namespace Gaokao
{
    partial class ResultForm
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
            grade = new Label();
            subjects = new Label();
            level = new Label();
            rank = new Label();
            high_risk = new PictureBox();
            middle_risk = new PictureBox();
            low_risk = new PictureBox();
            high_risk_count = new Label();
            middle_risk_count = new Label();
            low_risk_count = new Label();
            ReGenerate = new Button();
            ((System.ComponentModel.ISupportInitialize)high_risk).BeginInit();
            ((System.ComponentModel.ISupportInitialize)middle_risk).BeginInit();
            ((System.ComponentModel.ISupportInitialize)low_risk).BeginInit();
            SuspendLayout();
            // 
            // grade
            // 
            grade.AutoSize = true;
            grade.Location = new Point(194, 33);
            grade.Name = "grade";
            grade.Size = new Size(64, 24);
            grade.TabIndex = 0;
            grade.Text = "考分：";
            // 
            // subjects
            // 
            subjects.AutoSize = true;
            subjects.Location = new Point(540, 33);
            subjects.Name = "subjects";
            subjects.Size = new Size(64, 24);
            subjects.TabIndex = 1;
            subjects.Text = "选科：";
            // 
            // level
            // 
            level.AutoSize = true;
            level.Location = new Point(194, 89);
            level.Name = "level";
            level.Size = new Size(64, 24);
            level.TabIndex = 2;
            level.Text = "批次：";
            // 
            // rank
            // 
            rank.AutoSize = true;
            rank.Location = new Point(540, 89);
            rank.Name = "rank";
            rank.Size = new Size(64, 24);
            rank.TabIndex = 3;
            rank.Text = "位次：";
            // 
            // high_risk
            // 
            high_risk.BackColor = SystemColors.GradientInactiveCaption;
            high_risk.Image = Properties.Resources.冲;
            high_risk.Location = new Point(37, 205);
            high_risk.Name = "high_risk";
            high_risk.Size = new Size(221, 117);
            high_risk.SizeMode = PictureBoxSizeMode.Zoom;
            high_risk.TabIndex = 4;
            high_risk.TabStop = false;
            high_risk.Click += high_risk_click;
            // 
            // middle_risk
            // 
            middle_risk.BackColor = SystemColors.GradientInactiveCaption;
            middle_risk.Image = Properties.Resources.稳;
            middle_risk.Location = new Point(328, 205);
            middle_risk.Name = "middle_risk";
            middle_risk.Size = new Size(221, 117);
            middle_risk.SizeMode = PictureBoxSizeMode.Zoom;
            middle_risk.TabIndex = 5;
            middle_risk.TabStop = false;
            middle_risk.Click += middle_risk_click;
            // 
            // low_risk
            // 
            low_risk.BackColor = SystemColors.GradientInactiveCaption;
            low_risk.Image = Properties.Resources.保;
            low_risk.Location = new Point(629, 205);
            low_risk.Name = "low_risk";
            low_risk.Size = new Size(221, 117);
            low_risk.SizeMode = PictureBoxSizeMode.Zoom;
            low_risk.TabIndex = 6;
            low_risk.TabStop = false;
            low_risk.Click += low_risk_click;
            // 
            // high_risk_count
            // 
            high_risk_count.AutoSize = true;
            high_risk_count.Location = new Point(138, 353);
            high_risk_count.Name = "high_risk_count";
            high_risk_count.Size = new Size(28, 24);
            high_risk_count.TabIndex = 7;
            high_risk_count.Text = "所";
            // 
            // middle_risk_count
            // 
            middle_risk_count.AutoSize = true;
            middle_risk_count.Location = new Point(430, 353);
            middle_risk_count.Name = "middle_risk_count";
            middle_risk_count.Size = new Size(28, 24);
            middle_risk_count.TabIndex = 8;
            middle_risk_count.Text = "所";
            // 
            // low_risk_count
            // 
            low_risk_count.AutoSize = true;
            low_risk_count.Location = new Point(731, 353);
            low_risk_count.Name = "low_risk_count";
            low_risk_count.Size = new Size(28, 24);
            low_risk_count.TabIndex = 9;
            low_risk_count.Text = "所";
            // 
            // ReGenerate
            // 
            ReGenerate.BackColor = SystemColors.GradientInactiveCaption;
            ReGenerate.Location = new Point(328, 409);
            ReGenerate.Name = "ReGenerate";
            ReGenerate.Size = new Size(221, 55);
            ReGenerate.TabIndex = 10;
            ReGenerate.Text = "返回";
            ReGenerate.UseVisualStyleBackColor = false;
            ReGenerate.Click += ReGenerate_Click;
            // 
            // ResultForm
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(886, 497);
            Controls.Add(ReGenerate);
            Controls.Add(low_risk_count);
            Controls.Add(middle_risk_count);
            Controls.Add(high_risk_count);
            Controls.Add(low_risk);
            Controls.Add(middle_risk);
            Controls.Add(high_risk);
            Controls.Add(rank);
            Controls.Add(level);
            Controls.Add(subjects);
            Controls.Add(grade);
            MaximizeBox = false;
            Name = "ResultForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "院校推荐";
            ((System.ComponentModel.ISupportInitialize)high_risk).EndInit();
            ((System.ComponentModel.ISupportInitialize)middle_risk).EndInit();
            ((System.ComponentModel.ISupportInitialize)low_risk).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        public void changeText()
        {
            this.grade.Text = "考分：" + Program.student.score.ToString() + "分";
            this.subjects.Text = "选科：" + Program.student.subjects[0] + " " + Program.student.subjects[1] + " " + Program.student.subjects[2];
            if (Program.student.score >= 443)
            {
                this.level.Text = "批次：普通类一段";
            }
            else
            {
                this.level.Text = "批次：普通类二段";
            }
            this.rank.Text = "位次：" + Program.student.rank.ToString() + "名";
            this.high_risk_count.Text = Program.high_risk.Count.ToString() + "所";
            this.middle_risk_count.Text = Program.middle_risk.Count.ToString() + "所";
            this.low_risk_count.Text = Program.low_risk.Count.ToString() + "所";
        }

        #endregion

        private Label grade;
        private Label subjects;
        private Label level;
        private Label rank;
        private PictureBox high_risk;
        private PictureBox middle_risk;
        private PictureBox low_risk;
        private Label high_risk_count;
        private Label middle_risk_count;
        private Label low_risk_count;
        private Button ReGenerate;
    }
}