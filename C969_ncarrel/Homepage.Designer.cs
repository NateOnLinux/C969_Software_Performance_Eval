
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
			this.Exit.Location = new System.Drawing.Point(852, 415);
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
			this.tabControlMainScreen.Size = new System.Drawing.Size(939, 445);
			this.tabControlMainScreen.TabIndex = 2;
			// 
			// tabPageCalendar
			// 
			this.tabPageCalendar.Location = new System.Drawing.Point(4, 22);
			this.tabPageCalendar.Name = "tabPageCalendar";
			this.tabPageCalendar.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageCalendar.Size = new System.Drawing.Size(931, 419);
			this.tabPageCalendar.TabIndex = 0;
			this.tabPageCalendar.Text = "Calendar View";
			this.tabPageCalendar.UseVisualStyleBackColor = true;
			// 
			// tabPageCustomers
			// 
			this.tabPageCustomers.Controls.Add(this.dgvCustomers);
			this.tabPageCustomers.Location = new System.Drawing.Point(4, 22);
			this.tabPageCustomers.Name = "tabPageCustomers";
			this.tabPageCustomers.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageCustomers.Size = new System.Drawing.Size(931, 419);
			this.tabPageCustomers.TabIndex = 1;
			this.tabPageCustomers.Text = "Manage Customers";
			this.tabPageCustomers.UseVisualStyleBackColor = true;
			// 
			// dgvCustomers
			// 
			this.dgvCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvCustomers.Location = new System.Drawing.Point(6, 3);
			this.dgvCustomers.Name = "dgvCustomers";
			this.dgvCustomers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvCustomers.Size = new System.Drawing.Size(919, 197);
			this.dgvCustomers.TabIndex = 4;
			// 
			// tabPageAppointments
			// 
			this.tabPageAppointments.Controls.Add(this.dgvAppointments);
			this.tabPageAppointments.Location = new System.Drawing.Point(4, 22);
			this.tabPageAppointments.Name = "tabPageAppointments";
			this.tabPageAppointments.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageAppointments.Size = new System.Drawing.Size(469, 419);
			this.tabPageAppointments.TabIndex = 2;
			this.tabPageAppointments.Text = "Manage Appointments";
			this.tabPageAppointments.UseVisualStyleBackColor = true;
			// 
			// dgvAppointments
			// 
			this.dgvAppointments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvAppointments.Location = new System.Drawing.Point(6, 3);
			this.dgvAppointments.Name = "dgvAppointments";
			this.dgvAppointments.Size = new System.Drawing.Size(919, 198);
			this.dgvAppointments.TabIndex = 1;
			// 
			// tabPageSysReports
			// 
			this.tabPageSysReports.Location = new System.Drawing.Point(4, 22);
			this.tabPageSysReports.Name = "tabPageSysReports";
			this.tabPageSysReports.Size = new System.Drawing.Size(931, 383);
			this.tabPageSysReports.TabIndex = 3;
			this.tabPageSysReports.Text = "View System Reports";
			this.tabPageSysReports.UseVisualStyleBackColor = true;
			// 
			// Homepage
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(939, 445);
			this.Controls.Add(this.tabControlMainScreen);
			this.Controls.Add(this.Exit);
			this.Name = "Homepage";
			this.Text = "Homepage";
			this.Load += new System.EventHandler(this.Homepage_Load);
			this.tabControlMainScreen.ResumeLayout(false);
			this.tabPageCustomers.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).EndInit();
			this.tabPageAppointments.ResumeLayout(false);
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
	}
}