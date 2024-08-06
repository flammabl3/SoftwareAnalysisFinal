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
        public Form1()
        {
            InitializeComponent();

            //use an OfficeOpenXml ExceLPackage object to open the xlsx file.
            string filePath = @"../../data.xlsx";
            FileInfo xlsxFile = new FileInfo(filePath);
            if (!File.Exists(filePath))
            {
                Console.WriteLine("File not found.");
                return;
            }

            ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;
            package = new ExcelPackage(xlsxFile);
            workbook = package.Workbook;

            tabControl1.SelectedIndex = 0;
        }

        //control pages with tabControl1. Load a different worksheet from the xlsx depending on what tab is loaded.
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == AddEquipment)
            {
                dataTable = makeDataTable(workbook.Worksheets["RentalEquipment"]);
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

                comboBox1.DisplayMember = "DisplayColumn";
                comboBox1.ValueMember = "name";

                comboBox1.DataSource = dataTable;
            } else if (tabControl1.SelectedTab == AddClient)
            {
                dataTable = makeDataTable(workbook.Worksheets["CustomerInformation"]);
            }
            else if (tabControl1.SelectedTab == DisplayEquipment || tabControl1.SelectedTab == AddRentalItems)
            {
                dataTable = makeDataTable(workbook.Worksheets["RentalEquipment"]);
            }
            else if (tabControl1.SelectedTab == DisplayAllClients)
            {
                dataTable = makeDataTable(workbook.Worksheets["CustomerInformation"]);
                dataTable = makeDataTable(workbook.Worksheets[3]);
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
            DataRowView selectedRow = comboBox1.SelectedItem as DataRowView;

            if (selectedRow != null)
            {
                richTextBox1.Text = selectedRow["description"].ToString();
            }
        }


        // The delete button. We take the selected row from the combo box, and then remove it from the current datatable. Then we get the worksheet again, clear it
        //replace the values, and update the datatable
        //then save back to the xlsx and update the combobox.

        private void button1_Click(object sender, EventArgs e)
        {
            DataRowView selectedRow = comboBox1.SelectedItem as DataRowView;
            if (selectedRow != null)
            {
                delete(selectedRow.Row, workbook.Worksheets["RentalEquipment"]);

                package.Save();

                selectedRow = comboBox1.SelectedItem as DataRowView;
                if (selectedRow != null)
                {
                    richTextBox1.Text = selectedRow["description"].ToString();
                }
            }
        }

        private void delete(DataRow row, ExcelWorksheet worksheet)
        {
            DataTable dataTable = row.Table;
            dataTable.Rows.Remove(row);
            dataTable.Columns.Remove("DisplayColumn");

            worksheet.Cells.Clear();
            worksheet.Cells[1, 1].LoadFromDataTable(dataTable, true);
            dataTable = makeDataTable(worksheet);
        }

        private void add()
        {

        }

        private void update()
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
