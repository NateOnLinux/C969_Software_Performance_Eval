
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
            this.tabPageCustomers = new System.Windows.Forms.TabPage();
            this.dgvCustomers = new System.Windows.Forms.DataGridView();
            this.tabPageAppointments = new System.Windows.Forms.TabPage();
            this.dgvAppointments = new System.Windows.Forms.DataGridView();
            this.tabPageSysReports = new System.Windows.Forms.TabPage();
            this.tbCustName = new System.Windows.Forms.TextBox();
            this.labelCustName = new System.Windows.Forms.Label();
            this.labelCustStatus = new System.Windows.Forms.Label();
            this.tbCustPhone = new System.Windows.Forms.TextBox();
            this.cbCustStatus = new System.Windows.Forms.ComboBox();
            this.labelCustPhone = new System.Windows.Forms.Label();
            this.tbCustAddress = new System.Windows.Forms.TextBox();
            this.tbCustAddress2 = new System.Windows.Forms.TextBox();
            this.tbCustZIP = new System.Windows.Forms.TextBox();
            this.tbCustCity = new System.Windows.Forms.TextBox();
            this.cbCustCountry = new System.Windows.Forms.ComboBox();
            this.labelCustAddress = new System.Windows.Forms.Label();
            this.labelCustAddress2 = new System.Windows.Forms.Label();
            this.labelCustZIP = new System.Windows.Forms.Label();
            this.labelCustCity = new System.Windows.Forms.Label();
            this.labelCustCountry = new System.Windows.Forms.Label();
            this.btnCustNew = new System.Windows.Forms.Button();
            this.btnCustUpdate = new System.Windows.Forms.Button();
            this.btnCustDelete = new System.Windows.Forms.Button();
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
            this.dtpApptStart = new System.Windows.Forms.DateTimePicker();
            this.dtpApptEnd = new System.Windows.Forms.DateTimePicker();
            this.btnApptClear = new System.Windows.Forms.Button();
            this.btnApptSave = new System.Windows.Forms.Button();
            this.tabControlMainScreen.SuspendLayout();
            this.tabPageCustomers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).BeginInit();
            this.tabPageAppointments.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppointments)).BeginInit();
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
            // 
            // tabPageCalendar
            // 
            this.tabPageCalendar.Location = new System.Drawing.Point(4, 22);
            this.tabPageCalendar.Name = "tabPageCalendar";
            this.tabPageCalendar.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCalendar.Size = new System.Drawing.Size(931, 325);
            this.tabPageCalendar.TabIndex = 0;
            this.tabPageCalendar.Text = "Calendar View";
            this.tabPageCalendar.UseVisualStyleBackColor = true;
            // 
            // tabPageCustomers
            // 
            this.tabPageCustomers.Controls.Add(this.btnCustDelete);
            this.tabPageCustomers.Controls.Add(this.btnCustUpdate);
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
            this.tabPageCustomers.Controls.Add(this.cbCustStatus);
            this.tabPageCustomers.Controls.Add(this.tbCustPhone);
            this.tabPageCustomers.Controls.Add(this.labelCustStatus);
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
            // 
            // tabPageAppointments
            // 
            this.tabPageAppointments.Controls.Add(this.btnApptClear);
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
            this.tabPageAppointments.Controls.Add(this.dgvAppointments);
            this.tabPageAppointments.Location = new System.Drawing.Point(4, 22);
            this.tabPageAppointments.Name = "tabPageAppointments";
            this.tabPageAppointments.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAppointments.Size = new System.Drawing.Size(931, 325);
            this.tabPageAppointments.TabIndex = 2;
            this.tabPageAppointments.Text = "New Appointment";
            this.tabPageAppointments.UseVisualStyleBackColor = true;
            // 
            // dgvAppointments
            // 
            this.dgvAppointments.AllowUserToAddRows = false;
            this.dgvAppointments.AllowUserToDeleteRows = false;
            this.dgvAppointments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAppointments.Location = new System.Drawing.Point(6, 3);
            this.dgvAppointments.MultiSelect = false;
            this.dgvAppointments.Name = "dgvAppointments";
            this.dgvAppointments.ReadOnly = true;
            this.dgvAppointments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAppointments.Size = new System.Drawing.Size(919, 198);
            this.dgvAppointments.TabIndex = 1;
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
            // tbCustName
            // 
            this.tbCustName.Location = new System.Drawing.Point(72, 206);
            this.tbCustName.Name = "tbCustName";
            this.tbCustName.Size = new System.Drawing.Size(168, 20);
            this.tbCustName.TabIndex = 5;
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
            // labelCustStatus
            // 
            this.labelCustStatus.AutoSize = true;
            this.labelCustStatus.Location = new System.Drawing.Point(29, 235);
            this.labelCustStatus.Name = "labelCustStatus";
            this.labelCustStatus.Size = new System.Drawing.Size(37, 13);
            this.labelCustStatus.TabIndex = 7;
            this.labelCustStatus.Text = "Status";
            // 
            // tbCustPhone
            // 
            this.tbCustPhone.Location = new System.Drawing.Point(72, 259);
            this.tbCustPhone.Name = "tbCustPhone";
            this.tbCustPhone.Size = new System.Drawing.Size(168, 20);
            this.tbCustPhone.TabIndex = 8;
            // 
            // cbCustStatus
            // 
            this.cbCustStatus.FormattingEnabled = true;
            this.cbCustStatus.Location = new System.Drawing.Point(72, 232);
            this.cbCustStatus.Name = "cbCustStatus";
            this.cbCustStatus.Size = new System.Drawing.Size(121, 21);
            this.cbCustStatus.TabIndex = 9;
            // 
            // labelCustPhone
            // 
            this.labelCustPhone.AutoSize = true;
            this.labelCustPhone.Location = new System.Drawing.Point(28, 262);
            this.labelCustPhone.Name = "labelCustPhone";
            this.labelCustPhone.Size = new System.Drawing.Size(38, 13);
            this.labelCustPhone.TabIndex = 10;
            this.labelCustPhone.Text = "Phone";
            // 
            // tbCustAddress
            // 
            this.tbCustAddress.Location = new System.Drawing.Point(297, 206);
            this.tbCustAddress.Name = "tbCustAddress";
            this.tbCustAddress.Size = new System.Drawing.Size(168, 20);
            this.tbCustAddress.TabIndex = 11;
            // 
            // tbCustAddress2
            // 
            this.tbCustAddress2.Location = new System.Drawing.Point(297, 232);
            this.tbCustAddress2.Name = "tbCustAddress2";
            this.tbCustAddress2.Size = new System.Drawing.Size(168, 20);
            this.tbCustAddress2.TabIndex = 12;
            // 
            // tbCustZIP
            // 
            this.tbCustZIP.Location = new System.Drawing.Point(297, 258);
            this.tbCustZIP.Name = "tbCustZIP";
            this.tbCustZIP.Size = new System.Drawing.Size(121, 20);
            this.tbCustZIP.TabIndex = 13;
            // 
            // tbCustCity
            // 
            this.tbCustCity.Location = new System.Drawing.Point(518, 206);
            this.tbCustCity.Name = "tbCustCity";
            this.tbCustCity.Size = new System.Drawing.Size(168, 20);
            this.tbCustCity.TabIndex = 14;
            // 
            // cbCustCountry
            // 
            this.cbCustCountry.FormattingEnabled = true;
            this.cbCustCountry.Location = new System.Drawing.Point(518, 232);
            this.cbCustCountry.Name = "cbCustCountry";
            this.cbCustCountry.Size = new System.Drawing.Size(121, 21);
            this.cbCustCountry.TabIndex = 15;
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
            // labelCustAddress2
            // 
            this.labelCustAddress2.AutoSize = true;
            this.labelCustAddress2.Location = new System.Drawing.Point(255, 235);
            this.labelCustAddress2.Name = "labelCustAddress2";
            this.labelCustAddress2.Size = new System.Drawing.Size(36, 13);
            this.labelCustAddress2.TabIndex = 17;
            this.labelCustAddress2.Text = "Line 2";
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
            // labelCustCity
            // 
            this.labelCustCity.AutoSize = true;
            this.labelCustCity.Location = new System.Drawing.Point(488, 209);
            this.labelCustCity.Name = "labelCustCity";
            this.labelCustCity.Size = new System.Drawing.Size(24, 13);
            this.labelCustCity.TabIndex = 19;
            this.labelCustCity.Text = "City";
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
            // btnCustNew
            // 
            this.btnCustNew.Location = new System.Drawing.Point(836, 204);
            this.btnCustNew.Name = "btnCustNew";
            this.btnCustNew.Size = new System.Drawing.Size(87, 23);
            this.btnCustNew.TabIndex = 21;
            this.btnCustNew.Text = "Add New";
            this.btnCustNew.UseVisualStyleBackColor = true;
            // 
            // btnCustUpdate
            // 
            this.btnCustUpdate.Location = new System.Drawing.Point(836, 235);
            this.btnCustUpdate.Name = "btnCustUpdate";
            this.btnCustUpdate.Size = new System.Drawing.Size(87, 23);
            this.btnCustUpdate.TabIndex = 22;
            this.btnCustUpdate.Text = "Update";
            this.btnCustUpdate.UseVisualStyleBackColor = true;
            // 
            // btnCustDelete
            // 
            this.btnCustDelete.Location = new System.Drawing.Point(836, 264);
            this.btnCustDelete.Name = "btnCustDelete";
            this.btnCustDelete.Size = new System.Drawing.Size(87, 23);
            this.btnCustDelete.TabIndex = 23;
            this.btnCustDelete.Text = "Delete";
            this.btnCustDelete.UseVisualStyleBackColor = true;
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
            this.labelApptType.Location = new System.Drawing.Point(323, 291);
            this.labelApptType.Name = "labelApptType";
            this.labelApptType.Size = new System.Drawing.Size(31, 13);
            this.labelApptType.TabIndex = 35;
            this.labelApptType.Text = "Type";
            // 
            // labelApptContact
            // 
            this.labelApptContact.AutoSize = true;
            this.labelApptContact.Location = new System.Drawing.Point(313, 265);
            this.labelApptContact.Name = "labelApptContact";
            this.labelApptContact.Size = new System.Drawing.Size(44, 13);
            this.labelApptContact.TabIndex = 34;
            this.labelApptContact.Text = "Contact";
            // 
            // labelApptLocation
            // 
            this.labelApptLocation.AutoSize = true;
            this.labelApptLocation.Location = new System.Drawing.Point(309, 239);
            this.labelApptLocation.Name = "labelApptLocation";
            this.labelApptLocation.Size = new System.Drawing.Size(48, 13);
            this.labelApptLocation.TabIndex = 33;
            this.labelApptLocation.Text = "Location";
            // 
            // labelApptDescription
            // 
            this.labelApptDescription.AutoSize = true;
            this.labelApptDescription.Location = new System.Drawing.Point(297, 213);
            this.labelApptDescription.Name = "labelApptDescription";
            this.labelApptDescription.Size = new System.Drawing.Size(60, 13);
            this.labelApptDescription.TabIndex = 32;
            this.labelApptDescription.Text = "Description";
            // 
            // tbApptType
            // 
            this.tbApptType.Location = new System.Drawing.Point(360, 288);
            this.tbApptType.Name = "tbApptType";
            this.tbApptType.Size = new System.Drawing.Size(168, 20);
            this.tbApptType.TabIndex = 30;
            // 
            // tbApptContact
            // 
            this.tbApptContact.Location = new System.Drawing.Point(360, 262);
            this.tbApptContact.Name = "tbApptContact";
            this.tbApptContact.Size = new System.Drawing.Size(121, 20);
            this.tbApptContact.TabIndex = 29;
            // 
            // tbApptLocation
            // 
            this.tbApptLocation.Location = new System.Drawing.Point(360, 236);
            this.tbApptLocation.Name = "tbApptLocation";
            this.tbApptLocation.Size = new System.Drawing.Size(168, 20);
            this.tbApptLocation.TabIndex = 28;
            // 
            // tbApptDescription
            // 
            this.tbApptDescription.Location = new System.Drawing.Point(360, 210);
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
            this.labelApptCustomer.Enabled = false;
            this.labelApptCustomer.Location = new System.Drawing.Point(8, 213);
            this.labelApptCustomer.Name = "labelApptCustomer";
            this.labelApptCustomer.Size = new System.Drawing.Size(96, 13);
            this.labelApptCustomer.TabIndex = 22;
            this.labelApptCustomer.Text = "Selected Customer";
            // 
            // tbApptsCustomer
            // 
            this.tbApptsCustomer.Enabled = false;
            this.tbApptsCustomer.Location = new System.Drawing.Point(110, 210);
            this.tbApptsCustomer.Name = "tbApptsCustomer";
            this.tbApptsCustomer.Size = new System.Drawing.Size(168, 20);
            this.tbApptsCustomer.TabIndex = 21;
            // 
            // dtpApptStart
            // 
            this.dtpApptStart.Location = new System.Drawing.Point(78, 265);
            this.dtpApptStart.Name = "dtpApptStart";
            this.dtpApptStart.Size = new System.Drawing.Size(200, 20);
            this.dtpApptStart.TabIndex = 37;
            // 
            // dtpApptEnd
            // 
            this.dtpApptEnd.Location = new System.Drawing.Point(78, 291);
            this.dtpApptEnd.Name = "dtpApptEnd";
            this.dtpApptEnd.Size = new System.Drawing.Size(200, 20);
            this.dtpApptEnd.TabIndex = 38;
            // 
            // btnApptClear
            // 
            this.btnApptClear.Location = new System.Drawing.Point(836, 239);
            this.btnApptClear.Name = "btnApptClear";
            this.btnApptClear.Size = new System.Drawing.Size(87, 23);
            this.btnApptClear.TabIndex = 40;
            this.btnApptClear.Text = "Clear";
            this.btnApptClear.UseVisualStyleBackColor = true;
            // 
            // btnApptSave
            // 
            this.btnApptSave.Location = new System.Drawing.Point(836, 208);
            this.btnApptSave.Name = "btnApptSave";
            this.btnApptSave.Size = new System.Drawing.Size(87, 23);
            this.btnApptSave.TabIndex = 39;
            this.btnApptSave.Text = "Save";
            this.btnApptSave.UseVisualStyleBackColor = true;
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
            this.tabPageCustomers.ResumeLayout(false);
            this.tabPageCustomers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).EndInit();
            this.tabPageAppointments.ResumeLayout(false);
            this.tabPageAppointments.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppointments)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Exit;
		private System.Windows.Forms.TabControl tabControlMainScreen;
		private System.Windows.Forms.TabPage tabPageCalendar;
		private System.Windows.Forms.TabPage tabPageCustomers;
		private System.Windows.Forms.TabPage tabPageAppointments;
		private System.Windows.Forms.TabPage tabPageSysReports;
		private System.Windows.Forms.DataGridView dgvAppointments;
		internal System.Windows.Forms.DataGridView dgvCustomers;
        private System.Windows.Forms.Button btnCustDelete;
        private System.Windows.Forms.Button btnCustUpdate;
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
        private System.Windows.Forms.ComboBox cbCustStatus;
        private System.Windows.Forms.TextBox tbCustPhone;
        private System.Windows.Forms.Label labelCustStatus;
        private System.Windows.Forms.Label labelCustName;
        private System.Windows.Forms.TextBox tbCustName;
        private System.Windows.Forms.Button btnApptClear;
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
    }
}