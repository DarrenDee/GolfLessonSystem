using System;
using System.Collections;
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
    public partial class frmLessonCancel : Form
    {

        frmMainMenu parent;

        public frmLessonCancel()
        {
            InitializeComponent();
            grpInfo.Visible = false;
            cbxMemberID.Visible = true;
            cbxBooking.Visible = false;
            lblPickLesson.Visible = false;
        }

        public frmLessonCancel(frmMainMenu Parent)
        {
            InitializeComponent();
            parent = Parent;
            grpInfo.Visible = false;
            cbxMemberID.Visible = true;
            cbxBooking.Visible = false;
            lblPickLesson.Visible = false;
        }


        private void btnCancelLesson_Click(object sender, EventArgs e)
        {
            String name = cbxBooking.SelectedItem.ToString();
            var names = name.Split(' ');
            String bookingString = names[2];
            int booking = Int32.Parse(bookingString);

            Lessons.cancelLesson(booking);
            MessageBox.Show(" Lesson Number " + booking + " Was Successfully Cancelled", "Lesson Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information);
            lblPickLesson.Visible = false;
            cbxBooking.Visible = false;
            cbxBooking.Items.Clear();
            grpInfo.Visible = false;
            lblMemberName.Visible = true;
            cbxMemberID.Visible = true;

        }

        private void mnuBack_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;

        }

        private void cbxMemberID_SelectedIndexChanged(object sender, EventArgs e)
        {
            String name = cbxMemberID.SelectedItem.ToString();
            var names = name.Split(' ');
            String surname = names[0];
            String forename = names[1];
            DataSet ds = Members.loadMem(forename, surname);



            grpInfo.Visible = true;

            txtID.Text = (ds.Tables[0].Rows[0][0].ToString());
            txtSurname.Text = (ds.Tables[0].Rows[0][1].ToString());
            txtForename.Text = (ds.Tables[0].Rows[0][2].ToString());

            cbxMemberID.Visible = false;
            lblMemberName.Visible = false;



            int memberId = Int32.Parse(txtID.Text);
            DataSet dsLes = Lessons.getMemberLessons(memberId);

            // ValidationConstraints to show only upcoming lessons and not old lessons
            DateTime currentDate = DateTime.Today;
            DateTime dateCurrentTime = DateTime.Now;
            String currentTime = dateCurrentTime.ToString("HH:mm");


            if (dsLes.Tables[0].Rows.Count == 0)
            {
                MessageBox.Show(" Error \n This Member Currently has no bookings ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cbxMemberID.Visible = true;
                lblMemberName.Visible = true;
                grpInfo.Visible = false;

            }
            else
            {
                for (int i = 0; i < dsLes.Tables[0].Rows.Count; i++)
                {
                    DateTime lessonDate = (DateTime)dsLes.Tables[0].Rows[i][3];
                    int isInDate = DateTime.Compare(currentDate, lessonDate);
                    String lessonTime = dsLes.Tables[0].Rows[i][2].ToString();

                    if (isInDate == 0 && DateTime.Parse(currentTime) < DateTime.Parse(lessonTime) || isInDate < 0)
                    {
                        cbxBooking.Items.Add("Booking Number: " + dsLes.Tables[0].Rows[i][0].ToString() + "     Time & Date: " + dsLes.Tables[0].Rows[i][2].ToString() + " " + dsLes.Tables[0].Rows[i][3].ToString());
                    }
                    else if (isInDate > 0)
                    {


                    }

                }
                if (cbxBooking.Items.Count != 0)
                {
                    cbxBooking.Visible = true;
                    lblPickLesson.Visible = true;
                }
                if (cbxBooking.Items.Count == 0)
                {
                    MessageBox.Show(" Error \n This Member has no upcoming lessons ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cbxMemberID.Visible = true;
                    lblMemberName.Visible = true;
                    grpInfo.Visible = false;
                    lblPickLesson.Visible = false;
                    cbxBooking.Visible = false;
                }


            }

        }

        private void frmLessonCancel_Load(object sender, EventArgs e)
        {

            DataSet ds = Members.getAllMem();


            for (int i = 0; i < ds.Tables["Mem"].Rows.Count; i++)
            {
                cbxMemberID.Items.Add(ds.Tables[0].Rows[i][1].ToString() + " " + ds.Tables[0].Rows[i][2].ToString());
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            lblPickLesson.Visible = false;
            cbxBooking.Visible = false;
            cbxBooking.Items.Clear();
            grpInfo.Visible = false;
            lblMemberName.Visible = true;
            cbxMemberID.Visible = true;
        }
    }
}
