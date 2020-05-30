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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
            Dashboard buy = new Dashboard();
            nav(buy, content);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 fl = new Form1();
            fl.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void panelLogo_Paint(object sender, PaintEventArgs e)
        {
            
        }

        public void nav(Form form, Panel panel)
        {
            form.TopLevel = false;
            form.Size = panel.Size; // for responsive size
            panel.Controls.Clear();
            panel.Controls.Add(form);
            form.Show();
        }

        private void patientsBtn_Click(object sender, EventArgs e)
        {
            MesPatients buy = new MesPatients();
            nav(buy, content);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Meeting buy = new Meeting();
            nav(buy, content);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Interventions buy = new Interventions();
            nav(buy, content);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Params buy = new Params();
            nav(buy, content);
        }

        private void label9_Click(object sender, EventArgs e)
        {
            Dashboard buy = new Dashboard();
            nav(buy, content);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Dashboard buy = new Dashboard();
            nav(buy, content);
        }
    }
}
