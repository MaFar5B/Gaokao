namespace Gaokao
{
    partial class MajorModule
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            MajorName = new Label();
            dataGridView1 = new DataGridView();
            Year = new DataGridViewTextBoxColumn();
            EnrollMent = new DataGridViewTextBoxColumn();
            Grade = new DataGridViewTextBoxColumn();
            Rank = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // MajorName
            // 
            MajorName.AutoSize = true;
            MajorName.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            MajorName.ForeColor = Color.SteelBlue;
            MajorName.ImageAlign = ContentAlignment.TopLeft;
            MajorName.Location = new Point(4, 10);
            MajorName.MaximumSize = new Size(400, 200);
            MajorName.Name = "MajorName";
            MajorName.Size = new Size(142, 25);
            MajorName.TabIndex = 0;
            MajorName.Text = "ExampleMajor";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            dataGridView1.BackgroundColor = SystemColors.GradientInactiveCaption;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Year, EnrollMent, Grade, Rank });
            dataGridView1.Location = new Point(4, 66);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 32;
            dataGridView1.ScrollBars = ScrollBars.None;
            dataGridView1.Size = new Size(404, 125);
            dataGridView1.TabIndex = 1;
            // 
            // Year
            // 
            Year.HeaderText = "年份";
            Year.MinimumWidth = 8;
            Year.Name = "Year";
            Year.Width = 82;
            // 
            // EnrollMent
            // 
            EnrollMent.HeaderText = "招生数";
            EnrollMent.MinimumWidth = 8;
            EnrollMent.Name = "EnrollMent";
            // 
            // Grade
            // 
            Grade.HeaderText = "最低分";
            Grade.MinimumWidth = 8;
            Grade.Name = "Grade";
            // 
            // Rank
            // 
            Rank.HeaderText = "最低位次";
            Rank.MinimumWidth = 8;
            Rank.Name = "Rank";
            Rank.Width = 118;
            // 
            // MajorModule
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = SystemColors.InactiveCaption;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(dataGridView1);
            Controls.Add(MajorName);
            Name = "MajorModule";
            Size = new Size(411, 194);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label MajorName;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Year;
        private DataGridViewTextBoxColumn EnrollMent;
        private DataGridViewTextBoxColumn Grade;
        private DataGridViewTextBoxColumn Rank;
    }
}
