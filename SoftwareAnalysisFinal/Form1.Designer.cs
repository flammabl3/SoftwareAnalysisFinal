namespace SoftwareAnalysisFinal
{
    partial class Form1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.AddEquipment = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.DeleteEquipment = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.AddClient = new System.Windows.Forms.TabPage();
            this.ACConfirm = new System.Windows.Forms.Label();
            this.ACError = new System.Windows.Forms.Label();
            this.addClientButton = new System.Windows.Forms.Button();
            this.ACLabel4 = new System.Windows.Forms.Label();
            this.ACBox4 = new System.Windows.Forms.TextBox();
            this.ACLabel3 = new System.Windows.Forms.Label();
            this.ACLabel2 = new System.Windows.Forms.Label();
            this.ACLabel1 = new System.Windows.Forms.Label();
            this.ACBox3 = new System.Windows.Forms.TextBox();
            this.ACBox2 = new System.Windows.Forms.TextBox();
            this.ACBox1 = new System.Windows.Forms.TextBox();
            this.addClientLabel = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.DisplayEquipment = new System.Windows.Forms.TabPage();
            this.btnRefreshEquipmentList = new System.Windows.Forms.Button();
            this.dataGridViewEquipment = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.DisplayAllClients = new System.Windows.Forms.TabPage();
            this.btnRefreshClientList = new System.Windows.Forms.Button();
            this.dataGridViewClients = new System.Windows.Forms.DataGridView();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.AddRentalItems = new System.Windows.Forms.TabPage();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.tabControl1.SuspendLayout();
            this.AddEquipment.SuspendLayout();
            this.panel1.SuspendLayout();
            this.DeleteEquipment.SuspendLayout();
            this.AddClient.SuspendLayout();
            this.DisplayEquipment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEquipment)).BeginInit();
            this.panel4.SuspendLayout();
            this.DisplayAllClients.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClients)).BeginInit();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.AddEquipment);
            this.tabControl1.Controls.Add(this.DeleteEquipment);
            this.tabControl1.Controls.Add(this.AddClient);
            this.tabControl1.Controls.Add(this.DisplayEquipment);
            this.tabControl1.Controls.Add(this.DisplayAllClients);
            this.tabControl1.Controls.Add(this.AddRentalItems);
            this.tabControl1.Location = new System.Drawing.Point(1, 1);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(738, 385);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // AddEquipment
            // 
            this.AddEquipment.Controls.Add(this.panel1);
            this.AddEquipment.Controls.Add(this.textBox1);
            this.AddEquipment.Location = new System.Drawing.Point(8, 27);
            this.AddEquipment.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AddEquipment.Name = "AddEquipment";
            this.AddEquipment.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AddEquipment.Size = new System.Drawing.Size(722, 350);
            this.AddEquipment.TabIndex = 2;
            this.AddEquipment.Text = "Add Equipment";
            this.AddEquipment.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(676, 40);
            this.panel1.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightBlue;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(261, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(330, 51);
            this.label1.TabIndex = 10;
            this.label1.Text = "Add Equipment";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(217, 70);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(264, 20);
            this.textBox1.TabIndex = 1;
            // 
            // DeleteEquipment
            // 
            this.DeleteEquipment.Controls.Add(this.button1);
            this.DeleteEquipment.Controls.Add(this.label4);
            this.DeleteEquipment.Controls.Add(this.richTextBox1);
            this.DeleteEquipment.Controls.Add(this.label3);
            this.DeleteEquipment.Controls.Add(this.comboBox1);
            this.DeleteEquipment.Controls.Add(this.label2);
            this.DeleteEquipment.Controls.Add(this.panel2);
            this.DeleteEquipment.Location = new System.Drawing.Point(8, 27);
            this.DeleteEquipment.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DeleteEquipment.Name = "DeleteEquipment";
            this.DeleteEquipment.Size = new System.Drawing.Size(722, 350);
            this.DeleteEquipment.TabIndex = 8;
            this.DeleteEquipment.Text = "Delete Equipment";
            this.DeleteEquipment.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(304, 209);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(78, 33);
            this.button1.TabIndex = 8;
            this.button1.Text = "Delete";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(260, 78);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Description";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(326, 78);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(258, 78);
            this.richTextBox1.TabIndex = 6;
            this.richTextBox1.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(260, 47);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Equipment";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(326, 47);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(224, 21);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LightBlue;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(272, 14);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(381, 51);
            this.label2.TabIndex = 1;
            this.label2.Text = "Delete Equipment";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightBlue;
            this.panel2.Location = new System.Drawing.Point(1, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(676, 40);
            this.panel2.TabIndex = 9;
            // 
            // AddClient
            // 
            this.AddClient.Controls.Add(this.ACConfirm);
            this.AddClient.Controls.Add(this.ACError);
            this.AddClient.Controls.Add(this.addClientButton);
            this.AddClient.Controls.Add(this.ACLabel4);
            this.AddClient.Controls.Add(this.ACBox4);
            this.AddClient.Controls.Add(this.ACLabel3);
            this.AddClient.Controls.Add(this.ACLabel2);
            this.AddClient.Controls.Add(this.ACLabel1);
            this.AddClient.Controls.Add(this.ACBox3);
            this.AddClient.Controls.Add(this.ACBox2);
            this.AddClient.Controls.Add(this.ACBox1);
            this.AddClient.Controls.Add(this.addClientLabel);
            this.AddClient.Controls.Add(this.panel3);
            this.AddClient.Location = new System.Drawing.Point(8, 27);
            this.AddClient.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AddClient.Name = "AddClient";
            this.AddClient.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AddClient.Size = new System.Drawing.Size(722, 350);
            this.AddClient.TabIndex = 3;
            this.AddClient.Text = "Add Client";
            this.AddClient.UseVisualStyleBackColor = true;
            // 
            // ACConfirm
            // 
            this.ACConfirm.AutoSize = true;
            this.ACConfirm.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.ACConfirm.Location = new System.Drawing.Point(305, 244);
            this.ACConfirm.Name = "ACConfirm";
            this.ACConfirm.Size = new System.Drawing.Size(0, 13);
            this.ACConfirm.TabIndex = 24;
            // 
            // ACError
            // 
            this.ACError.AutoSize = true;
            this.ACError.ForeColor = System.Drawing.Color.Red;
            this.ACError.Location = new System.Drawing.Point(279, 188);
            this.ACError.Name = "ACError";
            this.ACError.Size = new System.Drawing.Size(0, 13);
            this.ACError.TabIndex = 23;
            // 
            // addClientButton
            // 
            this.addClientButton.Location = new System.Drawing.Point(279, 214);
            this.addClientButton.Name = "addClientButton";
            this.addClientButton.Size = new System.Drawing.Size(75, 23);
            this.addClientButton.TabIndex = 22;
            this.addClientButton.Text = "Add Client";
            this.addClientButton.UseVisualStyleBackColor = true;
            this.addClientButton.Click += new System.EventHandler(this.addClientButton_Click);
            // 
            // ACLabel4
            // 
            this.ACLabel4.AutoSize = true;
            this.ACLabel4.Location = new System.Drawing.Point(273, 160);
            this.ACLabel4.Name = "ACLabel4";
            this.ACLabel4.Size = new System.Drawing.Size(32, 13);
            this.ACLabel4.TabIndex = 21;
            this.ACLabel4.Text = "Email";
            // 
            // ACBox4
            // 
            this.ACBox4.Location = new System.Drawing.Point(322, 157);
            this.ACBox4.Name = "ACBox4";
            this.ACBox4.Size = new System.Drawing.Size(228, 20);
            this.ACBox4.TabIndex = 20;
            // 
            // ACLabel3
            // 
            this.ACLabel3.AutoSize = true;
            this.ACLabel3.Location = new System.Drawing.Point(227, 132);
            this.ACLabel3.Name = "ACLabel3";
            this.ACLabel3.Size = new System.Drawing.Size(78, 13);
            this.ACLabel3.TabIndex = 19;
            this.ACLabel3.Text = "Phone Number";
            // 
            // ACLabel2
            // 
            this.ACLabel2.AutoSize = true;
            this.ACLabel2.Location = new System.Drawing.Point(251, 106);
            this.ACLabel2.Name = "ACLabel2";
            this.ACLabel2.Size = new System.Drawing.Size(57, 13);
            this.ACLabel2.TabIndex = 18;
            this.ACLabel2.Text = "First Name";
            // 
            // ACLabel1
            // 
            this.ACLabel1.AutoSize = true;
            this.ACLabel1.Location = new System.Drawing.Point(247, 80);
            this.ACLabel1.Name = "ACLabel1";
            this.ACLabel1.Size = new System.Drawing.Size(58, 13);
            this.ACLabel1.TabIndex = 17;
            this.ACLabel1.Text = "Last Name";
            // 
            // ACBox3
            // 
            this.ACBox3.Location = new System.Drawing.Point(322, 129);
            this.ACBox3.Name = "ACBox3";
            this.ACBox3.Size = new System.Drawing.Size(228, 20);
            this.ACBox3.TabIndex = 14;
            // 
            // ACBox2
            // 
            this.ACBox2.Location = new System.Drawing.Point(322, 103);
            this.ACBox2.Name = "ACBox2";
            this.ACBox2.Size = new System.Drawing.Size(228, 20);
            this.ACBox2.TabIndex = 13;
            // 
            // ACBox1
            // 
            this.ACBox1.Location = new System.Drawing.Point(322, 77);
            this.ACBox1.Name = "ACBox1";
            this.ACBox1.Size = new System.Drawing.Size(228, 20);
            this.ACBox1.TabIndex = 12;
            // 
            // addClientLabel
            // 
            this.addClientLabel.AutoSize = true;
            this.addClientLabel.BackColor = System.Drawing.Color.LightBlue;
            this.addClientLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addClientLabel.Location = new System.Drawing.Point(274, 17);
            this.addClientLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.addClientLabel.Name = "addClientLabel";
            this.addClientLabel.Size = new System.Drawing.Size(231, 51);
            this.addClientLabel.TabIndex = 10;
            this.addClientLabel.Text = "Add Client";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightBlue;
            this.panel3.Location = new System.Drawing.Point(3, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(676, 40);
            this.panel3.TabIndex = 11;
            // 
            // DisplayEquipment
            // 
            this.DisplayEquipment.Controls.Add(this.btnRefreshEquipmentList);
            this.DisplayEquipment.Controls.Add(this.dataGridViewEquipment);
            this.DisplayEquipment.Controls.Add(this.panel4);
            this.DisplayEquipment.Location = new System.Drawing.Point(8, 27);
            this.DisplayEquipment.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DisplayEquipment.Name = "DisplayEquipment";
            this.DisplayEquipment.Size = new System.Drawing.Size(722, 350);
            this.DisplayEquipment.TabIndex = 5;
            this.DisplayEquipment.Text = "Display Equipment";
            this.DisplayEquipment.UseVisualStyleBackColor = true;
            // 
            // btnRefreshEquipmentList
            // 
            this.btnRefreshEquipmentList.Location = new System.Drawing.Point(267, 257);
            this.btnRefreshEquipmentList.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRefreshEquipmentList.Name = "btnRefreshEquipmentList";
            this.btnRefreshEquipmentList.Size = new System.Drawing.Size(145, 24);
            this.btnRefreshEquipmentList.TabIndex = 14;
            this.btnRefreshEquipmentList.Text = "Refresh Equipment List";
            this.btnRefreshEquipmentList.UseVisualStyleBackColor = true;
            // 
            // dataGridViewEquipment
            // 
            this.dataGridViewEquipment.AllowUserToAddRows = false;
            this.dataGridViewEquipment.AllowUserToDeleteRows = false;
            this.dataGridViewEquipment.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewEquipment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEquipment.Location = new System.Drawing.Point(109, 49);
            this.dataGridViewEquipment.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridViewEquipment.Name = "dataGridViewEquipment";
            this.dataGridViewEquipment.ReadOnly = true;
            this.dataGridViewEquipment.RowHeadersWidth = 62;
            this.dataGridViewEquipment.RowTemplate.Height = 28;
            this.dataGridViewEquipment.Size = new System.Drawing.Size(493, 179);
            this.dataGridViewEquipment.TabIndex = 13;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.LightBlue;
            this.panel4.Controls.Add(this.label5);
            this.panel4.Location = new System.Drawing.Point(4, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(676, 40);
            this.panel4.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.LightBlue;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(215, 6);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(400, 51);
            this.label5.TabIndex = 11;
            this.label5.Text = "Display Equipment";
            // 
            // DisplayAllClients
            // 
            this.DisplayAllClients.Controls.Add(this.btnRefreshClientList);
            this.DisplayAllClients.Controls.Add(this.dataGridViewClients);
            this.DisplayAllClients.Controls.Add(this.panel5);
            this.DisplayAllClients.Location = new System.Drawing.Point(8, 27);
            this.DisplayAllClients.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DisplayAllClients.Name = "DisplayAllClients";
            this.DisplayAllClients.Size = new System.Drawing.Size(722, 350);
            this.DisplayAllClients.TabIndex = 6;
            this.DisplayAllClients.Text = "Display All Clients";
            this.DisplayAllClients.UseVisualStyleBackColor = true;
            // 
            // btnRefreshClientList
            // 
            this.btnRefreshClientList.Location = new System.Drawing.Point(280, 239);
            this.btnRefreshClientList.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRefreshClientList.Name = "btnRefreshClientList";
            this.btnRefreshClientList.Size = new System.Drawing.Size(104, 38);
            this.btnRefreshClientList.TabIndex = 15;
            this.btnRefreshClientList.Text = "Refresh Client List";
            this.btnRefreshClientList.UseVisualStyleBackColor = true;
            // 
            // dataGridViewClients
            // 
            this.dataGridViewClients.AllowUserToAddRows = false;
            this.dataGridViewClients.AllowUserToDeleteRows = false;
            this.dataGridViewClients.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewClients.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewClients.Location = new System.Drawing.Point(127, 49);
            this.dataGridViewClients.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridViewClients.Name = "dataGridViewClients";
            this.dataGridViewClients.ReadOnly = true;
            this.dataGridViewClients.RowHeadersWidth = 62;
            this.dataGridViewClients.RowTemplate.Height = 28;
            this.dataGridViewClients.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewClients.Size = new System.Drawing.Size(429, 187);
            this.dataGridViewClients.TabIndex = 14;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.LightBlue;
            this.panel5.Controls.Add(this.label6);
            this.panel5.Location = new System.Drawing.Point(4, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(676, 40);
            this.panel5.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.LightBlue;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(220, 6);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(388, 51);
            this.label6.TabIndex = 11;
            this.label6.Text = "Display All Clients";
            // 
            // AddRentalItems
            // 
            this.AddRentalItems.Location = new System.Drawing.Point(8, 27);
            this.AddRentalItems.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AddRentalItems.Name = "AddRentalItems";
            this.AddRentalItems.Size = new System.Drawing.Size(722, 350);
            this.AddRentalItems.TabIndex = 7;
            this.AddRentalItems.Text = "Add Rental Items";
            this.AddRentalItems.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 340);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.AddEquipment.ResumeLayout(false);
            this.AddEquipment.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.DeleteEquipment.ResumeLayout(false);
            this.DeleteEquipment.PerformLayout();
            this.AddClient.ResumeLayout(false);
            this.AddClient.PerformLayout();
            this.DisplayEquipment.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEquipment)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.DisplayAllClients.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClients)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage AddEquipment;
        private System.Windows.Forms.TabPage AddClient;
        private System.Windows.Forms.TabPage DisplayEquipment;
        private System.Windows.Forms.TabPage DisplayAllClients;
        private System.Windows.Forms.TabPage AddRentalItems;
        private System.Windows.Forms.TabPage DeleteEquipment;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label addClientLabel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox ACBox3;
        private System.Windows.Forms.TextBox ACBox2;
        private System.Windows.Forms.TextBox ACBox1;
        private System.Windows.Forms.Label ACLabel4;
        private System.Windows.Forms.TextBox ACBox4;
        private System.Windows.Forms.Label ACLabel3;
        private System.Windows.Forms.Label ACLabel2;
        private System.Windows.Forms.Label ACLabel1;
        private System.Windows.Forms.Button addClientButton;
        private System.Windows.Forms.Label ACError;
        private System.Windows.Forms.Label ACConfirm;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnRefreshClientList;
        private System.Windows.Forms.DataGridView dataGridViewClients;
        private System.Windows.Forms.DataGridView dataGridViewEquipment;
        private System.Windows.Forms.Button btnRefreshEquipmentList;
    }
}

