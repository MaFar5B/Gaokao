namespace Gaokao
{
    partial class WishForm
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
            checkedListBox1 = new CheckedListBox();
            type1 = new Label();
            type2 = new Label();
            checkedListBox2 = new CheckedListBox();
            type3 = new Label();
            checkedListBox3 = new CheckedListBox();
            SuspendLayout();
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Items.AddRange(new object[] { "保险", "财政", "管理", "会计", "金融", "经济", "贸易", "信管", "营销" });
            checkedListBox1.Location = new Point(12, 36);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(87, 301);
            checkedListBox1.TabIndex = 0;
            // 
            // type1
            // 
            type1.AutoSize = true;
            type1.BackColor = SystemColors.GradientInactiveCaption;
            type1.Location = new Point(12, 9);
            type1.Name = "type1";
            type1.Size = new Size(87, 24);
            type1.TabIndex = 1;
            type1.Text = "\u007f经管商科";
            // 
            // type2
            // 
            type2.AutoSize = true;
            type2.BackColor = SystemColors.GradientInactiveCaption;
            type2.Location = new Point(114, 9);
            type2.Name = "type2";
            type2.Size = new Size(82, 24);
            type2.TabIndex = 2;
            type2.Text = "理科农科";
            // 
            // checkedListBox2
            // 
            checkedListBox2.FormattingEnabled = true;
            checkedListBox2.Items.AddRange(new object[] { "大气", "地理", "地质", "化学", "力学", "农学", "生物", "食品", "数学", "统计", "物理" });
            checkedListBox2.Location = new Point(114, 36);
            checkedListBox2.Name = "checkedListBox2";
            checkedListBox2.Size = new Size(82, 301);
            checkedListBox2.TabIndex = 3;
            // 
            // type3
            // 
            type3.BackColor = SystemColors.GradientInactiveCaption;
            type3.Location = new Point(217, 9);
            type3.Name = "type3";
            type3.Size = new Size(82, 24);
            type3.TabIndex = 4;
            type3.Text = "工科";
            type3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // checkedListBox3
            // 
            checkedListBox3.FormattingEnabled = true;
            checkedListBox3.Location = new Point(217, 36);
            checkedListBox3.Name = "checkedListBox3";
            checkedListBox3.Size = new Size(82, 301);
            checkedListBox3.TabIndex = 5;
            // 
            // WishForm
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(653, 420);
            Controls.Add(checkedListBox3);
            Controls.Add(type3);
            Controls.Add(checkedListBox2);
            Controls.Add(type2);
            Controls.Add(type1);
            Controls.Add(checkedListBox1);
            Name = "WishForm";
            Text = "WishForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckedListBox checkedListBox1;
        private Label type1;
        private Label type2;
        private CheckedListBox checkedListBox2;
        private Label type3;
        private CheckedListBox checkedListBox3;
    }
}