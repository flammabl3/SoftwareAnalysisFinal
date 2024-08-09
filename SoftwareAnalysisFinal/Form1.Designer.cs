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
            this.label8 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.DeleteEquipment = new System.Windows.Forms.TabPage();
            this.deleteEquipmentbutton1 = new System.Windows.Forms.Button();
            this.deleteEquipmentlabel4 = new System.Windows.Forms.Label();
            this.deleteEquipmentRichTextBox1 = new System.Windows.Forms.RichTextBox();
            this.deleteEquipmentlabel3 = new System.Windows.Forms.Label();
            this.deleteEquipmentComboBox1 = new System.Windows.Forms.ComboBox();
            this.deleteEquipmentlabel2 = new System.Windows.Forms.Label();
            this.deleteEquipmentpanel2 = new System.Windows.Forms.Panel();
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
            this.addClientpanel3 = new System.Windows.Forms.Panel();
            this.DisplayEquipment = new System.Windows.Forms.TabPage();
            this.btnRefreshEquipmentList = new System.Windows.Forms.Button();
            this.dataGridViewEquipment = new System.Windows.Forms.DataGridView();
            this.DEpanel4 = new System.Windows.Forms.Panel();
            this.DElabel5 = new System.Windows.Forms.Label();
            this.DisplayAllClients = new System.Windows.Forms.TabPage();
            this.btnRefreshClientList = new System.Windows.Forms.Button();
            this.dataGridViewClients = new System.Windows.Forms.DataGridView();
            this.DACpanel5 = new System.Windows.Forms.Panel();
            this.DAClabel6 = new System.Windows.Forms.Label();
            this.AddRentalItems = new System.Windows.Forms.TabPage();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button3 = new System.Windows.Forms.Button();
            this.richTextBox4 = new System.Windows.Forms.RichTextBox();
            this.richTextBox3 = new System.Windows.Forms.RichTextBox();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label13 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label14 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.DeleteEquipment.SuspendLayout();
            this.AddClient.SuspendLayout();
            this.DisplayEquipment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEquipment)).BeginInit();
            this.DEpanel4.SuspendLayout();
            this.DisplayAllClients.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClients)).BeginInit();
            this.DACpanel5.SuspendLayout();
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
            this.tabControl1.Location = new System.Drawing.Point(2, 2);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1476, 740);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // AddEquipment
            // 
            this.AddEquipment.Controls.Add(this.label8);
            this.AddEquipment.Controls.Add(this.comboBox3);
            this.AddEquipment.Controls.Add(this.label7);
            this.AddEquipment.Controls.Add(this.label6);
            this.AddEquipment.Controls.Add(this.richTextBox2);
            this.AddEquipment.Controls.Add(this.label5);
            this.AddEquipment.Controls.Add(this.comboBox2);
            this.AddEquipment.Controls.Add(this.button2);
            this.AddEquipment.Controls.Add(this.panel1);
            this.AddEquipment.Controls.Add(this.textBox1);
            this.AddEquipment.Location = new System.Drawing.Point(4, 29);
            this.AddEquipment.Name = "AddEquipment";
            this.AddEquipment.Padding = new System.Windows.Forms.Padding(3);
            this.AddEquipment.Size = new System.Drawing.Size(1099, 559);
            this.AddEquipment.TabIndex = 2;
            this.AddEquipment.Text = "Add Equipment";
            this.AddEquipment.UseVisualStyleBackColor = true;
            this.AddEquipment.Click += new System.EventHandler(this.AddEquipment_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(257, 203);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 20);
            this.label8.TabIndex = 19;
            this.label8.Text = "Price";
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(500, 203);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(256, 28);
            this.comboBox3.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(257, 271);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 20);
            this.label7.TabIndex = 17;
            this.label7.Text = "Description";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(257, 91);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 20);
            this.label6.TabIndex = 16;
            this.label6.Text = "Eqipment name";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(500, 268);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(256, 96);
            this.richTextBox2.TabIndex = 15;
            this.richTextBox2.Text = "";
            this.richTextBox2.TextChanged += new System.EventHandler(this.richTextBox2_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(257, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "Category ID";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(500, 145);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(256, 28);
            this.comboBox2.TabIndex = 13;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(376, 431);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(252, 32);
            this.button2.TabIndex = 12;
            this.button2.Text = "Add Equipment";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1014, 62);
            this.panel1.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(392, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 37);
            this.label1.TabIndex = 10;
            this.label1.Text = "Add Equipment";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(500, 85);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(394, 26);
            this.textBox1.TabIndex = 1;
            // 
            // DeleteEquipment
            // 
            this.DeleteEquipment.Controls.Add(this.deleteEquipmentbutton1);
            this.DeleteEquipment.Controls.Add(this.deleteEquipmentlabel4);
            this.DeleteEquipment.Controls.Add(this.deleteEquipmentRichTextBox1);
            this.DeleteEquipment.Controls.Add(this.deleteEquipmentlabel3);
            this.DeleteEquipment.Controls.Add(this.deleteEquipmentComboBox1);
            this.DeleteEquipment.Controls.Add(this.deleteEquipmentlabel2);
            this.DeleteEquipment.Controls.Add(this.deleteEquipmentpanel2);
            this.DeleteEquipment.Location = new System.Drawing.Point(8, 39);
            this.DeleteEquipment.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DeleteEquipment.Name = "DeleteEquipment";
            this.DeleteEquipment.Size = new System.Drawing.Size(1460, 693);
            this.DeleteEquipment.TabIndex = 8;
            this.DeleteEquipment.Text = "Delete Equipment";
            this.DeleteEquipment.UseVisualStyleBackColor = true;
            // 
            // deleteEquipmentbutton1
            // 
            this.deleteEquipmentbutton1.Location = new System.Drawing.Point(608, 402);
            this.deleteEquipmentbutton1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.deleteEquipmentbutton1.Name = "deleteEquipmentbutton1";
            this.deleteEquipmentbutton1.Size = new System.Drawing.Size(156, 63);
            this.deleteEquipmentbutton1.TabIndex = 8;
            this.deleteEquipmentbutton1.Text = "Delete";
            this.deleteEquipmentbutton1.UseVisualStyleBackColor = true;
            this.deleteEquipmentbutton1.Click += new System.EventHandler(this.button1_Click);
            // 
            // deleteEquipmentlabel4
            // 
            this.deleteEquipmentlabel4.AutoSize = true;
            this.deleteEquipmentlabel4.Location = new System.Drawing.Point(520, 150);
            this.deleteEquipmentlabel4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.deleteEquipmentlabel4.Name = "deleteEquipmentlabel4";
            this.deleteEquipmentlabel4.Size = new System.Drawing.Size(120, 25);
            this.deleteEquipmentlabel4.TabIndex = 7;
            this.deleteEquipmentlabel4.Text = "Description";
            // 
            // deleteEquipmentRichTextBox1
            // 
            this.deleteEquipmentRichTextBox1.Location = new System.Drawing.Point(652, 150);
            this.deleteEquipmentRichTextBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.deleteEquipmentRichTextBox1.Name = "deleteEquipmentRichTextBox1";
            this.deleteEquipmentRichTextBox1.Size = new System.Drawing.Size(512, 146);
            this.deleteEquipmentRichTextBox1.TabIndex = 6;
            this.deleteEquipmentRichTextBox1.Text = "";
            // 
            // deleteEquipmentlabel3
            // 
            this.deleteEquipmentlabel3.AutoSize = true;
            this.deleteEquipmentlabel3.Location = new System.Drawing.Point(520, 90);
            this.deleteEquipmentlabel3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.deleteEquipmentlabel3.Name = "deleteEquipmentlabel3";
            this.deleteEquipmentlabel3.Size = new System.Drawing.Size(114, 25);
            this.deleteEquipmentlabel3.TabIndex = 5;
            this.deleteEquipmentlabel3.Text = "Equipment";
            // 
            // deleteEquipmentComboBox1
            // 
            this.deleteEquipmentComboBox1.FormattingEnabled = true;
            this.deleteEquipmentComboBox1.Location = new System.Drawing.Point(652, 90);
            this.deleteEquipmentComboBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.deleteEquipmentComboBox1.Name = "deleteEquipmentComboBox1";
            this.deleteEquipmentComboBox1.Size = new System.Drawing.Size(444, 33);
            this.deleteEquipmentComboBox1.TabIndex = 2;
            this.deleteEquipmentComboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // deleteEquipmentlabel2
            // 
            this.deleteEquipmentlabel2.AutoSize = true;
            this.deleteEquipmentlabel2.BackColor = System.Drawing.Color.LightBlue;
            this.deleteEquipmentlabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteEquipmentlabel2.Location = new System.Drawing.Point(544, 27);
            this.deleteEquipmentlabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.deleteEquipmentlabel2.Name = "deleteEquipmentlabel2";
            this.deleteEquipmentlabel2.Size = new System.Drawing.Size(381, 51);
            this.deleteEquipmentlabel2.TabIndex = 1;
            this.deleteEquipmentlabel2.Text = "Delete Equipment";
            // 
            // deleteEquipmentpanel2
            // 
            this.deleteEquipmentpanel2.BackColor = System.Drawing.Color.LightBlue;
            this.deleteEquipmentpanel2.Location = new System.Drawing.Point(2, 4);
            this.deleteEquipmentpanel2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.deleteEquipmentpanel2.Name = "deleteEquipmentpanel2";
            this.deleteEquipmentpanel2.Size = new System.Drawing.Size(1352, 77);
            this.deleteEquipmentpanel2.TabIndex = 9;
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
            this.AddClient.Controls.Add(this.addClientpanel3);
            this.AddClient.Location = new System.Drawing.Point(8, 39);
            this.AddClient.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AddClient.Name = "AddClient";
            this.AddClient.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AddClient.Size = new System.Drawing.Size(1460, 693);
            this.AddClient.TabIndex = 3;
            this.AddClient.Text = "Add Client";
            this.AddClient.UseVisualStyleBackColor = true;
            // 
            // ACConfirm
            // 
            this.ACConfirm.AutoSize = true;
            this.ACConfirm.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.ACConfirm.Location = new System.Drawing.Point(610, 469);
            this.ACConfirm.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.ACConfirm.Name = "ACConfirm";
            this.ACConfirm.Size = new System.Drawing.Size(0, 25);
            this.ACConfirm.TabIndex = 24;
            // 
            // ACError
            // 
            this.ACError.AutoSize = true;
            this.ACError.ForeColor = System.Drawing.Color.Red;
            this.ACError.Location = new System.Drawing.Point(558, 362);
            this.ACError.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.ACError.Name = "ACError";
            this.ACError.Size = new System.Drawing.Size(0, 25);
            this.ACError.TabIndex = 23;
            // 
            // addClientButton
            // 
            this.addClientButton.Location = new System.Drawing.Point(558, 412);
            this.addClientButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.addClientButton.Name = "addClientButton";
            this.addClientButton.Size = new System.Drawing.Size(150, 44);
            this.addClientButton.TabIndex = 22;
            this.addClientButton.Text = "Add Client";
            this.addClientButton.UseVisualStyleBackColor = true;
            this.addClientButton.Click += new System.EventHandler(this.addClientButton_Click);
            // 
            // ACLabel4
            // 
            this.ACLabel4.AutoSize = true;
            this.ACLabel4.Location = new System.Drawing.Point(546, 308);
            this.ACLabel4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.ACLabel4.Name = "ACLabel4";
            this.ACLabel4.Size = new System.Drawing.Size(65, 25);
            this.ACLabel4.TabIndex = 21;
            this.ACLabel4.Text = "Email";
            // 
            // ACBox4
            // 
            this.ACBox4.Location = new System.Drawing.Point(644, 302);
            this.ACBox4.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.ACBox4.Name = "ACBox4";
            this.ACBox4.Size = new System.Drawing.Size(452, 31);
            this.ACBox4.TabIndex = 20;
            // 
            // ACLabel3
            // 
            this.ACLabel3.AutoSize = true;
            this.ACLabel3.Location = new System.Drawing.Point(454, 254);
            this.ACLabel3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.ACLabel3.Name = "ACLabel3";
            this.ACLabel3.Size = new System.Drawing.Size(155, 25);
            this.ACLabel3.TabIndex = 19;
            this.ACLabel3.Text = "Phone Number";
            // 
            // ACLabel2
            // 
            this.ACLabel2.AutoSize = true;
            this.ACLabel2.Location = new System.Drawing.Point(502, 204);
            this.ACLabel2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.ACLabel2.Name = "ACLabel2";
            this.ACLabel2.Size = new System.Drawing.Size(116, 25);
            this.ACLabel2.TabIndex = 18;
            this.ACLabel2.Text = "First Name";
            // 
            // ACLabel1
            // 
            this.ACLabel1.AutoSize = true;
            this.ACLabel1.Location = new System.Drawing.Point(494, 154);
            this.ACLabel1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.ACLabel1.Name = "ACLabel1";
            this.ACLabel1.Size = new System.Drawing.Size(115, 25);
            this.ACLabel1.TabIndex = 17;
            this.ACLabel1.Text = "Last Name";
            // 
            // ACBox3
            // 
            this.ACBox3.Location = new System.Drawing.Point(644, 248);
            this.ACBox3.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.ACBox3.Name = "ACBox3";
            this.ACBox3.Size = new System.Drawing.Size(452, 31);
            this.ACBox3.TabIndex = 14;
            // 
            // ACBox2
            // 
            this.ACBox2.Location = new System.Drawing.Point(644, 198);
            this.ACBox2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.ACBox2.Name = "ACBox2";
            this.ACBox2.Size = new System.Drawing.Size(452, 31);
            this.ACBox2.TabIndex = 13;
            // 
            // ACBox1
            // 
            this.ACBox1.Location = new System.Drawing.Point(644, 148);
            this.ACBox1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.ACBox1.Name = "ACBox1";
            this.ACBox1.Size = new System.Drawing.Size(452, 31);
            this.ACBox1.TabIndex = 12;
            // 
            // addClientLabel
            // 
            this.addClientLabel.AutoSize = true;
            this.addClientLabel.BackColor = System.Drawing.Color.LightBlue;
            this.addClientLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addClientLabel.Location = new System.Drawing.Point(548, 33);
            this.addClientLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.addClientLabel.Name = "addClientLabel";
            this.addClientLabel.Size = new System.Drawing.Size(231, 51);
            this.addClientLabel.TabIndex = 10;
            this.addClientLabel.Text = "Add Client";
            // 
            // addClientpanel3
            // 
            this.addClientpanel3.BackColor = System.Drawing.Color.LightBlue;
            this.addClientpanel3.Location = new System.Drawing.Point(6, 10);
            this.addClientpanel3.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.addClientpanel3.Name = "addClientpanel3";
            this.addClientpanel3.Size = new System.Drawing.Size(1352, 77);
            this.addClientpanel3.TabIndex = 11;
            // 
            // DisplayEquipment
            // 
            this.DisplayEquipment.Controls.Add(this.btnRefreshEquipmentList);
            this.DisplayEquipment.Controls.Add(this.dataGridViewEquipment);
            this.DisplayEquipment.Controls.Add(this.DEpanel4);
            this.DisplayEquipment.Location = new System.Drawing.Point(8, 39);
            this.DisplayEquipment.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DisplayEquipment.Name = "DisplayEquipment";
            this.DisplayEquipment.Size = new System.Drawing.Size(1460, 693);
            this.DisplayEquipment.TabIndex = 5;
            this.DisplayEquipment.Text = "Display Equipment";
            this.DisplayEquipment.UseVisualStyleBackColor = true;
            // 
            // btnRefreshEquipmentList
            // 
            this.btnRefreshEquipmentList.Location = new System.Drawing.Point(534, 494);
            this.btnRefreshEquipmentList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRefreshEquipmentList.Name = "btnRefreshEquipmentList";
            this.btnRefreshEquipmentList.Size = new System.Drawing.Size(290, 46);
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
            this.dataGridViewEquipment.Location = new System.Drawing.Point(218, 94);
            this.dataGridViewEquipment.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridViewEquipment.Name = "dataGridViewEquipment";
            this.dataGridViewEquipment.ReadOnly = true;
            this.dataGridViewEquipment.RowHeadersWidth = 62;
            this.dataGridViewEquipment.RowTemplate.Height = 28;
            this.dataGridViewEquipment.Size = new System.Drawing.Size(986, 344);
            this.dataGridViewEquipment.TabIndex = 13;
            // 
            // DEpanel4
            // 
            this.DEpanel4.BackColor = System.Drawing.Color.LightBlue;
            this.DEpanel4.Controls.Add(this.DElabel5);
            this.DEpanel4.Location = new System.Drawing.Point(8, 6);
            this.DEpanel4.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.DEpanel4.Name = "DEpanel4";
            this.DEpanel4.Size = new System.Drawing.Size(1352, 77);
            this.DEpanel4.TabIndex = 12;
            // 
            // DElabel5
            // 
            this.DElabel5.AutoSize = true;
            this.DElabel5.BackColor = System.Drawing.Color.LightBlue;
            this.DElabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DElabel5.Location = new System.Drawing.Point(469, 15);
            this.DElabel5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DElabel5.Name = "DElabel5";
            this.DElabel5.Size = new System.Drawing.Size(400, 51);
            this.DElabel5.TabIndex = 11;
            this.DElabel5.Text = "Display Equipment";
            // 
            // DisplayAllClients
            // 
            this.DisplayAllClients.Controls.Add(this.btnRefreshClientList);
            this.DisplayAllClients.Controls.Add(this.dataGridViewClients);
            this.DisplayAllClients.Controls.Add(this.DACpanel5);
            this.DisplayAllClients.Location = new System.Drawing.Point(8, 39);
            this.DisplayAllClients.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DisplayAllClients.Name = "DisplayAllClients";
            this.DisplayAllClients.Size = new System.Drawing.Size(1460, 693);
            this.DisplayAllClients.TabIndex = 6;
            this.DisplayAllClients.Text = "Display All Clients";
            this.DisplayAllClients.UseVisualStyleBackColor = true;
            // 
            // btnRefreshClientList
            // 
            this.btnRefreshClientList.Location = new System.Drawing.Point(560, 460);
            this.btnRefreshClientList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRefreshClientList.Name = "btnRefreshClientList";
            this.btnRefreshClientList.Size = new System.Drawing.Size(208, 73);
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
            this.dataGridViewClients.Location = new System.Drawing.Point(254, 94);
            this.dataGridViewClients.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridViewClients.Name = "dataGridViewClients";
            this.dataGridViewClients.ReadOnly = true;
            this.dataGridViewClients.RowHeadersWidth = 62;
            this.dataGridViewClients.RowTemplate.Height = 28;
            this.dataGridViewClients.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewClients.Size = new System.Drawing.Size(858, 360);
            this.dataGridViewClients.TabIndex = 14;
            // 
            // DACpanel5
            // 
            this.DACpanel5.BackColor = System.Drawing.Color.LightBlue;
            this.DACpanel5.Controls.Add(this.DAClabel6);
            this.DACpanel5.Location = new System.Drawing.Point(8, 6);
            this.DACpanel5.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.DACpanel5.Name = "DACpanel5";
            this.DACpanel5.Size = new System.Drawing.Size(1352, 77);
            this.DACpanel5.TabIndex = 13;
            // 
            // DAClabel6
            // 
            this.DAClabel6.AutoSize = true;
            this.DAClabel6.BackColor = System.Drawing.Color.LightBlue;
            this.DAClabel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DAClabel6.Location = new System.Drawing.Point(472, 9);
            this.DAClabel6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DAClabel6.Name = "DAClabel6";
            this.DAClabel6.Size = new System.Drawing.Size(388, 51);
            this.DAClabel6.TabIndex = 11;
            this.DAClabel6.Text = "Display All Clients";
            // 
            // AddRentalItems
            // 
            this.AddRentalItems.Controls.Add(this.label14);
            this.AddRentalItems.Controls.Add(this.dateTimePicker2);
            this.AddRentalItems.Controls.Add(this.label13);
            this.AddRentalItems.Controls.Add(this.dateTimePicker1);
            this.AddRentalItems.Controls.Add(this.button3);
            this.AddRentalItems.Controls.Add(this.richTextBox4);
            this.AddRentalItems.Controls.Add(this.richTextBox3);
            this.AddRentalItems.Controls.Add(this.comboBox5);
            this.AddRentalItems.Controls.Add(this.label12);
            this.AddRentalItems.Controls.Add(this.label11);
            this.AddRentalItems.Controls.Add(this.label10);
            this.AddRentalItems.Controls.Add(this.panel3);
            this.AddRentalItems.Location = new System.Drawing.Point(4, 29);
            this.AddRentalItems.Name = "AddRentalItems";
            this.AddRentalItems.Size = new System.Drawing.Size(1099, 559);
            this.AddRentalItems.TabIndex = 7;
            this.AddRentalItems.Text = "Add Rental Items";
            this.AddRentalItems.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(515, 370);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(213, 26);
            this.dateTimePicker1.TabIndex = 10;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(446, 460);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 29);
            this.button3.TabIndex = 9;
            this.button3.Text = "rent";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // richTextBox4
            // 
            this.richTextBox4.Location = new System.Drawing.Point(515, 314);
            this.richTextBox4.Name = "richTextBox4";
            this.richTextBox4.Size = new System.Drawing.Size(213, 33);
            this.richTextBox4.TabIndex = 8;
            this.richTextBox4.Text = "";
            // 
            // richTextBox3
            // 
            this.richTextBox3.Location = new System.Drawing.Point(515, 193);
            this.richTextBox3.Name = "richTextBox3";
            this.richTextBox3.Size = new System.Drawing.Size(213, 75);
            this.richTextBox3.TabIndex = 7;
            this.richTextBox3.Text = "";
            // 
            // comboBox5
            // 
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Location = new System.Drawing.Point(515, 130);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(213, 28);
            this.comboBox5.TabIndex = 6;
            this.comboBox5.SelectedIndexChanged += new System.EventHandler(this.comboBox5_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(287, 184);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(89, 20);
            this.label12.TabIndex = 5;
            this.label12.Text = "Description";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(287, 314);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(103, 20);
            this.label11.TabIndex = 3;
            this.label11.Text = "Rate per Day";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(287, 130);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(136, 20);
            this.label10.TabIndex = 1;
            this.label10.Text = "Equipment to rent";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel3.Controls.Add(this.label9);
            this.panel3.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1011, 62);
            this.panel3.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(339, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(368, 55);
            this.label9.TabIndex = 1;
            this.label9.Text = "Add Rental Item";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(287, 375);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(117, 20);
            this.label13.TabIndex = 11;
            this.label13.Text = "borowwed date";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(515, 414);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(213, 26);
            this.dateTimePicker2.TabIndex = 12;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(287, 420);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(87, 20);
            this.label14.TabIndex = 13;
            this.label14.Text = "return date";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 591);
            this.Controls.Add(this.tabControl1);
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
            this.AddRentalItems.ResumeLayout(false);
            this.AddRentalItems.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.AddClient.ResumeLayout(false);
            this.AddClient.PerformLayout();
            this.DisplayEquipment.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEquipment)).EndInit();
            this.DEpanel4.ResumeLayout(false);
            this.DEpanel4.PerformLayout();
            this.DisplayAllClients.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClients)).EndInit();
            this.DACpanel5.ResumeLayout(false);
            this.DACpanel5.PerformLayout();
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
        private System.Windows.Forms.ComboBox deleteEquipmentComboBox1;
        private System.Windows.Forms.Label deleteEquipmentlabel2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label deleteEquipmentlabel4;
        private System.Windows.Forms.RichTextBox deleteEquipmentRichTextBox1;
        private System.Windows.Forms.Label deleteEquipmentlabel3;
        private System.Windows.Forms.Button deleteEquipmentbutton1;
        private System.Windows.Forms.Panel deleteEquipmentpanel2;
        private System.Windows.Forms.Label addClientLabel;
        private System.Windows.Forms.Panel addClientpanel3;
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
        private System.Windows.Forms.Panel DEpanel4;
        private System.Windows.Forms.Panel DACpanel5;
        private System.Windows.Forms.Label DElabel5;
        private System.Windows.Forms.Label DAClabel6;
        private System.Windows.Forms.Button btnRefreshClientList;
        private System.Windows.Forms.DataGridView dataGridViewClients;
        private System.Windows.Forms.DataGridView dataGridViewEquipment;
        private System.Windows.Forms.Button btnRefreshEquipmentList;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.RichTextBox richTextBox3;
        private System.Windows.Forms.RichTextBox richTextBox4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label14;
    }
}

