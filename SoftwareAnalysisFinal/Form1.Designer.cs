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
            this.DACSuccess = new System.Windows.Forms.Label();
            this.DACError = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.DeleteEquipment = new System.Windows.Forms.TabPage();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label16 = new System.Windows.Forms.Label();
            this.deleteEquipmentbutton1 = new System.Windows.Forms.Button();
            this.deleteEquipmentlabel4 = new System.Windows.Forms.Label();
            this.deleteEquipmentRichTextBox1 = new System.Windows.Forms.RichTextBox();
            this.deleteEquipmentlabel3 = new System.Windows.Forms.Label();
            this.deleteEquipmentComboBox1 = new System.Windows.Forms.ComboBox();
            this.AddClient = new System.Windows.Forms.TabPage();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
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
            this.DisplayEquipment = new System.Windows.Forms.TabPage();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.btnRefreshEquipmentList = new System.Windows.Forms.Button();
            this.dataGridViewEquipment = new System.Windows.Forms.DataGridView();
            this.DisplayAllClients = new System.Windows.Forms.TabPage();
            this.btnRefreshClientList = new System.Windows.Forms.Button();
            this.dataGridViewClients = new System.Windows.Forms.DataGridView();
            this.DACpanel5 = new System.Windows.Forms.Panel();
            this.DAClabel6 = new System.Windows.Forms.Label();
            this.AddRentalItems = new System.Windows.Forms.TabPage();
            this.timeError = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.rentalLabelCost = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button3 = new System.Windows.Forms.Button();
            this.richTextBox3 = new System.Windows.Forms.RichTextBox();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.tabControl1.SuspendLayout();
            this.AddEquipment.SuspendLayout();
            this.panel1.SuspendLayout();
            this.DeleteEquipment.SuspendLayout();
            this.panel6.SuspendLayout();
            this.AddClient.SuspendLayout();
            this.panel5.SuspendLayout();
            this.DisplayEquipment.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEquipment)).BeginInit();
            this.DisplayAllClients.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClients)).BeginInit();
            this.DACpanel5.SuspendLayout();
            this.AddRentalItems.SuspendLayout();
            this.panel3.SuspendLayout();
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
            this.tabControl1.Location = new System.Drawing.Point(2, 1);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(984, 481);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // AddEquipment
            // 
            this.AddEquipment.Controls.Add(this.DACSuccess);
            this.AddEquipment.Controls.Add(this.DACError);
            this.AddEquipment.Controls.Add(this.panel1);
            this.AddEquipment.Controls.Add(this.label8);
            this.AddEquipment.Controls.Add(this.comboBox3);
            this.AddEquipment.Controls.Add(this.label7);
            this.AddEquipment.Controls.Add(this.label6);
            this.AddEquipment.Controls.Add(this.richTextBox2);
            this.AddEquipment.Controls.Add(this.label5);
            this.AddEquipment.Controls.Add(this.comboBox2);
            this.AddEquipment.Controls.Add(this.button2);
            this.AddEquipment.Controls.Add(this.textBox1);
            this.AddEquipment.Location = new System.Drawing.Point(8, 27);
            this.AddEquipment.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AddEquipment.Name = "AddEquipment";
            this.AddEquipment.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AddEquipment.Size = new System.Drawing.Size(968, 446);
            this.AddEquipment.TabIndex = 2;
            this.AddEquipment.Text = "Add Equipment";
            this.AddEquipment.UseVisualStyleBackColor = true;
            // 
            // DACSuccess
            // 
            this.DACSuccess.AutoSize = true;
            this.DACSuccess.ForeColor = System.Drawing.Color.LimeGreen;
            this.DACSuccess.Location = new System.Drawing.Point(264, 293);
            this.DACSuccess.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.DACSuccess.Name = "DACSuccess";
            this.DACSuccess.Size = new System.Drawing.Size(0, 13);
            this.DACSuccess.TabIndex = 22;
            // 
            // DACError
            // 
            this.DACError.AutoSize = true;
            this.DACError.ForeColor = System.Drawing.Color.Red;
            this.DACError.Location = new System.Drawing.Point(259, 289);
            this.DACError.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.DACError.Name = "DACError";
            this.DACError.Size = new System.Drawing.Size(0, 13);
            this.DACError.TabIndex = 21;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(682, 54);
            this.panel1.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(236, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(386, 61);
            this.label1.TabIndex = 11;
            this.label1.Text = "Add Equipment";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(178, 146);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Price per Day";
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(338, 144);
            this.comboBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(172, 21);
            this.comboBox3.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(178, 190);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Description";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(178, 73);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Equipment name";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(338, 186);
            this.richTextBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(172, 64);
            this.richTextBox2.TabIndex = 15;
            this.richTextBox2.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(178, 110);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Category ID";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(338, 106);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(172, 21);
            this.comboBox2.TabIndex = 13;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(254, 311);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(168, 21);
            this.button2.TabIndex = 12;
            this.button2.Text = "Add Equipment";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(338, 67);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(264, 20);
            this.textBox1.TabIndex = 1;
            // 
            // DeleteEquipment
            // 
            this.DeleteEquipment.Controls.Add(this.panel6);
            this.DeleteEquipment.Controls.Add(this.deleteEquipmentbutton1);
            this.DeleteEquipment.Controls.Add(this.deleteEquipmentlabel4);
            this.DeleteEquipment.Controls.Add(this.deleteEquipmentRichTextBox1);
            this.DeleteEquipment.Controls.Add(this.deleteEquipmentlabel3);
            this.DeleteEquipment.Controls.Add(this.deleteEquipmentComboBox1);
            this.DeleteEquipment.Location = new System.Drawing.Point(8, 27);
            this.DeleteEquipment.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.DeleteEquipment.Name = "DeleteEquipment";
            this.DeleteEquipment.Size = new System.Drawing.Size(968, 446);
            this.DeleteEquipment.TabIndex = 8;
            this.DeleteEquipment.Text = "Delete Equipment";
            this.DeleteEquipment.UseVisualStyleBackColor = true;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel6.Controls.Add(this.label16);
            this.panel6.Location = new System.Drawing.Point(3, 0);
            this.panel6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(682, 54);
            this.panel6.TabIndex = 14;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(236, 9);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(446, 61);
            this.label16.TabIndex = 11;
            this.label16.Text = "Delete Equipment";
            // 
            // deleteEquipmentbutton1
            // 
            this.deleteEquipmentbutton1.Location = new System.Drawing.Point(255, 281);
            this.deleteEquipmentbutton1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.deleteEquipmentbutton1.Name = "deleteEquipmentbutton1";
            this.deleteEquipmentbutton1.Size = new System.Drawing.Size(104, 41);
            this.deleteEquipmentbutton1.TabIndex = 8;
            this.deleteEquipmentbutton1.Text = "Delete";
            this.deleteEquipmentbutton1.UseVisualStyleBackColor = true;
            this.deleteEquipmentbutton1.Click += new System.EventHandler(this.button1_Click);
            // 
            // deleteEquipmentlabel4
            // 
            this.deleteEquipmentlabel4.AutoSize = true;
            this.deleteEquipmentlabel4.Location = new System.Drawing.Point(196, 118);
            this.deleteEquipmentlabel4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.deleteEquipmentlabel4.Name = "deleteEquipmentlabel4";
            this.deleteEquipmentlabel4.Size = new System.Drawing.Size(60, 13);
            this.deleteEquipmentlabel4.TabIndex = 7;
            this.deleteEquipmentlabel4.Text = "Description";
            // 
            // deleteEquipmentRichTextBox1
            // 
            this.deleteEquipmentRichTextBox1.Location = new System.Drawing.Point(284, 118);
            this.deleteEquipmentRichTextBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.deleteEquipmentRichTextBox1.Name = "deleteEquipmentRichTextBox1";
            this.deleteEquipmentRichTextBox1.Size = new System.Drawing.Size(342, 97);
            this.deleteEquipmentRichTextBox1.TabIndex = 6;
            this.deleteEquipmentRichTextBox1.Text = "";
            // 
            // deleteEquipmentlabel3
            // 
            this.deleteEquipmentlabel3.AutoSize = true;
            this.deleteEquipmentlabel3.Location = new System.Drawing.Point(199, 79);
            this.deleteEquipmentlabel3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.deleteEquipmentlabel3.Name = "deleteEquipmentlabel3";
            this.deleteEquipmentlabel3.Size = new System.Drawing.Size(57, 13);
            this.deleteEquipmentlabel3.TabIndex = 5;
            this.deleteEquipmentlabel3.Text = "Equipment";
            // 
            // deleteEquipmentComboBox1
            // 
            this.deleteEquipmentComboBox1.FormattingEnabled = true;
            this.deleteEquipmentComboBox1.Location = new System.Drawing.Point(284, 79);
            this.deleteEquipmentComboBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.deleteEquipmentComboBox1.Name = "deleteEquipmentComboBox1";
            this.deleteEquipmentComboBox1.Size = new System.Drawing.Size(298, 21);
            this.deleteEquipmentComboBox1.TabIndex = 2;
            this.deleteEquipmentComboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // AddClient
            // 
            this.AddClient.Controls.Add(this.panel5);
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
            this.AddClient.Location = new System.Drawing.Point(8, 27);
            this.AddClient.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.AddClient.Name = "AddClient";
            this.AddClient.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.AddClient.Size = new System.Drawing.Size(968, 446);
            this.AddClient.TabIndex = 3;
            this.AddClient.Text = "Add Client";
            this.AddClient.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel5.Controls.Add(this.label15);
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(682, 54);
            this.panel5.TabIndex = 25;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(271, 10);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(271, 61);
            this.label15.TabIndex = 11;
            this.label15.Text = "Add Client";
            // 
            // ACConfirm
            // 
            this.ACConfirm.AutoSize = true;
            this.ACConfirm.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.ACConfirm.Location = new System.Drawing.Point(406, 305);
            this.ACConfirm.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ACConfirm.Name = "ACConfirm";
            this.ACConfirm.Size = new System.Drawing.Size(0, 13);
            this.ACConfirm.TabIndex = 24;
            // 
            // ACError
            // 
            this.ACError.AutoSize = true;
            this.ACError.ForeColor = System.Drawing.Color.Red;
            this.ACError.Location = new System.Drawing.Point(372, 235);
            this.ACError.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ACError.Name = "ACError";
            this.ACError.Size = new System.Drawing.Size(0, 13);
            this.ACError.TabIndex = 23;
            // 
            // addClientButton
            // 
            this.addClientButton.Location = new System.Drawing.Point(242, 265);
            this.addClientButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.addClientButton.Name = "addClientButton";
            this.addClientButton.Size = new System.Drawing.Size(100, 29);
            this.addClientButton.TabIndex = 22;
            this.addClientButton.Text = "Add Client";
            this.addClientButton.UseVisualStyleBackColor = true;
            this.addClientButton.Click += new System.EventHandler(this.addClientButton_Click);
            // 
            // ACLabel4
            // 
            this.ACLabel4.AutoSize = true;
            this.ACLabel4.Location = new System.Drawing.Point(230, 197);
            this.ACLabel4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ACLabel4.Name = "ACLabel4";
            this.ACLabel4.Size = new System.Drawing.Size(32, 13);
            this.ACLabel4.TabIndex = 21;
            this.ACLabel4.Text = "Email";
            // 
            // ACBox4
            // 
            this.ACBox4.Location = new System.Drawing.Point(300, 193);
            this.ACBox4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ACBox4.Name = "ACBox4";
            this.ACBox4.Size = new System.Drawing.Size(302, 20);
            this.ACBox4.TabIndex = 20;
            // 
            // ACLabel3
            // 
            this.ACLabel3.AutoSize = true;
            this.ACLabel3.Location = new System.Drawing.Point(185, 160);
            this.ACLabel3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ACLabel3.Name = "ACLabel3";
            this.ACLabel3.Size = new System.Drawing.Size(78, 13);
            this.ACLabel3.TabIndex = 19;
            this.ACLabel3.Text = "Phone Number";
            // 
            // ACLabel2
            // 
            this.ACLabel2.AutoSize = true;
            this.ACLabel2.Location = new System.Drawing.Point(205, 127);
            this.ACLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ACLabel2.Name = "ACLabel2";
            this.ACLabel2.Size = new System.Drawing.Size(57, 13);
            this.ACLabel2.TabIndex = 18;
            this.ACLabel2.Text = "First Name";
            // 
            // ACLabel1
            // 
            this.ACLabel1.AutoSize = true;
            this.ACLabel1.Location = new System.Drawing.Point(205, 96);
            this.ACLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ACLabel1.Name = "ACLabel1";
            this.ACLabel1.Size = new System.Drawing.Size(58, 13);
            this.ACLabel1.TabIndex = 17;
            this.ACLabel1.Text = "Last Name";
            // 
            // ACBox3
            // 
            this.ACBox3.Location = new System.Drawing.Point(300, 158);
            this.ACBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ACBox3.Name = "ACBox3";
            this.ACBox3.Size = new System.Drawing.Size(302, 20);
            this.ACBox3.TabIndex = 14;
            // 
            // ACBox2
            // 
            this.ACBox2.Location = new System.Drawing.Point(300, 126);
            this.ACBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ACBox2.Name = "ACBox2";
            this.ACBox2.Size = new System.Drawing.Size(302, 20);
            this.ACBox2.TabIndex = 13;
            // 
            // ACBox1
            // 
            this.ACBox1.Location = new System.Drawing.Point(300, 93);
            this.ACBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ACBox1.Name = "ACBox1";
            this.ACBox1.Size = new System.Drawing.Size(302, 20);
            this.ACBox1.TabIndex = 12;
            // 
            // DisplayEquipment
            // 
            this.DisplayEquipment.Controls.Add(this.panel4);
            this.DisplayEquipment.Controls.Add(this.btnRefreshEquipmentList);
            this.DisplayEquipment.Controls.Add(this.dataGridViewEquipment);
            this.DisplayEquipment.Location = new System.Drawing.Point(8, 27);
            this.DisplayEquipment.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.DisplayEquipment.Name = "DisplayEquipment";
            this.DisplayEquipment.Size = new System.Drawing.Size(968, 446);
            this.DisplayEquipment.TabIndex = 5;
            this.DisplayEquipment.Text = "Display Equipment";
            this.DisplayEquipment.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel4.Controls.Add(this.label9);
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(682, 54);
            this.panel4.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(236, 9);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(469, 61);
            this.label9.TabIndex = 11;
            this.label9.Text = "Display Equipment";
            // 
            // btnRefreshEquipmentList
            // 
            this.btnRefreshEquipmentList.Location = new System.Drawing.Point(242, 302);
            this.btnRefreshEquipmentList.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnRefreshEquipmentList.Name = "btnRefreshEquipmentList";
            this.btnRefreshEquipmentList.Size = new System.Drawing.Size(194, 30);
            this.btnRefreshEquipmentList.TabIndex = 14;
            this.btnRefreshEquipmentList.Text = "Refresh Equipment List";
            this.btnRefreshEquipmentList.UseVisualStyleBackColor = true;
            this.btnRefreshEquipmentList.Click += new System.EventHandler(this.btnRefreshEquipmentList_Click);
            // 
            // dataGridViewEquipment
            // 
            this.dataGridViewEquipment.AllowUserToAddRows = false;
            this.dataGridViewEquipment.AllowUserToDeleteRows = false;
            this.dataGridViewEquipment.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewEquipment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEquipment.Location = new System.Drawing.Point(55, 56);
            this.dataGridViewEquipment.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dataGridViewEquipment.Name = "dataGridViewEquipment";
            this.dataGridViewEquipment.ReadOnly = true;
            this.dataGridViewEquipment.RowHeadersWidth = 62;
            this.dataGridViewEquipment.RowTemplate.Height = 28;
            this.dataGridViewEquipment.Size = new System.Drawing.Size(548, 224);
            this.dataGridViewEquipment.TabIndex = 13;
            // 
            // DisplayAllClients
            // 
            this.DisplayAllClients.Controls.Add(this.btnRefreshClientList);
            this.DisplayAllClients.Controls.Add(this.dataGridViewClients);
            this.DisplayAllClients.Controls.Add(this.DACpanel5);
            this.DisplayAllClients.Location = new System.Drawing.Point(8, 27);
            this.DisplayAllClients.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.DisplayAllClients.Name = "DisplayAllClients";
            this.DisplayAllClients.Size = new System.Drawing.Size(968, 446);
            this.DisplayAllClients.TabIndex = 6;
            this.DisplayAllClients.Text = "Display All Clients";
            this.DisplayAllClients.UseVisualStyleBackColor = true;
            // 
            // btnRefreshClientList
            // 
            this.btnRefreshClientList.Location = new System.Drawing.Point(269, 300);
            this.btnRefreshClientList.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnRefreshClientList.Name = "btnRefreshClientList";
            this.btnRefreshClientList.Size = new System.Drawing.Size(138, 47);
            this.btnRefreshClientList.TabIndex = 15;
            this.btnRefreshClientList.Text = "Refresh Client List";
            this.btnRefreshClientList.UseVisualStyleBackColor = true;
            this.btnRefreshClientList.Click += new System.EventHandler(this.btnRefreshClientList_Click);
            // 
            // dataGridViewClients
            // 
            this.dataGridViewClients.AllowUserToAddRows = false;
            this.dataGridViewClients.AllowUserToDeleteRows = false;
            this.dataGridViewClients.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewClients.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewClients.Location = new System.Drawing.Point(65, 62);
            this.dataGridViewClients.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dataGridViewClients.Name = "dataGridViewClients";
            this.dataGridViewClients.ReadOnly = true;
            this.dataGridViewClients.RowHeadersWidth = 62;
            this.dataGridViewClients.RowTemplate.Height = 28;
            this.dataGridViewClients.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewClients.Size = new System.Drawing.Size(572, 234);
            this.dataGridViewClients.TabIndex = 14;
            // 
            // DACpanel5
            // 
            this.DACpanel5.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.DACpanel5.Controls.Add(this.DAClabel6);
            this.DACpanel5.Location = new System.Drawing.Point(0, 0);
            this.DACpanel5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DACpanel5.Name = "DACpanel5";
            this.DACpanel5.Size = new System.Drawing.Size(682, 54);
            this.DACpanel5.TabIndex = 13;
            // 
            // DAClabel6
            // 
            this.DAClabel6.AutoSize = true;
            this.DAClabel6.BackColor = System.Drawing.Color.Transparent;
            this.DAClabel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DAClabel6.Location = new System.Drawing.Point(236, 9);
            this.DAClabel6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.DAClabel6.Name = "DAClabel6";
            this.DAClabel6.Size = new System.Drawing.Size(456, 61);
            this.DAClabel6.TabIndex = 11;
            this.DAClabel6.Text = "Display All Clients";
            // 
            // AddRentalItems
            // 
            this.AddRentalItems.Controls.Add(this.timeError);
            this.AddRentalItems.Controls.Add(this.label17);
            this.AddRentalItems.Controls.Add(this.comboBox4);
            this.AddRentalItems.Controls.Add(this.rentalLabelCost);
            this.AddRentalItems.Controls.Add(this.comboBox1);
            this.AddRentalItems.Controls.Add(this.panel3);
            this.AddRentalItems.Controls.Add(this.label14);
            this.AddRentalItems.Controls.Add(this.dateTimePicker2);
            this.AddRentalItems.Controls.Add(this.label13);
            this.AddRentalItems.Controls.Add(this.dateTimePicker1);
            this.AddRentalItems.Controls.Add(this.button3);
            this.AddRentalItems.Controls.Add(this.richTextBox3);
            this.AddRentalItems.Controls.Add(this.comboBox5);
            this.AddRentalItems.Controls.Add(this.label12);
            this.AddRentalItems.Controls.Add(this.label11);
            this.AddRentalItems.Controls.Add(this.label10);
            this.AddRentalItems.Location = new System.Drawing.Point(8, 27);
            this.AddRentalItems.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AddRentalItems.Name = "AddRentalItems";
            this.AddRentalItems.Size = new System.Drawing.Size(968, 446);
            this.AddRentalItems.TabIndex = 7;
            this.AddRentalItems.Text = "Add Rental Items";
            this.AddRentalItems.UseVisualStyleBackColor = true;
            // 
            // timeError
            // 
            this.timeError.AutoSize = true;
            this.timeError.ForeColor = System.Drawing.Color.Crimson;
            this.timeError.Location = new System.Drawing.Point(341, 295);
            this.timeError.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.timeError.Name = "timeError";
            this.timeError.Size = new System.Drawing.Size(229, 13);
            this.timeError.TabIndex = 19;
            this.timeError.Text = "Error: Return Date should be after Rental Date!";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(192, 106);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(65, 13);
            this.label17.TabIndex = 18;
            this.label17.Text = "Customer ID";
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(344, 101);
            this.comboBox4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(144, 21);
            this.comboBox4.TabIndex = 17;
            // 
            // rentalLabelCost
            // 
            this.rentalLabelCost.AutoSize = true;
            this.rentalLabelCost.ForeColor = System.Drawing.Color.Green;
            this.rentalLabelCost.Location = new System.Drawing.Point(192, 295);
            this.rentalLabelCost.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.rentalLabelCost.Name = "rentalLabelCost";
            this.rentalLabelCost.Size = new System.Drawing.Size(51, 13);
            this.rentalLabelCost.TabIndex = 16;
            this.rentalLabelCost.Text = "Success!";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(344, 68);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(144, 21);
            this.comboBox1.TabIndex = 15;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(682, 54);
            this.panel3.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(236, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(431, 61);
            this.label2.TabIndex = 11;
            this.label2.Text = "Add Rental Items";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(192, 265);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(81, 13);
            this.label14.TabIndex = 13;
            this.label14.Text = "Date To Return";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(344, 262);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(144, 20);
            this.dateTimePicker2.TabIndex = 12;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(192, 235);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(68, 13);
            this.label13.TabIndex = 11;
            this.label13.Text = "Date Rented";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(344, 232);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(144, 20);
            this.dateTimePicker1.TabIndex = 10;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(298, 325);
            this.button3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(50, 19);
            this.button3.TabIndex = 9;
            this.button3.Text = "Rent";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // richTextBox3
            // 
            this.richTextBox3.Location = new System.Drawing.Point(344, 170);
            this.richTextBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.richTextBox3.Name = "richTextBox3";
            this.richTextBox3.ReadOnly = true;
            this.richTextBox3.Size = new System.Drawing.Size(144, 50);
            this.richTextBox3.TabIndex = 7;
            this.richTextBox3.Text = "";
            // 
            // comboBox5
            // 
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Location = new System.Drawing.Point(344, 132);
            this.comboBox5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(144, 21);
            this.comboBox5.TabIndex = 6;
            this.comboBox5.SelectedIndexChanged += new System.EventHandler(this.comboBox5_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(192, 170);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(60, 13);
            this.label12.TabIndex = 5;
            this.label12.Text = "Description";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(192, 72);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 13);
            this.label11.TabIndex = 3;
            this.label11.Text = "Rental ID";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(192, 136);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "Equipment to rent";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 384);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Village Equipment Rentals";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.AddEquipment.ResumeLayout(false);
            this.AddEquipment.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.DeleteEquipment.ResumeLayout(false);
            this.DeleteEquipment.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.AddClient.ResumeLayout(false);
            this.AddClient.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.DisplayEquipment.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEquipment)).EndInit();
            this.DisplayAllClients.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClients)).EndInit();
            this.DACpanel5.ResumeLayout(false);
            this.DACpanel5.PerformLayout();
            this.AddRentalItems.ResumeLayout(false);
            this.AddRentalItems.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
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
        private System.Windows.Forms.ComboBox deleteEquipmentComboBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label deleteEquipmentlabel4;
        private System.Windows.Forms.RichTextBox deleteEquipmentRichTextBox1;
        private System.Windows.Forms.Label deleteEquipmentlabel3;
        private System.Windows.Forms.Button deleteEquipmentbutton1;
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
        private System.Windows.Forms.Panel DACpanel5;
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
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.RichTextBox richTextBox3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label rentalLabelCost;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.Label timeError;
        private System.Windows.Forms.Label DACError;
        private System.Windows.Forms.Label DACSuccess;
    }
}

