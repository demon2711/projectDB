using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projectDB
{
    public partial class AddAndEdit : Form
    {

        string path = "usersdata.db";
        string cs = @"URI=file:" + Application.StartupPath + "\\usersdata.db";

        SQLiteConnection con;
        SQLiteCommand cmd;
        SQLiteDataReader dr;


        private void data_show()
        {
            var con = new SQLiteConnection(cs);
            con.Open();

            string query = "SELECT * FROM ObjectSource";
            var cmd = new SQLiteCommand(query, con);
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                dataDB.Rows.Insert(0, dr.GetString(1), dr.GetString(2));
            }
            dr.Close();
        }

        


        public AddAndEdit()
        {
            InitializeComponent();
        }

        private void BackToSearch_Click(object sender, EventArgs e)
        {
            Program.search.Show();
            this.Hide();
        }

        private void AddAndEdit_Load(object sender, EventArgs e)
        {
            data_show();
        }


        //кнопка добавления
        private void Add_Click(object sender, EventArgs e)
        {
            var con = new SQLiteConnection(cs);
            con.Open();
            var cmd = new SQLiteCommand(con);

            cmd.CommandText = "INSERT INTO ObjectSource(Id, Object, Source, FreqFrom, " +
                "FreqBefore, Period1, Period2, Period3, Period4, Period5, Period6, Period7, " +
                "Period8, Period9, Period10, Impulse1, Impulse2, Impulse3, Impulse4, Impulse5, " +
                "Impulse6, Impulse7, Impulse8, Impulse9, Impulse10, Allowance1, Allowance2)" +
                "VALUES(@Id, @ObjectDB, @SourceDB, @FreqFrom, @FreqBefore, " +
                "@Period1, @Period2, @Period3, @Period4, @Period5, @Period6, @Period7, @Period8, @Period9," +
                "@Period10, @Impulse1, @Impulse2, @Impulse3, @Impulse4, @Impulse5, @Impulse6, @Impulse7," +
                "@Impulse8, @Impulse9, @Impulse10, @Allowance1, @Allowance2)";

            string Id = (dataDB.RowCount).ToString();

            string ObjectDB = objectDB.Text;
            string SourceDB = sourceDB.Text;
            string FreqFrom = freqFrom.Text;
            string FreqBefore = freqBefore.Text;
            string Period1 = T1.Text;
            string Period2 = T2.Text;
            string Period3 = T3.Text;
            string Period4 = T4.Text;
            string Period5 = T5.Text;
            string Period6 = T6.Text;
            string Period7 = T7.Text;
            string Period8 = T8.Text;
            string Period9 = T9.Text;
            string Period10 = T10.Text;
            string Impulse1 = timeImp1.Text;
            string Impulse2 = timeImp2.Text;
            string Impulse3 = timeImp3.Text;
            string Impulse4 = timeImp4.Text;
            string Impulse5 = timeImp5.Text;
            string Impulse6 = timeImp6.Text;
            string Impulse7 = timeImp7.Text;
            string Impulse8 = timeImp8.Text;
            string Impulse9 = timeImp9.Text;
            string Impulse10 = timeImp10.Text;
            string Allowance1 = toleranceT.Text;
            string Allowance2 = toleranceTime.Text;

            cmd.Parameters.AddWithValue("@Id", Id);
            cmd.Parameters.AddWithValue("@ObjectDB", ObjectDB);
            cmd.Parameters.AddWithValue("@SourceDB", SourceDB);
            cmd.Parameters.AddWithValue("@FreqFrom", FreqFrom);
            cmd.Parameters.AddWithValue("@FreqBefore", FreqBefore);

            cmd.Parameters.AddWithValue("@Period1", Period1);
            cmd.Parameters.AddWithValue("@Period2", Period2);
            cmd.Parameters.AddWithValue("@Period3", Period3);
            cmd.Parameters.AddWithValue("@Period4", Period4);
            cmd.Parameters.AddWithValue("@Period5", Period5);
            cmd.Parameters.AddWithValue("@Period6", Period6);
            cmd.Parameters.AddWithValue("@Period7", Period7);
            cmd.Parameters.AddWithValue("@Period8", Period8);
            cmd.Parameters.AddWithValue("@Period9", Period9);
            cmd.Parameters.AddWithValue("@Period10", Period10);

            cmd.Parameters.AddWithValue("@Impulse1", Impulse1);
            cmd.Parameters.AddWithValue("@Impulse2", Impulse2);
            cmd.Parameters.AddWithValue("@Impulse3", Impulse3);
            cmd.Parameters.AddWithValue("@Impulse4", Impulse4);
            cmd.Parameters.AddWithValue("@Impulse5", Impulse5);
            cmd.Parameters.AddWithValue("@Impulse6", Impulse6);
            cmd.Parameters.AddWithValue("@Impulse7", Impulse7);
            cmd.Parameters.AddWithValue("@Impulse8", Impulse8);
            cmd.Parameters.AddWithValue("@Impulse9", Impulse9);
            cmd.Parameters.AddWithValue("@Impulse10", Impulse10);

            cmd.Parameters.AddWithValue("@Allowance1", Allowance1);
            cmd.Parameters.AddWithValue("@Allowance2", Allowance2);

            dataDB.ColumnCount = 2;
            dataDB.Columns[0].Name = "Объект";
            dataDB.Columns[1].Name = "Источник";
            string[] row = new string[] { ObjectDB, SourceDB };
            dataDB.Rows.Add(row);
            cmd.ExecuteNonQuery();

            
            objectDB.Text = null;
            sourceDB.Text = null;
            freqFrom.Text = null;
            freqBefore.Text = null;
            T1.Text = null;
            T2.Text = null;
            T3.Text = null;
            T4.Text = null;
            T5.Text = null;
            T6.Text = null;
            T7.Text = null;
            T8.Text = null;
            T9.Text = null;
            T10.Text = null;
            timeImp1.Text = null;
            timeImp2.Text = null;
            timeImp3.Text = null;
            timeImp4.Text = null;
            timeImp5.Text = null;
            timeImp6.Text = null;
            timeImp7.Text = null;
            timeImp8.Text = null;
            timeImp9.Text = null;
            timeImp10.Text = null;
            toleranceT.Text = null;
            toleranceTime.Text = null;


        }

        private void textBox21_TextChanged(object sender, EventArgs e)
        {

        }

        private void Edit_Click(object sender, EventArgs e)
        {
            var con = new SQLiteConnection(cs);
            con.Open();
            var cmd = new SQLiteCommand(con);
            cmd.CommandText = "UPDATE ObjectSource Set Object=@ObjectDB, Source=@SourceDB, FreqFrom=@FreqFrom," +
                "FreqBefore=@FreqBefore, Period1=@Period1, Period2=@Period2, Period3=@Period3," +
                " Period4=@Period4, Period5=@Period5, Period6=@Period6, Period7=@Period7, Period8=@Period8," +
                " Period9=@Period9, Period10=@Period10, Impulse1=@Impulse1, Impulse2=@Impulse2," +
                " Impulse3=@Impulse3, Impulse4=@Impulse4, Impulse5=@Impulse5, Impulse6=@Impulse6," +
                " Impulse7=@Impulse7, Impulse8=@Impulse8, Impulse9=@Impulse9, Impulse10=@Impulse10," +
                "Allowance1=@Allowance1, Allowance1=@Allowance1 where Id = @Id";
            cmd.Prepare();

            string ObjectDB = objectDB.Text;
            string SourceDB = sourceDB.Text;
            string FreqFrom = freqFrom.Text;
            string FreqBefore = freqBefore.Text;
            string Period1 = T1.Text;
            string Period2 = T2.Text;
            string Period3 = T3.Text;
            string Period4 = T4.Text;
            string Period5 = T5.Text;
            string Period6 = T6.Text;
            string Period7 = T7.Text;
            string Period8 = T8.Text;
            string Period9 = T9.Text;
            string Period10 = T10.Text;
            string Impulse1 = timeImp1.Text;
            string Impulse2 = timeImp2.Text;
            string Impulse3 = timeImp3.Text;
            string Impulse4 = timeImp4.Text;
            string Impulse5 = timeImp5.Text;
            string Impulse6 = timeImp6.Text;
            string Impulse7 = timeImp7.Text;
            string Impulse8 = timeImp8.Text;
            string Impulse9 = timeImp9.Text;
            string Impulse10 = timeImp10.Text;
            string Allowance1 = toleranceT.Text;
            string Allowance2 = toleranceTime.Text;

            var connection = new SQLiteConnection(cs);
            connection.Open();
            var command = new SQLiteCommand(connection);


            cmd.Parameters.AddWithValue("@Id", Id);
            cmd.Parameters.AddWithValue("@ObjectDB", ObjectDB);
            cmd.Parameters.AddWithValue("@SourceDB", SourceDB);
            cmd.Parameters.AddWithValue("@FreqFrom", FreqFrom);
            cmd.Parameters.AddWithValue("@FreqBefore", FreqBefore);

            cmd.Parameters.AddWithValue("@Period1", Period1);
            cmd.Parameters.AddWithValue("@Period2", Period2);
            cmd.Parameters.AddWithValue("@Period3", Period3);
            cmd.Parameters.AddWithValue("@Period4", Period4);
            cmd.Parameters.AddWithValue("@Period5", Period5);
            cmd.Parameters.AddWithValue("@Period6", Period6);
            cmd.Parameters.AddWithValue("@Period7", Period7);
            cmd.Parameters.AddWithValue("@Period8", Period8);
            cmd.Parameters.AddWithValue("@Period9", Period9);
            cmd.Parameters.AddWithValue("@Period10", Period10);

            cmd.Parameters.AddWithValue("@Impulse1", Impulse1);
            cmd.Parameters.AddWithValue("@Impulse2", Impulse2);
            cmd.Parameters.AddWithValue("@Impulse3", Impulse3);
            cmd.Parameters.AddWithValue("@Impulse4", Impulse4);
            cmd.Parameters.AddWithValue("@Impulse5", Impulse5);
            cmd.Parameters.AddWithValue("@Impulse6", Impulse6);
            cmd.Parameters.AddWithValue("@Impulse7", Impulse7);
            cmd.Parameters.AddWithValue("@Impulse8", Impulse8);
            cmd.Parameters.AddWithValue("@Impulse9", Impulse9);
            cmd.Parameters.AddWithValue("@Impulse10", Impulse10);

            cmd.Parameters.AddWithValue("@Allowance1", Allowance1);
            cmd.Parameters.AddWithValue("@Allowance2", Allowance2);
        }
    }
}
