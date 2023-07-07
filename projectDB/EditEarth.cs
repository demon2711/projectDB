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
    public partial class EditEarth : Form
    {
        public EditEarth()
        {
            InitializeComponent();
        }

        string cs = @"URI=file:" + Application.StartupPath + "\\usersdata.db";
        SQLiteDataReader dr;

        private void Ok_Click(object sender, EventArgs e)
        {
            var con = new SQLiteConnection(cs);
            con.Open();
            var cmd = new SQLiteCommand(con);
            int id = Convert.ToInt32(AddAndEdit.NowNumber) + 1;
            cmd.CommandText = "SELECT * FROM ObjectSourceGround WHERE id=" + id;
            SQLiteDataReader dr;
            dr = cmd.ExecuteReader();
            string path = "";
            while (dr.Read())
            {
                path = dr.GetString(45);
            }
            dr.Close();

            if (path != pictureObj.ImageLocation)
            {
                File.Delete(path);
                string fileName;
                int numberChar = 0;
                for (int i = pictureObj.ImageLocation.Length - 1; i > 0; i--)
                {
                    if (pictureObj.ImageLocation[i] == '\\')
                    {
                        numberChar = i + 1;
                        break;
                    }

                }
                fileName = pictureObj.ImageLocation.Substring(numberChar);
                string pathFolder = Environment.CurrentDirectory + "\\Фотографии\\" + fileName;
                while (File.Exists(path))
                {
                    pathFolder = pathFolder.Insert(pathFolder.Length - 4, "_");
                }
                File.Copy(pictureObj.ImageLocation, pathFolder);
                pictureObj.ImageLocation = pathFolder;
            }
            path = pictureObj.ImageLocation;
            cmd.CommandText = "UPDATE ObjectSourceGround Set Object=@ObjectDB, Source=@SourceDB, FreqFrom=@FreqFrom," +
                "FreqBefore=@FreqBefore, Period1=@period1, Period2=@period2, Period3=@period3," +
                " Period4=@period4, Period5=@period5, Period6=@period6, Period7=@period7, Period8=@period8," +
                " Period9=@period9, Period10=@period10, Impulse1=@impulse1, Impulse2=@impulse2," +
                " Impulse3=@impulse3, Impulse4=@impulse4, Impulse5=@impulse5, Impulse6=@impulse6," +
                " Impulse7=@impulse7, Impulse8=@impulse8, Impulse9=@impulse9, Impulse10=@impulse10," +
                " TolerancePeriod1=@TolerancePeriod1, " +
                "TolerancePeriod2=@TolerancePeriod2, TolerancePeriod3=@TolerancePeriod3, " +
                "TolerancePeriod4=@TolerancePeriod4, TolerancePeriod5=@TolerancePeriod5, " +
                "TolerancePeriod6=@TolerancePeriod6, TolerancePeriod7=@TolerancePeriod7, " +
                "TolerancePeriod8=@TolerancePeriod8, TolerancePeriod9=@TolerancePeriod9, " +
                "TolerancePeriod10=@TolerancePeriod10, ToleranceTime1=@ToleranceTime1, " +
                "ToleranceTime2=@ToleranceTime2, ToleranceTime3=@ToleranceTime3, " +
                "ToleranceTime4=@ToleranceTime4, ToleranceTime5=@ToleranceTime5, " +
                "ToleranceTime6=@ToleranceTime6, ToleranceTime7=@ToleranceTime7, " +
                "ToleranceTime8=@ToleranceTime8, ToleranceTime9=@ToleranceTime9, " +
                "ToleranceTime10=@ToleranceTime10, Picture=@Picture, NickName=@NickName, " +
                "Sizes=@Sizes, Weight=@Weight, Type=@Type, Purpose=@Purpose, " +
                "Specification=@Specification, Path=@Path WHERE id = @id";
            cmd.Prepare();

            string ObjectDB = objectDB.Text;
            string SourceDB = sourceDB.Text;
            string FreqFrom = freqFrom.Text;
            string FreqBefore = freqBefore.Text;

            string period1 = Period1.Text;
            string period2 = Period2.Text;
            string period3 = Period3.Text;
            string period4 = Period4.Text;
            string period5 = Period5.Text;
            string period6 = Period6.Text;
            string period7 = Period7.Text;
            string period8 = Period8.Text;
            string period9 = Period9.Text;

            string period10 = Period10.Text;
            string impulse1 = Impulse1.Text;
            string impulse2 = Impulse2.Text;
            string impulse3 = Impulse3.Text;
            string impulse4 = Impulse4.Text;
            string impulse5 = Impulse5.Text;
            string impulse6 = Impulse6.Text;
            string impulse7 = Impulse7.Text;
            string impulse8 = Impulse8.Text;
            string impulse9 = Impulse9.Text;
            string impulse10 = Impulse10.Text;

            string TolerancePeriod1 = tolerancePeriod1.Text;
            string TolerancePeriod2 = tolerancePeriod2.Text;
            string TolerancePeriod3 = tolerancePeriod3.Text;
            string TolerancePeriod4 = tolerancePeriod4.Text;
            string TolerancePeriod5 = tolerancePeriod5.Text;
            string TolerancePeriod6 = tolerancePeriod6.Text;
            string TolerancePeriod7 = tolerancePeriod7.Text;
            string TolerancePeriod8 = tolerancePeriod8.Text;
            string TolerancePeriod9 = tolerancePeriod9.Text;
            string TolerancePeriod10 = tolerancePeriod10.Text;

            string ToleranceTime1 = toleranceTime1.Text;
            string ToleranceTime2 = toleranceTime2.Text;
            string ToleranceTime3 = toleranceTime3.Text;
            string ToleranceTime4 = toleranceTime4.Text;
            string ToleranceTime5 = toleranceTime5.Text;
            string ToleranceTime6 = toleranceTime6.Text;
            string ToleranceTime7 = toleranceTime7.Text;
            string ToleranceTime8 = toleranceTime8.Text;
            string ToleranceTime9 = toleranceTime9.Text;
            string ToleranceTime10 = toleranceTime10.Text;

            string NickName = nickNameEarth.Text;
            string Sizes = sizes.Text;
            string Weight = weight.Text;
            string Type = type.Text;
            string Purpose = purpose.Text;
            string Specification = specification.Text;
            string PathRLC = pathRLC.Text;

            int count = Convert.ToInt32(AddAndEdit.NowNumber) + 1;
            cmd.Parameters.AddWithValue("@id", count);
            cmd.Parameters.AddWithValue("@ObjectDB", ObjectDB);
            cmd.Parameters.AddWithValue("@SourceDB", SourceDB);
            cmd.Parameters.AddWithValue("@FreqFrom", FreqFrom);
            cmd.Parameters.AddWithValue("@FreqBefore", FreqBefore);

            cmd.Parameters.AddWithValue("@Period1", period1);
            cmd.Parameters.AddWithValue("@Period2", period2);
            cmd.Parameters.AddWithValue("@Period3", period3);
            cmd.Parameters.AddWithValue("@Period4", period4);
            cmd.Parameters.AddWithValue("@Period5", period5);
            cmd.Parameters.AddWithValue("@Period6", period6);
            cmd.Parameters.AddWithValue("@Period7", period7);
            cmd.Parameters.AddWithValue("@Period8", period8);
            cmd.Parameters.AddWithValue("@Period9", period9);
            cmd.Parameters.AddWithValue("@Period10", period10);

            cmd.Parameters.AddWithValue("@Impulse1", impulse1);
            cmd.Parameters.AddWithValue("@Impulse2", impulse2);
            cmd.Parameters.AddWithValue("@Impulse3", impulse3);
            cmd.Parameters.AddWithValue("@Impulse4", impulse4);
            cmd.Parameters.AddWithValue("@Impulse5", impulse5);
            cmd.Parameters.AddWithValue("@Impulse6", impulse6);
            cmd.Parameters.AddWithValue("@Impulse7", impulse7);
            cmd.Parameters.AddWithValue("@Impulse8", impulse8);
            cmd.Parameters.AddWithValue("@Impulse9", impulse9);
            cmd.Parameters.AddWithValue("@Impulse10", impulse10);

            cmd.Parameters.AddWithValue("@TolerancePeriod1", TolerancePeriod1);
            cmd.Parameters.AddWithValue("@TolerancePeriod2", TolerancePeriod2);
            cmd.Parameters.AddWithValue("@TolerancePeriod3", TolerancePeriod3);
            cmd.Parameters.AddWithValue("@TolerancePeriod4", TolerancePeriod4);
            cmd.Parameters.AddWithValue("@TolerancePeriod5", TolerancePeriod5);
            cmd.Parameters.AddWithValue("@TolerancePeriod6", TolerancePeriod6);
            cmd.Parameters.AddWithValue("@TolerancePeriod7", TolerancePeriod7);
            cmd.Parameters.AddWithValue("@TolerancePeriod8", TolerancePeriod8);
            cmd.Parameters.AddWithValue("@TolerancePeriod9", TolerancePeriod9);
            cmd.Parameters.AddWithValue("@TolerancePeriod10", TolerancePeriod10);

            cmd.Parameters.AddWithValue("@ToleranceTime1", ToleranceTime1);
            cmd.Parameters.AddWithValue("@ToleranceTime2", ToleranceTime2);
            cmd.Parameters.AddWithValue("@ToleranceTime3", ToleranceTime3);
            cmd.Parameters.AddWithValue("@ToleranceTime4", ToleranceTime4);
            cmd.Parameters.AddWithValue("@ToleranceTime5", ToleranceTime5);
            cmd.Parameters.AddWithValue("@ToleranceTime6", ToleranceTime6);
            cmd.Parameters.AddWithValue("@ToleranceTime7", ToleranceTime7);
            cmd.Parameters.AddWithValue("@ToleranceTime8", ToleranceTime8);
            cmd.Parameters.AddWithValue("@ToleranceTime9", ToleranceTime9);
            cmd.Parameters.AddWithValue("@ToleranceTime10", ToleranceTime10);

            cmd.Parameters.AddWithValue("@Picture", path);

            cmd.Parameters.AddWithValue("@NickName", NickName);
            cmd.Parameters.AddWithValue("@Sizes", Sizes);
            cmd.Parameters.AddWithValue("@Weight", Weight);
            cmd.Parameters.AddWithValue("@Type", Type);
            cmd.Parameters.AddWithValue("Purpose", Purpose);
            cmd.Parameters.AddWithValue("@Specification", Specification);
            cmd.Parameters.AddWithValue("@Path", PathRLC);

            cmd.ExecuteNonQuery();
            AddAndEdit addAndEdit = new AddAndEdit();
            addAndEdit.Show();
            this.Close();
        }
    

        private void EditEarth_Load(object sender, EventArgs e)
        {
            var con = new SQLiteConnection(cs);
            con.Open();
            int count = Convert.ToInt32(AddAndEdit.NowNumber) + 1;
            string query = "SELECT * FROM ObjectSourceGround WHERE id=" + count;
            var cmd = new SQLiteCommand(query, con);
            dr = cmd.ExecuteReader();
            List<string> values = new List<string>();
            int temp = dr.FieldCount;

            while (dr.Read())
            {
                for (int i = 1; i < dr.FieldCount; i++)
                {
                    values.Add(dr.GetString(i));
                }
            }
            dr.Close();

            objectDB.Text = values[0];
            sourceDB.Text = values[1];
            freqFrom.Text = values[2];
            freqBefore.Text = values[3];

            Period1.Text = values[4];
            Period2.Text = values[5];
            Period3.Text = values[6];
            Period4.Text = values[7];
            Period5.Text = values[8];
            Period6.Text = values[9];
            Period7.Text = values[10];
            Period8.Text = values[11];
            Period9.Text = values[12];
            Period10.Text = values[13];

            Impulse1.Text = values[14];
            Impulse2.Text = values[15];
            Impulse3.Text = values[16];
            Impulse4.Text = values[17];
            Impulse5.Text = values[18];
            Impulse6.Text = values[19];
            Impulse7.Text = values[20];
            Impulse8.Text = values[21];
            Impulse9.Text = values[22];
            Impulse10.Text = values[23];

            tolerancePeriod1.Text = values[24];
            tolerancePeriod2.Text = values[25];
            tolerancePeriod3.Text = values[26];
            tolerancePeriod4.Text = values[27];
            tolerancePeriod5.Text = values[28];
            tolerancePeriod6.Text = values[29];
            tolerancePeriod7.Text = values[30];
            tolerancePeriod8.Text = values[31];
            tolerancePeriod9.Text = values[32];
            tolerancePeriod10.Text = values[33];

            toleranceTime1.Text = values[34];
            toleranceTime2.Text = values[35];
            toleranceTime3.Text = values[36];
            toleranceTime4.Text = values[37];
            toleranceTime5.Text = values[38];
            toleranceTime6.Text = values[39];
            toleranceTime7.Text = values[40];
            toleranceTime8.Text = values[41];
            toleranceTime9.Text = values[42];
            toleranceTime10.Text = values[43];

            pictureObj.ImageLocation = values[44];
            nickNameEarth.Text = values[45];
            sizes.Text = values[46];
            weight.Text = values[47];
            type.Text = values[48];
            purpose.Text = values[49];
            specification.Text = values[50];
            pathRLC.Text = values[51];
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            using (var openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image files (*.jpg, *.jpeg *.png) | *.jpg; *.jpeg; *.png";
                openFileDialog.InitialDirectory = Environment.CurrentDirectory;
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    pictureObj.Image = Image.FromFile(openFileDialog.FileName);
                    pictureObj.ImageLocation = openFileDialog.FileName;
                }
            }
        }

        private void freqFromReplace(object sender, EventArgs e)
        {
            string valueTextBox = freqFrom.Text;
            if (valueTextBox != "")
            {
                freqFrom.Text = valueTextBox.Replace('.', ',');
            }
        }

        private void freqBeforeReplace(object sender, EventArgs e)
        {
            string valueTextBox = freqBefore.Text;
            if (valueTextBox != "")
            {
                freqBefore.Text = valueTextBox.Replace('.', ',');
            }
        }

        private void replacePeriodValue1(object sender, EventArgs e)
        {
            string valueTextBox = Period1.Text;
            if (valueTextBox != "")
            {
                Period1.Text = valueTextBox.Replace('.', ',');
            }
        }

        private void replacePeriodValue2(object sender, EventArgs e)
        {
            string valueTextBox = Period2.Text;
            if (valueTextBox != "")
            {
                Period2.Text = valueTextBox.Replace('.', ',');
            }
        }

        private void replacePeriodValue3(object sender, EventArgs e)
        {
            string valueTextBox = Period3.Text;
            if (valueTextBox != "")
            {
                Period3.Text = valueTextBox.Replace('.', ',');
            }
        }

        private void replacePeriodValue4(object sender, EventArgs e)
        {
            string valueTextBox = Period4.Text;
            if (valueTextBox != "")
            {
                Period4.Text = valueTextBox.Replace('.', ',');
            }
        }

        private void replacePeriodValue5(object sender, EventArgs e)
        {
            string valueTextBox = Period5.Text;
            if (valueTextBox != "")
            {
                Period5.Text = valueTextBox.Replace('.', ',');
            }
        }

        private void replacePeriodValue6(object sender, EventArgs e)
        {
            string valueTextBox = Period6.Text;
            if (valueTextBox != "")
            {
                Period6.Text = valueTextBox.Replace('.', ',');
            }
        }

        private void replacePeriodValue7(object sender, EventArgs e)
        {
            string valueTextBox = Period7.Text;
            if (valueTextBox != "")
            {
                Period7.Text = valueTextBox.Replace('.', ',');
            }
        }

        private void replacePeriodValue8(object sender, EventArgs e)
        {
            string valueTextBox = Period8.Text;
            if (valueTextBox != "")
            {
                Period8.Text = valueTextBox.Replace('.', ',');
            }
        }

        private void replacePeriodValue9(object sender, EventArgs e)
        {
            string valueTextBox = Period9.Text;
            if (valueTextBox != "")
            {
                Period9.Text = valueTextBox.Replace('.', ',');
            }
        }

        private void replacePeriodValue10(object sender, EventArgs e)
        {
            string valueTextBox = Period10.Text;
            if (valueTextBox != "")
            {
                Period10.Text = valueTextBox.Replace('.', ',');
            }
        }

        private void replaceTimeValue1(object sender, EventArgs e)
        {
            string valueTextBox = Impulse1.Text;
            if (valueTextBox != "")
            {
                Impulse1.Text = valueTextBox.Replace('.', ',');
            }
        }

        private void replaceTimeValue2(object sender, EventArgs e)
        {
            string valueTextBox = Impulse2.Text;
            if (valueTextBox != "")
            {
                Impulse2.Text = valueTextBox.Replace('.', ',');
            }
        }

        private void replaceTimeValue3(object sender, EventArgs e)
        {
            string valueTextBox = Impulse3.Text;
            if (valueTextBox != "")
            {
                Impulse3.Text = valueTextBox.Replace('.', ',');
            }
        }

        private void replaceTimeValue4(object sender, EventArgs e)
        {
            string valueTextBox = Impulse4.Text;
            if (valueTextBox != "")
            {
                Impulse4.Text = valueTextBox.Replace('.', ',');
            }
        }

        private void replaceTimeValue5(object sender, EventArgs e)
        {
            string valueTextBox = Impulse5.Text;
            if (valueTextBox != "")
            {
                Impulse5.Text = valueTextBox.Replace('.', ',');
            }
        }

        private void replaceTimeValue6(object sender, EventArgs e)
        {
            string valueTextBox = Impulse6.Text;
            if (valueTextBox != "")
            {
                Impulse6.Text = valueTextBox.Replace('.', ',');
            }
        }

        private void replaceTimeValue7(object sender, EventArgs e)
        {
            string valueTextBox = Impulse7.Text;
            if (valueTextBox != "")
            {
                Impulse7.Text = valueTextBox.Replace('.', ',');
            }
        }

        private void replaceTimeValue8(object sender, EventArgs e)
        {
            string valueTextBox = Impulse8.Text;
            if (valueTextBox != "")
            {
                Impulse8.Text = valueTextBox.Replace('.', ',');
            }
        }

        private void replaceTimeValue9(object sender, EventArgs e)
        {
            string valueTextBox = Impulse9.Text;
            if (valueTextBox != "")
            {
                Impulse9.Text = valueTextBox.Replace('.', ',');
            }
        }

        private void replaceTimeValue10(object sender, EventArgs e)
        {
            string valueTextBox = Impulse10.Text;
            if (valueTextBox != "")
            {
                Impulse10.Text = valueTextBox.Replace('.', ',');
            }
        }

        private void replaceTimeTolerance1(object sender, EventArgs e)
        {
            string valueTextBox = tolerancePeriod1.Text;
            if (valueTextBox != "")
            {
                tolerancePeriod1.Text = valueTextBox.Replace('.', ',');
            }
        }

        private void replaceTimeTolerance2(object sender, EventArgs e)
        {
            string valueTextBox = tolerancePeriod2.Text;
            if (valueTextBox != "")
            {
                tolerancePeriod2.Text = valueTextBox.Replace('.', ',');
            }
        }

        private void replaceTimeTolerance3(object sender, EventArgs e)
        {
            string valueTextBox = tolerancePeriod3.Text;
            if (valueTextBox != "")
            {
                tolerancePeriod3.Text = valueTextBox.Replace('.', ',');
            }
        }

        private void replaceTimeTolerance4(object sender, EventArgs e)
        {
            string valueTextBox = tolerancePeriod4.Text;
            if (valueTextBox != "")
            {
                tolerancePeriod4.Text = valueTextBox.Replace('.', ',');
            }
        }

        private void replaceTimeTolerance5(object sender, EventArgs e)
        {
            string valueTextBox = tolerancePeriod5.Text;
            if (valueTextBox != "")
            {
                tolerancePeriod5.Text = valueTextBox.Replace('.', ',');
            }
        }

        private void replaceTimeTolerance6(object sender, EventArgs e)
        {
            string valueTextBox = tolerancePeriod6.Text;
            if (valueTextBox != "")
            {
                tolerancePeriod6.Text = valueTextBox.Replace('.', ',');
            }
        }

        private void replaceTimeTolerance7(object sender, EventArgs e)
        {
            string valueTextBox = tolerancePeriod7.Text;
            if (valueTextBox != "")
            {
                tolerancePeriod7.Text = valueTextBox.Replace('.', ',');
            }
        }

        private void replaceTimeTolerance8(object sender, EventArgs e)
        {
            string valueTextBox = tolerancePeriod8.Text;
            if (valueTextBox != "")
            {
                tolerancePeriod8.Text = valueTextBox.Replace('.', ',');
            }
        }

        private void replaceTimeTolerance9(object sender, EventArgs e)
        {
            string valueTextBox = tolerancePeriod9.Text;
            if (valueTextBox != "")
            {
                tolerancePeriod9.Text = valueTextBox.Replace('.', ',');
            }
        }

        private void replaceTimeTolerance10(object sender, EventArgs e)
        {
            string valueTextBox = tolerancePeriod10.Text;
            if (valueTextBox != "")
            {
                tolerancePeriod10.Text = valueTextBox.Replace('.', ',');
            }
        }

        private void replaceImpTolerance1(object sender, EventArgs e)
        {
            string valueTextBox = toleranceTime1.Text;
            if (valueTextBox != "")
            {
                toleranceTime1.Text = valueTextBox.Replace('.', ',');
            }
        }

        private void replaceImpTolerance2(object sender, EventArgs e)
        {
            string valueTextBox = toleranceTime2.Text;
            if (valueTextBox != "")
            {
                toleranceTime2.Text = valueTextBox.Replace('.', ',');
            }
        }

        private void replaceImpTolerance3(object sender, EventArgs e)
        {
            string valueTextBox = toleranceTime3.Text;
            if (valueTextBox != "")
            {
                toleranceTime3.Text = valueTextBox.Replace('.', ',');
            }
        }

        private void replaceImpTolerance4(object sender, EventArgs e)
        {
            string valueTextBox = toleranceTime4.Text;
            if (valueTextBox != "")
            {
                toleranceTime4.Text = valueTextBox.Replace('.', ',');
            }
        }

        private void replaceImpTolerance5(object sender, EventArgs e)
        {
            string valueTextBox = toleranceTime5.Text;
            if (valueTextBox != "")
            {
                toleranceTime5.Text = valueTextBox.Replace('.', ',');
            }
        }

        private void replaceImpTolerance6(object sender, EventArgs e)
        {
            string valueTextBox = toleranceTime6.Text;
            if (valueTextBox != "")
            {
                toleranceTime6.Text = valueTextBox.Replace('.', ',');
            }
        }

        private void replaceImpTolerance7(object sender, EventArgs e)
        {
            string valueTextBox = toleranceTime7.Text;
            if (valueTextBox != "")
            {
                toleranceTime7.Text = valueTextBox.Replace('.', ',');
            }
        }

        private void replaceImpTolerance8(object sender, EventArgs e)
        {
            string valueTextBox = toleranceTime8.Text;
            if (valueTextBox != "")
            {
                toleranceTime8.Text = valueTextBox.Replace('.', ',');
            }
        }

        private void replaceImpTolerance9(object sender, EventArgs e)
        {
            string valueTextBox = toleranceTime9.Text;
            if (valueTextBox != "")
            {
                toleranceTime9.Text = valueTextBox.Replace('.', ',');
            }
        }

        private void replaceImpTolerance10(object sender, EventArgs e)
        {
            string valueTextBox = toleranceTime10.Text;
            if (valueTextBox != "")
            {
                toleranceTime10.Text = valueTextBox.Replace('.', ',');
            }
        }

        private void pathRLCButton_Click(object sender, EventArgs e)
        {
            using (var openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = Environment.CurrentDirectory + "\\Файлы сигналов РЛС\\";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    pathRLC.Text = openFileDialog.FileName;
                }
            }
        }
    }
}
