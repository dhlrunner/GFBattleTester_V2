namespace GFBattleTester_v2
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.server_togglebtn = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.informationpage = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.enemysearchtextBox = new System.Windows.Forms.TextBox();
            this.enemy_list_gridview = new System.Windows.Forms.DataGridView();
            this.dollsettingpage = new System.Windows.Forms.TabPage();
            this.addtdoll = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.gunid = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gunid_index = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gunname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gunteam = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gunpos = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gunteamlocation = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gunlv = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gunhp = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gunpow = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gundodge = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gunrate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gunhit = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gunnum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gunskill1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gunskill2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gunfavor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gunoath = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.mre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ammo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.equipsettingpage = new System.Windows.Forms.TabPage();
            this.fairysettingpage = new System.Windows.Forms.TabPage();
            this.serversettingpage = new System.Windows.Forms.TabPage();
            this.editpacbutton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.causeErrorNext = new System.Windows.Forms.CheckBox();
            this.sendmailbtn = new System.Windows.Forms.Button();
            this.serverport = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.serveripaddrtextbox = new System.Windows.Forms.TextBox();
            this.serverdebugpage = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.logtextbox_clientrequest = new System.Windows.Forms.TextBox();
            this.logtextbox_clientresponce = new System.Windows.Forms.TextBox();
            this.logTextbox = new System.Windows.Forms.TextBox();
            this.server_background = new System.ComponentModel.BackgroundWorker();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tr_RX = new System.Windows.Forms.ToolStripStatusLabel();
            this.tr_TX = new System.Windows.Forms.ToolStripStatusLabel();
            this.server_status_text = new System.Windows.Forms.ToolStripStatusLabel();
            this.ind_TX_timer = new System.Windows.Forms.Timer(this.components);
            this.ind_RX_timer = new System.Windows.Forms.Timer(this.components);
            this.enemy_group_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enemy_leader = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enemy_bosshp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enemy_leaderhp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mission_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tabControl1.SuspendLayout();
            this.informationpage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.enemy_list_gridview)).BeginInit();
            this.dollsettingpage.SuspendLayout();
            this.serversettingpage.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.serverport)).BeginInit();
            this.serverdebugpage.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // server_togglebtn
            // 
            resources.ApplyResources(this.server_togglebtn, "server_togglebtn");
            this.server_togglebtn.Name = "server_togglebtn";
            this.server_togglebtn.UseVisualStyleBackColor = true;
            this.server_togglebtn.Click += new System.EventHandler(this.server_togglebtn_Click);
            // 
            // tabControl1
            // 
            resources.ApplyResources(this.tabControl1, "tabControl1");
            this.tabControl1.Controls.Add(this.informationpage);
            this.tabControl1.Controls.Add(this.dollsettingpage);
            this.tabControl1.Controls.Add(this.equipsettingpage);
            this.tabControl1.Controls.Add(this.fairysettingpage);
            this.tabControl1.Controls.Add(this.serversettingpage);
            this.tabControl1.Controls.Add(this.serverdebugpage);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            // 
            // informationpage
            // 
            this.informationpage.Controls.Add(this.groupBox2);
            this.informationpage.Controls.Add(this.textBox1);
            this.informationpage.Controls.Add(this.enemysearchtextBox);
            this.informationpage.Controls.Add(this.enemy_list_gridview);
            resources.ApplyResources(this.informationpage, "informationpage");
            this.informationpage.Name = "informationpage";
            this.informationpage.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            resources.ApplyResources(this.textBox1, "textBox1");
            this.textBox1.Name = "textBox1";
            // 
            // enemysearchtextBox
            // 
            resources.ApplyResources(this.enemysearchtextBox, "enemysearchtextBox");
            this.enemysearchtextBox.Name = "enemysearchtextBox";
            this.enemysearchtextBox.TextChanged += new System.EventHandler(this.enemysearchtextBox_TextChanged);
            // 
            // enemy_list_gridview
            // 
            this.enemy_list_gridview.AllowUserToAddRows = false;
            this.enemy_list_gridview.AllowUserToDeleteRows = false;
            this.enemy_list_gridview.AllowUserToResizeRows = false;
            resources.ApplyResources(this.enemy_list_gridview, "enemy_list_gridview");
            this.enemy_list_gridview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.enemy_list_gridview.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.enemy_list_gridview.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedVertical;
            this.enemy_list_gridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.enemy_list_gridview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.enemy_group_id,
            this.enemy_leader,
            this.enemy_bosshp,
            this.enemy_leaderhp,
            this.mission_name});
            this.enemy_list_gridview.MultiSelect = false;
            this.enemy_list_gridview.Name = "enemy_list_gridview";
            this.enemy_list_gridview.ReadOnly = true;
            this.enemy_list_gridview.RowTemplate.Height = 23;
            this.enemy_list_gridview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.enemy_list_gridview.SortCompare += new System.Windows.Forms.DataGridViewSortCompareEventHandler(this.enemy_list_gridview_SortCompare);
            // 
            // dollsettingpage
            // 
            this.dollsettingpage.Controls.Add(this.addtdoll);
            this.dollsettingpage.Controls.Add(this.listView1);
            resources.ApplyResources(this.dollsettingpage, "dollsettingpage");
            this.dollsettingpage.Name = "dollsettingpage";
            this.dollsettingpage.UseVisualStyleBackColor = true;
            // 
            // addtdoll
            // 
            resources.ApplyResources(this.addtdoll, "addtdoll");
            this.addtdoll.Name = "addtdoll";
            this.addtdoll.UseVisualStyleBackColor = true;
            this.addtdoll.Click += new System.EventHandler(this.Button3_Click);
            // 
            // listView1
            // 
            resources.ApplyResources(this.listView1, "listView1");
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.gunid,
            this.gunid_index,
            this.gunname,
            this.gunteam,
            this.gunpos,
            this.gunteamlocation,
            this.gunlv,
            this.gunhp,
            this.gunpow,
            this.gundodge,
            this.gunrate,
            this.gunhit,
            this.gunnum,
            this.gunskill1,
            this.gunskill2,
            this.gunfavor,
            this.gunoath,
            this.mre,
            this.ammo});
            this.listView1.Cursor = System.Windows.Forms.Cursors.Cross;
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.Name = "listView1";
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.ListView1_SelectedIndexChanged);
            this.listView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseDoubleClick);
            // 
            // gunid
            // 
            resources.ApplyResources(this.gunid, "gunid");
            // 
            // gunid_index
            // 
            resources.ApplyResources(this.gunid_index, "gunid_index");
            // 
            // gunname
            // 
            resources.ApplyResources(this.gunname, "gunname");
            // 
            // gunteam
            // 
            resources.ApplyResources(this.gunteam, "gunteam");
            // 
            // gunpos
            // 
            resources.ApplyResources(this.gunpos, "gunpos");
            // 
            // gunteamlocation
            // 
            resources.ApplyResources(this.gunteamlocation, "gunteamlocation");
            // 
            // gunlv
            // 
            resources.ApplyResources(this.gunlv, "gunlv");
            // 
            // gunhp
            // 
            resources.ApplyResources(this.gunhp, "gunhp");
            // 
            // gunpow
            // 
            resources.ApplyResources(this.gunpow, "gunpow");
            // 
            // gundodge
            // 
            resources.ApplyResources(this.gundodge, "gundodge");
            // 
            // gunrate
            // 
            resources.ApplyResources(this.gunrate, "gunrate");
            // 
            // gunhit
            // 
            resources.ApplyResources(this.gunhit, "gunhit");
            // 
            // gunnum
            // 
            resources.ApplyResources(this.gunnum, "gunnum");
            // 
            // gunskill1
            // 
            resources.ApplyResources(this.gunskill1, "gunskill1");
            // 
            // gunskill2
            // 
            resources.ApplyResources(this.gunskill2, "gunskill2");
            // 
            // gunfavor
            // 
            resources.ApplyResources(this.gunfavor, "gunfavor");
            // 
            // gunoath
            // 
            resources.ApplyResources(this.gunoath, "gunoath");
            // 
            // mre
            // 
            resources.ApplyResources(this.mre, "mre");
            // 
            // ammo
            // 
            resources.ApplyResources(this.ammo, "ammo");
            // 
            // equipsettingpage
            // 
            resources.ApplyResources(this.equipsettingpage, "equipsettingpage");
            this.equipsettingpage.Name = "equipsettingpage";
            this.equipsettingpage.UseVisualStyleBackColor = true;
            // 
            // fairysettingpage
            // 
            resources.ApplyResources(this.fairysettingpage, "fairysettingpage");
            this.fairysettingpage.Name = "fairysettingpage";
            this.fairysettingpage.UseVisualStyleBackColor = true;
            // 
            // serversettingpage
            // 
            this.serversettingpage.Controls.Add(this.editpacbutton);
            this.serversettingpage.Controls.Add(this.groupBox1);
            this.serversettingpage.Controls.Add(this.serverport);
            this.serversettingpage.Controls.Add(this.label5);
            this.serversettingpage.Controls.Add(this.label4);
            this.serversettingpage.Controls.Add(this.serveripaddrtextbox);
            this.serversettingpage.Controls.Add(this.server_togglebtn);
            resources.ApplyResources(this.serversettingpage, "serversettingpage");
            this.serversettingpage.Name = "serversettingpage";
            this.serversettingpage.UseVisualStyleBackColor = true;
            // 
            // editpacbutton
            // 
            resources.ApplyResources(this.editpacbutton, "editpacbutton");
            this.editpacbutton.Name = "editpacbutton";
            this.editpacbutton.UseVisualStyleBackColor = true;
            this.editpacbutton.Click += new System.EventHandler(this.editpacbutton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.causeErrorNext);
            this.groupBox1.Controls.Add(this.sendmailbtn);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // causeErrorNext
            // 
            resources.ApplyResources(this.causeErrorNext, "causeErrorNext");
            this.causeErrorNext.Name = "causeErrorNext";
            this.causeErrorNext.UseVisualStyleBackColor = true;
            this.causeErrorNext.CheckedChanged += new System.EventHandler(this.causeErrorNext_CheckedChanged);
            // 
            // sendmailbtn
            // 
            resources.ApplyResources(this.sendmailbtn, "sendmailbtn");
            this.sendmailbtn.Name = "sendmailbtn";
            this.sendmailbtn.UseVisualStyleBackColor = true;
            this.sendmailbtn.Click += new System.EventHandler(this.sendmailbtn_Click);
            // 
            // serverport
            // 
            resources.ApplyResources(this.serverport, "serverport");
            this.serverport.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.serverport.Name = "serverport";
            this.serverport.Value = new decimal(new int[] {
            80,
            0,
            0,
            0});
            this.serverport.ValueChanged += new System.EventHandler(this.serverport_ValueChanged);
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // serveripaddrtextbox
            // 
            resources.ApplyResources(this.serveripaddrtextbox, "serveripaddrtextbox");
            this.serveripaddrtextbox.Name = "serveripaddrtextbox";
            this.serveripaddrtextbox.TextChanged += new System.EventHandler(this.serveripaddrtextbox_TextChanged);
            // 
            // serverdebugpage
            // 
            this.serverdebugpage.Controls.Add(this.label3);
            this.serverdebugpage.Controls.Add(this.label2);
            this.serverdebugpage.Controls.Add(this.button1);
            this.serverdebugpage.Controls.Add(this.label1);
            this.serverdebugpage.Controls.Add(this.logtextbox_clientrequest);
            this.serverdebugpage.Controls.Add(this.logtextbox_clientresponce);
            this.serverdebugpage.Controls.Add(this.logTextbox);
            resources.ApplyResources(this.serverdebugpage, "serverdebugpage");
            this.serverdebugpage.Name = "serverdebugpage";
            this.serverdebugpage.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // logtextbox_clientrequest
            // 
            resources.ApplyResources(this.logtextbox_clientrequest, "logtextbox_clientrequest");
            this.logtextbox_clientrequest.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.logtextbox_clientrequest.Name = "logtextbox_clientrequest";
            this.logtextbox_clientrequest.ReadOnly = true;
            // 
            // logtextbox_clientresponce
            // 
            resources.ApplyResources(this.logtextbox_clientresponce, "logtextbox_clientresponce");
            this.logtextbox_clientresponce.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.logtextbox_clientresponce.Name = "logtextbox_clientresponce";
            this.logtextbox_clientresponce.ReadOnly = true;
            // 
            // logTextbox
            // 
            this.logTextbox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            resources.ApplyResources(this.logTextbox, "logTextbox");
            this.logTextbox.Name = "logTextbox";
            this.logTextbox.ReadOnly = true;
            // 
            // server_background
            // 
            this.server_background.DoWork += new System.ComponentModel.DoWorkEventHandler(this.server_background_DoWork);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tr_RX,
            this.tr_TX,
            this.server_status_text});
            resources.ApplyResources(this.statusStrip1, "statusStrip1");
            this.statusStrip1.Name = "statusStrip1";
            // 
            // tr_RX
            // 
            this.tr_RX.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.tr_RX.Name = "tr_RX";
            resources.ApplyResources(this.tr_RX, "tr_RX");
            // 
            // tr_TX
            // 
            this.tr_TX.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.tr_TX.Name = "tr_TX";
            resources.ApplyResources(this.tr_TX, "tr_TX");
            // 
            // server_status_text
            // 
            this.server_status_text.Name = "server_status_text";
            resources.ApplyResources(this.server_status_text, "server_status_text");
            // 
            // ind_TX_timer
            // 
            this.ind_TX_timer.Tick += new System.EventHandler(this.ind_TX_timer_Tick);
            // 
            // ind_RX_timer
            // 
            this.ind_RX_timer.Tick += new System.EventHandler(this.ind_RX_timer_Tick);
            // 
            // enemy_group_id
            // 
            resources.ApplyResources(this.enemy_group_id, "enemy_group_id");
            this.enemy_group_id.Name = "enemy_group_id";
            this.enemy_group_id.ReadOnly = true;
            // 
            // enemy_leader
            // 
            resources.ApplyResources(this.enemy_leader, "enemy_leader");
            this.enemy_leader.Name = "enemy_leader";
            this.enemy_leader.ReadOnly = true;
            // 
            // enemy_bosshp
            // 
            resources.ApplyResources(this.enemy_bosshp, "enemy_bosshp");
            this.enemy_bosshp.Name = "enemy_bosshp";
            this.enemy_bosshp.ReadOnly = true;
            // 
            // enemy_leaderhp
            // 
            resources.ApplyResources(this.enemy_leaderhp, "enemy_leaderhp");
            this.enemy_leaderhp.Name = "enemy_leaderhp";
            this.enemy_leaderhp.ReadOnly = true;
            // 
            // mission_name
            // 
            resources.ApplyResources(this.mission_name, "mission_name");
            this.mission_name.Name = "mission_name";
            this.mission_name.ReadOnly = true;
            // 
            // groupBox2
            // 
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.informationpage.ResumeLayout(false);
            this.informationpage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.enemy_list_gridview)).EndInit();
            this.dollsettingpage.ResumeLayout(false);
            this.serversettingpage.ResumeLayout(false);
            this.serversettingpage.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.serverport)).EndInit();
            this.serverdebugpage.ResumeLayout(false);
            this.serverdebugpage.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button server_togglebtn;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage informationpage;
        private System.Windows.Forms.TabPage dollsettingpage;
        private System.Windows.Forms.Button addtdoll;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader gunid;
        private System.Windows.Forms.ColumnHeader gunname;
        private System.Windows.Forms.TabPage equipsettingpage;
        private System.Windows.Forms.TabPage fairysettingpage;
        private System.Windows.Forms.ColumnHeader gunlv;
        private System.Windows.Forms.ColumnHeader gunhp;
        private System.Windows.Forms.ColumnHeader gunpow;
        private System.Windows.Forms.ColumnHeader gundodge;
        private System.Windows.Forms.ColumnHeader gunrate;
        private System.Windows.Forms.ColumnHeader gunhit;
        private System.Windows.Forms.ColumnHeader gunnum;
        private System.Windows.Forms.ColumnHeader gunskill1;
        private System.Windows.Forms.ColumnHeader gunskill2;
        private System.Windows.Forms.ColumnHeader gunfavor;
        private System.Windows.Forms.ColumnHeader gunpos;
        private System.Windows.Forms.ColumnHeader gunoath;
        private System.ComponentModel.BackgroundWorker server_background;
        private System.Windows.Forms.ColumnHeader gunid_index;
        private System.Windows.Forms.ColumnHeader gunteam;
        private System.Windows.Forms.ColumnHeader gunteamlocation;
        private System.Windows.Forms.ColumnHeader mre;
        private System.Windows.Forms.ColumnHeader ammo;
        private System.Windows.Forms.TextBox logTextbox;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.CheckBox causeErrorNext;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel server_status_text;
        private System.Windows.Forms.ToolStripStatusLabel tr_RX;
        private System.Windows.Forms.ToolStripStatusLabel tr_TX;
        private System.Windows.Forms.Timer ind_TX_timer;
        private System.Windows.Forms.Timer ind_RX_timer;
        private System.Windows.Forms.Button sendmailbtn;
        private System.Windows.Forms.TabPage serverdebugpage;
        public System.Windows.Forms.TextBox logtextbox_clientrequest;
        public System.Windows.Forms.TextBox logtextbox_clientresponce;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage serversettingpage;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown serverport;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox serveripaddrtextbox;
        private System.Windows.Forms.Button editpacbutton;
        private System.Windows.Forms.DataGridView enemy_list_gridview;
        private System.Windows.Forms.TextBox enemysearchtextBox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn enemy_group_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn enemy_leader;
        private System.Windows.Forms.DataGridViewTextBoxColumn enemy_bosshp;
        private System.Windows.Forms.DataGridViewTextBoxColumn enemy_leaderhp;
        private System.Windows.Forms.DataGridViewTextBoxColumn mission_name;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

