namespace projectDB
{
    partial class Search
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.seeData = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.freq1 = new System.Windows.Forms.TextBox();
            this.freq10 = new System.Windows.Forms.TextBox();
            this.freq9 = new System.Windows.Forms.TextBox();
            this.freq8 = new System.Windows.Forms.TextBox();
            this.freq7 = new System.Windows.Forms.TextBox();
            this.freq6 = new System.Windows.Forms.TextBox();
            this.freq5 = new System.Windows.Forms.TextBox();
            this.freq4 = new System.Windows.Forms.TextBox();
            this.freq3 = new System.Windows.Forms.TextBox();
            this.freq2 = new System.Windows.Forms.TextBox();
            this.T2 = new System.Windows.Forms.TextBox();
            this.T3 = new System.Windows.Forms.TextBox();
            this.T4 = new System.Windows.Forms.TextBox();
            this.T5 = new System.Windows.Forms.TextBox();
            this.T6 = new System.Windows.Forms.TextBox();
            this.T7 = new System.Windows.Forms.TextBox();
            this.T8 = new System.Windows.Forms.TextBox();
            this.T9 = new System.Windows.Forms.TextBox();
            this.T10 = new System.Windows.Forms.TextBox();
            this.T1 = new System.Windows.Forms.TextBox();
            this.time2 = new System.Windows.Forms.TextBox();
            this.time3 = new System.Windows.Forms.TextBox();
            this.time4 = new System.Windows.Forms.TextBox();
            this.time5 = new System.Windows.Forms.TextBox();
            this.time6 = new System.Windows.Forms.TextBox();
            this.time7 = new System.Windows.Forms.TextBox();
            this.time8 = new System.Windows.Forms.TextBox();
            this.time9 = new System.Windows.Forms.TextBox();
            this.time10 = new System.Windows.Forms.TextBox();
            this.time1 = new System.Windows.Forms.TextBox();
            this.periodAntenna = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.OperatorButton = new System.Windows.Forms.Button();
            this.editMode = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.clearButton = new System.Windows.Forms.Button();
            this.numberFreqCell = new System.Windows.Forms.ComboBox();
            this.numberMatchFreq = new System.Windows.Forms.ComboBox();
            this.numberMatchImpulse = new System.Windows.Forms.ComboBox();
            this.numberImpulseCell = new System.Windows.Forms.ComboBox();
            this.numberMatchPeriod = new System.Windows.Forms.ComboBox();
            this.numberPeriodCell = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // seeData
            // 
            this.seeData.Location = new System.Drawing.Point(12, 425);
            this.seeData.Name = "seeData";
            this.seeData.Size = new System.Drawing.Size(158, 31);
            this.seeData.TabIndex = 0;
            this.seeData.Text = "Просмотр записей";
            this.seeData.UseVisualStyleBackColor = true;
            this.seeData.Click += new System.EventHandler(this.seeData_Click);
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(585, 425);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(82, 31);
            this.searchButton.TabIndex = 1;
            this.searchButton.Text = "Поиск";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // freq1
            // 
            this.freq1.Enabled = false;
            this.freq1.Location = new System.Drawing.Point(12, 243);
            this.freq1.Name = "freq1";
            this.freq1.Size = new System.Drawing.Size(60, 20);
            this.freq1.TabIndex = 2;
            this.freq1.Leave += new System.EventHandler(this.replaceFreq1);
            // 
            // freq10
            // 
            this.freq10.Enabled = false;
            this.freq10.Location = new System.Drawing.Point(606, 243);
            this.freq10.Name = "freq10";
            this.freq10.Size = new System.Drawing.Size(60, 20);
            this.freq10.TabIndex = 5;
            this.freq10.Leave += new System.EventHandler(this.replaceFreq10);
            // 
            // freq9
            // 
            this.freq9.Enabled = false;
            this.freq9.Location = new System.Drawing.Point(540, 243);
            this.freq9.Name = "freq9";
            this.freq9.Size = new System.Drawing.Size(60, 20);
            this.freq9.TabIndex = 6;
            this.freq9.Leave += new System.EventHandler(this.replaceFreq9);
            // 
            // freq8
            // 
            this.freq8.Enabled = false;
            this.freq8.Location = new System.Drawing.Point(474, 243);
            this.freq8.Name = "freq8";
            this.freq8.Size = new System.Drawing.Size(60, 20);
            this.freq8.TabIndex = 7;
            this.freq8.Leave += new System.EventHandler(this.replaceFreq8);
            // 
            // freq7
            // 
            this.freq7.Enabled = false;
            this.freq7.Location = new System.Drawing.Point(408, 243);
            this.freq7.Name = "freq7";
            this.freq7.Size = new System.Drawing.Size(60, 20);
            this.freq7.TabIndex = 8;
            this.freq7.Leave += new System.EventHandler(this.replaceFreq7);
            // 
            // freq6
            // 
            this.freq6.Enabled = false;
            this.freq6.Location = new System.Drawing.Point(342, 243);
            this.freq6.Name = "freq6";
            this.freq6.Size = new System.Drawing.Size(60, 20);
            this.freq6.TabIndex = 9;
            this.freq6.Leave += new System.EventHandler(this.replaceFreq6);
            // 
            // freq5
            // 
            this.freq5.Enabled = false;
            this.freq5.Location = new System.Drawing.Point(276, 243);
            this.freq5.Name = "freq5";
            this.freq5.Size = new System.Drawing.Size(60, 20);
            this.freq5.TabIndex = 10;
            this.freq5.Leave += new System.EventHandler(this.replaceFreq5);
            // 
            // freq4
            // 
            this.freq4.Enabled = false;
            this.freq4.Location = new System.Drawing.Point(210, 243);
            this.freq4.Name = "freq4";
            this.freq4.Size = new System.Drawing.Size(60, 20);
            this.freq4.TabIndex = 11;
            this.freq4.Leave += new System.EventHandler(this.replaceFreq4);
            // 
            // freq3
            // 
            this.freq3.Enabled = false;
            this.freq3.Location = new System.Drawing.Point(144, 243);
            this.freq3.Name = "freq3";
            this.freq3.Size = new System.Drawing.Size(60, 20);
            this.freq3.TabIndex = 12;
            this.freq3.Leave += new System.EventHandler(this.replaceFreq3);
            // 
            // freq2
            // 
            this.freq2.Enabled = false;
            this.freq2.Location = new System.Drawing.Point(78, 243);
            this.freq2.Name = "freq2";
            this.freq2.Size = new System.Drawing.Size(60, 20);
            this.freq2.TabIndex = 13;
            this.freq2.Leave += new System.EventHandler(this.replaceFreq2);
            // 
            // T2
            // 
            this.T2.Enabled = false;
            this.T2.Location = new System.Drawing.Point(78, 308);
            this.T2.Name = "T2";
            this.T2.Size = new System.Drawing.Size(60, 20);
            this.T2.TabIndex = 23;
            this.T2.Leave += new System.EventHandler(this.replacePeriod2);
            // 
            // T3
            // 
            this.T3.Enabled = false;
            this.T3.Location = new System.Drawing.Point(144, 308);
            this.T3.Name = "T3";
            this.T3.Size = new System.Drawing.Size(60, 20);
            this.T3.TabIndex = 22;
            this.T3.Leave += new System.EventHandler(this.replacePeriod3);
            // 
            // T4
            // 
            this.T4.Enabled = false;
            this.T4.Location = new System.Drawing.Point(210, 308);
            this.T4.Name = "T4";
            this.T4.Size = new System.Drawing.Size(60, 20);
            this.T4.TabIndex = 21;
            this.T4.Leave += new System.EventHandler(this.replacePeriod4);
            // 
            // T5
            // 
            this.T5.Enabled = false;
            this.T5.Location = new System.Drawing.Point(276, 308);
            this.T5.Name = "T5";
            this.T5.Size = new System.Drawing.Size(60, 20);
            this.T5.TabIndex = 20;
            this.T5.Leave += new System.EventHandler(this.replacePeriod5);
            // 
            // T6
            // 
            this.T6.Enabled = false;
            this.T6.Location = new System.Drawing.Point(342, 308);
            this.T6.Name = "T6";
            this.T6.Size = new System.Drawing.Size(60, 20);
            this.T6.TabIndex = 19;
            this.T6.Leave += new System.EventHandler(this.replacePeriod6);
            // 
            // T7
            // 
            this.T7.Enabled = false;
            this.T7.Location = new System.Drawing.Point(408, 308);
            this.T7.Name = "T7";
            this.T7.Size = new System.Drawing.Size(60, 20);
            this.T7.TabIndex = 18;
            this.T7.Leave += new System.EventHandler(this.replacePeriod7);
            // 
            // T8
            // 
            this.T8.Enabled = false;
            this.T8.Location = new System.Drawing.Point(474, 308);
            this.T8.Name = "T8";
            this.T8.Size = new System.Drawing.Size(60, 20);
            this.T8.TabIndex = 17;
            this.T8.Leave += new System.EventHandler(this.replacePeriod8);
            // 
            // T9
            // 
            this.T9.Enabled = false;
            this.T9.Location = new System.Drawing.Point(540, 308);
            this.T9.Name = "T9";
            this.T9.Size = new System.Drawing.Size(60, 20);
            this.T9.TabIndex = 16;
            this.T9.Leave += new System.EventHandler(this.replacePeriod9);
            // 
            // T10
            // 
            this.T10.Enabled = false;
            this.T10.Location = new System.Drawing.Point(606, 308);
            this.T10.Name = "T10";
            this.T10.Size = new System.Drawing.Size(60, 20);
            this.T10.TabIndex = 15;
            this.T10.Leave += new System.EventHandler(this.replacePeriod10);
            // 
            // T1
            // 
            this.T1.Enabled = false;
            this.T1.Location = new System.Drawing.Point(12, 308);
            this.T1.Name = "T1";
            this.T1.Size = new System.Drawing.Size(60, 20);
            this.T1.TabIndex = 14;
            this.T1.Leave += new System.EventHandler(this.replacePeriod1);
            // 
            // time2
            // 
            this.time2.Enabled = false;
            this.time2.Location = new System.Drawing.Point(78, 377);
            this.time2.Name = "time2";
            this.time2.Size = new System.Drawing.Size(60, 20);
            this.time2.TabIndex = 33;
            this.time2.Leave += new System.EventHandler(this.replaceTime2);
            // 
            // time3
            // 
            this.time3.Enabled = false;
            this.time3.Location = new System.Drawing.Point(144, 377);
            this.time3.Name = "time3";
            this.time3.Size = new System.Drawing.Size(60, 20);
            this.time3.TabIndex = 32;
            this.time3.Leave += new System.EventHandler(this.replaceTime3);
            // 
            // time4
            // 
            this.time4.Enabled = false;
            this.time4.Location = new System.Drawing.Point(210, 377);
            this.time4.Name = "time4";
            this.time4.Size = new System.Drawing.Size(60, 20);
            this.time4.TabIndex = 31;
            this.time4.Leave += new System.EventHandler(this.replaceTime4);
            // 
            // time5
            // 
            this.time5.Enabled = false;
            this.time5.Location = new System.Drawing.Point(276, 377);
            this.time5.Name = "time5";
            this.time5.Size = new System.Drawing.Size(60, 20);
            this.time5.TabIndex = 30;
            this.time5.Leave += new System.EventHandler(this.replaceTime5);
            // 
            // time6
            // 
            this.time6.Enabled = false;
            this.time6.Location = new System.Drawing.Point(342, 377);
            this.time6.Name = "time6";
            this.time6.Size = new System.Drawing.Size(60, 20);
            this.time6.TabIndex = 29;
            this.time6.Leave += new System.EventHandler(this.replaceTime6);
            // 
            // time7
            // 
            this.time7.Enabled = false;
            this.time7.Location = new System.Drawing.Point(408, 377);
            this.time7.Name = "time7";
            this.time7.Size = new System.Drawing.Size(60, 20);
            this.time7.TabIndex = 28;
            this.time7.Leave += new System.EventHandler(this.replaceTime7);
            // 
            // time8
            // 
            this.time8.Enabled = false;
            this.time8.Location = new System.Drawing.Point(474, 377);
            this.time8.Name = "time8";
            this.time8.Size = new System.Drawing.Size(60, 20);
            this.time8.TabIndex = 27;
            this.time8.Leave += new System.EventHandler(this.replaceTime8);
            // 
            // time9
            // 
            this.time9.Enabled = false;
            this.time9.Location = new System.Drawing.Point(540, 377);
            this.time9.Name = "time9";
            this.time9.Size = new System.Drawing.Size(60, 20);
            this.time9.TabIndex = 26;
            this.time9.Leave += new System.EventHandler(this.replaceTime9);
            // 
            // time10
            // 
            this.time10.Enabled = false;
            this.time10.Location = new System.Drawing.Point(606, 377);
            this.time10.Name = "time10";
            this.time10.Size = new System.Drawing.Size(60, 20);
            this.time10.TabIndex = 25;
            this.time10.Leave += new System.EventHandler(this.replaceTime10);
            // 
            // time1
            // 
            this.time1.Enabled = false;
            this.time1.Location = new System.Drawing.Point(12, 377);
            this.time1.Name = "time1";
            this.time1.Size = new System.Drawing.Size(60, 20);
            this.time1.TabIndex = 24;
            this.time1.Leave += new System.EventHandler(this.replaceTime1);
            // 
            // periodAntenna
            // 
            this.periodAntenna.Location = new System.Drawing.Point(606, 33);
            this.periodAntenna.Name = "periodAntenna";
            this.periodAntenna.Size = new System.Drawing.Size(60, 20);
            this.periodAntenna.TabIndex = 34;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(225, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 35;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // OperatorButton
            // 
            this.OperatorButton.Location = new System.Drawing.Point(118, 12);
            this.OperatorButton.Name = "OperatorButton";
            this.OperatorButton.Size = new System.Drawing.Size(75, 23);
            this.OperatorButton.TabIndex = 36;
            this.OperatorButton.Text = "Оператор";
            this.OperatorButton.UseVisualStyleBackColor = true;
            this.OperatorButton.Click += new System.EventHandler(this.operatorButton_Click);
            // 
            // editMode
            // 
            this.editMode.Location = new System.Drawing.Point(12, 12);
            this.editMode.Name = "editMode";
            this.editMode.Size = new System.Drawing.Size(75, 23);
            this.editMode.TabIndex = 37;
            this.editMode.Text = "Редактор";
            this.editMode.UseVisualStyleBackColor = true;
            this.editMode.Click += new System.EventHandler(this.editMode_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(525, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 13);
            this.label1.TabIndex = 38;
            this.label1.Text = "Период вращения антенны:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 224);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 13);
            this.label2.TabIndex = 39;
            this.label2.Text = "Рабочая частота, МГц:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 289);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 40;
            this.label3.Text = "Период, мкс:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 358);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 13);
            this.label4.TabIndex = 41;
            this.label4.Text = "Длительность импульса, мкс:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(255, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 42;
            this.label5.Text = "label5";
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(488, 425);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(89, 31);
            this.clearButton.TabIndex = 43;
            this.clearButton.Text = "Очистить";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // numberFreqCell
            // 
            this.numberFreqCell.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.numberFreqCell.FormattingEnabled = true;
            this.numberFreqCell.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.numberFreqCell.Location = new System.Drawing.Point(136, 138);
            this.numberFreqCell.Name = "numberFreqCell";
            this.numberFreqCell.Size = new System.Drawing.Size(71, 21);
            this.numberFreqCell.TabIndex = 44;
            this.numberFreqCell.SelectedIndexChanged += new System.EventHandler(this.numberCellFreqChanged);
            // 
            // numberMatchFreq
            // 
            this.numberMatchFreq.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.numberMatchFreq.FormattingEnabled = true;
            this.numberMatchFreq.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.numberMatchFreq.Location = new System.Drawing.Point(136, 181);
            this.numberMatchFreq.Name = "numberMatchFreq";
            this.numberMatchFreq.Size = new System.Drawing.Size(71, 21);
            this.numberMatchFreq.TabIndex = 45;
            // 
            // numberMatchImpulse
            // 
            this.numberMatchImpulse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.numberMatchImpulse.FormattingEnabled = true;
            this.numberMatchImpulse.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.numberMatchImpulse.Location = new System.Drawing.Point(594, 180);
            this.numberMatchImpulse.Name = "numberMatchImpulse";
            this.numberMatchImpulse.Size = new System.Drawing.Size(71, 21);
            this.numberMatchImpulse.TabIndex = 46;
            // 
            // numberImpulseCell
            // 
            this.numberImpulseCell.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.numberImpulseCell.FormattingEnabled = true;
            this.numberImpulseCell.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.numberImpulseCell.Location = new System.Drawing.Point(594, 137);
            this.numberImpulseCell.Name = "numberImpulseCell";
            this.numberImpulseCell.Size = new System.Drawing.Size(71, 21);
            this.numberImpulseCell.TabIndex = 47;
            this.numberImpulseCell.SelectedIndexChanged += new System.EventHandler(this.numberCellImpulseChanged);
            // 
            // numberMatchPeriod
            // 
            this.numberMatchPeriod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.numberMatchPeriod.FormattingEnabled = true;
            this.numberMatchPeriod.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.numberMatchPeriod.Location = new System.Drawing.Point(363, 180);
            this.numberMatchPeriod.Name = "numberMatchPeriod";
            this.numberMatchPeriod.Size = new System.Drawing.Size(71, 21);
            this.numberMatchPeriod.TabIndex = 48;
            // 
            // numberPeriodCell
            // 
            this.numberPeriodCell.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.numberPeriodCell.FormattingEnabled = true;
            this.numberPeriodCell.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.numberPeriodCell.Location = new System.Drawing.Point(363, 137);
            this.numberPeriodCell.Name = "numberPeriodCell";
            this.numberPeriodCell.Size = new System.Drawing.Size(71, 21);
            this.numberPeriodCell.TabIndex = 49;
            this.numberPeriodCell.SelectedIndexChanged += new System.EventHandler(this.numberCellPeriodChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(155, 114);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 50;
            this.label6.Text = "Частота";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(531, 114);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(132, 13);
            this.label7.TabIndex = 51;
            this.label7.Text = "Длительность импульса";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(378, 114);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 13);
            this.label8.TabIndex = 52;
            this.label8.Text = "Период";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(33, 141);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(101, 13);
            this.label9.TabIndex = 53;
            this.label9.Text = "Количество ячеек:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(259, 141);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(101, 13);
            this.label10.TabIndex = 54;
            this.label10.Text = "Количество ячеек:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(491, 142);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(101, 13);
            this.label11.TabIndex = 55;
            this.label11.Text = "Количество ячеек:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(3, 183);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(132, 13);
            this.label12.TabIndex = 56;
            this.label12.Text = "Количество совпадений:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(230, 184);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(132, 13);
            this.label13.TabIndex = 57;
            this.label13.Text = "Количество совпадений:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(462, 184);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(132, 13);
            this.label14.TabIndex = 58;
            this.label14.Text = "Количество совпадений:";
            // 
            // Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 475);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.numberPeriodCell);
            this.Controls.Add(this.numberMatchPeriod);
            this.Controls.Add(this.numberImpulseCell);
            this.Controls.Add(this.numberMatchImpulse);
            this.Controls.Add(this.numberMatchFreq);
            this.Controls.Add(this.numberFreqCell);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.editMode);
            this.Controls.Add(this.OperatorButton);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.periodAntenna);
            this.Controls.Add(this.time2);
            this.Controls.Add(this.time3);
            this.Controls.Add(this.time4);
            this.Controls.Add(this.time5);
            this.Controls.Add(this.time6);
            this.Controls.Add(this.time7);
            this.Controls.Add(this.time8);
            this.Controls.Add(this.time9);
            this.Controls.Add(this.time10);
            this.Controls.Add(this.time1);
            this.Controls.Add(this.T2);
            this.Controls.Add(this.T3);
            this.Controls.Add(this.T4);
            this.Controls.Add(this.T5);
            this.Controls.Add(this.T6);
            this.Controls.Add(this.T7);
            this.Controls.Add(this.T8);
            this.Controls.Add(this.T9);
            this.Controls.Add(this.T10);
            this.Controls.Add(this.T1);
            this.Controls.Add(this.freq2);
            this.Controls.Add(this.freq3);
            this.Controls.Add(this.freq4);
            this.Controls.Add(this.freq5);
            this.Controls.Add(this.freq6);
            this.Controls.Add(this.freq7);
            this.Controls.Add(this.freq8);
            this.Controls.Add(this.freq9);
            this.Controls.Add(this.freq10);
            this.Controls.Add(this.freq1);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.seeData);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label11);
            this.Name = "Search";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Search_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button seeData;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox freq1;
        private System.Windows.Forms.TextBox freq10;
        private System.Windows.Forms.TextBox freq9;
        private System.Windows.Forms.TextBox freq8;
        private System.Windows.Forms.TextBox freq7;
        private System.Windows.Forms.TextBox freq6;
        private System.Windows.Forms.TextBox freq5;
        private System.Windows.Forms.TextBox freq4;
        private System.Windows.Forms.TextBox freq3;
        private System.Windows.Forms.TextBox freq2;
        private System.Windows.Forms.TextBox T2;
        private System.Windows.Forms.TextBox T3;
        private System.Windows.Forms.TextBox T4;
        private System.Windows.Forms.TextBox T5;
        private System.Windows.Forms.TextBox T6;
        private System.Windows.Forms.TextBox T7;
        private System.Windows.Forms.TextBox T8;
        private System.Windows.Forms.TextBox T9;
        private System.Windows.Forms.TextBox T10;
        private System.Windows.Forms.TextBox T1;
        private System.Windows.Forms.TextBox time2;
        private System.Windows.Forms.TextBox time3;
        private System.Windows.Forms.TextBox time4;
        private System.Windows.Forms.TextBox time5;
        private System.Windows.Forms.TextBox time6;
        private System.Windows.Forms.TextBox time7;
        private System.Windows.Forms.TextBox time8;
        private System.Windows.Forms.TextBox time9;
        private System.Windows.Forms.TextBox time10;
        private System.Windows.Forms.TextBox time1;
        private System.Windows.Forms.TextBox periodAntenna;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button OperatorButton;
        private System.Windows.Forms.Button editMode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.ComboBox numberFreqCell;
        private System.Windows.Forms.ComboBox numberMatchFreq;
        private System.Windows.Forms.ComboBox numberMatchImpulse;
        private System.Windows.Forms.ComboBox numberImpulseCell;
        private System.Windows.Forms.ComboBox numberMatchPeriod;
        private System.Windows.Forms.ComboBox numberPeriodCell;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
    }
}

