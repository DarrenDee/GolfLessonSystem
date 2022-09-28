
namespace GolfLessonSystem
{
    partial class frmMainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainMenu));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.golfProffesionalsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRegPro = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuUpdatePro = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRemovePro = new System.Windows.Forms.ToolStripMenuItem();
            this.golfToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBookLesson = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCancelLesson = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPrintLessonSchedule = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFindAvailableLessons = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAdmin = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuYearlyRevinue = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuYearlyPro = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBook = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.golfProffesionalsToolStripMenuItem,
            this.golfToolStripMenuItem,
            this.mnuAdmin,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "mnuMainMenu";
            // 
            // golfProffesionalsToolStripMenuItem
            // 
            this.golfProffesionalsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuRegPro,
            this.mnuUpdatePro,
            this.mnuRemovePro});
            this.golfProffesionalsToolStripMenuItem.Name = "golfProffesionalsToolStripMenuItem";
            this.golfProffesionalsToolStripMenuItem.Size = new System.Drawing.Size(116, 20);
            this.golfProffesionalsToolStripMenuItem.Text = "Golf Professional’s";
            // 
            // mnuRegPro
            // 
            this.mnuRegPro.Name = "mnuRegPro";
            this.mnuRegPro.Size = new System.Drawing.Size(156, 22);
            this.mnuRegPro.Text = "Register Pro";
            this.mnuRegPro.Click += new System.EventHandler(this.mnuRegPro_Click);
            // 
            // mnuUpdatePro
            // 
            this.mnuUpdatePro.Name = "mnuUpdatePro";
            this.mnuUpdatePro.Size = new System.Drawing.Size(156, 22);
            this.mnuUpdatePro.Text = "Update Pro";
            this.mnuUpdatePro.Click += new System.EventHandler(this.mnuUpdatePro_Click);
            // 
            // mnuRemovePro
            // 
            this.mnuRemovePro.Name = "mnuRemovePro";
            this.mnuRemovePro.Size = new System.Drawing.Size(156, 22);
            this.mnuRemovePro.Text = "De-Register Pro";
            this.mnuRemovePro.Click += new System.EventHandler(this.mnuRemovePro_Click);
            // 
            // golfToolStripMenuItem
            // 
            this.golfToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuBookLesson,
            this.mnuCancelLesson,
            this.mnuPrintLessonSchedule,
            this.mnuFindAvailableLessons});
            this.golfToolStripMenuItem.Name = "golfToolStripMenuItem";
            this.golfToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.golfToolStripMenuItem.Text = "Lessons";
            this.golfToolStripMenuItem.Click += new System.EventHandler(this.golfToolStripMenuItem_Click);
            // 
            // mnuBookLesson
            // 
            this.mnuBookLesson.Name = "mnuBookLesson";
            this.mnuBookLesson.Size = new System.Drawing.Size(192, 22);
            this.mnuBookLesson.Text = "Book Lesson";
            this.mnuBookLesson.Click += new System.EventHandler(this.mnuBookLesson_Click);
            // 
            // mnuCancelLesson
            // 
            this.mnuCancelLesson.Name = "mnuCancelLesson";
            this.mnuCancelLesson.Size = new System.Drawing.Size(192, 22);
            this.mnuCancelLesson.Text = "Cancel Lesson";
            this.mnuCancelLesson.Click += new System.EventHandler(this.mnuCancelLesson_Click);
            // 
            // mnuPrintLessonSchedule
            // 
            this.mnuPrintLessonSchedule.Name = "mnuPrintLessonSchedule";
            this.mnuPrintLessonSchedule.Size = new System.Drawing.Size(192, 22);
            this.mnuPrintLessonSchedule.Text = "Print Lesson Schedule";
            this.mnuPrintLessonSchedule.Click += new System.EventHandler(this.mnuPrintLessonSchedule_Click);
            // 
            // mnuFindAvailableLessons
            // 
            this.mnuFindAvailableLessons.Name = "mnuFindAvailableLessons";
            this.mnuFindAvailableLessons.Size = new System.Drawing.Size(192, 22);
            this.mnuFindAvailableLessons.Text = "Find Available Lessons";
            this.mnuFindAvailableLessons.Click += new System.EventHandler(this.mnuFindAvailableLessons_Click);
            // 
            // mnuAdmin
            // 
            this.mnuAdmin.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuYearlyRevinue,
            this.mnuYearlyPro});
            this.mnuAdmin.Name = "mnuAdmin";
            this.mnuAdmin.Size = new System.Drawing.Size(55, 20);
            this.mnuAdmin.Text = "Admin";
            // 
            // mnuYearlyRevinue
            // 
            this.mnuYearlyRevinue.Name = "mnuYearlyRevinue";
            this.mnuYearlyRevinue.Size = new System.Drawing.Size(196, 22);
            this.mnuYearlyRevinue.Text = "Yearly Revinue Analysis";
            this.mnuYearlyRevinue.Click += new System.EventHandler(this.mnuYearlyRevinue_Click);
            // 
            // mnuYearlyPro
            // 
            this.mnuYearlyPro.Name = "mnuYearlyPro";
            this.mnuYearlyPro.Size = new System.Drawing.Size(196, 22);
            this.mnuYearlyPro.Text = "Yearly Pro Analysis";
            this.mnuYearlyPro.Click += new System.EventHandler(this.mnuYearlyPro_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Niagara Engraved", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(233, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(320, 103);
            this.label1.TabIndex = 1;
            this.label1.Text = "Golf Lessons";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnBook
            // 
            this.btnBook.BackColor = System.Drawing.Color.SeaShell;
            this.btnBook.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.btnBook.Font = new System.Drawing.Font("Yu Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBook.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnBook.Location = new System.Drawing.Point(136, 263);
            this.btnBook.Name = "btnBook";
            this.btnBook.Size = new System.Drawing.Size(180, 47);
            this.btnBook.TabIndex = 2;
            this.btnBook.Text = "Book A Lesson";
            this.btnBook.UseVisualStyleBackColor = false;
            this.btnBook.Click += new System.EventHandler(this.btnBook_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.SeaShell;
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.btnCancel.Font = new System.Drawing.Font("Yu Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCancel.Location = new System.Drawing.Point(446, 263);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(180, 47);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel A Lesson";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GolfLessonSystem.Properties.Resources._4;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnBook);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMainMenu";
            this.Text = "Golf Lessons";
            this.Load += new System.EventHandler(this.frmMainMenu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem golfToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem golfProffesionalsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuAdmin;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuRegPro;
        private System.Windows.Forms.ToolStripMenuItem mnuUpdatePro;
        private System.Windows.Forms.ToolStripMenuItem mnuRemovePro;
        private System.Windows.Forms.ToolStripMenuItem mnuBookLesson;
        private System.Windows.Forms.ToolStripMenuItem mnuCancelLesson;
        private System.Windows.Forms.ToolStripMenuItem mnuPrintLessonSchedule;
        private System.Windows.Forms.ToolStripMenuItem mnuFindAvailableLessons;
        private System.Windows.Forms.ToolStripMenuItem mnuYearlyRevinue;
        private System.Windows.Forms.ToolStripMenuItem mnuYearlyPro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBook;
        private System.Windows.Forms.Button btnCancel;
    }
}

