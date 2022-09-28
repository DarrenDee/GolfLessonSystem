
namespace GolfLessonSystem
{
    partial class frmLessonSchedule
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLessonSchedule));
            this.label1 = new System.Windows.Forms.Label();
            this.mnuLessonSchedule = new System.Windows.Forms.MenuStrip();
            this.mnuBack = new System.Windows.Forms.ToolStripMenuItem();
            this.dtpScheduleDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.btnView = new System.Windows.Forms.Button();
            this.lsTimes = new System.Windows.Forms.ListBox();
            this.grpLessonSchedule = new System.Windows.Forms.GroupBox();
            this.mnuLessonSchedule.SuspendLayout();
            this.grpLessonSchedule.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(48, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lesson Schedule";
            // 
            // mnuLessonSchedule
            // 
            this.mnuLessonSchedule.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuBack});
            this.mnuLessonSchedule.Location = new System.Drawing.Point(0, 0);
            this.mnuLessonSchedule.Name = "mnuLessonSchedule";
            this.mnuLessonSchedule.Size = new System.Drawing.Size(800, 24);
            this.mnuLessonSchedule.TabIndex = 1;
            this.mnuLessonSchedule.Text = "menuStrip1";
            // 
            // mnuBack
            // 
            this.mnuBack.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.mnuBack.Name = "mnuBack";
            this.mnuBack.Size = new System.Drawing.Size(44, 20);
            this.mnuBack.Text = "Back";
            this.mnuBack.Click += new System.EventHandler(this.mnuBack_Click);
            // 
            // dtpScheduleDate
            // 
            this.dtpScheduleDate.Location = new System.Drawing.Point(176, 147);
            this.dtpScheduleDate.Name = "dtpScheduleDate";
            this.dtpScheduleDate.Size = new System.Drawing.Size(258, 20);
            this.dtpScheduleDate.TabIndex = 3;
            this.dtpScheduleDate.ValueChanged += new System.EventHandler(this.dtpScheduleDate_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(50, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Pick a Date:";
            // 
            // btnView
            // 
            this.btnView.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnView.Location = new System.Drawing.Point(286, 217);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(148, 35);
            this.btnView.TabIndex = 20;
            this.btnView.Text = "View Schedule";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // lsTimes
            // 
            this.lsTimes.FormattingEnabled = true;
            this.lsTimes.Location = new System.Drawing.Point(15, 29);
            this.lsTimes.Name = "lsTimes";
            this.lsTimes.Size = new System.Drawing.Size(260, 303);
            this.lsTimes.TabIndex = 0;
            // 
            // grpLessonSchedule
            // 
            this.grpLessonSchedule.Controls.Add(this.lsTimes);
            this.grpLessonSchedule.Location = new System.Drawing.Point(477, 46);
            this.grpLessonSchedule.Name = "grpLessonSchedule";
            this.grpLessonSchedule.Size = new System.Drawing.Size(287, 349);
            this.grpLessonSchedule.TabIndex = 21;
            this.grpLessonSchedule.TabStop = false;
            this.grpLessonSchedule.Text = "Schedule";
            // 
            // frmLessonSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grpLessonSchedule);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpScheduleDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mnuLessonSchedule);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mnuLessonSchedule;
            this.Name = "frmLessonSchedule";
            this.Text = "Lesson Schedule";
            this.Load += new System.EventHandler(this.frmLessonSchedule_Load);
            this.mnuLessonSchedule.ResumeLayout(false);
            this.mnuLessonSchedule.PerformLayout();
            this.grpLessonSchedule.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip mnuLessonSchedule;
        private System.Windows.Forms.ToolStripMenuItem mnuBack;
        private System.Windows.Forms.DateTimePicker dtpScheduleDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.ListBox lsTimes;
        private System.Windows.Forms.GroupBox grpLessonSchedule;
    }
}