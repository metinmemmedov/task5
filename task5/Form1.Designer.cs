namespace task5
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
            components = new System.ComponentModel.Container();
            textBox1 = new TextBox();
            label11 = new Label();
            label12 = new Label();
            maskedTextBox1 = new MaskedTextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            listBox1 = new ListBox();
            timer1 = new System.Windows.Forms.Timer(components);
            timer2 = new System.Windows.Forms.Timer(components);
            timer3 = new System.Windows.Forms.Timer(components);
            timer4 = new System.Windows.Forms.Timer(components);
            timer5 = new System.Windows.Forms.Timer(components);
            timer6 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Location = new Point(139, 62);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(112, 23);
            textBox1.TabIndex = 0;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(139, 44);
            label11.Name = "label11";
            label11.Size = new Size(112, 15);
            label11.TabIndex = 1;
            label11.Text = "Name and Surname";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(297, 44);
            label12.Name = "label12";
            label12.Size = new Size(53, 15);
            label12.TabIndex = 2;
            label12.Text = "Duration";
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.BorderStyle = BorderStyle.FixedSingle;
            maskedTextBox1.Location = new Point(297, 62);
            maskedTextBox1.Mask = "00000";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(100, 23);
            maskedTextBox1.TabIndex = 3;
            maskedTextBox1.ValidatingType = typeof(int);
            // 
            // button1
            // 
            button1.Location = new Point(139, 130);
            button1.Name = "button1";
            button1.Size = new Size(87, 71);
            button1.TabIndex = 4;
            button1.Text = "ROOM 1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(232, 130);
            button2.Name = "button2";
            button2.Size = new Size(87, 71);
            button2.TabIndex = 5;
            button2.Text = "ROOM 2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(325, 130);
            button3.Name = "button3";
            button3.Size = new Size(87, 71);
            button3.TabIndex = 6;
            button3.Text = "ROOM 3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(139, 222);
            button4.Name = "button4";
            button4.Size = new Size(87, 71);
            button4.TabIndex = 7;
            button4.Text = "ROOM 4";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(232, 222);
            button5.Name = "button5";
            button5.Size = new Size(87, 71);
            button5.TabIndex = 8;
            button5.Text = "ROOM 5";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(325, 222);
            button6.Name = "button6";
            button6.Size = new Size(87, 71);
            button6.TabIndex = 9;
            button6.Text = "ROOM 6";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(139, 112);
            label1.Name = "label1";
            label1.Size = new Size(55, 15);
            label1.TabIndex = 10;
            label1.Text = "Available";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(232, 112);
            label2.Name = "label2";
            label2.Size = new Size(55, 15);
            label2.TabIndex = 11;
            label2.Text = "Available";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(325, 112);
            label3.Name = "label3";
            label3.Size = new Size(55, 15);
            label3.TabIndex = 12;
            label3.Text = "Available";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(139, 204);
            label4.Name = "label4";
            label4.Size = new Size(55, 15);
            label4.TabIndex = 13;
            label4.Text = "Available";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(232, 204);
            label5.Name = "label5";
            label5.Size = new Size(55, 15);
            label5.TabIndex = 14;
            label5.Text = "Available";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(325, 204);
            label6.Name = "label6";
            label6.Size = new Size(55, 15);
            label6.TabIndex = 15;
            label6.Text = "Available";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(139, 299);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(273, 124);
            listBox1.TabIndex = 16;
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // timer2
            // 
            timer2.Interval = 1000;
            timer2.Tick += timer2_Tick;
            // 
            // timer3
            // 
            timer3.Interval = 1000;
            timer3.Tick += timer3_Tick;
            // 
            // timer4
            // 
            timer4.Interval = 1000;
            timer4.Tick += timer4_Tick;
            // 
            // timer5
            // 
            timer5.Interval = 1000;
            timer5.Tick += timer5_Tick;
            // 
            // timer6
            // 
            timer6.Interval = 1000;
            timer6.Tick += timer6_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(606, 450);
            Controls.Add(listBox1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(maskedTextBox1);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(textBox1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label label11;
        private Label label12;
        private MaskedTextBox maskedTextBox1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private ListBox listBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Timer timer4;
        private System.Windows.Forms.Timer timer5;
        private System.Windows.Forms.Timer timer6;
    }
}
