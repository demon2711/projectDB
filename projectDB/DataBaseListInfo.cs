using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projectDB
{
    public partial class DataBaseListInfo : Form
    {
        public DataBaseListInfo()
        {
            InitializeComponent();
            

            //this.infoDataBase.DefaultCellStyle.Font = new Font("Tahoma", 15);
        }

        SQLiteDataReader dr;
        string cs = @"URI=file:" + Application.StartupPath + "\\usersdata.db";


        private void DataBaseListInfo_Load(object sender, EventArgs e)
        {
            
            path.Visible= false;
            var con = new SQLiteConnection(cs);
            con.Open();

            string query = "SELECT * FROM ObjectSourceGround";
            var cmd = new SQLiteCommand(query, con);
            dr = cmd.ExecuteReader();
            StringBuilder stringInfoDBGround = new StringBuilder();
            while (dr.Read())
            {
                stringInfoDBGround.Clear();
                stringInfoDBGround.Append(dr.GetString(1));
                stringInfoDBGround.Append(" - ");
                stringInfoDBGround.Append(dr.GetString(2));
                
                infoDataBaseEarth.Rows.Add(stringInfoDBGround.ToString());
            }
            dr.Close();

            query = "SELECT * FROM ObjectSource";
            cmd = new SQLiteCommand(query, con);
            dr = cmd.ExecuteReader();
            StringBuilder stringInfoDBAir = new StringBuilder();
            while (dr.Read())
            {
                stringInfoDBAir.Clear();
                stringInfoDBAir.Append(dr.GetString(1));
                stringInfoDBAir.Append(" - ");
                stringInfoDBAir.Append(dr.GetString(2));

                infoDataBaseAir.Rows.Add(stringInfoDBAir.ToString());
            }
            dr.Close();

            query = "SELECT * FROM ObjectSourceSea";
            cmd = new SQLiteCommand(query, con);
            dr = cmd.ExecuteReader();
            StringBuilder stringInfoDBSea = new StringBuilder();
            while (dr.Read())
            {
                stringInfoDBSea.Clear();
                stringInfoDBSea.Append(dr.GetString(1));
                stringInfoDBSea.Append(" - ");
                stringInfoDBSea.Append(dr.GetString(2));

                infoDataBaseSea.Rows.Add(stringInfoDBSea.ToString());
            }
            dr.Close();

            infoDataBaseSea.ClearSelection();
            infoDataBaseEarth.ClearSelection();
            infoDataBaseAir.ClearSelection();
            

        }

        private void Ok_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cellAirTable_Click(object sender, DataGridViewCellEventArgs e)
        {
            //запрос в базу

            var con = new SQLiteConnection(cs);
            con.Open();

            string query = "SELECT * FROM ObjectSource WHERE id=" + (e.RowIndex + 1);
            var cmd = new SQLiteCommand(query, con);
            dr = cmd.ExecuteReader();
            StringBuilder stringInfoDBAir = new StringBuilder();
            while (dr.Read())
            {
                pictureObj.ImageLocation = dr.GetString(45);
                stringInfoDBAir.Append(dr.GetString(1) + " - " + dr.GetString(2) + "\r\n");
                stringInfoDBAir.Append("Частота от, МГц: " + dr.GetString(3) + ", частота до, МГц: " + dr.GetString(4) + "\r\n");
                stringInfoDBAir.Append("Периоды, мкс: ");
                for (int i = 5; i < 15; i++)
                {
                    stringInfoDBAir.Append(dr.GetString(i) + " ");
                }
                stringInfoDBAir.Append("\r\nДлительности периодов, мкс: ");
                for (int i = 15; i < 25; i++)
                {
                    stringInfoDBAir.Append(dr.GetString(i) + " ");
                }
                stringInfoDBAir.Append("\r\nДопуски по периодам: ");
                for (int i = 25; i < 35; i++)
                {
                    stringInfoDBAir.Append(dr.GetString(i) + " ");
                }
                stringInfoDBAir.Append("\r\nДопуски по длительности импульсов: ");
                for (int i = 35; i < 45; i++)
                {
                    stringInfoDBAir.Append(dr.GetString(i) + " ");
                }
                stringInfoDBAir.Append("\r\nДополнительная информация:\r\n");
                stringInfoDBAir.Append("Позывной: " + dr.GetString(46) + "\r\n");
                stringInfoDBAir.Append("Код ЗА: " + dr.GetString(47) + "\r\n");
                stringInfoDBAir.Append("Код ИКАО: " + dr.GetString(48) + "\r\n");
                stringInfoDBAir.Append("Скорость: " + dr.GetString(49) + "\r\n");
                stringInfoDBAir.Append("Бортовое РЛО: " + dr.GetString(50) + "\r\n");
                stringInfoDBAir.Append("Минимальный предел по высоте: " + dr.GetString(51) + "\r\n");
                stringInfoDBAir.Append("Максимальный предел по высоте: " + dr.GetString(52) + "\r\n");
                stringInfoDBAir.Append("Основное вооружение: " + dr.GetString(53) + "\r\n");
                stringInfoDBAir.Append("Назначение: " + dr.GetString(54) + "\r\n");
                stringInfoDBAir.Append("Другие параметры: " + dr.GetString(55));
                path.Text = dr.GetString(56);
            }
            infoFromDB.Text = stringInfoDBAir.ToString();
        }

        private void cellEarthTable_Click(object sender, DataGridViewCellEventArgs e)
        {
            //запрос в базу

            var con = new SQLiteConnection(cs);
            con.Open();

            string query = "SELECT * FROM ObjectSourceGround WHERE id=" + (e.RowIndex + 1);
            var cmd = new SQLiteCommand(query, con);
            dr = cmd.ExecuteReader();
            StringBuilder stringInfoDBEarth = new StringBuilder();
            while (dr.Read())
            {
                pictureObj.ImageLocation = dr.GetString(45);
                stringInfoDBEarth.Append(dr.GetString(1) + " - " + dr.GetString(2) + "\r\n");
                stringInfoDBEarth.Append("Частота от, МГц: " + dr.GetString(3) + ", частота до, МГц: " + dr.GetString(4) + "\r\n");
                stringInfoDBEarth.Append("Периоды, мкс: ");
                for (int i = 5; i < 15; i++)
                {
                    stringInfoDBEarth.Append(dr.GetString(i) + " ");
                }
                stringInfoDBEarth.Append("\r\nДлительности периодов, мкс: ");
                for (int i = 15; i < 25; i++)
                {
                    stringInfoDBEarth.Append(dr.GetString(i) + " ");
                }
                stringInfoDBEarth.Append("\r\nДопуски по периодам: ");
                for (int i = 25; i < 35; i++)  
                {
                    stringInfoDBEarth.Append(dr.GetString(i) + " ");
                }
                stringInfoDBEarth.Append("\r\nДопуски по длительности импульсов: ");
                for (int i = 35; i < 45; i++)
                {
                    stringInfoDBEarth.Append(dr.GetString(i) + " ");
                }
                stringInfoDBEarth.Append("\r\nДополнительная информация:\r\n");
                stringInfoDBEarth.Append("Позывной: " + dr.GetString(46) + "\r\n");
                stringInfoDBEarth.Append("Размеры: " + dr.GetString(47) + "\r\n");
                stringInfoDBEarth.Append("Вес: " + dr.GetString(48) + "\r\n");
                stringInfoDBEarth.Append("Тип: " + dr.GetString(49) + "\r\n");
                stringInfoDBEarth.Append("Назначение: " + dr.GetString(50) + "\r\n");
                stringInfoDBEarth.Append("Технические характеристики: " + dr.GetString(51));
                path.Text = dr.GetString(52);
            }
            infoFromDB.Text = stringInfoDBEarth.ToString();
        }

        private void cellSeaTable_Click(object sender, DataGridViewCellEventArgs e)
        {
            //запрос в базу

            var con = new SQLiteConnection(cs);
            con.Open();

            string query = "SELECT * FROM ObjectSourceSea WHERE id=" + (e.RowIndex + 1);
            var cmd = new SQLiteCommand(query, con);
            dr = cmd.ExecuteReader();
            StringBuilder stringInfoDBSea = new StringBuilder();
            while (dr.Read())
            {
                pictureObj.ImageLocation = dr.GetString(45);
                stringInfoDBSea.Append(dr.GetString(1) + " - " + dr.GetString(2) + "\r\n");
                stringInfoDBSea.Append("Частота от, МГц: " + dr.GetString(3) + ", частота до, МГц: " + dr.GetString(4) + "\r\n");
                stringInfoDBSea.Append("Периоды, мкс: ");
                for (int i = 5; i < 15; i++)
                {
                    stringInfoDBSea.Append(dr.GetString(i) + " ");
                }
                stringInfoDBSea.Append("\r\nДлительности периодов, мкс: ");
                for (int i = 15; i < 25; i++)
                {
                    stringInfoDBSea.Append(dr.GetString(i) + " ");
                }
                stringInfoDBSea.Append("\r\nДопуски по периодам: ");
                for (int i = 25; i < 35; i++)
                {
                    stringInfoDBSea.Append(dr.GetString(i) + " ");
                }
                stringInfoDBSea.Append("\r\nДопуски по длительности импульсов: ");
                for (int i = 35; i < 45; i++)
                {
                    stringInfoDBSea.Append(dr.GetString(i) + " ");
                }
                stringInfoDBSea.Append("\r\nДополнительная информация:\r\n");
                stringInfoDBSea.Append("Позывной: " + dr.GetString(46) + "\r\n");
                stringInfoDBSea.Append("Длина корабля: " + dr.GetString(47) + "\r\n");
                stringInfoDBSea.Append("Ширина корабля: " + dr.GetString(48) + "\r\n");
                stringInfoDBSea.Append("Водоизмещение: " + dr.GetString(49) + "\r\n");
                stringInfoDBSea.Append("Код MMSI: " + dr.GetString(50) + "\r\n");
                stringInfoDBSea.Append("Описание: " + dr.GetString(51) + "\r\n");
                stringInfoDBSea.Append("Общая информация: " + dr.GetString(52) + "\r\n");
                path.Text = dr.GetString(53);
            }
            infoFromDB.Text = stringInfoDBSea.ToString();
        }

        private void buttonRLC_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(path.Text);
        }
    }
}
