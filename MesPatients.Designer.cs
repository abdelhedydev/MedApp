namespace MedProject
{
    partial class MesPatients
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MesPatients));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.antecedants = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.panel4 = new System.Windows.Forms.Panel();
            this.patientCount = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.assurance = new System.Windows.Forms.ListBox();
            this.assuranceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.medicalDataSet1 = new MedProject.medicalDataSet1();
            this.label5 = new System.Windows.Forms.Label();
            this.femme = new System.Windows.Forms.RadioButton();
            this.homme = new System.Windows.Forms.RadioButton();
            this.save = new System.Windows.Forms.Button();
            this.telephone = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.agee = new System.Windows.Forms.Label();
            this.patientAdr = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cin = new System.Windows.Forms.TextBox();
            this.cinn = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.patientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.medicalDataSet = new MedProject.medicalDataSet();
            this.patientTableAdapter = new MedProject.medicalDataSetTableAdapters.PatientTableAdapter();
            this.searchWord = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.editBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.medicalDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.assuranceTableAdapter = new MedProject.medicalDataSet1TableAdapters.AssuranceTableAdapter();
            this.patientDataGrid = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.medicalDataSet2 = new MedProject.medicalDataSet();
            this.info = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.assuranceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicalDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicalDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicalDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientDataGrid)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.medicalDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.antecedants);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.date);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.assurance);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.femme);
            this.panel1.Controls.Add(this.homme);
            this.panel1.Controls.Add(this.save);
            this.panel1.Controls.Add(this.telephone);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.agee);
            this.panel1.Controls.Add(this.patientAdr);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cin);
            this.panel1.Controls.Add(this.cinn);
            this.panel1.Controls.Add(this.name);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1104, 176);
            this.panel1.TabIndex = 0;
            // 
            // antecedants
            // 
            this.antecedants.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.antecedants.Location = new System.Drawing.Point(465, 98);
            this.antecedants.Multiline = true;
            this.antecedants.Name = "antecedants";
            this.antecedants.Size = new System.Drawing.Size(188, 58);
            this.antecedants.TabIndex = 31;
            this.antecedants.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(357, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 21);
            this.label6.TabIndex = 30;
            this.label6.Text = "Antecedants";
            // 
            // date
            // 
            this.date.CalendarFont = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date.Location = new System.Drawing.Point(132, 99);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(188, 28);
            this.date.TabIndex = 29;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Silver;
            this.panel4.Controls.Add(this.patientCount);
            this.panel4.Controls.Add(this.button2);
            this.panel4.Location = new System.Drawing.Point(975, 35);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(85, 51);
            this.panel4.TabIndex = 28;
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
            this.button2.Location = new System.Drawing.Point(9, 10);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(29, 32);
            this.button2.TabIndex = 25;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Silver;
            this.panel3.Controls.Add(this.button5);
            this.panel3.Controls.Add(this.button4);
            this.panel3.Location = new System.Drawing.Point(975, 105);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(85, 51);
            this.panel3.TabIndex = 27;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.White;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.Location = new System.Drawing.Point(9, 10);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(29, 32);
            this.button5.TabIndex = 25;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.White;
            this.button4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button4.BackgroundImage")));
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(48, 9);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(29, 32);
            this.button4.TabIndex = 26;
            this.button4.UseVisualStyleBackColor = false;
            // 
            // assurance
            // 
            this.assurance.DataSource = this.assuranceBindingSource;
            this.assurance.DisplayMember = "name";
            this.assurance.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.assurance.FormattingEnabled = true;
            this.assurance.ItemHeight = 21;
            this.assurance.Location = new System.Drawing.Point(691, 35);
            this.assurance.Name = "assurance";
            this.assurance.Size = new System.Drawing.Size(228, 67);
            this.assurance.TabIndex = 19;
            this.assurance.ValueMember = "id";
            // 
            // assuranceBindingSource
            // 
            this.assuranceBindingSource.DataMember = "Assurance";
            this.assuranceBindingSource.DataSource = this.medicalDataSet1;
            // 
            // medicalDataSet1
            // 
            this.medicalDataSet1.DataSetName = "medicalDataSet1";
            this.medicalDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(687, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 21);
            this.label5.TabIndex = 18;
            this.label5.Text = "Assurance";
            // 
            // femme
            // 
            this.femme.AutoSize = true;
            this.femme.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.femme.Location = new System.Drawing.Point(238, 138);
            this.femme.Name = "femme";
            this.femme.Size = new System.Drawing.Size(81, 24);
            this.femme.TabIndex = 16;
            this.femme.TabStop = true;
            this.femme.Text = "Femme";
            this.femme.UseVisualStyleBackColor = true;
            // 
            // homme
            // 
            this.homme.AutoSize = true;
            this.homme.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homme.Location = new System.Drawing.Point(131, 138);
            this.homme.Name = "homme";
            this.homme.Size = new System.Drawing.Size(83, 24);
            this.homme.TabIndex = 15;
            this.homme.TabStop = true;
            this.homme.Text = "Homme";
            this.homme.UseVisualStyleBackColor = true;
            // 
            // save
            // 
            this.save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(214)))), ((int)(((byte)(92)))));
            this.save.FlatAppearance.BorderSize = 0;
            this.save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.save.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save.ForeColor = System.Drawing.Color.White;
            this.save.Location = new System.Drawing.Point(691, 110);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(228, 46);
            this.save.TabIndex = 14;
            this.save.Text = "Enregistrer";
            this.save.UseVisualStyleBackColor = false;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // telephone
            // 
            this.telephone.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telephone.Location = new System.Drawing.Point(465, 8);
            this.telephone.Name = "telephone";
            this.telephone.Size = new System.Drawing.Size(188, 28);
            this.telephone.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(357, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 21);
            this.label3.TabIndex = 12;
            this.label3.Text = "Téléphone";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(10, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 21);
            this.label4.TabIndex = 10;
            this.label4.Text = "Sexe";
            // 
            // agee
            // 
            this.agee.AutoSize = true;
            this.agee.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agee.Location = new System.Drawing.Point(11, 105);
            this.agee.Name = "agee";
            this.agee.Size = new System.Drawing.Size(87, 21);
            this.agee.TabIndex = 8;
            this.agee.Text = "Naissance";
            // 
            // patientAdr
            // 
            this.patientAdr.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientAdr.Location = new System.Drawing.Point(465, 51);
            this.patientAdr.Name = "patientAdr";
            this.patientAdr.Size = new System.Drawing.Size(188, 28);
            this.patientAdr.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(357, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 21);
            this.label2.TabIndex = 6;
            this.label2.Text = "Addresse";
            // 
            // cin
            // 
            this.cin.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cin.Location = new System.Drawing.Point(132, 56);
            this.cin.Name = "cin";
            this.cin.Size = new System.Drawing.Size(188, 28);
            this.cin.TabIndex = 5;
            // 
            // cinn
            // 
            this.cinn.AutoSize = true;
            this.cinn.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cinn.Location = new System.Drawing.Point(11, 59);
            this.cinn.Name = "cinn";
            this.cinn.Size = new System.Drawing.Size(115, 21);
            this.cinn.TabIndex = 4;
            this.cinn.Text = "Cin / Passport";
            // 
            // name
            // 
            this.name.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.Location = new System.Drawing.Point(132, 15);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(188, 28);
            this.name.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom & Prenom";
            // 
            // patientBindingSource
            // 
            this.patientBindingSource.DataMember = "Patient";
            this.patientBindingSource.DataSource = this.medicalDataSet;
            // 
            // medicalDataSet
            // 
            this.medicalDataSet.DataSetName = "medicalDataSet";
            this.medicalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // patientTableAdapter
            // 
            this.patientTableAdapter.ClearBeforeFill = true;
            // 
            // searchWord
            // 
            this.searchWord.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchWord.Location = new System.Drawing.Point(856, 12);
            this.searchWord.Name = "searchWord";
            this.searchWord.Size = new System.Drawing.Size(188, 32);
            this.searchWord.TabIndex = 18;
            this.searchWord.TextChanged += new System.EventHandler(this.searchWord_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(1063, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(29, 32);
            this.button1.TabIndex = 17;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // editBtn
            // 
            this.editBtn.BackColor = System.Drawing.Color.White;
            this.editBtn.FlatAppearance.BorderSize = 0;
            this.editBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editBtn.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editBtn.ForeColor = System.Drawing.Color.White;
            this.editBtn.Image = ((System.Drawing.Image)(resources.GetObject("editBtn.Image")));
            this.editBtn.Location = new System.Drawing.Point(19, 188);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(29, 32);
            this.editBtn.TabIndex = 20;
            this.editBtn.UseVisualStyleBackColor = false;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.BackColor = System.Drawing.Color.White;
            this.deleteBtn.FlatAppearance.BorderSize = 0;
            this.deleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteBtn.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteBtn.ForeColor = System.Drawing.Color.White;
            this.deleteBtn.Image = ((System.Drawing.Image)(resources.GetObject("deleteBtn.Image")));
            this.deleteBtn.Location = new System.Drawing.Point(65, 188);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(29, 32);
            this.deleteBtn.TabIndex = 21;
            this.deleteBtn.UseVisualStyleBackColor = false;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // medicalDataSetBindingSource
            // 
            this.medicalDataSetBindingSource.DataSource = this.medicalDataSet;
            this.medicalDataSetBindingSource.Position = 0;
            // 
            // assuranceTableAdapter
            // 
            this.assuranceTableAdapter.ClearBeforeFill = true;
            // 
            // patientDataGrid
            // 
            this.patientDataGrid.AllowUserToAddRows = false;
            this.patientDataGrid.AllowUserToDeleteRows = false;
            this.patientDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.patientDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.patientDataGrid.DefaultCellStyle = dataGridViewCellStyle1;
            this.patientDataGrid.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.patientDataGrid.Location = new System.Drawing.Point(0, 226);
            this.patientDataGrid.Name = "patientDataGrid";
            this.patientDataGrid.ReadOnly = true;
            this.patientDataGrid.RowTemplate.Height = 25;
            this.patientDataGrid.Size = new System.Drawing.Size(1104, 374);
            this.patientDataGrid.TabIndex = 19;
            this.patientDataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.patientDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(43)))), ((int)(((byte)(67)))));
            this.panel2.Controls.Add(this.info);
            this.panel2.Controls.Add(this.searchWord);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Location = new System.Drawing.Point(0, 176);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1104, 55);
            this.panel2.TabIndex = 22;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // medicalDataSet2
            // 
            this.medicalDataSet2.DataSetName = "medicalDataSet";
            this.medicalDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // info
            // 
            this.info.BackColor = System.Drawing.Color.White;
            this.info.FlatAppearance.BorderSize = 0;
            this.info.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.info.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.info.ForeColor = System.Drawing.Color.White;
            this.info.Image = ((System.Drawing.Image)(resources.GetObject("info.Image")));
            this.info.Location = new System.Drawing.Point(112, 12);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(29, 32);
            this.info.TabIndex = 23;
            this.info.UseVisualStyleBackColor = false;
            this.info.Click += new System.EventHandler(this.info_Click);
            // 
            // MesPatients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 600);
            this.ControlBox = false;
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.editBtn);
            this.Controls.Add(this.patientDataGrid);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MesPatients";
            this.Text = "MesPatients";
            this.Load += new System.EventHandler(this.MesPatients_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.assuranceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicalDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicalDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicalDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientDataGrid)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.medicalDataSet2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.TextBox telephone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label agee;
        private System.Windows.Forms.TextBox patientAdr;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox cin;
        private System.Windows.Forms.Label cinn;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label label1;
        private medicalDataSet medicalDataSet;
        private System.Windows.Forms.BindingSource patientBindingSource;
        private medicalDataSetTableAdapters.PatientTableAdapter patientTableAdapter;
        private System.Windows.Forms.RadioButton femme;
        private System.Windows.Forms.RadioButton homme;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox searchWord;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button editBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.ListBox assurance;
        private System.Windows.Forms.BindingSource medicalDataSetBindingSource;
        private medicalDataSet1 medicalDataSet1;
        private System.Windows.Forms.BindingSource assuranceBindingSource;
        private medicalDataSet1TableAdapters.AssuranceTableAdapter assuranceTableAdapter;
        private System.Windows.Forms.DataGridView patientDataGrid;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label patientCount;
        private System.Windows.Forms.Button button2;
        private medicalDataSet medicalDataSet2;
        private System.Windows.Forms.TextBox antecedants;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.Button info;
    }
}