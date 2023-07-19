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
            phy = new CheckBox();
            bio = new CheckBox();
            his = new CheckBox();
            ch = new CheckBox();
            pol = new CheckBox();
            geo = new CheckBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // phy
            // 
            phy.AutoSize = true;
            phy.Location = new Point(102, 28);
            phy.Name = "phy";
            phy.Size = new Size(72, 28);
            phy.TabIndex = 0;
            phy.Text = "物理";
            phy.UseVisualStyleBackColor = true;
            // 
            // bio
            // 
            bio.AutoSize = true;
            bio.Location = new Point(102, 62);
            bio.Name = "bio";
            bio.Size = new Size(72, 28);
            bio.TabIndex = 1;
            bio.Text = "生物";
            bio.UseVisualStyleBackColor = true;
            // 
            // his
            // 
            his.AccessibleDescription = "";
            his.AutoSize = true;
            his.Location = new Point(102, 96);
            his.Name = "his";
            his.Size = new Size(72, 28);
            his.TabIndex = 2;
            his.Text = "历史";
            his.UseVisualStyleBackColor = true;
            // 
            // ch
            // 
            ch.AutoSize = true;
            ch.Location = new Point(247, 28);
            ch.Name = "ch";
            ch.Size = new Size(72, 28);
            ch.TabIndex = 3;
            ch.Text = "化学";
            ch.UseVisualStyleBackColor = true;
            // 
            // pol
            // 
            pol.AutoSize = true;
            pol.Location = new Point(247, 62);
            pol.Name = "pol";
            pol.Size = new Size(72, 28);
            pol.TabIndex = 4;
            pol.Text = "政治";
            pol.UseVisualStyleBackColor = true;
            // 
            // geo
            // 
            geo.AccessibleDescription = "";
            geo.AutoSize = true;
            geo.Location = new Point(247, 96);
            geo.Name = "geo";
            geo.Size = new Size(72, 28);
            geo.TabIndex = 5;
            geo.Text = "地理";
            geo.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(150, 148);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 6;
            button1.Text = "确认";
            button1.UseVisualStyleBackColor = true;
            button1.Click += confirmsubject;
            // 
            // SubjectForm
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(422, 220);
            Controls.Add(button1);
            Controls.Add(geo);
            Controls.Add(pol);
            Controls.Add(ch);
            Controls.Add(his);
            Controls.Add(bio);
            Controls.Add(phy);
            Name = "SubjectForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "科目选择";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox phy;
        private CheckBox bio;
        private CheckBox his;
        private CheckBox ch;
        private CheckBox pol;
        private CheckBox geo;
        private Button button1;
    }
}