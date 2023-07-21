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
            SuspendLayout();
            // 
            // grade
            // 
            grade.AutoSize = true;
            grade.Location = new Point(217, 33);
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
            level.Location = new Point(217, 89);
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
            // ResultForm
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(886, 497);
            Controls.Add(rank);
            Controls.Add(level);
            Controls.Add(subjects);
            Controls.Add(grade);
            MaximizeBox = false;
            Name = "ResultForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "院校推荐";
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
        }

        #endregion

        private Label grade;
        private Label subjects;
        private Label level;
        private Label rank;
    }
}