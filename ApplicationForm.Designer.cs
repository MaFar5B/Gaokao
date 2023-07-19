﻿namespace Gaokao
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
            button3 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ButtonHighlight;
            button1.Cursor = Cursors.Hand;
            button1.Location = new Point(310, 361);
            button1.Name = "button1";
            button1.Size = new Size(180, 62);
            button1.TabIndex = 0;
            button1.Text = "生成";
            button1.UseVisualStyleBackColor = false;
            button1.Click += Botton1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(359, 184);
            label4.Name = "label4";
            label4.Size = new Size(82, 24);
            label4.TabIndex = 10;
            label4.Text = "高考总分";
            // 
            // textBox5
            // 
            textBox5.BackColor = SystemColors.Window;
            textBox5.Location = new Point(344, 221);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(112, 30);
            textBox5.TabIndex = 11;
            textBox5.KeyPress += textBox5_KeyPress;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ButtonHighlight;
            button2.Cursor = Cursors.Hand;
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
            label1.BackColor = SystemColors.InactiveBorder;
            label1.Location = new Point(227, 112);
            label1.Name = "label1";
            label1.Size = new Size(46, 24);
            label1.TabIndex = 13;
            label1.Text = "物理";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.InactiveBorder;
            label2.Location = new Point(377, 112);
            label2.Name = "label2";
            label2.Size = new Size(46, 24);
            label2.TabIndex = 14;
            label2.Text = "化学";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.InactiveBorder;
            label3.Location = new Point(524, 112);
            label3.Name = "label3";
            label3.Size = new Size(46, 24);
            label3.TabIndex = 15;
            label3.Text = "生物";
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ButtonHighlight;
            button3.Cursor = Cursors.Hand;
            button3.Location = new Point(325, 286);
            button3.Name = "button3";
            button3.Size = new Size(150, 34);
            button3.TabIndex = 16;
            button3.Text = "选择专业意愿";
            button3.UseVisualStyleBackColor = false;
            button3.Click += Botton3_Click;
            // 
            // ApplicationForm
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox5);
            Controls.Add(button2);
            Controls.Add(label4);
            Controls.Add(button1);
            Name = "ApplicationForm";
            StartPosition = FormStartPosition.CenterScreen;
            ResumeLayout(false);
            PerformLayout();
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        public void setLable(String text1, String text2, String text3)
        {
            this.label1.Text = text1;
            this.label1.Update();
            this.label2.Text = text2;
            this.label2.Update();
            this.label3.Text = text3;
            this.label3.Update();
        }

        #endregion

        private Button button1;
        private TextBox textBox5;
        private Button button2;
        private Label label4;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button3;
    }
}