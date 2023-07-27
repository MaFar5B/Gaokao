namespace Gaokao
{
    partial class MajorForm
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
            flowLayoutPanel_Major = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // flowLayoutPanel_Major
            // 
            flowLayoutPanel_Major.AutoScroll = true;
            flowLayoutPanel_Major.AutoSize = true;
            flowLayoutPanel_Major.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel_Major.Location = new Point(12, 12);
            flowLayoutPanel_Major.Name = "flowLayoutPanel_Major";
            flowLayoutPanel_Major.Size = new Size(425, 614);
            flowLayoutPanel_Major.TabIndex = 0;
            // 
            // MajorForm
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(449, 638);
            Controls.Add(flowLayoutPanel_Major);
            MaximizeBox = false;
            Name = "MajorForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "可选志愿";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel_Major;
    }
}