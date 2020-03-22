using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Net;
using System.Net.Sockets;
using System.Windows.Forms;
using System.IO;
using Tulpep.NotificationWindow;
using neo365.Server.Http;

namespace GFBattleTester_v2
{
    public partial class Form1 : Form
    {
        JObject enemy_team_info = new JObject();
        JObject enemy_character_info = new JObject();
        List<string> mission_name_list = new List<string>();
        public string signkey = "우중비모";
        private Thread DaemonThread;
        private ServerProcess httpServer;
        public bool IsServerStart = false;
        public string serveripaddr = "192.168.0.13";
        public int servport = 80;
        public List<string> gunNameID = new List<string>();
        public JArray gundb = new JArray();
        public string[] type_string = { "hg", "smg", "rf", "ar", "mg", "sg" };
        public static Form1 frm;
        public string uid = "20139";
        public JObject userdata = new JObject();
        public JObject homedata = new JObject();
        public int gun_id_db = 1;
        public long[] gun_exp_table = {0,100,300,600,1000,1500,2100,2800,3600,4500,5500,6600,7800,9100,
        10500,12000,13600,15300,17100,19000,21000,23100,25300,27600,30000,32500,35100,37900,41000,44400,
        48600,53200,58200,63600,69400,75700,82400,89600,97300,105500,114300,123600,133500,144000,155100,
        166900,179400,192500,206400,221000,236400,252500,269400,287200,305800,325300,345700,367000,389300,
        412600,436900,462200,488500,515900,544400,574000,604800,636800,670000,704400,749500,796300,844900,
        895300,947500,1001500,1057400,1115300,1175100,1236900,1300800,1366800,1434900,1505200,1577800,
        1652600,1729700,1809200,1891100,1975400,2088000,2204100,2323600,2446700,
        2573400,2703800,2837900,2975800,3117600,3263300,
        3363300,3483300,3623300,3783300,3963300,
        4163300,4383300,4623300,4903300,5263300,
        5743300,6383300,7283300,8483300,10083300,
        12283300,15283300,19283300,24283300,30823300}; //thanks to dice1024
        public int[] gun_position = { 0, 7, 12, 17, 8, 13, 18, 9, 14, 19 };
        public List<string> gunNameCsv = new List<string>();
        public List<int> GeneratedgunIDs = new List<int>();
        BindingSource bs = new BindingSource();
        
