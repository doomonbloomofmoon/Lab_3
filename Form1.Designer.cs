namespace IndividualPart
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BExit = new System.Windows.Forms.Button();
            this.BAdd = new System.Windows.Forms.Button();
            this.txt6 = new System.Windows.Forms.TextBox();
            this.txt5 = new System.Windows.Forms.TextBox();
            this.txt4 = new System.Windows.Forms.TextBox();
            this.txt3 = new System.Windows.Forms.TextBox();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // BExit
            // 
            this.BExit.Location = new System.Drawing.Point(255, 240);
            this.BExit.Name = "BExit";
            this.BExit.Size = new System.Drawing.Size(94, 29);
            this.BExit.TabIndex = 19;
            this.BExit.Text = "Exit";
            this.BExit.UseVisualStyleBackColor = true;
            this.BExit.Click += new System.EventHandler(this.BExit_Click);
            // 
            // BAdd
            // 
            this.BAdd.Location = new System.Drawing.Point(12, 240);
            this.BAdd.Name = "BAdd";
            this.BAdd.Size = new System.Drawing.Size(94, 29);
            this.BAdd.TabIndex = 18;
            this.BAdd.Text = "Add";
            this.BAdd.UseVisualStyleBackColor = true;
            this.BAdd.Click += new System.EventHandler(this.BAdd_Click);
            // 
            // txt6
            // 
            this.txt6.Location = new System.Drawing.Point(12, 192);
            this.txt6.Name = "txt6";
            this.txt6.PlaceholderText = "Должность";
            this.txt6.ReadOnly = true;
            this.txt6.Size = new System.Drawing.Size(337, 30);
            this.txt6.TabIndex = 17;
            // 
            // txt5
            // 
            this.txt5.Location = new System.Drawing.Point(12, 156);
            this.txt5.Name = "txt5";
            this.txt5.PlaceholderText = "Стаж";
            this.txt5.ReadOnly = true;
            this.txt5.Size = new System.Drawing.Size(337, 30);
            this.txt5.TabIndex = 16;
            // 
            // txt4
            // 
            this.txt4.Location = new System.Drawing.Point(12, 120);
            this.txt4.Name = "txt4";
            this.txt4.PlaceholderText = "Возраст";
            this.txt4.ReadOnly = true;
            this.txt4.Size = new System.Drawing.Size(337, 30);
            this.txt4.TabIndex = 15;
            // 
            // txt3
            // 
            this.txt3.Location = new System.Drawing.Point(12, 84);
            this.txt3.Name = "txt3";
            this.txt3.PlaceholderText = "Отчество";
            this.txt3.ReadOnly = true;
            this.txt3.Size = new System.Drawing.Size(337, 30);
            this.txt3.TabIndex = 14;
            // 
            // txt2
            // 
            this.txt2.Location = new System.Drawing.Point(12, 48);
            this.txt2.Name = "txt2";
            this.txt2.PlaceholderText = "Имя";
            this.txt2.ReadOnly = true;
            this.txt2.Size = new System.Drawing.Size(337, 30);
            this.txt2.TabIndex = 13;
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(12, 12);
            this.txt1.Name = "txt1";
            this.txt1.PlaceholderText = "Фамилия";
            this.txt1.ReadOnly = true;
            this.txt1.Size = new System.Drawing.Size(337, 30);
            this.txt1.TabIndex = 12;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 23;
            this.listBox1.Location = new System.Drawing.Point(355, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(337, 257);
            this.listBox1.TabIndex = 20;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 282);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.BExit);
            this.Controls.Add(this.BAdd);
            this.Controls.Add(this.txt6);
            this.Controls.Add(this.txt5);
            this.Controls.Add(this.txt4);
            this.Controls.Add(this.txt3);
            this.Controls.Add(this.txt2);
            this.Controls.Add(this.txt1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button BExit;
        private Button BAdd;
        private TextBox txt6;
        private TextBox txt5;
        private TextBox txt4;
        private TextBox txt3;
        private TextBox txt2;
        private TextBox txt1;
        private ListBox listBox1;
    }
}