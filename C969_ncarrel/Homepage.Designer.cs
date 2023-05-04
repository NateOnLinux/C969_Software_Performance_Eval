
namespace C969_ncarrel
{
    partial class Homepage
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
            this.Exit = new System.Windows.Forms.Button();
            this.tabControlMainScreen = new System.Windows.Forms.TabControl();
            this.tabPageCalendar = new System.Windows.Forms.TabPage();
            this.rbDay = new System.Windows.Forms.RadioButton();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.rbWeek = new System.Windows.Forms.RadioButton();
            this.rbMonth = new System.Windows.Forms.RadioButton();
            this.dgvCalendar = new System.Windows.Forms.DataGridView();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.tabPageCustomers = new System.Windows.Forms.TabPage();
            this.labelEditWarning = new System.Windows.Forms.Label();
            this.gbStatus = new System.Windows.Forms.GroupBox();
            this.rbInactive = new System.Windows.Forms.RadioButton();
            this.rbActive = new System.Windows.Forms.RadioButton();
            this.btnCustDelete = new System.Windows.Forms.Button();
            this.btnCustEdit = new System.Windows.Forms.Button();
            this.btnCustNew = new System.Windows.Forms.Button();
            this.labelCustCountry = new System.Windows.Forms.Label();
            this.labelCustCity = new System.Windows.Forms.Label();
            this.labelCustZIP = new System.Windows.Forms.Label();
            this.labelCustAddress2 = new System.Windows.Forms.Label();
            this.labelCustAddress = new System.Windows.Forms.Label();
            this.cbCustCountry = new System.Windows.Forms.ComboBox();
            this.tbCustCity = new System.Windows.Forms.TextBox();
            this.tbCustZIP = new System.Windows.Forms.TextBox();
            this.tbCustAddress2 = new System.Windows.Forms.TextBox();
            this.tbCustAddress = new System.Windows.Forms.TextBox();
            this.labelCustPhone = new System.Windows.Forms.Label();
            this.tbCustPhone = new System.Windows.Forms.TextBox();
            this.labelCustName = new System.Windows.Forms.Label();
            this.tbCustName = new System.Windows.Forms.TextBox();
            this.dgvCustomers = new System.Windows.Forms.DataGridView();
            this.tabPageAppointments = new System.Windows.Forms.TabPage();
            this.labelTitle = new System.Windows.Forms.Label();
            this.tbApptTitle = new System.Windows.Forms.TextBox();
            this.btnApptSave = new System.Windows.Forms.Button();
            this.dtpApptEnd = new System.Windows.Forms.DateTimePicker();
            this.dtpApptStart = new System.Windows.Forms.DateTimePicker();
            this.labelApptEnd = new System.Windows.Forms.Label();
            this.labelApptType = new System.Windows.Forms.Label();
            this.labelApptContact = new System.Windows.Forms.Label();
            this.labelApptLocation = new System.Windows.Forms.Label();
            this.labelApptDescription = new System.Windows.Forms.Label();
            this.tbApptType = new System.Windows.Forms.TextBox();
            this.tbApptContact = new System.Windows.Forms.TextBox();
            this.tbApptLocation = new System.Windows.Forms.TextBox();
            this.tbApptDescription = new System.Windows.Forms.TextBox();
            this.labelApptURL = new System.Windows.Forms.Label();
            this.tbApptURL = new System.Windows.Forms.TextBox();
            this.labelApptStart = new System.Windows.Forms.Label();
            this.labelApptCustomer = new System.Windows.Forms.Label();
            this.tbApptsCustomer = new System.Windows.Forms.TextBox();
            this.dgvCustomersAppt = new System.Windows.Forms.DataGridView();
            this.tabPageSysReports = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControlMainScreen.SuspendLayout();
            this.tabPageCalendar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCalendar)).BeginInit();
            this.tabPageCustomers.SuspendLayout();
            this.gbStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).BeginInit();
            this.tabPageAppointments.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomersAppt)).BeginInit();
            this.SuspendLayout();
            // 
            // Exit
            // 
            this.Exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Exit.Location = new System.Drawing.Point(852, 321);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(75, 23);
            this.Exit.TabIndex = 1;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // tabControlMainScreen
            // 
            this.tabControlMainScreen.Controls.Add(this.tabPageCalendar);
            this.tabControlMainScreen.Controls.Add(this.tabPageCustomers);
            this.tabControlMainScreen.Controls.Add(this.tabPageAppointments);
            this.tabControlMainScreen.Controls.Add(this.tabPageSysReports);
            this.tabControlMainScreen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlMainScreen.Location = new System.Drawing.Point(0, 0);
            this.tabControlMainScreen.Name = "tabControlMainScreen";
            this.tabControlMainScreen.SelectedIndex = 0;
            this.tabControlMainScreen.Size = new System.Drawing.Size(939, 351);
            this.tabControlMainScreen.TabIndex = 2;
            this.tabControlMainScreen.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tabControlMainScreen_Selecting);
            // 
            // tabPageCalendar
            // 
            this.tabPageCalendar.Controls.Add(this.label1);
            this.tabPageCalendar.Controls.Add(this.rbDay);
            this.tabPageCalendar.Controls.Add(this.btnEdit);
            this.tabPageCalendar.Controls.Add(this.btnDelete);
            this.tabPageCalendar.Controls.Add(this.rbWeek);
            this.tabPageCalendar.Controls.Add(this.rbMonth);
            this.tabPageCalendar.Controls.Add(this.dgvCalendar);
            this.tabPageCalendar.Controls.Add(this.monthCalendar1);
            this.tabPageCalendar.Location = new System.Drawing.Point(4, 22);
            this.tabPageCalendar.Name = "tabPageCalendar";
            this.tabPageCalendar.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCalendar.Size = new System.Drawing.Size(931, 325);
            this.tabPageCalendar.TabIndex = 0;
            this.tabPageCalendar.Text = "Calendar View";
            this.tabPageCalendar.UseVisualStyleBackColor = true;
            // 
            // rbDay
            // 
            this.rbDay.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbDay.AutoSize = true;
            this.rbDay.Location = new System.Drawing.Point(253, 9);
            this.rbDay.Name = "rbDay";
            this.rbDay.Size = new System.Drawing.Size(36, 23);
            this.rbDay.TabIndex = 6;
            this.rbDay.TabStop = true;
            this.rbDay.Text = "Day";
            this.rbDay.UseVisualStyleBackColor = true;
            this.rbDay.CheckedChanged += new System.EventHandler(this.rbDay_CheckedChanged);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(767, 9);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 5;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(848, 9);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // rbWeek
            // 
            this.rbWeek.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbWeek.AutoSize = true;
            this.rbWeek.Location = new System.Drawing.Point(295, 9);
            this.rbWeek.Name = "rbWeek";
            this.rbWeek.Size = new System.Drawing.Size(46, 23);
            this.rbWeek.TabIndex = 3;
            this.rbWeek.TabStop = true;
            this.rbWeek.Text = "Week";
            this.rbWeek.UseVisualStyleBackColor = true;
            this.rbWeek.CheckedChanged += new System.EventHandler(this.rbDay_CheckedChanged);
            // 
            // rbMonth
            // 
            this.rbMonth.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbMonth.AutoSize = true;
            this.rbMonth.Location = new System.Drawing.Point(347, 9);
            this.rbMonth.Name = "rbMonth";
            this.rbMonth.Size = new System.Drawing.Size(47, 23);
            this.rbMonth.TabIndex = 2;
            this.rbMonth.TabStop = true;
            this.rbMonth.Text = "Month";
            this.rbMonth.UseVisualStyleBackColor = true;
            this.rbMonth.CheckedChanged += new System.EventHandler(this.rbDay_CheckedChanged);
            // 
            // dgvCalendar
            // 
            this.dgvCalendar.AllowUserToAddRows = false;
            this.dgvCalendar.AllowUserToDeleteRows = false;
            this.dgvCalendar.AllowUserToOrderColumns = true;
            this.dgvCalendar.AllowUserToResizeColumns = false;
            this.dgvCalendar.AllowUserToResizeRows = false;
            this.dgvCalendar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCalendar.Location = new System.Drawing.Point(253, 38);
            this.dgvCalendar.Name = "dgvCalendar";
            this.dgvCalendar.ReadOnly = true;
            this.dgvCalendar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCalendar.Size = new System.Drawing.Size(670, 281);
            this.dgvCalendar.TabIndex = 1;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(14, 38);
            this.monthCalendar1.MaxSelectionCount = 1;
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 0;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // tabPageCustomers
            // 
            this.tabPageCustomers.Controls.Add(this.labelEditWarning);
            this.tabPageCustomers.Controls.Add(this.gbStatus);
            this.tabPageCustomers.Controls.Add(this.btnCustDelete);
            this.tabPageCustomers.Controls.Add(this.btnCustEdit);
            this.tabPageCustomers.Controls.Add(this.btnCustNew);
            this.tabPageCustomers.Controls.Add(this.labelCustCountry);
            this.tabPageCustomers.Controls.Add(this.labelCustCity);
            this.tabPageCustomers.Controls.Add(this.labelCustZIP);
            this.tabPageCustomers.Controls.Add(this.labelCustAddress2);
            this.tabPageCustomers.Controls.Add(this.labelCustAddress);
            this.tabPageCustomers.Controls.Add(this.cbCustCountry);
            this.tabPageCustomers.Controls.Add(this.tbCustCity);
            this.tabPageCustomers.Controls.Add(this.tbCustZIP);
            this.tabPageCustomers.Controls.Add(this.tbCustAddress2);
            this.tabPageCustomers.Controls.Add(this.tbCustAddress);
            this.tabPageCustomers.Controls.Add(this.labelCustPhone);
            this.tabPageCustomers.Controls.Add(this.tbCustPhone);
            this.tabPageCustomers.Controls.Add(this.labelCustName);
            this.tabPageCustomers.Controls.Add(this.tbCustName);
            this.tabPageCustomers.Controls.Add(this.dgvCustomers);
            this.tabPageCustomers.Location = new System.Drawing.Point(4, 22);
            this.tabPageCustomers.Name = "tabPageCustomers";
            this.tabPageCustomers.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCustomers.Size = new System.Drawing.Size(931, 325);
            this.tabPageCustomers.TabIndex = 1;
            this.tabPageCustomers.Text = "Manage Customers";
            this.tabPageCustomers.UseVisualStyleBackColor = true;
            // 
            // labelEditWarning
            // 
            this.labelEditWarning.AutoSize = true;
            this.labelEditWarning.ForeColor = System.Drawing.Color.Red;
            this.labelEditWarning.Location = new System.Drawing.Point(724, 304);
            this.labelEditWarning.Name = "labelEditWarning";
            this.labelEditWarning.Size = new System.Drawing.Size(155, 13);
            this.labelEditWarning.TabIndex = 25;
            this.labelEditWarning.Text = "You are currently editing UID -1";
            this.labelEditWarning.Visible = false;
            // 
            // gbStatus
            // 
            this.gbStatus.Controls.Add(this.rbInactive);
            this.gbStatus.Controls.Add(this.rbActive);
            this.gbStatus.Location = new System.Drawing.Point(23, 256);
            this.gbStatus.Name = "gbStatus";
            this.gbStatus.Size = new System.Drawing.Size(102, 61);
            this.gbStatus.TabIndex = 24;
            this.gbStatus.TabStop = false;
            this.gbStatus.Text = "Status";
            // 
            // rbInactive
            // 
            this.rbInactive.AutoSize = true;
            this.rbInactive.Location = new System.Drawing.Point(38, 38);
            this.rbInactive.Name = "rbInactive";
            this.rbInactive.Size = new System.Drawing.Size(63, 17);
            this.rbInactive.TabIndex = 1;
            this.rbInactive.Text = "Inactive";
            this.rbInactive.UseVisualStyleBackColor = true;
            // 
            // rbActive
            // 
            this.rbActive.AutoSize = true;
            this.rbActive.Checked = true;
            this.rbActive.Location = new System.Drawing.Point(38, 15);
            this.rbActive.Name = "rbActive";
            this.rbActive.Size = new System.Drawing.Size(55, 17);
            this.rbActive.TabIndex = 0;
            this.rbActive.TabStop = true;
            this.rbActive.Text = "Active";
            this.rbActive.UseVisualStyleBackColor = true;
            // 
            // btnCustDelete
            // 
            this.btnCustDelete.Location = new System.Drawing.Point(836, 264);
            this.btnCustDelete.Name = "btnCustDelete";
            this.btnCustDelete.Size = new System.Drawing.Size(87, 23);
            this.btnCustDelete.TabIndex = 23;
            this.btnCustDelete.Text = "Delete";
            this.btnCustDelete.UseVisualStyleBackColor = true;
            this.btnCustDelete.Click += new System.EventHandler(this.btnCustDelete_Click);
            // 
            // btnCustEdit
            // 
            this.btnCustEdit.Location = new System.Drawing.Point(836, 235);
            this.btnCustEdit.Name = "btnCustEdit";
            this.btnCustEdit.Size = new System.Drawing.Size(87, 23);
            this.btnCustEdit.TabIndex = 22;
            this.btnCustEdit.Text = "Edit";
            this.btnCustEdit.UseVisualStyleBackColor = true;
            this.btnCustEdit.Click += new System.EventHandler(this.btnCustEdit_Click);
            // 
            // btnCustNew
            // 
            this.btnCustNew.Location = new System.Drawing.Point(836, 204);
            this.btnCustNew.Name = "btnCustNew";
            this.btnCustNew.Size = new System.Drawing.Size(87, 23);
            this.btnCustNew.TabIndex = 21;
            this.btnCustNew.Text = "Add New";
            this.btnCustNew.UseVisualStyleBackColor = true;
            this.btnCustNew.Click += new System.EventHandler(this.btnCustNew_Click);
            // 
            // labelCustCountry
            // 
            this.labelCustCountry.AutoSize = true;
            this.labelCustCountry.Location = new System.Drawing.Point(469, 235);
            this.labelCustCountry.Name = "labelCustCountry";
            this.labelCustCountry.Size = new System.Drawing.Size(43, 13);
            this.labelCustCountry.TabIndex = 20;
            this.labelCustCountry.Text = "Country";
            // 
            // labelCustCity
            // 
            this.labelCustCity.AutoSize = true;
            this.labelCustCity.Location = new System.Drawing.Point(488, 209);
            this.labelCustCity.Name = "labelCustCity";
            this.labelCustCity.Size = new System.Drawing.Size(24, 13);
            this.labelCustCity.TabIndex = 19;
            this.labelCustCity.Text = "City";
            // 
            // labelCustZIP
            // 
            this.labelCustZIP.AutoSize = true;
            this.labelCustZIP.Location = new System.Drawing.Point(267, 261);
            this.labelCustZIP.Name = "labelCustZIP";
            this.labelCustZIP.Size = new System.Drawing.Size(24, 13);
            this.labelCustZIP.TabIndex = 18;
            this.labelCustZIP.Text = "ZIP";
            // 
            // labelCustAddress2
            // 
            this.labelCustAddress2.AutoSize = true;
            this.labelCustAddress2.Location = new System.Drawing.Point(255, 235);
            this.labelCustAddress2.Name = "labelCustAddress2";
            this.labelCustAddress2.Size = new System.Drawing.Size(36, 13);
            this.labelCustAddress2.TabIndex = 17;
            this.labelCustAddress2.Text = "Line 2";
            // 
            // labelCustAddress
            // 
            this.labelCustAddress.AutoSize = true;
            this.labelCustAddress.Location = new System.Drawing.Point(246, 209);
            this.labelCustAddress.Name = "labelCustAddress";
            this.labelCustAddress.Size = new System.Drawing.Size(45, 13);
            this.labelCustAddress.TabIndex = 16;
            this.labelCustAddress.Text = "Address";
            // 
            // cbCustCountry
            // 
            this.cbCustCountry.FormattingEnabled = true;
            this.cbCustCountry.Location = new System.Drawing.Point(518, 232);
            this.cbCustCountry.Name = "cbCustCountry";
            this.cbCustCountry.Size = new System.Drawing.Size(121, 21);
            this.cbCustCountry.TabIndex = 15;
            // 
            // tbCustCity
            // 
            this.tbCustCity.Location = new System.Drawing.Point(518, 206);
            this.tbCustCity.Name = "tbCustCity";
            this.tbCustCity.Size = new System.Drawing.Size(168, 20);
            this.tbCustCity.TabIndex = 14;
            // 
            // tbCustZIP
            // 
            this.tbCustZIP.Location = new System.Drawing.Point(297, 258);
            this.tbCustZIP.Name = "tbCustZIP";
            this.tbCustZIP.Size = new System.Drawing.Size(121, 20);
            this.tbCustZIP.TabIndex = 13;
            // 
            // tbCustAddress2
            // 
            this.tbCustAddress2.Location = new System.Drawing.Point(297, 232);
            this.tbCustAddress2.Name = "tbCustAddress2";
            this.tbCustAddress2.Size = new System.Drawing.Size(168, 20);
            this.tbCustAddress2.TabIndex = 12;
            // 
            // tbCustAddress
            // 
            this.tbCustAddress.Location = new System.Drawing.Point(297, 206);
            this.tbCustAddress.Name = "tbCustAddress";
            this.tbCustAddress.Size = new System.Drawing.Size(168, 20);
            this.tbCustAddress.TabIndex = 11;
            // 
            // labelCustPhone
            // 
            this.labelCustPhone.AutoSize = true;
            this.labelCustPhone.Location = new System.Drawing.Point(28, 235);
            this.labelCustPhone.Name = "labelCustPhone";
            this.labelCustPhone.Size = new System.Drawing.Size(38, 13);
            this.labelCustPhone.TabIndex = 10;
            this.labelCustPhone.Text = "Phone";
            // 
            // tbCustPhone
            // 
            this.tbCustPhone.Location = new System.Drawing.Point(72, 232);
            this.tbCustPhone.Name = "tbCustPhone";
            this.tbCustPhone.Size = new System.Drawing.Size(168, 20);
            this.tbCustPhone.TabIndex = 8;
            // 
            // labelCustName
            // 
            this.labelCustName.AutoSize = true;
            this.labelCustName.Location = new System.Drawing.Point(31, 209);
            this.labelCustName.Name = "labelCustName";
            this.labelCustName.Size = new System.Drawing.Size(35, 13);
            this.labelCustName.TabIndex = 6;
            this.labelCustName.Text = "Name";
            // 
            // tbCustName
            // 
            this.tbCustName.Location = new System.Drawing.Point(72, 206);
            this.tbCustName.Name = "tbCustName";
            this.tbCustName.Size = new System.Drawing.Size(168, 20);
            this.tbCustName.TabIndex = 5;
            // 
            // dgvCustomers
            // 
            this.dgvCustomers.AllowUserToAddRows = false;
            this.dgvCustomers.AllowUserToDeleteRows = false;
            this.dgvCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomers.Location = new System.Drawing.Point(6, 3);
            this.dgvCustomers.MultiSelect = false;
            this.dgvCustomers.Name = "dgvCustomers";
            this.dgvCustomers.ReadOnly = true;
            this.dgvCustomers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCustomers.Size = new System.Drawing.Size(919, 197);
            this.dgvCustomers.TabIndex = 4;
            this.dgvCustomers.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCustomers_CellDoubleClick);
            // 
            // tabPageAppointments
            // 
            this.tabPageAppointments.Controls.Add(this.labelTitle);
            this.tabPageAppointments.Controls.Add(this.tbApptTitle);
            this.tabPageAppointments.Controls.Add(this.btnApptSave);
            this.tabPageAppointments.Controls.Add(this.dtpApptEnd);
            this.tabPageAppointments.Controls.Add(this.dtpApptStart);
            this.tabPageAppointments.Controls.Add(this.labelApptEnd);
            this.tabPageAppointments.Controls.Add(this.labelApptType);
            this.tabPageAppointments.Controls.Add(this.labelApptContact);
            this.tabPageAppointments.Controls.Add(this.labelApptLocation);
            this.tabPageAppointments.Controls.Add(this.labelApptDescription);
            this.tabPageAppointments.Controls.Add(this.tbApptType);
            this.tabPageAppointments.Controls.Add(this.tbApptContact);
            this.tabPageAppointments.Controls.Add(this.tbApptLocation);
            this.tabPageAppointments.Controls.Add(this.tbApptDescription);
            this.tabPageAppointments.Controls.Add(this.labelApptURL);
            this.tabPageAppointments.Controls.Add(this.tbApptURL);
            this.tabPageAppointments.Controls.Add(this.labelApptStart);
            this.tabPageAppointments.Controls.Add(this.labelApptCustomer);
            this.tabPageAppointments.Controls.Add(this.tbApptsCustomer);
            this.tabPageAppointments.Controls.Add(this.dgvCustomersAppt);
            this.tabPageAppointments.Location = new System.Drawing.Point(4, 22);
            this.tabPageAppointments.Name = "tabPageAppointments";
            this.tabPageAppointments.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAppointments.Size = new System.Drawing.Size(931, 325);
            this.tabPageAppointments.TabIndex = 2;
            this.tabPageAppointments.Text = "New Appointment";
            this.tabPageAppointments.UseVisualStyleBackColor = true;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Location = new System.Drawing.Point(318, 213);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(27, 13);
            this.labelTitle.TabIndex = 41;
            this.labelTitle.Text = "Title";
            // 
            // tbApptTitle
            // 
            this.tbApptTitle.Location = new System.Drawing.Point(351, 210);
            this.tbApptTitle.Name = "tbApptTitle";
            this.tbApptTitle.Size = new System.Drawing.Size(168, 20);
            this.tbApptTitle.TabIndex = 40;
            // 
            // btnApptSave
            // 
            this.btnApptSave.Location = new System.Drawing.Point(836, 208);
            this.btnApptSave.Name = "btnApptSave";
            this.btnApptSave.Size = new System.Drawing.Size(87, 23);
            this.btnApptSave.TabIndex = 39;
            this.btnApptSave.Text = "Save";
            this.btnApptSave.UseVisualStyleBackColor = true;
            this.btnApptSave.Click += new System.EventHandler(this.btnApptSave_Click);
            // 
            // dtpApptEnd
            // 
            this.dtpApptEnd.CustomFormat = "dd-MM-yyyy HH:mm";
            this.dtpApptEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpApptEnd.Location = new System.Drawing.Point(78, 291);
            this.dtpApptEnd.Name = "dtpApptEnd";
            this.dtpApptEnd.Size = new System.Drawing.Size(200, 20);
            this.dtpApptEnd.TabIndex = 38;
            // 
            // dtpApptStart
            // 
            this.dtpApptStart.AllowDrop = true;
            this.dtpApptStart.CustomFormat = "dd-MM-yyyy HH:mm";
            this.dtpApptStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpApptStart.Location = new System.Drawing.Point(78, 265);
            this.dtpApptStart.Name = "dtpApptStart";
            this.dtpApptStart.Size = new System.Drawing.Size(200, 20);
            this.dtpApptStart.TabIndex = 37;
            this.dtpApptStart.Value = new System.DateTime(2023, 4, 23, 0, 0, 0, 0);
            // 
            // labelApptEnd
            // 
            this.labelApptEnd.AutoSize = true;
            this.labelApptEnd.Location = new System.Drawing.Point(46, 295);
            this.labelApptEnd.Name = "labelApptEnd";
            this.labelApptEnd.Size = new System.Drawing.Size(26, 13);
            this.labelApptEnd.TabIndex = 36;
            this.labelApptEnd.Text = "End";
            // 
            // labelApptType
            // 
            this.labelApptType.AutoSize = true;
            this.labelApptType.Location = new System.Drawing.Point(314, 265);
            this.labelApptType.Name = "labelApptType";
            this.labelApptType.Size = new System.Drawing.Size(31, 13);
            this.labelApptType.TabIndex = 35;
            this.labelApptType.Text = "Type";
            // 
            // labelApptContact
            // 
            this.labelApptContact.AutoSize = true;
            this.labelApptContact.Location = new System.Drawing.Point(530, 240);
            this.labelApptContact.Name = "labelApptContact";
            this.labelApptContact.Size = new System.Drawing.Size(44, 13);
            this.labelApptContact.TabIndex = 34;
            this.labelApptContact.Text = "Contact";
            // 
            // labelApptLocation
            // 
            this.labelApptLocation.AutoSize = true;
            this.labelApptLocation.Location = new System.Drawing.Point(526, 214);
            this.labelApptLocation.Name = "labelApptLocation";
            this.labelApptLocation.Size = new System.Drawing.Size(48, 13);
            this.labelApptLocation.TabIndex = 33;
            this.labelApptLocation.Text = "Location";
            // 
            // labelApptDescription
            // 
            this.labelApptDescription.AutoSize = true;
            this.labelApptDescription.Location = new System.Drawing.Point(288, 239);
            this.labelApptDescription.Name = "labelApptDescription";
            this.labelApptDescription.Size = new System.Drawing.Size(60, 13);
            this.labelApptDescription.TabIndex = 32;
            this.labelApptDescription.Text = "Description";
            // 
            // tbApptType
            // 
            this.tbApptType.Location = new System.Drawing.Point(351, 262);
            this.tbApptType.Name = "tbApptType";
            this.tbApptType.Size = new System.Drawing.Size(168, 20);
            this.tbApptType.TabIndex = 30;
            // 
            // tbApptContact
            // 
            this.tbApptContact.Location = new System.Drawing.Point(577, 237);
            this.tbApptContact.Name = "tbApptContact";
            this.tbApptContact.Size = new System.Drawing.Size(121, 20);
            this.tbApptContact.TabIndex = 29;
            // 
            // tbApptLocation
            // 
            this.tbApptLocation.Location = new System.Drawing.Point(577, 211);
            this.tbApptLocation.Name = "tbApptLocation";
            this.tbApptLocation.Size = new System.Drawing.Size(168, 20);
            this.tbApptLocation.TabIndex = 28;
            // 
            // tbApptDescription
            // 
            this.tbApptDescription.Location = new System.Drawing.Point(351, 236);
            this.tbApptDescription.Name = "tbApptDescription";
            this.tbApptDescription.Size = new System.Drawing.Size(168, 20);
            this.tbApptDescription.TabIndex = 27;
            // 
            // labelApptURL
            // 
            this.labelApptURL.AutoSize = true;
            this.labelApptURL.Location = new System.Drawing.Point(43, 242);
            this.labelApptURL.Name = "labelApptURL";
            this.labelApptURL.Size = new System.Drawing.Size(29, 13);
            this.labelApptURL.TabIndex = 26;
            this.labelApptURL.Text = "URL";
            // 
            // tbApptURL
            // 
            this.tbApptURL.Location = new System.Drawing.Point(78, 239);
            this.tbApptURL.Name = "tbApptURL";
            this.tbApptURL.Size = new System.Drawing.Size(200, 20);
            this.tbApptURL.TabIndex = 24;
            // 
            // labelApptStart
            // 
            this.labelApptStart.AutoSize = true;
            this.labelApptStart.Location = new System.Drawing.Point(43, 269);
            this.labelApptStart.Name = "labelApptStart";
            this.labelApptStart.Size = new System.Drawing.Size(29, 13);
            this.labelApptStart.TabIndex = 23;
            this.labelApptStart.Text = "Start";
            // 
            // labelApptCustomer
            // 
            this.labelApptCustomer.AutoSize = true;
            this.labelApptCustomer.Location = new System.Drawing.Point(8, 213);
            this.labelApptCustomer.Name = "labelApptCustomer";
            this.labelApptCustomer.Size = new System.Drawing.Size(96, 13);
            this.labelApptCustomer.TabIndex = 22;
            this.labelApptCustomer.Text = "Selected Customer";
            // 
            // tbApptsCustomer
            // 
            this.tbApptsCustomer.Cursor = System.Windows.Forms.Cursors.Default;
            this.tbApptsCustomer.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tbApptsCustomer.Location = new System.Drawing.Point(110, 210);
            this.tbApptsCustomer.Name = "tbApptsCustomer";
            this.tbApptsCustomer.ReadOnly = true;
            this.tbApptsCustomer.Size = new System.Drawing.Size(168, 20);
            this.tbApptsCustomer.TabIndex = 21;
            // 
            // dgvCustomersAppt
            // 
            this.dgvCustomersAppt.AllowUserToAddRows = false;
            this.dgvCustomersAppt.AllowUserToDeleteRows = false;
            this.dgvCustomersAppt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomersAppt.Location = new System.Drawing.Point(6, 3);
            this.dgvCustomersAppt.MultiSelect = false;
            this.dgvCustomersAppt.Name = "dgvCustomersAppt";
            this.dgvCustomersAppt.ReadOnly = true;
            this.dgvCustomersAppt.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCustomersAppt.Size = new System.Drawing.Size(919, 198);
            this.dgvCustomersAppt.TabIndex = 1;
            this.dgvCustomersAppt.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCustomersAppt_CellClick);
            // 
            // tabPageSysReports
            // 
            this.tabPageSysReports.Location = new System.Drawing.Point(4, 22);
            this.tabPageSysReports.Name = "tabPageSysReports";
            this.tabPageSysReports.Size = new System.Drawing.Size(931, 325);
            this.tabPageSysReports.TabIndex = 3;
            this.tabPageSysReports.Text = "View System Reports";
            this.tabPageSysReports.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 255);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "label1";
            // 
            // Homepage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 351);
            this.Controls.Add(this.tabControlMainScreen);
            this.Controls.Add(this.Exit);
            this.Name = "Homepage";
            this.Text = "Homepage";
            this.Load += new System.EventHandler(this.Homepage_Load);
            this.tabControlMainScreen.ResumeLayout(false);
            this.tabPageCalendar.ResumeLayout(false);
            this.tabPageCalendar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCalendar)).EndInit();
            this.tabPageCustomers.ResumeLayout(false);
            this.tabPageCustomers.PerformLayout();
            this.gbStatus.ResumeLayout(false);
            this.gbStatus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).EndInit();
            this.tabPageAppointments.ResumeLayout(false);
            this.tabPageAppointments.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomersAppt)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Exit;
		private System.Windows.Forms.TabControl tabControlMainScreen;
		private System.Windows.Forms.TabPage tabPageCalendar;
		private System.Windows.Forms.TabPage tabPageCustomers;
		private System.Windows.Forms.TabPage tabPageAppointments;
		private System.Windows.Forms.TabPage tabPageSysReports;
		private System.Windows.Forms.DataGridView dgvCustomersAppt;
		internal System.Windows.Forms.DataGridView dgvCustomers;
        private System.Windows.Forms.Button btnCustDelete;
        private System.Windows.Forms.Button btnCustEdit;
        private System.Windows.Forms.Button btnCustNew;
        private System.Windows.Forms.Label labelCustCountry;
        private System.Windows.Forms.Label labelCustCity;
        private System.Windows.Forms.Label labelCustZIP;
        private System.Windows.Forms.Label labelCustAddress2;
        private System.Windows.Forms.Label labelCustAddress;
        private System.Windows.Forms.ComboBox cbCustCountry;
        private System.Windows.Forms.TextBox tbCustCity;
        private System.Windows.Forms.TextBox tbCustZIP;
        private System.Windows.Forms.TextBox tbCustAddress2;
        private System.Windows.Forms.TextBox tbCustAddress;
        private System.Windows.Forms.Label labelCustPhone;
        private System.Windows.Forms.TextBox tbCustPhone;
        private System.Windows.Forms.Label labelCustName;
        private System.Windows.Forms.TextBox tbCustName;
        private System.Windows.Forms.Button btnApptSave;
        private System.Windows.Forms.DateTimePicker dtpApptEnd;
        private System.Windows.Forms.DateTimePicker dtpApptStart;
        private System.Windows.Forms.Label labelApptEnd;
        private System.Windows.Forms.Label labelApptType;
        private System.Windows.Forms.Label labelApptContact;
        private System.Windows.Forms.Label labelApptLocation;
        private System.Windows.Forms.Label labelApptDescription;
        private System.Windows.Forms.TextBox tbApptType;
        private System.Windows.Forms.TextBox tbApptContact;
        private System.Windows.Forms.TextBox tbApptLocation;
        private System.Windows.Forms.TextBox tbApptDescription;
        private System.Windows.Forms.Label labelApptURL;
        private System.Windows.Forms.TextBox tbApptURL;
        private System.Windows.Forms.Label labelApptStart;
        private System.Windows.Forms.Label labelApptCustomer;
        private System.Windows.Forms.TextBox tbApptsCustomer;
        private System.Windows.Forms.GroupBox gbStatus;
        private System.Windows.Forms.RadioButton rbInactive;
        private System.Windows.Forms.RadioButton rbActive;
        private System.Windows.Forms.Label labelEditWarning;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.TextBox tbApptTitle;
        private System.Windows.Forms.RadioButton rbDay;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.RadioButton rbWeek;
        private System.Windows.Forms.RadioButton rbMonth;
        private System.Windows.Forms.DataGridView dgvCalendar;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label label1;
    }
}