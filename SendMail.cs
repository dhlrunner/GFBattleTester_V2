using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;

namespace GFBattleTester_v2
{
    public partial class SendMail : Form
    {
        public delegate void FormCloseEventHandler(JObject json);
        public event FormCloseEventHandler FormCloseEvent;
        public SendMail()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void titletext_TextChanged(object sender, EventArgs e)
        {
            if(titletext.TextLength > 0)
            {
                sendbtn.Enabled = true;
            }
            else
            {
                sendbtn.Enabled = false;
            }
        }

        private void sendbtn_Click(object sender, EventArgs e)
        {
            Random n = new Random();
            JObject mail = new JObject();
            mail.Add("id", n.Next(1, 99999999).ToString()); ;
            mail.Add("user_id","0");
            mail.Add("type", "6");
            mail.Add("sub_id", "0");
            mail.Add("user_exp", "0");
            mail.Add("mp", "0");
            mail.Add("ammo", "0");
            mail.Add("mre", "0");
            mail.Add("part", "0");
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
            mail.Add("title", titletext.Text);
            mail.Add("content", bodytext.Text);
            mail.Add("code", "");
            mail.Add("start_time",  MicaSecurityTools.GetCurrentTimeStamp().ToString());
            mail.Add("end_time", notime.Checked ? "2100000000" : ((DateTimeOffset)dateTimePicker1.Value).ToUnixTimeSeconds().ToString());
            mail.Add("if_read", "0");
            this.FormCloseEvent(mail);
            Close();
        }

        private void notime_CheckedChanged(object sender, EventArgs e)
        {
            dateTimePicker1.Enabled = !notime.Checked;
        }

        private void SendMail_Load(object sender, EventArgs e)
        {

        }
    }
}
