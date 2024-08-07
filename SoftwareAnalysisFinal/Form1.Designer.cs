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
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.AddClient = new System.Windows.Forms.TabPage();
            this.DisplayEquipment = new System.Windows.Forms.TabPage();
            this.DisplayAllClients = new System.Windows.Forms.TabPage();
            this.AddRentalItems = new System.Windows.Forms.TabPage();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.richTextBox3 = new System.Windows.Forms.RichTextBox();
            this.richTextBox4 = new System.Windows.Forms.RichTextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.AddEquipment.SuspendLayout();
            this.panel1.SuspendLayout();
            this.DeleteEquipment.SuspendLayout();
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
            this.tabControl1.Location = new System.Drawing.Point(9, -2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1107, 592);
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
            this.DeleteEquipment.Controls.Add(this.button1);
            this.DeleteEquipment.Controls.Add(this.label4);
            this.DeleteEquipment.Controls.Add(this.richTextBox1);
            this.DeleteEquipment.Controls.Add(this.label3);
            this.DeleteEquipment.Controls.Add(this.comboBox1);
            this.DeleteEquipment.Controls.Add(this.label2);
            this.DeleteEquipment.Controls.Add(this.panel2);
            this.DeleteEquipment.Location = new System.Drawing.Point(4, 29);
            this.DeleteEquipment.Name = "DeleteEquipment";
            this.DeleteEquipment.Size = new System.Drawing.Size(1099, 559);
            this.DeleteEquipment.TabIndex = 8;
            this.DeleteEquipment.Text = "Delete Equipment";
            this.DeleteEquipment.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(456, 322);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 51);
            this.button1.TabIndex = 8;
            this.button1.Text = "Delete";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(390, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Description";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(489, 120);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(385, 118);
            this.richTextBox1.TabIndex = 6;
            this.richTextBox1.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(390, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Equipment";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(489, 72);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(334, 28);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(408, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(285, 37);
            this.label2.TabIndex = 1;
            this.label2.Text = "Delete Equipment";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel2.Location = new System.Drawing.Point(2, 3);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1014, 62);
            this.panel2.TabIndex = 9;
            // 
            // AddClient
            // 
            this.AddClient.Location = new System.Drawing.Point(4, 29);
            this.AddClient.Name = "AddClient";
            this.AddClient.Padding = new System.Windows.Forms.Padding(3);
            this.AddClient.Size = new System.Drawing.Size(1099, 559);
            this.AddClient.TabIndex = 3;
            this.AddClient.Text = "Add Client";
            this.AddClient.UseVisualStyleBackColor = true;
            // 
            // DisplayEquipment
            // 
            this.DisplayEquipment.Location = new System.Drawing.Point(4, 29);
            this.DisplayEquipment.Name = "DisplayEquipment";
            this.DisplayEquipment.Size = new System.Drawing.Size(1099, 559);
            this.DisplayEquipment.TabIndex = 5;
            this.DisplayEquipment.Text = "Display Equipment";
            this.DisplayEquipment.UseVisualStyleBackColor = true;
            // 
            // DisplayAllClients
            // 
            this.DisplayAllClients.Location = new System.Drawing.Point(4, 29);
            this.DisplayAllClients.Name = "DisplayAllClients";
            this.DisplayAllClients.Size = new System.Drawing.Size(1099, 559);
            this.DisplayAllClients.TabIndex = 6;
            this.DisplayAllClients.Text = "Display All Clients";
            this.DisplayAllClients.UseVisualStyleBackColor = true;
            // 
            // AddRentalItems
            // 
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
            // comboBox5
            // 
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Location = new System.Drawing.Point(515, 130);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(213, 28);
            this.comboBox5.TabIndex = 6;
            this.comboBox5.SelectedIndexChanged += new System.EventHandler(this.comboBox5_SelectedIndexChanged);
            // 
            // richTextBox3
            // 
            this.richTextBox3.Location = new System.Drawing.Point(515, 193);
            this.richTextBox3.Name = "richTextBox3";
            this.richTextBox3.Size = new System.Drawing.Size(213, 75);
            this.richTextBox3.TabIndex = 7;
            this.richTextBox3.Text = "";
            // 
            // richTextBox4
            // 
            this.richTextBox4.Location = new System.Drawing.Point(515, 314);
            this.richTextBox4.Name = "richTextBox4";
            this.richTextBox4.Size = new System.Drawing.Size(213, 33);
            this.richTextBox4.TabIndex = 8;
            this.richTextBox4.Text = "";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(442, 405);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 29);
            this.button3.TabIndex = 9;
            this.button3.Text = "rent";
            this.button3.UseVisualStyleBackColor = true;
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
    }
}

