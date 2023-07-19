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
        /// 
        private void InitializeComponent()
        {
            checkedListBox1 = new CheckedListBox();
            type1 = new Label();
            type2 = new Label();
            checkedListBox2 = new CheckedListBox();
            type3 = new Label();
            checkedListBox3 = new CheckedListBox();
            type4 = new Label();
            checkedListBox4 = new CheckedListBox();
            type5 = new Label();
            checkedListBox5 = new CheckedListBox();
            confirmwish = new Button();
            SuspendLayout();
            // 
            // checkedListBox1
            // 
            checkedListBox1.CheckOnClick = true;
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Items.AddRange(new object[] { "保险", "财政", "管理", "会计", "金融", "经济", "贸易", "信管", "营销" });
            checkedListBox1.Location = new Point(12, 45);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(87, 301);
            checkedListBox1.TabIndex = 0;
            checkedListBox1.ItemCheck += ItemCheck1;
            // 
            // type1
            // 
            type1.AutoSize = true;
            type1.BackColor = SystemColors.GradientInactiveCaption;
            type1.Location = new Point(12, 18);
            type1.Name = "type1";
            type1.Size = new Size(87, 24);
            type1.TabIndex = 1;
            type1.Text = "\u007f经管商科";
            // 
            // type2
            // 
            type2.AutoSize = true;
            type2.BackColor = SystemColors.GradientInactiveCaption;
            type2.Location = new Point(128, 18);
            type2.Name = "type2";
            type2.Size = new Size(82, 24);
            type2.TabIndex = 2;
            type2.Text = "理科农科";
            // 
            // checkedListBox2
            // 
            checkedListBox2.CheckOnClick = true;
            checkedListBox2.FormattingEnabled = true;
            checkedListBox2.Items.AddRange(new object[] { "大气", "地理", "地质", "化学", "力学", "农学", "生物", "食品", "数学", "统计", "物理" });
            checkedListBox2.Location = new Point(128, 45);
            checkedListBox2.Name = "checkedListBox2";
            checkedListBox2.Size = new Size(82, 301);
            checkedListBox2.TabIndex = 3;
            checkedListBox2.ItemCheck += ItemCheck2;
            // 
            // type3
            // 
            type3.BackColor = SystemColors.GradientInactiveCaption;
            type3.Location = new Point(249, 18);
            type3.Name = "type3";
            type3.Size = new Size(158, 24);
            type3.TabIndex = 4;
            type3.Text = "工科";
            type3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // checkedListBox3
            // 
            checkedListBox3.CheckOnClick = true;
            checkedListBox3.FormattingEnabled = true;
            checkedListBox3.Items.AddRange(new object[] { "材料", "城市规划", "电气自动化", "电子", "风光园林", "工业", "光学", "化工", "机械", "计算机", "建筑", "能源", "软件", "生物工程", "石油", "通信", "土木" });
            checkedListBox3.Location = new Point(249, 45);
            checkedListBox3.Name = "checkedListBox3";
            checkedListBox3.Size = new Size(158, 301);
            checkedListBox3.TabIndex = 5;
            checkedListBox3.ItemCheck += ItemCheck3;
            // 
            // type4
            // 
            type4.BackColor = SystemColors.GradientInactiveCaption;
            type4.Location = new Point(448, 18);
            type4.Name = "type4";
            type4.Size = new Size(120, 24);
            type4.TabIndex = 6;
            type4.Text = "人文";
            type4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // checkedListBox4
            // 
            checkedListBox4.CheckOnClick = true;
            checkedListBox4.FormattingEnabled = true;
            checkedListBox4.Items.AddRange(new object[] { "广告", "汉语", "教育", "历史", "社会", "心理", "新闻传媒", "英语", "哲学", "政治" });
            checkedListBox4.Location = new Point(448, 45);
            checkedListBox4.Name = "checkedListBox4";
            checkedListBox4.Size = new Size(120, 301);
            checkedListBox4.TabIndex = 7;
            checkedListBox4.ItemCheck += ItemCheck4;
            // 
            // type5
            // 
            type5.BackColor = SystemColors.GradientInactiveCaption;
            type5.Location = new Point(617, 18);
            type5.Name = "type5";
            type5.Size = new Size(114, 24);
            type5.TabIndex = 8;
            type5.Text = "理科农科";
            type5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // checkedListBox5
            // 
            checkedListBox5.CheckOnClick = true;
            checkedListBox5.FormattingEnabled = true;
            checkedListBox5.Items.AddRange(new object[] { "护理", "基础医学", "口腔", "临床", "药学", "预防公卫", "中医" });
            checkedListBox5.Location = new Point(617, 45);
            checkedListBox5.Name = "checkedListBox5";
            checkedListBox5.Size = new Size(114, 301);
            checkedListBox5.TabIndex = 9;
            checkedListBox5.ItemCheck += ItemCheck5;
            // 
            // confirmwish
            // 
            confirmwish.BackColor = SystemColors.GradientInactiveCaption;
            confirmwish.Location = new Point(306, 370);
            confirmwish.Name = "confirmwish";
            confirmwish.Size = new Size(154, 44);
            confirmwish.TabIndex = 10;
            confirmwish.Text = "确认";
            confirmwish.UseVisualStyleBackColor = false;
            confirmwish.Click += Confirm_Wish;
            // 
            // WishForm
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(744, 442);
            Controls.Add(confirmwish);
            Controls.Add(checkedListBox5);
            Controls.Add(type5);
            Controls.Add(checkedListBox4);
            Controls.Add(type4);
            Controls.Add(checkedListBox3);
            Controls.Add(type3);
            Controls.Add(checkedListBox2);
            Controls.Add(type2);
            Controls.Add(type1);
            Controls.Add(checkedListBox1);
            Name = "WishForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "专业意愿选择";
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
        private Label type4;
        private CheckedListBox checkedListBox4;
        private Label type5;
        private CheckedListBox checkedListBox5;
        private Button confirmwish;
    }
}