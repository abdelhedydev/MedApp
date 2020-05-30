using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.OleDb;
using System.Data.SqlClient;

namespace MedProject
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=localhost;Initial Catalog=medical;Integrated Security=True";
            con.Open();
            SqlCommand cmd = new SqlCommand("Select count(*) from patient", con);
            Int32 countPatient = (Int32)cmd.ExecuteScalar();
            InitializeComponent();
            patientNumber.Text = this.FormatResult(countPatient);
            /* Meeting */
            SqlCommand cmdMeeting = new SqlCommand("Select count(*) from Meeting", con);
            Int32 countMeeting = (Int32)cmdMeeting.ExecuteScalar();
            rdvNumber.Text = this.FormatResult(countMeeting);
            /* Intervention */
            SqlCommand cmdMeetingDetail = new SqlCommand("Select count(*) from MeetingDetail", con);
            Int32 countMeetingDetail = (Int32)cmdMeetingDetail.ExecuteScalar();
            intervNumber.Text = this.FormatResult(countMeetingDetail);
            /* Monnaie */
            SqlCommand cmdMoney = new SqlCommand("Select sum(cout) as total from MeetingDetail", con);
            monnaieNumber.Text = cmdMoney.ExecuteScalar().ToString()+ ' '+"dt";
        }

        public string FormatResult(Int32 val)
        {
            if (val < 100)
                return '0' + val.ToString();
            return val.ToString();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void monnaieNumber_Click(object sender, EventArgs e)
        {

        }
    }
}
