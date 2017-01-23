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
            this.btnSouth = new System.Windows.Forms.Button();
            this.btnWest = new System.Windows.Forms.Button();
            this.btnEast = new System.Windows.Forms.Button();
            this.btnAction = new System.Windows.Forms.Button();
            this.pbCurrent = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbCurrent)).BeginInit();
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
            this.btnNorth.Click += new System.EventHandler(this.btnNorth_Click);
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
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // btnUseWeapon
            // 
            this.btnUseWeapon.Location = new System.Drawing.Point(397, 303);
            this.btnUseWeapon.Name = "btnUseWeapon";
            this.btnUseWeapon.Size = new System.Drawing.Size(75, 23);
            this.btnUseWeapon.TabIndex = 19;
            this.btnUseWeapon.Text = "Атака";
            this.btnUseWeapon.UseVisualStyleBackColor = true;
            this.btnUseWeapon.Click += new System.EventHandler(this.btnUseWeapon_Click);
            // 
            // btnUseSkill
            // 
            this.btnUseSkill.Location = new System.Drawing.Point(397, 332);
            this.btnUseSkill.Name = "btnUseSkill";
            this.btnUseSkill.Size = new System.Drawing.Size(75, 23);
            this.btnUseSkill.TabIndex = 20;
            this.btnUseSkill.Text = "Навык";
            this.btnUseSkill.UseVisualStyleBackColor = true;
            this.btnUseSkill.Click += new System.EventHandler(this.btnUseSkill_Click);
            // 
            // btnUsePotion
            // 
            this.btnUsePotion.Location = new System.Drawing.Point(397, 361);
            this.btnUsePotion.Name = "btnUsePotion";
            this.btnUsePotion.Size = new System.Drawing.Size(75, 23);
            this.btnUsePotion.TabIndex = 21;
            this.btnUsePotion.Text = "Лечение";
            this.btnUsePotion.UseVisualStyleBackColor = true;
            this.btnUsePotion.Click += new System.EventHandler(this.btnUsePotion_Click);
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
            // btnSouth
            // 
            this.btnSouth.Location = new System.Drawing.Point(504, 69);
            this.btnSouth.Name = "btnSouth";
            this.btnSouth.Size = new System.Drawing.Size(75, 41);
            this.btnSouth.TabIndex = 25;
            this.btnSouth.Text = "Юг";
            this.btnSouth.UseVisualStyleBackColor = true;
            this.btnSouth.Click += new System.EventHandler(this.btnSouth_Click);
            // 
            // btnWest
            // 
            this.btnWest.Location = new System.Drawing.Point(504, 125);
            this.btnWest.Name = "btnWest";
            this.btnWest.Size = new System.Drawing.Size(75, 41);
            this.btnWest.TabIndex = 26;
            this.btnWest.Text = "Запад";
            this.btnWest.UseVisualStyleBackColor = true;
            this.btnWest.Click += new System.EventHandler(this.btnWest_Click);
            // 
            // btnEast
            // 
            this.btnEast.Location = new System.Drawing.Point(504, 185);
            this.btnEast.Name = "btnEast";
            this.btnEast.Size = new System.Drawing.Size(75, 41);
            this.btnEast.TabIndex = 27;
            this.btnEast.Text = "Восток";
            this.btnEast.UseVisualStyleBackColor = true;
            this.btnEast.Click += new System.EventHandler(this.btnEast_Click);
            // 
            // btnAction
            // 
            this.btnAction.Location = new System.Drawing.Point(504, 247);
            this.btnAction.Name = "btnAction";
            this.btnAction.Size = new System.Drawing.Size(75, 41);
            this.btnAction.TabIndex = 28;
            this.btnAction.Text = "Поиск";
            this.btnAction.UseVisualStyleBackColor = true;
            this.btnAction.Click += new System.EventHandler(this.btnAction_Click);
            // 
            // pbCurrent
            // 
            this.pbCurrent.Image = global::TextRpg.Properties.Resources.level1DefaultCity;
            this.pbCurrent.InitialImage = ((System.Drawing.Image)(resources.GetObject("pbCurrent.InitialImage")));
            this.pbCurrent.Location = new System.Drawing.Point(12, 1);
            this.pbCurrent.Name = "pbCurrent";
            this.pbCurrent.Size = new System.Drawing.Size(460, 287);
            this.pbCurrent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCurrent.TabIndex = 24;
            this.pbCurrent.TabStop = false;
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
            this.Controls.Add(this.pbCurrent);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TextRpg";
            this.Text = "TextRpg";
            ((System.ComponentModel.ISupportInitialize)(this.pbCurrent)).EndInit();
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
        private System.Windows.Forms.PictureBox pbCurrent;
        private System.Windows.Forms.Button btnSouth;
        private System.Windows.Forms.Button btnWest;
        private System.Windows.Forms.Button btnEast;
        private System.Windows.Forms.Button btnAction;
    }
}

