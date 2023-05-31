using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projectDB
{
    public partial class AddAndEdit : Form
    {
        
        public AddAndEdit()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Program.search.Show();
            this.Hide();
        }

        private void AddAndEdit_Load(object sender, EventArgs e)
        {

        }
    }
}
