using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;

namespace GFBattleTester_v2
{
    public partial class gunselector : Form
    {
        public delegate void FormCloseEventHandler(JObject json);
        public event FormCloseEventHandler FormCloseEvent;
        JObject dataFromform1 = null;
        public gunselector(JObject o)
        {
            InitializeComponent();
            if (o != null)
            {
                dataFromform1 = new JObject(o);
            }
        }
        public int selectedGuns = 0;
        private static int CurrentIndex
        {
            get;
            set;
        }
        private ListViewItem FindItem(string keyword, int startIndex)
        {
            for (int i = startIndex; i < listView1.Items.Count; i++)
            {
                ListViewItem item = listView1.Items[i];
                int id = -1;
                bool isID = int.TryParse(keyword, out id);
                bool isContains = item.SubItems[1].Text.Contains(keyword);
                if (isID)
                    isContains = item.SubItems[0].Text.Contains(int.Parse(keyword).ToString()); 
                if (isContains) { return item; }
            }
            return null;
        }
        private void SelectItem(ListViewItem item)
        {
            CurrentIndex = item.Index;
            listView1.MultiSelect = false;
            item.Selected = true;
            listView1.Select();
            listView1.MultiSelect = true;
        }

        private void gunselector_Load(object sender, EventArgs e)
        {
            stat_teamid.SelectedIndex = 0;
            stat_inteamlocation.SelectedIndex = 0;
            AutoCompleteStringCollection src = new AutoCompleteStringCollection();
            foreach(string name in Form1.frm.gunNameCsv)
            {
                string[] t = name.Split(',');
                if (t[0].StartsWith("gun-1"))
                {
                    src.Add(t[1]);
                }
                
                
            }
            foreach(JObject guns in Form1.frm.gundb)
            {
                string id = guns["id_index"].ToString();
                string name = Form1.frm.getgunKRNAme(id);
                string codename = guns["api_name"].ToString();
                string type = Form1.frm.type_string[int.Parse(guns["type"].ToString())-1];
                string rank = rankToStars(int.Parse(guns["rarity"].ToString()));
                if (Convert.ToBoolean(guns["mod"]))
                {
                    id = (int.Parse(id) + 20000).ToString();
                    name = name + "(Mod)";
                }
                ListViewItem dbs = new ListViewItem(new string[] {
                    id,name,codename,type,rank
                }) ;
                listView1.Items.Add(dbs);
            }
            gunNametextbox.AutoCompleteCustomSource = src;
            if(dataFromform1 != null)
            {
                load_stats(dataFromform1);
            }
        }
        
        private void searchbtn_Click(object sender, EventArgs e)
        {
            string searchitem;
            if (Form1.frm.getgunID(gunNametextbox.Text) != null)
                searchitem = Form1.frm.getgunID(gunNametextbox.Text);
            else
                searchitem = gunNametextbox.Text;

            ListViewItem item = FindItem(searchitem, 0);

            if (item == null)
                MessageBox.Show("検索結果がありません。");
            else
            {
                SelectItem(item);
                listView1.EnsureVisible(item.Index);
            }
                
        }

        private void gunNametextbox_TextChanged(object sender, EventArgs e)
        {

        }
        public string rankToStars(int a)
        {
            string s = "";
            for(int i = 0; i < a; i++)
            {
                s += "★";
            }
            return s;
        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (listView1.SelectedItems.Count == 1)
            {
                applybtn.Enabled = true;
                calc_stat();
                stat_groupbox.Enabled = true;
                ListView.SelectedListViewItemCollection items = listView1.SelectedItems;
                ListViewItem subitem = items[0];
                stat_groupbox.Text = string.Format("{0}/{1}({2})",subitem.SubItems[1].Text, subitem.SubItems[2].Text, subitem.SubItems[0].Text);
                if (checkifmod(subitem.SubItems[0].Text))
                {
                    stat_level.Maximum = 120;
                }
                else
                {
                    stat_level.Maximum = 100;
                }
                selectedGuns = Convert.ToInt32(subitem.SubItems[0].Text);
            }
        }
        void load_stats(JObject o)
        {
            JObject db = new JObject(Form1.frm.getGunInfoFromDB(o["gun_id"].ToString()));
            stat_groupbox.Enabled = true;
            stat_groupbox.Text = stat_groupbox.Text = string.Format("{0}/{1}({2});{3}", Form1.frm.getgunKRNAme(o["gun_id"].ToString()),
                db["api_name"], o["gun_id"].ToString(),o["id"].ToString());
            applybtn.Enabled = true;
            selectedGuns = Convert.ToInt32(o["gun_id"]);
            stat_level.Value = int.Parse(o["gun_level"].ToString());
            stat_hp.Value = int.Parse(o["life"].ToString());
            stat_fire.Value = int.Parse(o["pow"].ToString());
            stat_rate.Value = int.Parse(o["rate"].ToString());
            stat_hit.Value = int.Parse(o["hit"].ToString());
            stat_dodge.Value = int.Parse(o["dodge"].ToString());
            stat_num.Value = int.Parse(o["number"].ToString());
            stat_pos.Value = Array.IndexOf(Form1.frm.gun_position, int.Parse(o["position"].ToString()));
            stat_favor.Value = int.Parse(o["favor"].ToString())/10000;
            stat_skill1.Value = int.Parse(o["skill1"].ToString());
            stat_skill2.Value = int.Parse(o["skill2"].ToString());
            stat_ammo.Value = int.Parse(o["ammo"].ToString());
            stat_mre.Value = int.Parse(o["mre"].ToString());
            stat_teamid.SelectedIndex = int.Parse(o["team_id"].ToString());
            stat_inteamlocation.SelectedIndex = int.Parse(o["location"].ToString())-1;
        }
        private void stat_groupbox_Enter(object sender, EventArgs e)
        {

        }

