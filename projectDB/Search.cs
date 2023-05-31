

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
    public partial class Search : Form
    {
        
        
        
        public Search()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (var connection = new SQLiteConnection("Data Source=usersdata.db; Cache=Shared; Mode=ReadWriteCreate;"))
            {
                connection.Open();
            }
            Console.Read();
        }

        private void button5_Click(object sender, EventArgs e)
        {

            Program.addAndEdit.Show();
            this.Hide();
        }
    }
}
