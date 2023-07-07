namespace projectDB
{
    partial class DataBaseListInfo
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
            this.infoDataBaseAir = new System.Windows.Forms.DataGridView();
            this.Ok = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.infoDataBaseEarth = new System.Windows.Forms.DataGridView();
            this.infoDataBaseSea = new System.Windows.Forms.DataGridView();
            this.infoFromDB = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureObj = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonRLC = new System.Windows.Forms.Button();
            this.path = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.infoDataBaseAir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.infoDataBaseEarth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.infoDataBaseSea)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureObj)).BeginInit();
            this.SuspendLayout();
            // 
            // infoDataBaseAir
            // 
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.infoDataBaseAir.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.infoDataBaseAir.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.infoDataBaseAir.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.infoDataBaseAir.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Cascadia Mono", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.infoDataBaseAir.DefaultCellStyle = dataGridViewCellStyle2;
            this.infoDataBaseAir.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.infoDataBaseAir.Location = new System.Drawing.Point(12, 12);
            this.infoDataBaseAir.Name = "infoDataBaseAir";
            this.infoDataBaseAir.ReadOnly = true;
            this.infoDataBaseAir.RowTemplate.Height = 20;
            this.infoDataBaseAir.RowTemplate.ReadOnly = true;
            this.infoDataBaseAir.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.infoDataBaseAir.Size = new System.Drawing.Size(315, 176);
            this.infoDataBaseAir.TabIndex = 0;
            this.infoDataBaseAir.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.cellAirTable_Click);
            // 
            // Ok
            // 
            this.Ok.Location = new System.Drawing.Point(454, 582);
            this.Ok.Name = "Ok";
            this.Ok.Size = new System.Drawing.Size(91, 32);
            this.Ok.TabIndex = 1;
            this.Ok.Text = "OK";
            this.Ok.UseVisualStyleBackColor = true;
            this.Ok.Click += new System.EventHandler(this.Ok_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(814, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // infoDataBaseEarth
            // 
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.infoDataBaseEarth.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.infoDataBaseEarth.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.infoDataBaseEarth.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.infoDataBaseEarth.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Cascadia Mono", 10F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.infoDataBaseEarth.DefaultCellStyle = dataGridViewCellStyle4;
            this.infoDataBaseEarth.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.infoDataBaseEarth.Location = new System.Drawing.Point(342, 12);
            this.infoDataBaseEarth.Name = "infoDataBaseEarth";
            this.infoDataBaseEarth.ReadOnly = true;
            this.infoDataBaseEarth.RowTemplate.Height = 20;
            this.infoDataBaseEarth.RowTemplate.ReadOnly = true;
            this.infoDataBaseEarth.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.infoDataBaseEarth.Size = new System.Drawing.Size(315, 176);
            this.infoDataBaseEarth.TabIndex = 3;
            this.infoDataBaseEarth.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.cellEarthTable_Click);
            // 
            // infoDataBaseSea
            // 
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.infoDataBaseSea.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.infoDataBaseSea.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.infoDataBaseSea.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.infoDataBaseSea.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Cascadia Mono", 10F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.infoDataBaseSea.DefaultCellStyle = dataGridViewCellStyle6;
            this.infoDataBaseSea.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.infoDataBaseSea.Location = new System.Drawing.Point(672, 12);
            this.infoDataBaseSea.Name = "infoDataBaseSea";
            this.infoDataBaseSea.ReadOnly = true;
            this.infoDataBaseSea.RowTemplate.Height = 20;
            this.infoDataBaseSea.RowTemplate.ReadOnly = true;
            this.infoDataBaseSea.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.infoDataBaseSea.Size = new System.Drawing.Size(315, 176);
            this.infoDataBaseSea.TabIndex = 4;
            this.infoDataBaseSea.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.cellSeaTable_Click);
            // 
            // infoFromDB
            // 
            this.infoFromDB.BackColor = System.Drawing.SystemColors.HighlightText;
            this.infoFromDB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.infoFromDB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.infoFromDB.Location = new System.Drawing.Point(12, 222);
            this.infoFromDB.Name = "infoFromDB";
            this.infoFromDB.ReadOnly = true;
            this.infoFromDB.Size = new System.Drawing.Size(619, 350);
            this.infoFromDB.TabIndex = 251;
            this.infoFromDB.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(781, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 24);
            this.label2.TabIndex = 295;
            this.label2.Text = "Фото";
            // 
            // pictureObj
            // 
            this.pictureObj.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pictureObj.Location = new System.Drawing.Point(658, 222);
            this.pictureObj.Name = "pictureObj";
            this.pictureObj.Size = new System.Drawing.Size(318, 289);
            this.pictureObj.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureObj.TabIndex = 294;
            this.pictureObj.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 20);
            this.label3.TabIndex = 296;
            this.label3.Text = "Информация:";
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.HeaderText = "Записи (воздух)";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.HeaderText = "Записи (земля)";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.HeaderText = "Записи (море)";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // buttonRLC
            // 
            this.buttonRLC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRLC.Location = new System.Drawing.Point(747, 527);
            this.buttonRLC.Name = "buttonRLC";
            this.buttonRLC.Size = new System.Drawing.Size(154, 45);
            this.buttonRLC.TabIndex = 297;
            this.buttonRLC.Text = "Файл с сигналом РЛС";
            this.buttonRLC.UseVisualStyleBackColor = true;
            this.buttonRLC.Click += new System.EventHandler(this.buttonRLC_Click);
            // 
            // path
            // 
            this.path.AutoSize = true;
            this.path.Location = new System.Drawing.Point(487, 450);
            this.path.Name = "path";
            this.path.Size = new System.Drawing.Size(35, 13);
            this.path.TabIndex = 298;
            this.path.Text = "label4";
            // 
            // DataBaseListInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 624);
            this.Controls.Add(this.buttonRLC);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureObj);
            this.Controls.Add(this.infoFromDB);
            this.Controls.Add(this.infoDataBaseSea);
            this.Controls.Add(this.infoDataBaseEarth);
            this.Controls.Add(this.Ok);
            this.Controls.Add(this.infoDataBaseAir);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.path);
            this.Name = "DataBaseListInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.DataBaseListInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.infoDataBaseAir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.infoDataBaseEarth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.infoDataBaseSea)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureObj)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView infoDataBaseAir;
        private System.Windows.Forms.Button Ok;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView infoDataBaseEarth;
        private System.Windows.Forms.DataGridView infoDataBaseSea;
        private System.Windows.Forms.RichTextBox infoFromDB;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureObj;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonRLC;
        private System.Windows.Forms.Label path;
    }
}