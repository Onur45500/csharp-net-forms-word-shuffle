namespace csharp_net_forms_word_shuffle
{
    partial class GuessTheWord
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
            label1 = new Label();
            label2 = new Label();
            lblWord = new Label();
            textBox1 = new TextBox();
            lblInfo = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F);
            label1.ForeColor = Color.FromArgb(0, 192, 0);
            label1.Location = new Point(285, 26);
            label1.Name = "label1";
            label1.Size = new Size(200, 37);
            label1.TabIndex = 0;
            label1.Text = "Guess the word";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(346, 331);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 1;
            label2.Text = "label2";
            // 
            // lblWord
            // 
            lblWord.ForeColor = Color.White;
            lblWord.Location = new Point(306, 112);
            lblWord.Name = "lblWord";
            lblWord.Size = new Size(147, 20);
            lblWord.TabIndex = 2;
            lblWord.Text = "label3";
            lblWord.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(268, 176);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(217, 27);
            textBox1.TabIndex = 3;
            // 
            // lblInfo
            // 
            lblInfo.AutoSize = true;
            lblInfo.Location = new Point(523, 179);
            lblInfo.Name = "lblInfo";
            lblInfo.Size = new Size(50, 20);
            lblInfo.TabIndex = 4;
            lblInfo.Text = "label3";
            // 
            // GuessTheWord
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DimGray;
            ClientSize = new Size(800, 450);
            Controls.Add(lblInfo);
            Controls.Add(textBox1);
            Controls.Add(lblWord);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "GuessTheWord";
            Text = "Guess the word";
            KeyPress += KeyIsPressed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label lblWord;
        private TextBox textBox1;
        private Label lblInfo;
    }
}
