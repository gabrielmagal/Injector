﻿namespace Injector
{
    partial class Form1
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
            this.nightForm1 = new ReaLTaiizor.Forms.NightForm();
            this.btn_close = new ReaLTaiizor.Controls.LostButton();
            this.statusbar = new ReaLTaiizor.Controls.ForeverStatusBar();
            this.group_injection = new ReaLTaiizor.Controls.ThunderGroupBox();
            this.chk_injection_close_on_inject = new ReaLTaiizor.Controls.ForeverCheckBox();
            this.chk_injection_automatic = new ReaLTaiizor.Controls.ForeverCheckBox();
            this.btn_inject = new ReaLTaiizor.Controls.LostButton();
            this.group_settings = new ReaLTaiizor.Controls.ThunderGroupBox();
            this.group_additionals = new ReaLTaiizor.Controls.ThunderGroupBox();
            this.thunderGroupBox8 = new ReaLTaiizor.Controls.ThunderGroupBox();
            this.foreverComboBox2 = new ReaLTaiizor.Controls.ForeverComboBox();
            this.group_peHeader = new ReaLTaiizor.Controls.ThunderGroupBox();
            this.cbb_peHeader = new ReaLTaiizor.Controls.ForeverComboBox();
            this.group_method = new ReaLTaiizor.Controls.ThunderGroupBox();
            this.rdb_method_ldrLoadDll = new ReaLTaiizor.Controls.ForeverRadioButton();
            this.rdb_method_manuallMap = new ReaLTaiizor.Controls.ForeverRadioButton();
            this.rdb_method_standardW = new ReaLTaiizor.Controls.ForeverRadioButton();
            this.rdb_method_standardA = new ReaLTaiizor.Controls.ForeverRadioButton();
            this.group_dll = new ReaLTaiizor.Controls.ThunderGroupBox();
            this.btn_dll_removeAll = new ReaLTaiizor.Controls.LostButton();
            this.btn_dll_remove = new ReaLTaiizor.Controls.LostButton();
            this.btn_dll_add = new ReaLTaiizor.Controls.LostButton();
            this.crownDropDownList1 = new ReaLTaiizor.Controls.CrownDropDownList();
            this.group_process = new ReaLTaiizor.Controls.ThunderGroupBox();
            this.txb_process = new ReaLTaiizor.Controls.CrownTextBox();
            this.btn_process_listAllProcess = new ReaLTaiizor.Controls.LostButton();
            this.nightForm1.SuspendLayout();
            this.group_injection.SuspendLayout();
            this.group_settings.SuspendLayout();
            this.group_additionals.SuspendLayout();
            this.thunderGroupBox8.SuspendLayout();
            this.group_peHeader.SuspendLayout();
            this.group_method.SuspendLayout();
            this.group_dll.SuspendLayout();
            this.group_process.SuspendLayout();
            this.SuspendLayout();
            // 
            // nightForm1
            // 
            this.nightForm1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.nightForm1.Controls.Add(this.btn_close);
            this.nightForm1.Controls.Add(this.statusbar);
            this.nightForm1.Controls.Add(this.group_injection);
            this.nightForm1.Controls.Add(this.group_settings);
            this.nightForm1.Controls.Add(this.group_dll);
            this.nightForm1.Controls.Add(this.group_process);
            this.nightForm1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nightForm1.DrawIcon = false;
            this.nightForm1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.nightForm1.HeadColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(58)))), ((int)(((byte)(61)))));
            this.nightForm1.Location = new System.Drawing.Point(0, 0);
            this.nightForm1.MinimumSize = new System.Drawing.Size(100, 42);
            this.nightForm1.Name = "nightForm1";
            this.nightForm1.Padding = new System.Windows.Forms.Padding(0, 31, 0, 0);
            this.nightForm1.Size = new System.Drawing.Size(559, 667);
            this.nightForm1.TabIndex = 0;
            this.nightForm1.Text = "x86 Injector";
            this.nightForm1.TextAlignment = ReaLTaiizor.Forms.NightForm.Alignment.Left;
            this.nightForm1.TitleBarTextColor = System.Drawing.Color.Gainsboro;
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(58)))), ((int)(((byte)(61)))));
            this.btn_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_close.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_close.ForeColor = System.Drawing.Color.White;
            this.btn_close.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(58)))), ((int)(((byte)(61)))));
            this.btn_close.Image = global::Injector.Properties.Resources.macos_close_30px;
            this.btn_close.Location = new System.Drawing.Point(517, -3);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(40, 34);
            this.btn_close.TabIndex = 3;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // statusbar
            // 
            this.statusbar.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.statusbar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.statusbar.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusbar.ForeColor = System.Drawing.Color.White;
            this.statusbar.Location = new System.Drawing.Point(0, 644);
            this.statusbar.Name = "statusbar";
            this.statusbar.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.statusbar.ShowTimeDate = false;
            this.statusbar.Size = new System.Drawing.Size(559, 23);
            this.statusbar.TabIndex = 11;
            this.statusbar.Text = "- Pronto para uso";
            this.statusbar.TextColor = System.Drawing.Color.White;
            this.statusbar.TimeColor = System.Drawing.Color.White;
            this.statusbar.TimeFormat = "dd.MM.yyyy - HH:mm:ss";
            // 
            // group_injection
            // 
            this.group_injection.BackColor = System.Drawing.Color.Transparent;
            this.group_injection.BodyColorA = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(58)))), ((int)(((byte)(61)))));
            this.group_injection.BodyColorB = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(58)))), ((int)(((byte)(61)))));
            this.group_injection.BodyColorC = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(58)))), ((int)(((byte)(61)))));
            this.group_injection.BodyColorD = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(58)))), ((int)(((byte)(61)))));
            this.group_injection.Controls.Add(this.chk_injection_close_on_inject);
            this.group_injection.Controls.Add(this.chk_injection_automatic);
            this.group_injection.Controls.Add(this.btn_inject);
            this.group_injection.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.group_injection.Location = new System.Drawing.Point(41, 553);
            this.group_injection.Name = "group_injection";
            this.group_injection.Size = new System.Drawing.Size(488, 87);
            this.group_injection.TabIndex = 9;
            this.group_injection.Text = "Injection";
            // 
            // chk_injection_close_on_inject
            // 
            this.chk_injection_close_on_inject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(58)))), ((int)(((byte)(61)))));
            this.chk_injection_close_on_inject.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.chk_injection_close_on_inject.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.chk_injection_close_on_inject.Checked = false;
            this.chk_injection_close_on_inject.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chk_injection_close_on_inject.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.chk_injection_close_on_inject.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.chk_injection_close_on_inject.Location = new System.Drawing.Point(250, 29);
            this.chk_injection_close_on_inject.Name = "chk_injection_close_on_inject";
            this.chk_injection_close_on_inject.Options = ReaLTaiizor.Controls.ForeverCheckBox._Options.Style1;
            this.chk_injection_close_on_inject.Size = new System.Drawing.Size(131, 22);
            this.chk_injection_close_on_inject.TabIndex = 8;
            this.chk_injection_close_on_inject.Text = "Close on inject";
            // 
            // chk_injection_automatic
            // 
            this.chk_injection_automatic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(58)))), ((int)(((byte)(61)))));
            this.chk_injection_automatic.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.chk_injection_automatic.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.chk_injection_automatic.Checked = false;
            this.chk_injection_automatic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chk_injection_automatic.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.chk_injection_automatic.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.chk_injection_automatic.Location = new System.Drawing.Point(108, 29);
            this.chk_injection_automatic.Name = "chk_injection_automatic";
            this.chk_injection_automatic.Options = ReaLTaiizor.Controls.ForeverCheckBox._Options.Style1;
            this.chk_injection_automatic.Size = new System.Drawing.Size(131, 22);
            this.chk_injection_automatic.TabIndex = 7;
            this.chk_injection_automatic.Text = "Automatic Injection";
            // 
            // btn_inject
            // 
            this.btn_inject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.btn_inject.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_inject.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_inject.ForeColor = System.Drawing.Color.White;
            this.btn_inject.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btn_inject.Image = null;
            this.btn_inject.Location = new System.Drawing.Point(119, 53);
            this.btn_inject.Name = "btn_inject";
            this.btn_inject.Size = new System.Drawing.Size(243, 23);
            this.btn_inject.TabIndex = 6;
            this.btn_inject.Text = "Inject";
            this.btn_inject.Click += new System.EventHandler(this.btn_inject_Click);
            // 
            // group_settings
            // 
            this.group_settings.BackColor = System.Drawing.Color.Transparent;
            this.group_settings.BodyColorA = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(58)))), ((int)(((byte)(61)))));
            this.group_settings.BodyColorB = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(58)))), ((int)(((byte)(61)))));
            this.group_settings.BodyColorC = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.group_settings.BodyColorD = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(58)))));
            this.group_settings.Controls.Add(this.group_additionals);
            this.group_settings.Controls.Add(this.group_method);
            this.group_settings.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.group_settings.Location = new System.Drawing.Point(41, 337);
            this.group_settings.Name = "group_settings";
            this.group_settings.Size = new System.Drawing.Size(488, 213);
            this.group_settings.TabIndex = 10;
            this.group_settings.Text = "Settings";
            // 
            // group_additionals
            // 
            this.group_additionals.BackColor = System.Drawing.Color.Transparent;
            this.group_additionals.BodyColorA = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(58)))), ((int)(((byte)(61)))));
            this.group_additionals.BodyColorB = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(58)))), ((int)(((byte)(61)))));
            this.group_additionals.BodyColorC = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(58)))), ((int)(((byte)(61)))));
            this.group_additionals.BodyColorD = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(58)))), ((int)(((byte)(61)))));
            this.group_additionals.Controls.Add(this.thunderGroupBox8);
            this.group_additionals.Controls.Add(this.group_peHeader);
            this.group_additionals.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.group_additionals.Location = new System.Drawing.Point(16, 107);
            this.group_additionals.Name = "group_additionals";
            this.group_additionals.Size = new System.Drawing.Size(457, 97);
            this.group_additionals.TabIndex = 10;
            this.group_additionals.Text = "Additionals";
            // 
            // thunderGroupBox8
            // 
            this.thunderGroupBox8.BackColor = System.Drawing.Color.Transparent;
            this.thunderGroupBox8.BodyColorA = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(58)))), ((int)(((byte)(61)))));
            this.thunderGroupBox8.BodyColorB = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(58)))), ((int)(((byte)(61)))));
            this.thunderGroupBox8.BodyColorC = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(58)))), ((int)(((byte)(61)))));
            this.thunderGroupBox8.BodyColorD = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(58)))), ((int)(((byte)(61)))));
            this.thunderGroupBox8.Controls.Add(this.foreverComboBox2);
            this.thunderGroupBox8.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.thunderGroupBox8.Location = new System.Drawing.Point(168, 28);
            this.thunderGroupBox8.Name = "thunderGroupBox8";
            this.thunderGroupBox8.Size = new System.Drawing.Size(281, 62);
            this.thunderGroupBox8.TabIndex = 12;
            // 
            // foreverComboBox2
            // 
            this.foreverComboBox2.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(29)))));
            this.foreverComboBox2.BGColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.foreverComboBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.foreverComboBox2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.foreverComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.foreverComboBox2.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.foreverComboBox2.ForeColor = System.Drawing.Color.White;
            this.foreverComboBox2.FormattingEnabled = true;
            this.foreverComboBox2.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.foreverComboBox2.HoverFontColor = System.Drawing.Color.White;
            this.foreverComboBox2.ItemHeight = 18;
            this.foreverComboBox2.Location = new System.Drawing.Point(13, 30);
            this.foreverComboBox2.Name = "foreverComboBox2";
            this.foreverComboBox2.Size = new System.Drawing.Size(256, 24);
            this.foreverComboBox2.TabIndex = 1;
            // 
            // group_peHeader
            // 
            this.group_peHeader.BackColor = System.Drawing.Color.Transparent;
            this.group_peHeader.BodyColorA = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(58)))), ((int)(((byte)(61)))));
            this.group_peHeader.BodyColorB = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(58)))), ((int)(((byte)(61)))));
            this.group_peHeader.BodyColorC = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(58)))), ((int)(((byte)(61)))));
            this.group_peHeader.BodyColorD = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(58)))), ((int)(((byte)(61)))));
            this.group_peHeader.Controls.Add(this.cbb_peHeader);
            this.group_peHeader.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.group_peHeader.Location = new System.Drawing.Point(8, 28);
            this.group_peHeader.Name = "group_peHeader";
            this.group_peHeader.Size = new System.Drawing.Size(157, 62);
            this.group_peHeader.TabIndex = 11;
            this.group_peHeader.Text = "PEHeader";
            // 
            // cbb_peHeader
            // 
            this.cbb_peHeader.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(29)))));
            this.cbb_peHeader.BGColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.cbb_peHeader.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbb_peHeader.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbb_peHeader.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_peHeader.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.cbb_peHeader.ForeColor = System.Drawing.Color.White;
            this.cbb_peHeader.FormattingEnabled = true;
            this.cbb_peHeader.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.cbb_peHeader.HoverFontColor = System.Drawing.Color.White;
            this.cbb_peHeader.ItemHeight = 18;
            this.cbb_peHeader.Items.AddRange(new object[] {
            "Erase",
            "Fake",
            "Random"});
            this.cbb_peHeader.Location = new System.Drawing.Point(15, 30);
            this.cbb_peHeader.Name = "cbb_peHeader";
            this.cbb_peHeader.Size = new System.Drawing.Size(121, 24);
            this.cbb_peHeader.TabIndex = 0;
            // 
            // group_method
            // 
            this.group_method.BackColor = System.Drawing.Color.Transparent;
            this.group_method.BodyColorA = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(58)))), ((int)(((byte)(61)))));
            this.group_method.BodyColorB = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(58)))), ((int)(((byte)(61)))));
            this.group_method.BodyColorC = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(58)))), ((int)(((byte)(61)))));
            this.group_method.BodyColorD = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(58)))), ((int)(((byte)(61)))));
            this.group_method.Controls.Add(this.rdb_method_ldrLoadDll);
            this.group_method.Controls.Add(this.rdb_method_manuallMap);
            this.group_method.Controls.Add(this.rdb_method_standardW);
            this.group_method.Controls.Add(this.rdb_method_standardA);
            this.group_method.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.group_method.Location = new System.Drawing.Point(16, 30);
            this.group_method.Name = "group_method";
            this.group_method.Size = new System.Drawing.Size(457, 74);
            this.group_method.TabIndex = 9;
            this.group_method.Text = "Method Inject";
            // 
            // rdb_method_ldrLoadDll
            // 
            this.rdb_method_ldrLoadDll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(58)))), ((int)(((byte)(61)))));
            this.rdb_method_ldrLoadDll.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.rdb_method_ldrLoadDll.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.rdb_method_ldrLoadDll.Checked = false;
            this.rdb_method_ldrLoadDll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdb_method_ldrLoadDll.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.rdb_method_ldrLoadDll.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.rdb_method_ldrLoadDll.Location = new System.Drawing.Point(234, 37);
            this.rdb_method_ldrLoadDll.Name = "rdb_method_ldrLoadDll";
            this.rdb_method_ldrLoadDll.Options = ReaLTaiizor.Controls.ForeverRadioButton._Options.Style1;
            this.rdb_method_ldrLoadDll.Size = new System.Drawing.Size(84, 22);
            this.rdb_method_ldrLoadDll.TabIndex = 4;
            this.rdb_method_ldrLoadDll.Text = "LdrLoadll";
            // 
            // rdb_method_manuallMap
            // 
            this.rdb_method_manuallMap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(58)))), ((int)(((byte)(61)))));
            this.rdb_method_manuallMap.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.rdb_method_manuallMap.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.rdb_method_manuallMap.Checked = false;
            this.rdb_method_manuallMap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdb_method_manuallMap.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.rdb_method_manuallMap.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.rdb_method_manuallMap.Location = new System.Drawing.Point(329, 37);
            this.rdb_method_manuallMap.Name = "rdb_method_manuallMap";
            this.rdb_method_manuallMap.Options = ReaLTaiizor.Controls.ForeverRadioButton._Options.Style1;
            this.rdb_method_manuallMap.Size = new System.Drawing.Size(105, 22);
            this.rdb_method_manuallMap.TabIndex = 3;
            this.rdb_method_manuallMap.Text = "ManuallMap";
            // 
            // rdb_method_standardW
            // 
            this.rdb_method_standardW.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(58)))), ((int)(((byte)(61)))));
            this.rdb_method_standardW.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.rdb_method_standardW.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.rdb_method_standardW.Checked = false;
            this.rdb_method_standardW.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdb_method_standardW.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.rdb_method_standardW.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.rdb_method_standardW.Location = new System.Drawing.Point(127, 37);
            this.rdb_method_standardW.Name = "rdb_method_standardW";
            this.rdb_method_standardW.Options = ReaLTaiizor.Controls.ForeverRadioButton._Options.Style1;
            this.rdb_method_standardW.Size = new System.Drawing.Size(96, 22);
            this.rdb_method_standardW.TabIndex = 2;
            this.rdb_method_standardW.Text = "Standard_W";
            // 
            // rdb_method_standardA
            // 
            this.rdb_method_standardA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(58)))), ((int)(((byte)(61)))));
            this.rdb_method_standardA.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.rdb_method_standardA.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.rdb_method_standardA.Checked = false;
            this.rdb_method_standardA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdb_method_standardA.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.rdb_method_standardA.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.rdb_method_standardA.Location = new System.Drawing.Point(22, 37);
            this.rdb_method_standardA.Name = "rdb_method_standardA";
            this.rdb_method_standardA.Options = ReaLTaiizor.Controls.ForeverRadioButton._Options.Style1;
            this.rdb_method_standardA.Size = new System.Drawing.Size(94, 22);
            this.rdb_method_standardA.TabIndex = 1;
            this.rdb_method_standardA.Text = "Standard_A";
            // 
            // group_dll
            // 
            this.group_dll.BackColor = System.Drawing.Color.Transparent;
            this.group_dll.BodyColorA = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(58)))), ((int)(((byte)(61)))));
            this.group_dll.BodyColorB = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(58)))), ((int)(((byte)(61)))));
            this.group_dll.BodyColorC = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(58)))), ((int)(((byte)(61)))));
            this.group_dll.BodyColorD = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(58)))), ((int)(((byte)(61)))));
            this.group_dll.Controls.Add(this.btn_dll_removeAll);
            this.group_dll.Controls.Add(this.btn_dll_remove);
            this.group_dll.Controls.Add(this.btn_dll_add);
            this.group_dll.Controls.Add(this.crownDropDownList1);
            this.group_dll.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.group_dll.Location = new System.Drawing.Point(41, 101);
            this.group_dll.Name = "group_dll";
            this.group_dll.Size = new System.Drawing.Size(488, 233);
            this.group_dll.TabIndex = 9;
            this.group_dll.Text = "Dll";
            // 
            // btn_dll_removeAll
            // 
            this.btn_dll_removeAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.btn_dll_removeAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_dll_removeAll.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_dll_removeAll.ForeColor = System.Drawing.Color.White;
            this.btn_dll_removeAll.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btn_dll_removeAll.Image = null;
            this.btn_dll_removeAll.Location = new System.Drawing.Point(305, 199);
            this.btn_dll_removeAll.Name = "btn_dll_removeAll";
            this.btn_dll_removeAll.Size = new System.Drawing.Size(116, 23);
            this.btn_dll_removeAll.TabIndex = 5;
            this.btn_dll_removeAll.Text = "Remove All";
            // 
            // btn_dll_remove
            // 
            this.btn_dll_remove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.btn_dll_remove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_dll_remove.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_dll_remove.ForeColor = System.Drawing.Color.White;
            this.btn_dll_remove.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btn_dll_remove.Image = null;
            this.btn_dll_remove.Location = new System.Drawing.Point(186, 199);
            this.btn_dll_remove.Name = "btn_dll_remove";
            this.btn_dll_remove.Size = new System.Drawing.Size(116, 23);
            this.btn_dll_remove.TabIndex = 4;
            this.btn_dll_remove.Text = "Remove";
            // 
            // btn_dll_add
            // 
            this.btn_dll_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.btn_dll_add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_dll_add.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_dll_add.ForeColor = System.Drawing.Color.White;
            this.btn_dll_add.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btn_dll_add.Image = null;
            this.btn_dll_add.Location = new System.Drawing.Point(67, 199);
            this.btn_dll_add.Name = "btn_dll_add";
            this.btn_dll_add.Size = new System.Drawing.Size(116, 23);
            this.btn_dll_add.TabIndex = 3;
            this.btn_dll_add.Text = "Add";
            // 
            // crownDropDownList1
            // 
            this.crownDropDownList1.Location = new System.Drawing.Point(24, 34);
            this.crownDropDownList1.Name = "crownDropDownList1";
            this.crownDropDownList1.Size = new System.Drawing.Size(441, 162);
            this.crownDropDownList1.TabIndex = 0;
            this.crownDropDownList1.Text = "crownDropDownList1";
            // 
            // group_process
            // 
            this.group_process.BackColor = System.Drawing.Color.Transparent;
            this.group_process.BodyColorA = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(58)))), ((int)(((byte)(61)))));
            this.group_process.BodyColorB = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(58)))), ((int)(((byte)(61)))));
            this.group_process.BodyColorC = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(58)))), ((int)(((byte)(61)))));
            this.group_process.BodyColorD = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(58)))));
            this.group_process.Controls.Add(this.txb_process);
            this.group_process.Controls.Add(this.btn_process_listAllProcess);
            this.group_process.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.group_process.Location = new System.Drawing.Point(41, 37);
            this.group_process.Name = "group_process";
            this.group_process.Size = new System.Drawing.Size(488, 62);
            this.group_process.TabIndex = 8;
            this.group_process.Text = "Process";
            // 
            // txb_process
            // 
            this.txb_process.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(58)))), ((int)(((byte)(61)))));
            this.txb_process.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txb_process.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.txb_process.Location = new System.Drawing.Point(18, 30);
            this.txb_process.Name = "txb_process";
            this.txb_process.Size = new System.Drawing.Size(407, 23);
            this.txb_process.TabIndex = 2;
            this.txb_process.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_process_listAllProcess
            // 
            this.btn_process_listAllProcess.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.btn_process_listAllProcess.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_process_listAllProcess.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_process_listAllProcess.ForeColor = System.Drawing.Color.White;
            this.btn_process_listAllProcess.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btn_process_listAllProcess.Image = null;
            this.btn_process_listAllProcess.Location = new System.Drawing.Point(431, 30);
            this.btn_process_listAllProcess.Name = "btn_process_listAllProcess";
            this.btn_process_listAllProcess.Size = new System.Drawing.Size(40, 23);
            this.btn_process_listAllProcess.TabIndex = 1;
            this.btn_process_listAllProcess.Text = "...";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 667);
            this.Controls.Add(this.nightForm1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(1920, 1032);
            this.MinimumSize = new System.Drawing.Size(261, 61);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "themeForm1";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.nightForm1.ResumeLayout(false);
            this.group_injection.ResumeLayout(false);
            this.group_settings.ResumeLayout(false);
            this.group_additionals.ResumeLayout(false);
            this.thunderGroupBox8.ResumeLayout(false);
            this.group_peHeader.ResumeLayout(false);
            this.group_method.ResumeLayout(false);
            this.group_dll.ResumeLayout(false);
            this.group_process.ResumeLayout(false);
            this.group_process.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ReaLTaiizor.Forms.NightForm nightForm1;
        private ReaLTaiizor.Controls.CrownTextBox txb_process;
        private ReaLTaiizor.Controls.ThunderGroupBox group_process;
        private ReaLTaiizor.Controls.LostButton btn_process_listAllProcess;
        private ReaLTaiizor.Controls.ThunderGroupBox group_dll;
        private ReaLTaiizor.Controls.LostButton btn_dll_remove;
        private ReaLTaiizor.Controls.LostButton btn_dll_add;
        private ReaLTaiizor.Controls.CrownDropDownList crownDropDownList1;
        private ReaLTaiizor.Controls.ThunderGroupBox group_settings;
        private ReaLTaiizor.Controls.ThunderGroupBox group_additionals;
        private ReaLTaiizor.Controls.ThunderGroupBox group_method;
        private ReaLTaiizor.Controls.LostButton btn_dll_removeAll;
        private ReaLTaiizor.Controls.ForeverRadioButton rdb_method_standardA;
        private ReaLTaiizor.Controls.ForeverRadioButton rdb_method_standardW;
        private ReaLTaiizor.Controls.ThunderGroupBox group_injection;
        private ReaLTaiizor.Controls.ForeverCheckBox chk_injection_automatic;
        private ReaLTaiizor.Controls.LostButton btn_inject;
        private ReaLTaiizor.Controls.ForeverStatusBar statusbar;
        private ReaLTaiizor.Controls.ForeverRadioButton rdb_method_ldrLoadDll;
        private ReaLTaiizor.Controls.ForeverRadioButton rdb_method_manuallMap;
        private ReaLTaiizor.Controls.LostButton btn_close;
        private ReaLTaiizor.Controls.ForeverComboBox cbb_peHeader;
        private ReaLTaiizor.Controls.ForeverCheckBox chk_injection_close_on_inject;
        private ReaLTaiizor.Controls.ThunderGroupBox thunderGroupBox8;
        private ReaLTaiizor.Controls.ForeverComboBox foreverComboBox2;
        private ReaLTaiizor.Controls.ThunderGroupBox group_peHeader;
    }
}
