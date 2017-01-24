namespace TextRpg
{
    partial class StatsScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StatsScreen));
            this.pbIcon = new System.Windows.Forms.PictureBox();
            this.globalLevelLabel = new System.Windows.Forms.Label();
            this.globalLevelCount = new System.Windows.Forms.Label();
            this.globalHealthLabel = new System.Windows.Forms.Label();
            this.globalHealthCount = new System.Windows.Forms.Label();
            this.globalGoldLabel = new System.Windows.Forms.Label();
            this.globalGoldCount = new System.Windows.Forms.Label();
            this.dgvInventory = new System.Windows.Forms.DataGridView();
            this.dgbQuests = new System.Windows.Forms.DataGridView();
            this.btnClose = new System.Windows.Forms.Button();
            this.globalExpCount = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgbQuests)).BeginInit();
            this.SuspendLayout();
            // 
            // pbIcon
            // 
            this.pbIcon.Image = ((System.Drawing.Image)(resources.GetObject("pbIcon.Image")));
            this.pbIcon.Location = new System.Drawing.Point(10, 10);
            this.pbIcon.Name = "pbIcon";
            this.pbIcon.Size = new System.Drawing.Size(208, 197);
            this.pbIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbIcon.TabIndex = 0;
            this.pbIcon.TabStop = false;
            // 
            // globalLevelLabel
            // 
            this.globalLevelLabel.AutoSize = true;
            this.globalLevelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.globalLevelLabel.Location = new System.Drawing.Point(233, 12);
            this.globalLevelLabel.Name = "globalLevelLabel";
            this.globalLevelLabel.Size = new System.Drawing.Size(70, 16);
            this.globalLevelLabel.TabIndex = 1;
            this.globalLevelLabel.Text = "Уровень: ";
            // 
            // globalLevelCount
            // 
            this.globalLevelCount.AutoSize = true;
            this.globalLevelCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.globalLevelCount.Location = new System.Drawing.Point(362, 12);
            this.globalLevelCount.Name = "globalLevelCount";
            this.globalLevelCount.Size = new System.Drawing.Size(15, 16);
            this.globalLevelCount.TabIndex = 5;
            this.globalLevelCount.Text = "1";
            // 
            // globalHealthLabel
            // 
            this.globalHealthLabel.AutoSize = true;
            this.globalHealthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.globalHealthLabel.Location = new System.Drawing.Point(233, 61);
            this.globalHealthLabel.Name = "globalHealthLabel";
            this.globalHealthLabel.Size = new System.Drawing.Size(78, 16);
            this.globalHealthLabel.TabIndex = 8;
            this.globalHealthLabel.Text = "Здоровье: ";
            // 
            // globalHealthCount
            // 
            this.globalHealthCount.AutoSize = true;
            this.globalHealthCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.globalHealthCount.Location = new System.Drawing.Point(362, 61);
            this.globalHealthCount.Name = "globalHealthCount";
            this.globalHealthCount.Size = new System.Drawing.Size(29, 16);
            this.globalHealthCount.TabIndex = 9;
            this.globalHealthCount.Text = "100";
            // 
            // globalGoldLabel
            // 
            this.globalGoldLabel.AutoSize = true;
            this.globalGoldLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.globalGoldLabel.Location = new System.Drawing.Point(241, 116);
            this.globalGoldLabel.Name = "globalGoldLabel";
            this.globalGoldLabel.Size = new System.Drawing.Size(62, 16);
            this.globalGoldLabel.TabIndex = 10;
            this.globalGoldLabel.Text = "Золото: ";
            // 
            // globalGoldCount
            // 
            this.globalGoldCount.AutoSize = true;
            this.globalGoldCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.globalGoldCount.Location = new System.Drawing.Point(362, 116);
            this.globalGoldCount.Name = "globalGoldCount";
            this.globalGoldCount.Size = new System.Drawing.Size(15, 16);
            this.globalGoldCount.TabIndex = 11;
            this.globalGoldCount.Text = "0";
            // 
            // dgvInventory
            // 
            this.dgvInventory.AllowUserToAddRows = false;
            this.dgvInventory.AllowUserToDeleteRows = false;
            this.dgvInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInventory.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvInventory.Location = new System.Drawing.Point(10, 230);
            this.dgvInventory.MultiSelect = false;
            this.dgvInventory.Name = "dgvInventory";
            this.dgvInventory.ReadOnly = true;
            this.dgvInventory.Size = new System.Drawing.Size(320, 200);
            this.dgvInventory.TabIndex = 12;
            // 
            // dgbQuests
            // 
            this.dgbQuests.AllowUserToAddRows = false;
            this.dgbQuests.AllowUserToDeleteRows = false;
            this.dgbQuests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgbQuests.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgbQuests.Location = new System.Drawing.Point(352, 230);
            this.dgbQuests.MultiSelect = false;
            this.dgbQuests.Name = "dgbQuests";
            this.dgbQuests.ReadOnly = true;
            this.dgbQuests.Size = new System.Drawing.Size(260, 150);
            this.dgbQuests.TabIndex = 13;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(451, 406);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 14;
            this.btnClose.Text = "Закрыть";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // globalExpCount
            // 
            this.globalExpCount.AutoSize = true;
            this.globalExpCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.globalExpCount.Location = new System.Drawing.Point(585, 106);
            this.globalExpCount.Name = "globalExpCount";
            this.globalExpCount.Size = new System.Drawing.Size(15, 16);
            this.globalExpCount.TabIndex = 15;
            this.globalExpCount.Text = "0";
            // 
            // StatsScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.globalExpCount);
            this.Controls.Add(this.globalHealthCount);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dgbQuests);
            this.Controls.Add(this.dgvInventory);
            this.Controls.Add(this.globalGoldCount);
            this.Controls.Add(this.globalGoldLabel);
            this.Controls.Add(this.globalHealthLabel);
            this.Controls.Add(this.globalLevelCount);
            this.Controls.Add(this.globalLevelLabel);
            this.Controls.Add(this.pbIcon);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StatsScreen";
            this.Text = "StatsScreen";
            ((System.ComponentModel.ISupportInitialize)(this.pbIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgbQuests)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbIcon;
        private System.Windows.Forms.Label globalLevelLabel;
        private System.Windows.Forms.Label globalLevelCount;
        private System.Windows.Forms.Label globalHealthLabel;
        private System.Windows.Forms.Label globalHealthCount;
        private System.Windows.Forms.Label globalGoldLabel;
        private System.Windows.Forms.Label globalGoldCount;
        private System.Windows.Forms.DataGridView dgvInventory;
        private System.Windows.Forms.DataGridView dgbQuests;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label globalExpCount;
    }
}