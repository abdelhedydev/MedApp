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
/*using Excel = Microsoft.Office.Interop.Excel;*/


namespace MedProject
{
    public partial class MesPatients : Form
    {
        public MesPatients()
        {
            InitializeComponent();
            BindPatitentDataGrid();
        }

        private void BindPatitentDataGrid()
        {
            string constring = @"Data Source=localhost;Initial Catalog=medical;Integrated Security=True";
            using (SqlConnection con = new SqlConnection(constring))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT patient.id,patient.name as 'Nom & Prenom' ,cin as Identifiant,telephone as Téléphone,adresse as Adresse,sexe as Genre,date as 'Date',antecedants, asr.name as 'Assurance' " +
                    "FROM patient left join assurance asr on patient.assurance_id = asr.id", con))
                {
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        using (DataTable dt = new DataTable())
                        {
                            sda.Fill(dt);
                            patientDataGrid.DataSource = dt;
                            patientDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                            patientCount.Text = patientDataGrid.RowCount.ToString();


                        }
                    }
                }
            }
            
        }

        private void save_Click(object sender, EventArgs e)
        {
            string connection = "Data Source=localhost;Initial Catalog=medical;Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(connection);
            if(save.Text == "Enregistrer")
            {
                string query = "INSERT INTO Patient " +
                            "(name, cin, adresse, date,sexe,telephone,antecedants,assurance_id) " +
                            "VALUES (@name,  @cin, @adresse,@date,@sexe,@telephone,@antecedants,@assurance_id) ";
                SqlCommand cmd = new SqlCommand(query, sqlConnection);
                cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = name.Text;
                cmd.Parameters.Add("@cin", SqlDbType.VarChar, 100).Value = cin.Text;
                cmd.Parameters.Add("@adresse", SqlDbType.VarChar).Value = patientAdr.Text;
                cmd.Parameters.Add("@antecedants", SqlDbType.VarChar).Value = antecedants.Text;
                cmd.Parameters.Add("@sexe", SqlDbType.VarChar).Value = homme.Checked ? "H" : "F";
                cmd.Parameters.Add("@telephone", SqlDbType.VarChar).Value = telephone.Text;
                cmd.Parameters.Add("@date", SqlDbType.Date).Value = date.Text;
                cmd.Parameters.Add("@assurance_id", SqlDbType.Int).Value = Int32.Parse(assurance.SelectedValue.ToString());
                sqlConnection.Open();
                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Patient Enregistré avec succées");

                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                Int32 id = Convert.ToInt32(patientDataGrid.Rows[patientDataGrid.CurrentRow.Index].Cells[0].Value);
                string query = "update Patient " +
                            "set name=@name, cin=@cin, adresse=@adresse,sexe=@sexe,telephone=@telephone,assurance_id=@assurance_id,date=@date,antecedants=@antecedants " +
                            "where id = @id ";
                SqlCommand cmd = new SqlCommand(query, sqlConnection);
                cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = name.Text;
                cmd.Parameters.Add("@cin", SqlDbType.VarChar, 100).Value = cin.Text;
                cmd.Parameters.Add("@adresse", SqlDbType.VarChar).Value = patientAdr.Text;
                cmd.Parameters.Add("@sexe", SqlDbType.VarChar).Value = homme.Checked ? "H" : "F";
                cmd.Parameters.Add("@telephone", SqlDbType.VarChar).Value = telephone.Text;
                cmd.Parameters.Add("@date", SqlDbType.Date).Value = date.Text;
                cmd.Parameters.Add("@antecedants", SqlDbType.VarChar).Value = antecedants.Text;
                cmd.Parameters.Add("@assurance_id", SqlDbType.Int).Value = Int32.Parse(assurance.SelectedValue.ToString());
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
                sqlConnection.Open();
                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Patient modifié avec succées");

                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            save.Text = "Enregistrer";
            this.ResetInputs();
            this.BindPatitentDataGrid();
            sqlConnection.Close();
        }

        public void ResetInputs()
        {
            name.Text = "";
            cin.Text = "";
            patientAdr.Text = "";
            telephone.Text = "";
            antecedants.Text = "";
        }

        private void MesPatients_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'medicalDataSet1.Assurance'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.assuranceTableAdapter.Fill(this.medicalDataSet1.Assurance);
            // TODO: cette ligne de code charge les données dans la table 'medicalDataSet.Patient'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.patientTableAdapter.Fill(this.medicalDataSet.Patient);

            deleteBtn.Hide();
            editBtn.Hide();
            info.Hide();

            patientDataGrid.BorderStyle = BorderStyle.None;
            patientDataGrid.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(242, 242, 242);
            patientDataGrid.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            patientDataGrid.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            patientDataGrid.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            patientDataGrid.BackgroundColor = Color.White;

            patientDataGrid.EnableHeadersVisualStyles = false;
            patientDataGrid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            patientDataGrid.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            patientDataGrid.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.patientTableAdapter.FillBy(this.medicalDataSet.Patient);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillBy1ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.patientTableAdapter.FillBy1(this.medicalDataSet.Patient);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("test");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            deleteBtn.Show();
            editBtn.Show();
            info.Show();

        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            Int32 id = Convert.ToInt32(patientDataGrid.Rows[patientDataGrid.CurrentRow.Index].Cells[0].Value);
            string connection = "Data Source=localhost;Initial Catalog=medical;Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(connection);
            string query = "DELETE from Patient where id = @id";
            SqlCommand cmd = new SqlCommand(query, sqlConnection);
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
            sqlConnection.Open();
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Patient Supprimé avec succées");
                this.ResetInputs();

                this.BindPatitentDataGrid();


            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            sqlConnection.Close();

        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            Int32 id = Convert.ToInt32(patientDataGrid.Rows[patientDataGrid.CurrentRow.Index].Cells[0].Value);
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
                    name.Text = reader["name"].ToString();
                    cin.Text = reader["cin"].ToString();
                    patientAdr.Text = reader["adresse"].ToString();
                    date.Value = DateTime.Parse(reader["date"].ToString());
                    telephone.Text = reader["telephone"].ToString();
                    antecedants.Text = reader["antecedants"].ToString();
                    if(reader["sexe"].ToString() == "F")
                    {
                        femme.Checked = true;

                    }else
                    {
                        homme.Checked = true;
                    }
                    assurance.SelectedValue = (Int32)reader["assurance_id"];
                    save.Text = "Modifier";
                }
            }
            sqlConnection.Close();
        }

        /* Export To Excel */
        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Exported To Excel File");

        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("File is Imported");
        }

        /*Search*/
        private void button1_Click(object sender, EventArgs e)
        {
            if(searchWord.Text.Length > 0)
            {
                string constring = @"Data Source=localhost;Initial Catalog=medical;Integrated Security=True";
                using (SqlConnection con = new SqlConnection(constring))
                {
                    /*name.Text = reader["name"].ToString();
                    cin.Text = reader["cin"].ToString();
                    patientAdr.Text = reader["adresse"].ToString();
                    date.Value = DateTime.Parse(reader["date"].ToString());
                    telephone.Text = reader["telephone"].ToString();*/
                    using (SqlCommand cmd = new SqlCommand("SELECT patient.id,patient.name as 'Nom & Prenom' ,cin as Identifiant,telephone as Téléphone,adresse as Adresse,sexe as Genre, asr.name as 'Assurance' " +
                        "FROM patient, assurance asr where patient.assurance_id = asr.id and ( patient.name like '%"+ searchWord.Text + "%'"+
                        "or patient.cin like '%"+ searchWord.Text + "%'" +
                        "or patient.telephone like '%" + searchWord.Text + "%'" +
                        "or patient.adresse like '%" + searchWord.Text + "%'" +
                        "or patient.antecedants like '%" + searchWord.Text + "%'" +
                        "or asr.name like '%" + searchWord.Text + "%'"+")", con))
                    {
                        cmd.CommandType = CommandType.Text;
                        using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                        {
                            using (DataTable dt = new DataTable())
                            {
                                sda.Fill(dt);
                                patientDataGrid.DataSource = dt;
                                patientDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                                patientCount.Text = patientDataGrid.RowCount.ToString();


                            }
                        }
                    }
                }
            }
            else
            {
                this.BindPatitentDataGrid();
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void searchWord_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void info_Click(object sender, EventArgs e)
        {
            Int32 id = Convert.ToInt32(patientDataGrid.Rows[patientDataGrid.CurrentRow.Index].Cells[0].Value);
            MessageBox.Show("go to Info");
        }
    }
}
