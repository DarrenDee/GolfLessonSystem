using ImTools;
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
    public partial class frmLessonSchedule : Form
    {
        frmMainMenu parent;

        public frmLessonSchedule()
        {
            InitializeComponent();
        }

        public frmLessonSchedule(frmMainMenu Parent)
        {
            InitializeComponent();
            parent = Parent;
           
            grpLessonSchedule.Visible = false;
        }

        private void frmLessonSchedule_Load(object sender, EventArgs e)
        {
            grpLessonSchedule.Visible = false;
            dtpScheduleDate.MinDate = dtpScheduleDate.Value.AddDays(0);

        }

        private void btnView_Click(object sender, EventArgs e)
        {
            lsTimes.Items.Clear();
            String pickedDate = dtpScheduleDate.Value.ToString("dd-MMM-yyyy");
            DataSet dsSchedule = Lessons.getLessonSchedule(pickedDate);


            lsTimes.Items.Add(pickedDate + "\n");
            for (int i = 0; i < dsSchedule.Tables["SD"].Rows.Count; i++) { 

                
                lsTimes.Items.Add("Booking Number: " + dsSchedule.Tables[0].Rows[i][0].ToString());
                lsTimes.Items.Add("\nTime: " + dsSchedule.Tables[0].Rows[i][2].ToString());
                lsTimes.Items.Add("\nCost: " + dsSchedule.Tables[0].Rows[i][1].ToString());
                lsTimes.Items.Add("\nPro ID: " + dsSchedule.Tables[0].Rows[i][4].ToString());
                lsTimes.Items.Add("\nMember ID: " + dsSchedule.Tables[0].Rows[i][5].ToString());
                lsTimes.Items.Add(" ");
                lsTimes.Items.Add(" ");


            }


            grpLessonSchedule.Visible = true;
        }

        private void mnuBack_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }

        private void dtpScheduleDate_ValueChanged(object sender, EventArgs e)
        {

            lsTimes.Items.Clear();

        }
    }
}


