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
    public partial class frmLessonsAvailable : Form
    {

        frmMainMenu parent;

        public frmLessonsAvailable()
        {
            InitializeComponent();
        }

        public frmLessonsAvailable(frmMainMenu Parent)
        {
            InitializeComponent();
            parent = Parent;

            grpAvailableLessons.Visible = false;
        }

        private void frmLessonsAvailable_Load(object sender, EventArgs e)
        {
            DataSet ds1 = Professional.getAllPros();


            for (int i = 0; i < ds1.Tables["Pros"].Rows.Count; i++)
            {
                cboPickPro.Items.Add(ds1.Tables[0].Rows[i][1].ToString() + " " + ds1.Tables[0].Rows[i][2].ToString() + " " + ds1.Tables[0].Rows[i][0].ToString().PadLeft(2, '0'));
            }


        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            
            lstTimes.Items.Clear();
       
            String name = cboPickPro.SelectedItem.ToString();
            var names = name.Split(' ');
            String proIdString = names[2];
            int proId = Int32.Parse(proIdString);
            String forename = names[0];
            String surname = names[1];
            DataSet ds = Professional.loadPro(proId);


            String proID = (ds.Tables[0].Rows[0][0].ToString());

   
            //Load Pro times into dataset
            DataSet dstime = Lessons.loadTimesPro(proID);

            //Load All times into dataset
            DataSet dsAppTime = AppTime.getAllTimes();

            //Load all lessons into dataset
            DataSet dsAllLessons = Lessons.getAllLessons();



            ArrayList allTimes = new ArrayList();
            ArrayList bookedTimes = new ArrayList();
            ArrayList bookedDates = new ArrayList();


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




            //Display available times
            for (int i = 0; i < allTimes.Count; i++)
            {

                if (bookedTimes.Contains(allTimes[i]))
                {

                    String pickedDate = dtpAvailableDate.Value.ToString();
                    var pd = pickedDate.Split(' ');
                    String relPickedDate = pd[0];
                    //https://stackoverflow.com/questions/37049935/how-to-convert-dd-mm-yyyy-to-dd-mm-yyyy-in-asp-net  This was used to convert the date to the correct format
                    string convertedPickedDate = DateTime.ParseExact(relPickedDate, "dd/MM/yyyy", CultureInfo.InvariantCulture).ToString("dd-MMM-yy");

                    DataSet dsdate = Lessons.checkproDate(convertedPickedDate, proId );

                    for (int j = 0; j < dsdate.Tables[0].Rows.Count; j++)
                    {
                        bookedDates.Add(dsdate.Tables["Date"].Rows[j][2].ToString());
              

                    }


                    if (bookedDates.Contains(allTimes[i]))
                    {
                        timeBooked = true;
                    }

                }

                if (timeBooked == false)
                {
                  lstTimes.Items.Add(allTimes[i]);
                }
                else
                {
                    timeBooked = false;
                }
            }





            grpAvailableLessons.Visible = true;
        }

        private void mnuBack_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }

        private void cboPickPro_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