        public Form1()
        {
            frm = this;
            InitializeComponent();           
            CheckForIllegalCrossThreadCalls = false;          
        }
        public void notification_show (string title, string data)
        {
            this.Invoke((MethodInvoker)delegate
            {
                PopupNotifier pop = new PopupNotifier();
                pop.TitleFont = this.Font;             
                pop.TitleText ="[GFBT]" + title;
                pop.ContentText = data;
                pop.ContentFont = this.Font;
                pop.Popup();
            });           
        }
        /*protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            this.Hide();
        }*/
        private void HttpServer_Reqeust(object sender, HttpRequestEventArgs e)
        {
            indicater_blink_RX();
            //log_textbox(string.Format("Request\n\rHost: {0}", e.Request.Headers["Host"])+Environment.NewLine+
            //    String.Format("URL: {0}", e.Request.Url)+Environment.NewLine+
            //    String.Format("User-Agent: {0} ", e.Request.Headers["User-Agent"]));
            log_textbox(e.Request.Method+" " + e.Request.Url); 
            if (e.Request.GetParameters.Count > 0)
            {
                log_textbox("GET " +e.Request.Url);
                /*foreach (string key in e.Request.GetParameters.AllKeys)
                {
                    log_textbox(String.Format("KEY: {0} | VALUE: {1}", key, e.Request.GetParameters[key]));
                }*/
            }
            if (e.Request.PostParameters.Count > 0)
            {
                log_textbox("POST " + e.Request.Url);
                /*foreach (string key in e.Request.PostParameters.AllKeys)
                {
                    log_textbox(String.Format("KEY: {0} | VALUE: {1}", key, e.Request.PostParameters[key]));
                }
                log_textbox("[Body Contents]"+Environment.NewLine+e.Request.Postbody_str);*/
            }

        }
        public string GenerateRandomID()
        {
            Random r = new Random();
            int id = r.Next(1, 999999999);
            foreach(int i in GeneratedgunIDs)
            {
                if(i == id)
                {
                    id = r.Next(1, 999999999);
                }
            }
            GeneratedgunIDs.Add(id);
            return id.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            string mission = File.ReadAllText("data/db/csv/mission.b64");
            // mission = Encoding.UTF8.GetString(Convert.FromBase64String(mission));
            mission_name_list = mission.Split('\n').ToList();
            JObject spotinfo = JObject.Parse(File.ReadAllText(@"data/db/json/spot_info.json"));
            enemy_team_info = JObject.Parse(File.ReadAllText(@"data/db/json/enemy_team_info.json"));
            enemy_character_info = JObject.Parse(File.ReadAllText(@"data/db/json/enemy_character_type_info.json"));
            server_togglebtn.Text = Properties.Strings.serverstart;
            tabControl1.TabPages["informationpage"].Text = Properties.Strings.tapPage_info;
            tabControl1.TabPages["dollsettingpage"].Text = Properties.Strings.tapPage_gunsett;
            tabControl1.TabPages["equipsettingpage"].Text = Properties.Strings.tapPage_equipsett;
            tabControl1.TabPages["fairysettingpage"].Text = Properties.Strings.tapPage_fairysett;
            tabControl1.TabPages["serversettingpage"].Text = Properties.Strings.tapPage_serversett;
            tr_RX.Text = Properties.Strings.indicater_rx;
            tr_TX.Text = Properties.Strings.indicater_tx;
            //tabControl1.TabPages.Remove(tabControl1.TabPages[4]);
            ind_RX_timer.Start();
            ind_TX_timer.Start();
            serveripaddrtextbox.Text = GetLocalIP();
            gunNameCsv.AddRange(File.ReadAllLines("data/db/csv/guns.b64"));
            userdata = JObject.Parse(File.ReadAllText("data/db/json/userinfo.json"));
            homedata = JObject.Parse(File.ReadAllText("data/db/json/home.json"));
            JArray userdata_guninfo = JArray.Parse(userdata["gun_with_user_info"].ToString());
            gundb = JArray.Parse(File.ReadAllText("data/db/json/dolls.json"));
            gundb.Merge(JArray.Parse(File.ReadAllText("data/db/json/dolls_missing.json")));
            enemy_list_gridview.Columns[0].ValueType = typeof(int);
            foreach (string name in gunNameCsv)
            {
                string[] t = name.Split(',');
                if (t[0].StartsWith("gun-1"))
                {
                    gunNameID.Add(string.Format("{0},{1}", t[1], t[0].Substring(5)));
                }

            }
            foreach (JObject a in userdata_guninfo)
            {
                add_gun_list(a);
                GeneratedgunIDs.Add(Convert.ToInt32(a["id"]));
            }
            MicaSecurityTools.init();
            server_status_text.Text = "停止";
            #region datagridview 전역/적 정보 리스트 추가 부분
            foreach (var item in enemy_team_info)
            {
                string enemyID = enemy_team_info[item.Key]["id"].ToString();
                string enemyLeaderID = enemy_team_info[enemyID]["enemy_leader"].ToString();

                //string membernames = string.Empty;
                JArray a = JArray.Parse(enemy_team_info[enemyID]["member_ids"].ToString());
                if (enemyLeaderID != "0")
                {
                    /*
                    for(int i=0; i<a.Count; i++)
                    {
                        string id = a[i].ToString();
                        if(enemy_character_info.ContainsKey(id))
                        {
                            if (i == a.Count - 1)
                                membernames += enemy_character_info[id]["code"].ToString();
                            else
                                membernames += enemy_character_info[id]["code"].ToString() + ",";
                        }
                        else
                        {
                            if (i == a.Count - 1)
                                membernames += id;
                            else
                                membernames += id + ",";
                        }

                    }*/
                    string missionspotname = string.Empty;
                    if (int.Parse(enemy_team_info[enemyID]["spot_id"].ToString()) > 0)
                    {
                        missionspotname = CodeToMissionName(int.Parse(spotinfo[enemy_team_info[enemyID]["spot_id"].ToString()]["mission_id"].ToString()));
                    }
                    else
                        missionspotname = "-";
                    string[] enemyinfo = { enemyID, enemy_character_info[enemyLeaderID]["code"].ToString(), enemy_character_info[enemyLeaderID]["boss_hp"].ToString(),
                         enemy_character_info[enemyLeaderID]["maxlife"].ToString(),missionspotname/*membernames*/};
                    enemy_list_gridview.Rows.Add(enemyinfo);
                    
                }
                //enemyGrpID.Add(enemyID);
                //enemy_team_id_combobox.Items.Add(enemyID);


            }
            bs.DataSource = enemy_list_gridview.DataSource;
            #endregion
        }
        public string CodeToMissionName(int code)
        {
            string name = string.Empty;
            for (int i = 0; i < mission_name_list.Count(); i++)
            {
                string temp = mission_name_list[i].Split('-')[1];

                if (temp.Substring(0, 1) != "2")
                {
                    int c = int.Parse(temp.Split(',')[0].Substring(1));
                    if (c == code)
                    {
                        name = temp.Split(',')[1];
                        return name;
                    }
                }

            }
            return "-";
        }
        private void ListView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
       
