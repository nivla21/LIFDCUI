namespace LIFDCUI
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
            splitContainer1 = new SplitContainer();
            button1 = new Button();
            groupBox2 = new GroupBox();
            button2 = new Button();
            textBox6 = new TextBox();
            groupBox1 = new GroupBox();
            button3 = new Button();
            textBox7 = new TextBox();
            label8 = new Label();
            textBox5 = new TextBox();
            label7 = new Label();
            comboBox2 = new ComboBox();
            label6 = new Label();
            textBox4 = new TextBox();
            label5 = new Label();
            textBox3 = new TextBox();
            label4 = new Label();
            comboBox1 = new ComboBox();
            label3 = new Label();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(button1);
            splitContainer1.Panel1.Controls.Add(groupBox2);
            splitContainer1.Panel1.Controls.Add(groupBox1);
            splitContainer1.Size = new Size(1082, 953);
            splitContainer1.SplitterDistance = 616;
            splitContainer1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(225, 893);
            button1.Name = "button1";
            button1.Size = new Size(209, 33);
            button1.TabIndex = 2;
            button1.Text = "Generate DAT Config";
            button1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button2);
            groupBox2.Controls.Add(textBox6);
            groupBox2.Location = new Point(12, 273);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(586, 614);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Source File/s";
            // 
            // button2
            // 
            button2.BackColor = Color.Purple;
            button2.ForeColor = Color.White;
            button2.Location = new Point(14, 26);
            button2.Name = "button2";
            button2.Size = new Size(134, 29);
            button2.TabIndex = 16;
            button2.Text = "Source Filename";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // textBox6
            // 
            textBox6.CharacterCasing = CharacterCasing.Upper;
            textBox6.Location = new Point(171, 28);
            textBox6.Name = "textBox6";
            textBox6.ReadOnly = true;
            textBox6.Size = new Size(409, 27);
            textBox6.TabIndex = 15;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(textBox7);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(textBox5);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(comboBox2);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(textBox4);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 10);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(586, 257);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Default Configuration";
            // 
            // button3
            // 
            button3.BackColor = Color.Purple;
            button3.ForeColor = Color.White;
            button3.Location = new Point(14, 59);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 17;
            button3.Text = "Driving File";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(455, 21);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(125, 27);
            textBox7.TabIndex = 16;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Purple;
            label8.ForeColor = Color.White;
            label8.Location = new Point(286, 24);
            label8.Name = "label8";
            label8.Size = new Size(136, 20);
            label8.TabIndex = 15;
            label8.Text = "No. of  Source Files";
            // 
            // textBox5
            // 
            textBox5.CharacterCasing = CharacterCasing.Upper;
            textBox5.Location = new Point(132, 225);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(136, 27);
            textBox5.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Purple;
            label7.ForeColor = Color.White;
            label7.Location = new Point(14, 228);
            label7.Name = "label7";
            label7.Size = new Size(88, 20);
            label7.TabIndex = 13;
            label7.Text = "Key Column";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "YES", "NO" });
            comboBox2.Location = new Point(132, 190);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(136, 28);
            comboBox2.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Purple;
            label6.ForeColor = Color.White;
            label6.Location = new Point(14, 194);
            label6.Name = "label6";
            label6.Size = new Size(104, 20);
            label6.TabIndex = 11;
            label6.Text = "Retain Header";
            // 
            // textBox4
            // 
            textBox4.CharacterCasing = CharacterCasing.Upper;
            textBox4.Location = new Point(132, 157);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(136, 27);
            textBox4.TabIndex = 10;
            textBox4.Text = "DD/MM/YYYY";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Purple;
            label5.ForeColor = Color.White;
            label5.Location = new Point(14, 158);
            label5.Name = "label5";
            label5.Size = new Size(92, 20);
            label5.TabIndex = 9;
            label5.Text = "Date Format";
            // 
            // textBox3
            // 
            textBox3.CharacterCasing = CharacterCasing.Upper;
            textBox3.Location = new Point(132, 124);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(136, 27);
            textBox3.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Purple;
            label4.ForeColor = Color.White;
            label4.Location = new Point(14, 129);
            label4.Name = "label4";
            label4.Size = new Size(71, 20);
            label4.TabIndex = 7;
            label4.Text = "Delimiter";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "FUNDCHOICE", "INVEST", "CONTRATE" });
            comboBox1.Location = new Point(132, 90);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(136, 28);
            comboBox1.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Purple;
            label3.ForeColor = Color.White;
            label3.Location = new Point(14, 94);
            label3.Name = "label3";
            label3.Size = new Size(85, 20);
            label3.TabIndex = 4;
            label3.Text = "DC Scheme";
            // 
            // textBox2
            // 
            textBox2.CharacterCasing = CharacterCasing.Upper;
            textBox2.Location = new Point(132, 59);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(136, 27);
            textBox2.TabIndex = 3;
            // 
            // textBox1
            // 
            textBox1.CharacterCasing = CharacterCasing.Upper;
            textBox1.Location = new Point(132, 21);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(136, 27);
            textBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Purple;
            label1.ForeColor = Color.White;
            label1.Location = new Point(14, 24);
            label1.Name = "label1";
            label1.Size = new Size(99, 20);
            label1.TabIndex = 0;
            label1.Text = "Project Name";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(1082, 953);
            Controls.Add(splitContainer1);
            HelpButton = true;
            IsMdiContainer = true;
            Name = "Form1";
            Text = "Form1";
            splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private GroupBox groupBox2;
        private GroupBox groupBox1;
        private Label label1;
        private TextBox textBox1;
        private Label label3;
        private TextBox textBox2;
        private ComboBox comboBox1;
        private Label label4;
        private Label label5;
        private TextBox textBox3;
        private Label label6;
        private TextBox textBox4;
        private ComboBox comboBox2;
        private TextBox textBox5;
        private Label label7;
        private Button button1;
        private TextBox textBox6;
        private Button button2;
        private TextBox textBox7;
        private Label label8;
        private Button button3;
    }
}
