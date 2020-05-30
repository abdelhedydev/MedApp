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
    public partial class Interventions : Form
    {
        public Interventions()
        {
            InitializeComponent();
        }

        private void Interventions_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'medicalDataSet10.Intervention'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.interventionTableAdapter1.Fill(this.medicalDataSet10.Intervention);
            // TODO: cette ligne de code charge les données dans la table 'medicalDataSet9.Intervention'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.interventionTableAdapter.Fill(this.medicalDataSet9.Intervention);
            // TODO: cette ligne de code charge les données dans la table 'medicalDataSet5.patientMeeting'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.patientMeetingTableAdapter.Fill(this.medicalDataSet5.patientMeeting);
            // TODO: cette ligne de code charge les données dans la table 'medicalDataSet3.MeetingDetail'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            /*this.meetingDetailTableAdapter.Fill(this.medicalDataSet3.MeetingDetail);*/
            this.BindPatientMeet();

            deleteBtn.Hide();
            editBtn.Hide();

            meetingDetailGrid.BorderStyle = BorderStyle.None;
            meetingDetailGrid.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(242, 242, 242);
            meetingDetailGrid.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            meetingDetailGrid.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            meetingDetailGrid.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            meetingDetailGrid.BackgroundColor = Color.White;

            meetingDetailGrid.EnableHeadersVisualStyles = false;
            meetingDetailGrid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            meetingDetailGrid.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            meetingDetailGrid.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            this.BindMeetDetailDataGrid();
            this.bindCout();

            partieCombo.SelectedIndex = 0;
            dentCombo.SelectedIndex = 0;
            intervCombo.SelectedIndex = 0;

        }

        private void BindMeetDetailDataGrid()
        {
            string constring = @"Data Source=localhost;Initial Catalog=medical;Integrated Security=True";
            using (SqlConnection con = new SqlConnection(constring))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT MD.id as 'Id',M.hours as 'Heure',M.minutes as 'Minutes',I.name as 'Intervention' ,partie as Partie,dents as 'Dents',remarque as Remarque,cout as 'Cout' " +
                    "FROM MeetingDetail MD left join Meeting M on MD.meeting_id = M.id inner join Intervention I on MD.intervention = I.id", con))
                {
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        using (DataTable dt = new DataTable())
                        {
                            sda.Fill(dt);
                            meetingDetailGrid.DataSource = dt;
                            meetingDetailGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                            patientCount.Text = meetingDetailGrid.RowCount.ToString();


                        }
                    }
                }
            }

        }

        private void BindPatientMeet()
        {
            string connection = "Data Source=localhost;Initial Catalog=medical;Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(connection);
            string query = "SELECT Top (5) Meet.id as 'Id',P.name as 'Title' FROM Meeting Meet inner join Patient P on P.id = Meet.patient_id order BY Meet.date DESC";
            //"WHERE Meet.date like '" + DateTime.Today.ToString("yyyy-MM-dd") + "'";
            SqlCommand cmd = new SqlCommand(query, sqlConnection);
            sqlConnection.Open();
            var dataSource = new List<PatientMeeting>();
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    dataSource.Add(new PatientMeeting() { Title = reader["Title"].ToString(), Value = reader["ID"].ToString() });

                }
                //Setup data binding
                this.patientCombo.DataSource = dataSource;
                this.patientCombo.DisplayMember = "Title";
                this.patientCombo.ValueMember = "Value";

                // make it readonly
                this.patientCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            }
            sqlConnection.Close();

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=localhost;Initial Catalog=medical;Integrated Security=True";
            con.Open();
            try
            {
                if(intervCombo.SelectedValue != null)
                {
                    Int32 intervId = Int32.Parse(intervCombo.SelectedValue.ToString());
                    SqlCommand cmdMeeting = new SqlCommand("Select price from Intervention where id = '" + intervId + "'", con);
                    String cout = cmdMeeting.ExecuteScalar().ToString();
                    coutTxt.Text = cout.ToString();
                }
            }catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        /* Selecting Dents*/
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.bindCout();

        }

        public void bindCout()
        {
            dentCombo.Items.Clear();

            System.Object[] ItemObject = new System.Object[8];
            string value = partieCombo.Text.ToString();
            if (value == "Supérieur à droite")
            {
                for (int i = 0; i <= 7; i++)
                {
                    ItemObject[i] = i + 11;
                }
                dentCombo.Items.Clear();
                dentCombo.Items.AddRange(ItemObject);
            }
            else if (value == "Supérieur à gauche")
            {
                for (int i = 0; i <= 7; i++)
                {
                    ItemObject[i] = i + 21;
                }
                dentCombo.Items.Clear();
                dentCombo.Items.AddRange(ItemObject);
            }
            else if (value == "Inférieur à droite")
            {
                for (int i = 0; i <= 7; i++)
                {
                    ItemObject[i] = i + 41;
                }
                dentCombo.Items.Clear();
                dentCombo.Items.AddRange(ItemObject);
            }
            else
            {
                for (int i = 0; i <= 7; i++)
                {
                    ItemObject[i] = i + 31;
                }
                dentCombo.Items.Clear();
                dentCombo.Items.AddRange(ItemObject);
            }
        }

        private void patientCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string meetId = patientCombo.SelectedValue.ToString();
            Int32 number;
            bool result = Int32.TryParse(meetId, out number);
            if (result)
            {
                MessageBox.Show(number.ToString());
                string constring = @"Data Source=localhost;Initial Catalog=medical;Integrated Security=True";
                using (SqlConnection con = new SqlConnection(constring))
                {
                    using (SqlCommand cmd = new SqlCommand("SELECT MD.id as 'Id',M.hours as 'Heure',M.minutes as 'Minutes',I.name as 'Intervention' ,partie as 'Partie',dents as 'Dents',remarque as Remarque,cout as 'Cout' " +
                        "FROM MeetingDetail MD ,Meeting M,Intervention I where MD.meeting_id = M.id and MD.intervention = I.id and M.id = '" + number + "' ", con))
                    {
                        cmd.CommandType = CommandType.Text;
                        using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                        {
                            using (DataTable dt = new DataTable())
                            {
                                sda.Fill(dt);
                                meetingDetailGrid.DataSource = dt;
                                meetingDetailGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                                patientCount.Text = meetingDetailGrid.RowCount.ToString();


                            }
                        }
                    }
                }
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            Int32 id = Convert.ToInt32(meetingDetailGrid.Rows[meetingDetailGrid.CurrentRow.Index].Cells[0].Value);
            string connection = "Data Source=localhost;Initial Catalog=medical;Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(connection);
            string query = "DELETE from MeetingDetail where id = @id";
            SqlCommand cmd = new SqlCommand(query, sqlConnection);
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
            sqlConnection.Open();
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Intervention Supprimé avec succées");
                this.ResetInputs();

                this.BindMeetDetailDataGrid();


            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            sqlConnection.Close();
        }

        public void ResetInputs()
        {
            remarqueTxt.Text = "";
            coutTxt.Text = "";
        }

        private void meetingDetailGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            deleteBtn.Show();
            editBtn.Show();
        }

        private void save_Click(object sender, EventArgs e)
        {
            string connection = "Data Source=localhost;Initial Catalog=medical;Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(connection);
            if (save.Text == "Enregistrer")
            {
                string query = "INSERT INTO MeetingDetail " +
                            "(meeting_id, intervention, partie,dents,remarque,cout) " +
                            "VALUES (@meeting_id,  @intervention, @partie,@dents,@remarque,@cout) ";
                SqlCommand cmd = new SqlCommand(query, sqlConnection);
                cmd.Parameters.Add("@meeting_id", SqlDbType.Int).Value = Int32.Parse(patientCombo.SelectedValue.ToString());
                cmd.Parameters.Add("@intervention", SqlDbType.Int).Value = Int32.Parse(intervCombo.SelectedValue.ToString());
                cmd.Parameters.Add("@partie", SqlDbType.VarChar).Value = partieCombo.Text.ToString();
                cmd.Parameters.Add("@dents", SqlDbType.VarChar).Value = dentCombo.Text.ToString();
                cmd.Parameters.Add("@remarque", SqlDbType.VarChar).Value = remarqueTxt.Text.ToString();
                cmd.Parameters.Add("@cout", SqlDbType.VarChar).Value = coutTxt.Text.ToString();
                sqlConnection.Open();
                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Intervention Enregistré avec succées");

                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                Int32 id = Convert.ToInt32(meetingDetailGrid.Rows[meetingDetailGrid.CurrentRow.Index].Cells[0].Value);
                string query = "update MeetingDetail " +
                            "set intervention=@intervention, partie=@partie, dents=@dents,remarque=@remarque,cout=@cout " +
                            "where id = @id ";
                SqlCommand cmd = new SqlCommand(query, sqlConnection);
                cmd.Parameters.Add("@intervention", SqlDbType.Int).Value = Int32.Parse(intervCombo.SelectedValue.ToString());
                cmd.Parameters.Add("@partie", SqlDbType.VarChar).Value = partieCombo.Text.ToString();
                cmd.Parameters.Add("@dents", SqlDbType.VarChar).Value = dentCombo.Text.ToString();
                cmd.Parameters.Add("@remarque", SqlDbType.VarChar).Value = remarqueTxt.Text.ToString();
                cmd.Parameters.Add("@cout", SqlDbType.VarChar).Value = coutTxt.Text.ToString();
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
                sqlConnection.Open();
                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Intervention modifié avec succées");

                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            save.Text = "Enregistrer";
            this.ResetInputs();
            this.BindMeetDetailDataGrid();
            sqlConnection.Close();
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            Int32 id = Convert.ToInt32(meetingDetailGrid.Rows[meetingDetailGrid.CurrentRow.Index].Cells[0].Value);
            string connection = "Data Source=localhost;Initial Catalog=medical;Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(connection);
            string query = "SELECT intervention,partie,dents,remarque,cout FROM MeetingDetail where id = @id";
            SqlCommand cmd = new SqlCommand(query, sqlConnection);
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
            sqlConnection.Open();
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    remarqueTxt.Text = reader["remarque"].ToString();
                    coutTxt.Text = reader["cout"].ToString();

                    intervCombo.SelectedValue = (Int32)reader["intervention"];
                    partieCombo.Text = (String)reader["partie"];
                    dentCombo.Text = (String)reader["dents"];
                    save.Text = "Modifier";
                }
            }
            sqlConnection.Close();
        }

        private void info_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("aaa");
        }
    }

    public class PatientMeeting
    {
        public string Title { get; set; }
        public string Value { get; set; }
    }
}
