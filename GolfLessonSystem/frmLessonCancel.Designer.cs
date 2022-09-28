
namespace GolfLessonSystem
{
    partial class frmLessonCancel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLessonCancel));
            this.label2 = new System.Windows.Forms.Label();
            this.lblPickLesson = new System.Windows.Forms.Label();
            this.btnCancelLesson = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuBack = new System.Windows.Forms.ToolStripMenuItem();
            this.lblMemberName = new System.Windows.Forms.Label();
            this.cbxMemberID = new System.Windows.Forms.ComboBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtForename = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.grpInfo = new System.Windows.Forms.GroupBox();
            this.cbxBooking = new System.Windows.Forms.ComboBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.grpInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(84, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(219, 31);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cancel A Lesson";
            // 
            // lblPickLesson
            // 
            this.lblPickLesson.AutoSize = true;
            this.lblPickLesson.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPickLesson.Location = new System.Drawing.Point(86, 216);
            this.lblPickLesson.Name = "lblPickLesson";
            this.lblPickLesson.Size = new System.Drawing.Size(192, 20);
            this.lblPickLesson.TabIndex = 22;
            this.lblPickLesson.Text = "Pick A Lesson To Cancel: ";
            // 
            // btnCancelLesson
            // 
            this.btnCancelLesson.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelLesson.Location = new System.Drawing.Point(578, 259);
            this.btnCancelLesson.Name = "btnCancelLesson";
            this.btnCancelLesson.Size = new System.Drawing.Size(172, 40);
            this.btnCancelLesson.TabIndex = 24;
            this.btnCancelLesson.Text = "Cancel Lesson";
            this.btnCancelLesson.UseVisualStyleBackColor = true;
            this.btnCancelLesson.Click += new System.EventHandler(this.btnCancelLesson_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuBack});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 25;
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
            // lblMemberName
            // 
            this.lblMemberName.AutoSize = true;
            this.lblMemberName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMemberName.Location = new System.Drawing.Point(96, 103);
            this.lblMemberName.Name = "lblMemberName";
            this.lblMemberName.Size = new System.Drawing.Size(113, 20);
            this.lblMemberName.TabIndex = 30;
            this.lblMemberName.Text = "Member Name";
            // 
            // cbxMemberID
            // 
            this.cbxMemberID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxMemberID.FormattingEnabled = true;
            this.cbxMemberID.Location = new System.Drawing.Point(215, 103);
            this.cbxMemberID.Name = "cbxMemberID";
            this.cbxMemberID.Size = new System.Drawing.Size(200, 21);
            this.cbxMemberID.TabIndex = 29;
            this.cbxMemberID.SelectedIndexChanged += new System.EventHandler(this.cbxMemberID_SelectedIndexChanged);
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
            // grpInfo
            // 
            this.grpInfo.Controls.Add(this.txtID);
            this.grpInfo.Controls.Add(this.label7);
            this.grpInfo.Controls.Add(this.txtForename);
            this.grpInfo.Controls.Add(this.txtSurname);
            this.grpInfo.Controls.Add(this.label6);
            this.grpInfo.Controls.Add(this.label5);
            this.grpInfo.Location = new System.Drawing.Point(90, 73);
            this.grpInfo.Name = "grpInfo";
            this.grpInfo.Size = new System.Drawing.Size(325, 122);
            this.grpInfo.TabIndex = 28;
            this.grpInfo.TabStop = false;
            this.grpInfo.Text = "Member Details";
            // 
            // cbxBooking
            // 
            this.cbxBooking.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxBooking.FormattingEnabled = true;
            this.cbxBooking.Location = new System.Drawing.Point(284, 215);
            this.cbxBooking.Name = "cbxBooking";
            this.cbxBooking.Size = new System.Drawing.Size(266, 21);
            this.cbxBooking.TabIndex = 31;
            this.cbxBooking.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(578, 36);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(172, 29);
            this.btnReset.TabIndex = 32;
            this.btnReset.Text = "Reset Cancelation";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // frmLessonCancel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.cbxBooking);
            this.Controls.Add(this.lblMemberName);
            this.Controls.Add(this.cbxMemberID);
            this.Controls.Add(this.grpInfo);
            this.Controls.Add(this.btnCancelLesson);
            this.Controls.Add(this.lblPickLesson);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmLessonCancel";
            this.Text = "Cancel Lesson";
            this.Load += new System.EventHandler(this.frmLessonCancel_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grpInfo.ResumeLayout(false);
            this.grpInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblPickLesson;
        private System.Windows.Forms.Button btnCancelLesson;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuBack;
        private System.Windows.Forms.Label lblMemberName;
        private System.Windows.Forms.ComboBox cbxMemberID;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtForename;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox grpInfo;
        private System.Windows.Forms.ComboBox cbxBooking;
        private System.Windows.Forms.Button btnReset;
    }
}