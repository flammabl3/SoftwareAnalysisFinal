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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DeleteEquipment = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.AddClient = new System.Windows.Forms.TabPage();
            this.DisplayEquipment = new System.Windows.Forms.TabPage();
            this.DisplayAllClients = new System.Windows.Forms.TabPage();
            this.AddRentalItems = new System.Windows.Forms.TabPage();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.AddEquipment.SuspendLayout();
            this.DeleteEquipment.SuspendLayout();
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
            this.tabControl1.Location = new System.Drawing.Point(12, -1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1477, 740);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // AddEquipment
            // 
            this.AddEquipment.Controls.Add(this.textBox1);
            this.AddEquipment.Controls.Add(this.label1);
            this.AddEquipment.Location = new System.Drawing.Point(8, 39);
            this.AddEquipment.Name = "AddEquipment";
            this.AddEquipment.Padding = new System.Windows.Forms.Padding(3);
            this.AddEquipment.Size = new System.Drawing.Size(1461, 693);
            this.AddEquipment.TabIndex = 2;
            this.AddEquipment.Text = "Add Equipment";
            this.AddEquipment.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(577, 105);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(525, 31);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(568, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(330, 51);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Equipment";
            // 
            // DeleteEquipment
            // 
            this.DeleteEquipment.Controls.Add(this.button1);
            this.DeleteEquipment.Controls.Add(this.label4);
            this.DeleteEquipment.Controls.Add(this.richTextBox1);
            this.DeleteEquipment.Controls.Add(this.label3);
            this.DeleteEquipment.Controls.Add(this.comboBox1);
            this.DeleteEquipment.Controls.Add(this.label2);
            this.DeleteEquipment.Location = new System.Drawing.Point(8, 39);
            this.DeleteEquipment.Name = "DeleteEquipment";
            this.DeleteEquipment.Size = new System.Drawing.Size(1461, 693);
            this.DeleteEquipment.TabIndex = 8;
            this.DeleteEquipment.Text = "Delete Equipment";
            this.DeleteEquipment.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(520, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Description";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(652, 150);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(513, 146);
            this.richTextBox1.TabIndex = 6;
            this.richTextBox1.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(520, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Equipment";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(652, 90);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(443, 33);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(543, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(381, 51);
            this.label2.TabIndex = 1;
            this.label2.Text = "Delete Equipment";
            // 
            // AddClient
            // 
            this.AddClient.Location = new System.Drawing.Point(8, 39);
            this.AddClient.Name = "AddClient";
            this.AddClient.Padding = new System.Windows.Forms.Padding(3);
            this.AddClient.Size = new System.Drawing.Size(1461, 693);
            this.AddClient.TabIndex = 3;
            this.AddClient.Text = "Add Client";
            this.AddClient.UseVisualStyleBackColor = true;
            // 
            // DisplayEquipment
            // 
            this.DisplayEquipment.Location = new System.Drawing.Point(8, 39);
            this.DisplayEquipment.Name = "DisplayEquipment";
            this.DisplayEquipment.Size = new System.Drawing.Size(1461, 693);
            this.DisplayEquipment.TabIndex = 5;
            this.DisplayEquipment.Text = "Display Equipment";
            this.DisplayEquipment.UseVisualStyleBackColor = true;
            // 
            // DisplayAllClients
            // 
            this.DisplayAllClients.Location = new System.Drawing.Point(8, 39);
            this.DisplayAllClients.Name = "DisplayAllClients";
            this.DisplayAllClients.Size = new System.Drawing.Size(1461, 693);
            this.DisplayAllClients.TabIndex = 6;
            this.DisplayAllClients.Text = "Display All Clients";
            this.DisplayAllClients.UseVisualStyleBackColor = true;
            // 
            // AddRentalItems
            // 
            this.AddRentalItems.Location = new System.Drawing.Point(8, 39);
            this.AddRentalItems.Name = "AddRentalItems";
            this.AddRentalItems.Size = new System.Drawing.Size(1461, 693);
            this.AddRentalItems.TabIndex = 7;
            this.AddRentalItems.Text = "Add Rental Items";
            this.AddRentalItems.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(608, 402);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 63);
            this.button1.TabIndex = 8;
            this.button1.Text = "Delete";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1485, 738);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.AddEquipment.ResumeLayout(false);
            this.AddEquipment.PerformLayout();
            this.DeleteEquipment.ResumeLayout(false);
            this.DeleteEquipment.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage AddEquipment;
        private System.Windows.Forms.TabPage AddClient;
        private System.Windows.Forms.TabPage DisplayEquipment;
        private System.Windows.Forms.TabPage DisplayAllClients;
        private System.Windows.Forms.TabPage AddRentalItems;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage DeleteEquipment;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
    }
}

