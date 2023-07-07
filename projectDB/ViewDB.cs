using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projectDB
{
    public partial class ViewDB : Form
    {
        string cs = @"URI=file:" + Application.StartupPath + "\\usersdata.db";
        SQLiteDataReader dr;
        public ViewDB()
        {
            InitializeComponent();
        }

        private void OK_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ViewDB_Load(object sender, EventArgs e)
        {
            var con = new SQLiteConnection(cs);
            con.Open();
            int count = Convert.ToInt32(AddAndEdit.NowNumber);
            
            string task = "SELECT * FROM ObjectSource WHERE Object=\'" + AddAndEdit.NameObject + "\'";
            
            var cmd = new SQLiteCommand(task, con);
            dr = cmd.ExecuteReader();
            List<string> values = new List<string>();
            int temp = dr.FieldCount;

            while (dr.Read())
            {
                
                for (int i = 1; i < dr.FieldCount; i++)
                    values.Add(dr.GetString(i));
            }
            dr.Close();

            objectDB.Text = values[0];
            SourceDB.Text = values[1];
            freqFrom.Text = values[2];
            freqBefore.Text = values[3];

            T1.Text = values[4];
            T2.Text = values[5];
            T3.Text = values[6];
            T4.Text = values[7];
            T5.Text = values[8];
            T6.Text = values[9];
            T7.Text = values[10];
            T8.Text = values[11];
            T9.Text = values[12];
            T10.Text = values[13];

            time1.Text = values[14];
            time2.Text = values[15];
            time3.Text = values[16];
            time4.Text = values[17];
            time5.Text = values[18];
            time6.Text = values[19];
            time7.Text = values[20];
            time8.Text = values[21];
            time9.Text = values[22];
            time10.Text = values[23];

            tolerance1.Text = values[24];
            tolerance2.Text = values[25];
        }

        private void T9_Click(object sender, EventArgs e)
        {

        }
    }
}
