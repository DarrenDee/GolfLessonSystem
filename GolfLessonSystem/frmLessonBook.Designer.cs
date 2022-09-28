
namespace GolfLessonSystem
{
    partial class frmLessonBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLessonBook));
            this.label1 = new System.Windows.Forms.Label();
            this.dtpPickDate = new System.Windows.Forms.DateTimePicker();
            this.grpAppointments = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cboAvailableTimes = new System.Windows.Forms.ComboBox();
            this.txtMakeApp = new System.Windows.Forms.Button();
            this.txtCost = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cboPickPro = new System.Windows.Forms.ComboBox();
            this.grpInfo = new System.Windows.Forms.GroupBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtForename = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbxMemberID = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuBack = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.lblMemberName = new System.Windows.Forms.Label();
            this.grpDatePro = new System.Windows.Forms.GroupBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btmTimes = new System.Windows.Forms.Button();
            this.grpAppointments.SuspendLayout();
            this.grpInfo.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.grpDatePro.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pick a Date:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dtpPickDate
            // 
            this.dtpPickDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpPickDate.Location = new System.Drawing.Point(106, 22);
            this.dtpPickDate.Name = "dtpPickDate";
            this.dtpPickDate.Size = new System.Drawing.Size(121, 20);
            this.dtpPickDate.TabIndex = 2;
            this.dtpPickDate.ValueChanged += new System.EventHandler(this.dtpPickDate_ValueChanged);
            // 
            // grpAppointments
            // 
            this.grpAppointments.Controls.Add(this.label4);
            this.grpAppointments.Controls.Add(this.cboAvailableTimes);
            this.grpAppointments.Controls.Add(this.txtMakeApp);
            this.grpAppointments.Controls.Add(this.txtCost);
            this.grpAppointments.Controls.Add(this.label3);
            this.grpAppointments.Location = new System.Drawing.Point(61, 253);
            this.grpAppointments.Name = "grpAppointments";
            this.grpAppointments.Size = new System.Drawing.Size(407, 132);
            this.grpAppointments.TabIndex = 20;
            this.grpAppointments.TabStop = false;
            this.grpAppointments.Text = "Available Times";
            this.grpAppointments.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(55, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 16);
            this.label4.TabIndex = 24;
            this.label4.Text = "Available Times:";
            // 
            // cboAvailableTimes
            // 
            this.cboAvailableTimes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAvailableTimes.FormattingEnabled = true;
            this.cboAvailableTimes.Location = new System.Drawing.Point(53, 40);
            this.cboAvailableTimes.Name = "cboAvailableTimes";
            this.cboAvailableTimes.Size = new System.Drawing.Size(111, 21);
            this.cboAvailableTimes.TabIndex = 23;
            // 
            // txtMakeApp
            // 
            this.txtMakeApp.Location = new System.Drawing.Point(26, 90);
            this.txtMakeApp.Name = "txtMakeApp";
            this.txtMakeApp.Size = new System.Drawing.Size(172, 29);
            this.txtMakeApp.TabIndex = 3;
            this.txtMakeApp.Text = "BOOK";
            this.txtMakeApp.UseVisualStyleBackColor = true;
            this.txtMakeApp.Click += new System.EventHandler(this.txtMakeApp_Click);
            // 
            // txtCost
            // 
            this.txtCost.Location = new System.Drawing.Point(257, 64);
            this.txtCost.Name = "txtCost";
            this.txtCost.ReadOnly = true;
            this.txtCost.Size = new System.Drawing.Size(73, 20);
            this.txtCost.TabIndex = 2;
            this.txtCost.Text = "€100";
            this.txtCost.Visible = false;
            this.txtCost.TextChanged += new System.EventHandler(this.txtCost_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(258, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Total Cost:";
            // 
            // cboPickPro
            // 
            this.cboPickPro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPickPro.FormattingEnabled = true;
            this.cboPickPro.Location = new System.Drawing.Point(106, 56);
            this.cboPickPro.Name = "cboPickPro";
            this.cboPickPro.Size = new System.Drawing.Size(200, 21);
            this.cboPickPro.TabIndex = 22;
            this.cboPickPro.SelectedIndexChanged += new System.EventHandler(this.cboPickPro_SelectedIndexChanged);
            // 
            // grpInfo
            // 
            this.grpInfo.Controls.Add(this.txtID);
            this.grpInfo.Controls.Add(this.label7);
            this.grpInfo.Controls.Add(this.txtForename);
            this.grpInfo.Controls.Add(this.txtSurname);
            this.grpInfo.Controls.Add(this.label6);
            this.grpInfo.Controls.Add(this.label5);
            this.grpInfo.Location = new System.Drawing.Point(61, 27);
            this.grpInfo.Name = "grpInfo";
            this.grpInfo.Size = new System.Drawing.Size(325, 122);
            this.grpInfo.TabIndex = 23;
            this.grpInfo.TabStop = false;
            this.grpInfo.Text = "Member Details";
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(96, 17);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(42, 20);
            this.txtID.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 16);
            this.label7.TabIndex = 7;
            this.label7.Text = "MemberID";
            // 
            // txtForename
            // 
            this.txtForename.Enabled = false;
            this.txtForename.Location = new System.Drawing.Point(97, 86);
            this.txtForename.Name = "txtForename";
            this.txtForename.Size = new System.Drawing.Size(121, 20);
            this.txtForename.TabIndex = 6;
            // 
            // txtSurname
            // 
            this.txtSurname.Enabled = false;
            this.txtSurname.Location = new System.Drawing.Point(97, 52);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(121, 20);
            this.txtSurname.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(7, 86);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 16);
            this.label6.TabIndex = 2;
            this.label6.Text = "Surname: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(7, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 16);
            this.label5.TabIndex = 1;
            this.label5.Text = "Forename:";
            // 
            // cbxMemberID
            // 
            this.cbxMemberID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxMemberID.FormattingEnabled = true;
            this.cbxMemberID.Location = new System.Drawing.Point(186, 57);
            this.cbxMemberID.Name = "cbxMemberID";
            this.cbxMemberID.Size = new System.Drawing.Size(200, 21);
            this.cbxMemberID.TabIndex = 26;
            this.cbxMemberID.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuBack});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 24;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuBack
            // 
            this.mnuBack.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.mnuBack.Name = "mnuBack";
            this.mnuBack.Size = new System.Drawing.Size(44, 20);
            this.mnuBack.Text = "Back";
            this.mnuBack.Click += new System.EventHandler(this.mnuBack_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 25;
            this.label2.Text = "Pick a Pro";
            // 
            // lblMemberName
            // 
            this.lblMemberName.AutoSize = true;
            this.lblMemberName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMemberName.Location = new System.Drawing.Point(67, 57);
            this.lblMemberName.Name = "lblMemberName";
            this.lblMemberName.Size = new System.Drawing.Size(113, 20);
            this.lblMemberName.TabIndex = 27;
            this.lblMemberName.Text = "Member Name";
            // 
            // grpDatePro
            // 
            this.grpDatePro.Controls.Add(this.label1);
            this.grpDatePro.Controls.Add(this.dtpPickDate);
            this.grpDatePro.Controls.Add(this.cboPickPro);
            this.grpDatePro.Controls.Add(this.label2);
            this.grpDatePro.Location = new System.Drawing.Point(61, 155);
            this.grpDatePro.Name = "grpDatePro";
            this.grpDatePro.Size = new System.Drawing.Size(332, 92);
            this.grpDatePro.TabIndex = 25;
            this.grpDatePro.TabStop = false;
            this.grpDatePro.Text = "Date and Pro";
            this.grpDatePro.Visible = false;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(616, 44);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(172, 29);
            this.btnReset.TabIndex = 25;
            this.btnReset.Text = "Reset Booking";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btmTimes
            // 
            this.btmTimes.Location = new System.Drawing.Point(412, 218);
            this.btmTimes.Name = "btmTimes";
            this.btmTimes.Size = new System.Drawing.Size(172, 29);
            this.btmTimes.TabIndex = 28;
            this.btmTimes.Text = "Find Available Times";
            this.btmTimes.UseVisualStyleBackColor = true;
            this.btmTimes.Click += new System.EventHandler(this.btmTimes_Click);
            // 
            // frmLessonBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btmTimes);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.grpDatePro);
            this.Controls.Add(this.lblMemberName);
            this.Controls.Add(this.cbxMemberID);
            this.Controls.Add(this.grpInfo);
            this.Controls.Add(this.grpAppointments);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmLessonBook";
            this.Text = "Book a Lesson";
            this.Load += new System.EventHandler(this.frmBookLesson_Load);
            this.grpAppointments.ResumeLayout(false);
            this.grpAppointments.PerformLayout();
            this.grpInfo.ResumeLayout(false);
            this.grpInfo.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grpDatePro.ResumeLayout(false);
            this.grpDatePro.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpPickDate;
        private System.Windows.Forms.GroupBox grpAppointments;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCost;
        private System.Windows.Forms.ComboBox cboPickPro;
        private System.Windows.Forms.GroupBox grpInfo;
        private System.Windows.Forms.TextBox txtForename;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuBack;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button txtMakeApp;
        private System.Windows.Forms.Label lblMemberName;
        private System.Windows.Forms.ComboBox cbxMemberID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboAvailableTimes;
        private System.Windows.Forms.GroupBox grpDatePro;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btmTimes;
    }
}