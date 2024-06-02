namespace WinFormsApp3
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
            lblQuestion = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            SuspendLayout();
            // 
            // lblQuestion
            // 
            lblQuestion.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblQuestion.Location = new Point(0, 115);
            lblQuestion.Name = "lblQuestion";
            lblQuestion.Size = new Size(494, 23);
            lblQuestion.TabIndex = 1;
            lblQuestion.Text = "Questionaire";
            lblQuestion.TextAlign = ContentAlignment.TopCenter;
            // 
            // button1
            // 
            button1.Location = new Point(61, 330);
            button1.Name = "button1";
            button1.Size = new Size(150, 42);
            button1.TabIndex = 2;
            button1.Tag = "1";
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += checkAnswerEvent;
            // 
            // button2
            // 
            button2.Location = new Point(289, 330);
            button2.Name = "button2";
            button2.Size = new Size(150, 42);
            button2.TabIndex = 3;
            button2.Tag = "2";
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += checkAnswerEvent;
            // 
            // button3
            // 
            button3.Location = new Point(61, 438);
            button3.Name = "button3";
            button3.Size = new Size(150, 42);
            button3.TabIndex = 4;
            button3.Tag = "3";
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += checkAnswerEvent;
            // 
            // button4
            // 
            button4.Location = new Point(289, 438);
            button4.Name = "button4";
            button4.Size = new Size(150, 42);
            button4.TabIndex = 5;
            button4.Tag = "4";
            button4.Text = "button4";
            button4.UseVisualStyleBackColor = true;
            button4.Click += checkAnswerEvent;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(493, 626);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(lblQuestion);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion
        private Label lblQuestion;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}
