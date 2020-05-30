namespace MedProject
{
    partial class Params
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Params));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.nameTxt = new System.Windows.Forms.TextBox();
            this.typetxt = new System.Windows.Forms.ComboBox();
            this.save = new System.Windows.Forms.Button();
            this.passwordTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cinn = new System.Windows.Forms.Label();
            this.userNameTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.editBtn = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.intervDataGrid = new System.Windows.Forms.DataGridView();
            this.panel9 = new System.Windows.Forms.Panel();
            this.intervDeleteBtn = new System.Windows.Forms.Button();
            this.intervEditBtn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.intervNameTxt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.saveInterv = new System.Windows.Forms.Button();
            this.intervCoutTxt = new System.Windows.Forms.TextBox();
            this.usersDataGrid = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.intervDataGrid)).BeginInit();
            this.panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usersDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.nameTxt);
            this.panel1.Controls.Add(this.typetxt);
            this.panel1.Controls.Add(this.save);
            this.panel1.Controls.Add(this.passwordTxt);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.cinn);
            this.panel1.Controls.Add(this.userNameTxt);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1104, 200);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(48, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 21);
            this.label2.TabIndex = 54;
            this.label2.Text = "Nom";
            // 
            // nameTxt
            // 
            this.nameTxt.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTxt.Location = new System.Drawing.Point(199, 46);
            this.nameTxt.Name = "nameTxt";
            this.nameTxt.Size = new System.Drawing.Size(188, 28);
            this.nameTxt.TabIndex = 53;
            // 
            // typetxt
            // 
            this.typetxt.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typetxt.FormattingEnabled = true;
            this.typetxt.Items.AddRange(new object[] {
            "user",
            "secretaire"});
            this.typetxt.Location = new System.Drawing.Point(521, 94);
            this.typetxt.Name = "typetxt";
            this.typetxt.Size = new System.Drawing.Size(188, 29);
            this.typetxt.TabIndex = 49;
            // 
            // save
            // 
            this.save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(214)))), ((int)(((byte)(92)))));
            this.save.FlatAppearance.BorderSize = 0;
            this.save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.save.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save.ForeColor = System.Drawing.Color.White;
            this.save.Location = new System.Drawing.Point(744, 50);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(228, 46);
            this.save.TabIndex = 23;
            this.save.Text = "Enregistrer";
            this.save.UseVisualStyleBackColor = false;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // passwordTxt
            // 
            this.passwordTxt.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTxt.Location = new System.Drawing.Point(521, 46);
            this.passwordTxt.Name = "passwordTxt";
            this.passwordTxt.Size = new System.Drawing.Size(188, 28);
            this.passwordTxt.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(393, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 21);
            this.label3.TabIndex = 21;
            this.label3.Text = "Mot de passe";
            // 
            // cinn
            // 
            this.cinn.AutoSize = true;
            this.cinn.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cinn.Location = new System.Drawing.Point(393, 102);
            this.cinn.Name = "cinn";
            this.cinn.Size = new System.Drawing.Size(47, 21);
            this.cinn.TabIndex = 17;
            this.cinn.Text = "Type";
            // 
            // userNameTxt
            // 
            this.userNameTxt.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameTxt.Location = new System.Drawing.Point(199, 94);
            this.userNameTxt.Name = "userNameTxt";
            this.userNameTxt.Size = new System.Drawing.Size(188, 28);
            this.userNameTxt.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(48, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 21);
            this.label1.TabIndex = 15;
            this.label1.Text = "Nom d\'utilisateur";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gray;
            this.panel2.Controls.Add(this.label4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1104, 38);
            this.panel2.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(26, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 21);
            this.label4.TabIndex = 24;
            this.label4.Text = "Utlisateurs";
            // 
            // deleteBtn
            // 
            this.deleteBtn.BackColor = System.Drawing.Color.White;
            this.deleteBtn.FlatAppearance.BorderSize = 0;
            this.deleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteBtn.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteBtn.ForeColor = System.Drawing.Color.White;
            this.deleteBtn.Image = ((System.Drawing.Image)(resources.GetObject("deleteBtn.Image")));
            this.deleteBtn.Location = new System.Drawing.Point(60, 10);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(29, 32);
            this.deleteBtn.TabIndex = 25;
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
            this.editBtn.Location = new System.Drawing.Point(14, 10);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(29, 32);
            this.editBtn.TabIndex = 24;
            this.editBtn.UseVisualStyleBackColor = false;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.deleteBtn);
            this.panel3.Controls.Add(this.editBtn);
            this.panel3.Location = new System.Drawing.Point(0, 148);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1104, 55);
            this.panel3.TabIndex = 26;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(26, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 21);
            this.label6.TabIndex = 24;
            this.label6.Text = "Interventions";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Navy;
            this.panel7.Controls.Add(this.label6);
            this.panel7.Location = new System.Drawing.Point(0, 339);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(1104, 38);
            this.panel7.TabIndex = 26;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.White;
            this.panel8.Controls.Add(this.intervDataGrid);
            this.panel8.Controls.Add(this.panel9);
            this.panel8.Controls.Add(this.label7);
            this.panel8.Controls.Add(this.intervNameTxt);
            this.panel8.Controls.Add(this.label8);
            this.panel8.Controls.Add(this.saveInterv);
            this.panel8.Controls.Add(this.intervCoutTxt);
            this.panel8.Location = new System.Drawing.Point(0, 377);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(1104, 261);
            this.panel8.TabIndex = 62;
            // 
            // intervDataGrid
            // 
            this.intervDataGrid.AllowUserToAddRows = false;
            this.intervDataGrid.AllowUserToDeleteRows = false;
            this.intervDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.intervDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.intervDataGrid.DefaultCellStyle = dataGridViewCellStyle1;
            this.intervDataGrid.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.intervDataGrid.Location = new System.Drawing.Point(0, 112);
            this.intervDataGrid.Name = "intervDataGrid";
            this.intervDataGrid.ReadOnly = true;
            this.intervDataGrid.RowTemplate.Height = 25;
            this.intervDataGrid.Size = new System.Drawing.Size(1104, 149);
            this.intervDataGrid.TabIndex = 29;
            this.intervDataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.asrDataGrid_CellClick);
            this.intervDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.asrDataGrid_CellClick);
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.White;
            this.panel9.Controls.Add(this.intervDeleteBtn);
            this.panel9.Controls.Add(this.intervEditBtn);
            this.panel9.Location = new System.Drawing.Point(-1, 63);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(1104, 55);
            this.panel9.TabIndex = 61;
            // 
            // intervDeleteBtn
            // 
            this.intervDeleteBtn.BackColor = System.Drawing.Color.White;
            this.intervDeleteBtn.FlatAppearance.BorderSize = 0;
            this.intervDeleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.intervDeleteBtn.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.intervDeleteBtn.ForeColor = System.Drawing.Color.White;
            this.intervDeleteBtn.Image = ((System.Drawing.Image)(resources.GetObject("intervDeleteBtn.Image")));
            this.intervDeleteBtn.Location = new System.Drawing.Point(61, 5);
            this.intervDeleteBtn.Name = "intervDeleteBtn";
            this.intervDeleteBtn.Size = new System.Drawing.Size(29, 32);
            this.intervDeleteBtn.TabIndex = 25;
            this.intervDeleteBtn.UseVisualStyleBackColor = false;
            this.intervDeleteBtn.Click += new System.EventHandler(this.intervDeleteBtn_Click);
            // 
            // intervEditBtn
            // 
            this.intervEditBtn.BackColor = System.Drawing.Color.White;
            this.intervEditBtn.FlatAppearance.BorderSize = 0;
            this.intervEditBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.intervEditBtn.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.intervEditBtn.ForeColor = System.Drawing.Color.White;
            this.intervEditBtn.Image = ((System.Drawing.Image)(resources.GetObject("intervEditBtn.Image")));
            this.intervEditBtn.Location = new System.Drawing.Point(15, 5);
            this.intervEditBtn.Name = "intervEditBtn";
            this.intervEditBtn.Size = new System.Drawing.Size(29, 32);
            this.intervEditBtn.TabIndex = 24;
            this.intervEditBtn.UseVisualStyleBackColor = false;
            this.intervEditBtn.Click += new System.EventHandler(this.intervEditBtn_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(46, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(147, 21);
            this.label7.TabIndex = 59;
            this.label7.Text = "Nom Intervention";
            // 
            // intervNameTxt
            // 
            this.intervNameTxt.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.intervNameTxt.Location = new System.Drawing.Point(197, 21);
            this.intervNameTxt.Name = "intervNameTxt";
            this.intervNameTxt.Size = new System.Drawing.Size(188, 28);
            this.intervNameTxt.TabIndex = 58;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(422, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 21);
            this.label8.TabIndex = 55;
            this.label8.Text = "Cout";
            // 
            // saveInterv
            // 
            this.saveInterv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(214)))), ((int)(((byte)(92)))));
            this.saveInterv.FlatAppearance.BorderSize = 0;
            this.saveInterv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveInterv.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveInterv.ForeColor = System.Drawing.Color.White;
            this.saveInterv.Location = new System.Drawing.Point(742, 17);
            this.saveInterv.Name = "saveInterv";
            this.saveInterv.Size = new System.Drawing.Size(228, 46);
            this.saveInterv.TabIndex = 57;
            this.saveInterv.Text = "Enregistrer";
            this.saveInterv.UseVisualStyleBackColor = false;
            this.saveInterv.Click += new System.EventHandler(this.saveInterv_Click);
            // 
            // intervCoutTxt
            // 
            this.intervCoutTxt.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.intervCoutTxt.Location = new System.Drawing.Point(519, 17);
            this.intervCoutTxt.Name = "intervCoutTxt";
            this.intervCoutTxt.Size = new System.Drawing.Size(188, 28);
            this.intervCoutTxt.TabIndex = 56;
            // 
            // usersDataGrid
            // 
            this.usersDataGrid.AllowUserToAddRows = false;
            this.usersDataGrid.AllowUserToDeleteRows = false;
            this.usersDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.usersDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.usersDataGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.usersDataGrid.Location = new System.Drawing.Point(0, 200);
            this.usersDataGrid.Name = "usersDataGrid";
            this.usersDataGrid.ReadOnly = true;
            this.usersDataGrid.RowTemplate.Height = 25;
            this.usersDataGrid.Size = new System.Drawing.Size(1104, 139);
            this.usersDataGrid.TabIndex = 23;
            this.usersDataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.usersDataGrid_CellClick);
            this.usersDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.usersDataGrid_CellClick);
            // 
            // Params
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1104, 747);
            this.ControlBox = false;
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.usersDataGrid);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Params";
            this.Text = "Params";
            this.Load += new System.EventHandler(this.Params_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.intervDataGrid)).EndInit();
            this.panel9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.usersDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.TextBox passwordTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label cinn;
        private System.Windows.Forms.TextBox userNameTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox typetxt;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button editBtn;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox nameTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.DataGridView intervDataGrid;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Button intervDeleteBtn;
        private System.Windows.Forms.Button intervEditBtn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox intervNameTxt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button saveInterv;
        private System.Windows.Forms.TextBox intervCoutTxt;
        private System.Windows.Forms.DataGridView usersDataGrid;
    }
}