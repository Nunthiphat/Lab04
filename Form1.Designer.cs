namespace Lab04
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
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbBirthYear = new System.Windows.Forms.TextBox();
            this.tbGPA = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btAdd = new System.Windows.Forms.Button();
            this.tbListofPerson = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbTotal = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbGpaAvg = new System.Windows.Forms.TextBox();
            this.tbGpaMin = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbGpaMax = new System.Windows.Forms.TextBox();
            this.tbMinName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tbNameMax = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(101, 26);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(125, 27);
            this.tbName.TabIndex = 0;
            // 
            // tbBirthYear
            // 
            this.tbBirthYear.Location = new System.Drawing.Point(101, 59);
            this.tbBirthYear.Name = "tbBirthYear";
            this.tbBirthYear.Size = new System.Drawing.Size(125, 27);
            this.tbBirthYear.TabIndex = 1;
            // 
            // tbGPA
            // 
            this.tbGPA.Location = new System.Drawing.Point(101, 92);
            this.tbGPA.Name = "tbGPA";
            this.tbGPA.Size = new System.Drawing.Size(125, 27);
            this.tbGPA.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "ชื่ีอ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "ปีเกิด";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "GPA";
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(101, 144);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(125, 67);
            this.btAdd.TabIndex = 6;
            this.btAdd.Text = "ADD";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // tbListofPerson
            // 
            this.tbListofPerson.Location = new System.Drawing.Point(355, 188);
            this.tbListofPerson.Multiline = true;
            this.tbListofPerson.Name = "tbListofPerson";
            this.tbListofPerson.Size = new System.Drawing.Size(361, 223);
            this.tbListofPerson.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(276, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "รายชื่อ";
            // 
            // tbTotal
            // 
            this.tbTotal.Location = new System.Drawing.Point(355, 144);
            this.tbTotal.Name = "tbTotal";
            this.tbTotal.Size = new System.Drawing.Size(125, 27);
            this.tbTotal.TabIndex = 9;
            this.tbTotal.TextChanged += new System.EventHandler(this.tbTotal_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(276, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "อายุรวม";
            // 
            // tbGpaAvg
            // 
            this.tbGpaAvg.Location = new System.Drawing.Point(355, 92);
            this.tbGpaAvg.Name = "tbGpaAvg";
            this.tbGpaAvg.Size = new System.Drawing.Size(125, 27);
            this.tbGpaAvg.TabIndex = 11;
            this.tbGpaAvg.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tbGpaMin
            // 
            this.tbGpaMin.Location = new System.Drawing.Point(355, 59);
            this.tbGpaMin.Name = "tbGpaMin";
            this.tbGpaMin.Size = new System.Drawing.Size(125, 27);
            this.tbGpaMin.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(263, 95);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "GPA Avg";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(264, 62);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "GPA Min";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(261, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 20);
            this.label8.TabIndex = 15;
            this.label8.Text = "GPA Max";
            // 
            // tbGpaMax
            // 
            this.tbGpaMax.Location = new System.Drawing.Point(355, 26);
            this.tbGpaMax.Name = "tbGpaMax";
            this.tbGpaMax.Size = new System.Drawing.Size(125, 27);
            this.tbGpaMax.TabIndex = 16;
            // 
            // tbMinName
            // 
            this.tbMinName.Location = new System.Drawing.Point(591, 62);
            this.tbMinName.Name = "tbMinName";
            this.tbMinName.Size = new System.Drawing.Size(125, 27);
            this.tbMinName.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(514, 62);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(26, 20);
            this.label9.TabIndex = 18;
            this.label9.Text = "ชื่อ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(514, 29);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(26, 20);
            this.label10.TabIndex = 19;
            this.label10.Text = "ชื่อ";
            // 
            // tbNameMax
            // 
            this.tbNameMax.Location = new System.Drawing.Point(591, 26);
            this.tbNameMax.Name = "tbNameMax";
            this.tbNameMax.Size = new System.Drawing.Size(125, 27);
            this.tbNameMax.TabIndex = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbNameMax);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tbMinName);
            this.Controls.Add(this.tbGpaMax);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbGpaMin);
            this.Controls.Add(this.tbGpaAvg);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbTotal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbListofPerson);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbGPA);
            this.Controls.Add(this.tbBirthYear);
            this.Controls.Add(this.tbName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox tbName;
        private TextBox tbBirthYear;
        private TextBox tbGPA;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btAdd;
        private TextBox tbListofPerson;
        private Label label4;
        private TextBox tbTotal;
        private Label label5;
        private TextBox tbGpaAvg;
        private TextBox tbGpaMin;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox tbGpaMax;
        private TextBox tbMinName;
        private Label label9;
        private Label label10;
        private TextBox tbNameMax;
    }
}