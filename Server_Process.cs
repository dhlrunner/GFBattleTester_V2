using neo365.Server.Http;
using System.ComponentModel;
using System.Text;
using Newtonsoft.Json.Linq;
using System.IO;
using System;
using System.Net;

namespace GFBattleTester_v2
{
    public class ServerProcess : CustomHttpServer
    {
        string defaultkey = "yundoudou";
        public static int[] current_develop = new int[16];
        int last_user_gun_id_info = 0;
        public ServerProcess(ISynchronizeInvoke syncObj, int port, string ip) : base(syncObj, port, ip)
        {
        }
        public static int gunid_generate()
        {
            //int[] Missinggun = { 30, 45, 67, 76, 83, 214, 219, 246, 256 };
            Random rd = new Random();
            int[] ids = new int[Form1.frm.gunNameID.Count];          

            for(int i= 0; i < Form1.frm.gunNameID.Count; i++)
            {
                string[] a = Form1.frm.gunNameID[i].Split(',');
                ids[i] = int.Parse(a[1]);
            }
            return ids[rd.Next(0,ids.Length)];
        }
        protected override byte[] ResponseProcess(HttpRequest request)
        {
            void log_clientdata(string s)
            {
                Form1.frm.logtextbox_clientrequest.AppendText(string.Format("[{0}]{1}{2}", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),s,Environment.NewLine));
            }
            void log_returndata(string s)
            {
                Form1.frm.logtextbox_clientresponce.AppendText(string.Format("[{0}]{1}{2}", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"), s, Environment.NewLine));
            }
            Form1.frm.indicater_blink_TX();
            string datafromclient = null;
            foreach (string key in request.PostParameters.AllKeys)
            {
                if(key == "outdatacode")
                {
                    datafromclient = MicaSecurityTools.Decode(request.PostParameters["outdatacode"],Form1.frm.signkey);
                    log_clientdata(datafromclient);
                }
                else if(key == "signcode")
                {
                    log_clientdata("Sign:"+request.PostParameters["signcode"]);
                }
            }
            if (request.Uri.ToString() == "/")
            {
                return Encoding.UTF8.GetBytes("Welcome! Simple Http Server");
            }                
            if (request.Uri.LocalPath == "/getpac/pac.js")
            {
                return Encoding.UTF8.GetBytes(File.ReadAllText(@"data/pac/pac.js"));
            }
                if (request.Uri.ToString().Contains(GF_URLs_KR.host)  && Form1.frm.causeErrorNext.Checked)
            {
                Form1.frm.causeErrorNext.Checked = false;
                return Encoding.UTF8.GetBytes("error:1");
            }           
            else if(request.Uri.ToString().Contains(GF_URLs_KR.index_version)){
                JObject outdata = new JObject();
                TimeSpan monthzero = (new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1, 0, 0, 0) - new DateTime(1970, 1, 1, 0, 0, 0));
                outdata.Add("now",Form1.frm.UnixTimeNow().ToString());
                outdata.Add("tomorrow_zero", (Form1.frm.UnixTimeNow() + (86400 - Form1.frm.UnixTimeNow() % 86400)).ToString());
                outdata.Add("month_zero", (long)monthzero.TotalSeconds);
                outdata.Add("next_month_zero",0);
                outdata.Add("timezone", "Asia / Seoul");
                outdata.Add("data_version", "6fe7682a59f7b2f014c079c2d3b87220");
                outdata.Add("client_version", "20399");
                outdata.Add("ab_version", "0");
                outdata.Add("is_kick", "0");
                outdata.Add("weekday", 4);
                outdata.Add("authentication_url", "http://127.0.0.1");
                return Encoding.UTF8.GetBytes(outdata.ToString());
            }

            else if (request.Uri.ToString().Contains(GF_URLs_KR.getToken))
            {
                JObject outdata = new JObject();
                outdata.Add("uid", Form1.frm.uid);
                outdata.Add("sign",Form1.frm.signkey);
                outdata.Add("is_username_exist", true);
                outdata.Add("app_guard_id", "");
                outdata.Add("real_name", 0);
                outdata.Add("authentication_url", "http://127.0.0.1");
                return Encoding.UTF8.GetBytes(MicaSecurityTools.EncodeWithGzip(outdata.ToString(),defaultkey));
            }
            else if (request.Uri.ToString().Contains(GF_URLs_KR.gundevelop))
            {
                JObject o = JObject.Parse(datafromclient);
                int slot = int.Parse(o["build_slot"].ToString()) - 1;
                current_develop[slot] = gunid_generate();
                string data = "{ \"gun_id\":\"" + current_develop[slot].ToString() + "\"}";               
                return Encoding.UTF8.GetBytes(MicaSecurityTools.EncodeWithGzip(data, Form1.frm.signkey));
            }
            else if (request.Uri.ToString().Contains(GF_URLs_KR.finishdevelop))
            {
                JObject o = JObject.Parse(datafromclient);
                int slot = int.Parse(o["build_slot"].ToString()) - 1;
                string gid = Form1.frm.GenerateRandomID();
                string data = "{ \"gun_with_user_add\":{ \"gun_with_user_id\":\"" + gid + "\",\"gun_id\":\"" + current_develop[slot].ToString() + "\"} }";        
                JObject newgun = new JObject(Form1.frm.GenerateNewGun(gid, current_develop[slot].ToString()));
                current_develop[slot] = 0;
                Form1.frm.add_gun_list(newgun);
                Form1.frm.addGuntoUserinfo(newgun);
                return Encoding.UTF8.GetBytes(MicaSecurityTools.EncodeWithGzip(data, Form1.frm.signkey));
            }
            else if (request.Uri.ToString().Contains(GF_URLs_KR.GetgundevelopCollectList))
            {
                StringBuilder data = new StringBuilder();
                for(int i= 0; i < current_develop.Length; i=i+2)
                {
                    data.Append(string.Format("スロット{0} [一般] {1}  [大型] {2}{3}",(i/2)+1,
                        Form1.frm.getgunKRNAme(current_develop[i].ToString()),
                        Form1.frm.getgunKRNAme(current_develop[i+1].ToString()),
                        Environment.NewLine
                        ));
                }
                return Encoding.UTF8.GetBytes(string.Format("error:202|[現在製造中リスト]{0}{1}",Environment.NewLine
                    ,data.ToString()));
            }
            else if(request.Uri.ToString().Contains("sn-list.girlfrontline.co.kr") && request.Uri.ToString().Contains(".txt"))
            {
                //Uri url = new Uri("http:" + request.Uri.ToString());
                WebClient wc = new WebClient();
                wc.Headers.Add("Accept-Encoding", "gzip");
                wc.Headers.Add("User-Agent", request.Headers["User-Agent"].ToString());
                wc.Headers.Add("X-Unity-Version", request.Headers["X-Unity-Version"].ToString());
                byte[] data = wc.DownloadData(request.Uri.ToString());
                return data;
            }
            else if (request.Uri.ToString().Contains("sn-list.girlfrontline.co.kr") && request.Uri.ToString().Contains("index.php"))
            {
                WebClient wc = new WebClient();
                wc.Headers.Add("Accept-Encoding", "gzip");
                wc.Headers.Add("Content-Type", request.Headers["Content-Type"].ToString());
                wc.Headers.Add("X-Unity-Version", request.Headers["X-Unity-Version"].ToString());
                byte[] reqdata = request.Postbody;
                byte[] data = wc.UploadData(request.Uri.ToString(),reqdata);
                return data;
            }
            else if (request.Uri.ToString().Contains(GF_URLs_KR.quickdevelop))
            {
                return  new byte[] { 0x31 };
            }
            else if (request.Uri.ToString().Contains(GF_URLs_KR.unlockgun))
            {
                return new byte[] { 0x31 };
            }
            else if (request.Uri.ToString().Contains(GF_URLs_KR.getuserinfo))
            {
                Form1.frm.userdata["user_record"]["attendance_type1_day"] = DateTime.Now.Day.ToString();
                Form1.frm.userdata["user_record"]["attendance_type1_time"] = (Form1.frm.UnixTimeNow() + (86400 - Form1.frm.UnixTimeNow() % 86400)).ToString();
                return Encoding.UTF8.GetBytes(MicaSecurityTools.EncodeWithGzip(Form1.frm.userdata.ToString(), Form1.frm.signkey));
            }
            else if (request.Uri.ToString().Contains(GF_URLs_KR.getdorminfo))
            {
                return Encoding.UTF8.GetBytes(MicaSecurityTools.EncodeWithGzip(File.ReadAllText("data/db/json/dorm.json"), Form1.frm.signkey));
            }
            else if (request.Uri.ToString().Contains(GF_URLs_KR.downloadsucsess))
            {
                return Encoding.UTF8.GetBytes("1");
            }
            else if (request.Uri.ToString().Contains(GF_URLs_KR.home))
            {
                
                return Encoding.UTF8.GetBytes(MicaSecurityTools.EncodeWithGzip(Form1.frm.homedata.ToString(), Form1.frm.signkey));
            }
            else if (request.Uri.ToString().Contains(GF_URLs_KR.attendance))
            {
                return Encoding.UTF8.GetBytes(MicaSecurityTools.EncodeWithGzip(File.ReadAllText("data/db/json/attendance.json"), Form1.frm.signkey));
            }
            else if (request.Uri.ToString().Contains(GF_URLs_KR.statictables))
            {
                return Encoding.UTF8.GetBytes(MicaSecurityTools.EncodeWithGzip(File.ReadAllText("data/db/json/statictables.json"), Form1.frm.signkey));
            }
            else if (request.Uri.ToString().Contains(GF_URLs_KR.ChangeGamesettings))
            {
                return Encoding.UTF8.GetBytes("1");
            }
            else if (request.Uri.ToString().Contains("sn-list.xdg.com/kr_gf_index.php"))
            {
                return Encoding.UTF8.GetBytes("1");
            }
            
            return Encoding.UTF8.GetBytes("error:202|[GFBattleTester_v2]\nまだサポートされてない機能です。");
        }

    }
}