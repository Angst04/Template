namespace Template
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            anwerLabel = new Label();
            label8 = new Label();
            groupBox1 = new GroupBox();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            button1 = new Button();
            listBox1 = new ListBox();
            removeButton = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(103, 136);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 0;
            textBox1.Text = "0";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(230, 136);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 1;
            textBox2.Text = "0";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(357, 136);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 2;
            textBox3.Text = "0";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(103, 118);
            label1.Name = "label1";
            label1.Size = new Size(96, 15);
            label1.TabIndex = 3;
            label1.Text = "Введите 1 число";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(230, 118);
            label2.Name = "label2";
            label2.Size = new Size(96, 15);
            label2.TabIndex = 4;
            label2.Text = "Введите 2 число";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(357, 118);
            label3.Name = "label3";
            label3.Size = new Size(96, 15);
            label3.TabIndex = 5;
            label3.Text = "Введите 3 число";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(209, 139);
            label4.Name = "label4";
            label4.Size = new Size(15, 15);
            label4.TabIndex = 6;
            label4.Text = "+";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(336, 139);
            label5.Name = "label5";
            label5.Size = new Size(15, 15);
            label5.TabIndex = 7;
            label5.Text = "+";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(463, 139);
            label6.Name = "label6";
            label6.Size = new Size(15, 15);
            label6.TabIndex = 8;
            label6.Text = "=";
            // 
            // anwerLabel
            // 
            anwerLabel.AutoSize = true;
            anwerLabel.Location = new Point(484, 139);
            anwerLabel.Name = "anwerLabel";
            anwerLabel.Size = new Size(13, 15);
            anwerLabel.TabIndex = 9;
            anwerLabel.Text = "0";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(484, 118);
            label8.Name = "label8";
            label8.Size = new Size(60, 15);
            label8.TabIndex = 10;
            label8.Text = "Результат";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Location = new Point(103, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 100);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            groupBox1.Text = "Количество слагаемых";
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Checked = true;
            radioButton2.Location = new Point(14, 59);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(67, 19);
            radioButton2.TabIndex = 1;
            radioButton2.TabStop = true;
            radioButton2.Text = "3 числа";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(14, 22);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(67, 19);
            radioButton1.TabIndex = 0;
            radioButton1.Text = "2 числа";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // button1
            // 
            button1.Location = new Point(103, 182);
            button1.Name = "button1";
            button1.Size = new Size(441, 48);
            button1.TabIndex = 12;
            button1.Text = "Посчитать";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(629, 103);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(120, 94);
            listBox1.TabIndex = 13;
            // 
            // removeButton
            // 
            removeButton.Location = new Point(629, 207);
            removeButton.Name = "removeButton";
            removeButton.Size = new Size(75, 23);
            removeButton.TabIndex = 14;
            removeButton.Text = "Убрать";
            removeButton.UseVisualStyleBackColor = true;
            removeButton.Click += removeButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(removeButton);
            Controls.Add(listBox1);
            Controls.Add(button1);
            Controls.Add(groupBox1);
            Controls.Add(label8);
            Controls.Add(anwerLabel);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label anwerLabel;
        private Label label8;
        private GroupBox groupBox1;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private Button button1;
        private ListBox listBox1;
        private Button removeButton;
    }
}
