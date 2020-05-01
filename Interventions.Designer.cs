namespace MedProject
{
    partial class Interventions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Interventions));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.patientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.medicalDataSet = new MedProject.medicalDataSet();
            this.label5 = new System.Windows.Forms.Label();
            this.save = new System.Windows.Forms.Button();
            this.patientTableAdapter = new MedProject.medicalDataSetTableAdapters.PatientTableAdapter();
            this.assuranceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.medicalDataSet1 = new MedProject.medicalDataSet1();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.medicalDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel4 = new System.Windows.Forms.Panel();
            this.patientCount = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.assuranceTableAdapter = new MedProject.medicalDataSet1TableAdapters.AssuranceTableAdapter();
            this.editBtn = new System.Windows.Forms.Button();
            this.medicalDataSet2 = new MedProject.medicalDataSet();
            this.meetingDetailGrid = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.remarqueTxt = new System.Windows.Forms.TextBox();
            this.coutTxt = new System.Windows.Forms.TextBox();
            this.intervCombo = new System.Windows.Forms.ComboBox();
            this.interventionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.medicalDataSet9 = new MedProject.medicalDataSet9();
            this.co = new System.Windows.Forms.Label();
            this.interventionTxt = new System.Windows.Forms.Label();
            this.dentCombo = new System.Windows.Forms.ComboBox();
            this.partieCombo = new System.Windows.Forms.ComboBox();
            this.patientCombo = new System.Windows.Forms.ComboBox();
            this.agee = new System.Windows.Forms.Label();
            this.partieeee = new System.Windows.Forms.Label();
            this.patientTxt = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.medicalDataSet3 = new MedProject.medicalDataSet3();
            this.meetingDetailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.meetingDetailTableAdapter = new MedProject.medicalDataSet3TableAdapters.MeetingDetailTableAdapter();
            this.medicalDataSet4 = new MedProject.medicalDataSet4();
            this.medicalDataSet4BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.medicalDataSet5 = new MedProject.medicalDataSet5();
            this.patientMeetingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.patientMeetingTableAdapter = new MedProject.medicalDataSet5TableAdapters.patientMeetingTableAdapter();
            this.medicalDataSet7 = new MedProject.medicalDataSet7();
            this.medicalDataSet7BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.interventionTableAdapter = new MedProject.medicalDataSet9TableAdapters.InterventionTableAdapter();
            this.medicalDataSet10 = new MedProject.medicalDataSet10();
            this.interventionBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.interventionTableAdapter1 = new MedProject.medicalDataSet10TableAdapters.InterventionTableAdapter();
            this.info = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicalDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assuranceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicalDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicalDataSetBindingSource)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.medicalDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.meetingDetailGrid)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.interventionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicalDataSet9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicalDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.meetingDetailBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicalDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicalDataSet4BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicalDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientMeetingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicalDataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicalDataSet7BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicalDataSet10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.interventionBindingSource1)).BeginInit();
            this.SuspendLayout();
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(687, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 21);
            this.label5.TabIndex = 18;
            this.label5.Text = "Remarque";
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
            // patientTableAdapter
            // 
            this.patientTableAdapter.ClearBeforeFill = true;
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
            this.deleteBtn.TabIndex = 26;
            this.deleteBtn.UseVisualStyleBackColor = false;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // medicalDataSetBindingSource
            // 
            this.medicalDataSetBindingSource.DataSource = this.medicalDataSet;
            this.medicalDataSetBindingSource.Position = 0;
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
            // assuranceTableAdapter
            // 
            this.assuranceTableAdapter.ClearBeforeFill = true;
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
            this.editBtn.TabIndex = 25;
            this.editBtn.UseVisualStyleBackColor = false;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // medicalDataSet2
            // 
            this.medicalDataSet2.DataSetName = "medicalDataSet";
            this.medicalDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // meetingDetailGrid
            // 
            this.meetingDetailGrid.AllowUserToAddRows = false;
            this.meetingDetailGrid.AllowUserToDeleteRows = false;
            this.meetingDetailGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.meetingDetailGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.meetingDetailGrid.DefaultCellStyle = dataGridViewCellStyle1;
            this.meetingDetailGrid.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.meetingDetailGrid.Location = new System.Drawing.Point(0, 226);
            this.meetingDetailGrid.Name = "meetingDetailGrid";
            this.meetingDetailGrid.ReadOnly = true;
            this.meetingDetailGrid.RowTemplate.Height = 25;
            this.meetingDetailGrid.Size = new System.Drawing.Size(1104, 374);
            this.meetingDetailGrid.TabIndex = 24;
            this.meetingDetailGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.meetingDetailGrid_CellClick);
            this.meetingDetailGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.meetingDetailGrid_CellClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.info);
            this.panel1.Controls.Add(this.remarqueTxt);
            this.panel1.Controls.Add(this.coutTxt);
            this.panel1.Controls.Add(this.intervCombo);
            this.panel1.Controls.Add(this.co);
            this.panel1.Controls.Add(this.interventionTxt);
            this.panel1.Controls.Add(this.dentCombo);
            this.panel1.Controls.Add(this.partieCombo);
            this.panel1.Controls.Add(this.patientCombo);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.save);
            this.panel1.Controls.Add(this.agee);
            this.panel1.Controls.Add(this.partieeee);
            this.panel1.Controls.Add(this.patientTxt);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1104, 176);
            this.panel1.TabIndex = 23;
            // 
            // remarqueTxt
            // 
            this.remarqueTxt.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.remarqueTxt.Location = new System.Drawing.Point(691, 35);
            this.remarqueTxt.Multiline = true;
            this.remarqueTxt.Name = "remarqueTxt";
            this.remarqueTxt.Size = new System.Drawing.Size(188, 58);
            this.remarqueTxt.TabIndex = 40;
            // 
            // coutTxt
            // 
            this.coutTxt.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coutTxt.Location = new System.Drawing.Point(461, 113);
            this.coutTxt.Name = "coutTxt";
            this.coutTxt.Size = new System.Drawing.Size(55, 28);
            this.coutTxt.TabIndex = 39;
            // 
            // intervCombo
            // 
            this.intervCombo.DataSource = this.interventionBindingSource1;
            this.intervCombo.DisplayMember = "name";
            this.intervCombo.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.intervCombo.FormattingEnabled = true;
            this.intervCombo.Location = new System.Drawing.Point(461, 56);
            this.intervCombo.Name = "intervCombo";
            this.intervCombo.Size = new System.Drawing.Size(189, 29);
            this.intervCombo.TabIndex = 38;
            this.intervCombo.ValueMember = "id";
            this.intervCombo.SelectedIndexChanged += new System.EventHandler(this.comboBox4_SelectedIndexChanged);
            // 
            // interventionBindingSource
            // 
            this.interventionBindingSource.DataMember = "Intervention";
            this.interventionBindingSource.DataSource = this.medicalDataSet9;
            // 
            // medicalDataSet9
            // 
            this.medicalDataSet9.DataSetName = "medicalDataSet9";
            this.medicalDataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // co
            // 
            this.co.AutoSize = true;
            this.co.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.co.Location = new System.Drawing.Point(351, 113);
            this.co.Name = "co";
            this.co.Size = new System.Drawing.Size(46, 21);
            this.co.TabIndex = 37;
            this.co.Text = "Cout";
            // 
            // interventionTxt
            // 
            this.interventionTxt.AutoSize = true;
            this.interventionTxt.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.interventionTxt.Location = new System.Drawing.Point(351, 59);
            this.interventionTxt.Name = "interventionTxt";
            this.interventionTxt.Size = new System.Drawing.Size(105, 21);
            this.interventionTxt.TabIndex = 36;
            this.interventionTxt.Text = "Intervention";
            // 
            // dentCombo
            // 
            this.dentCombo.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dentCombo.FormattingEnabled = true;
            this.dentCombo.Location = new System.Drawing.Point(132, 110);
            this.dentCombo.Name = "dentCombo";
            this.dentCombo.Size = new System.Drawing.Size(189, 29);
            this.dentCombo.TabIndex = 35;
            // 
            // partieCombo
            // 
            this.partieCombo.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.partieCombo.FormattingEnabled = true;
            this.partieCombo.Items.AddRange(new object[] {
            "Supérieur à droite",
            "Supérieur à gauche",
            "Inférieur à droite",
            "Inférieur à droite"});
            this.partieCombo.Location = new System.Drawing.Point(132, 56);
            this.partieCombo.Name = "partieCombo";
            this.partieCombo.Size = new System.Drawing.Size(189, 29);
            this.partieCombo.TabIndex = 34;
            this.partieCombo.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // patientCombo
            // 
            this.patientCombo.DataSource = this.patientBindingSource;
            this.patientCombo.DisplayMember = "name";
            this.patientCombo.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientCombo.FormattingEnabled = true;
            this.patientCombo.Location = new System.Drawing.Point(132, 8);
            this.patientCombo.Name = "patientCombo";
            this.patientCombo.Size = new System.Drawing.Size(479, 29);
            this.patientCombo.TabIndex = 32;
            this.patientCombo.ValueMember = "id";
            this.patientCombo.SelectedIndexChanged += new System.EventHandler(this.patientCombo_SelectedIndexChanged);
            // 
            // agee
            // 
            this.agee.AutoSize = true;
            this.agee.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agee.Location = new System.Drawing.Point(11, 105);
            this.agee.Name = "agee";
            this.agee.Size = new System.Drawing.Size(54, 21);
            this.agee.TabIndex = 8;
            this.agee.Text = "Dents";
            // 
            // partieeee
            // 
            this.partieeee.AutoSize = true;
            this.partieeee.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.partieeee.Location = new System.Drawing.Point(11, 59);
            this.partieeee.Name = "partieeee";
            this.partieeee.Size = new System.Drawing.Size(55, 21);
            this.partieeee.TabIndex = 4;
            this.partieeee.Text = "Partie";
            // 
            // patientTxt
            // 
            this.patientTxt.AutoSize = true;
            this.patientTxt.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientTxt.Location = new System.Drawing.Point(10, 18);
            this.patientTxt.Name = "patientTxt";
            this.patientTxt.Size = new System.Drawing.Size(65, 21);
            this.patientTxt.TabIndex = 0;
            this.patientTxt.Text = "Patient";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(43)))), ((int)(((byte)(67)))));
            this.panel2.Location = new System.Drawing.Point(0, 176);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1104, 55);
            this.panel2.TabIndex = 27;
            // 
            // medicalDataSet3
            // 
            this.medicalDataSet3.DataSetName = "medicalDataSet3";
            this.medicalDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // meetingDetailBindingSource
            // 
            this.meetingDetailBindingSource.DataMember = "MeetingDetail";
            this.meetingDetailBindingSource.DataSource = this.medicalDataSet3;
            // 
            // meetingDetailTableAdapter
            // 
            this.meetingDetailTableAdapter.ClearBeforeFill = true;
            // 
            // medicalDataSet4
            // 
            this.medicalDataSet4.DataSetName = "medicalDataSet4";
            this.medicalDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // medicalDataSet4BindingSource
            // 
            this.medicalDataSet4BindingSource.DataSource = this.medicalDataSet4;
            this.medicalDataSet4BindingSource.Position = 0;
            // 
            // medicalDataSet5
            // 
            this.medicalDataSet5.DataSetName = "medicalDataSet5";
            this.medicalDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // patientMeetingBindingSource
            // 
            this.patientMeetingBindingSource.DataMember = "patientMeeting";
            this.patientMeetingBindingSource.DataSource = this.medicalDataSet5;
            // 
            // patientMeetingTableAdapter
            // 
            this.patientMeetingTableAdapter.ClearBeforeFill = true;
            // 
            // medicalDataSet7
            // 
            this.medicalDataSet7.DataSetName = "medicalDataSet7";
            this.medicalDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // medicalDataSet7BindingSource
            // 
            this.medicalDataSet7BindingSource.DataSource = this.medicalDataSet7;
            this.medicalDataSet7BindingSource.Position = 0;
            // 
            // interventionTableAdapter
            // 
            this.interventionTableAdapter.ClearBeforeFill = true;
            // 
            // medicalDataSet10
            // 
            this.medicalDataSet10.DataSetName = "medicalDataSet10";
            this.medicalDataSet10.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // interventionBindingSource1
            // 
            this.interventionBindingSource1.DataMember = "Intervention";
            this.interventionBindingSource1.DataSource = this.medicalDataSet10;
            // 
            // interventionTableAdapter1
            // 
            this.interventionTableAdapter1.ClearBeforeFill = true;
            // 
            // info
            // 
            this.info.BackColor = System.Drawing.Color.White;
            this.info.FlatAppearance.BorderSize = 0;
            this.info.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.info.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.info.ForeColor = System.Drawing.Color.White;
            this.info.Image = ((System.Drawing.Image)(resources.GetObject("info.Image")));
            this.info.Location = new System.Drawing.Point(614, 5);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(29, 32);
            this.info.TabIndex = 28;
            this.info.UseVisualStyleBackColor = false;
            this.info.Click += new System.EventHandler(this.info_Click);
            // 
            // Interventions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 600);
            this.ControlBox = false;
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.editBtn);
            this.Controls.Add(this.meetingDetailGrid);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Interventions";
            this.Text = "Interventions";
            this.Load += new System.EventHandler(this.Interventions_Load);
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicalDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assuranceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicalDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicalDataSetBindingSource)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.medicalDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.meetingDetailGrid)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.interventionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicalDataSet9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicalDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.meetingDetailBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicalDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicalDataSet4BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicalDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientMeetingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicalDataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicalDataSet7BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicalDataSet10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.interventionBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource patientBindingSource;
        private medicalDataSet medicalDataSet;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button save;
        private medicalDataSetTableAdapters.PatientTableAdapter patientTableAdapter;
        private System.Windows.Forms.BindingSource assuranceBindingSource;
        private medicalDataSet1 medicalDataSet1;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.BindingSource medicalDataSetBindingSource;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label patientCount;
        private System.Windows.Forms.Button button2;
        private medicalDataSet1TableAdapters.AssuranceTableAdapter assuranceTableAdapter;
        private System.Windows.Forms.Button editBtn;
        private medicalDataSet medicalDataSet2;
        private System.Windows.Forms.DataGridView meetingDetailGrid;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox intervCombo;
        private System.Windows.Forms.Label co;
        private System.Windows.Forms.Label interventionTxt;
        private System.Windows.Forms.ComboBox dentCombo;
        private System.Windows.Forms.ComboBox partieCombo;
        private System.Windows.Forms.ComboBox patientCombo;
        private System.Windows.Forms.Label agee;
        private System.Windows.Forms.Label partieeee;
        private System.Windows.Forms.Label patientTxt;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox coutTxt;
        private System.Windows.Forms.TextBox remarqueTxt;
        private medicalDataSet3 medicalDataSet3;
        private System.Windows.Forms.BindingSource meetingDetailBindingSource;
        private medicalDataSet3TableAdapters.MeetingDetailTableAdapter meetingDetailTableAdapter;
        private medicalDataSet4 medicalDataSet4;
        private System.Windows.Forms.BindingSource medicalDataSet4BindingSource;
        private medicalDataSet5 medicalDataSet5;
        private System.Windows.Forms.BindingSource patientMeetingBindingSource;
        private medicalDataSet5TableAdapters.patientMeetingTableAdapter patientMeetingTableAdapter;
        private System.Windows.Forms.BindingSource medicalDataSet7BindingSource;
        private medicalDataSet7 medicalDataSet7;
        private medicalDataSet9 medicalDataSet9;
        private System.Windows.Forms.BindingSource interventionBindingSource;
        private medicalDataSet9TableAdapters.InterventionTableAdapter interventionTableAdapter;
        private medicalDataSet10 medicalDataSet10;
        private System.Windows.Forms.BindingSource interventionBindingSource1;
        private medicalDataSet10TableAdapters.InterventionTableAdapter interventionTableAdapter1;
        private System.Windows.Forms.Button info;
    }
}