namespace Gaokao
{
    partial class SchoolModule
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
            SchoolName = new Label();
            Property = new Label();
            FirstClass = new Label();
            Level = new Label();
            dataGridView1 = new DataGridView();
            Year = new DataGridViewTextBoxColumn();
            Grade = new DataGridViewTextBoxColumn();
            Rank = new DataGridViewTextBoxColumn();
            AvailableMajor = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // SchoolName
            // 
            SchoolName.AutoSize = true;
            SchoolName.Font = new Font("Microsoft YaHei UI", 10.5F, FontStyle.Bold, GraphicsUnit.Point);
            SchoolName.ForeColor = Color.DarkBlue;
            SchoolName.Location = new Point(3, 8);
            SchoolName.Name = "SchoolName";
            SchoolName.Size = new Size(173, 28);
            SchoolName.TabIndex = 0;
            SchoolName.Text = "ExampleSchool";
            SchoolName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Property
            // 
            Property.AutoSize = true;
            Property.Location = new Point(3, 36);
            Property.Name = "Property";
            Property.Size = new Size(158, 24);
            Property.TabIndex = 1;
            Property.Text = "ExampleProperty";
            // 
            // FirstClass
            // 
            FirstClass.AutoSize = true;
            FirstClass.Location = new Point(183, 36);
            FirstClass.Name = "FirstClass";
            FirstClass.Size = new Size(126, 24);
            FirstClass.TabIndex = 2;
            FirstClass.Text = "ExampleClass";
            // 
            // Level
            // 
            Level.AutoSize = true;
            Level.ForeColor = Color.BlueViolet;
            Level.Location = new Point(3, 60);
            Level.Name = "Level";
            Level.Size = new Size(126, 24);
            Level.TabIndex = 3;
            Level.Text = "ExampleLevel";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            dataGridView1.BackgroundColor = SystemColors.GradientInactiveCaption;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Year, Grade, Rank });
            dataGridView1.Location = new Point(3, 87);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 32;
            dataGridView1.ScrollBars = ScrollBars.None;
            dataGridView1.Size = new Size(306, 122);
            dataGridView1.TabIndex = 7;
            // 
            // Year
            // 
            Year.HeaderText = "年份";
            Year.MinimumWidth = 8;
            Year.Name = "Year";
            Year.Width = 82;
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
            // AvailableMajor
            // 
            AvailableMajor.BackColor = Color.SteelBlue;
            AvailableMajor.Location = new Point(3, 214);
            AvailableMajor.Name = "AvailableMajor";
            AvailableMajor.Size = new Size(306, 34);
            AvailableMajor.TabIndex = 8;
            AvailableMajor.Text = "AvailableMajor";
            AvailableMajor.UseVisualStyleBackColor = false;
            AvailableMajor.Click += Available_Major_Click;
            // 
            // SchoolModule
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = SystemColors.InactiveCaption;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(AvailableMajor);
            Controls.Add(dataGridView1);
            Controls.Add(Level);
            Controls.Add(FirstClass);
            Controls.Add(Property);
            Controls.Add(SchoolName);
            Name = "SchoolModule";
            Size = new Size(314, 251);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label SchoolName;
        private Label Property;
        private Label FirstClass;
        private Label Level;
        private DataGridView dataGridView1;
        private Button AvailableMajor;
        private DataGridViewTextBoxColumn Year;
        private DataGridViewTextBoxColumn Grade;
        private DataGridViewTextBoxColumn Rank;
    }
}