        private void stat_autocalc_CheckedChanged(object sender, EventArgs e)
        {

        }
       
        private void stat_level_ValueChanged(object sender, EventArgs e)
        {
            calc_stat();
        }
        void calc_stat()
        {
            if (stat_autocalc.Checked)
            {
                int id = 0;
                if (checkifmod(selectedGuns))
                {
                    id = selectedGuns - 20000;
                }
                else
                {
                    id = selectedGuns;
                }                
                JObject newstat = new JObject(Form1.frm.getGunDefaultStat((int)stat_num.Value, id, (int)stat_level.Value));
                stat_fire.Value = Convert.ToDecimal(newstat["pow"].ToString());
                stat_hit.Value = Convert.ToDecimal(newstat["hit"].ToString());
                stat_hp.Value = Convert.ToDecimal(newstat["hp"].ToString());
                stat_dodge.Value = Convert.ToDecimal(newstat["dodge"].ToString());
                stat_rate.Value = Convert.ToDecimal(newstat["rate"].ToString());
            }
        }
       

        private void stat_num_ValueChanged(object sender, EventArgs e)
        {
            calc_stat();
        }
        public bool checkifmod(string id)
        {
            if (id.Length == 5 && id.StartsWith("2"))
                return true;
            return false;
        }
        public bool checkifmod(int id)
        {
            return checkifmod(id.ToString());
        }
        public string getModState(int lv)
        {
            if (lv < 110)
                return "1";
            else if (lv < 115)
                return "2";
            else if (lv <= 120)
                return "3";
            else
                return "0";
        }
        private void applybtn_Click(object sender, EventArgs e)
        {
            JObject o = new JObject();
            o.Add("id", "0");
            o.Add("user_id", Form1.frm.uid);
            o.Add("gun_id", selectedGuns.ToString());
            o.Add("gun_exp", Form1.frm.gun_exp_table[(int)stat_level.Value-1].ToString());
            o.Add("gun_level", stat_level.Value.ToString());
            o.Add("team_id",stat_teamid.SelectedIndex.ToString());
            o.Add("if_modification", checkifmod(selectedGuns) ? getModState((int)stat_level.Value) : "0");
            o.Add("location",(stat_inteamlocation.SelectedIndex+1).ToString());
            o.Add("position", Form1.frm.gun_position[(int)stat_pos.Value].ToString());
            o.Add("life",stat_hp.Value.ToString());
            o.Add("ammo", stat_ammo.Value.ToString()) ;
            o.Add("mre",stat_mre.Value.ToString());
            o.Add("pow",stat_fire.Value.ToString());
            o.Add("hit",stat_hit.Value.ToString());
            o.Add("dodge",stat_dodge.Value.ToString());
            o.Add("rate",stat_rate.Value.ToString());
            o.Add("skill1",stat_skill1.Value.ToString());
            o.Add("skill2",stat_skill2.Value.ToString());
            o.Add("fix_end_time","0");
            o.Add("is_locked","1");
            o.Add("number",stat_num.Value.ToString());
            o.Add("equip1","0");
            o.Add("equip2","0");
            o.Add("equip3","0");
            o.Add("equip4","0");
            o.Add("favor",(stat_favor.Value*10000).ToString());
            o.Add("max_favor","2000000");
            o.Add("favor_toplimit","2000000");
            o.Add("soul_bond", Convert.ToInt16(stat_oath.Checked).ToString()) ;
            o.Add("skin","0");
            o.Add("can_click","1");
            o.Add("soul_bond_time", stat_oath.Checked ? Form1.frm.UnixTimeNow().ToString() : "0");
            o.Add("special_effect","0");
            Close();
            this.FormCloseEvent(o);
            this.Dispose();
        }

        private void stat_teamid_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(stat_teamid.SelectedIndex == 0)
            {
                stat_inteamlocation.Enabled = false;
                //stat_inteamlocation.SelectedIndex = 0;
            }
            else
            {
                stat_inteamlocation.Enabled = true;
            }
        }
    }
}
