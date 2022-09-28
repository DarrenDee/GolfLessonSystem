using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GolfLessonSystem
{
    public partial class frmMainMenu : Form
    {

        
        public frmMainMenu()
        {
            InitializeComponent();
        }

        private void golfToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
         
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to exit", "Confirm Please", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }

        }

        private void frmMainMenu_Load(object sender, EventArgs e)
        {

        }

        private void mnuRegPro_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmProAdd pro = new frmProAdd(this);
            pro.Show();
        }

        private void mnuUpdatePro_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmProUpdate proUp = new frmProUpdate(this);
            proUp.Show();
        }

        private void mnuRemovePro_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmProDereg proDer = new frmProDereg(this);
            proDer.Show();
        }

        private void mnuBookLesson_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLessonBook book = new frmLessonBook(this);
            book.Show();
        }

        private void mnuCancelLesson_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLessonCancel book = new frmLessonCancel(this);
            book.Show();
        }

        private void mnuPrintLessonSchedule_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLessonSchedule schedule = new frmLessonSchedule(this);
            schedule.Show();
        }

        private void mnuFindAvailableLessons_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLessonsAvailable available = new frmLessonsAvailable(this);
            available.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void mnuYearlyRevinue_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmAdminYearlyAnalysis available = new FrmAdminYearlyAnalysis(this);
            available.Show();
        }

        private void mnuYearlyPro_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAdminProAnalysis proAnalysis = new frmAdminProAnalysis(this);
            proAnalysis.Show();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLessonCancel book = new frmLessonCancel(this);
            book.Show();
        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLessonBook book = new frmLessonBook(this);
            book.Show();
        }
    }
}
