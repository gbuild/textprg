namespace TextRpg
{
    partial class TextRpg
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
            this.globalLevelLabel = new System.Windows.Forms.Label();
            this.globalExpLabel = new System.Windows.Forms.Label();
            this.globalHealthLabel = new System.Windows.Forms.Label();
            this.globalGoldLabel = new System.Windows.Forms.Label();
            this.globalLevelCount = new System.Windows.Forms.Label();
            this.globalExpCount = new System.Windows.Forms.Label();
            this.globalHealthCount = new System.Windows.Forms.Label();
            this.globalGoldCount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // globalLevelLabel
            // 
            this.globalLevelLabel.AutoSize = true;
            this.globalLevelLabel.Location = new System.Drawing.Point(12, 9);
            this.globalLevelLabel.Name = "globalLevelLabel";
            this.globalLevelLabel.Size = new System.Drawing.Size(57, 13);
            this.globalLevelLabel.TabIndex = 0;
            this.globalLevelLabel.Text = "Уровень: ";
            // 
            // globalExpLabel
            // 
            this.globalExpLabel.AutoSize = true;
            this.globalExpLabel.Location = new System.Drawing.Point(116, 9);
            this.globalExpLabel.Name = "globalExpLabel";
            this.globalExpLabel.Size = new System.Drawing.Size(40, 13);
            this.globalExpLabel.TabIndex = 1;
            this.globalExpLabel.Text = "Опыт: ";
            // 
            // globalHealthLabel
            // 
            this.globalHealthLabel.AutoSize = true;
            this.globalHealthLabel.Location = new System.Drawing.Point(445, 9);
            this.globalHealthLabel.Name = "globalHealthLabel";
            this.globalHealthLabel.Size = new System.Drawing.Size(62, 13);
            this.globalHealthLabel.TabIndex = 2;
            this.globalHealthLabel.Text = "Здоровье: ";
            // 
            // globalGoldLabel
            // 
            this.globalGoldLabel.AutoSize = true;
            this.globalGoldLabel.Location = new System.Drawing.Point(544, 9);
            this.globalGoldLabel.Name = "globalGoldLabel";
            this.globalGoldLabel.Size = new System.Drawing.Size(49, 13);
            this.globalGoldLabel.TabIndex = 3;
            this.globalGoldLabel.Text = "Золото: ";
            // 
            // globalLevelCount
            // 
            this.globalLevelCount.AutoSize = true;
            this.globalLevelCount.Location = new System.Drawing.Point(75, 9);
            this.globalLevelCount.Name = "globalLevelCount";
            this.globalLevelCount.Size = new System.Drawing.Size(13, 13);
            this.globalLevelCount.TabIndex = 4;
            this.globalLevelCount.Text = "1";
            // 
            // globalExpCount
            // 
            this.globalExpCount.AutoSize = true;
            this.globalExpCount.Location = new System.Drawing.Point(162, 9);
            this.globalExpCount.Name = "globalExpCount";
            this.globalExpCount.Size = new System.Drawing.Size(13, 13);
            this.globalExpCount.TabIndex = 5;
            this.globalExpCount.Text = "0";
            // 
            // globalHealthCount
            // 
            this.globalHealthCount.AutoSize = true;
            this.globalHealthCount.Location = new System.Drawing.Point(513, 9);
            this.globalHealthCount.Name = "globalHealthCount";
            this.globalHealthCount.Size = new System.Drawing.Size(25, 13);
            this.globalHealthCount.TabIndex = 6;
            this.globalHealthCount.Text = "100";
            // 
            // globalGoldCount
            // 
            this.globalGoldCount.AutoSize = true;
            this.globalGoldCount.Location = new System.Drawing.Point(599, 9);
            this.globalGoldCount.Name = "globalGoldCount";
            this.globalGoldCount.Size = new System.Drawing.Size(13, 13);
            this.globalGoldCount.TabIndex = 7;
            this.globalGoldCount.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.globalGoldCount);
            this.Controls.Add(this.globalHealthCount);
            this.Controls.Add(this.globalExpCount);
            this.Controls.Add(this.globalLevelCount);
            this.Controls.Add(this.globalGoldLabel);
            this.Controls.Add(this.globalHealthLabel);
            this.Controls.Add(this.globalExpLabel);
            this.Controls.Add(this.globalLevelLabel);
            this.Name = "Form1";
            this.Text = "TextRpg";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label globalLevelLabel;
        private System.Windows.Forms.Label globalExpLabel;
        private System.Windows.Forms.Label globalHealthLabel;
        private System.Windows.Forms.Label globalGoldLabel;
        private System.Windows.Forms.Label globalLevelCount;
        private System.Windows.Forms.Label globalExpCount;
        private System.Windows.Forms.Label globalHealthCount;
        private System.Windows.Forms.Label globalGoldCount;
    }
}

