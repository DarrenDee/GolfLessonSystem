
namespace GolfLessonSystem
{
    partial class frmProUpdate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProUpdate));
            this.label4 = new System.Windows.Forms.Label();
            this.grpUpdateInfo = new System.Windows.Forms.GroupBox();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFee = new System.Windows.Forms.TextBox();
            this.lblFee = new System.Windows.Forms.Label();
            this.txtSubmit = new System.Windows.Forms.Button();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.lblSurname = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblProId = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtForename = new System.Windows.Forms.TextBox();
            this.lblForename = new System.Windows.Forms.Label();
            this.lblSelectProId = new System.Windows.Forms.Label();
            this.cboProName = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuBack = new System.Windows.Forms.ToolStripMenuItem();
            this.grpUpdateInfo.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(53, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(349, 25);
            this.label4.TabIndex = 20;
            this.label4.Text = "Update A Professionals Information";
            // 
            // grpUpdateInfo
            // 
            this.grpUpdateInfo.BackColor = System.Drawing.SystemColors.Control;
            this.grpUpdateInfo.Controls.Add(this.txtStatus);
            this.grpUpdateInfo.Controls.Add(this.label1);
            this.grpUpdateInfo.Controls.Add(this.txtFee);
            this.grpUpdateInfo.Controls.Add(this.lblFee);
            this.grpUpdateInfo.Controls.Add(this.txtSubmit);
            this.grpUpdateInfo.Controls.Add(this.txtSurname);
            this.grpUpdateInfo.Controls.Add(this.lblSurname);
            this.grpUpdateInfo.Controls.Add(this.txtID);
            this.grpUpdateInfo.Controls.Add(this.lblProId);
            this.grpUpdateInfo.Controls.Add(this.txtPhone);
            this.grpUpdateInfo.Controls.Add(this.lblPhone);
            this.grpUpdateInfo.Controls.Add(this.txtEmail);
            this.grpUpdateInfo.Controls.Add(this.lblEmail);
            this.grpUpdateInfo.Controls.Add(this.txtForename);
            this.grpUpdateInfo.Controls.Add(this.lblForename);
            this.grpUpdateInfo.Location = new System.Drawing.Point(434, 70);
            this.grpUpdateInfo.Name = "grpUpdateInfo";
            this.grpUpdateInfo.Size = new System.Drawing.Size(302, 355);
            this.grpUpdateInfo.TabIndex = 24;
            this.grpUpdateInfo.TabStop = false;
            this.grpUpdateInfo.Text = "Update Information";
            this.grpUpdateInfo.Visible = false;
            // 
            // txtStatus
            // 
            this.txtStatus.Enabled = false;
            this.txtStatus.Location = new System.Drawing.Point(146, 289);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.ReadOnly = true;
            this.txtStatus.Size = new System.Drawing.Size(23, 20);
            this.txtStatus.TabIndex = 37;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 289);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 38;
            this.label1.Text = "Status:";
            // 
            // txtFee
            // 
            this.txtFee.Location = new System.Drawing.Point(148, 246);
            this.txtFee.Name = "txtFee";
            this.txtFee.Size = new System.Drawing.Size(148, 20);
            this.txtFee.TabIndex = 35;
            // 
            // lblFee
            // 
            this.lblFee.AutoSize = true;
            this.lblFee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFee.Location = new System.Drawing.Point(8, 246);
            this.lblFee.Name = "lblFee";
            this.lblFee.Size = new System.Drawing.Size(41, 20);
            this.lblFee.TabIndex = 36;
            this.lblFee.Text = "Fee:";
            // 
            // txtSubmit
            // 
            this.txtSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubmit.Location = new System.Drawing.Point(233, 315);
            this.txtSubmit.Name = "txtSubmit";
            this.txtSubmit.Size = new System.Drawing.Size(63, 25);
            this.txtSubmit.TabIndex = 34;
            this.txtSubmit.Text = "Submit";
            this.txtSubmit.UseVisualStyleBackColor = true;
            this.txtSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(148, 114);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(148, 20);
            this.txtSurname.TabIndex = 26;
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSurname.Location = new System.Drawing.Point(8, 114);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(78, 20);
            this.lblSurname.TabIndex = 33;
            this.lblSurname.Text = "Surname:";
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(146, 28);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(23, 20);
            this.txtID.TabIndex = 32;
            // 
            // lblProId
            // 
            this.lblProId.AutoSize = true;
            this.lblProId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProId.Location = new System.Drawing.Point(6, 28);
            this.lblProId.Name = "lblProId";
            this.lblProId.Size = new System.Drawing.Size(121, 20);
            this.lblProId.TabIndex = 31;
            this.lblProId.Text = "Professional ID:";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(148, 201);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(148, 20);
            this.txtPhone.TabIndex = 29;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.Location = new System.Drawing.Point(8, 201);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(119, 20);
            this.lblPhone.TabIndex = 30;
            this.lblPhone.Text = "Phone Number:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(148, 157);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(148, 20);
            this.txtEmail.TabIndex = 27;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(8, 157);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(52, 20);
            this.lblEmail.TabIndex = 28;
            this.lblEmail.Text = "Email:";
            // 
            // txtForename
            // 
            this.txtForename.Location = new System.Drawing.Point(146, 72);
            this.txtForename.Name = "txtForename";
            this.txtForename.Size = new System.Drawing.Size(148, 20);
            this.txtForename.TabIndex = 24;
            // 
            // lblForename
            // 
            this.lblForename.AutoSize = true;
            this.lblForename.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblForename.Location = new System.Drawing.Point(8, 70);
            this.lblForename.Name = "lblForename";
            this.lblForename.Size = new System.Drawing.Size(86, 20);
            this.lblForename.TabIndex = 25;
            this.lblForename.Text = "Forename:";
            // 
            // lblSelectProId
            // 
            this.lblSelectProId.AutoSize = true;
            this.lblSelectProId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectProId.Location = new System.Drawing.Point(54, 124);
            this.lblSelectProId.Name = "lblSelectProId";
            this.lblSelectProId.Size = new System.Drawing.Size(149, 20);
            this.lblSelectProId.TabIndex = 32;
            this.lblSelectProId.Text = "Select Professional:";
            // 
            // cboProName
            // 
            this.cboProName.FormattingEnabled = true;
            this.cboProName.Location = new System.Drawing.Point(226, 123);
            this.cboProName.Name = "cboProName";
            this.cboProName.Size = new System.Drawing.Size(121, 21);
            this.cboProName.TabIndex = 33;
            this.cboProName.SelectedIndexChanged += new System.EventHandler(this.cboSelectID_SelectedIndexChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuBack});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 34;
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
            // frmProUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cboProName);
            this.Controls.Add(this.lblSelectProId);
            this.Controls.Add(this.grpUpdateInfo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmProUpdate";
            this.Text = "Update Professional";
            this.Load += new System.EventHandler(this.frmProUpdate_Load);
            this.grpUpdateInfo.ResumeLayout(false);
            this.grpUpdateInfo.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox grpUpdateInfo;
        private System.Windows.Forms.Button txtSubmit;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblProId;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtForename;
        private System.Windows.Forms.Label lblForename;
        private System.Windows.Forms.Label lblSelectProId;
        private System.Windows.Forms.ComboBox cboProName;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuBack;
        private System.Windows.Forms.TextBox txtFee;
        private System.Windows.Forms.Label lblFee;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.Label label1;
    }
}