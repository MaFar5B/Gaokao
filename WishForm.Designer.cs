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
            All1 = new CheckBox();
            All2 = new CheckBox();
            All3 = new CheckBox();
            All4 = new CheckBox();
            All5 = new CheckBox();
            SuspendLayout();
            // 
            // checkedListBox1
            // 
            checkedListBox1.CheckOnClick = true;
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Items.AddRange(new object[] { "保险", "财政", "管理", "会计", "金融", "经济", "贸易", "信管", "营销" });
            checkedListBox1.Location = new Point(12, 79);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(87, 301);
            checkedListBox1.TabIndex = 0;
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
            checkedListBox2.Location = new Point(128, 79);
            checkedListBox2.Name = "checkedListBox2";
            checkedListBox2.Size = new Size(82, 301);
            checkedListBox2.TabIndex = 3;
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
            checkedListBox3.Location = new Point(249, 79);
            checkedListBox3.Name = "checkedListBox3";
            checkedListBox3.Size = new Size(158, 301);
            checkedListBox3.TabIndex = 5;
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
            checkedListBox4.Location = new Point(448, 79);
            checkedListBox4.Name = "checkedListBox4";
            checkedListBox4.Size = new Size(120, 301);
            checkedListBox4.TabIndex = 7;
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
            checkedListBox5.Location = new Point(617, 79);
            checkedListBox5.Name = "checkedListBox5";
            checkedListBox5.Size = new Size(114, 301);
            checkedListBox5.TabIndex = 9;
            // 
            // confirmwish
            // 
            confirmwish.BackColor = SystemColors.GradientInactiveCaption;
            confirmwish.Location = new Point(301, 411);
            confirmwish.Name = "confirmwish";
            confirmwish.Size = new Size(154, 44);
            confirmwish.TabIndex = 10;
            confirmwish.Text = "确认";
            confirmwish.UseVisualStyleBackColor = false;
            confirmwish.Click += Confirm_Wish;
            // 
            // All1
            // 
            All1.AutoSize = true;
            All1.Location = new Point(12, 45);
            All1.Name = "All1";
            All1.Size = new Size(72, 28);
            All1.TabIndex = 11;
            All1.Text = "全选";
            All1.UseVisualStyleBackColor = true;
            All1.CheckStateChanged += Changed1;
            // 
            // All2
            // 
            All2.AutoSize = true;
            All2.Location = new Point(128, 45);
            All2.Name = "All2";
            All2.Size = new Size(72, 28);
            All2.TabIndex = 12;
            All2.Text = "全选";
            All2.UseVisualStyleBackColor = true;
            All2.CheckStateChanged += Changed2;
            // 
            // All3
            // 
            All3.AutoSize = true;
            All3.Location = new Point(249, 45);
            All3.Name = "All3";
            All3.Size = new Size(72, 28);
            All3.TabIndex = 13;
            All3.Text = "全选";
            All3.UseVisualStyleBackColor = true;
            All3.CheckStateChanged += Changed3;
            // 
            // All4
            // 
            All4.AutoSize = true;
            All4.Location = new Point(448, 45);
            All4.Name = "All4";
            All4.Size = new Size(72, 28);
            All4.TabIndex = 14;
            All4.Text = "全选";
            All4.UseVisualStyleBackColor = true;
            All4.CheckStateChanged += Changed4;
            // 
            // All5
            // 
            All5.AutoSize = true;
            All5.Location = new Point(617, 45);
            All5.Name = "All5";
            All5.Size = new Size(72, 28);
            All5.TabIndex = 15;
            All5.Text = "全选";
            All5.UseVisualStyleBackColor = true;
            All5.CheckStateChanged += Changed5;
            // 
            // WishForm
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(744, 488);
            Controls.Add(All5);
            Controls.Add(All4);
            Controls.Add(All3);
            Controls.Add(All2);
            Controls.Add(All1);
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
            MaximizeBox = false;
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
        private CheckBox All1;
        private CheckBox All2;
        private CheckBox All3;
        private CheckBox All4;
        private CheckBox All5;
    }
}