        private void Button3_Click(object sender, EventArgs e)
        {
            gunselector_show();
        }
        void gunselector_show(JObject o)
        {
            gunselector gs = new gunselector(o);
            gs.FormCloseEvent += new gunselector.FormCloseEventHandler(gunselector_RecieveData);
            gs.Show();
           // tabControl1.TabPages.Add(tabControl1.TabPages[4]);
        }
        void gunselector_show()
        {
            gunselector gs = new gunselector(null);
            gs.FormCloseEvent += new gunselector.FormCloseEventHandler(gunselector_RecieveData);
            gs.Show();
        }
        void gunselector_RecieveData(JObject o)
        {
            //MessageBox.Show(o.ToString());
            if(o["id"].ToString() == "0")
            {
                o["id"] = GenerateRandomID();
                add_gun_list(o);
                addGuntoUserinfo(o);
            }
        }
        public void addGuntoUserinfo(JObject gunobjectjson)
        {            
            ((JArray)userdata["gun_with_user_info"]).Add(gunobjectjson);           
        }

        private void server_background_DoWork(object sender, DoWorkEventArgs e)
        {

        }
        public void add_gun_list(JObject o)
        {
            string id = o["id"].ToString();
            string gunid = o["gun_id"].ToString();
            //JObject db = getGunInfoFromDB(gunid);
            string name = getgunKRNAme(gunid);
            string level = o["gun_level"].ToString();
            string health = o["life"].ToString();
            string teamid = o["team_id"].ToString();
            string inteamlocation = o["location"].ToString();
            string pos = o["position"].ToString();
            string power = o["pow"].ToString();
            string mre = o["mre"].ToString();
            string ammo = o["ammo"].ToString();
            string hit = o["hit"].ToString();
            string dodge = o["dodge"].ToString();
            string rate = o["rate"].ToString();
            string sk1lv = o["skill1"].ToString();
            string sk2lv = o["skill2"].ToString();
            string num = o["number"].ToString();
            string favor = (Convert.ToInt32(o["favor"]) / 10000).ToString();
            string oath = Convert.ToBoolean(Convert.ToInt16(o["soul_bond"])).ToString();

            ListViewItem dbs = new ListViewItem(new string[] {
                    id,gunid,name,teamid, Array.IndexOf(gun_position, int.Parse(pos)).ToString(),inteamlocation,level,health,power,dodge,rate,hit,num,sk1lv,sk2lv,favor,oath,mre,ammo
                }) ;
            listView1.Items.Add(dbs);
        }
        public string getgunID(string name)
        {
            foreach (string n in Form1.frm.gunNameID)
            {
                if (name.Contains(n.Split(',')[0]))
                {
                    return n.Split(',')[1];
                }
            }
            return null;
        }
        public string getgunKRNAme(string id)
        {
            foreach (string n in gunNameID)
            {
                if (int.Parse(id) == int.Parse(n.Split(',')[1]))
                {
                    return n.Split(',')[0];
                }
            }
            return null;
        }
        public JObject getGunInfoFromDB(string id)
        {
            if (id.Length == 5 && id.StartsWith("2"))
            {
                foreach (JObject a in gundb)
                {
                    if (a["id_index"].ToString() == (int.Parse(id) - 20000).ToString())
                    {
                        if(a["api_name"].ToString().Contains("mod"))
                            return a;
                    }
                }
            }
            else
            {
                foreach (JObject a in gundb)
                {

                    if (a["id_index"].ToString() == id)
                    {
                        return a;
                    }
                }
            }
            
            return null;
        }
        public JObject getGunInfoFromDB(int id)
        {
            return getGunInfoFromDB(id.ToString());
        }
        public JObject getGunDefaultStat(int gunNum, int gunID, int lev)
        {
            int level = lev;
            int growratio = 0;
            JObject grow = JObject.Parse(File.ReadAllText("data/db/json/dollGrow.json"));
            JObject attribute = JObject.Parse(File.ReadAllText("data/db/json/dollAttribute.json"));
            JObject stats = new JObject();
            JObject basicstats = new JObject();
            JObject growStats = new JObject();
            JObject newStats = new JObject();
            string type = string.Empty;
            string name = string.Empty;
            double favorRatio = 0.0;
            /*
            if (favor < 10)
                favorRatio = -0.05;
            else if (favor < 90)
                favorRatio = 0;
            else if (favor < 140)
                favorRatio = 0.05;
            else if (favor < 190)
                favorRatio = 0.1;
            else
                favorRatio = 0.15;*/

            try
            {
                for (int i = 0; i < Form1.frm.gundb.Count; i++)
                {
                    string t = Form1.frm.gundb[i]["id_index"].ToString();
                    if (t == gunID.ToString())
                    {
                        type = Form1.frm.type_string[Convert.ToInt32(Form1.frm.gundb[i]["type"]) - 1];
                        name = Form1.frm.gundb[i]["api_name"].ToString();
                        growratio = int.Parse(Form1.frm.gundb[i]["growth_rating"].ToString());
                        //stats = (JObject)gundb[i]["stats"];
                        JObject tempstat = new JObject();
                        tempstat.Add("hp", Form1.frm.gundb[i]["hp"]);
                        tempstat.Add("pow", Form1.frm.gundb[i]["fp"]);
                        tempstat.Add("hit", Form1.frm.gundb[i]["acc"]);
                        tempstat.Add("dodge", Form1.frm.gundb[i]["eva"]);
                        //tempstat.Add("speed", gundb[i]["hp"]);
                        tempstat.Add("rate", Form1.frm.gundb[i]["rof"]);
                        tempstat.Add("armor", Form1.frm.gundb[i]["armor"]);
                        tempstat.Add("crit", Form1.frm.gundb[i]["crit"]);
                        stats = new JObject(tempstat);
                        if (level <= 100)
                        {
                            basicstats = (JObject)grow["normal"]["basic"];
                            growStats = (JObject)grow["normal"]["grow"];
                        }
                        else
                        {
                            basicstats = (JObject)grow["after100"]["basic"];
                            growStats = (JObject)grow["after100"]["grow"];
                        }
                        break;
                    }
                }
                newStats = new JObject(stats);
                foreach (var keys in basicstats.Properties())
                {

                    newStats[keys.Name] = basicstats[keys.Name].Count() > 1 ?
                        Math.Ceiling((Convert.ToDecimal(basicstats[keys.Name][0]) + (Convert.ToDecimal(level - 1) * Convert.ToDecimal(basicstats[keys.Name][1]))) * Convert.ToDecimal(attribute[type][keys.Name]) * Convert.ToDecimal(stats[keys.Name]) / 100) :
                        Math.Ceiling(Convert.ToDecimal(basicstats[keys.Name][0]) * Convert.ToDecimal(attribute[type][keys.Name]) * Convert.ToDecimal(stats[keys.Name]) / 100);

                    //newStat[key] = math.ceil((basicStats[key][0] + ((self.level - 1) * basicStats[key][1])) * attribute[self.type][key] * stats[key] / 100) if len(basicStats[key]) > 1 
                    //else math.ceil(basicStats[key][0] * attribute[self.type][key] * stats[key] / 100)
                }

                foreach (var keys in growStats.Properties())
                {
                     newStats[keys.Name] = Convert.ToDecimal(newStats[keys.Name]) + Math.Ceiling((Convert.ToDecimal(growStats[keys.Name][1]) + Convert.ToDecimal(level - 1) * Convert.ToDecimal(growStats[keys.Name][0])) * Convert.ToDecimal(attribute[type][keys.Name]) * Convert.ToDecimal(stats[keys.Name]) * Convert.ToDecimal(growratio) / 100 / 100);
                    //newStat[key] += math.ceil(growStats[key][1] + ((self.level - 1) * growStats[key][0]) * attribute[self.type][key] * stats[key] * growRatio / 100 / 100)

                }

                newStats["hp"] = int.Parse(newStats["hp"].ToString()) * gunNum;
                return newStats;
            }
            catch (NullReferenceException)
            {
                return JObject.Parse("{'hp':0,'pow':0,'hit':0,'dodge':0,'speed':0,'rate':0,'armorPiercing':0,'crit':0}");
            }

        }

