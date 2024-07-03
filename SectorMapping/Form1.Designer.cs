namespace SectorMapping
{
    partial class Form1
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
            this.lstSector = new System.Windows.Forms.ListBox();
            this.lst_stocks = new System.Windows.Forms.ListBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.radNSE = new System.Windows.Forms.RadioButton();
            this.radBSE = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // lstSector
            // 
            this.lstSector.FormattingEnabled = true;
            this.lstSector.Location = new System.Drawing.Point(40, 40);
            this.lstSector.Name = "lstSector";
            this.lstSector.Size = new System.Drawing.Size(234, 511);
            this.lstSector.TabIndex = 0;
            this.lstSector.SelectedIndexChanged += new System.EventHandler(this.lstSector_SelectedIndexChanged);
            // 
            // lst_stocks
            // 
            this.lst_stocks.FormattingEnabled = true;
            this.lst_stocks.Location = new System.Drawing.Point(963, 288);
            this.lst_stocks.Name = "lst_stocks";
            this.lst_stocks.Size = new System.Drawing.Size(234, 238);
            this.lst_stocks.TabIndex = 1;
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(844, 162);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(107, 57);
            this.btn_add.TabIndex = 3;
            this.btn_add.Text = ">>>";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // txtsearch
            // 
            this.txtsearch.Location = new System.Drawing.Point(368, 16);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(133, 20);
            this.txtsearch.TabIndex = 4;
            this.txtsearch.TextChanged += new System.EventHandler(this.txtsearch_TextChanged);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(289, 40);
            this.checkedListBox1.MultiColumn = true;
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(521, 514);
            this.checkedListBox1.TabIndex = 5;
            this.checkedListBox1.ThreeDCheckBoxes = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(946, 40);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(217, 202);
            this.richTextBox1.TabIndex = 6;
            this.richTextBox1.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1021, 552);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(63, 31);
            this.button1.TabIndex = 7;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // radNSE
            // 
            this.radNSE.AutoSize = true;
            this.radNSE.Location = new System.Drawing.Point(53, 13);
            this.radNSE.Name = "radNSE";
            this.radNSE.Size = new System.Drawing.Size(47, 17);
            this.radNSE.TabIndex = 8;
            this.radNSE.TabStop = true;
            this.radNSE.Text = "NSE";
            this.radNSE.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radNSE.UseVisualStyleBackColor = true;
            this.radNSE.CheckedChanged += new System.EventHandler(this.radNSE_CheckedChanged);
            // 
            // radBSE
            // 
            this.radBSE.AutoSize = true;
            this.radBSE.Location = new System.Drawing.Point(144, 13);
            this.radBSE.Name = "radBSE";
            this.radBSE.Size = new System.Drawing.Size(46, 17);
            this.radBSE.TabIndex = 9;
            this.radBSE.TabStop = true;
            this.radBSE.Text = "BSE";
            this.radBSE.UseVisualStyleBackColor = true;
            this.radBSE.CheckedChanged += new System.EventHandler(this.radBSE_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1241, 600);
            this.Controls.Add(this.radBSE);
            this.Controls.Add(this.radNSE);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.txtsearch);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.lst_stocks);
            this.Controls.Add(this.lstSector);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstSector;
        private System.Windows.Forms.ListBox lst_stocks;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton radNSE;
        private System.Windows.Forms.RadioButton radBSE;
    }
}

