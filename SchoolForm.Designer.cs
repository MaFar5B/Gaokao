namespace Gaokao
{
    partial class SchoolForm
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
            flowLayoutPanel_School = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // flowLayoutPanel_School
            // 
            flowLayoutPanel_School.AutoScroll = true;
            flowLayoutPanel_School.AutoSize = true;
            flowLayoutPanel_School.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel_School.Location = new Point(12, 12);
            flowLayoutPanel_School.Name = "flowLayoutPanel_School";
            flowLayoutPanel_School.Size = new Size(327, 591);
            flowLayoutPanel_School.TabIndex = 0;
            // 
            // SchoolForm
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(351, 622);
            Controls.Add(flowLayoutPanel_School);
            MaximizeBox = false;
            Name = "SchoolForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SchoolForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel_School;
    }
}