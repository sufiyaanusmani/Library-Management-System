namespace LibraryManagementSystem
{
    partial class AddBook
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
            this.rbtnEnglish = new System.Windows.Forms.GroupBox();
            this.rbtnChinese = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtISBN = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.rbtnEng = new System.Windows.Forms.RadioButton();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.rbtnEnglish.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbtnEnglish
            // 
            this.rbtnEnglish.Controls.Add(this.rbtnChinese);
            this.rbtnEnglish.Controls.Add(this.label5);
            this.rbtnEnglish.Controls.Add(this.txtPrice);
            this.rbtnEnglish.Controls.Add(this.label4);
            this.rbtnEnglish.Controls.Add(this.txtAuthor);
            this.rbtnEnglish.Controls.Add(this.label3);
            this.rbtnEnglish.Controls.Add(this.txtISBN);
            this.rbtnEnglish.Controls.Add(this.label2);
            this.rbtnEnglish.Controls.Add(this.button1);
            this.rbtnEnglish.Controls.Add(this.rbtnEng);
            this.rbtnEnglish.Controls.Add(this.txtTitle);
            this.rbtnEnglish.Controls.Add(this.label1);
            this.rbtnEnglish.Location = new System.Drawing.Point(13, 59);
            this.rbtnEnglish.Name = "rbtnEnglish";
            this.rbtnEnglish.Size = new System.Drawing.Size(371, 370);
            this.rbtnEnglish.TabIndex = 0;
            this.rbtnEnglish.TabStop = false;
            this.rbtnEnglish.Text = "Book Details";
            // 
            // rbtnChinese
            // 
            this.rbtnChinese.AutoSize = true;
            this.rbtnChinese.Location = new System.Drawing.Point(203, 231);
            this.rbtnChinese.Name = "rbtnChinese";
            this.rbtnChinese.Size = new System.Drawing.Size(63, 17);
            this.rbtnChinese.TabIndex = 6;
            this.rbtnChinese.TabStop = true;
            this.rbtnChinese.Text = "Chinese";
            this.rbtnChinese.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(31, 230);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 18);
            this.label5.TabIndex = 10;
            this.label5.Text = "Language :";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(98, 183);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(233, 20);
            this.txtPrice.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(31, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 18);
            this.label4.TabIndex = 9;
            this.label4.Text = "Price :";
            // 
            // txtAuthor
            // 
            this.txtAuthor.Location = new System.Drawing.Point(98, 136);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(233, 20);
            this.txtAuthor.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(33, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 18);
            this.label3.TabIndex = 10;
            this.label3.Text = "Author :";
            // 
            // txtISBN
            // 
            this.txtISBN.Location = new System.Drawing.Point(98, 90);
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.Size = new System.Drawing.Size(233, 20);
            this.txtISBN.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 18);
            this.label2.TabIndex = 9;
            this.label2.Text = "ISBN :";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(105)))), ((int)(((byte)(189)))));
            this.button1.Font = new System.Drawing.Font("Dubai", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(34, 279);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(297, 45);
            this.button1.TabIndex = 7;
            this.button1.Text = "Add Book";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // rbtnEng
            // 
            this.rbtnEng.AutoSize = true;
            this.rbtnEng.Location = new System.Drawing.Point(122, 231);
            this.rbtnEng.Name = "rbtnEng";
            this.rbtnEng.Size = new System.Drawing.Size(59, 17);
            this.rbtnEng.TabIndex = 5;
            this.rbtnEng.TabStop = true;
            this.rbtnEng.Text = "English";
            this.rbtnEng.UseVisualStyleBackColor = true;
            this.rbtnEng.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(98, 45);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(233, 20);
            this.txtTitle.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Title :";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(13, 24);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // AddBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(403, 450);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.rbtnEnglish);
            this.MaximizeBox = false;
            this.Name = "AddBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add New Book";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddBook_FormClosing);
            this.rbtnEnglish.ResumeLayout(false);
            this.rbtnEnglish.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox rbtnEnglish;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtISBN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton rbtnEng;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbtnChinese;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}