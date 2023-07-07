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
    public partial class SearchList : Form
    {
        private static List<InfoFromDB> finalListAir;
        private static List<InfoFromDBEarth> finalListEarth;
        private static List<InfoFromDBSea> finalListSea;
        public SearchList(List<InfoFromDB> infoFromDBAir, List<InfoFromDBEarth> infoFromDBEarth, List<InfoFromDBSea> infoFromDBSea)
        {
            InitializeComponent();
            finalListAir = new List<InfoFromDB>(infoFromDBAir);
            finalListEarth = new List<InfoFromDBEarth>(infoFromDBEarth);
            finalListSea = new List<InfoFromDBSea>(infoFromDBSea);
            
            foreach (var oneOfTheList in infoFromDBAir)
            {
                StringBuilder name = new StringBuilder();
                name.Clear();
                name.Append(oneOfTheList.Object);
                name.Append(" - ");
                name.Append(oneOfTheList.Source);
                searchListFinalAir.Rows.Insert(searchListFinalAir.Rows.Count - 1, name);
                
            }
            foreach (var oneOfTheList in infoFromDBEarth)
            {
                StringBuilder name = new StringBuilder();
                name.Clear();
                name.Append(oneOfTheList.Object);
                name.Append(" - ");
                name.Append(oneOfTheList.Source);
                searchListFinalEarth.Rows.Insert(searchListFinalEarth.Rows.Count - 1, name);
                
            }
            foreach (var oneOfTheList in infoFromDBSea)
            {
                StringBuilder name = new StringBuilder();
                name.Clear();
                name.Append(oneOfTheList.Object);
                name.Append(" - ");
                name.Append(oneOfTheList.Source);
                searchListFinalSea.Rows.Insert(searchListFinalSea.Rows.Count - 1, name);
                
            }

        }

        private void SearchList_Load(object sender, EventArgs e)
        {
            searchListFinalAir.CurrentCell = null;
            searchListFinalEarth.CurrentCell = null;
            searchListFinalSea.CurrentCell = null;
            path.Visible = false;

        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cellClickAirTable(object sender, DataGridViewCellEventArgs e)
        {
            
            int number = e.RowIndex;
            path.Visible = false;
            path.Text = finalListAir[number].path;
            if (number != searchListFinalAir.RowCount-1)
            {
                StringBuilder info = new StringBuilder();
                info.Append(finalListAir[number].Object + " ");
                info.Append(finalListAir[number].Source + " \r\n");
                info.Append("Частота от, МГц: " + finalListAir[number].freqFrom + " частота до, МГц: ");
                info.Append(finalListAir[number].freqBefore + " \r\n");
                info.Append("Периоды, мкс: " + finalListAir[number].t1 + " ");
                info.Append(finalListAir[number].t2 + " ");
                info.Append(finalListAir[number].t3 + " ");
                info.Append(finalListAir[number].t4 + " ");
                info.Append(finalListAir[number].t5 + " ");
                info.Append(finalListAir[number].t6 + " ");
                info.Append(finalListAir[number].t7 + " ");
                info.Append(finalListAir[number].t8 + " ");
                info.Append(finalListAir[number].t9 + " ");
                info.Append(finalListAir[number].t10 + " \r\n");
                info.Append("Длительности периодов, мкс: " + finalListAir[number].time1 + " ");
                info.Append(finalListAir[number].time2 + " ");
                info.Append(finalListAir[number].time3 + " ");
                info.Append(finalListAir[number].time4 + " ");
                info.Append(finalListAir[number].time5 + " ");
                info.Append(finalListAir[number].time6 + " ");
                info.Append(finalListAir[number].time7 + " ");
                info.Append(finalListAir[number].time8 + " ");
                info.Append(finalListAir[number].time9 + " ");
                info.Append(finalListAir[number].time10 + " \r\n");
                info.Append("Дополнительная информация:\r\nПозывной: " + finalListAir[number].nickName + " \r\n");
                info.Append("Код ЗА: " + finalListAir[number].codeZA + " \r\n");
                info.Append("Код ИКАО: " + finalListAir[number].codeIKAO + " \r\n");
                info.Append("Скорость: " + finalListAir[number].speed + " \r\n");
                info.Append("Бортовое РЛО: " + finalListAir[number].rlo + " \r\n");
                info.Append("Минимальный предел по высоте: " + finalListAir[number].minLimit + " \r\n");
                info.Append("Максимальный предел по высоте: " + finalListAir[number].maxLimit + " \r\n");
                info.Append("Основное вооружение: " + finalListAir[number].mainArmament + " \r\n");
                info.Append("Назначение: " + finalListAir[number].purpose + " \r\n");
                info.Append("Другие параметры: " + finalListAir[number].otherParam);
                infoFromDB.Text = info.ToString();
                pictureObj.ImageLocation = finalListAir[number].picture;
            }
        }

        private void cellClickEarthTable(object sender, DataGridViewCellEventArgs e)
        {
            
            int number = e.RowIndex;
            path.Visible = false;
            path.Text = finalListEarth[number].path;
            if (number != searchListFinalEarth.RowCount - 1)
            {
                StringBuilder info = new StringBuilder();
                info.Append(finalListEarth[number].Object + " ");
                info.Append(finalListEarth[number].Source + " \r\n");
                info.Append("Частота от, МГц: " + finalListEarth[number].freqFrom + " частота до, МГц: ");
                info.Append(finalListEarth[number].freqBefore + " \r\n");
                info.Append("Периоды, мкс: " + finalListEarth[number].t1 + " ");
                info.Append(finalListEarth[number].t2 + " ");
                info.Append(finalListEarth[number].t3 + " ");
                info.Append(finalListEarth[number].t4 + " ");
                info.Append(finalListEarth[number].t5 + " ");
                info.Append(finalListEarth[number].t6 + " ");
                info.Append(finalListEarth[number].t7 + " ");
                info.Append(finalListEarth[number].t8 + " ");
                info.Append(finalListEarth[number].t9 + " ");
                info.Append(finalListEarth[number].t10 + " \r\n");
                info.Append("Длительности периодов, мкс: " + finalListEarth[number].time1 + " ");
                info.Append(finalListEarth[number].time2 + " ");
                info.Append(finalListEarth[number].time3 + " ");
                info.Append(finalListEarth[number].time4 + " ");
                info.Append(finalListEarth[number].time5 + " ");
                info.Append(finalListEarth[number].time6 + " ");
                info.Append(finalListEarth[number].time7 + " ");
                info.Append(finalListEarth[number].time8 + " ");
                info.Append(finalListEarth[number].time9 + " ");
                info.Append(finalListEarth[number].time10 + " \r\n");
                info.Append("Дополнительная информация:\r\nПозывной: " + finalListEarth[number].nickName + " \r\n");
                info.Append("Размеры: " + finalListEarth[number].sizes + " \r\n");
                info.Append("Вес: " + finalListEarth[number].weight + " \r\n");
                info.Append("Тип: " + finalListEarth[number].type + " \r\n");
                info.Append("Назначение: " + finalListEarth[number].purpose + " \r\n");
                info.Append("Технические характеристики: " + finalListEarth[number].specification);
                infoFromDB.Text = info.ToString();
                pictureObj.ImageLocation = finalListEarth[number].picture;
            }
        }

        private void cellClickSeaTable(object sender, DataGridViewCellEventArgs e)
        {
            
            int number = e.RowIndex;
            path.Visible = false;
            path.Text = finalListSea[number].path;
            if (number != searchListFinalSea.RowCount - 1)
            {
                StringBuilder info = new StringBuilder();
                info.Append(finalListSea[number].Object + " ");
                info.Append(finalListSea[number].Source + " \r\n");
                info.Append("Частота от, МГц: " + finalListSea[number].freqFrom + " частота до, МГц: ");
                info.Append(finalListSea[number].freqBefore + " \r\n");
                info.Append("Периоды, мкс: " + finalListSea[number].t1 + " ");
                info.Append(finalListSea[number].t2 + " ");
                info.Append(finalListSea[number].t3 + " ");
                info.Append(finalListSea[number].t4 + " ");
                info.Append(finalListSea[number].t5 + " ");
                info.Append(finalListSea[number].t6 + " ");
                info.Append(finalListSea[number].t7 + " ");
                info.Append(finalListSea[number].t8 + " ");
                info.Append(finalListSea[number].t9 + " ");
                info.Append(finalListSea[number].t10 + " \r\n");
                info.Append("Длительности периодов, мкс: " + finalListSea[number].time1 + " ");
                info.Append(finalListSea[number].time2 + " ");
                info.Append(finalListSea[number].time3 + " ");
                info.Append(finalListSea[number].time4 + " ");
                info.Append(finalListSea[number].time5 + " ");
                info.Append(finalListSea[number].time6 + " ");
                info.Append(finalListSea[number].time7 + " ");
                info.Append(finalListSea[number].time8 + " ");
                info.Append(finalListSea[number].time9 + " ");
                info.Append(finalListSea[number].time10 + " \r\n");
                info.Append("Дополнительная информация:\r\nПозывной: " + finalListSea[number].nickName + " \r\n");
                info.Append("Длина корабля: " + finalListSea[number].lengthShip + " \r\n");
                info.Append("Ширина корабля: " + finalListSea[number].heightShip + " \r\n");
                info.Append("Водоизмещение: " + finalListSea[number].displacement + " \r\n");
                info.Append("Код MMSI: " + finalListSea[number].codeMMSI + " \r\n");
                info.Append("Описание: " + finalListSea[number].description + "\r\n");
                info.Append("Общая информация: " + finalListSea[number].information);
                infoFromDB.Text = info.ToString();
                pictureObj.ImageLocation = finalListSea[number].picture;
            }
        }

        private void buttonRLC_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(path.Text);
        }

        private void searchListFinalSea_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void test(object sender, EventArgs e)
        {

        }
    }
}
