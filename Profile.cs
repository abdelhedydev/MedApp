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
using System.IO;
using System.Drawing;
using System.Drawing.Printing;

namespace MedProject
{
    public partial class Profile : Form
    {
        Int32 id;
        String path;
        private PrintDocument printDocument1 = new PrintDocument();

        public Profile()
        {
            InitializeComponent();
        }
        public Profile(Int32 id,String path)
        {
            InitializeComponent();
            this.id = id;
            this.path = path;
            this.BinInfo();
            printDocument1.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);
        }

        public void BinInfo()
        {
            string connection = "Data Source=localhost;Initial Catalog=medical;Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(connection);
            string query = "SELECT name ,cin ,telephone ,adresse,sexe,date,antecedants,assurance_id FROM patient where id = @id";
            SqlCommand cmd = new SqlCommand(query, sqlConnection);
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
            sqlConnection.Open();
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    nameTxt.Text = reader["name"].ToString();
                    cintxt.Text = reader["cin"].ToString();
                    adrTxt.Text = reader["adresse"].ToString();
                    birthDateTxt.Text = DateTime.Parse(reader["date"].ToString()).ToLocalTime().ToString("dd-MM-yyyy");
                    phoneTxt.Text = reader["telephone"].ToString();
                }
            }
            sqlConnection.Close();
            this.BindMeerting();
        }

        public void BindDetail(String id)
        {
            string connection = "Data Source=localhost;Initial Catalog=medical;Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(connection);
            string query = "SELECT inter.name as'interv' ,partie ,dents,cout FROM meetingDetail meet,intervention inter " +
                "where meet.intervention = inter.id and meet.id = @id";
            SqlCommand cmd = new SqlCommand(query, sqlConnection);
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
            sqlConnection.Open();
            int i = 0;
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    string intervention = reader["interv"].ToString().Trim();
                    string partie = reader["partie"].ToString().Trim();
                    string dents = reader["dents"].ToString().Trim();
                    string couts = reader["cout"].ToString().Trim();
                    string result = intervention + " : " + partie + " N°" + dents + "  " + couts + "dt .";
                    Label label = this.getLabel(result, i, 350, 300);
                    this.Controls.Add(label);
                    label.BringToFront();
                    i++;
                }
            }
            sqlConnection.Close();

        }


        public Label getLabel(String txt,Int32 i,Int32 y,Int32 x)
        {
            Label label = new Label();
            label.Text = txt;
            label.BackColor = Color.White;
            label.Font = new Font("Microsoft Tai Le", 12);
            label.Left = 141;
            label.AutoSize = true;
            label.Location = new Point(y, x + (30 * i));
            label.ForeColor = Color.Black;
            return label;
        }

        private void BindMeerting()
        {
            string connection = "Data Source=localhost;Initial Catalog=medical;Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(connection);
            string query = "SELECT M.id as 'Id',M.date as'Date' ,M.hours as 'Hours',M.minutes as 'Minutes' from Meeting M inner join Patient p on M.patient_id = p.id  "+ 
                "WHERE M.patient_id = '" +this.id + "'";
            SqlCommand cmd = new SqlCommand(query, sqlConnection);
            sqlConnection.Open();
            Int32 i = 0;
            var dataSource = new List<PatientMeeting>();
            using (SqlDataReader reader = cmd.ExecuteReader())
            
            {
                while (reader.Read())
                {
                    string dateInput = reader["Date"].ToString();
                    DateTime parsedDate = DateTime.Parse(dateInput);
                    string dateformatted = parsedDate.ToLocalTime().ToString("dd-MM-yyyy").Trim();
                    string time = reader["Hours"].ToString().Trim() +":"+ reader["Minutes"].ToString().Trim();
                    string result = "Le "+ dateformatted+ " à "+time+ " .";
                    Label label = this.getLabel(result, i,40,300);
                    this.Controls.Add(label);
                    label.BringToFront();
                    i++;
                    string id = reader["Id"].ToString();
                    this.BindDetail(id);


                }
            }
            sqlConnection.Close();

        }
        private void goBack()
        {
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.goBack();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            this.goBack();

        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
           
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CaptureScreen();
            printDocument1.Print();
        }

        Bitmap memoryImage;
        private void CaptureScreen()
        {
            Graphics myGraphics = this.CreateGraphics();
            Size s = this.Size;
            memoryImage = new Bitmap(s.Width, s.Height, myGraphics);
            Graphics memoryGraphics = Graphics.FromImage(memoryImage);
            memoryGraphics.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, s);
        }

        private void printDocument1_PrintPage(System.Object sender,
           System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(memoryImage, 0, 0);
        }
    }
}