        public JObject getGunInfoFromUserdata(string id)
        {
            foreach(JObject a in (JArray)userdata["gun_with_user_info"])
            {
                if (a["id"].ToString() == id)
                    return a;
            }
            return null;
        }
        public JObject getGunInfoFromUserdata(int id)
        {
            return getGunInfoFromUserdata(id.ToString());
        }
        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (listView1.SelectedItems.Count == 1)
            {
                ListView.SelectedListViewItemCollection items = listView1.SelectedItems;
                ListViewItem subitem = items[0];
                gunselector_show(getGunInfoFromUserdata(subitem.SubItems[0].Text));
            }
        }
        public long UnixTimeNow()
        {
            var timeSpan = (DateTime.Now - new DateTime(1970, 1, 1, 0, 0, 0));
            return (long)timeSpan.TotalSeconds;
        }
        public string GetLocalIP()
        {
            string myIP = "";
            IPHostEntry host = Dns.GetHostEntry(Dns.GetHostName());

            foreach (IPAddress ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    myIP = ip.ToString();
                }
            }

            return myIP;
        }
        private void server_togglebtn_Click(object sender, EventArgs e)
        {         
            if (!IsServerStart)
            {
                try{
                    httpServer = new ServerProcess(this, servport, serveripaddr);
                    httpServer.Reqeust += HttpServer_Reqeust;
                    DaemonThread = new Thread(new ThreadStart(httpServer.listen));
                    DaemonThread.Start();
                    log_textbox("Started Server");
                    server_status_text.Text = string.Format(Properties.Strings.runningServer, serveripaddr +":" + servport);
                    IsServerStart = true;
                    notification_show(Properties.Strings.notification,string.Format(Properties.Strings.server_started_alert, serveripaddr+":"+ servport));
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            else
            {
                try
                {
                    if (DaemonThread != null)
                    {
                        if (DaemonThread.IsAlive)
                        {
                            httpServer.Stop();
                        }
                    }
                }
                catch (Exception)
                {
                }
                IsServerStart = false;
                log_textbox("Server Stopped");
                server_status_text.Text = Properties.Strings.server_paused;
            }
            server_togglebtn.Text = IsServerStart ? Properties.Strings.serverstop : Properties.Strings.serverstart;
            serveripaddrtextbox.Enabled = !IsServerStart;
            serverport.Enabled = !IsServerStart;
        }
        public JObject GenerateNewGun(string id, string gunid_index)
        {
            JObject o = new JObject();
            o.Add("id", id);
            o.Add("user_id", uid);
            o.Add("gun_id", gunid_index);
            o.Add("gun_exp", "0");
            o.Add("gun_level", "1");
            o.Add("team_id", "0");
            o.Add("if_modification", "0");
            o.Add("location", "0");
            o.Add("position", "0");
            o.Add("life", "0");
            o.Add("ammo", "120");
            o.Add("mre", "120");
            o.Add("pow", "0");
            o.Add("hit", "0");
            o.Add("dodge", "0");
            o.Add("rate", "0");
            o.Add("skill1", "1");
            o.Add("skill2", "0");
            o.Add("fix_end_time", "0");
            o.Add("is_locked", "1");
            o.Add("number", "1");
            o.Add("equip1", "0");
            o.Add("equip2", "0");
            o.Add("equip3", "0");
            o.Add("equip4", "0");
            o.Add("favor", "500000");
            o.Add("max_favor", "1000000");
            o.Add("favor_toplimit", "2000000");
            o.Add("soul_bond", "0");
            o.Add("skin", "0");
            o.Add("can_click", "1");
            o.Add("soul_bond_time", "0");
            o.Add("special_effect", "0");
            return o;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DaemonThread != null)
            {
                if (DaemonThread.IsAlive)
                {
                    httpServer.Stop();
                }

                DaemonThread.Abort();
            }
        }
        public void log_textbox(string log)
        {
            logTextbox.AppendText(string.Format("[{0}]{1}{2}", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),log,Environment.NewLine));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(userdata.ToString());
        }
        public void addResource(int mp,int ammo,int mre,int part)
        {
            Random n = new Random();
            JObject mail = new JObject();
            mail.Add("id", n.Next(1, 99999999).ToString()); ;
            mail.Add("user_id", "0");
            mail.Add("type", "6");
            mail.Add("sub_id", "0");
            mail.Add("user_exp", "0");
            mail.Add("mp", mp.ToString());
            mail.Add("ammo", ammo.ToString());
            mail.Add("mre", mre.ToString());
            mail.Add("part", part.ToString());
            mail.Add("core", "0");
            mail.Add("gem", "0");
            mail.Add("gun_id", "0");
            mail.Add("fairy_ids", "");
            mail.Add("item_ids", "");
            mail.Add("equip_ids", "");
            mail.Add("furniture", "");
            mail.Add("gift", "");
            mail.Add("coins", "");
            mail.Add("skin", "0");
            mail.Add("commander_uniform", "");
            mail.Add("bp_pay", "0");
            mail.Add("chip", "");
            mail.Add("title", "GiveResource");
            mail.Add("content", "");
            mail.Add("code", "");
            mail.Add("start_time", MicaSecurityTools.GetCurrentTimeStamp().ToString());
            mail.Add("end_time", "2100000000");
            mail.Add("if_read", "0");
            ((JArray)homedata["index_getmaillist"]).Add(mail);
        }

        public void addGuns(int id)
        {
            Random n = new Random();
            JObject mail = new JObject();
            mail.Add("id", n.Next(1, 99999999).ToString()); ;
            mail.Add("user_id", "0");
            mail.Add("type", "6");
            mail.Add("sub_id", "0");
            mail.Add("user_exp", "0");
            mail.Add("mp", "0");
            mail.Add("ammo", "0");
            mail.Add("mre", "0");
            mail.Add("part", "0");
            mail.Add("core", "0");
            mail.Add("gem", "0");
            mail.Add("gun_id", id.ToString());
            mail.Add("fairy_ids", "");
            mail.Add("item_ids", "");
            mail.Add("equip_ids", "");
            mail.Add("furniture", "");
            mail.Add("gift", "");
            mail.Add("coins", "");
            mail.Add("skin", "0");
            mail.Add("commander_uniform", "");
            mail.Add("bp_pay", "0");
            mail.Add("chip", "");
            mail.Add("title", string.Format("GiveGuns {0}",id.ToString()));
            mail.Add("content", "");
            mail.Add("code", "");
            mail.Add("start_time", MicaSecurityTools.GetCurrentTimeStamp().ToString());
            mail.Add("end_time", "2100000000");
            mail.Add("if_read", "0");
            ((JArray)homedata["index_getmaillist"]).Add(mail);
        }
        private void causeErrorNext_CheckedChanged(object sender, EventArgs e)
        {

        }
        public void indicater_blink_RX()
        {
            tr_RX.BackColor = Color.Red;
            //ind_RX_timer.Start();
        }
        public void indicater_blink_TX()
        {
            tr_TX.BackColor = Color.LimeGreen;
            //ind_TX_timer.Start();
        }
        private void ind_TX_timer_Tick(object sender, EventArgs e)
        {
            tr_TX.BackColor = SystemColors.Control;
            //ind_TX_timer.Stop();
        }

        private void ind_RX_timer_Tick(object sender, EventArgs e)
        {
            tr_RX.BackColor = SystemColors.Control;
            //ind_RX_timer.Stop();
        }

        private void sendmailbtn_Click(object sender, EventArgs e)
        {
            SendMail sm = new SendMail();
            sm.FormCloseEvent += new SendMail.FormCloseEventHandler(mailer_close);
            sm.Show();
        }
        private void mailer_close(JObject o)
        {
            ((JArray)homedata["index_getmaillist"]).Add(o);
            //Clipboard.SetText(homedata.ToString());
        }

        private void serveripaddrtextbox_TextChanged(object sender, EventArgs e)
        {
            serveripaddr = serveripaddrtextbox.Text;
        }

        private void serverport_ValueChanged(object sender, EventArgs e)
        {
            servport = (int)serverport.Value;
        }

        private void editpacbutton_Click(object sender, EventArgs e)
        {
            paceditform edit = new paceditform();
            edit.Show();
        }

        private void enemysearchtextBox_TextChanged(object sender, EventArgs e)
        {
            
             if (enemysearchtextBox.Text.Length > 0)
             {
                //(enemy_list_gridview.DataSource as DataTable).DefaultView.RowFilter = string.Format("Leader = '{0}'", enemysearchtextBox.Text);
                //string rowFilter = string.Format("OR [{0}] = '{1}'", enemy_list_gridview.Columns[1].HeaderText, enemysearchtextBox.Text);
                //(enemy_list_gridview.DataSource as DataTable).DefaultView.RowFilter = rowFilter;
                bs.Filter = string.Format("{0} LIKE '%{1}%'", enemy_list_gridview.Columns[1].HeaderText, enemysearchtextBox.Text);
                enemy_list_gridview.DataSource = bs;

            }
             else if(enemysearchtextBox.Text.Length == 0){
                 // bs.DataSource = enemy_list_gridview.DataSource;
                 bs.RemoveFilter();
                 enemy_list_gridview.DataSource = bs;
             }
            

        }

        private void enemy_list_gridview_SortCompare(object sender, DataGridViewSortCompareEventArgs e)
        {
            if(e.Column.Index != 1 && e.Column.Index != 4)
            {
                int a = int.Parse(e.CellValue1.ToString()), b = int.Parse(e.CellValue2.ToString());
                e.SortResult = a.CompareTo(b);
                e.Handled = true;
            }
           
        }
    }
  
}
