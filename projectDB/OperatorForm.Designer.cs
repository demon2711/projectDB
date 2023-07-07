namespace projectDB
{
    partial class OperatorForm
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
            this.numberLetters = new System.Windows.Forms.TextBox();
            this.viewLetters = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numberBases = new System.Windows.Forms.TextBox();
            this.output = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // numberLetters
            // 
            this.numberLetters.Location = new System.Drawing.Point(357, 11);
            this.numberLetters.Name = "numberLetters";
            this.numberLetters.Size = new System.Drawing.Size(100, 20);
            this.numberLetters.TabIndex = 0;
            // 
            // viewLetters
            // 
            this.viewLetters.Location = new System.Drawing.Point(480, 10);
            this.viewLetters.Name = "viewLetters";
            this.viewLetters.Size = new System.Drawing.Size(147, 23);
            this.viewLetters.TabIndex = 1;
            this.viewLetters.Text = "Показать донесения";
            this.viewLetters.UseVisualStyleBackColor = true;
            this.viewLetters.Click += new System.EventHandler(this.viewLetters_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Количество постов:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(230, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Количество донесений:";
            // 
            // numberBases
            // 
            this.numberBases.Location = new System.Drawing.Point(124, 12);
            this.numberBases.Name = "numberBases";
            this.numberBases.Size = new System.Drawing.Size(100, 20);
            this.numberBases.TabIndex = 4;
            // 
            // output
            // 
            this.output.Location = new System.Drawing.Point(31, 569);
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(981, 96);
            this.output.TabIndex = 5;
            this.output.Text = "";
            // 
            // OperatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1056, 717);
            this.Controls.Add(this.output);
            this.Controls.Add(this.numberBases);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.viewLetters);
            this.Controls.Add(this.numberLetters);
            this.Name = "OperatorForm";
            this.Text = "OperatorForm";
            this.Load += new System.EventHandler(this.OperatorForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox numberLetters;
        private System.Windows.Forms.Button viewLetters;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox numberBases;
        private System.Windows.Forms.RichTextBox output;
    }
}