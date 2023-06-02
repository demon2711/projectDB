

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace projectDB
{
    public partial class Search : Form
    {
        string path = "usersdata.db";
        private void Create_db()
        {
            if (!System.IO.File.Exists(path))
            {
                SQLiteConnection.CreateFile(path);
                using (var sqlite = new SQLiteConnection(@"Data Source=" + path))
                {
                    sqlite.Open();
                    string sql = "create table ObjectSource(Id varchar(20), Object varchar(200), Source varchar(200), FreqFrom varchar(20), FreqBefore varchar(20), Period1 varchar(20), Period2 varchar(20), Period3 varchar(20), Period4 varchar(20), Period5 varchar(20), Period6 varchar(20), Period7 varchar(20), Period8 varchar(20), Period9 varchar(20), Period10 varchar(20), Impulse1 varchar(20), Impulse2 varchar(20), Impulse3 varchar(20), Impulse4 varchar(20), Impulse5 varchar(20), Impulse6 varchar(20), Impulse7 varchar(20), Impulse8 varchar(20), Impulse9 varchar(20), Impulse10 varchar(20), Allowance1 varchar(20), Allowance2 varchar(20))";
                    SQLiteCommand command = new SQLiteCommand(sql, sqlite);
                    command.ExecuteNonQuery();
                }
            }
            else
            {
                Console.WriteLine("БД уже создана!");
                return;
            }
        }

        public Search()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Create_db();
        }

        private void button5_Click(object sender, EventArgs e)
        {

            Program.addAndEdit.Show();
            this.Hide();
        }
    }
}
