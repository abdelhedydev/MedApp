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

namespace MedProject
{
    public partial class Meeting : Form
    {
        public Meeting()
        {
            InitializeComponent();
            this.BindMeetingDataGrid();

        }

        private void Meeting_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'medicalDataSet2.Patient'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.patientTableAdapter.Fill(this.medicalDataSet2.Patient);

            deleteBtn.Hide();
            editBtn.Hide();
            reset.Hide();

            meetingDataGrid.BorderStyle = BorderStyle.None;
            meetingDataGrid.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(242, 242, 242);
            meetingDataGrid.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            meetingDataGrid.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            meetingDataGrid.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            meetingDataGrid.BackgroundColor = Color.White;

            meetingDataGrid.EnableHeadersVisualStyles = false;
            meetingDataGrid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            meetingDataGrid.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            meetingDataGrid.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

        }

        private void BindMeetingDataGrid()
        {
            string constring = @"Data Source=localhost;Initial Catalog=medical;Integrated Security=True";
            using (SqlConnection con = new SqlConnection(constring))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT meet.id as 'Id',patient.name as 'Nom & Prenom' ,CONCAT(hours,minutes) as Heure,meet.date as 'Date'  " +
                    "FROM patient right join meeting meet on patient.id = meet.patient_id", con))
                {
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        using (DataTable dt = new DataTable())
                        {
                            sda.Fill(dt);
                            meetingDataGrid.DataSource = dt;
                            meetingDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                            patientCount.Text = meetingDataGrid.RowCount.ToString();


                        }
                    }
                }
            }

        }

        private void meetingDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
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
                string query = "INSERT INTO Meeting " +
                            "(date, hours, minutes, patient_id) " +
                            "VALUES (@date,  @hours, @minutes,@patient_id) ";
                SqlCommand cmd = new SqlCommand(query, sqlConnection);
                cmd.Parameters.Add("@date", SqlDbType.Date).Value = dateTxt.Text;
                cmd.Parameters.Add("@hours", SqlDbType.VarChar).Value = hoursTxt.Text.ToString();
                cmd.Parameters.Add("@minutes", SqlDbType.VarChar).Value = minutesTxt.Text.ToString();
                cmd.Parameters.Add("@patient_id", SqlDbType.Int).Value = Int32.Parse(patientTxt.SelectedValue.ToString());
                sqlConnection.Open();
                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Rendez-vous Enregistré avec succées");

                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                Int32 id = Convert.ToInt32(meetingDataGrid.Rows[meetingDataGrid.CurrentRow.Index].Cells[0].Value);
                string query = "update Meeting " +
                            "set date=@date,  hours=@hours, minutes=@minutes,patient_id=@patient_id " +
                            "where id = @id ";
                SqlCommand cmd = new SqlCommand(query, sqlConnection);
                cmd.Parameters.Add("@date", SqlDbType.Date).Value = dateTxt.Text;
                cmd.Parameters.Add("@hours", SqlDbType.VarChar, 100).Value = hoursTxt.Text.ToString();
                cmd.Parameters.Add("@minutes", SqlDbType.VarChar, 100).Value = minutesTxt.Text.ToString();
                cmd.Parameters.Add("@patient_id", SqlDbType.Int).Value = Int32.Parse(patientTxt.SelectedValue.ToString());
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
                sqlConnection.Open();
                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Rendez-vous modifié avec succées");

                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            deleteBtn.Hide();
            editBtn.Hide();
            save.Text = "Enregistrer";
            this.BindMeetingDataGrid();
            sqlConnection.Close();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            Int32 id = Convert.ToInt32(meetingDataGrid.Rows[meetingDataGrid.CurrentRow.Index].Cells[0].Value);
            string connection = "Data Source=localhost;Initial Catalog=medical;Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(connection);
            string query = "DELETE from Meeting where id = @id";
            SqlCommand cmd = new SqlCommand(query, sqlConnection);
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
            sqlConnection.Open();
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Rendez-vous Supprimé avec succées");
                this.BindMeetingDataGrid();


            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            sqlConnection.Close();
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            Int32 id = Convert.ToInt32(meetingDataGrid.Rows[meetingDataGrid.CurrentRow.Index].Cells[0].Value);
            string connection = "Data Source=localhost;Initial Catalog=medical;Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(connection);
            string query = "SELECT date,hours,minutes,patient_id from Meeting where id = @id";
            SqlCommand cmd = new SqlCommand(query, sqlConnection);
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
            sqlConnection.Open();
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    patientTxt.SelectedValue = (Int32)reader["patient_id"];
                    hoursTxt.Text = reader["hours"].ToString();
                    minutesTxt.Text = reader["minutes"].ToString();
                    dateTxt.Value = DateTime.Parse(reader["date"].ToString());
                    save.Text = "Modifier";
                }
            }
            sqlConnection.Close();
        }

        private void today_CheckedChanged(object sender, EventArgs e)
        {
            /*if (today.Checked)
            {
                string constring = @"Data Source=localhost;Initial Catalog=medical;Integrated Security=True";
                using (SqlConnection con = new SqlConnection(constring))
                {
                    using (SqlCommand cmd = new SqlCommand("SELECT meet.id as 'Id',patient.name as 'Nom & Prenom' ,meet.date as 'Date',CONCAT(hours,':',minutes) as Heure  " +
                        "FROM patient, meeting meet where patient.id = meet.patient_id and meet.date like '" + DateTime.Today.ToString("yyyy-MM-dd") + "'", con))
                    {
                        cmd.CommandType = CommandType.Text;
                        using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                        {
                            using (DataTable dt = new DataTable())
                            {
                                sda.Fill(dt);
                                meetingDataGrid.DataSource = dt;
                                meetingDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                                patientCount.Text = meetingDataGrid.RowCount.ToString();


                            }
                        }
                    }
                }
            }
            else
            {
                this.BindMeetingDataGrid();
            }*/
        }

        private void search(object sender, EventArgs e)
        {
            reset.Show();
            if (today.Checked)
            {
                string constring = @"Data Source=localhost;Initial Catalog=medical;Integrated Security=True";
                using (SqlConnection con = new SqlConnection(constring))
                {
                    using (SqlCommand cmd = new SqlCommand("SELECT meet.id as 'Id',patient.name as 'Nom & Prenom' ,meet.date as 'Date',CONCAT(hours,':',minutes) as Heure  " +
                        "FROM patient, meeting meet where patient.id = meet.patient_id and meet.patient_id = '" + Int32.Parse(patientTxt.SelectedValue.ToString()) + "'" +
                        "and meet.date like '" + DateTime.Today.ToString("yyyy-MM-dd") + "'", con))
                    {
                        cmd.CommandType = CommandType.Text;
                        using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                        {
                            using (DataTable dt = new DataTable())
                            {
                                sda.Fill(dt);
                                meetingDataGrid.DataSource = dt;
                                meetingDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                                patientCount.Text = meetingDataGrid.RowCount.ToString();


                            }
                        }
                    }
                }
            }
            else
            {
                string constring = @"Data Source=localhost;Initial Catalog=medical;Integrated Security=True";
                using (SqlConnection con = new SqlConnection(constring))
                {
                    using (SqlCommand cmd = new SqlCommand("SELECT meet.id as 'Id',patient.name as 'Nom & Prenom' ,meet.date as 'Date',CONCAT(hours,':',minutes) as Heure  " +
                        "FROM patient, meeting meet where patient.id = meet.patient_id and meet.patient_id = '" + Int32.Parse(patientTxt.SelectedValue.ToString()) + "'", con))
                    {
                        cmd.CommandType = CommandType.Text;
                        using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                        {
                            using (DataTable dt = new DataTable())
                            {
                                sda.Fill(dt);
                                meetingDataGrid.DataSource = dt;
                                meetingDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                                patientCount.Text = meetingDataGrid.RowCount.ToString();


                            }
                        }
                    }
                }
            }
        }

        private void resetFilter(object sender, EventArgs e)
        {
            this.BindMeetingDataGrid();
            reset.Hide();
            today.Checked = false;
        }
    }
}
