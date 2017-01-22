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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TextRpg));
            this.btnNorth = new System.Windows.Forms.Button();
            this.cboWeapons = new System.Windows.Forms.ComboBox();
            this.cboSkills = new System.Windows.Forms.ComboBox();
            this.cboPotions = new System.Windows.Forms.ComboBox();
            this.btnRun = new System.Windows.Forms.Button();
            this.btnUseWeapon = new System.Windows.Forms.Button();
            this.btnUseSkill = new System.Windows.Forms.Button();
            this.btnUsePotion = new System.Windows.Forms.Button();
            this.rtbMessages = new System.Windows.Forms.RichTextBox();
            this.btnInventory = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSouth = new System.Windows.Forms.Button();
            this.btnWest = new System.Windows.Forms.Button();
            this.btnEast = new System.Windows.Forms.Button();
            this.btnAction = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNorth
            // 
            this.btnNorth.Location = new System.Drawing.Point(504, 12);
            this.btnNorth.Name = "btnNorth";
            this.btnNorth.Size = new System.Drawing.Size(75, 41);
            this.btnNorth.TabIndex = 8;
            this.btnNorth.Text = "Север";
            this.btnNorth.UseVisualStyleBackColor = true;
            // 
            // cboWeapons
            // 
            this.cboWeapons.FormattingEnabled = true;
            this.cboWeapons.Location = new System.Drawing.Point(491, 303);
            this.cboWeapons.Name = "cboWeapons";
            this.cboWeapons.Size = new System.Drawing.Size(121, 21);
            this.cboWeapons.TabIndex = 15;
            // 
            // cboSkills
            // 
            this.cboSkills.FormattingEnabled = true;
            this.cboSkills.Location = new System.Drawing.Point(491, 334);
            this.cboSkills.Name = "cboSkills";
            this.cboSkills.Size = new System.Drawing.Size(121, 21);
            this.cboSkills.TabIndex = 16;
            // 
            // cboPotions
            // 
            this.cboPotions.FormattingEnabled = true;
            this.cboPotions.Location = new System.Drawing.Point(491, 363);
            this.cboPotions.Name = "cboPotions";
            this.cboPotions.Size = new System.Drawing.Size(121, 21);
            this.cboPotions.TabIndex = 17;
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(537, 406);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(75, 23);
            this.btnRun.TabIndex = 18;
            this.btnRun.Text = "Убежать";
            this.btnRun.UseVisualStyleBackColor = true;
            // 
            // btnUseWeapon
            // 
            this.btnUseWeapon.Location = new System.Drawing.Point(397, 303);
            this.btnUseWeapon.Name = "btnUseWeapon";
            this.btnUseWeapon.Size = new System.Drawing.Size(75, 23);
            this.btnUseWeapon.TabIndex = 19;
            this.btnUseWeapon.Text = "Атака";
            this.btnUseWeapon.UseVisualStyleBackColor = true;
            // 
            // btnUseSkill
            // 
            this.btnUseSkill.Location = new System.Drawing.Point(397, 332);
            this.btnUseSkill.Name = "btnUseSkill";
            this.btnUseSkill.Size = new System.Drawing.Size(75, 23);
            this.btnUseSkill.TabIndex = 20;
            this.btnUseSkill.Text = "Навык";
            this.btnUseSkill.UseVisualStyleBackColor = true;
            // 
            // btnUsePotion
            // 
            this.btnUsePotion.Location = new System.Drawing.Point(397, 361);
            this.btnUsePotion.Name = "btnUsePotion";
            this.btnUsePotion.Size = new System.Drawing.Size(75, 23);
            this.btnUsePotion.TabIndex = 21;
            this.btnUsePotion.Text = "Лечение";
            this.btnUsePotion.UseVisualStyleBackColor = true;
            // 
            // rtbMessages
            // 
            this.rtbMessages.Location = new System.Drawing.Point(12, 303);
            this.rtbMessages.Name = "rtbMessages";
            this.rtbMessages.ReadOnly = true;
            this.rtbMessages.Size = new System.Drawing.Size(379, 126);
            this.rtbMessages.TabIndex = 22;
            this.rtbMessages.Text = "";
            // 
            // btnInventory
            // 
            this.btnInventory.Location = new System.Drawing.Point(397, 406);
            this.btnInventory.Name = "btnInventory";
            this.btnInventory.Size = new System.Drawing.Size(75, 23);
            this.btnInventory.TabIndex = 23;
            this.btnInventory.Text = "Инвентарь";
            this.btnInventory.UseVisualStyleBackColor = true;
            this.btnInventory.Click += new System.EventHandler(this.btnInventory_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(460, 287);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // btnSouth
            // 
            this.btnSouth.Location = new System.Drawing.Point(504, 69);
            this.btnSouth.Name = "btnSouth";
            this.btnSouth.Size = new System.Drawing.Size(75, 41);
            this.btnSouth.TabIndex = 25;
            this.btnSouth.Text = "Юг";
            this.btnSouth.UseVisualStyleBackColor = true;
            // 
            // btnWest
            // 
            this.btnWest.Location = new System.Drawing.Point(504, 125);
            this.btnWest.Name = "btnWest";
            this.btnWest.Size = new System.Drawing.Size(75, 41);
            this.btnWest.TabIndex = 26;
            this.btnWest.Text = "Запад";
            this.btnWest.UseVisualStyleBackColor = true;
            // 
            // btnEast
            // 
            this.btnEast.Location = new System.Drawing.Point(504, 185);
            this.btnEast.Name = "btnEast";
            this.btnEast.Size = new System.Drawing.Size(75, 41);
            this.btnEast.TabIndex = 27;
            this.btnEast.Text = "Восток";
            this.btnEast.UseVisualStyleBackColor = true;
            // 
            // btnAction
            // 
            this.btnAction.Location = new System.Drawing.Point(504, 247);
            this.btnAction.Name = "btnAction";
            this.btnAction.Size = new System.Drawing.Size(75, 41);
            this.btnAction.TabIndex = 28;
            this.btnAction.Text = "Действие";
            this.btnAction.UseVisualStyleBackColor = true;
            // 
            // TextRpg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.btnAction);
            this.Controls.Add(this.btnEast);
            this.Controls.Add(this.btnWest);
            this.Controls.Add(this.btnSouth);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnInventory);
            this.Controls.Add(this.rtbMessages);
            this.Controls.Add(this.btnUsePotion);
            this.Controls.Add(this.btnUseSkill);
            this.Controls.Add(this.btnUseWeapon);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.cboPotions);
            this.Controls.Add(this.cboSkills);
            this.Controls.Add(this.cboWeapons);
            this.Controls.Add(this.btnNorth);
            this.Name = "TextRpg";
            this.Text = "TextRpg";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnNorth;
        private System.Windows.Forms.ComboBox cboWeapons;
        private System.Windows.Forms.ComboBox cboSkills;
        private System.Windows.Forms.ComboBox cboPotions;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Button btnUseWeapon;
        private System.Windows.Forms.Button btnUseSkill;
        private System.Windows.Forms.Button btnUsePotion;
        private System.Windows.Forms.RichTextBox rtbMessages;
        private System.Windows.Forms.Button btnInventory;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnSouth;
        private System.Windows.Forms.Button btnWest;
        private System.Windows.Forms.Button btnEast;
        private System.Windows.Forms.Button btnAction;
    }
}

