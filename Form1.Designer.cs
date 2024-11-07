namespace Calculator1
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            button11 = new Button();
            button12 = new Button();
            button13 = new Button();
            button14 = new Button();
            button15 = new Button();
            button16 = new Button();
            button17 = new Button();
            button18 = new Button();
            txtOutput = new TextBox();
            button20 = new Button();
            button4 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(89, 304);
            button1.Name = "button1";
            button1.Size = new Size(36, 52);
            button1.TabIndex = 0;
            button1.Text = "1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button_Click;
            // 
            // button2
            // 
            button2.Location = new Point(124, 304);
            button2.Name = "button2";
            button2.Size = new Size(36, 52);
            button2.TabIndex = 1;
            button2.Text = "2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button_Click;
            // 
            // button3
            // 
            button3.Location = new Point(159, 304);
            button3.Name = "button3";
            button3.Size = new Size(36, 52);
            button3.TabIndex = 2;
            button3.Text = "3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button_Click;
            // 
            // button5
            // 
            button5.Location = new Point(124, 257);
            button5.Name = "button5";
            button5.Size = new Size(36, 52);
            button5.TabIndex = 7;
            button5.Text = "5";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button_Click;
            // 
            // button6
            // 
            button6.Location = new Point(159, 257);
            button6.Name = "button6";
            button6.Size = new Size(36, 52);
            button6.TabIndex = 6;
            button6.Text = "6";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button_Click;
            // 
            // button7
            // 
            button7.Location = new Point(89, 208);
            button7.Name = "button7";
            button7.Size = new Size(36, 52);
            button7.TabIndex = 5;
            button7.Text = "7";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button_Click;
            // 
            // button8
            // 
            button8.Location = new Point(124, 208);
            button8.Name = "button8";
            button8.Size = new Size(36, 52);
            button8.TabIndex = 4;
            button8.Text = "8";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button_Click;
            // 
            // button9
            // 
            button9.Location = new Point(159, 208);
            button9.Name = "button9";
            button9.Size = new Size(36, 52);
            button9.TabIndex = 11;
            button9.Text = "9";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button_Click;
            // 
            // button10
            // 
            button10.Location = new Point(89, 354);
            button10.Name = "button10";
            button10.Size = new Size(71, 52);
            button10.TabIndex = 10;
            button10.Text = "0";
            button10.UseVisualStyleBackColor = true;
            button10.Click += button_Click;
            // 
            // button11
            // 
            button11.BackColor = Color.FromArgb(255, 128, 0);
            button11.Location = new Point(193, 158);
            button11.Name = "button11";
            button11.Size = new Size(36, 52);
            button11.TabIndex = 9;
            button11.Text = "/";
            button11.UseVisualStyleBackColor = false;
            button11.BackColorChanged += button13_BackColorChanged;
            button11.Click += button_Click;
            // 
            // button12
            // 
            button12.BackColor = Color.FromArgb(255, 128, 0);
            button12.Location = new Point(193, 208);
            button12.Name = "button12";
            button12.Size = new Size(36, 52);
            button12.TabIndex = 8;
            button12.Text = "*";
            button12.UseVisualStyleBackColor = false;
            button12.BackColorChanged += button13_BackColorChanged;
            button12.Click += button_Click;
            // 
            // button13
            // 
            button13.BackColor = Color.FromArgb(255, 128, 0);
            button13.Location = new Point(193, 257);
            button13.Name = "button13";
            button13.Size = new Size(36, 52);
            button13.TabIndex = 15;
            button13.Text = "-";
            button13.UseVisualStyleBackColor = false;
            button13.BackColorChanged += button13_BackColorChanged;
            button13.Click += button_Click;
            // 
            // button14
            // 
            button14.BackColor = Color.FromArgb(255, 128, 0);
            button14.Location = new Point(193, 304);
            button14.Name = "button14";
            button14.Size = new Size(36, 52);
            button14.TabIndex = 14;
            button14.Text = "+";
            button14.UseVisualStyleBackColor = false;
            button14.BackColorChanged += button13_BackColorChanged;
            button14.Click += button_Click;
            // 
            // button15
            // 
            button15.BackColor = Color.FromArgb(255, 128, 0);
            button15.Location = new Point(193, 354);
            button15.Name = "button15";
            button15.Size = new Size(36, 52);
            button15.TabIndex = 13;
            button15.Text = "=";
            button15.UseVisualStyleBackColor = false;
            button15.BackColorChanged += button13_BackColorChanged;
            button15.Click += button_Equals_Click;
            // 
            // button16
            // 
            button16.BackColor = SystemColors.ActiveBorder;
            button16.Location = new Point(159, 158);
            button16.Name = "button16";
            button16.Size = new Size(36, 52);
            button16.TabIndex = 12;
            button16.Text = "%";
            button16.UseVisualStyleBackColor = false;
            button16.Click += button_Click;
            // 
            // button17
            // 
            button17.BackColor = SystemColors.ActiveBorder;
            button17.Location = new Point(89, 158);
            button17.Name = "button17";
            button17.Size = new Size(36, 52);
            button17.TabIndex = 19;
            button17.Text = "AC";
            button17.UseVisualStyleBackColor = false;
            button17.Click += button_Clear_click;
            // 
            // button18
            // 
            button18.BackColor = SystemColors.ActiveBorder;
            button18.Location = new Point(124, 158);
            button18.Name = "button18";
            button18.Size = new Size(36, 52);
            button18.TabIndex = 18;
            button18.Text = "C";
            button18.UseVisualStyleBackColor = false;
            button18.Click += button_clearEntery_click;
            // 
            // txtOutput
            // 
            txtOutput.Location = new Point(89, 131);
            txtOutput.Name = "txtOutput";
            txtOutput.Size = new Size(140, 25);
            txtOutput.TabIndex = 20;
            // 
            // button20
            // 
            button20.Location = new Point(89, 257);
            button20.Name = "button20";
            button20.Size = new Size(36, 52);
            button20.TabIndex = 22;
            button20.Text = "4";
            button20.UseVisualStyleBackColor = true;
            button20.Click += button_Click;
            // 
            // button4
            // 
            button4.Location = new Point(159, 354);
            button4.Name = "button4";
            button4.Size = new Size(36, 52);
            button4.TabIndex = 23;
            button4.Text = ".";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            BackgroundImage = Properties.Resources.IPhone_7_Plus_Jet_Black_mobile_phone_Premium_vector_PNG;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(324, 511);
            Controls.Add(button4);
            Controls.Add(button20);
            Controls.Add(txtOutput);
            Controls.Add(button17);
            Controls.Add(button18);
            Controls.Add(button13);
            Controls.Add(button14);
            Controls.Add(button15);
            Controls.Add(button16);
            Controls.Add(button9);
            Controls.Add(button10);
            Controls.Add(button11);
            Controls.Add(button12);
            Controls.Add(button5);
            Controls.Add(button6);
            Controls.Add(button7);
            Controls.Add(button8);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Name = "Form1";
            Text = "IPhone Calculator ";
            Load += Form1_Load_1;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
        private Button button11;
        private Button button12;
        private Button button13;
        private Button button14;
        private Button button15;
        private Button button16;
        private Button button17;
        private Button button18;
        private TextBox txtOutput;
        private Button button20;
        private Button button4;
    }
}
