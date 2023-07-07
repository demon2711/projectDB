using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.ModelConfiguration.Configuration;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace projectDB
{
    public partial class AddAndEdit : Form
    {

        string path = "usersdata.db";
        string cs = @"URI=file:" + Application.StartupPath + "\\usersdata.db";

        SQLiteConnection con;
        SQLiteCommand cmd;
        SQLiteDataReader dr;
        public static string NowNumber;
        public static string NameObject;

        private void data_show()
        {
            var con = new SQLiteConnection(cs);
            con.Open();
            string query = "";
            if (radioButtonAir.Checked == true)
            {
                query = "SELECT * FROM ObjectSource";
            }
            else if (radioButtonEarth.Checked == true)
            {
                query = "SELECT * FROM ObjectSourceGround";
            }
            else
            {
                query = "SELECT * FROM ObjectSourceSea";
            }
            var cmd = new SQLiteCommand(query, con);
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                dataDB.Rows.Insert(dataDB.RowCount-1, dr.GetString(1), dr.GetString(2));
            }
            dr.Close();
            dataDB.ClearSelection();
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
            
            radioButtonAir.Checked = true;
            //data_show();   
        }


        //кнопка добавления
        private void Add_Click(object sender, EventArgs e)
        {
            if (freqFrom.Text == "" || freqBefore.Text == "")
            {
                MessageBox.Show("Введите значения частот!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (T1.Text == "" && T2.Text == "" && T3.Text == "" && T4.Text == "" && T5.Text == "" &&
                T6.Text == "" && T7.Text == "" && T8.Text == "" && T9.Text == "" && T10.Text == "")
            {
                MessageBox.Show("Введите хотя-бы одно значение периода!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string fileName;
            string path = "";
            if (pictureObj.ImageLocation != null) {
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
                path = Environment.CurrentDirectory + "\\Фотографии\\" + fileName;
                while (File.Exists(path))
                {
                    path = path.Insert(path.Length - 4, "_");
                }
                File.Copy(pictureObj.ImageLocation, path);
            }

            var con = new SQLiteConnection(cs);
            con.Open();
            var cmd = new SQLiteCommand(con);

            if (radioButtonAir.Checked == true)
            {
                cmd.CommandText = "INSERT INTO ObjectSource(id, Object, Source, FreqFrom, " +
                    "FreqBefore, Period1, Period2, Period3, Period4, Period5, Period6, Period7, " +
                    "Period8, Period9, Period10, Impulse1, Impulse2, Impulse3, Impulse4, Impulse5, " +
                    "Impulse6, Impulse7, Impulse8, Impulse9, Impulse10, TolerancePeriod1, " +
                    "TolerancePeriod2, TolerancePeriod3, TolerancePeriod4, TolerancePeriod5, " +
                    "TolerancePeriod6, TolerancePeriod7, TolerancePeriod8, TolerancePeriod9, " +
                    "TolerancePeriod10, ToleranceTime1, ToleranceTime2, ToleranceTime3, " +
                    "ToleranceTime4, ToleranceTime5, ToleranceTime6, ToleranceTime7, " +
                    "ToleranceTime8, ToleranceTime9, ToleranceTime10, Picture, " +
                    "NickName, CodeZA, CodeIKAO, Speed, RLO, MinHeightLimit, MaxHeightLimit, MainArmament, " +
                    "Purpose, OtherParam, Path)" +
                    "VALUES(@Id, @ObjectDB, @SourceDB, @FreqFrom, @FreqBefore, " +
                    "@Period1, @Period2, @Period3, @Period4, @Period5, @Period6, @Period7, @Period8, @Period9," +
                    "@Period10, @Impulse1, @Impulse2, @Impulse3, @Impulse4, @Impulse5, @Impulse6, @Impulse7," +
                    "@Impulse8, @Impulse9, @Impulse10, @TolerancePeriod1, " +
                    "@TolerancePeriod2, @TolerancePeriod3, @TolerancePeriod4, @TolerancePeriod5, " +
                    "@TolerancePeriod6, @TolerancePeriod7, @TolerancePeriod8, @TolerancePeriod9, " +
                    "@TolerancePeriod10, @ToleranceTime1, @ToleranceTime2, @ToleranceTime3, " +
                    "@ToleranceTime4, @ToleranceTime5, @ToleranceTime6, @ToleranceTime7, " +
                    "@ToleranceTime8, @ToleranceTime9, @ToleranceTime10, " +
                    "@Picture, @NickName, @CodeZA, " +
                    "@CodeIKAO, @Speed, @RLO, @MinHeightLimit, @MaxHeightLimit, @MainArmament, @Purpose, @OtherParam, @Path)";

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

                string picturePath = path;
                string NickName = nickName.Text;
                string CodeZA = codeZA.Text;
                string CodeIKAO = codeIKAO.Text;
                string Speed = speed.Text;
                string rlo = RLO.Text;
                string minLimit = minHeightLimit.Text;
                string maxLimit = maxHeightLimit.Text;
                string armament = mainArmament.Text;
                string Purpose = purpose.Text;
                string OtherParam = otherParam.Text;
                string PathRLC = pathRLC.Text;

                if (PathRLC == null)
                {
                    PathRLC = "";
                }

                if (picturePath == null)
                {
                    picturePath = "";
                }

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

                cmd.Parameters.AddWithValue("@Picture", picturePath);
                cmd.Parameters.AddWithValue("@NickName", NickName);
                cmd.Parameters.AddWithValue("@CodeZA", CodeZA);
                cmd.Parameters.AddWithValue("@CodeIKAO", CodeIKAO);
                cmd.Parameters.AddWithValue("@Speed", Speed);
                cmd.Parameters.AddWithValue("@RLO", rlo);
                cmd.Parameters.AddWithValue("@MinHeightLimit", minLimit);
                cmd.Parameters.AddWithValue("@MaxHeightLimit", maxLimit);
                cmd.Parameters.AddWithValue("@MainArmament", armament);
                cmd.Parameters.AddWithValue("@Purpose", Purpose);
                cmd.Parameters.AddWithValue("@OtherParam", OtherParam);
                cmd.Parameters.AddWithValue("@Path", PathRLC);

                cmd.ExecuteNonQuery();
            }
            else if (radioButtonEarth.Checked == true)
            {
                cmd.CommandText = "INSERT INTO ObjectSourceGround(id, Object, Source, FreqFrom, " +
                    "FreqBefore, Period1, Period2, Period3, Period4, Period5, Period6, Period7, " +
                    "Period8, Period9, Period10, Impulse1, Impulse2, Impulse3, Impulse4, Impulse5, " +
                    "Impulse6, Impulse7, Impulse8, Impulse9, Impulse10, TolerancePeriod1, " +
                    "TolerancePeriod2, TolerancePeriod3, TolerancePeriod4, TolerancePeriod5, " +
                    "TolerancePeriod6, TolerancePeriod7, TolerancePeriod8, TolerancePeriod9, " +
                    "TolerancePeriod10, ToleranceTime1, ToleranceTime2, ToleranceTime3, " +
                    "ToleranceTime4, ToleranceTime5, ToleranceTime6, ToleranceTime7, " +
                    "ToleranceTime8, ToleranceTime9, ToleranceTime10, Picture, " +
                    "NickName, Sizes, Weight, Type, Purpose, Specification, Path)" +
                    "VALUES(@Id, @ObjectDB, @SourceDB, @FreqFrom, @FreqBefore, " +
                    "@Period1, @Period2, @Period3, @Period4, @Period5, @Period6, @Period7, @Period8, @Period9," +
                    "@Period10, @Impulse1, @Impulse2, @Impulse3, @Impulse4, @Impulse5, @Impulse6, @Impulse7," +
                    "@Impulse8, @Impulse9, @Impulse10, @TolerancePeriod1, " +
                    "@TolerancePeriod2, @TolerancePeriod3, @TolerancePeriod4, @TolerancePeriod5, " +
                    "@TolerancePeriod6, @TolerancePeriod7, @TolerancePeriod8, @TolerancePeriod9, " +
                    "@TolerancePeriod10, @ToleranceTime1, @ToleranceTime2, @ToleranceTime3, " +
                    "@ToleranceTime4, @ToleranceTime5, @ToleranceTime6, @ToleranceTime7, " +
                    "@ToleranceTime8, @ToleranceTime9, @ToleranceTime10, " +
                    "@Picture, @NickName, @Sizes, " +
                    "@Weight, @Type, @Purpose, @Specification, @Path)";

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

                string picturePath = path;
                string NickName = nickNameEarth.Text;
                string Sizes = sizes.Text;
                string Weight = weight.Text;
                string Type = type.Text;
                string PurposeEarth = purposeEarth.Text;
                string Specification = Information.Text;
                string PathRLC = pathRLC.Text;

                if (PathRLC == null)
                {
                    PathRLC = "";
                }

                if (picturePath == null)
                {
                    picturePath = "";
                }

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

                cmd.Parameters.AddWithValue("@Picture", picturePath);
                cmd.Parameters.AddWithValue("@NickName", NickName);
                cmd.Parameters.AddWithValue("@Sizes", Sizes);
                cmd.Parameters.AddWithValue("@Weight", Weight);
                cmd.Parameters.AddWithValue("@Type", Type);
                cmd.Parameters.AddWithValue("@Purpose", PurposeEarth);
                cmd.Parameters.AddWithValue("@Specification", Specification);
                cmd.Parameters.AddWithValue("@Path", PathRLC);

                cmd.ExecuteNonQuery();
            }

            else if (radioButtonSea.Checked == true)
            {
                cmd.CommandText = "INSERT INTO ObjectSourceSea(id, Object, Source, FreqFrom, " +
                    "FreqBefore, Period1, Period2, Period3, Period4, Period5, Period6, Period7, " +
                    "Period8, Period9, Period10, Impulse1, Impulse2, Impulse3, Impulse4, Impulse5, " +
                    "Impulse6, Impulse7, Impulse8, Impulse9, Impulse10, TolerancePeriod1, " +
                    "TolerancePeriod2, TolerancePeriod3, TolerancePeriod4, TolerancePeriod5, " +
                    "TolerancePeriod6, TolerancePeriod7, TolerancePeriod8, TolerancePeriod9, " +
                    "TolerancePeriod10, ToleranceTime1, ToleranceTime2, ToleranceTime3, " +
                    "ToleranceTime4, ToleranceTime5, ToleranceTime6, ToleranceTime7, " +
                    "ToleranceTime8, ToleranceTime9, ToleranceTime10, Picture, " +
                    "NickName, LengthShip, HeightShip, Displacement, MMSI, Description, Information, Path)" +
                    "VALUES(@Id, @ObjectDB, @SourceDB, @FreqFrom, @FreqBefore, " +
                    "@Period1, @Period2, @Period3, @Period4, @Period5, @Period6, @Period7, @Period8, @Period9," +
                    "@Period10, @Impulse1, @Impulse2, @Impulse3, @Impulse4, @Impulse5, @Impulse6, @Impulse7," +
                    "@Impulse8, @Impulse9, @Impulse10, @TolerancePeriod1, " +
                    "@TolerancePeriod2, @TolerancePeriod3, @TolerancePeriod4, @TolerancePeriod5, " +
                    "@TolerancePeriod6, @TolerancePeriod7, @TolerancePeriod8, @TolerancePeriod9, " +
                    "@TolerancePeriod10, @ToleranceTime1, @ToleranceTime2, @ToleranceTime3, " +
                    "@ToleranceTime4, @ToleranceTime5, @ToleranceTime6, @ToleranceTime7, " +
                    "@ToleranceTime8, @ToleranceTime9, @ToleranceTime10, " +
                    "@Picture, @NickName, @LengthShip, " +
                    "@HeightShip, @Displacement, @MMSI, @Description, @Information, @Path)";

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

                string picturePath = path;
                string NickName = nickNameSea.Text;


                string LengthShip = lengthShip.Text;
                string HeightShip = label100.Text;
                string Displacement = displacement.Text;
                string MMSI = codeMMSI.Text;
                string Description = description.Text;
                string Information = informationSea.Text;
                string PathRLC = pathRLC.Text;

                if (PathRLC == null)
                {
                    PathRLC = "";
                }


                if (picturePath == null)
                {
                    picturePath = "";
                }

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

                cmd.Parameters.AddWithValue("@Picture", picturePath);
                cmd.Parameters.AddWithValue("@NickName", NickName);
                cmd.Parameters.AddWithValue("@LengthShip", LengthShip);
                cmd.Parameters.AddWithValue("@HeightShip", HeightShip);
                cmd.Parameters.AddWithValue("@Displacement", Displacement);
                cmd.Parameters.AddWithValue("@MMSI", MMSI);
                cmd.Parameters.AddWithValue("@Description", Description);
                cmd.Parameters.AddWithValue("@Information", Information);
                cmd.Parameters.AddWithValue("@Path", PathRLC);

                cmd.ExecuteNonQuery();
            }

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
            toleranceTime1.Text = null;
            toleranceTime2.Text = null;
            toleranceTime3.Text = null;
            toleranceTime4.Text = null;
            toleranceTime5.Text = null;
            toleranceTime6.Text = null;
            toleranceTime7.Text = null;
            toleranceTime8.Text = null;
            toleranceTime9.Text = null;
            toleranceTime10.Text = null;
            tolerancePeriod1.Text = null;
            tolerancePeriod2.Text = null;
            tolerancePeriod3.Text = null;
            tolerancePeriod4.Text = null;
            tolerancePeriod5.Text = null;
            tolerancePeriod6.Text = null;
            tolerancePeriod7.Text = null;
            tolerancePeriod8.Text = null;
            tolerancePeriod9.Text = null;
            tolerancePeriod10.Text = null;
            nickName.Text = null;
            codeIKAO.Text = null;
            codeZA.Text = null;
            mainArmament.Text = null;
            pictureObj.Image = null;
            otherParam.Text = null;
            purpose.Text = null;
            minHeightLimit.Text = null;
            maxHeightLimit.Text = null;
            speed.Text = null;
            RLO.Text = null;
            sizes.Text = null;
            weight.Text = null;
            type.Text = null;
            Information.Text = null;
            nickNameEarth.Text = null;
            purposeEarth.Text = null;
            codeMMSI.Text = null;
            nickNameSea.Text = null;
            lengthShip.Text = null;
            label100.Text = null;
            description.Text = null;
            displacement.Text = null;
            informationSea.Text = null;

            dataDB.Rows.Clear();
            data_show();

            
        }
        
        private void Edit_Click(object sender, EventArgs e)
        {            
            if (radioButtonAir.Checked == true)
            {
                Edit edit = new Edit();
                edit.Show();
            }
            else if (radioButtonEarth.Checked == true)
            {
                EditEarth editEarth = new EditEarth();
                editEarth.Show();
            }
            else if (radioButtonSea.Checked == true) 
            {
                EditSea editSea = new EditSea();
                editSea.Show();
            }            
            Close();
        }

        private void DataGridCellClick(object sender, DataGridViewCellEventArgs e)
        {
            try 
            {
                dataDB.CurrentRow.Selected = true;
                NowNumber = (e.RowIndex).ToString();
                int b = dataDB.Rows.Count;
                int c = e.RowIndex;
                string a = NowNumber;
                NameObject = dataDB[0, e.RowIndex].Value.ToString();
            }
            catch
            {
                return;
            }
            //(dataDB.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            
        }

        private void DataGridDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ViewDB viewDB = new ViewDB();
            viewDB.Show();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (dataDB.Rows.Count == 1)
            {
                MessageBox.Show("Нечего удалять, так как в таблице нет записей!", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var con = new SQLiteConnection(cs);
            con.Open();
            
            int count = Convert.ToInt32(NowNumber);
            NameObject = dataDB[0, count].Value.ToString();
            int numberID = Convert.ToInt32(NowNumber) + 1;
            string task = "";
            if (radioButtonAir.Checked == true)
            {
                task = "SELECT * FROM ObjectSource WHERE id=" + numberID;
            }
            else if (radioButtonEarth.Checked == true)
            {
                task = "SELECT * FROM ObjectSourceGround WHERE id=" + numberID;
            }
            else if (radioButtonSea.Checked == true)
            {
                task = "SELECT * FROM ObjectSourceSea WHERE id=" + numberID;
            }
            SQLiteDataReader dr;
            var cmd = new SQLiteCommand(task, con);
            dr = cmd.ExecuteReader();
            string path = "";
            while (dr.Read())
            {      
                path = dr.GetString(45);     
            }
            dr.Close();
            if (path != "")
            {
                File.Delete(path);
            }
            if (radioButtonAir.Checked == true)
            {
                task = "DELETE FROM ObjectSource WHERE id=" + numberID;
            }
            else if (radioButtonEarth.Checked == true)
            {
                task = "DELETE FROM ObjectSourceGround WHERE id=" + numberID;
            }
            else if (radioButtonSea.Checked == true)
            {
                task = "DELETE FROM ObjectSourceSea WHERE id=" + numberID;
            }
            
            cmd.CommandText = task;
            cmd.ExecuteNonQuery();

            if (radioButtonAir.Checked == true)
            {
                task = "UPDATE ObjectSource Set id = id - 1 where id >" + numberID;
            }
            else if (radioButtonEarth.Checked == true)
            {
                task = "UPDATE ObjectSourceGround Set id = id - 1 where id >" + numberID;
            }
            else if (radioButtonSea.Checked == true)
            {
                task = "UPDATE ObjectSourceSea Set id = id - 1 where id >" + numberID;
            }
            
            cmd.CommandText = task;
            cmd.ExecuteNonQuery();

            dataDB.Rows.Clear();
            data_show();



            /*AddAndEdit addAndEdit = new AddAndEdit();
            addAndEdit.Show();
            
            this.Close();*/
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

            /*string fileName;
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
            string path = Environment.CurrentDirectory + "\\Фотографии\\" + fileName;
            while (File.Exists(path))
            {
                path = path.Insert(path.Length - 4, "_");
            }
            File.Copy(pictureObj.ImageLocation, path);
            /*pictureObj.Image = Image.FromFile(path);
            pictureObj.ImageLocation = path;*/
        }

        


        //переключение текстовых форм дополнительной информации
        private void checkedAirButton(object sender, EventArgs e)
        {
            if (radioButtonAir.Checked == true)
            {
                dataDB.Rows.Clear();
                nickName.Visible = true;
                codeIKAO.Visible = true;
                codeZA.Visible = true;
                speed.Visible = true;
                purpose.Visible = true;
                RLO.Visible = true;
                mainArmament.Visible = true;
                minHeightLimit.Visible = true;
                maxHeightLimit.Visible = true;
                otherParam.Visible = true;
                label37.Visible = true;
                label38.Visible = true;
                label32.Visible = true;
                label36.Visible = true;
                label35.Visible = true;
                label17.Visible = true;
                label34.Visible = true;
                label33.Visible = true;
                label31.Visible = true;
                label18.Visible = true;
                label23.Visible = true;
                label24.Visible = true;
                label19.Visible = true;
                label20.Visible = true;
                label25.Visible = true;
                label21.Visible = true;
                label26.Visible = true;
                label22.Visible = true;
                label30.Visible = true;
                label28.Visible = true;
                label29.Visible = true;
                label27.Visible = true;

                //скрытие текстовых форм для земли

                nickNameEarth.Visible = false;
                purposeEarth.Visible = false;
                sizes.Visible = false;
                Information.Visible = false;
                weight.Visible = false;
                type.Visible = false;
                label72.Visible = false;
                label65.Visible = false;
                label67.Visible = false;
                label63.Visible = false;
                label64.Visible = false;
                label66.Visible = false;
                label74.Visible = false;
                label76.Visible = false;
                label73.Visible = false;
                label75.Visible = false;
                label70.Visible = false;
                label68.Visible = false;
                label71.Visible = false;
                label69.Visible = false;


                nickNameSea.Visible = false;
                codeMMSI.Visible = false;
                lengthShip.Visible = false;
                heightShip.Visible = false;
                label100.Visible = false;
                displacement.Visible = false;
                description.Visible = false;
                informationSea.Visible = false;
                label87.Visible = false;
                label81.Visible = false;
                label86.Visible = false;
                label85.Visible = false;
                label90.Visible = false;
                label89.Visible = false;
                label91.Visible = false;
                label88.Visible = false;
                label100.Visible = false;
                label80.Visible = false;
                label77.Visible = false;
                label83.Visible = false;
                label78.Visible = false;
                label79.Visible = false;
                label84.Visible = false;


                
                data_show();
            }
        }

        private void checkedEarthButton(object sender, EventArgs e)
        {
            if (radioButtonEarth.Checked == true)
            {
                dataDB.Rows.Clear();
                nickNameEarth.Visible = true;
                purposeEarth.Visible = true;
                sizes.Visible = true;
                Information.Visible = true;
                weight.Visible = true;
                type.Visible = true;
                label72.Visible = true;
                label65.Visible = true;
                label67.Visible = true;
                label63.Visible = true;
                label64.Visible = true;
                label66.Visible = true;
                label74.Visible = true;
                label76.Visible = true;
                label73.Visible = true;
                label75.Visible = true;
                label70.Visible = true;
                label68.Visible = true;
                label71.Visible = true;
                label69.Visible = true;


                //скрытие текстовых форм для воздуха

                nickName.Visible = false;
                codeIKAO.Visible = false;
                codeZA.Visible = false;
                speed.Visible = false;
                purpose.Visible = false;
                RLO.Visible = false;
                mainArmament.Visible = false;
                minHeightLimit.Visible = false;
                maxHeightLimit.Visible = false;
                otherParam.Visible = false;
                label37.Visible = false;
                label38.Visible = false;
                label32.Visible = false;
                label36.Visible = false;
                label35.Visible = false;
                label17.Visible = false;
                label34.Visible = false;
                label33.Visible = false;
                label31.Visible = false;
                label18.Visible = false;
                label23.Visible = false;
                label24.Visible = false;
                label19.Visible = false;
                label20.Visible = false;
                label25.Visible = false;
                label21.Visible = false;
                label26.Visible = false;
                label22.Visible = false;
                label30.Visible = false;
                label28.Visible = false;
                label29.Visible = false;
                label27.Visible = false;

                nickNameSea.Visible = false;
                codeMMSI.Visible = false;
                lengthShip.Visible = false;
                label100.Visible = false;
                displacement.Visible = false;
                description.Visible = false;
                informationSea.Visible = false;
                label87.Visible = false;
                label81.Visible = false;
                label86.Visible = false;
                label85.Visible = false;
                label90.Visible = false;
                label89.Visible = false;
                label91.Visible = false;
                label88.Visible = false;
                label100.Visible = false;
                label80.Visible = false;
                label77.Visible = false;
                label83.Visible = false;
                label78.Visible = false;
                label79.Visible = false;
                label84.Visible = false;
                
                data_show();
            }
        }

        private void checkedSeaButton(object sender, EventArgs e)
        {
            if (radioButtonSea.Checked)
            {
                dataDB.Rows.Clear();
                nickNameSea.Visible = true;
                codeMMSI.Visible = true;
                lengthShip.Visible = true;
                heightShip.Visible = true;
                label100.Visible = true;
                displacement.Visible = true;
                description.Visible = true;
                informationSea.Visible = true;
                label87.Visible = true;
                label81.Visible = true;
                label86.Visible = true;
                label85.Visible = true;
                label90.Visible = true;
                label89.Visible = true;
                label91.Visible = true;
                label88.Visible = true;
                label100.Visible = true;
                label80.Visible = true;
                label77.Visible = true;
                label83.Visible = true;
                label78.Visible = true;
                label79.Visible = true;
                label84.Visible = true;


                nickName.Visible = false;
                codeIKAO.Visible = false;
                codeZA.Visible = false;
                speed.Visible = false;
                purpose.Visible = false;
                RLO.Visible = false;
                mainArmament.Visible = false;
                minHeightLimit.Visible = false;
                maxHeightLimit.Visible = false;
                otherParam.Visible = false;
                label37.Visible = false;
                label38.Visible = false;
                label32.Visible = false;
                label36.Visible = false;
                label35.Visible = false;
                label17.Visible = false;
                label34.Visible = false;
                label33.Visible = false;
                label31.Visible = false;
                label18.Visible = false;
                label23.Visible = false;
                label24.Visible = false;
                label19.Visible = false;
                label20.Visible = false;
                label25.Visible = false;
                label21.Visible = false;
                label26.Visible = false;
                label22.Visible = false;
                label30.Visible = false;
                label28.Visible = false;
                label29.Visible = false;
                label27.Visible = false;

                nickNameEarth.Visible = false;
                purposeEarth.Visible = false;
                sizes.Visible = false;
                Information.Visible = false;
                weight.Visible = false;
                type.Visible = false;
                label72.Visible = false;
                label65.Visible = false;
                label67.Visible = false;
                label63.Visible = false;
                label64.Visible = false;
                label66.Visible = false;
                label74.Visible = false;
                label76.Visible = false;
                label73.Visible = false;
                label75.Visible = false;
                label70.Visible = false;
                label68.Visible = false;
                label71.Visible = false;
                label69.Visible = false;

                data_show();
            }

        }

        private void checkTextBox1(object sender, EventArgs e)
        {
            string valueTextBox = tolerancePeriod1.Text;
            if (valueTextBox != "")
            {
                tolerancePeriod1.Text = valueTextBox.Replace('.', ',');
            }
        }

        private void checkTextBox2(object sender, EventArgs e)
        {
            string valueTextBox = tolerancePeriod2.Text;
            if (valueTextBox != "")
            {
                tolerancePeriod2.Text = valueTextBox.Replace('.', ',');
            }
        }

        private void checkTextBox3(object sender, EventArgs e)
        {
            string valueTextBox = tolerancePeriod3.Text;
            if (valueTextBox != "")
            {
                tolerancePeriod3.Text = valueTextBox.Replace('.', ',');
            }
        }

        private void checkTextBox4(object sender, EventArgs e)
        {
            string valueTextBox = tolerancePeriod4.Text;
            if (valueTextBox != "")
            {
                tolerancePeriod4.Text = valueTextBox.Replace('.', ',');
            }
        }

        private void checkTextBox5(object sender, EventArgs e)
        {
            string valueTextBox = tolerancePeriod5.Text;
            if (valueTextBox != "")
            {
                tolerancePeriod5.Text = valueTextBox.Replace('.', ',');
            }
        }

        private void checkTextBox6(object sender, EventArgs e)
        {
            string valueTextBox = tolerancePeriod6.Text;
            if (valueTextBox != "")
            {
                tolerancePeriod6.Text = valueTextBox.Replace('.', ',');
            }
        }

        private void checkTextBox7(object sender, EventArgs e)
        {
            string valueTextBox = tolerancePeriod7.Text;
            if (valueTextBox != "")
            {
                tolerancePeriod7.Text = valueTextBox.Replace('.', ',');
            }
        }

        private void checkTextBox8(object sender, EventArgs e)
        {
            string valueTextBox = tolerancePeriod8.Text;
            if (valueTextBox != "")
            {
                tolerancePeriod8.Text = valueTextBox.Replace('.', ',');
            }
        }

        private void checkTextBox9(object sender, EventArgs e)
        {
            string valueTextBox = tolerancePeriod9.Text;
            if (valueTextBox != "")
            {
                tolerancePeriod9.Text = valueTextBox.Replace('.', ',');
            }
        }

        private void checkTextBox10(object sender, EventArgs e)
        {
            string valueTextBox = tolerancePeriod10.Text;
            if (valueTextBox != "")
            {
                tolerancePeriod10.Text = valueTextBox.Replace('.', ',');
            }
        }

        private void checkTextBoxTime1(object sender, EventArgs e)
        {
            string valueTextBox = toleranceTime1.Text;
            if (valueTextBox != "")
            {
                toleranceTime1.Text = valueTextBox.Replace('.', ',');
            }
        }

        private void checkTextBoxTime2(object sender, EventArgs e)
        {
            string valueTextBox = toleranceTime2.Text;
            if (valueTextBox != "")
            {
                toleranceTime2.Text = valueTextBox.Replace('.', ',');
            }
        }

        private void checkTextBoxTime3(object sender, EventArgs e)
        {
            string valueTextBox = toleranceTime3.Text;
            if (valueTextBox != "")
            {
                toleranceTime3.Text = valueTextBox.Replace('.', ',');
            }
        }

        private void checkTextBoxTime4(object sender, EventArgs e)
        {
            string valueTextBox = toleranceTime4.Text;
            if (valueTextBox != "")
            {
                toleranceTime4.Text = valueTextBox.Replace('.', ',');
            }
        }

        private void checkTextBoxTime5(object sender, EventArgs e)
        {
            string valueTextBox = toleranceTime5.Text;
            if (valueTextBox != "")
            {
                toleranceTime5.Text = valueTextBox.Replace('.', ',');
            }
        }

        private void checkTextBoxTime6(object sender, EventArgs e)
        {
            string valueTextBox = toleranceTime6.Text;
            if (valueTextBox != "")
            {
                toleranceTime6.Text = valueTextBox.Replace('.', ',');
            }
        }

        private void checkTextBoxTime7(object sender, EventArgs e)
        {
            string valueTextBox = toleranceTime7.Text;
            if (valueTextBox != "")
            {
                toleranceTime7.Text = valueTextBox.Replace('.', ',');
            }
        }

        private void checkTextBoxTime8(object sender, EventArgs e)
        {
            string valueTextBox = toleranceTime8.Text;
            if (valueTextBox != "")
            {
                toleranceTime8.Text = valueTextBox.Replace('.', ',');
            }
        }

        private void checkTextBoxTime9(object sender, EventArgs e)
        {
            string valueTextBox = toleranceTime9.Text;
            if (valueTextBox != "")
            {
                toleranceTime9.Text = valueTextBox.Replace('.', ',');
            }
        }

        private void checkTextBoxTime10(object sender, EventArgs e)
        {
            string valueTextBox = toleranceTime10.Text;
            if (valueTextBox != "")
            {
                toleranceTime10.Text = valueTextBox.Replace('.', ',');
            }
        }

        private void checkTextBoxPeriod1(object sender, EventArgs e)
        {
            string valueTextBox = T1.Text;
            if (valueTextBox != "")
            {
                T1.Text = valueTextBox.Replace('.', ',');
            }
        }

        private void checkTextBoxPeriod2(object sender, EventArgs e)
        {
            string valueTextBox = T2.Text;
            if (valueTextBox != "")
            {
                T2.Text = valueTextBox.Replace('.', ',');
            }
        }

        private void checkTextBoxPeriod3(object sender, EventArgs e)
        {
            string valueTextBox = T3.Text;
            if (valueTextBox != "")
            {
                T3.Text = valueTextBox.Replace('.', ',');
            }
        }

        private void checkTextBoxPeriod4(object sender, EventArgs e)
        {
            string valueTextBox = T4.Text;
            if (valueTextBox != "")
            {
                T4.Text = valueTextBox.Replace('.', ',');
            }
        }

        private void checkTextBoxPeriod5(object sender, EventArgs e)
        {
            string valueTextBox = T5.Text;
            if (valueTextBox != "")
            {
                T5.Text = valueTextBox.Replace('.', ',');
            }
        }

        private void checkTextBoxPeriod6(object sender, EventArgs e)
        {
            string valueTextBox = T6.Text;
            if (valueTextBox != "")
            {
                T6.Text = valueTextBox.Replace('.', ',');
            }
        }

        private void checkTextBoxPeriod7(object sender, EventArgs e)
        {
            string valueTextBox = T7.Text;
            if (valueTextBox != "")
            {
                T7.Text = valueTextBox.Replace('.', ',');
            }
        }

        private void checkTextBoxPeriod8(object sender, EventArgs e)
        {
            string valueTextBox = T8.Text;
            if (valueTextBox != "")
            {
                T8.Text = valueTextBox.Replace('.', ',');
            }
        }

        private void checkTextBoxPeriod9(object sender, EventArgs e)
        {
            string valueTextBox = T9.Text;
            if (valueTextBox != "")
            {
                T9.Text = valueTextBox.Replace('.', ',');
            }
        }

        private void checkTextBoxPeriod10(object sender, EventArgs e)
        {
            string valueTextBox = T10.Text;
            if (valueTextBox != "")
            {
                T10.Text = valueTextBox.Replace('.', ',');
            }
        }

        private void checkTextBoxImpulse1(object sender, EventArgs e)
        {
            string valueTextBox = timeImp1.Text;
            if (valueTextBox != "")
            {
                timeImp1.Text = valueTextBox.Replace('.', ',');
            }
        }

        private void checkTextBoxImpulse2(object sender, EventArgs e)
        {
            string valueTextBox = timeImp2.Text;
            if (valueTextBox != "")
            {
                timeImp2.Text = valueTextBox.Replace('.', ',');
            }
        }

        private void checkTextBoxImpulse3(object sender, EventArgs e)
        {
            string valueTextBox = timeImp3.Text;
            if (valueTextBox != "")
            {
                timeImp3.Text = valueTextBox.Replace('.', ',');
            }
        }

        private void checkTextBoxImpulse4(object sender, EventArgs e)
        {
            string valueTextBox = timeImp4.Text;
            if (valueTextBox != "")
            {
                timeImp4.Text = valueTextBox.Replace('.', ',');
            }
        }

        private void checkTextBoxImpulse5(object sender, EventArgs e)
        {
            string valueTextBox = timeImp5.Text;
            if (valueTextBox != "")
            {
                timeImp5.Text = valueTextBox.Replace('.', ',');
            }
        }

        private void checkTextBoxImpulse6(object sender, EventArgs e)
        {
            string valueTextBox = timeImp6.Text;
            if (valueTextBox != "")
            {
                timeImp6.Text = valueTextBox.Replace('.', ',');
            }
        }

        private void checkTextBoxImpulse7(object sender, EventArgs e)
        {
            string valueTextBox = timeImp7.Text;
            if (valueTextBox != "")
            {
                timeImp7.Text = valueTextBox.Replace('.', ',');
            }
        }

        private void checkTextBoxImpulse8(object sender, EventArgs e)
        {
            string valueTextBox = timeImp8.Text;
            if (valueTextBox != "")
            {
                timeImp8.Text = valueTextBox.Replace('.', ',');
            }
        }

        private void checkTextBoxImpulse9(object sender, EventArgs e)
        {
            string valueTextBox = timeImp9.Text;
            if (valueTextBox != "")
            {
                timeImp9.Text = valueTextBox.Replace('.', ',');
            }
        }

        private void checkTextBoxImpulse10(object sender, EventArgs e)
        {
            string valueTextBox = timeImp10.Text;
            if (valueTextBox != "")
            {
                timeImp10.Text = valueTextBox.Replace('.', ',');
            }
        }

        private void replaceFreqFrom(object sender, EventArgs e)
        {
            string valueTextBox = freqFrom.Text;
            if (valueTextBox != "")
            {
                freqFrom.Text = valueTextBox.Replace('.', ',');
            }
        }

        private void replaceFreqBefore(object sender, EventArgs e)
        {
            string valueTextBox = freqBefore.Text;
            if (valueTextBox != "")
            {
                freqBefore.Text = valueTextBox.Replace('.', ',');
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
            //System.Diagnostics.Process.Start(Environment.CurrentDirectory + "\\Файлы сигналов РЛС\\test.txt");
        }

        private void pathRLC_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
