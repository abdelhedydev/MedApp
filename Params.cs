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
    public partial class Params : Form
    {
        public Params()
        {
            InitializeComponent();
            this.UserDataGrid();
            this.AsrDataGrid();
            this.IntervDataGrid();
        }

        private void UserDataGrid()
        {
            string constring = @"Data Source=localhost;Initial Catalog=medical;Integrated Security=True";
            using (SqlConnection con = new SqlConnection(constring))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT id as 'Identifiant',name as 'Nom',username as 'Utilisateur',pasword 'Mot de Pass',type as 'Type' from [User]", con))
                {
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        using (DataTable dt = new DataTable())
                        {
                            sda.Fill(dt);
                            usersDataGrid.DataSource = dt;
                            usersDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                        }
                    }
                }
            }

        }


        private void AsrDataGrid()
        {
            string constring = @"Data Source=localhost;Initial Catalog=medical;Integrated Security=True";
            using (SqlConnection con = new SqlConnection(constring))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT id as 'Identifiant',name as 'Nom',detail as 'Description' from [Assurance]", con))
                {
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        using (DataTable dt = new DataTable())
                        {
                            sda.Fill(dt);
                            asrDataGridd.DataSource = dt;
                            asrDataGridd.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                        }
                    }
                }
            }

        }

        private void IntervDataGrid()
        {
            string constring = @"Data Source=localhost;Initial Catalog=medical;Integrated Security=True";
            using (SqlConnection con = new SqlConnection(constring))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT id as 'Identifiant',name as 'Nom',price as 'Cout' from [Intervention]", con))
                {
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        using (DataTable dt = new DataTable())
                        {
                            sda.Fill(dt);
                            intervDataGrid.DataSource = dt;
                            intervDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                        }
                    }
                }
            }

        }

        private void Params_Load(object sender, EventArgs e)
        {
            deleteBtn.Hide();
            editBtn.Hide();

            editAsr.Hide();
            delAsr.Hide();

            usersDataGrid.BorderStyle = BorderStyle.None;
            usersDataGrid.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(242, 242, 242);
            usersDataGrid.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            usersDataGrid.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            usersDataGrid.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            usersDataGrid.BackgroundColor = Color.White;

            usersDataGrid.EnableHeadersVisualStyles = false;
            usersDataGrid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            usersDataGrid.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            usersDataGrid.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;



            asrDataGridd.BorderStyle = BorderStyle.None;
            asrDataGridd.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(242, 242, 242);
            asrDataGridd.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            asrDataGridd.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            asrDataGridd.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            asrDataGridd.BackgroundColor = Color.White;

            asrDataGridd.EnableHeadersVisualStyles = false;
            asrDataGridd.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            asrDataGridd.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            asrDataGridd.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;



            intervDataGrid.BorderStyle = BorderStyle.None;
            intervDataGrid.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(242, 242, 242);
            intervDataGrid.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            intervDataGrid.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            intervDataGrid.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            intervDataGrid.BackgroundColor = Color.White;

            intervDataGrid.EnableHeadersVisualStyles = false;
            intervDataGrid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            intervDataGrid.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            intervDataGrid.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }

        private void save_Click(object sender, EventArgs e)
        {
            string connection = "Data Source=localhost;Initial Catalog=medical;Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(connection);
            if (save.Text == "Enregistrer")
            {
                string query = "INSERT INTO [User] " +
                            "(username, pasword, type, name) " +
                            "VALUES (@username,  @pasword, @type,@name) ";
                SqlCommand cmd = new SqlCommand(query, sqlConnection);
                cmd.Parameters.Add("@username", SqlDbType.VarChar).Value = userNameTxt.Text;
                cmd.Parameters.Add("@pasword", SqlDbType.VarChar).Value = passwordTxt.Text;
                cmd.Parameters.Add("@type", SqlDbType.VarChar).Value = typetxt.Text;
                cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = nameTxt.Text;
                sqlConnection.Open();
                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Utilisateur Enregistré avec succées");

                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                Int32 id = Convert.ToInt32(usersDataGrid.Rows[usersDataGrid.CurrentRow.Index].Cells[0].Value);
                string query = "update [User] " +
                            "set username=@username,pasword=@pasword, type=@type,name=@name " +
                            "where id = @id ";
                SqlCommand cmd = new SqlCommand(query, sqlConnection);
                cmd.Parameters.Add("@username", SqlDbType.VarChar).Value = userNameTxt.Text;
                cmd.Parameters.Add("@pasword", SqlDbType.VarChar).Value = passwordTxt.Text;
                cmd.Parameters.Add("@type", SqlDbType.VarChar).Value = typetxt.Text;

                cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = nameTxt.Text;
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
                sqlConnection.Open();
                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Utilisateur modifié avec succées");

                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            save.Text = "Enregistrer";
            this.ResetInputs();
            this.UserDataGrid();
            sqlConnection.Close();
        }

        public void ResetInputs()
        {
            nameTxt.Text = "";
            userNameTxt.Text = "";
            passwordTxt.Text = "";
        }

        public void ResetInputsAsr()
        {
            asrdetailTxt.Text = "";
            asrNameTxt.Text = "";
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            Int32 id = Convert.ToInt32(usersDataGrid.Rows[usersDataGrid.CurrentRow.Index].Cells[0].Value);
            string connection = "Data Source=localhost;Initial Catalog=medical;Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(connection);
            string query = "DELETE from [user] where id = @id";
            SqlCommand cmd = new SqlCommand(query, sqlConnection);
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
            sqlConnection.Open();
            try
            {
                if(usersDataGrid.Rows.Count > 1)
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Utilisateur Supprimé avec succées");

                }
                else
                {
                    MessageBox.Show("Impossible de supprimer tous les utilisateurs");
                }
                
                this.ResetInputs();

                this.UserDataGrid();


            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            sqlConnection.Close();
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            Int32 id = Convert.ToInt32(usersDataGrid.Rows[usersDataGrid.CurrentRow.Index].Cells[0].Value);
            string connection = "Data Source=localhost;Initial Catalog=medical;Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(connection);
            string query = "SELECT username,pasword,type,name from [user] where id = @id";
            SqlCommand cmd = new SqlCommand(query, sqlConnection);
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
            sqlConnection.Open();
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    nameTxt.Text = reader["name"].ToString();
                    userNameTxt.Text = reader["username"].ToString();
                    passwordTxt.Text = reader["pasword"].ToString();
                    typetxt.Text = reader["type"].ToString();
                    save.Text = "Modifier";
                }
            }
            sqlConnection.Close();
        }

        private void usersDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            deleteBtn.Show();
            editBtn.Show();
        }

        private void saveAsr_Click(object sender, EventArgs e)
        {
            string connection = "Data Source=localhost;Initial Catalog=medical;Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(connection);
            if (saveAsr.Text == "Enregistrer")
            {
                string query = "INSERT INTO [Assurance] " +
                            "(detail,name) " +
                            "VALUES (@detail,@name) ";
                SqlCommand cmd = new SqlCommand(query, sqlConnection);
                cmd.Parameters.Add("@detail", SqlDbType.VarChar).Value = asrdetailTxt.Text;
                cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = asrNameTxt.Text;
                sqlConnection.Open();
                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Assurance Enregistré avec succées");

                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                Int32 id = Convert.ToInt32(asrDataGridd.Rows[asrDataGridd.CurrentRow.Index].Cells[0].Value);
                string query = "update [Assurance] " +
                            "set detail=@detail,name=@name " +
                            "where id = @id ";
                SqlCommand cmd = new SqlCommand(query, sqlConnection);
                cmd.Parameters.Add("@detail", SqlDbType.VarChar).Value = asrdetailTxt.Text;
                cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = asrNameTxt.Text;
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
                sqlConnection.Open();
                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Assurance modifié avec succées");

                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            save.Text = "Enregistrer";
            this.ResetInputsAsr();
            this.AsrDataGrid();
            sqlConnection.Close();
        }

        private void delAsr_Click(object sender, EventArgs e)
        {
            Int32 id = Convert.ToInt32(asrDataGridd.Rows[asrDataGridd.CurrentRow.Index].Cells[0].Value);
            string connection = "Data Source=localhost;Initial Catalog=medical;Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(connection);
            string query = "DELETE from [Assurance] where id = @id";
            SqlCommand cmd = new SqlCommand(query, sqlConnection);
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
            sqlConnection.Open();
            try
            {
                if (usersDataGrid.Rows.Count > 1)
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Assurance Supprimé avec succées");

                }
                else
                {
                    MessageBox.Show("Impossible de supprimer tous les assurances");
                }

                this.ResetInputsAsr();
                this.AsrDataGrid();


            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            sqlConnection.Close();
        }

        private void asrDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            editAsr.Show();
            delAsr.Show();
        }

        private void editAsr_Click(object sender, EventArgs e)
        {
            Int32 id = Convert.ToInt32(asrDataGridd.Rows[asrDataGridd.CurrentRow.Index].Cells[0].Value);
            string connection = "Data Source=localhost;Initial Catalog=medical;Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(connection);
            string query = "SELECT detail,name from [Assurance] where id = @id";
            SqlCommand cmd = new SqlCommand(query, sqlConnection);
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
            sqlConnection.Open();
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    asrNameTxt.Text = reader["name"].ToString();
                    asrdetailTxt.Text = reader["detail"].ToString();
                    saveAsr.Text = "Modifier";
                }
            }
            sqlConnection.Close();
        }

        public void ResetIntervInput()
        {
            intervCoutTxt.Text = "";
            intervNameTxt.Text = "";
        }

        private void saveInterv_Click(object sender, EventArgs e)
        {
            string connection = "Data Source=localhost;Initial Catalog=medical;Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(connection);
            if (saveInterv.Text == "Enregistrer")
            {
                string query = "INSERT INTO [Intervention] " +
                            "(price,name) " +
                            "VALUES (@price,@name) ";
                SqlCommand cmd = new SqlCommand(query, sqlConnection);
                cmd.Parameters.Add("@price", SqlDbType.VarChar).Value = intervCoutTxt.Text;
                cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = intervNameTxt.Text;
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
                Int32 id = Convert.ToInt32(intervDataGrid.Rows[intervDataGrid.CurrentRow.Index].Cells[0].Value);
                string query = "update [Intervention] " +
                            "set price=@price,name=@name " +
                            "where id = @id ";
                SqlCommand cmd = new SqlCommand(query, sqlConnection);
                cmd.Parameters.Add("@price", SqlDbType.VarChar).Value = intervCoutTxt.Text;
                cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = intervNameTxt.Text;
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
                sqlConnection.Open();
                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Assurance modifié avec succées");

                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            save.Text = "Enregistrer";
            this.ResetIntervInput();
            this.IntervDataGrid();
            sqlConnection.Close();
        }

        private void intervDeleteBtn_Click(object sender, EventArgs e)
        {
            Int32 id = Convert.ToInt32(intervDataGrid.Rows[intervDataGrid.CurrentRow.Index].Cells[0].Value);
            string connection = "Data Source=localhost;Initial Catalog=medical;Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(connection);
            string query = "DELETE from [Intervention] where id = @id";
            SqlCommand cmd = new SqlCommand(query, sqlConnection);
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
            sqlConnection.Open();
            try
            {
                if (usersDataGrid.Rows.Count > 1)
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Intervention Supprimé avec succées");

                }
                else
                {
                    MessageBox.Show("Impossible de supprimer tous les assurances");
                }

                this.IntervDataGrid();


            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            sqlConnection.Close();
        }

        private void intervEditBtn_Click(object sender, EventArgs e)
        {
            Int32 id = Convert.ToInt32(asrDataGridd.Rows[asrDataGridd.CurrentRow.Index].Cells[0].Value);
            string connection = "Data Source=localhost;Initial Catalog=medical;Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(connection);
            string query = "SELECT price,name from [Intervention] where id = @id";
            SqlCommand cmd = new SqlCommand(query, sqlConnection);
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
            sqlConnection.Open();
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    intervNameTxt.Text = reader["name"].ToString();
                    intervCoutTxt.Text = reader["price"].ToString();
                    saveAsr.Text = "Modifier";
                }
            }
            sqlConnection.Close();
        }
    }
}
