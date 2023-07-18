namespace Gaokao
{
    partial class SubjectForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox3 = new CheckBox();
            checkBox4 = new CheckBox();
            checkBox5 = new CheckBox();
            checkBox6 = new CheckBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(102, 28);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(72, 28);
            checkBox1.TabIndex = 0;
            checkBox1.Text = "物理";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(102, 62);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(72, 28);
            checkBox2.TabIndex = 1;
            checkBox2.Text = "生物";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(102, 96);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(72, 28);
            checkBox3.TabIndex = 2;
            checkBox3.Text = "历史";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Location = new Point(247, 28);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(72, 28);
            checkBox4.TabIndex = 3;
            checkBox4.Text = "化学";
            checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            checkBox5.AutoSize = true;
            checkBox5.Location = new Point(247, 62);
            checkBox5.Name = "checkBox5";
            checkBox5.Size = new Size(72, 28);
            checkBox5.TabIndex = 4;
            checkBox5.Text = "政治";
            checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox6
            // 
            checkBox6.AutoSize = true;
            checkBox6.Location = new Point(247, 96);
            checkBox6.Name = "checkBox6";
            checkBox6.Size = new Size(72, 28);
            checkBox6.TabIndex = 5;
            checkBox6.Text = "地理";
            checkBox6.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(150, 148);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 6;
            button1.Text = "确认";
            button1.UseVisualStyleBackColor = true;
            // 
            // SubjectForm
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(422, 220);
            Controls.Add(button1);
            Controls.Add(checkBox6);
            Controls.Add(checkBox5);
            Controls.Add(checkBox4);
            Controls.Add(checkBox3);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Name = "SubjectForm";
            Text = "科目选择";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private CheckBox checkBox3;
        private CheckBox checkBox4;
        private CheckBox checkBox5;
        private CheckBox checkBox6;
        private Button button1;
    }
}