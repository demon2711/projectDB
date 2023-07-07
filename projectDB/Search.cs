

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace projectDB
{
    public partial class Search : Form
    {
        string path = "usersdata.db";
        SQLiteDataReader dr;
        string cs = @"URI=file:" + Application.StartupPath + "\\usersdata.db";
        private void Create_db()
        {
            if (!System.IO.File.Exists(path))
            {
                SQLiteConnection.CreateFile(path);
                using (var sqlite = new SQLiteConnection(@"Data Source=" + path))
                {
                    sqlite.Open();
                    string sql = "create table ObjectSource(id integer, Object varchar(200), " +
                        "Source varchar(200), FreqFrom varchar(20), " +
                        "FreqBefore varchar(20), Period1 varchar(20), Period2 varchar(20), " +
                        "Period3 varchar(20), Period4 varchar(20), Period5 varchar(20), " +
                        "Period6 varchar(20), Period7 varchar(20), Period8 varchar(20), " +
                        "Period9 varchar(20), Period10 varchar(20), Impulse1 varchar(20), " +
                        "Impulse2 varchar(20), Impulse3 varchar(20), Impulse4 varchar(20), " +
                        "Impulse5 varchar(20), Impulse6 varchar(20), Impulse7 varchar(20), " +
                        "Impulse8 varchar(20), Impulse9 varchar(20), Impulse10 varchar(20), " +
                        "TolerancePeriod1 varchar(20), " +
                        "TolerancePeriod2 varchar(20), TolerancePeriod3 varchar(20), " +
                        "TolerancePeriod4 varchar(20), TolerancePeriod5 varchar(20), " +
                        "TolerancePeriod6 varchar(20), TolerancePeriod7 varchar(20), " +
                        "TolerancePeriod8 varchar(20), TolerancePeriod9 varchar(20), " +
                        "TolerancePeriod10 varchar(20), ToleranceTime1 varchar(20), " +
                        "ToleranceTime2 varchar(20), ToleranceTime3 varchar(20), " +
                        "ToleranceTime4 varchar(20), ToleranceTime5 varchar(20), " +
                        "ToleranceTime6 varchar(20), ToleranceTime7 varchar(20), " +
                        "ToleranceTime8 varchar(20), ToleranceTime9 varchar(20), " +
                        "ToleranceTime10 varchar(20), Picture varchar(10000), " +
                        "NickName varchar(100), CodeZA varchar(50), CodeIKAO varchar(50), " +
                        "Speed varchar(20), RLO varchar(100), MinHeightLimit varchar(20), " +
                        "MaxHeightLimit varchar(20), MainArmament varchar(20000), Purpose varchar(20000), " +
                        "OtherParam varchar(20000), Path varchar(500))";
                    SQLiteCommand command = new SQLiteCommand(sql, sqlite);
                    command.ExecuteNonQuery();

                    sql = "create table ObjectSourceGround(id integer, Object varchar(200), " +
                        "Source varchar(200), FreqFrom varchar(20), " +
                        "FreqBefore varchar(20), Period1 varchar(20), Period2 varchar(20), " +
                        "Period3 varchar(20), Period4 varchar(20), Period5 varchar(20), " +
                        "Period6 varchar(20), Period7 varchar(20), Period8 varchar(20), " +
                        "Period9 varchar(20), Period10 varchar(20), Impulse1 varchar(20), " +
                        "Impulse2 varchar(20), Impulse3 varchar(20), Impulse4 varchar(20), " +
                        "Impulse5 varchar(20), Impulse6 varchar(20), Impulse7 varchar(20), " +
                        "Impulse8 varchar(20), Impulse9 varchar(20), Impulse10 varchar(20), " +
                        "TolerancePeriod1 varchar(20), " +
                        "TolerancePeriod2 varchar(20), TolerancePeriod3 varchar(20), " +
                        "TolerancePeriod4 varchar(20), TolerancePeriod5 varchar(20), " +
                        "TolerancePeriod6 varchar(20), TolerancePeriod7 varchar(20), " +
                        "TolerancePeriod8 varchar(20), TolerancePeriod9 varchar(20), " +
                        "TolerancePeriod10 varchar(20), ToleranceTime1 varchar(20), " +
                        "ToleranceTime2 varchar(20), ToleranceTime3 varchar(20), " +
                        "ToleranceTime4 varchar(20), ToleranceTime5 varchar(20), " +
                        "ToleranceTime6 varchar(20), ToleranceTime7 varchar(20), " +
                        "ToleranceTime8 varchar(20), ToleranceTime9 varchar(20), " +
                        "ToleranceTime10 varchar(20), Picture varchar(10000), " +
                        "NickName varchar(100), Sizes varchar(100), Weight varchar(50), " +
                        "Type varchar(20), Purpose varchar(20000), Specification varchar(200000), " +
                        "Path varchar(500))";
                    command = new SQLiteCommand(sql, sqlite);
                    command.ExecuteNonQuery();

                    sql = "create table ObjectSourceSea(id integer, Object varchar(200), " +
                        "Source varchar(200), FreqFrom varchar(20), " +
                        "FreqBefore varchar(20), Period1 varchar(20), Period2 varchar(20), " +
                        "Period3 varchar(20), Period4 varchar(20), Period5 varchar(20), " +
                        "Period6 varchar(20), Period7 varchar(20), Period8 varchar(20), " +
                        "Period9 varchar(20), Period10 varchar(20), Impulse1 varchar(20), " +
                        "Impulse2 varchar(20), Impulse3 varchar(20), Impulse4 varchar(20), " +
                        "Impulse5 varchar(20), Impulse6 varchar(20), Impulse7 varchar(20), " +
                        "Impulse8 varchar(20), Impulse9 varchar(20), Impulse10 varchar(20), " +
                        "TolerancePeriod1 varchar(20), " +
                        "TolerancePeriod2 varchar(20), TolerancePeriod3 varchar(20), " +
                        "TolerancePeriod4 varchar(20), TolerancePeriod5 varchar(20), " +
                        "TolerancePeriod6 varchar(20), TolerancePeriod7 varchar(20), " +
                        "TolerancePeriod8 varchar(20), TolerancePeriod9 varchar(20), " +
                        "TolerancePeriod10 varchar(20), ToleranceTime1 varchar(20), " +
                        "ToleranceTime2 varchar(20), ToleranceTime3 varchar(20), " +
                        "ToleranceTime4 varchar(20), ToleranceTime5 varchar(20), " +
                        "ToleranceTime6 varchar(20), ToleranceTime7 varchar(20), " +
                        "ToleranceTime8 varchar(20), ToleranceTime9 varchar(20), " +
                        "ToleranceTime10 varchar(20), Picture varchar(10000), " +
                        "NickName varchar(100), LengthShip varchar(50), HeightShip varchar(50), " +
                        "Displacement varchar(2000), MMSI varchar(1000), Description varchar(200000), " +
                        "Information varchar(200000), Path varchar(500))";
                    command = new SQLiteCommand(sql, sqlite);
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

        private void Search_Load(object sender, EventArgs e)
        {
            Create_db();
            ActiveControl = label5;
            numberFreqCell.Text = "1";
            numberPeriodCell.Text = "1";
            numberImpulseCell.Text = "1";
            numberMatchFreq.Text = "1";
            numberMatchPeriod.Text = "1";
            numberMatchImpulse.Text = "1";
            

        }

        private void editMode_Click(object sender, EventArgs e)
        {
            if (!Program.addAndEdit.IsDisposed)
            {
                Program.addAndEdit.Show();
            }
            else
            {
                AddAndEdit addAndEdit = new AddAndEdit();
                Program.addAndEdit = addAndEdit;
                addAndEdit.Show();
            }
            this.Hide();
            ActiveControl = label5;
        }

        private void seeData_Click(object sender, EventArgs e)
        {
            DataBaseListInfo dataBaseListInfo = new DataBaseListInfo();
            dataBaseListInfo.Show();
            ActiveControl = label5;
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            

            var con = new SQLiteConnection(cs);
            con.Open();

            string query = "SELECT * FROM ObjectSource";
            var cmd = new SQLiteCommand(query, con);
            dr = cmd.ExecuteReader();

            List <InfoFromDB> infoFromDBAir = new List <InfoFromDB>();
            while (dr.Read())
            {
                InfoFromDB infoFromDB = new InfoFromDB();
                infoFromDB.Object = dr.GetString(1);
                infoFromDB.Source = dr.GetString(2);
                infoFromDB.freqFrom = dr.GetString(3);
                infoFromDB.freqBefore = dr.GetString(4);
                infoFromDB.t1 = dr.GetString(5);
                infoFromDB.t2 = dr.GetString(6);
                infoFromDB.t3 = dr.GetString(7);
                infoFromDB.t4 = dr.GetString(8);
                infoFromDB.t5 = dr.GetString(9);
                infoFromDB.t6 = dr.GetString(10);
                infoFromDB.t7 = dr.GetString(11);
                infoFromDB.t8 = dr.GetString(12);
                infoFromDB.t9 = dr.GetString(13);
                infoFromDB.t10 = dr.GetString(14);
                infoFromDB.time1 = dr.GetString(15);
                infoFromDB.time2 = dr.GetString(16);
                infoFromDB.time3 = dr.GetString(17);
                infoFromDB.time4 = dr.GetString(18);
                infoFromDB.time5 = dr.GetString(19);
                infoFromDB.time6 = dr.GetString(20);
                infoFromDB.time7 = dr.GetString(21);
                infoFromDB.time8 = dr.GetString(22);
                infoFromDB.time9 = dr.GetString(23);
                infoFromDB.time10 = dr.GetString(24);
                
                infoFromDB.tolerancePeriod1 = dr.GetString(25);
                infoFromDB.tolerancePeriod2 = dr.GetString(26);
                infoFromDB.tolerancePeriod3 = dr.GetString(27);
                infoFromDB.tolerancePeriod4 = dr.GetString(28);
                infoFromDB.tolerancePeriod5 = dr.GetString(29);
                infoFromDB.tolerancePeriod6 = dr.GetString(30);
                infoFromDB.tolerancePeriod7 = dr.GetString(31);
                infoFromDB.tolerancePeriod8 = dr.GetString(32);
                infoFromDB.tolerancePeriod9 = dr.GetString(33);
                infoFromDB.tolerancePeriod10 = dr.GetString(34);
                infoFromDB.toleranceTime1 = dr.GetString(35);
                infoFromDB.toleranceTime2 = dr.GetString(36);
                infoFromDB.toleranceTime3 = dr.GetString(37);
                infoFromDB.toleranceTime4 = dr.GetString(38);
                infoFromDB.toleranceTime5 = dr.GetString(39);
                infoFromDB.toleranceTime6 = dr.GetString(40);
                infoFromDB.toleranceTime7 = dr.GetString(41);
                infoFromDB.toleranceTime8 = dr.GetString(42);
                infoFromDB.toleranceTime9 = dr.GetString(43);
                infoFromDB.toleranceTime10 = dr.GetString(44);
                infoFromDB.picture = dr.GetString(45);
                infoFromDB.nickName = dr.GetString(46);
                infoFromDB.codeZA = dr.GetString(47);
                infoFromDB.codeIKAO = dr.GetString(48);
                infoFromDB.speed = dr.GetString(49);
                infoFromDB.rlo = dr.GetString(50);
                infoFromDB.minLimit = dr.GetString(51);
                infoFromDB.maxLimit = dr.GetString(52);
                infoFromDB.mainArmament = dr.GetString(53);
                infoFromDB.purpose = dr.GetString(54);
                infoFromDB.otherParam = dr.GetString(55);
                infoFromDB.path = dr.GetString(56);
                infoFromDBAir.Add(infoFromDB);
            }
            dr.Close();

            query = "SELECT * FROM ObjectSourceGround";
            cmd = new SQLiteCommand(query, con);
            dr = cmd.ExecuteReader();
            List<InfoFromDBEarth> infoFromDBEarth = new List<InfoFromDBEarth>();
            while (dr.Read())
            {
                InfoFromDBEarth infoFromDB = new InfoFromDBEarth();
                infoFromDB.Object = dr.GetString(1);
                infoFromDB.Source = dr.GetString(2);
                infoFromDB.freqFrom = dr.GetString(3);
                infoFromDB.freqBefore = dr.GetString(4);
                infoFromDB.t1 = dr.GetString(5);
                infoFromDB.t2 = dr.GetString(6);
                infoFromDB.t3 = dr.GetString(7);
                infoFromDB.t4 = dr.GetString(8);
                infoFromDB.t5 = dr.GetString(9);
                infoFromDB.t6 = dr.GetString(10);
                infoFromDB.t7 = dr.GetString(11);
                infoFromDB.t8 = dr.GetString(12);
                infoFromDB.t9 = dr.GetString(13);
                infoFromDB.t10 = dr.GetString(14);
                infoFromDB.time1 = dr.GetString(15);
                infoFromDB.time2 = dr.GetString(16);
                infoFromDB.time3 = dr.GetString(17);
                infoFromDB.time4 = dr.GetString(18);
                infoFromDB.time5 = dr.GetString(19);
                infoFromDB.time6 = dr.GetString(20);
                infoFromDB.time7 = dr.GetString(21);
                infoFromDB.time8 = dr.GetString(22);
                infoFromDB.time9 = dr.GetString(23);
                infoFromDB.time10 = dr.GetString(24);
                infoFromDB.tolerancePeriod1 = dr.GetString(25);
                infoFromDB.tolerancePeriod2 = dr.GetString(26);
                infoFromDB.tolerancePeriod3 = dr.GetString(27);
                infoFromDB.tolerancePeriod4 = dr.GetString(28);
                infoFromDB.tolerancePeriod5 = dr.GetString(29);
                infoFromDB.tolerancePeriod6 = dr.GetString(30);
                infoFromDB.tolerancePeriod7 = dr.GetString(31);
                infoFromDB.tolerancePeriod8 = dr.GetString(32);
                infoFromDB.tolerancePeriod9 = dr.GetString(33);
                infoFromDB.tolerancePeriod10 = dr.GetString(34);
                infoFromDB.toleranceTime1 = dr.GetString(35);
                infoFromDB.toleranceTime2 = dr.GetString(36);
                infoFromDB.toleranceTime3 = dr.GetString(37);
                infoFromDB.toleranceTime4 = dr.GetString(38);
                infoFromDB.toleranceTime5 = dr.GetString(39);
                infoFromDB.toleranceTime6 = dr.GetString(40);
                infoFromDB.toleranceTime7 = dr.GetString(41);
                infoFromDB.toleranceTime8 = dr.GetString(42);
                infoFromDB.toleranceTime9 = dr.GetString(43);
                infoFromDB.toleranceTime10 = dr.GetString(44);
                infoFromDB.picture = dr.GetString(45);
                infoFromDB.nickName = dr.GetString(46);
                infoFromDB.sizes = dr.GetString(47);
                infoFromDB.weight = dr.GetString(48);
                infoFromDB.type = dr.GetString(49);
                infoFromDB.purpose = dr.GetString(50);
                infoFromDB.specification = dr.GetString(51);
                infoFromDB.path = dr.GetString(52);

                infoFromDBEarth.Add(infoFromDB);
            }
            dr.Close();

            query = "SELECT * FROM ObjectSourceSea";
            cmd = new SQLiteCommand(query, con);
            dr = cmd.ExecuteReader();
            List<InfoFromDBSea> infoFromDBSea = new List<InfoFromDBSea>();
            while (dr.Read())
            {
                InfoFromDBSea infoFromDB = new InfoFromDBSea();
                infoFromDB.Object = dr.GetString(1);
                infoFromDB.Source = dr.GetString(2);
                infoFromDB.freqFrom = dr.GetString(3);
                infoFromDB.freqBefore = dr.GetString(4);
                infoFromDB.t1 = dr.GetString(5);
                infoFromDB.t2 = dr.GetString(6);
                infoFromDB.t3 = dr.GetString(7);
                infoFromDB.t4 = dr.GetString(8);
                infoFromDB.t5 = dr.GetString(9);
                infoFromDB.t6 = dr.GetString(10);
                infoFromDB.t7 = dr.GetString(11);
                infoFromDB.t8 = dr.GetString(12);
                infoFromDB.t9 = dr.GetString(13);
                infoFromDB.t10 = dr.GetString(14);
                infoFromDB.time1 = dr.GetString(15);
                infoFromDB.time2 = dr.GetString(16);
                infoFromDB.time3 = dr.GetString(17);
                infoFromDB.time4 = dr.GetString(18);
                infoFromDB.time5 = dr.GetString(19);
                infoFromDB.time6 = dr.GetString(20);
                infoFromDB.time7 = dr.GetString(21);
                infoFromDB.time8 = dr.GetString(22);
                infoFromDB.time9 = dr.GetString(23);
                infoFromDB.time10 = dr.GetString(24);
                infoFromDB.tolerancePeriod1 = dr.GetString(25);
                infoFromDB.tolerancePeriod2 = dr.GetString(26);
                infoFromDB.tolerancePeriod3 = dr.GetString(27);
                infoFromDB.tolerancePeriod4 = dr.GetString(28);
                infoFromDB.tolerancePeriod5 = dr.GetString(29);
                infoFromDB.tolerancePeriod6 = dr.GetString(30);
                infoFromDB.tolerancePeriod7 = dr.GetString(31);
                infoFromDB.tolerancePeriod8 = dr.GetString(32);
                infoFromDB.tolerancePeriod9 = dr.GetString(33);
                infoFromDB.tolerancePeriod10 = dr.GetString(34);
                infoFromDB.toleranceTime1 = dr.GetString(35);
                infoFromDB.toleranceTime2 = dr.GetString(36);
                infoFromDB.toleranceTime3 = dr.GetString(37);
                infoFromDB.toleranceTime4 = dr.GetString(38);
                infoFromDB.toleranceTime5 = dr.GetString(39);
                infoFromDB.toleranceTime6 = dr.GetString(40);
                infoFromDB.toleranceTime7 = dr.GetString(41);
                infoFromDB.toleranceTime8 = dr.GetString(42);
                infoFromDB.toleranceTime9 = dr.GetString(43);
                infoFromDB.toleranceTime10 = dr.GetString(44);
                infoFromDB.picture = dr.GetString(45);
                infoFromDB.nickName = dr.GetString(46);
                infoFromDB.lengthShip = dr.GetString(47);
                infoFromDB.heightShip = dr.GetString(48);
                infoFromDB.displacement = dr.GetString(49);
                infoFromDB.codeMMSI = dr.GetString(50);
                infoFromDB.description = dr.GetString(51);
                infoFromDB.information = dr.GetString(52);
                infoFromDB.path = dr.GetString(53);
                infoFromDBSea.Add(infoFromDB);
            }
            dr.Close();

            List<InfoFromDB> finalSelectedListAir = Selected(infoFromDBAir);
            List<InfoFromDBEarth> finalSelectedListEarth = Selected(infoFromDBEarth);
            List<InfoFromDBSea> finalSelectedListSea = Selected(infoFromDBSea);
            SearchList searchList = new SearchList(finalSelectedListAir, finalSelectedListEarth, finalSelectedListSea);
            searchList.Show();
            ActiveControl = label5;
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            freq1.Text = "";
            freq2.Text = "";
            freq3.Text = "";
            freq4.Text = "";
            freq5.Text = "";
            freq6.Text = "";
            freq7.Text = "";
            freq8.Text = "";
            freq9.Text = "";
            freq10.Text = "";

            T1.Text = "";
            T2.Text = "";
            T3.Text = "";
            T4.Text = "";
            T5.Text = "";
            T6.Text = "";
            T7.Text = "";
            T8.Text = "";
            T9.Text = "";
            T10.Text = "";

            time1.Text = "";
            time2.Text = "";
            time3.Text = "";
            time4.Text = "";
            time5.Text = "";
            time6.Text = "";
            time7.Text = "";
            time8.Text = "";
            time9.Text = "";
            time10.Text = "";

            periodAntenna.Text = "";
        }

        
        private List<InfoFromDB> Selected(List<InfoFromDB> infoFromDBs)
        {
            List<InfoFromDB> finalSelectedList = new List<InfoFromDB>();
            int countTrueFreq;
            int countTruePeriod;
            int countTrueImpulse;
            foreach (var oneOfTheList in infoFromDBs)
            {
                countTrueFreq = 0;
                countTrueImpulse = 0;
                countTruePeriod = 0;

                List<string> stringsFreq = new List<string>
                {
                    oneOfTheList.freqFrom,
                    oneOfTheList.freqBefore
                };

                List<string> stringsFreqForm = new List<string>
                {
                    freq1.Text,
                    freq2.Text,
                    freq3.Text,
                    freq4.Text,
                    freq5.Text,
                    freq6.Text,
                    freq7.Text,
                    freq8.Text,
                    freq9.Text,
                    freq10.Text
                };

                List<string> stringsPeriod = new List<string>
                {
                    oneOfTheList.t1,
                    oneOfTheList.t2,
                    oneOfTheList.t3,
                    oneOfTheList.t4,
                    oneOfTheList.t5,
                    oneOfTheList.t6,
                    oneOfTheList.t7,
                    oneOfTheList.t8,
                    oneOfTheList.t9,
                    oneOfTheList.t10
                };

                List<string> stringsPeriodForm = new List<string>
                {
                    T1.Text,
                    T2.Text,
                    T3.Text,
                    T4.Text,
                    T5.Text,
                    T6.Text,
                    T7.Text,
                    T8.Text,
                    T9.Text,
                    T10.Text
                };

                List<string> stringsTime = new List<string>
                {
                    oneOfTheList.time1,
                    oneOfTheList.time2,
                    oneOfTheList.time3,
                    oneOfTheList.time4,
                    oneOfTheList.time5,
                    oneOfTheList.time6,
                    oneOfTheList.time7,
                    oneOfTheList.time8,
                    oneOfTheList.time9,
                    oneOfTheList.time10
                };

                List<string> stringsTimeForm = new List<string>
                {
                    time1.Text,
                    time2.Text,
                    time3.Text,
                    time4.Text,
                    time5.Text,
                    time6.Text,
                    time7.Text,
                    time8.Text,
                    time9.Text,
                    time10.Text
                };

                List<string> stringsToleranceTime = new List<string>
                {
                    oneOfTheList.toleranceTime1,
                    oneOfTheList.toleranceTime2,
                    oneOfTheList.toleranceTime3,
                    oneOfTheList.toleranceTime4,
                    oneOfTheList.toleranceTime5,
                    oneOfTheList.toleranceTime6,
                    oneOfTheList.toleranceTime7,
                    oneOfTheList.toleranceTime8,
                    oneOfTheList.toleranceTime9,
                    oneOfTheList.toleranceTime10
                };

                List<string> stringsTolerancePeriod = new List<string>
                {
                    oneOfTheList.toleranceTime1,
                    oneOfTheList.toleranceTime2,
                    oneOfTheList.toleranceTime3,
                    oneOfTheList.toleranceTime4,
                    oneOfTheList.toleranceTime5,
                    oneOfTheList.toleranceTime6,
                    oneOfTheList.toleranceTime7,
                    oneOfTheList.toleranceTime8,
                    oneOfTheList.toleranceTime9,
                    oneOfTheList.toleranceTime10
                };

                for (int i = 0; i < stringsFreqForm.Count(); i++)
                {
                    if (stringsFreqForm[i] != "" && stringsFreq[0] != "" && stringsFreq[1] != "" && Convert.ToDouble(stringsFreqForm[i]) >= Convert.ToDouble(stringsFreq[0]) 
                        && Convert.ToDouble(stringsFreqForm[i]) <= Convert.ToDouble(stringsFreq[1]))
                    {
                        countTrueFreq++;
                    }
                }

                for (int i = 0; i < stringsPeriodForm.Count(); i++)
                {
                    for (int j = 0; j < stringsPeriod.Count(); j++)
                    {
                        if (stringsPeriodForm[i] != "" && stringsPeriod[j] != "" && (Convert.ToDouble(stringsPeriod[j]) + Convert.ToDouble(stringsTolerancePeriod[j])) >= Convert.ToDouble(stringsPeriodForm[i]) &&
                            (Convert.ToDouble(stringsPeriod[j]) - Convert.ToDouble(stringsTolerancePeriod[j])) <= Convert.ToDouble(stringsPeriodForm[i]))
                        {
                            countTruePeriod++;
                            stringsPeriod.RemoveAt(j);
                            stringsTolerancePeriod.RemoveAt(j);
                        }
                    }
                }

                for (int i = 0; i < stringsTimeForm.Count(); i++)
                {
                    for (int j = 0; j < stringsTime.Count(); j++)
                    {
                        if (stringsTimeForm[i] != "" && stringsTime[j] != "" && (Convert.ToDouble(stringsTime[j]) + Convert.ToDouble(stringsToleranceTime[j])) >= Convert.ToDouble(stringsTimeForm[i]) &&
                            (Convert.ToDouble(stringsTime[j]) - Convert.ToDouble(stringsToleranceTime[j])) <= Convert.ToDouble(stringsTimeForm[i]))
                        {
                            countTrueImpulse++;
                            stringsTime.RemoveAt(j);
                            stringsToleranceTime.RemoveAt(j);
                        }
                    }
                }

                //условие что всё совпадает:
                if (countTrueFreq >= Convert.ToInt32(numberMatchFreq.Text) && countTruePeriod >= Convert.ToInt32(numberMatchPeriod.Text) && countTrueImpulse >= Convert.ToInt32(numberMatchImpulse.Text))
                {
                    finalSelectedList.Add(oneOfTheList);
                }

            }



            return finalSelectedList;
        }

        private List<InfoFromDBSea> Selected(List<InfoFromDBSea> infoFromDBs)
        {
            List<InfoFromDBSea> finalSelectedList = new List<InfoFromDBSea>();
            int countTrueFreq;
            int countTruePeriod;
            int countTrueImpulse;
            foreach (var oneOfTheList in infoFromDBs)
            {
                countTrueFreq = 0;
                countTrueImpulse = 0;
                countTruePeriod = 0;

                List<string> stringsFreq = new List<string>
                {
                    oneOfTheList.freqFrom,
                    oneOfTheList.freqBefore
                };

                List<string> stringsFreqForm = new List<string>
                {
                    freq1.Text,
                    freq2.Text,
                    freq3.Text,
                    freq4.Text,
                    freq5.Text,
                    freq6.Text,
                    freq7.Text,
                    freq8.Text,
                    freq9.Text,
                    freq10.Text
                };

                List<string> stringsPeriod = new List<string>
                {
                    oneOfTheList.t1,
                    oneOfTheList.t2,
                    oneOfTheList.t3,
                    oneOfTheList.t4,
                    oneOfTheList.t5,
                    oneOfTheList.t6,
                    oneOfTheList.t7,
                    oneOfTheList.t8,
                    oneOfTheList.t9,
                    oneOfTheList.t10
                };

                List<string> stringsPeriodForm = new List<string>
                {
                    T1.Text,
                    T2.Text,
                    T3.Text,
                    T4.Text,
                    T5.Text,
                    T6.Text,
                    T7.Text,
                    T8.Text,
                    T9.Text,
                    T10.Text
                };

                List<string> stringsTime = new List<string>
                {
                    oneOfTheList.time1,
                    oneOfTheList.time2,
                    oneOfTheList.time3,
                    oneOfTheList.time4,
                    oneOfTheList.time5,
                    oneOfTheList.time6,
                    oneOfTheList.time7,
                    oneOfTheList.time8,
                    oneOfTheList.time9,
                    oneOfTheList.time10
                };

                List<string> stringsTimeForm = new List<string>
                {
                    time1.Text,
                    time2.Text,
                    time3.Text,
                    time4.Text,
                    time5.Text,
                    time6.Text,
                    time7.Text,
                    time8.Text,
                    time9.Text,
                    time10.Text
                };

                List<string> stringsToleranceTime = new List<string>
                {
                    oneOfTheList.toleranceTime1,
                    oneOfTheList.toleranceTime2,
                    oneOfTheList.toleranceTime3,
                    oneOfTheList.toleranceTime4,
                    oneOfTheList.toleranceTime5,
                    oneOfTheList.toleranceTime6,
                    oneOfTheList.toleranceTime7,
                    oneOfTheList.toleranceTime8,
                    oneOfTheList.toleranceTime9,
                    oneOfTheList.toleranceTime10
                };

                List<string> stringsTolerancePeriod = new List<string>
                {
                    oneOfTheList.toleranceTime1,
                    oneOfTheList.toleranceTime2,
                    oneOfTheList.toleranceTime3,
                    oneOfTheList.toleranceTime4,
                    oneOfTheList.toleranceTime5,
                    oneOfTheList.toleranceTime6,
                    oneOfTheList.toleranceTime7,
                    oneOfTheList.toleranceTime8,
                    oneOfTheList.toleranceTime9,
                    oneOfTheList.toleranceTime10
                };

                for (int i = 0; i < stringsFreqForm.Count(); i++)
                {
                    if (stringsFreqForm[i] != "" && stringsFreq[0] != "" && stringsFreq[1] != "" && Convert.ToDouble(stringsFreqForm[i]) >= Convert.ToDouble(stringsFreq[0]) && 
                        Convert.ToDouble(stringsFreqForm[i]) <= Convert.ToDouble(stringsFreq[1]))
                    {
                        countTrueFreq++;
                    }
                }

                for (int i = 0; i < stringsPeriodForm.Count(); i++)
                {
                    for (int j = 0; j < stringsPeriod.Count(); j++)
                    {
                        if (stringsPeriodForm[i] != "" && stringsPeriod[j] != "" && (Convert.ToDouble(stringsPeriod[j]) + Convert.ToDouble(stringsTolerancePeriod[j])) >= Convert.ToDouble(stringsPeriodForm[i]) &&
                            (Convert.ToDouble(stringsPeriod[j]) - Convert.ToDouble(stringsTolerancePeriod[j])) <= Convert.ToDouble(stringsPeriodForm[i]))
                        {
                            countTruePeriod++;
                            stringsPeriod.RemoveAt(j);
                            stringsTolerancePeriod.RemoveAt(j);
                        }
                    }
                }

                for (int i = 0; i < stringsTimeForm.Count(); i++)
                {
                    for (int j = 0; j < stringsTime.Count(); j++)
                    {
                        if (stringsTimeForm[i] != "" && stringsTime[j] != "" && (Convert.ToDouble(stringsTime[j]) + Convert.ToDouble(stringsToleranceTime[j])) >= Convert.ToDouble(stringsTimeForm[i]) &&
                            (Convert.ToDouble(stringsTime[j]) - Convert.ToDouble(stringsToleranceTime[j])) <= Convert.ToDouble(stringsTimeForm[i]))
                        {
                            countTrueImpulse++;
                            stringsTime.RemoveAt(j);
                            stringsToleranceTime.RemoveAt(j);
                        }
                    }
                }


                //условие что всё совпадает:
                if (countTrueFreq >= Convert.ToInt32(numberMatchFreq.Text) && countTruePeriod >= Convert.ToInt32(numberMatchPeriod.Text) && countTrueImpulse >= Convert.ToInt32(numberMatchImpulse.Text))
                {
                    finalSelectedList.Add(oneOfTheList);
                }

            }



            return finalSelectedList;
        }

        private List<InfoFromDBEarth> Selected(List<InfoFromDBEarth> infoFromDBs)
        {
            List<InfoFromDBEarth> finalSelectedList = new List<InfoFromDBEarth>();
            int countTrueFreq;
            int countTruePeriod;
            int countTrueImpulse;
            foreach (var oneOfTheList in infoFromDBs)
            {
                countTrueFreq = 0;
                countTrueImpulse = 0;
                countTruePeriod = 0;

                List<string> stringsFreq = new List<string>
                {
                    oneOfTheList.freqFrom,
                    oneOfTheList.freqBefore
                };

                List<string> stringsFreqForm = new List<string>
                {
                    freq1.Text,
                    freq2.Text,
                    freq3.Text,
                    freq4.Text,
                    freq5.Text,
                    freq6.Text,
                    freq7.Text,
                    freq8.Text,
                    freq9.Text,
                    freq10.Text
                };

                List<string> stringsPeriod = new List<string>
                {
                    oneOfTheList.t1,
                    oneOfTheList.t2,
                    oneOfTheList.t3,
                    oneOfTheList.t4,
                    oneOfTheList.t5,
                    oneOfTheList.t6,
                    oneOfTheList.t7,
                    oneOfTheList.t8,
                    oneOfTheList.t9,
                    oneOfTheList.t10
                };

                List<string> stringsPeriodForm = new List<string>
                {
                    T1.Text,
                    T2.Text,
                    T3.Text,
                    T4.Text,
                    T5.Text,
                    T6.Text,
                    T7.Text,
                    T8.Text,
                    T9.Text,
                    T10.Text
                };

                List<string> stringsTime = new List<string>
                {
                    oneOfTheList.time1,
                    oneOfTheList.time2,
                    oneOfTheList.time3,
                    oneOfTheList.time4,
                    oneOfTheList.time5,
                    oneOfTheList.time6,
                    oneOfTheList.time7,
                    oneOfTheList.time8,
                    oneOfTheList.time9,
                    oneOfTheList.time10
                };

                List<string> stringsTimeForm = new List<string>
                {
                    time1.Text,
                    time2.Text,
                    time3.Text,
                    time4.Text,
                    time5.Text,
                    time6.Text,
                    time7.Text,
                    time8.Text,
                    time9.Text,
                    time10.Text
                };

                List<string> stringsToleranceTime = new List<string>
                {
                    oneOfTheList.toleranceTime1,
                    oneOfTheList.toleranceTime2,
                    oneOfTheList.toleranceTime3,
                    oneOfTheList.toleranceTime4,
                    oneOfTheList.toleranceTime5,
                    oneOfTheList.toleranceTime6,
                    oneOfTheList.toleranceTime7,
                    oneOfTheList.toleranceTime8,
                    oneOfTheList.toleranceTime9,
                    oneOfTheList.toleranceTime10
                };

                List<string> stringsTolerancePeriod = new List<string>
                {
                    oneOfTheList.toleranceTime1,
                    oneOfTheList.toleranceTime2,
                    oneOfTheList.toleranceTime3,
                    oneOfTheList.toleranceTime4,
                    oneOfTheList.toleranceTime5,
                    oneOfTheList.toleranceTime6,
                    oneOfTheList.toleranceTime7,
                    oneOfTheList.toleranceTime8,
                    oneOfTheList.toleranceTime9,
                    oneOfTheList.toleranceTime10
                };

                for (int i = 0; i < stringsFreqForm.Count(); i++)
                {
                    if (stringsFreqForm[i] != "" && stringsFreq[0] != "" && stringsFreq[1] != "" && Convert.ToDouble(stringsFreqForm[i]) >= Convert.ToDouble(stringsFreq[0]) && 
                        Convert.ToDouble(stringsFreqForm[i]) <= Convert.ToDouble(stringsFreq[1]))
                    {
                        countTrueFreq++;
                    }
                }

                for (int i = 0; i < stringsPeriodForm.Count(); i++)
                {
                    for (int j = 0; j < stringsPeriod.Count(); j++)
                    {
                        if (stringsPeriodForm[i] != "" && stringsPeriod[j] != "" && (Convert.ToDouble(stringsPeriod[j]) + Convert.ToDouble(stringsTolerancePeriod[j])) >= Convert.ToDouble(stringsPeriodForm[i]) &&
                            (Convert.ToDouble(stringsPeriod[j]) - Convert.ToDouble(stringsTolerancePeriod[j])) <= Convert.ToDouble(stringsPeriodForm[i]))
                        {
                            countTruePeriod++;
                            stringsPeriod.RemoveAt(j);
                            stringsTolerancePeriod.RemoveAt(j);
                        }
                    }
                }

                for (int i = 0; i < stringsTimeForm.Count(); i++)
                {
                    for (int j = 0; j < stringsTime.Count(); j++)
                    {
                        if (stringsTimeForm[i] != "" && stringsTime[j] != "" && (Convert.ToDouble(stringsTime[j]) + Convert.ToDouble(stringsToleranceTime[j])) >= Convert.ToDouble(stringsTimeForm[i]) &&
                            (Convert.ToDouble(stringsTime[j]) - Convert.ToDouble(stringsToleranceTime[j])) <= Convert.ToDouble(stringsTimeForm[i]))
                        {
                            countTrueImpulse++;
                            stringsTime.RemoveAt(j);
                            stringsToleranceTime.RemoveAt(j);
                        }
                    }
                }


                //условие что всё совпадает:
                if (countTrueFreq >= Convert.ToInt32(numberMatchFreq.Text) && countTruePeriod >= Convert.ToInt32(numberMatchPeriod.Text) && countTrueImpulse >= Convert.ToInt32(numberMatchImpulse.Text))
                {
                    finalSelectedList.Add(oneOfTheList);
                }

            }



            return finalSelectedList;
        }

        private void numberCellFreqChanged(object sender, EventArgs e)
        {
            freq1.Text = "";
            freq2.Text = "";
            freq3.Text = "";
            freq4.Text = "";
            freq5.Text = "";
            freq6.Text = "";
            freq7.Text = "";
            freq8.Text = "";
            freq9.Text = "";
            freq10.Text = "";

            if (numberFreqCell.Text == "1")
            {
                freq1.Enabled = true;
                freq2.Enabled = false;
                freq3.Enabled = false;
                freq4.Enabled = false;
                freq5.Enabled = false;
                freq6.Enabled = false;
                freq7.Enabled = false;
                freq8.Enabled = false;
                freq9.Enabled = false;
                freq10.Enabled = false;
            }
            else if (numberFreqCell.Text == "2")
            {
                freq1.Enabled = true;
                freq2.Enabled = true;
                freq3.Enabled = false;
                freq4.Enabled = false;
                freq5.Enabled = false;
                freq6.Enabled = false;
                freq7.Enabled = false;
                freq8.Enabled = false;
                freq9.Enabled = false;
                freq10.Enabled = false;
            }
            else if (numberFreqCell.Text == "3")
            {
                freq1.Enabled = true;
                freq2.Enabled = true;
                freq3.Enabled = true;
                freq4.Enabled = false;
                freq5.Enabled = false;
                freq6.Enabled = false;
                freq7.Enabled = false;
                freq8.Enabled = false;
                freq9.Enabled = false;
                freq10.Enabled = false;
            }
            else if (numberFreqCell.Text == "4")
            {
                freq1.Enabled = true;
                freq2.Enabled = true;
                freq3.Enabled = true;
                freq4.Enabled = true;
                freq5.Enabled = false;
                freq6.Enabled = false;
                freq7.Enabled = false;
                freq8.Enabled = false;
                freq9.Enabled = false;
                freq10.Enabled = false;
            }
            else if (numberFreqCell.Text == "5")
            {
                freq1.Enabled = true;
                freq2.Enabled = true;
                freq3.Enabled = true;
                freq4.Enabled = true;
                freq5.Enabled = true;
                freq6.Enabled = false;
                freq7.Enabled = false;
                freq8.Enabled = false;
                freq9.Enabled = false;
                freq10.Enabled = false;
            }
            else if (numberFreqCell.Text == "6")
            {
                freq1.Enabled = true;
                freq2.Enabled = true;
                freq3.Enabled = true;
                freq4.Enabled = true;
                freq5.Enabled = true;
                freq6.Enabled = true;
                freq7.Enabled = false;
                freq8.Enabled = false;
                freq9.Enabled = false;
                freq10.Enabled = false;
            }
            else if (numberFreqCell.Text == "7")
            {
                freq1.Enabled = true;
                freq2.Enabled = true;
                freq3.Enabled = true;
                freq4.Enabled = true;
                freq5.Enabled = true;
                freq6.Enabled = true;
                freq7.Enabled = true;
                freq8.Enabled = false;
                freq9.Enabled = false;
                freq10.Enabled = false;
            }
            else if (numberFreqCell.Text == "8")
            {
                freq1.Enabled = true;
                freq2.Enabled = true;
                freq3.Enabled = true;
                freq4.Enabled = true;
                freq5.Enabled = true;
                freq6.Enabled = true;
                freq7.Enabled = true;
                freq8.Enabled = true;
                freq9.Enabled = false;
                freq10.Enabled = false;
            }
            else if (numberFreqCell.Text == "9")
            {
                freq1.Enabled = true;
                freq2.Enabled = true;
                freq3.Enabled = true;
                freq4.Enabled = true;
                freq5.Enabled = true;
                freq6.Enabled = true;
                freq7.Enabled = true;
                freq8.Enabled = true;
                freq9.Enabled = true;
                freq10.Enabled = false;
            }
            else if (numberFreqCell.Text == "10")
            {
                freq1.Enabled = true;
                freq2.Enabled = true;
                freq3.Enabled = true;
                freq4.Enabled = true;
                freq5.Enabled = true;
                freq6.Enabled = true;
                freq7.Enabled = true;
                freq8.Enabled = true;
                freq9.Enabled = true;
                freq10.Enabled = true;
            }
        }

        private void numberCellPeriodChanged(object sender, EventArgs e)
        {
            T1.Text = "";
            T2.Text = "";
            T3.Text = "";
            T4.Text = "";
            T5.Text = "";
            T6.Text = "";
            T7.Text = "";
            T8.Text = "";
            T9.Text = "";
            T10.Text = "";

            if (numberPeriodCell.Text == "1")
            {
                T1.Enabled = true;
                T2.Enabled = false;
                T3.Enabled = false;
                T4.Enabled = false;
                T5.Enabled = false;
                T6.Enabled = false;
                T7.Enabled = false;
                T8.Enabled = false;
                T9.Enabled = false;
                T10.Enabled = false;
            }
            else if (numberPeriodCell.Text == "2")
            {
                T1.Enabled = true;
                T2.Enabled = true;
                T3.Enabled = false;
                T4.Enabled = false;
                T5.Enabled = false;
                T6.Enabled = false;
                T7.Enabled = false;
                T8.Enabled = false;
                T9.Enabled = false;
                T10.Enabled = false;
            }
            else if (numberPeriodCell.Text == "3")
            {
                T1.Enabled = true;
                T2.Enabled = true;
                T3.Enabled = true;
                T4.Enabled = false;
                T5.Enabled = false;
                T6.Enabled = false;
                T7.Enabled = false;
                T8.Enabled = false;
                T9.Enabled = false;
                T10.Enabled = false;
            }
            else if (numberPeriodCell.Text == "4")
            {
                T1.Enabled = true;
                T2.Enabled = true;
                T3.Enabled = true;
                T4.Enabled = true;
                T5.Enabled = false;
                T6.Enabled = false;
                T7.Enabled = false;
                T8.Enabled = false;
                T9.Enabled = false;
                T10.Enabled = false;
            }
            else if (numberPeriodCell.Text == "5")
            {
                T1.Enabled = true;
                T2.Enabled = true;
                T3.Enabled = true;
                T4.Enabled = true;
                T5.Enabled = true;
                T6.Enabled = false;
                T7.Enabled = false;
                T8.Enabled = false;
                T9.Enabled = false;
                T10.Enabled = false;
            }
            else if (numberPeriodCell.Text == "6")
            {
                T1.Enabled = true;
                T2.Enabled = true;
                T3.Enabled = true;
                T4.Enabled = true;
                T5.Enabled = true;
                T6.Enabled = true;
                T7.Enabled = false;
                T8.Enabled = false;
                T9.Enabled = false;
                T10.Enabled = false;
            }
            else if (numberPeriodCell.Text == "7")
            {
                T1.Enabled = true;
                T2.Enabled = true;
                T3.Enabled = true;
                T4.Enabled = true;
                T5.Enabled = true;
                T6.Enabled = true;
                T7.Enabled = true;
                T8.Enabled = false;
                T9.Enabled = false;
                T10.Enabled = false;
            }
            else if (numberPeriodCell.Text == "8")
            {
                T1.Enabled = true;
                T2.Enabled = true;
                T3.Enabled = true;
                T4.Enabled = true;
                T5.Enabled = true;
                T6.Enabled = true;
                T7.Enabled = true;
                T8.Enabled = true;
                T9.Enabled = false;
                T10.Enabled = false;
            }
            else if (numberPeriodCell.Text == "9")
            {
                T1.Enabled = true;
                T2.Enabled = true;
                T3.Enabled = true;
                T4.Enabled = true;
                T5.Enabled = true;
                T6.Enabled = true;
                T7.Enabled = true;
                T8.Enabled = true;
                T9.Enabled = true;
                T10.Enabled = false;
            }
            else if (numberPeriodCell.Text == "10")
            {
                T1.Enabled = true;
                T2.Enabled = true;
                T3.Enabled = true;
                T4.Enabled = true;
                T5.Enabled = true;
                T6.Enabled = true;
                T7.Enabled = true;
                T8.Enabled = true;
                T9.Enabled = true;
                T10.Enabled = true;
            }

        }

        private void numberCellImpulseChanged(object sender, EventArgs e)
        {
            time1.Text = "";
            time2.Text = "";
            time3.Text = "";
            time4.Text = "";
            time5.Text = "";
            time6.Text = "";
            time7.Text = "";
            time8.Text = "";
            time9.Text = "";
            time10.Text = "";

            if (numberImpulseCell.Text == "1")
            {
                time1.Enabled = true;
                time2.Enabled = false;
                time3.Enabled = false;
                time4.Enabled = false;
                time5.Enabled = false;
                time6.Enabled = false;
                time7.Enabled = false;
                time8.Enabled = false;
                time9.Enabled = false;
                time10.Enabled = false;
            }
            else if (numberImpulseCell.Text == "2")
            {
                time1.Enabled = true;
                time2.Enabled = true;
                time3.Enabled = false;
                time4.Enabled = false;
                time5.Enabled = false;
                time6.Enabled = false;
                time7.Enabled = false;
                time8.Enabled = false;
                time9.Enabled = false;
                time10.Enabled= false;
            }
            else if (numberImpulseCell.Text == "3")
            {
                time1.Enabled = true;
                time2.Enabled = true;
                time3.Enabled = true;
                time4.Enabled = false;
                time5.Enabled = false;
                time6.Enabled = false;
                time7.Enabled = false;
                time8.Enabled = false;
                time9.Enabled = false;
                time10.Enabled = false;            
            }
            else if (numberImpulseCell.Text == "4")
            {
                time1.Enabled = true;
                time2.Enabled = true;
                time3.Enabled = true;
                time4.Enabled = true;
                time5.Enabled = false;
                time6.Enabled = false;
                time7.Enabled = false;
                time8.Enabled = false;
                time9.Enabled = false;
                time10.Enabled = false;             
            }
            else if (numberImpulseCell.Text == "5")
            {
                time1.Enabled = true;
                time2.Enabled = true;
                time3.Enabled = true;
                time4.Enabled = true;
                time5.Enabled = true;
                time6.Enabled = false;
                time7.Enabled = false;
                time8.Enabled = false;
                time9.Enabled = false;
                time10.Enabled = false;
            }
            else if (numberImpulseCell.Text == "6")
            {
                time1.Enabled = true;
                time2.Enabled = true;
                time3.Enabled = true;
                time4.Enabled = true;
                time5.Enabled = true;
                time6.Enabled = true;
                time7.Enabled = false;
                time8.Enabled = false;
                time9.Enabled = false;
                time10.Enabled = false;
            }
            else if (numberImpulseCell.Text == "7")
            {
                time1.Enabled = true;
                time2.Enabled = true;
                time3.Enabled = true;
                time4.Enabled = true;
                time5.Enabled = true;
                time6.Enabled = true;
                time7.Enabled = true;
                time8.Enabled = false;
                time9.Enabled = false;
                time10.Enabled = false;
            }
            else if (numberImpulseCell.Text == "8")
            {
                time1.Enabled = true;
                time2.Enabled = true;
                time3.Enabled = true;
                time4.Enabled = true;
                time5.Enabled = true;
                time6.Enabled = true;
                time7.Enabled = true;
                time8.Enabled = true;
                time9.Enabled = false;
                time10.Enabled = false;
            }
            else if (numberImpulseCell.Text == "9")
            {
                time1.Enabled = true;
                time2.Enabled = true;
                time3.Enabled = true;
                time4.Enabled = true;
                time5.Enabled = true;
                time6.Enabled = true;
                time7.Enabled = true;
                time8.Enabled = true;
                time9.Enabled = true;
                time10.Enabled = false;
            }
            else if (numberImpulseCell.Text == "10")
            {
                time1.Enabled = true;
                time2.Enabled = true;
                time3.Enabled = true;
                time4.Enabled = true;
                time5.Enabled = true;
                time6.Enabled = true;
                time7.Enabled = true;
                time8.Enabled = true;
                time9.Enabled = true;
                time10.Enabled = true;
            }
        }

        private void replaceFreq1(object sender, EventArgs e)
        {
            string valueTextBox = freq1.Text;
            if (valueTextBox != "")
            {
                freq1.Text = valueTextBox.Replace('.', ',');
            }
        }

        private void replaceFreq2(object sender, EventArgs e)
        {
            string valueTextBox = freq2.Text;
            if (valueTextBox != "")
            {
                freq2.Text = valueTextBox.Replace('.', ',');
            }
        }

        private void replaceFreq3(object sender, EventArgs e)
        {
            string valueTextBox = freq3.Text;
            if (valueTextBox != "")
            {
                freq3.Text = valueTextBox.Replace('.', ',');
            }
        }

        private void replaceFreq4(object sender, EventArgs e)
        {
            string valueTextBox = freq4.Text;
            if (valueTextBox != "")
            {
                freq4.Text = valueTextBox.Replace('.', ',');
            }
        }

        private void replaceFreq5(object sender, EventArgs e)
        {
            string valueTextBox = freq5.Text;
            if (valueTextBox != "")
            {
                freq5.Text = valueTextBox.Replace('.', ',');
            }
        }

        private void replaceFreq6(object sender, EventArgs e)
        {
            string valueTextBox = freq6.Text;
            if (valueTextBox != "")
            {
                freq6.Text = valueTextBox.Replace('.', ',');
            }
        }

        private void replaceFreq7(object sender, EventArgs e)
        {
            string valueTextBox = freq7.Text;
            if (valueTextBox != "")
            {
                freq7.Text = valueTextBox.Replace('.', ',');
            }
        }

        private void replaceFreq8(object sender, EventArgs e)
        {
            string valueTextBox = freq8.Text;
            if (valueTextBox != "")
            {
                freq8.Text = valueTextBox.Replace('.', ',');
            }
        }

        private void replaceFreq9(object sender, EventArgs e)
        {
            string valueTextBox = freq9.Text;
            if (valueTextBox != "")
            {
                freq9.Text = valueTextBox.Replace('.', ',');
            }
        }

        private void replaceFreq10(object sender, EventArgs e)
        {
            string valueTextBox = freq10.Text;
            if (valueTextBox != "")
            {
                freq10.Text = valueTextBox.Replace('.', ',');
            }
        }

        private void replacePeriod1(object sender, EventArgs e)
        {
            string valueTextBox = T1.Text;
            if (valueTextBox != "")
            {
                T1.Text = valueTextBox.Replace('.', ',');
            }
        }

        private void replacePeriod2(object sender, EventArgs e)
        {
            string valueTextBox = T2.Text;
            if (valueTextBox != "")
            {
                T2.Text = valueTextBox.Replace('.', ',');
            }
        }

        private void replacePeriod3(object sender, EventArgs e)
        {
            string valueTextBox = T3.Text;
            if (valueTextBox != "")
            {
                T3.Text = valueTextBox.Replace('.', ',');
            }
        }

        private void replacePeriod4(object sender, EventArgs e)
        {
            string valueTextBox = T4.Text;
            if (valueTextBox != "")
            {
                T4.Text = valueTextBox.Replace('.', ',');
            }
        }

        private void replacePeriod5(object sender, EventArgs e)
        {
            string valueTextBox = T5.Text;
            if (valueTextBox != "")
            {
                T5.Text = valueTextBox.Replace('.', ',');
            }
        }

        private void replacePeriod6(object sender, EventArgs e)
        {
            string valueTextBox = T6.Text;
            if (valueTextBox != "")
            {
                T6.Text = valueTextBox.Replace('.', ',');
            }
        }

        private void replacePeriod7(object sender, EventArgs e)
        {
            string valueTextBox = T7.Text;
            if (valueTextBox != "")
            {
                T7.Text = valueTextBox.Replace('.', ',');
            }
        }

        private void replacePeriod8(object sender, EventArgs e)
        {
            string valueTextBox = T8.Text;
            if (valueTextBox != "")
            {
                T8.Text = valueTextBox.Replace('.', ',');
            }
        }

        private void replacePeriod9(object sender, EventArgs e)
        {
            string valueTextBox = T9.Text;
            if (valueTextBox != "")
            {
                T9.Text = valueTextBox.Replace('.', ',');
            }
        }

        private void replacePeriod10(object sender, EventArgs e)
        {
            string valueTextBox = T10.Text;
            if (valueTextBox != "")
            {
                T10.Text = valueTextBox.Replace('.', ',');
            }
        }

        private void replaceTime1(object sender, EventArgs e)
        {
            string valueTextBox = time1.Text;
            if (valueTextBox != "")
            {
                time1.Text = valueTextBox.Replace('.', ',');
            }
        }

        private void replaceTime2(object sender, EventArgs e)
        {
            string valueTextBox = time2.Text;
            if (valueTextBox != "")
            {
                time2.Text = valueTextBox.Replace('.', ',');
            }
        }

        private void replaceTime3(object sender, EventArgs e)
        {
            string valueTextBox = time3.Text;
            if (valueTextBox != "")
            {
                time3.Text = valueTextBox.Replace('.', ',');
            }
        }

        private void replaceTime4(object sender, EventArgs e)
        {
            string valueTextBox = time4.Text;
            if (valueTextBox != "")
            {
                time4.Text = valueTextBox.Replace('.', ',');
            }
        }

        private void replaceTime5(object sender, EventArgs e)
        {
            string valueTextBox = time5.Text;
            if (valueTextBox != "")
            {
                time5.Text = valueTextBox.Replace('.', ',');
            }
        }

        private void replaceTime6(object sender, EventArgs e)
        {
            string valueTextBox = time6.Text;
            if (valueTextBox != "")
            {
                time6.Text = valueTextBox.Replace('.', ',');
            }
        }

        private void replaceTime7(object sender, EventArgs e)
        {
            string valueTextBox = time7.Text;
            if (valueTextBox != "")
            {
                time7.Text = valueTextBox.Replace('.', ',');
            }
        }

        private void replaceTime8(object sender, EventArgs e)
        {
            string valueTextBox = time8.Text;
            if (valueTextBox != "")
            {
                time8.Text = valueTextBox.Replace('.', ',');
            }
        }

        private void replaceTime9(object sender, EventArgs e)
        {
            string valueTextBox = time9.Text;
            if (valueTextBox != "")
            {
                time9.Text = valueTextBox.Replace('.', ',');
            }
        }

        private void replaceTime10(object sender, EventArgs e)
        {
            string valueTextBox = time10.Text;
            if (valueTextBox != "")
            {
                time10.Text = valueTextBox.Replace('.', ',');
            }
        }

        

        private void operatorButton_Click(object sender, EventArgs e)
        {
            OperatorForm operatorForm = new OperatorForm();
            operatorForm.Show();
        }
    }
}
