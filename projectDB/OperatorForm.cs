using DocumentFormat.OpenXml.Packaging;
using Microsoft.Office.Interop.Word;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;
using Table = DocumentFormat.OpenXml.Wordprocessing.Table;
using DataTable = System.Data.DataTable;

namespace projectDB
{
    public partial class OperatorForm : Form
    {
        public OperatorForm()
        {
            InitializeComponent();
        }

        public static List <DataGridView> dataGridViews = new List <DataGridView> ();

        private void OperatorForm_Load(object sender, EventArgs e)
        {
            

        }

        private void viewLetters_Click(object sender, EventArgs e)
        {
            int numberReports = Convert.ToInt32(numberLetters.Text);
            int numberRowsInDataGrid = Convert.ToInt32(numberBases.Text);
            foreach (var datagridView in dataGridViews)
            {
                Controls.Remove(datagridView);
            }
            dataGridViews.Clear();
            for (int i = 0; i < numberReports; i++)
            {
                DataGridView dataGridView = new DataGridView();
                //dataGridView.RowCount = numberReports - 1;
                dataGridView.Name = "letter" + (i + 1);
                dataGridView.Columns.Add("Number", "№");
                dataGridView.Columns.Add("DateTime", "Дата и время");
                dataGridView.Columns.Add("Freq", "Частота, МГц");
                dataGridView.Columns.Add("Period", "Период, мкс");
                dataGridView.Columns.Add("Time", "Длительность импульса, мкс");
                dataGridView.Columns.Add("RotationPeriod", "Период вращения");
                dataGridView.Columns.Add("Object", "Объект");
                dataGridView.Columns.Add("Source", "Источник");
                dataGridView.Columns.Add("Coordinates", "Координаты, град");
                dataGridView.Columns.Add("Other", "Примечание");
                dataGridView.ColumnHeadersHeight = 35;
                dataGridView.Columns[0].Width = 25;
                dataGridView.Columns[1].Width = 110;
                dataGridView.Columns[9].Width = 137;
                dataGridView.RowTemplate.Height = 140;
                dataGridView.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                dataGridView.Size = new System.Drawing.Size(1015, 150);
                dataGridView.Location = new System.Drawing.Point(20, 80 + 170 * i);
                //dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                
                this.Controls.Add(dataGridView);
                dataGridView.CurrentCell = null;
                dataGridView.DoubleClick += dataCellDoubleClick();
                dataGridViews.Add(dataGridView);
            }
        }

        private void dataCellDoubleClick(object sender, EventArgs e)
        {
            numberBases.Text = "norm";
            string path = "C:\\Temp\\доклад поста1.docx";
            string a = e.ToString();
            using (var doc = WordprocessingDocument.Open(path, true))
            {
                // To create a temporary table   
                DataTable dt = new DataTable();
                int rowCount = 0;

                // Find the first table in the document.   
                Table table = doc.MainDocumentPart.Document.Body.Elements<Table>().First();

                // To get all rows from table  
                IEnumerable<TableRow> rows = table.Elements<TableRow>();

                // To read data from rows and to add records to the temporary table  
                foreach (TableRow row in rows)
                {
                    if (rowCount == 0)
                    {
                        foreach (TableCell cell in row.Descendants<TableCell>())
                        {
                            dt.Columns.Add(cell.InnerText);
                        }
                        rowCount += 1;
                    }
                    else
                    {
                        dt.Rows.Add();
                        int i = 0;
                        foreach (TableCell cell in row.Descendants<TableCell>())
                        {
                            dt.Rows[dt.Rows.Count - 1][i] = cell.InnerText;
                            i++;
                        }
                    }
                }
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    
                }
                StringBuilder stringBuilder = new StringBuilder();
                for (int i = 0; i < dt.Rows.Count; i++) //looping through all rows including the column. change `i=1` if need to exclude the columns display
                {
                    for (int j = 0; j < dt.Columns.Count; j++) //looping through all columns
                    {
                        stringBuilder.Append(dt.Rows[i][j] + "\r\n");
                        
                    }
                }

                output.Text = stringBuilder.ToString();
                // To display the result   
                // Bind datatable(temporary table) to the datagridview   
                //dgvTable.DataSource = dt;
            }


        }
    }
}
