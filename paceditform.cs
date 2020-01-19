using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using Newtonsoft.Json.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GFBattleTester_v2
{
    public partial class paceditform : Form
    {
        bool edited = false;
        JArray jsondb = new JArray();
        public paceditform()
        {
            InitializeComponent();
        }

        private void paceditform_Load(object sender, EventArgs e)
        {
            jsondb =JArray.Parse(File.ReadAllText(@"data\pac\pac.json"));
            initdb();
        }
        void initdb()
        {
            dataGridView1.Rows.Clear();
            foreach (JObject a in jsondb)
            {
                dataGridView1.Rows.Add(new string[] { a["domain"].ToString(), a["route"].ToString() });
            }
        }
        private void Addbutton_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(1);
        }

        private void resetbutton_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                jsondb.Clear();
                JObject a = new JObject();
                a.Add("domain", "gf-game.girlfrontline.co.kr");
                a.Add("route", Form1.frm.serveripaddr);
                jsondb.Add(a);
                StringBuilder jsbuilder = new StringBuilder();
                jsbuilder.Append("function FindProxyForURL(url, host) {");
                jsbuilder.Append("if (dnsDomainIs(host, \"gf-game.girlfrontline.co.kr\")){");
                jsbuilder.Append(string.Format("return \"PROXY {0}\";", Form1.frm.serveripaddr) + "}");
                jsbuilder.Append("else{ return \"DIRECT\";}}");
                File.WriteAllText(@"data/pac/pac.json", jsondb.ToString());
                File.WriteAllText(@"data/pac/pac.js", jsbuilder.ToString());
                initdb();
                MessageBox.Show("Completed", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                edited = false;
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dataGridView1.SelectedRows.Count > 0)
            {
                delbutton.Enabled = true;                
            }
            else
            {
                delbutton.Enabled = false;
            }
        }

        private void delbutton_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                dataGridView1.Rows.RemoveAt(row.Index);
            }
        }
 
        private void Savebutton_Click(object sender, EventArgs e)
        {
            jsondb.Clear();
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if(row.Cells["dnsDomain"].Value != null)
                {                  
                    JObject n = new JObject();
                    n.Add("domain", row.Cells["dnsDomain"].Value.ToString());
                    n.Add("route", row.Cells["route"].Value.ToString());
                    jsondb.Add(n);
                 }
            }
            StringBuilder jsbuilder = new StringBuilder();
            jsbuilder.Append("function FindProxyForURL(url, host) {");
            for(int i=0; i<jsondb.Count(); i++)
            {
                if (i == 0)
                    jsbuilder.Append(string.Format("if (dnsDomainIs(host, \"{0}\"))",jsondb[i]["domain"])+"{");
                else
                    jsbuilder.Append(string.Format("else if (dnsDomainIs(host, \"{0}\"))", jsondb[i]["domain"].ToString()) + "{");
                jsbuilder.Append(string.Format("return \"PROXY {0}\";", jsondb[i]["route"].ToString())+"}");
            }
            jsbuilder.Append("else{ return \"DIRECT\";}}");
            File.WriteAllText(@"data/pac/pac.json", jsondb.ToString());
            File.WriteAllText(@"data/pac/pac.js", jsbuilder.ToString());
            MessageBox.Show("Saved","Success",MessageBoxButtons.OK,MessageBoxIcon.Information);
            edited = false;
        }

        private void dataGridView1_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            if(dataGridView1.Rows.Count > 0)
            {
                Savebutton.Enabled = true;
                edited = true;
            }               
            else
                Savebutton.Enabled = false;
        }

        private void paceditform_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (edited)
            {
                if(MessageBox.Show( "You have unsaved items. Are you sure to exit?","Confirm",MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }

        private void paceditform_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F1:
                    resetbutton_Click(null, null);
                    break;
                case Keys.F2:
                    Addbutton_Click(null, null);
                    break;
                case Keys.Delete:
                    delbutton_Click(null, null);
                    break;
                case Keys.F4:
                    Savebutton_Click(null, null);
                    break;
            }
        }
    }
}
