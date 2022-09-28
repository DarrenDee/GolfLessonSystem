
namespace GolfLessonSystem
{
    partial class frmLessonsAvailable
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLessonsAvailable));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpAvailableDate = new System.Windows.Forms.DateTimePicker();
            this.btnCheck = new System.Windows.Forms.Button();
            this.grpAvailableLessons = new System.Windows.Forms.GroupBox();
            this.lstTimes = new System.Windows.Forms.ListBox();
            this.mnuAvailableLessons = new System.Windows.Forms.MenuStrip();
            this.mnuBack = new System.Windows.Forms.ToolStripMenuItem();
            this.cboPickPro = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.grpAvailableLessons.SuspendLayout();
            this.mnuAvailableLessons.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(51, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Available Lessons";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(53, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Pick a Date:";
            // 
            // dtpAvailableDate
            // 
            this.dtpAvailableDate.Location = new System.Drawing.Point(192, 148);
            this.dtpAvailableDate.Name = "dtpAvailableDate";
            this.dtpAvailableDate.Size = new System.Drawing.Size(258, 20);
            this.dtpAvailableDate.TabIndex = 6;
            // 
            // btnCheck
            // 
            this.btnCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheck.Location = new System.Drawing.Point(302, 269);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(148, 35);
            this.btnCheck.TabIndex = 21;
            this.btnCheck.Text = "Check Availability";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // grpAvailableLessons
            // 
            this.grpAvailableLessons.Controls.Add(this.lstTimes);
            this.grpAvailableLessons.Location = new System.Drawing.Point(530, 49);
            this.grpAvailableLessons.Name = "grpAvailableLessons";
            this.grpAvailableLessons.Size = new System.Drawing.Size(192, 349);
            this.grpAvailableLessons.TabIndex = 22;
            this.grpAvailableLessons.TabStop = false;
            this.grpAvailableLessons.Text = "Available Lessons";
            // 
            // lstTimes
            // 
            this.lstTimes.FormattingEnabled = true;
            this.lstTimes.Location = new System.Drawing.Point(19, 19);
            this.lstTimes.Name = "lstTimes";
            this.lstTimes.Size = new System.Drawing.Size(145, 303);
            this.lstTimes.TabIndex = 0;
            // 
            // mnuAvailableLessons
            // 
            this.mnuAvailableLessons.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuBack});
            this.mnuAvailableLessons.Location = new System.Drawing.Point(0, 0);
            this.mnuAvailableLessons.Name = "mnuAvailableLessons";
            this.mnuAvailableLessons.Size = new System.Drawing.Size(800, 24);
            this.mnuAvailableLessons.TabIndex = 23;
            this.mnuAvailableLessons.Text = "menuStrip1";
            // 
            // mnuBack
            // 
            this.mnuBack.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.mnuBack.Name = "mnuBack";
            this.mnuBack.Size = new System.Drawing.Size(44, 20);
            this.mnuBack.Text = "Back";
            this.mnuBack.Click += new System.EventHandler(this.mnuBack_Click);
            // 
            // cboPickPro
            // 
            this.cboPickPro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPickPro.FormattingEnabled = true;
            this.cboPickPro.Location = new System.Drawing.Point(192, 190);
            this.cboPickPro.Name = "cboPickPro";
            this.cboPickPro.Size = new System.Drawing.Size(258, 21);
            this.cboPickPro.TabIndex = 26;
            this.cboPickPro.SelectedIndexChanged += new System.EventHandler(this.cboPickPro_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(53, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 20);
            this.label3.TabIndex = 27;
            this.label3.Text = "Pick a Pro:";
            // 
            // frmLessonsAvailable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cboPickPro);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.grpAvailableLessons);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.dtpAvailableDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mnuAvailableLessons);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mnuAvailableLessons;
            this.Name = "frmLessonsAvailable";
            this.Text = "Available Lessons";
            this.Load += new System.EventHandler(this.frmLessonsAvailable_Load);
            this.grpAvailableLessons.ResumeLayout(false);
            this.mnuAvailableLessons.ResumeLayout(false);
            this.mnuAvailableLessons.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpAvailableDate;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.GroupBox grpAvailableLessons;
        private System.Windows.Forms.ListBox lstTimes;
        private System.Windows.Forms.MenuStrip mnuAvailableLessons;
        private System.Windows.Forms.ToolStripMenuItem mnuBack;
        private System.Windows.Forms.ComboBox cboPickPro;
        private System.Windows.Forms.Label label3;
    }
}