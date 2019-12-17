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
            this.server_togglebtn = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.informationpage = new System.Windows.Forms.TabPage();
            this.sendmailbtn = new System.Windows.Forms.Button();
            this.causeErrorNext = new System.Windows.Forms.CheckBox();
            this.dollsettingpage = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
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
            this.serveripaddrtextbox = new System.Windows.Forms.TextBox();
            this.serversettingpage = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.serverport = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tabControl1.SuspendLayout();
            this.dollsettingpage.SuspendLayout();
            this.serverdebugpage.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.serversettingpage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.serverport)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // server_togglebtn
            // 
            this.server_togglebtn.Location = new System.Drawing.Point(962, 6);
            this.server_togglebtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.server_togglebtn.Name = "server_togglebtn";
            this.server_togglebtn.Size = new System.Drawing.Size(158, 38);
            this.server_togglebtn.TabIndex = 0;
            this.server_togglebtn.Text = "Start Server";
            this.server_togglebtn.UseVisualStyleBackColor = true;
            this.server_togglebtn.Click += new System.EventHandler(this.server_togglebtn_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.informationpage);
            this.tabControl1.Controls.Add(this.dollsettingpage);
            this.tabControl1.Controls.Add(this.equipsettingpage);
            this.tabControl1.Controls.Add(this.fairysettingpage);
            this.tabControl1.Controls.Add(this.serversettingpage);
            this.tabControl1.Controls.Add(this.serverdebugpage);
            this.tabControl1.Location = new System.Drawing.Point(12, 13);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1131, 523);
            this.tabControl1.TabIndex = 1;
            // 
            // informationpage
            // 
            this.informationpage.Location = new System.Drawing.Point(4, 24);
            this.informationpage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.informationpage.Name = "informationpage";
            this.informationpage.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.informationpage.Size = new System.Drawing.Size(1123, 495);
            this.informationpage.TabIndex = 0;
            this.informationpage.Text = "정보";
            this.informationpage.UseVisualStyleBackColor = true;
            // 
            // sendmailbtn
            // 
            this.sendmailbtn.Location = new System.Drawing.Point(6, 176);
            this.sendmailbtn.Name = "sendmailbtn";
            this.sendmailbtn.Size = new System.Drawing.Size(158, 23);
            this.sendmailbtn.TabIndex = 4;
            this.sendmailbtn.Text = "メールを送る";
            this.sendmailbtn.UseVisualStyleBackColor = true;
            this.sendmailbtn.Click += new System.EventHandler(this.sendmailbtn_Click);
            // 
            // causeErrorNext
            // 
            this.causeErrorNext.AutoSize = true;
            this.causeErrorNext.Location = new System.Drawing.Point(14, 22);
            this.causeErrorNext.Name = "causeErrorNext";
            this.causeErrorNext.Size = new System.Drawing.Size(267, 19);
            this.causeErrorNext.TabIndex = 3;
            this.causeErrorNext.Text = "次のサーバ接続時クライアント強制リセット";
            this.causeErrorNext.UseVisualStyleBackColor = true;
            this.causeErrorNext.CheckedChanged += new System.EventHandler(this.causeErrorNext_CheckedChanged);
            // 
            // dollsettingpage
            // 
            this.dollsettingpage.Controls.Add(this.button3);
            this.dollsettingpage.Controls.Add(this.listView1);
            this.dollsettingpage.Location = new System.Drawing.Point(4, 24);
            this.dollsettingpage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dollsettingpage.Name = "dollsettingpage";
            this.dollsettingpage.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dollsettingpage.Size = new System.Drawing.Size(1123, 495);
            this.dollsettingpage.TabIndex = 1;
            this.dollsettingpage.Text = "인형 설정";
            this.dollsettingpage.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(3, 8);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 24);
            this.button3.TabIndex = 1;
            this.button3.Text = "追加";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.listView1.Location = new System.Drawing.Point(3, 40);
            this.listView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1114, 451);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.ListView1_SelectedIndexChanged);
            this.listView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseDoubleClick);
            // 
            // gunid
            // 
            this.gunid.Text = "ID";
            this.gunid.Width = 56;
            // 
            // gunid_index
            // 
            this.gunid_index.Text = "図鑑ID";
            // 
            // gunname
            // 
            this.gunname.Text = "名前";
            this.gunname.Width = 100;
            // 
            // gunteam
            // 
            this.gunteam.Text = "部隊";
            // 
            // gunpos
            // 
            this.gunpos.Text = "陣形位置";
            // 
            // gunteamlocation
            // 
            this.gunteamlocation.Text = "部隊内順番";
            this.gunteamlocation.Width = 75;
            // 
            // gunlv
            // 
            this.gunlv.Text = "LV";
            this.gunlv.Width = 40;
            // 
            // gunhp
            // 
            this.gunhp.Text = "HP";
            this.gunhp.Width = 50;
            // 
            // gunpow
            // 
            this.gunpow.Text = "火力";
            this.gunpow.Width = 40;
            // 
            // gundodge
            // 
            this.gundodge.Text = "回避";
            this.gundodge.Width = 50;
            // 
            // gunrate
            // 
            this.gunrate.Text = "射速";
            this.gunrate.Width = 50;
            // 
            // gunhit
            // 
            this.gunhit.Text = "命中";
            this.gunhit.Width = 50;
            // 
            // gunnum
            // 
            this.gunnum.Text = "編成数";
            this.gunnum.Width = 50;
            // 
            // gunskill1
            // 
            this.gunskill1.Text = "スキル1LV";
            this.gunskill1.Width = 74;
            // 
            // gunskill2
            // 
            this.gunskill2.Text = "スキル2LV";
            this.gunskill2.Width = 72;
            // 
            // gunfavor
            // 
            this.gunfavor.Text = "好感度";
            this.gunfavor.Width = 50;
            // 
            // gunoath
            // 
            this.gunoath.Text = "誓約";
            // 
            // mre
            // 
            this.mre.Text = "食糧";
            this.mre.Width = 50;
            // 
            // ammo
            // 
            this.ammo.Text = "弾薬";
            this.ammo.Width = 50;
            // 
            // equipsettingpage
            // 
            this.equipsettingpage.Location = new System.Drawing.Point(4, 24);
            this.equipsettingpage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.equipsettingpage.Name = "equipsettingpage";
            this.equipsettingpage.Size = new System.Drawing.Size(1123, 495);
            this.equipsettingpage.TabIndex = 2;
            this.equipsettingpage.Text = "장비 설정";
            this.equipsettingpage.UseVisualStyleBackColor = true;
            // 
            // fairysettingpage
            // 
            this.fairysettingpage.Location = new System.Drawing.Point(4, 24);
            this.fairysettingpage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.fairysettingpage.Name = "fairysettingpage";
            this.fairysettingpage.Size = new System.Drawing.Size(1123, 495);
            this.fairysettingpage.TabIndex = 3;
            this.fairysettingpage.Text = "요정 설정";
            this.fairysettingpage.UseVisualStyleBackColor = true;
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
            this.serverdebugpage.Location = new System.Drawing.Point(4, 24);
            this.serverdebugpage.Name = "serverdebugpage";
            this.serverdebugpage.Padding = new System.Windows.Forms.Padding(3);
            this.serverdebugpage.Size = new System.Drawing.Size(1123, 495);
            this.serverdebugpage.TabIndex = 4;
            this.serverdebugpage.Text = "Debugging";
            this.serverdebugpage.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(600, 255);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Responce to GF client";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(600, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "GF Client Request";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.Location = new System.Drawing.Point(10, 466);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(248, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Copy userdata to clipboard";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Requested URL";
            // 
            // logtextbox_clientrequest
            // 
            this.logtextbox_clientrequest.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.logtextbox_clientrequest.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.logtextbox_clientrequest.Location = new System.Drawing.Point(603, 27);
            this.logtextbox_clientrequest.Multiline = true;
            this.logtextbox_clientrequest.Name = "logtextbox_clientrequest";
            this.logtextbox_clientrequest.ReadOnly = true;
            this.logtextbox_clientrequest.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.logtextbox_clientrequest.Size = new System.Drawing.Size(514, 220);
            this.logtextbox_clientrequest.TabIndex = 2;
            // 
            // logtextbox_clientresponce
            // 
            this.logtextbox_clientresponce.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.logtextbox_clientresponce.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.logtextbox_clientresponce.Location = new System.Drawing.Point(603, 274);
            this.logtextbox_clientresponce.Multiline = true;
            this.logtextbox_clientresponce.Name = "logtextbox_clientresponce";
            this.logtextbox_clientresponce.ReadOnly = true;
            this.logtextbox_clientresponce.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.logtextbox_clientresponce.Size = new System.Drawing.Size(514, 215);
            this.logtextbox_clientresponce.TabIndex = 2;
            // 
            // logTextbox
            // 
            this.logTextbox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.logTextbox.Location = new System.Drawing.Point(6, 27);
            this.logTextbox.Multiline = true;
            this.logTextbox.Name = "logTextbox";
            this.logTextbox.ReadOnly = true;
            this.logTextbox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.logTextbox.Size = new System.Drawing.Size(566, 271);
            this.logTextbox.TabIndex = 1;
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
            this.statusStrip1.Location = new System.Drawing.Point(0, 538);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1155, 24);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tr_RX
            // 
            this.tr_RX.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.tr_RX.Name = "tr_RX";
            this.tr_RX.Size = new System.Drawing.Size(35, 19);
            this.tr_RX.Text = "受信";
            // 
            // tr_TX
            // 
            this.tr_TX.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.tr_TX.Name = "tr_TX";
            this.tr_TX.Size = new System.Drawing.Size(35, 19);
            this.tr_TX.Text = "送信";
            // 
            // server_status_text
            // 
            this.server_status_text.Name = "server_status_text";
            this.server_status_text.Size = new System.Drawing.Size(0, 19);
            // 
            // ind_TX_timer
            // 
            this.ind_TX_timer.Tick += new System.EventHandler(this.ind_TX_timer_Tick);
            // 
            // ind_RX_timer
            // 
            this.ind_RX_timer.Tick += new System.EventHandler(this.ind_RX_timer_Tick);
            // 
            // serveripaddrtextbox
            // 
            this.serveripaddrtextbox.Location = new System.Drawing.Point(37, 16);
            this.serveripaddrtextbox.Name = "serveripaddrtextbox";
            this.serveripaddrtextbox.Size = new System.Drawing.Size(125, 23);
            this.serveripaddrtextbox.TabIndex = 5;
            this.serveripaddrtextbox.TextChanged += new System.EventHandler(this.serveripaddrtextbox_TextChanged);
            // 
            // serversettingpage
            // 
            this.serversettingpage.Controls.Add(this.groupBox1);
            this.serversettingpage.Controls.Add(this.serverport);
            this.serversettingpage.Controls.Add(this.label5);
            this.serversettingpage.Controls.Add(this.label4);
            this.serversettingpage.Controls.Add(this.serveripaddrtextbox);
            this.serversettingpage.Controls.Add(this.server_togglebtn);
            this.serversettingpage.Location = new System.Drawing.Point(4, 24);
            this.serversettingpage.Name = "serversettingpage";
            this.serversettingpage.Size = new System.Drawing.Size(1123, 495);
            this.serversettingpage.TabIndex = 5;
            this.serversettingpage.Text = "サーバ設定";
            this.serversettingpage.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "IP";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(183, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "Port";
            // 
            // serverport
            // 
            this.serverport.Location = new System.Drawing.Point(218, 16);
            this.serverport.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.serverport.Name = "serverport";
            this.serverport.Size = new System.Drawing.Size(61, 23);
            this.serverport.TabIndex = 8;
            this.serverport.Value = new decimal(new int[] {
            80,
            0,
            0,
            0});
            this.serverport.ValueChanged += new System.EventHandler(this.serverport_ValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.causeErrorNext);
            this.groupBox1.Controls.Add(this.sendmailbtn);
            this.groupBox1.Location = new System.Drawing.Point(3, 57);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(467, 205);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1155, 562);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.dollsettingpage.ResumeLayout(false);
            this.serverdebugpage.ResumeLayout(false);
            this.serverdebugpage.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.serversettingpage.ResumeLayout(false);
            this.serversettingpage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.serverport)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button server_togglebtn;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage informationpage;
        private System.Windows.Forms.TabPage dollsettingpage;
        private System.Windows.Forms.Button button3;
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
    }
}

