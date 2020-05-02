namespace MedProject
{
    partial class Meeting
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Meeting));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.datemeeting = new System.Windows.Forms.Label();
            this.patient = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.patientCount = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.editBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.reset = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.patientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.medicalDataSet2 = new MedProject.medicalDataSet2();
            this.button1 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.today = new System.Windows.Forms.CheckBox();
            this.patientTxt = new System.Windows.Forms.ComboBox();
            this.dateTxt = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.hoursTxt = new System.Windows.Forms.ComboBox();
            this.minutesTxt = new System.Windows.Forms.ComboBox();
            this.patientTableAdapter = new MedProject.medicalDataSet2TableAdapters.PatientTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.meetingDataGrid = new System.Windows.Forms.DataGridView();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicalDataSet2)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.meetingDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // datemeeting
            // 
            this.datemeeting.AutoSize = true;
            this.datemeeting.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datemeeting.Location = new System.Drawing.Point(11, 20);
            this.datemeeting.Name = "datemeeting";
            this.datemeeting.Size = new System.Drawing.Size(46, 21);
            this.datemeeting.TabIndex = 31;
            this.datemeeting.Text = "Date";
            // 
            // patient
            // 
            this.patient.AutoSize = true;
            this.patient.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patient.Location = new System.Drawing.Point(320, 20);
            this.patient.Name = "patient";
            this.patient.Size = new System.Drawing.Size(65, 21);
            this.patient.TabIndex = 29;
            this.patient.Text = "Patient";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Silver;
            this.panel4.Controls.Add(this.patientCount);
            this.panel4.Controls.Add(this.button2);
            this.panel4.Location = new System.Drawing.Point(979, 20);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(85, 51);
            this.panel4.TabIndex = 38;
            // 
            // patientCount
            // 
            this.patientCount.AutoSize = true;
            this.patientCount.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientCount.Location = new System.Drawing.Point(44, 16);
            this.patientCount.Name = "patientCount";
            this.patientCount.Size = new System.Drawing.Size(28, 21);
            this.patientCount.TabIndex = 29;
            this.patientCount.Text = "00";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(4, 6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(40, 38);
            this.button2.TabIndex = 25;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // save
            // 
            this.save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(214)))), ((int)(((byte)(92)))));
            this.save.FlatAppearance.BorderSize = 0;
            this.save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.save.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save.ForeColor = System.Drawing.Color.White;
            this.save.Location = new System.Drawing.Point(379, 69);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(228, 46);
            this.save.TabIndex = 35;
            this.save.Text = "Enregistrer";
            this.save.UseVisualStyleBackColor = false;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.BackColor = System.Drawing.Color.White;
            this.deleteBtn.FlatAppearance.BorderSize = 0;
            this.deleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteBtn.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteBtn.ForeColor = System.Drawing.Color.White;
            this.deleteBtn.Image = ((System.Drawing.Image)(resources.GetObject("deleteBtn.Image")));
            this.deleteBtn.Location = new System.Drawing.Point(76, 9);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(29, 32);
            this.deleteBtn.TabIndex = 41;
            this.deleteBtn.UseVisualStyleBackColor = false;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // editBtn
            // 
            this.editBtn.BackColor = System.Drawing.Color.White;
            this.editBtn.FlatAppearance.BorderSize = 0;
            this.editBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editBtn.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editBtn.ForeColor = System.Drawing.Color.White;
            this.editBtn.Image = ((System.Drawing.Image)(resources.GetObject("editBtn.Image")));
            this.editBtn.Location = new System.Drawing.Point(16, 9);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(29, 32);
            this.editBtn.TabIndex = 40;
            this.editBtn.UseVisualStyleBackColor = false;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(43)))), ((int)(((byte)(67)))));
            this.panel2.Controls.Add(this.reset);
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Controls.Add(this.deleteBtn);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.editBtn);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(0, 127);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1104, 55);
            this.panel2.TabIndex = 42;
            // 
            // reset
            // 
            this.reset.BackColor = System.Drawing.Color.White;
            this.reset.FlatAppearance.BorderSize = 0;
            this.reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reset.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reset.ForeColor = System.Drawing.Color.White;
            this.reset.Image = ((System.Drawing.Image)(resources.GetObject("reset.Image")));
            this.reset.Location = new System.Drawing.Point(1064, 7);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(29, 32);
            this.reset.TabIndex = 52;
            this.reset.UseVisualStyleBackColor = false;
            this.reset.Click += new System.EventHandler(this.resetFilter);
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.patientBindingSource;
            this.comboBox1.DisplayMember = "name";
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(796, 9);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(204, 29);
            this.comboBox1.TabIndex = 50;
            this.comboBox1.ValueMember = "id";
            // 
            // patientBindingSource
            // 
            this.patientBindingSource.DataMember = "Patient";
            this.patientBindingSource.DataSource = this.medicalDataSet2;
            // 
            // medicalDataSet2
            // 
            this.medicalDataSet2.DataSetName = "medicalDataSet2";
            this.medicalDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(1009, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(29, 32);
            this.button1.TabIndex = 51;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.search);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.today);
            this.panel3.Location = new System.Drawing.Point(666, 9);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(124, 29);
            this.panel3.TabIndex = 51;
            // 
            // today
            // 
            this.today.AutoSize = true;
            this.today.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.today.Location = new System.Drawing.Point(7, 3);
            this.today.Name = "today";
            this.today.Size = new System.Drawing.Size(111, 25);
            this.today.TabIndex = 0;
            this.today.Text = "Aujourd\'hui";
            this.today.UseVisualStyleBackColor = true;
            this.today.CheckedChanged += new System.EventHandler(this.today_CheckedChanged);
            // 
            // patientTxt
            // 
            this.patientTxt.DataSource = this.patientBindingSource;
            this.patientTxt.DisplayMember = "name";
            this.patientTxt.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientTxt.FormattingEnabled = true;
            this.patientTxt.Location = new System.Drawing.Point(403, 20);
            this.patientTxt.Name = "patientTxt";
            this.patientTxt.Size = new System.Drawing.Size(204, 29);
            this.patientTxt.TabIndex = 43;
            this.patientTxt.ValueMember = "id";
            // 
            // dateTxt
            // 
            this.dateTxt.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTxt.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTxt.Location = new System.Drawing.Point(76, 20);
            this.dateTxt.Name = "dateTxt";
            this.dateTxt.Size = new System.Drawing.Size(200, 28);
            this.dateTxt.TabIndex = 44;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 21);
            this.label1.TabIndex = 33;
            this.label1.Text = "Heure";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(136, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 31);
            this.label2.TabIndex = 47;
            this.label2.Text = "/";
            // 
            // hoursTxt
            // 
            this.hoursTxt.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hoursTxt.FormattingEnabled = true;
            this.hoursTxt.Items.AddRange(new object[] {
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17"});
            this.hoursTxt.Location = new System.Drawing.Point(75, 66);
            this.hoursTxt.Name = "hoursTxt";
            this.hoursTxt.Size = new System.Drawing.Size(42, 29);
            this.hoursTxt.TabIndex = 48;
            // 
            // minutesTxt
            // 
            this.minutesTxt.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minutesTxt.FormattingEnabled = true;
            this.minutesTxt.Items.AddRange(new object[] {
            "00",
            "15",
            "30",
            "45"});
            this.minutesTxt.Location = new System.Drawing.Point(183, 66);
            this.minutesTxt.Name = "minutesTxt";
            this.minutesTxt.Size = new System.Drawing.Size(44, 29);
            this.minutesTxt.TabIndex = 49;
            // 
            // patientTableAdapter
            // 
            this.patientTableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.patientTxt);
            this.panel1.Controls.Add(this.patient);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.minutesTxt);
            this.panel1.Controls.Add(this.dateTxt);
            this.panel1.Controls.Add(this.hoursTxt);
            this.panel1.Controls.Add(this.save);
            this.panel1.Controls.Add(this.datemeeting);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(0, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1104, 128);
            this.panel1.TabIndex = 50;
            // 
            // meetingDataGrid
            // 
            this.meetingDataGrid.AllowUserToAddRows = false;
            this.meetingDataGrid.AllowUserToDeleteRows = false;
            this.meetingDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.meetingDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.meetingDataGrid.DefaultCellStyle = dataGridViewCellStyle1;
            this.meetingDataGrid.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.meetingDataGrid.Location = new System.Drawing.Point(0, 177);
            this.meetingDataGrid.Name = "meetingDataGrid";
            this.meetingDataGrid.ReadOnly = true;
            this.meetingDataGrid.RowTemplate.Height = 25;
            this.meetingDataGrid.Size = new System.Drawing.Size(1104, 423);
            this.meetingDataGrid.TabIndex = 39;
            this.meetingDataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.meetingDataGrid_CellClick);
            this.meetingDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.meetingDataGrid_CellClick);
            // 
            // Meeting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 600);
            this.ControlBox = false;
            this.Controls.Add(this.meetingDataGrid);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Meeting";
            this.Text = "Meeting";
            this.Load += new System.EventHandler(this.Meeting_Load);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicalDataSet2)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.meetingDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label datemeeting;
        private System.Windows.Forms.Label patient;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label patientCount;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button editBtn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox patientTxt;
        private System.Windows.Forms.DateTimePicker dateTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox hoursTxt;
        private System.Windows.Forms.ComboBox minutesTxt;
        private medicalDataSet2 medicalDataSet2;
        private System.Windows.Forms.BindingSource patientBindingSource;
        private medicalDataSet2TableAdapters.PatientTableAdapter patientTableAdapter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.CheckBox today;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridView meetingDataGrid;
    }
}