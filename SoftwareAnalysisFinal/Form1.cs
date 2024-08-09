using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OfficeOpenXml;
using System.Reflection;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Text.RegularExpressions;
using System.Globalization;
using System.Data.Odbc;

/* Author: Harry Jung
 * Program breakdown:
 * We have 1 form class, with many tabs.
 * The form has workbook and dataTable attributes.
 * Depending on what tab is loaded, we load a corresponding workbook from the xlsx file,
 * then load it into the datable, modifying the datatable and writing back to the xlsx if needed.
 */


namespace SoftwareAnalysisFinal
{
    public partial class Form1 : Form
    {
        ExcelPackage package;
        ExcelWorkbook workbook;
        DataTable dataTable;
        DataTable dataTableAux;
        DataTable dataTableClients;
        public Form1()
        {
            InitializeComponent();

            //use an OfficeOpenXml ExceLPackage object to open the xlsx file.
            string filePath = @"data.xlsx";
            FileInfo xlsxFile = new FileInfo(filePath);
            if (!File.Exists(filePath))
            {
                Console.WriteLine("File not found.");
                return;
            }

            ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;
            package = new ExcelPackage(xlsxFile);
            workbook = package.Workbook;

        }

        //control pages with tabControl1. Load a different worksheet from the xlsx depending on what tab is loaded.
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == AddEquipment)
            {
                DACSuccess.Visible = false;
                DACSuccess.Text = "";
                DACError.Visible = false;
                DACError.Text = "";
                dataTable = makeDataTable(workbook.Worksheets["RentalEquipment"]);

                dataTableAux = makeDataTable(workbook.Worksheets["CategoryList"]);
                dataTableAux.Columns.Add("DisplayColumn", typeof(string), "name + ' (' + Convert(category_id, 'System.String') + ')'");


                comboBox2.DisplayMember = "DisplayColumn";
                comboBox2.ValueMember = "category_id";
                comboBox2.DataSource = dataTableAux;

                comboBox3.DisplayMember = "daily_rate";
                comboBox3.ValueMember = "daily_rate";
                comboBox3.DataSource = dataTable;

            }
            else if (tabControl1.SelectedTab == AddRentalItems)
            {
                rentalLabelCost.Visible = false;
                timeError.Visible = false;

                dataTable = makeDataTable(workbook.Worksheets["RentalInfo"]);
                dataTableAux = makeDataTable(workbook.Worksheets["RentalEquipment"]);
                dataTableClients = makeDataTable(workbook.Worksheets["CustomerInformation"]);
                if (dataTable.Rows.Count == 0)
                {
                    return;
                }
                //add a new column to show the name and equipment id in the combobox.
                dataTableAux.Columns.Add("DisplayColumn", typeof(string), "name + ' (' + Convert(equipment_id, 'System.String') + ')'");

                comboBox5.DisplayMember = "DisplayColumn";
                comboBox5.ValueMember = "equipment_id";
                comboBox5.DataSource = dataTableAux;

                comboBox1.DisplayMember = "rental_id";
                comboBox1.ValueMember = "rental_id";
                var distinctRentalIds = dataTable.AsEnumerable()
                .Select(row => row.Field<string>("rental_id"))
                .Distinct()
                .ToList();

                comboBox1.DataSource = distinctRentalIds;

                dataTableClients.Columns.Add("DisplayColumn", typeof(string), "first_name + ' ' + last_name + ' (' + Convert(customer_id, 'System.String') + ')'");

                comboBox4.DisplayMember = "DisplayColumn";
                comboBox4.ValueMember = "customer_id";
                comboBox4.DataSource = dataTableClients;

            }
            else if (tabControl1.SelectedTab == DeleteEquipment)
            {
                dataTable = makeDataTable(workbook.Worksheets["RentalEquipment"]);
                //dont update data if there is an empty table loaded.
                if (dataTable.Rows.Count == 0)
                {
                    return;
                }
                //add a new column to show the name and equipment id in the combobox.
                dataTable.Columns.Add("DisplayColumn", typeof(string), "name + ' (' + Convert(equipment_id, 'System.String') + ')'");

                deleteEquipmentComboBox1.DisplayMember = "DisplayColumn";
                deleteEquipmentComboBox1.ValueMember = "name";

                deleteEquipmentComboBox1.DataSource = dataTable;
            }
            else if (tabControl1.SelectedTab == AddClient)
            {
                dataTable = makeDataTable(workbook.Worksheets["CustomerInformation"]);

            }
            else if (tabControl1.SelectedTab == DisplayEquipment)
            {
                dataTable = makeDataTable(workbook.Worksheets["RentalEquipment"]);
                dataGridViewEquipment.DataSource = dataTable;
            }
            else if (tabControl1.SelectedTab == DisplayAllClients)
            {
                dataTable = makeDataTable(workbook.Worksheets["CustomerInformation"]);
                dataGridViewClients.DataSource = dataTable;
            }
            
        }

        //load all entries from an excel worksheet into a winforms DataTable.
        private DataTable makeDataTable(ExcelWorksheet worksheet)
        {
            //make a dataTable object.
            DataTable dataTable = new DataTable();

            if (worksheet.Dimension == null)
            {
                return dataTable;  // return empty table if worksheet is empty
            }


            //iterate through each column in the 1st row to create our headers.
            foreach (var headerCell in worksheet.Cells[1, 1, 1, worksheet.Dimension.Columns])
            {
                dataTable.Columns.Add(headerCell.Text);
            }

            //create a DataRow out of an ExcelRange and add it to the datatable.
            for (int rowNum = 2; rowNum <= worksheet.Dimension.Rows; rowNum++)
            {
                ExcelRange row = worksheet.Cells[rowNum, 1, rowNum, worksheet.Dimension.Columns];
                DataRow dataRow = dataTable.NewRow();

                //for each cell in the ExcelRange, assign the corresponding cell in the dataTable to have the cell's text.
                foreach (var cell in row)
                {
                    dataRow[cell.Start.Column - 1] = cell.Text;
                }

                dataTable.Rows.Add(dataRow);
            }
            return dataTable;
        }

        //when we pick a piece of equipment, we update the description box with the data from that row.
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataRowView selectedRow = deleteEquipmentComboBox1.SelectedItem as DataRowView;

            if (selectedRow != null)
            {
                deleteEquipmentRichTextBox1.Text = selectedRow["description"].ToString();
            }
        }



        // The delete button. We take the selected row from the combo box, and then remove it from the current datatable. Then we get the worksheet again, clear it
        //replace the values, and update the datatable
        //then save back to the xlsx and update the combobox.

        private void button1_Click(object sender, EventArgs e)
        {
            DataRowView selectedRow = deleteEquipmentComboBox1.SelectedItem as DataRowView;
            if (selectedRow != null)
            {
                delete(selectedRow.Row, workbook.Worksheets["RentalEquipment"]);
                deleteEquipmentComboBox1.DisplayMember = "DisplayColumn";

                selectedRow = deleteEquipmentComboBox1.SelectedItem as DataRowView;
                if (selectedRow != null)
                {
                    deleteEquipmentRichTextBox1.Text = selectedRow["description"].ToString();
                }
            }
        }

        private void delete(DataRow row, ExcelWorksheet worksheet)
        {
            DataTable dataTable = row.Table;
            dataTable.Rows.Remove(row);
            if (dataTable.Columns["DisplayColumn"] != null)
                dataTable.Columns.Remove("DisplayColumn");

            worksheet.Cells.Clear();
            worksheet.Cells[1, 1].LoadFromDataTable(dataTable, true);
            dataTable = makeDataTable(worksheet);

            package.Save();
        }

        private void add(DataRow row, ExcelWorksheet worksheet)
        {
            DataTable dataTable = row.Table;
            dataTable.Rows.Add(row);

            worksheet.Cells.Clear();
            worksheet.Cells[1, 1].LoadFromDataTable(dataTable, true);
            dataTable = makeDataTable(worksheet);
            package.Save();
        }


        private void addClientButton_Click(object sender, EventArgs e)
        {
            ACError.Text = "";
            ACConfirm.Text = "";

            //make a new row and add it to excel. Trim all strings and validate.
            string last_name = ACBox1.Text.Trim();
            string first_name = ACBox2.Text.Trim();
            string c_phone = ACBox3.Text.Trim();
            string email = ACBox4.Text.Trim();

            if (last_name == "")
            {
                ACError.Text = "Error: last name needed.";
                return;
            }

            else if (Regex.IsMatch(last_name, @"[^a-zA-Z\-]"))
            {
                ACError.Text = "Error: last name contains invalid characters.";
                return;
            }

            else if (first_name == "")
            {
                ACError.Text = "Error: first name needed.";
                return;
            }

            // contains nonalpha
            else if (Regex.IsMatch(first_name, @"[^a-zA-Z\-]"))
            {
                ACError.Text = "Error: first name contains invalid characters.";
                return;
            }

            else if (c_phone == "")
            {
                ACError.Text = "Error: phone number needed.";
                return;
            }

            // contains nonnumeric
            else if (Regex.IsMatch(c_phone, @"[^0-9()\-\s]"))
            {
                ACError.Text = "Error: phone number contains invalid characters.";
                return;
            }

            else if (email == "")
            {
                ACError.Text = "Error: email needed.";
                return;
            }

            else if (Regex.IsMatch(email, @"[^a-zA-Z0-9._%+-@]") || Regex.IsMatch(email, @"^(?!.*[@.]).*$"))
            {
                ACError.Text = "Error: email contains invalid characters.";
                return;
            }

            int largest = 0;
            foreach (DataRow r in dataTable.Rows)
            {
                if (r["customer_id"] == DBNull.Value)
                    continue;

                int currentCategoryId = Convert.ToInt32(r["customer_id"]);

                if (currentCategoryId > largest)
                {
                    largest = currentCategoryId;
                }
            }

            DataRow row = dataTable.NewRow();
            row["customer_id"] = largest + 1;
            row["last_name"] = last_name;
            row["first_name"] = first_name;
            row["contact_phone"] = c_phone;
            row["e-mail"] = email;


            //use filterExpression to search for duplicates!
            string filterExpression = $"last_name = '{last_name}' AND " +
                           $"first_name = '{first_name}' AND " +
                           $"contact_phone = '{c_phone}' AND " +
                           $"[e-mail] = '{email}'";

            DataRow[] matchingRows = dataTable.Select(filterExpression);

            if (matchingRows.Length > 0)
            {
                ACError.Text = "Duplicate customer entry.";
                return;
            }

            ACError.Text = "";
            ACConfirm.Text = "Added Successfully!";
            add(row, workbook.Worksheets["CustomerInformation"]);

            ACBox1.Text = "";
            ACBox2.Text = "";
            ACBox3.Text = "";
            ACBox4.Text = "";
        }

        private void btnRefreshEquipmentList_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == DisplayEquipment)
            {
                dataTable = makeDataTable(workbook.Worksheets["RentalEquipment"]);
                dataGridViewEquipment.DataSource = dataTable;
            }
        }

        private void btnRefreshClientList_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == DisplayAllClients)
            {
                dataTable = makeDataTable(workbook.Worksheets["CustomerInformation"]);
                dataGridViewClients.DataSource = dataTable;
            }
        }



        private void button2_Click(object sender, EventArgs e)
        {
            DACError.Visible = false;
            DACSuccess.Visible = false;

            if (textBox1.Text == "") 
            {
                DACError.Visible = true;
                DACError.Text = "Error: Enter a name for the item!";
                return;
            }
            else if (richTextBox2.Text == "") 
            {
                DACError.Visible = true;
                DACError.Text = "Error: Enter a description for the item!";
                return;
            }
            DataRow row = dataTable.NewRow();
            row["name"] = textBox1.Text;
            row["category_ID"]=comboBox2.SelectedValue;
            row["description"]=richTextBox2.Text;
            row["daily_rate"] = comboBox3.Text;

            string prefix = Convert.ToString(comboBox2.SelectedValue);

            var filteredRows = dataTable.AsEnumerable()
                                    .Where(r => r.Field<string>("equipment_id").StartsWith(prefix));
            int maxValue = Convert.ToInt32(prefix + "0");
            if (filteredRows.Any())
                maxValue = filteredRows.Max(r => Convert.ToInt32(r.Field<string>("equipment_id")));

            row["equipment_id"] = maxValue + 1;

            add(row, workbook.Worksheets["RentalEquipment"]);
            DACSuccess.Visible = true;
            DACSuccess.Text = "Success!";

            textBox1.Clear();
            richTextBox2.Clear();
        }


        // force call event handler for tab check when the form loads.
        private void Form1_Load(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;
            tabControl1_SelectedIndexChanged(tabControl1, EventArgs.Empty);
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataRowView selectedRow = comboBox5.SelectedItem as DataRowView;

            if (selectedRow != null)
            {
                richTextBox3.Text = selectedRow["description"].ToString();
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            rentalLabelCost.Visible = false;
            timeError.Visible = false;

            DataRow row = dataTable.NewRow();

            DateTime thisDay = DateTime.Today;

            row["rental_id"] = comboBox1.Text;
            row["date"] = thisDay.ToString("yyyy-MM-dd");
            row["customer_id"] = comboBox4.SelectedValue;
            row["equipment_id"] = comboBox5.SelectedValue;

            DateTime rentalDate = DateTime.ParseExact(dateTimePicker1.Text, "MMMM d, yyyy", CultureInfo.InvariantCulture);

            row["rental_date"] = rentalDate.ToString("yyyy-MM-dd");

            DateTime returnDate = DateTime.ParseExact(dateTimePicker2.Text, "MMMM d, yyyy", CultureInfo.InvariantCulture);

            row["return_date"] = returnDate.ToString("yyyy-MM-dd");

            TimeSpan difference = returnDate - rentalDate;
            int daysDifference = (int)difference.TotalDays;
            if (daysDifference < 0)
            {
                timeError.Visible = true;
                return;
            }
            if (daysDifference == 0)
                daysDifference++;

            DataRow foundRow = dataTableAux.Select($"equipment_id = {Convert.ToInt32(comboBox5.SelectedValue)}").FirstOrDefault();
            var cost = (Convert.ToDecimal(foundRow["daily_rate"]) * Convert.ToDecimal(daysDifference)).ToString("F2");

            row["cost"] = cost;
            add(row, workbook.Worksheets["RentalInfo"]);

            rentalLabelCost.Visible = true;
            rentalLabelCost.Text = $"Success! Rental added for ${cost}.";

        }
    }
}