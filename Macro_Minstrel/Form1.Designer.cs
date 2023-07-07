namespace Macro_Minstrel
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
            number1 = new Label();
            number2 = new Label();
            number3 = new Label();
            number4 = new Label();
            NAME = new Label();
            macro1 = new TextBox();
            macro2 = new TextBox();
            macro3 = new TextBox();
            macro4 = new TextBox();
            timer1 = new System.Windows.Forms.Timer(components);
            StartButton = new Button();
            StopButton = new Button();
            SuspendLayout();
            // 
            // number1
            // 
            number1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            number1.Location = new Point(12, 74);
            number1.Name = "number1";
            number1.Size = new Size(335, 41);
            number1.TabIndex = 0;
            number1.Text = "[1]";
            number1.Click += label1_Click;
            // 
            // number2
            // 
            number2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            number2.Location = new Point(12, 136);
            number2.Name = "number2";
            number2.Size = new Size(335, 40);
            number2.TabIndex = 1;
            number2.Text = "[2]";
            number2.Click += label2_Click;
            // 
            // number3
            // 
            number3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            number3.Location = new Point(12, 199);
            number3.Name = "number3";
            number3.Size = new Size(335, 55);
            number3.TabIndex = 2;
            number3.Text = "[3]";
            number3.Click += label3_Click;
            // 
            // number4
            // 
            number4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            number4.Location = new Point(12, 268);
            number4.Name = "number4";
            number4.Size = new Size(335, 56);
            number4.TabIndex = 3;
            number4.Text = "[4]";
            number4.Click += label4_Click;
            // 
            // NAME
            // 
            NAME.AutoSize = true;
            NAME.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            NAME.Location = new Point(269, 9);
            NAME.Name = "NAME";
            NAME.Size = new Size(241, 35);
            NAME.TabIndex = 4;
            NAME.Text = "MACRO-MINSTREL";
            // 
            // macro1
            // 
            macro1.Location = new Point(98, 78);
            macro1.Multiline = true;
            macro1.Name = "macro1";
            macro1.Size = new Size(249, 34);
            macro1.TabIndex = 5;
            macro1.TextChanged += textBox1_TextChanged;
            // 
            // macro2
            // 
            macro2.Location = new Point(98, 140);
            macro2.Multiline = true;
            macro2.Name = "macro2";
            macro2.Size = new Size(249, 34);
            macro2.TabIndex = 6;
            macro2.TextChanged += textBox2_TextChanged;
            // 
            // macro3
            // 
            macro3.Location = new Point(98, 203);
            macro3.Multiline = true;
            macro3.Name = "macro3";
            macro3.Size = new Size(249, 34);
            macro3.TabIndex = 7;
            macro3.TextChanged += textBox3_TextChanged;
            // 
            // macro4
            // 
            macro4.Location = new Point(98, 272);
            macro4.Multiline = true;
            macro4.Name = "macro4";
            macro4.Size = new Size(249, 34);
            macro4.TabIndex = 8;
            macro4.TextChanged += textBox4_TextChanged;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // StartButton
            // 
            StartButton.BackColor = Color.Chartreuse;
            StartButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            StartButton.Location = new Point(534, 74);
            StartButton.Name = "StartButton";
            StartButton.Size = new Size(183, 67);
            StartButton.TabIndex = 9;
            StartButton.Text = "START";
            StartButton.UseVisualStyleBackColor = false;
            StartButton.Click += StartButton_Click;
            // 
            // StopButton
            // 
            StopButton.BackColor = Color.Red;
            StopButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            StopButton.Location = new Point(534, 226);
            StopButton.Name = "StopButton";
            StopButton.Size = new Size(183, 67);
            StopButton.TabIndex = 10;
            StopButton.Text = "STOP";
            StopButton.UseVisualStyleBackColor = false;
            StopButton.Click += StopButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(StopButton);
            Controls.Add(StartButton);
            Controls.Add(macro4);
            Controls.Add(macro3);
            Controls.Add(macro2);
            Controls.Add(macro1);
            Controls.Add(NAME);
            Controls.Add(number4);
            Controls.Add(number3);
            Controls.Add(number2);
            Controls.Add(number1);
            KeyPreview = true;
            Name = "Form1";
            Text = "Macro-Minstrel";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label number1;
        private Label number2;
        private Label number3;
        private Label number4;
        private Label NAME;
        private TextBox macro1;
        private TextBox macro2;
        private TextBox macro3;
        private TextBox macro4;
        private System.Windows.Forms.Timer timer1;
        private Button StartButton;
        private Button StopButton;
    }
}