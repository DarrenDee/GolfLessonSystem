using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace GolfLessonSystem
{
    public partial class frmLessonBook : Form
    {
        
        frmMainMenu parent;
        public frmLessonBook()
        {
            InitializeComponent();
            grpInfo.Visible = false;
            cbxMemberID.Visible = true;
        }

        public frmLessonBook(frmMainMenu Parent)
        {
            InitializeComponent();
            parent = Parent;
            grpInfo.Visible = false;
            cbxMemberID.Visible = true;
            grpAppointments.Visible = false;
        }

        private void frmBookLesson_Load(object sender, EventArgs e)
        {

            btmTimes.Visible = false;
            

            DataSet ds = Members.getAllMem();


            for (int i = 0; i < ds.Tables["Mem"].Rows.Count; i++)
            {
                cbxMemberID.Items.Add(ds.Tables[0].Rows[i][1].ToString() + " " + ds.Tables[0].Rows[i][2].ToString());
            }


            DataSet ds1 = Professional.getAllPros();

            
            for (int i = 0; i < ds1.Tables["Pros"].Rows.Count; i++)
            {

                if (ds1.Tables[0].Rows[i][6].Equals("R"))
                {
                    cboPickPro.Items.Add(ds1.Tables[0].Rows[i][1].ToString() + " " + ds1.Tables[0].Rows[i][2].ToString() + " " + ds1.Tables[0].Rows[i][0].ToString().PadLeft(2, '0'));
                }
                }


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) //Wont leave me use cboMemberID
        {
            String name = cbxMemberID.SelectedItem.ToString();
            var names = name.Split(' ');
            String surname = names[0];
            String forename = names[1];
            DataSet ds = Members.loadMem(forename, surname);


            grpInfo.Visible = true;

            txtID.Text = (ds.Tables[0].Rows[0][0].ToString());
            txtForename.Text = (ds.Tables[0].Rows[0][1].ToString());
            txtSurname.Text = (ds.Tables[0].Rows[0][2].ToString());

            cbxMemberID.Visible = false;
            lblMemberName.Visible = false;

            grpDatePro.Visible = true;
    
        }


        private void label1_Click(object sender, EventArgs e)
        {
            
        }

 

        private void cboPickPro_SelectedIndexChanged(object sender, EventArgs e)
        {
            btmTimes.Visible = true;
            grpAppointments.Visible = false;

        }

        private void mnuBack_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }




        private void txtCost_TextChanged(object sender, EventArgs e)
        {
            txtCost.Visible = true;
        }


        private void txtMakeApp_Click(object sender, EventArgs e)
        {
            String pickedDate = dtpPickDate.Value.ToString();
            var pd = pickedDate.Split(' ');
            String relPickedDate = pd[0];
            //https://stackoverflow.com/questions/37049935/how-to-convert-dd-mm-yyyy-to-dd-mm-yyyy-in-asp-net  This was used to convert the date to the correct format
            string convertedPickedDate = DateTime.ParseExact(relPickedDate, "dd/MM/yyyy", CultureInfo.InvariantCulture).ToString("dd-MMM-yy");
            String memberId = txtID.Text;
            int bookingNumber = Lessons.getNextBookingID();
            String name = cboPickPro.SelectedItem.ToString();
            var names = name.Split(' ');
            String proIdString = names[2];


            Lessons lesson = new Lessons(bookingNumber, Convert.ToInt32(txtCost.Text), cboAvailableTimes.SelectedItem.ToString() , convertedPickedDate, Convert.ToInt32(proIdString), Convert.ToInt32(memberId));


            //invoke method to add data

            lesson.addLesson();

            //Display confirmation message
            MessageBox.Show("Booking Confirmed, Your Booking Number is " + bookingNumber + "\n Thank you! ", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

            grpAppointments.Visible = false;
            grpDatePro.Visible = false;
            grpInfo.Visible = false;
            lblMemberName.Visible = true;
            cbxMemberID.Items.Clear();


            DataSet ds = Members.getAllMem();


            for (int i = 0; i < ds.Tables["Mem"].Rows.Count; i++)
            {
                cbxMemberID.Items.Add(ds.Tables[0].Rows[i][1].ToString().PadLeft(3, '0') + " " + ds.Tables[0].Rows[i][2].ToString());
            }
            cbxMemberID.Visible = true;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            grpAppointments.Visible = false;
            grpDatePro.Visible = false;
            grpInfo.Visible = false;
            btmTimes.Visible = false;
            lblMemberName.Visible = true;
            cbxMemberID.Items.Clear();


            DataSet ds = Members.getAllMem();


            for (int i = 0; i < ds.Tables["Mem"].Rows.Count; i++)
            {
                cbxMemberID.Items.Add(ds.Tables[0].Rows[i][1].ToString().PadLeft(3, '0') + " " + ds.Tables[0].Rows[i][2].ToString());
            }
            cbxMemberID.Visible = true;
        }

        private void btmTimes_Click(object sender, EventArgs e)
        {
            cboAvailableTimes.Items.Clear();
  
            if (cboPickPro.Text != "")
            {

                String memberId = txtID.Text;
                String name = cboPickPro.SelectedItem.ToString();
                var names = name.Split(' ');
                String proIdString = names[2];
                int proId = Int32.Parse(proIdString);
                String forename = names[0];
                String surname = names[1];
                DataSet ds = Professional.loadPro(proId);

                txtCost.Text = (ds.Tables[0].Rows[0][5].ToString().PadLeft(3));

                grpAppointments.Visible = true;

                String proID = (ds.Tables[0].Rows[0][0].ToString());

                //Load Pro times into dataset
                DataSet dstime = Lessons.loadTimesPro(proID);

                //Load Member times into dataset
                DataSet dsMemTime = Lessons.loadTimesMem(memberId);

                //Load All times into dataset
                DataSet dsAppTime = AppTime.getAllTimes();

                //Load all lessons into dataset
                DataSet dsAllLessons = Lessons.getAllLessons();



                ArrayList allTimes = new ArrayList();
                ArrayList bookedTimes = new ArrayList();
                ArrayList membersBookedTimes = new ArrayList();
                ArrayList bookedDates = new ArrayList();
                ArrayList membookedDates = new ArrayList();


                //Add dataset times to All times Array
                for (int i = 0; i < dsAppTime.Tables[0].Rows.Count; i++)
                {
                    allTimes.Add(dsAppTime.Tables[0].Rows[i][0]);
                }

                Boolean timeBooked = false;

                //Add dataset times to booked times Array
                for (int i = 0; i < dstime.Tables["Time"].Rows.Count; i++)
                {

                    bookedTimes.Add(dstime.Tables[0].Rows[i][2].ToString());
                }

                //Add dataset times to members booked times Array
                for (int i = 0; i < dsMemTime.Tables["MemTime"].Rows.Count; i++)
                {

                    membersBookedTimes.Add(dsMemTime.Tables[0].Rows[i][2].ToString());
                }



                //Display available times
                for (int i = 0; i < allTimes.Count; i++)
                {

                    if (bookedTimes.Contains(allTimes[i]) || (membersBookedTimes.Contains(allTimes[i])))
                    {

                        String pickedDate = dtpPickDate.Value.ToString();
                        var pd = pickedDate.Split(' ');
                        String relPickedDate = pd[0];
                        //https://stackoverflow.com/questions/37049935/how-to-convert-dd-mm-yyyy-to-dd-mm-yyyy-in-asp-net  This was used to convert the date to the correct format
                        string convertedPickedDate = DateTime.ParseExact(relPickedDate, "dd/MM/yyyy", CultureInfo.InvariantCulture).ToString("dd-MMM-yy");

                        DataSet dsdate = Lessons.checkproDate(convertedPickedDate, proId);

                        DataSet dsmemdate = Lessons.checkmemDate(convertedPickedDate, memberId);


                        for (int j = 0; j < dsdate.Tables[0].Rows.Count; j++)
                        {

                            bookedDates.Add(dsdate.Tables["Date"].Rows[j][2].ToString());

                        }

                        for (int j = 0; j < dsmemdate.Tables[0].Rows.Count; j++)
                        {

                            membookedDates.Add(dsmemdate.Tables["Date"].Rows[j][2].ToString());

                        }


                        if (bookedDates.Contains(allTimes[i]) || membookedDates.Contains(allTimes[i]))
                        {
                            timeBooked = true;
                        }

                    }

                    if (timeBooked == false)
                    {
                        DateTime today = DateTime.Today.Date;
                        int time = DateTime.Now.Hour;
                        var allTimeHour = allTimes[i].ToString().Split(':');
                        String hourString = allTimeHour[0];
                        int hour = Int32.Parse(hourString);



                        //     DateTime all = (DateTime)allTimes[i];
                        if (dtpPickDate.Value.Date == today)
                        {
                           if(hour > time)
                            {
                                cboAvailableTimes.Items.Add(allTimes[i]);
                            }
                        }
                        else
                        {

                            cboAvailableTimes.Items.Add(allTimes[i]);
                        }
                    }
                    else
                    {
                        timeBooked = false;
                    }
                }

                btmTimes.Visible = false;
            }
            else
            {
                MessageBox.Show("Member or Pro Fields Have Not Been Filled Correctly");
            }
        }
        private void dtpPickDate_ValueChanged(object sender, EventArgs e)
        {
            btmTimes.Visible = true;
            grpAppointments.Visible = false;
  
                DateTime today = DateTime.Today.Date;
                if (dtpPickDate.Value < today)
                {
                   
                    dtpPickDate.Value = DateTime.Today.Date;
                MessageBox.Show("A Lesson Can only be Booked for a future date");
            }
     
        }
        
    }
    }

