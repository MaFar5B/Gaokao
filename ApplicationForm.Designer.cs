namespace Gaokao
{
    partial class ApplicationForm
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
            label4 = new Label();
            textBox5 = new TextBox();
            button2 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(344, 348);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 0;
            button1.Text = "生成";
            button1.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(359, 202);
            label4.Name = "label4";
            label4.Size = new Size(82, 24);
            label4.TabIndex = 10;
            label4.Text = "高考总分";
            // 
            // textBox5
            // 
            textBox5.BackColor = SystemColors.Window;
            textBox5.Location = new Point(344, 247);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(112, 30);
            textBox5.TabIndex = 11;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(325, 37);
            button2.Name = "button2";
            button2.Size = new Size(150, 34);
            button2.TabIndex = 12;
            button2.Text = "选择高考科目";
            button2.UseVisualStyleBackColor = false;
            button2.Click += SelectSubject;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(185, 114);
            label1.Name = "label1";
            label1.Size = new Size(63, 24);
            label1.TabIndex = 13;
            label1.Text = "label1";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(377, 114);
            label2.Name = "label2";
            label2.Size = new Size(46, 24);
            label2.TabIndex = 14;
            label2.Text = "物理";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(538, 114);
            label3.Name = "label3";
            label3.Size = new Size(63, 24);
            label3.TabIndex = 15;
            label3.Text = "label3";
            // 
            // ApplicationForm
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(textBox5);
            Controls.Add(label4);
            Controls.Add(button1);
            Name = "ApplicationForm";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label4;
        private TextBox textBox5;
        private Button button2;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}