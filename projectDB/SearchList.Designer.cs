namespace projectDB
{
    partial class SearchList
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.buttonClose = new System.Windows.Forms.Button();
            this.searchListFinalSea = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.searchListFinalEarth = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label14 = new System.Windows.Forms.Label();
            this.searchListFinalAir = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.infoFromDB = new System.Windows.Forms.RichTextBox();
            this.pictureObj = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonRLC = new System.Windows.Forms.Button();
            this.path = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.searchListFinalSea)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchListFinalEarth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchListFinalAir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureObj)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(323, 535);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 23);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "ОК";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // searchListFinalSea
            // 
            this.searchListFinalSea.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.searchListFinalSea.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.searchListFinalSea.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.searchListFinalSea.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Cascadia Mono", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.searchListFinalSea.DefaultCellStyle = dataGridViewCellStyle2;
            this.searchListFinalSea.GridColor = System.Drawing.SystemColors.HighlightText;
            this.searchListFinalSea.Location = new System.Drawing.Point(480, 12);
            this.searchListFinalSea.Name = "searchListFinalSea";
            this.searchListFinalSea.ReadOnly = true;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.searchListFinalSea.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.searchListFinalSea.RowTemplate.Height = 20;
            this.searchListFinalSea.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.searchListFinalSea.Size = new System.Drawing.Size(228, 157);
            this.searchListFinalSea.TabIndex = 2;
            this.searchListFinalSea.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.cellClickSeaTable);
            this.searchListFinalSea.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.searchListFinalSea_CellContentClick);
            this.searchListFinalSea.DoubleClick += new System.EventHandler(this.test);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.HeaderText = "Записи (море)";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // searchListFinalEarth
            // 
            this.searchListFinalEarth.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.searchListFinalEarth.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.searchListFinalEarth.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.searchListFinalEarth.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Cascadia Mono", 10F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.searchListFinalEarth.DefaultCellStyle = dataGridViewCellStyle5;
            this.searchListFinalEarth.GridColor = System.Drawing.SystemColors.HighlightText;
            this.searchListFinalEarth.Location = new System.Drawing.Point(246, 12);
            this.searchListFinalEarth.Name = "searchListFinalEarth";
            this.searchListFinalEarth.ReadOnly = true;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.searchListFinalEarth.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.searchListFinalEarth.RowTemplate.Height = 20;
            this.searchListFinalEarth.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.searchListFinalEarth.Size = new System.Drawing.Size(228, 157);
            this.searchListFinalEarth.TabIndex = 3;
            this.searchListFinalEarth.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.cellClickEarthTable);
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.HeaderText = "Записи (земля)";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.SystemColors.Desktop;
            this.label14.Location = new System.Drawing.Point(-74, 178);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(856, 3);
            this.label14.TabIndex = 248;
            // 
            // searchListFinalAir
            // 
            this.searchListFinalAir.AllowUserToDeleteRows = false;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.searchListFinalAir.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.searchListFinalAir.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.searchListFinalAir.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Cascadia Mono", 10F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.searchListFinalAir.DefaultCellStyle = dataGridViewCellStyle8;
            this.searchListFinalAir.GridColor = System.Drawing.SystemColors.HighlightText;
            this.searchListFinalAir.Location = new System.Drawing.Point(12, 12);
            this.searchListFinalAir.Name = "searchListFinalAir";
            this.searchListFinalAir.ReadOnly = true;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.searchListFinalAir.RowsDefaultCellStyle = dataGridViewCellStyle9;
            this.searchListFinalAir.RowTemplate.Height = 20;
            this.searchListFinalAir.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.searchListFinalAir.Size = new System.Drawing.Size(228, 157);
            this.searchListFinalAir.TabIndex = 249;
            this.searchListFinalAir.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.cellClickAirTable);
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.HeaderText = "Записи (воздух)";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // infoFromDB
            // 
            this.infoFromDB.BackColor = System.Drawing.SystemColors.Menu;
            this.infoFromDB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.infoFromDB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.infoFromDB.Location = new System.Drawing.Point(13, 185);
            this.infoFromDB.Name = "infoFromDB";
            this.infoFromDB.ReadOnly = true;
            this.infoFromDB.Size = new System.Drawing.Size(491, 344);
            this.infoFromDB.TabIndex = 250;
            this.infoFromDB.Text = "";
            // 
            // pictureObj
            // 
            this.pictureObj.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pictureObj.Location = new System.Drawing.Point(510, 185);
            this.pictureObj.Name = "pictureObj";
            this.pictureObj.Size = new System.Drawing.Size(198, 198);
            this.pictureObj.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureObj.TabIndex = 292;
            this.pictureObj.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(583, 386);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 24);
            this.label1.TabIndex = 293;
            this.label1.Text = "Фото";
            // 
            // buttonRLC
            // 
            this.buttonRLC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRLC.Location = new System.Drawing.Point(539, 442);
            this.buttonRLC.Name = "buttonRLC";
            this.buttonRLC.Size = new System.Drawing.Size(154, 45);
            this.buttonRLC.TabIndex = 294;
            this.buttonRLC.Text = "Файл с сигналом РЛС";
            this.buttonRLC.UseVisualStyleBackColor = true;
            this.buttonRLC.Click += new System.EventHandler(this.buttonRLC_Click);
            // 
            // path
            // 
            this.path.AutoSize = true;
            this.path.Location = new System.Drawing.Point(276, 442);
            this.path.Name = "path";
            this.path.Size = new System.Drawing.Size(35, 13);
            this.path.TabIndex = 295;
            this.path.Text = "label2";
            // 
            // SearchList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(719, 566);
            this.Controls.Add(this.buttonRLC);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureObj);
            this.Controls.Add(this.infoFromDB);
            this.Controls.Add(this.searchListFinalAir);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.searchListFinalEarth);
            this.Controls.Add(this.searchListFinalSea);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.path);
            this.Name = "SearchList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.SearchList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.searchListFinalSea)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchListFinalEarth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchListFinalAir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureObj)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.DataGridView searchListFinalSea;
        private System.Windows.Forms.DataGridView searchListFinalEarth;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridView searchListFinalAir;
        private System.Windows.Forms.RichTextBox infoFromDB;
        private System.Windows.Forms.PictureBox pictureObj;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Button buttonRLC;
        private System.Windows.Forms.Label path;
    }
}