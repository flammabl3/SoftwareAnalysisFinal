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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
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
            this.AddEquipment.Location = new System.Drawing.Point(8, 39);
            this.AddEquipment.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AddEquipment.Name = "AddEquipment";
            this.AddEquipment.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AddEquipment.Size = new System.Drawing.Size(1460, 693);
            this.AddEquipment.TabIndex = 2;
            this.AddEquipment.Text = "Add Equipment";
            this.AddEquipment.UseVisualStyleBackColor = true;
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
            this.AddRentalItems.Location = new System.Drawing.Point(8, 39);
            this.AddRentalItems.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AddRentalItems.Name = "AddRentalItems";
            this.AddRentalItems.Size = new System.Drawing.Size(1460, 693);
            this.AddRentalItems.TabIndex = 7;
            this.AddRentalItems.Text = "Add Rental Items";
            this.AddRentalItems.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1376, 654);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.DeleteEquipment.ResumeLayout(false);
            this.DeleteEquipment.PerformLayout();
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
    }
}

