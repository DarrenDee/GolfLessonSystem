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
    public partial class frmAdminProAnalysis : Form
    {
        frmMainMenu parent;
        string year = "";
        public frmAdminProAnalysis()
        {
            InitializeComponent();
        }
        public frmAdminProAnalysis(frmMainMenu Parent)
        {
            InitializeComponent();

            parent = Parent;
        }

        public void loadPro()
        {
 
        }



        private void frmAdminProAnalysis_Load(object sender, EventArgs e)
        {
         
            cboSelectYear.Items.Add(DateTime.Today.Year - 3);
            cboSelectYear.Items.Add(DateTime.Today.Year - 2);
            cboSelectYear.Items.Add(DateTime.Today.Year - 1);
            cboSelectYear.Items.Add(DateTime.Today.Year);
        }

        private void mnuBack_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }

        private void cboSelectID_SelectedIndexChanged(object sender, EventArgs e)
        {
            year = cboSelectYear.SelectedItem.ToString();
            chtData.Titles.Clear();
            chtData.Titles.Add("Yearly Revenue " + cboSelectYear.Text.ToString());
            chtData.Visible = true;

            DataSet dt = Admin.getYearlyProAnalysis(year);
            DataSet dp = Professional.getAllPros();
            //Array size 12 since there are 12 months in a year
            int[] Pros = new int[dp.Tables[0].Rows.Count];
            decimal[] Amounts = new decimal[dp.Tables[0].Rows.Count];

            for (int i = 0; i < dp.Tables[0].Rows.Count; i++)
            {
               if (dt.Tables[0].Rows.Count < 1)
               {
                    //Pros[i] = i + 1;
                    //Amounts[i] = 0;
               }
               else
                {
                    Pros[i] = Convert.ToInt32(dt.Tables[0].Rows[i][1]);
                    Amounts[i] = Convert.ToDecimal(dt.Tables[0].Rows[i][0]);
                }
            }


            //for (int i = 0; i < dt.Tables[0].Rows.Count; i++)
           // {
          //      Amounts[Convert.ToInt32(dt.Tables[0].Rows[i][1]) - 1] = Convert.ToDecimal(dt.Tables[0].Rows[i][0]);
          //  }
            chtData.ChartAreas[0].AxisX.MajorGrid.LineWidth = 0;
            chtData.ChartAreas[0].AxisY.MajorGrid.LineWidth = 0;
            chtData.Series[0].LegendText = "Income in €";
            chtData.Series[0].Points.DataBindXY(Pros, Amounts);
            chtData.ChartAreas["ChartArea1"].AxisX.LabelStyle.Format = "";
            //chtSales.Series[0].Points[0] = "XXX";
            chtData.Series[0].Label = "#VALY";
            //chtData.Titles.Add("Yearly Revenue ");
            chtData.Visible = true;



        }
    }
}
