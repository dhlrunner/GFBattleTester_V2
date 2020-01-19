namespace GFBattleTester_v2
{
    partial class gunselector
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gunNametextbox = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.gundb_ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gundb_name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gundb_codename = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gundb_type = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gundb_rare = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.searchbtn = new System.Windows.Forms.Button();
            this.stat_groupbox = new System.Windows.Forms.GroupBox();
            this.stat_inteamlocation = new System.Windows.Forms.ComboBox();
            this.stat_teamid = new System.Windows.Forms.ComboBox();
            this.stat_autocalc = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.stat_oath = new System.Windows.Forms.CheckBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.stat_hp = new System.Windows.Forms.NumericUpDown();
            this.stat_hit = new System.Windows.Forms.NumericUpDown();
            this.stat_ammo = new System.Windows.Forms.NumericUpDown();
            this.stat_mre = new System.Windows.Forms.NumericUpDown();
            this.stat_rate = new System.Windows.Forms.NumericUpDown();
            this.stat_favor = new System.Windows.Forms.NumericUpDown();
            this.stat_num = new System.Windows.Forms.NumericUpDown();
            this.stat_skill2 = new System.Windows.Forms.NumericUpDown();
            this.stat_pos = new System.Windows.Forms.NumericUpDown();
            this.stat_skill1 = new System.Windows.Forms.NumericUpDown();
            this.stat_dodge = new System.Windows.Forms.NumericUpDown();
            this.stat_fire = new System.Windows.Forms.NumericUpDown();
            this.stat_level = new System.Windows.Forms.NumericUpDown();
            this.applybtn = new System.Windows.Forms.Button();
            this.stat_groupbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stat_hp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stat_hit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stat_ammo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stat_mre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stat_rate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stat_favor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stat_num)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stat_skill2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stat_pos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stat_skill1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stat_dodge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stat_fire)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stat_level)).BeginInit();
            this.SuspendLayout();
            // 
            // gunNametextbox
            // 
            this.gunNametextbox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.gunNametextbox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.gunNametextbox.Location = new System.Drawing.Point(12, 44);
            this.gunNametextbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gunNametextbox.Name = "gunNametextbox";
            this.gunNametextbox.Size = new System.Drawing.Size(155, 23);
            this.gunNametextbox.TabIndex = 0;
            this.gunNametextbox.TextChanged += new System.EventHandler(this.gunNametextbox_TextChanged);
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.gundb_ID,
            this.gundb_name,
            this.gundb_codename,
            this.gundb_type,
            this.gundb_rare});
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 75);
            this.listView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(477, 480);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseDoubleClick);
            // 
            // gundb_ID
            // 
            this.gundb_ID.Text = "人形ID";
            // 
            // gundb_name
            // 
            this.gundb_name.Text = "名前";
            this.gundb_name.Width = 120;
            // 
            // gundb_codename
            // 
            this.gundb_codename.Text = "コードネーム";
            this.gundb_codename.Width = 120;
            // 
            // gundb_type
            // 
            this.gundb_type.Text = "種類";
            // 
            // gundb_rare
            // 
            this.gundb_rare.Text = "レアリティ";
            this.gundb_rare.Width = 110;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "名前で検索";
            // 
            // searchbtn
            // 
            this.searchbtn.Location = new System.Drawing.Point(173, 43);
            this.searchbtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.searchbtn.Name = "searchbtn";
            this.searchbtn.Size = new System.Drawing.Size(75, 24);
            this.searchbtn.TabIndex = 3;
            this.searchbtn.Text = "検索";
            this.searchbtn.UseVisualStyleBackColor = true;
            this.searchbtn.Click += new System.EventHandler(this.searchbtn_Click);
            // 
            // stat_groupbox
            // 
            this.stat_groupbox.Controls.Add(this.stat_inteamlocation);
            this.stat_groupbox.Controls.Add(this.stat_teamid);
            this.stat_groupbox.Controls.Add(this.stat_autocalc);
            this.stat_groupbox.Controls.Add(this.button1);
            this.stat_groupbox.Controls.Add(this.stat_oath);
            this.stat_groupbox.Controls.Add(this.label14);
            this.stat_groupbox.Controls.Add(this.label16);
            this.stat_groupbox.Controls.Add(this.label15);
            this.stat_groupbox.Controls.Add(this.label13);
            this.stat_groupbox.Controls.Add(this.label4);
            this.stat_groupbox.Controls.Add(this.label7);
            this.stat_groupbox.Controls.Add(this.label6);
            this.stat_groupbox.Controls.Add(this.label9);
            this.stat_groupbox.Controls.Add(this.label8);
            this.stat_groupbox.Controls.Add(this.label11);
            this.stat_groupbox.Controls.Add(this.label12);
            this.stat_groupbox.Controls.Add(this.label10);
            this.stat_groupbox.Controls.Add(this.label5);
            this.stat_groupbox.Controls.Add(this.label3);
            this.stat_groupbox.Controls.Add(this.label2);
            this.stat_groupbox.Controls.Add(this.stat_hp);
            this.stat_groupbox.Controls.Add(this.stat_hit);
            this.stat_groupbox.Controls.Add(this.stat_ammo);
            this.stat_groupbox.Controls.Add(this.stat_mre);
            this.stat_groupbox.Controls.Add(this.stat_rate);
            this.stat_groupbox.Controls.Add(this.stat_favor);
            this.stat_groupbox.Controls.Add(this.stat_num);
            this.stat_groupbox.Controls.Add(this.stat_skill2);
            this.stat_groupbox.Controls.Add(this.stat_pos);
            this.stat_groupbox.Controls.Add(this.stat_skill1);
            this.stat_groupbox.Controls.Add(this.stat_dodge);
            this.stat_groupbox.Controls.Add(this.stat_fire);
            this.stat_groupbox.Controls.Add(this.stat_level);
            this.stat_groupbox.Enabled = false;
            this.stat_groupbox.Location = new System.Drawing.Point(495, 66);
            this.stat_groupbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.stat_groupbox.Name = "stat_groupbox";
            this.stat_groupbox.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.stat_groupbox.Size = new System.Drawing.Size(361, 459);
            this.stat_groupbox.TabIndex = 4;
            this.stat_groupbox.TabStop = false;
            this.stat_groupbox.Text = "ダブルクリックで選択";
            this.stat_groupbox.Enter += new System.EventHandler(this.stat_groupbox_Enter);
            // 
            // stat_inteamlocation
            // 
            this.stat_inteamlocation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.stat_inteamlocation.FormattingEnabled = true;
            this.stat_inteamlocation.Items.AddRange(new object[] {
            "1番",
            "2番",
            "3番",
            "4番",
            "5番"});
            this.stat_inteamlocation.Location = new System.Drawing.Point(251, 115);
            this.stat_inteamlocation.Name = "stat_inteamlocation";
            this.stat_inteamlocation.Size = new System.Drawing.Size(87, 23);
            this.stat_inteamlocation.TabIndex = 7;
            // 
            // stat_teamid
            // 
            this.stat_teamid.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.stat_teamid.FormattingEnabled = true;
            this.stat_teamid.Items.AddRange(new object[] {
            "解除",
            "第1部隊",
            "第2部隊",
            "第3部隊",
            "第4部隊",
            "第5部隊",
            "第6部隊",
            "第7部隊",
            "第8部隊",
            "第9部隊",
            "第10部隊"});
            this.stat_teamid.Location = new System.Drawing.Point(251, 64);
            this.stat_teamid.Name = "stat_teamid";
            this.stat_teamid.Size = new System.Drawing.Size(87, 23);
            this.stat_teamid.TabIndex = 7;
            this.stat_teamid.SelectedIndexChanged += new System.EventHandler(this.stat_teamid_SelectedIndexChanged);
            // 
            // stat_autocalc
            // 
            this.stat_autocalc.AutoSize = true;
            this.stat_autocalc.Location = new System.Drawing.Point(26, 411);
            this.stat_autocalc.Name = "stat_autocalc";
            this.stat_autocalc.Size = new System.Drawing.Size(260, 19);
            this.stat_autocalc.TabIndex = 6;
            this.stat_autocalc.Text = "レベル/編成数に合わせて能力値を自動計算";
            this.stat_autocalc.UseVisualStyleBackColor = true;
            this.stat_autocalc.CheckedChanged += new System.EventHandler(this.stat_autocalc_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(74, 334);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(42, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "選択";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // stat_oath
            // 
            this.stat_oath.AutoSize = true;
            this.stat_oath.Location = new System.Drawing.Point(265, 276);
            this.stat_oath.Name = "stat_oath";
            this.stat_oath.Size = new System.Drawing.Size(50, 19);
            this.stat_oath.TabIndex = 4;
            this.stat_oath.Text = "誓約";
            this.stat_oath.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(251, 97);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(68, 15);
            this.label14.TabIndex = 3;
            this.label14.Text = "部隊内順番";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(251, 201);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(33, 15);
            this.label16.TabIndex = 3;
            this.label16.Text = "弾薬";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(251, 150);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(31, 15);
            this.label15.TabIndex = 3;
            this.label15.Text = "食糧";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(251, 47);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(31, 15);
            this.label13.TabIndex = 3;
            this.label13.Text = "部隊";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(136, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "HP";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(135, 97);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 15);
            this.label7.TabIndex = 3;
            this.label7.Text = "命中";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(135, 150);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 15);
            this.label6.TabIndex = 3;
            this.label6.Text = "射速";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(134, 201);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 15);
            this.label9.TabIndex = 3;
            this.label9.Text = "好感度";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(24, 201);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 15);
            this.label8.TabIndex = 3;
            this.label8.Text = "編成数";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(134, 256);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 15);
            this.label11.TabIndex = 3;
            this.label11.Text = "スキル2LV";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(25, 316);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(55, 15);
            this.label12.TabIndex = 3;
            this.label12.Text = "陣形位置";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(25, 256);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 15);
            this.label10.TabIndex = 3;
            this.label10.Text = "スキル1LV";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 15);
            this.label5.TabIndex = 3;
            this.label5.Text = "回避";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "火力";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "LV";
            // 
            // stat_hp
            // 
            this.stat_hp.Location = new System.Drawing.Point(138, 64);
            this.stat_hp.Maximum = new decimal(new int[] {
            1215752191,
            23,
            0,
            0});
            this.stat_hp.Name = "stat_hp";
            this.stat_hp.Size = new System.Drawing.Size(88, 23);
            this.stat_hp.TabIndex = 1;
            // 
            // stat_hit
            // 
            this.stat_hit.Location = new System.Drawing.Point(138, 115);
            this.stat_hit.Maximum = new decimal(new int[] {
            1215752191,
            23,
            0,
            0});
            this.stat_hit.Name = "stat_hit";
            this.stat_hit.Size = new System.Drawing.Size(88, 23);
            this.stat_hit.TabIndex = 1;
            // 
            // stat_ammo
            // 
            this.stat_ammo.Location = new System.Drawing.Point(250, 219);
            this.stat_ammo.Maximum = new decimal(new int[] {
            1215752191,
            23,
            0,
            0});
            this.stat_ammo.Name = "stat_ammo";
            this.stat_ammo.Size = new System.Drawing.Size(88, 23);
            this.stat_ammo.TabIndex = 1;
            this.stat_ammo.Value = new decimal(new int[] {
            120,
            0,
            0,
            0});
            // 
            // stat_mre
            // 
            this.stat_mre.Location = new System.Drawing.Point(251, 168);
            this.stat_mre.Maximum = new decimal(new int[] {
            1215752191,
            23,
            0,
            0});
            this.stat_mre.Name = "stat_mre";
            this.stat_mre.Size = new System.Drawing.Size(88, 23);
            this.stat_mre.TabIndex = 1;
            this.stat_mre.Value = new decimal(new int[] {
            120,
            0,
            0,
            0});
            // 
            // stat_rate
            // 
            this.stat_rate.Location = new System.Drawing.Point(138, 168);
            this.stat_rate.Maximum = new decimal(new int[] {
            1215752191,
            23,
            0,
            0});
            this.stat_rate.Name = "stat_rate";
            this.stat_rate.Size = new System.Drawing.Size(88, 23);
            this.stat_rate.TabIndex = 1;
            // 
            // stat_favor
            // 
            this.stat_favor.Location = new System.Drawing.Point(137, 219);
            this.stat_favor.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.stat_favor.Name = "stat_favor";
            this.stat_favor.Size = new System.Drawing.Size(88, 23);
            this.stat_favor.TabIndex = 1;
            this.stat_favor.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // stat_num
            // 
            this.stat_num.Location = new System.Drawing.Point(27, 219);
            this.stat_num.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.stat_num.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.stat_num.Name = "stat_num";
            this.stat_num.Size = new System.Drawing.Size(88, 23);
            this.stat_num.TabIndex = 1;
            this.stat_num.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.stat_num.ValueChanged += new System.EventHandler(this.stat_num_ValueChanged);
            // 
            // stat_skill2
            // 
            this.stat_skill2.Location = new System.Drawing.Point(137, 274);
            this.stat_skill2.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.stat_skill2.Name = "stat_skill2";
            this.stat_skill2.Size = new System.Drawing.Size(88, 23);
            this.stat_skill2.TabIndex = 1;
            // 
            // stat_pos
            // 
            this.stat_pos.Location = new System.Drawing.Point(28, 334);
            this.stat_pos.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.stat_pos.Name = "stat_pos";
            this.stat_pos.Size = new System.Drawing.Size(40, 23);
            this.stat_pos.TabIndex = 1;
            this.stat_pos.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // stat_skill1
            // 
            this.stat_skill1.Location = new System.Drawing.Point(28, 274);
            this.stat_skill1.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.stat_skill1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.stat_skill1.Name = "stat_skill1";
            this.stat_skill1.Size = new System.Drawing.Size(88, 23);
            this.stat_skill1.TabIndex = 1;
            this.stat_skill1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // stat_dodge
            // 
            this.stat_dodge.Location = new System.Drawing.Point(27, 168);
            this.stat_dodge.Maximum = new decimal(new int[] {
            1215752191,
            23,
            0,
            0});
            this.stat_dodge.Name = "stat_dodge";
            this.stat_dodge.Size = new System.Drawing.Size(88, 23);
            this.stat_dodge.TabIndex = 1;
            // 
            // stat_fire
            // 
            this.stat_fire.Location = new System.Drawing.Point(27, 115);
            this.stat_fire.Maximum = new decimal(new int[] {
            1215752191,
            23,
            0,
            0});
            this.stat_fire.Name = "stat_fire";
            this.stat_fire.Size = new System.Drawing.Size(88, 23);
            this.stat_fire.TabIndex = 1;
            // 
            // stat_level
            // 
            this.stat_level.Location = new System.Drawing.Point(26, 64);
            this.stat_level.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.stat_level.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.stat_level.Name = "stat_level";
            this.stat_level.Size = new System.Drawing.Size(88, 23);
            this.stat_level.TabIndex = 1;
            this.stat_level.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.stat_level.ValueChanged += new System.EventHandler(this.stat_level_ValueChanged);
            // 
            // applybtn
            // 
            this.applybtn.Enabled = false;
            this.applybtn.Location = new System.Drawing.Point(760, 532);
            this.applybtn.Name = "applybtn";
            this.applybtn.Size = new System.Drawing.Size(96, 23);
            this.applybtn.TabIndex = 5;
            this.applybtn.Text = "決定";
            this.applybtn.UseVisualStyleBackColor = true;
            this.applybtn.Click += new System.EventHandler(this.applybtn_Click);
            // 
            // gunselector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 567);
            this.Controls.Add(this.applybtn);
            this.Controls.Add(this.stat_groupbox);
            this.Controls.Add(this.searchbtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.gunNametextbox);
            this.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "gunselector";
            this.Text = "gunselector";
            this.Load += new System.EventHandler(this.gunselector_Load);
            this.stat_groupbox.ResumeLayout(false);
            this.stat_groupbox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stat_hp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stat_hit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stat_ammo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stat_mre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stat_rate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stat_favor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stat_num)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stat_skill2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stat_pos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stat_skill1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stat_dodge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stat_fire)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stat_level)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox gunNametextbox;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader gundb_ID;
        private System.Windows.Forms.ColumnHeader gundb_name;
        private System.Windows.Forms.ColumnHeader gundb_type;
        private System.Windows.Forms.ColumnHeader gundb_rare;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button searchbtn;
        private System.Windows.Forms.GroupBox stat_groupbox;
        private System.Windows.Forms.NumericUpDown stat_level;
        private System.Windows.Forms.ColumnHeader gundb_codename;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown stat_hp;
        private System.Windows.Forms.NumericUpDown stat_hit;
        private System.Windows.Forms.NumericUpDown stat_rate;
        private System.Windows.Forms.NumericUpDown stat_num;
        private System.Windows.Forms.NumericUpDown stat_dodge;
        private System.Windows.Forms.NumericUpDown stat_fire;
        private System.Windows.Forms.CheckBox stat_oath;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown stat_favor;
        private System.Windows.Forms.NumericUpDown stat_skill2;
        private System.Windows.Forms.NumericUpDown stat_skill1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown stat_pos;
        private System.Windows.Forms.CheckBox stat_autocalc;
        private System.Windows.Forms.Button applybtn;
        private System.Windows.Forms.ComboBox stat_teamid;
        private System.Windows.Forms.ComboBox stat_inteamlocation;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NumericUpDown stat_ammo;
        private System.Windows.Forms.NumericUpDown stat_mre;
    }
}