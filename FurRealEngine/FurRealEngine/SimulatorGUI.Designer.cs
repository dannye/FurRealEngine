namespace FurRealEngine
{
    partial class SimulatorGUI
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
            this.characterList = new System.Windows.Forms.ListBox();
            this.monsterList = new System.Windows.Forms.ListBox();
            this.characterGroup = new System.Windows.Forms.GroupBox();
            this.professionText = new System.Windows.Forms.TextBox();
            this.professionLabel = new System.Windows.Forms.Label();
            this.charMaxHealthText = new System.Windows.Forms.TextBox();
            this.slash1Label = new System.Windows.Forms.Label();
            this.charCurHealthText = new System.Windows.Forms.TextBox();
            this.charHealthLabel = new System.Windows.Forms.Label();
            this.constitutionText = new System.Windows.Forms.TextBox();
            this.constitutionLabel = new System.Windows.Forms.Label();
            this.dexterityText = new System.Windows.Forms.TextBox();
            this.dexterityLabel = new System.Windows.Forms.Label();
            this.wisdomText = new System.Windows.Forms.TextBox();
            this.intelligenceText = new System.Windows.Forms.TextBox();
            this.wisdomLabel = new System.Windows.Forms.Label();
            this.intelligenceLabel = new System.Windows.Forms.Label();
            this.strengthText = new System.Windows.Forms.TextBox();
            this.strengthLabel = new System.Windows.Forms.Label();
            this.monsterGroup = new System.Windows.Forms.GroupBox();
            this.nameText = new System.Windows.Forms.TextBox();
            this.typeText = new System.Windows.Forms.TextBox();
            this.difficultyLevelText = new System.Windows.Forms.TextBox();
            this.difficultyLevelLabel = new System.Windows.Forms.Label();
            this.monsterMaxHealthText = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.slash2Label = new System.Windows.Forms.Label();
            this.typeLabel = new System.Windows.Forms.Label();
            this.monsterCurHealthText = new System.Windows.Forms.TextBox();
            this.monsterHealthLabel = new System.Windows.Forms.Label();
            this.meleeButton = new System.Windows.Forms.Button();
            this.spellButton = new System.Windows.Forms.Button();
            this.characterGroup.SuspendLayout();
            this.monsterGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // characterList
            // 
            this.characterList.FormattingEnabled = true;
            this.characterList.ItemHeight = 20;
            this.characterList.Location = new System.Drawing.Point(56, 75);
            this.characterList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.characterList.Name = "characterList";
            this.characterList.Size = new System.Drawing.Size(134, 324);
            this.characterList.TabIndex = 0;
            this.characterList.SelectedIndexChanged += new System.EventHandler(this.characterList_SelectedIndexChanged);
            // 
            // monsterList
            // 
            this.monsterList.FormattingEnabled = true;
            this.monsterList.ItemHeight = 20;
            this.monsterList.Location = new System.Drawing.Point(852, 70);
            this.monsterList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.monsterList.Name = "monsterList";
            this.monsterList.Size = new System.Drawing.Size(134, 324);
            this.monsterList.TabIndex = 1;
            // 
            // characterGroup
            // 
            this.characterGroup.Controls.Add(this.professionText);
            this.characterGroup.Controls.Add(this.professionLabel);
            this.characterGroup.Controls.Add(this.charMaxHealthText);
            this.characterGroup.Controls.Add(this.slash1Label);
            this.characterGroup.Controls.Add(this.charCurHealthText);
            this.characterGroup.Controls.Add(this.charHealthLabel);
            this.characterGroup.Controls.Add(this.constitutionText);
            this.characterGroup.Controls.Add(this.constitutionLabel);
            this.characterGroup.Controls.Add(this.dexterityText);
            this.characterGroup.Controls.Add(this.dexterityLabel);
            this.characterGroup.Controls.Add(this.wisdomText);
            this.characterGroup.Controls.Add(this.intelligenceText);
            this.characterGroup.Controls.Add(this.wisdomLabel);
            this.characterGroup.Controls.Add(this.intelligenceLabel);
            this.characterGroup.Controls.Add(this.strengthText);
            this.characterGroup.Controls.Add(this.strengthLabel);
            this.characterGroup.Location = new System.Drawing.Point(219, 75);
            this.characterGroup.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.characterGroup.Name = "characterGroup";
            this.characterGroup.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.characterGroup.Size = new System.Drawing.Size(263, 320);
            this.characterGroup.TabIndex = 2;
            this.characterGroup.TabStop = false;
            this.characterGroup.Text = "Character Stats";
            // 
            // professionText
            // 
            this.professionText.Location = new System.Drawing.Point(123, 41);
            this.professionText.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.professionText.Name = "professionText";
            this.professionText.Size = new System.Drawing.Size(111, 26);
            this.professionText.TabIndex = 17;
            // 
            // professionLabel
            // 
            this.professionLabel.AutoSize = true;
            this.professionLabel.Location = new System.Drawing.Point(18, 41);
            this.professionLabel.Name = "professionLabel";
            this.professionLabel.Size = new System.Drawing.Size(88, 20);
            this.professionLabel.TabIndex = 16;
            this.professionLabel.Text = "Profession:";
            // 
            // charMaxHealthText
            // 
            this.charMaxHealthText.Location = new System.Drawing.Point(191, 89);
            this.charMaxHealthText.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.charMaxHealthText.Name = "charMaxHealthText";
            this.charMaxHealthText.Size = new System.Drawing.Size(42, 26);
            this.charMaxHealthText.TabIndex = 15;
            // 
            // slash1Label
            // 
            this.slash1Label.AutoSize = true;
            this.slash1Label.Location = new System.Drawing.Point(171, 92);
            this.slash1Label.Name = "slash1Label";
            this.slash1Label.Size = new System.Drawing.Size(13, 20);
            this.slash1Label.TabIndex = 14;
            this.slash1Label.Text = "/";
            // 
            // charCurHealthText
            // 
            this.charCurHealthText.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.charCurHealthText.Location = new System.Drawing.Point(123, 89);
            this.charCurHealthText.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.charCurHealthText.Name = "charCurHealthText";
            this.charCurHealthText.ReadOnly = true;
            this.charCurHealthText.Size = new System.Drawing.Size(41, 26);
            this.charCurHealthText.TabIndex = 13;
            // 
            // charHealthLabel
            // 
            this.charHealthLabel.AutoSize = true;
            this.charHealthLabel.Location = new System.Drawing.Point(18, 89);
            this.charHealthLabel.Name = "charHealthLabel";
            this.charHealthLabel.Size = new System.Drawing.Size(60, 20);
            this.charHealthLabel.TabIndex = 12;
            this.charHealthLabel.Text = "Health:";
            // 
            // constitutionText
            // 
            this.constitutionText.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.constitutionText.Location = new System.Drawing.Point(123, 272);
            this.constitutionText.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.constitutionText.Name = "constitutionText";
            this.constitutionText.ReadOnly = true;
            this.constitutionText.Size = new System.Drawing.Size(111, 26);
            this.constitutionText.TabIndex = 11;
            // 
            // constitutionLabel
            // 
            this.constitutionLabel.AutoSize = true;
            this.constitutionLabel.Location = new System.Drawing.Point(18, 272);
            this.constitutionLabel.Name = "constitutionLabel";
            this.constitutionLabel.Size = new System.Drawing.Size(98, 20);
            this.constitutionLabel.TabIndex = 10;
            this.constitutionLabel.Text = "Constitution:";
            // 
            // dexterityText
            // 
            this.dexterityText.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.dexterityText.Location = new System.Drawing.Point(123, 241);
            this.dexterityText.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dexterityText.Name = "dexterityText";
            this.dexterityText.ReadOnly = true;
            this.dexterityText.Size = new System.Drawing.Size(111, 26);
            this.dexterityText.TabIndex = 9;
            // 
            // dexterityLabel
            // 
            this.dexterityLabel.AutoSize = true;
            this.dexterityLabel.Location = new System.Drawing.Point(18, 241);
            this.dexterityLabel.Name = "dexterityLabel";
            this.dexterityLabel.Size = new System.Drawing.Size(79, 20);
            this.dexterityLabel.TabIndex = 8;
            this.dexterityLabel.Text = "Dexterity: ";
            // 
            // wisdomText
            // 
            this.wisdomText.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.wisdomText.Location = new System.Drawing.Point(123, 210);
            this.wisdomText.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.wisdomText.Name = "wisdomText";
            this.wisdomText.ReadOnly = true;
            this.wisdomText.Size = new System.Drawing.Size(111, 26);
            this.wisdomText.TabIndex = 7;
            // 
            // intelligenceText
            // 
            this.intelligenceText.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.intelligenceText.Location = new System.Drawing.Point(123, 179);
            this.intelligenceText.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.intelligenceText.Name = "intelligenceText";
            this.intelligenceText.ReadOnly = true;
            this.intelligenceText.Size = new System.Drawing.Size(111, 26);
            this.intelligenceText.TabIndex = 3;
            // 
            // wisdomLabel
            // 
            this.wisdomLabel.AutoSize = true;
            this.wisdomLabel.Location = new System.Drawing.Point(18, 210);
            this.wisdomLabel.Name = "wisdomLabel";
            this.wisdomLabel.Size = new System.Drawing.Size(70, 20);
            this.wisdomLabel.TabIndex = 6;
            this.wisdomLabel.Text = "Wisdom:";
            // 
            // intelligenceLabel
            // 
            this.intelligenceLabel.AutoSize = true;
            this.intelligenceLabel.Location = new System.Drawing.Point(18, 179);
            this.intelligenceLabel.Name = "intelligenceLabel";
            this.intelligenceLabel.Size = new System.Drawing.Size(98, 20);
            this.intelligenceLabel.TabIndex = 2;
            this.intelligenceLabel.Text = "Intelligence: ";
            // 
            // strengthText
            // 
            this.strengthText.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.strengthText.Location = new System.Drawing.Point(123, 146);
            this.strengthText.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.strengthText.Name = "strengthText";
            this.strengthText.ReadOnly = true;
            this.strengthText.Size = new System.Drawing.Size(111, 26);
            this.strengthText.TabIndex = 1;
            // 
            // strengthLabel
            // 
            this.strengthLabel.AutoSize = true;
            this.strengthLabel.Location = new System.Drawing.Point(18, 146);
            this.strengthLabel.Name = "strengthLabel";
            this.strengthLabel.Size = new System.Drawing.Size(79, 20);
            this.strengthLabel.TabIndex = 0;
            this.strengthLabel.Text = "Strength: ";
            // 
            // monsterGroup
            // 
            this.monsterGroup.Controls.Add(this.nameText);
            this.monsterGroup.Controls.Add(this.typeText);
            this.monsterGroup.Controls.Add(this.difficultyLevelText);
            this.monsterGroup.Controls.Add(this.difficultyLevelLabel);
            this.monsterGroup.Controls.Add(this.monsterMaxHealthText);
            this.monsterGroup.Controls.Add(this.nameLabel);
            this.monsterGroup.Controls.Add(this.slash2Label);
            this.monsterGroup.Controls.Add(this.typeLabel);
            this.monsterGroup.Controls.Add(this.monsterCurHealthText);
            this.monsterGroup.Controls.Add(this.monsterHealthLabel);
            this.monsterGroup.Location = new System.Drawing.Point(529, 75);
            this.monsterGroup.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.monsterGroup.Name = "monsterGroup";
            this.monsterGroup.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.monsterGroup.Size = new System.Drawing.Size(287, 325);
            this.monsterGroup.TabIndex = 3;
            this.monsterGroup.TabStop = false;
            this.monsterGroup.Text = "Monster Stats";
            // 
            // nameText
            // 
            this.nameText.Location = new System.Drawing.Point(144, 74);
            this.nameText.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nameText.Name = "nameText";
            this.nameText.Size = new System.Drawing.Size(109, 26);
            this.nameText.TabIndex = 25;
            // 
            // typeText
            // 
            this.typeText.Location = new System.Drawing.Point(144, 40);
            this.typeText.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.typeText.Name = "typeText";
            this.typeText.Size = new System.Drawing.Size(109, 26);
            this.typeText.TabIndex = 24;
            // 
            // difficultyLevelText
            // 
            this.difficultyLevelText.Location = new System.Drawing.Point(144, 156);
            this.difficultyLevelText.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.difficultyLevelText.Name = "difficultyLevelText";
            this.difficultyLevelText.Size = new System.Drawing.Size(109, 26);
            this.difficultyLevelText.TabIndex = 23;
            // 
            // difficultyLevelLabel
            // 
            this.difficultyLevelLabel.AutoSize = true;
            this.difficultyLevelLabel.Location = new System.Drawing.Point(11, 160);
            this.difficultyLevelLabel.Name = "difficultyLevelLabel";
            this.difficultyLevelLabel.Size = new System.Drawing.Size(114, 20);
            this.difficultyLevelLabel.TabIndex = 22;
            this.difficultyLevelLabel.Text = "Difficulty Level:";
            // 
            // monsterMaxHealthText
            // 
            this.monsterMaxHealthText.Location = new System.Drawing.Point(208, 115);
            this.monsterMaxHealthText.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.monsterMaxHealthText.Name = "monsterMaxHealthText";
            this.monsterMaxHealthText.Size = new System.Drawing.Size(44, 26);
            this.monsterMaxHealthText.TabIndex = 21;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(12, 74);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(55, 20);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "Name:";
            // 
            // slash2Label
            // 
            this.slash2Label.AutoSize = true;
            this.slash2Label.Location = new System.Drawing.Point(190, 118);
            this.slash2Label.Name = "slash2Label";
            this.slash2Label.Size = new System.Drawing.Size(13, 20);
            this.slash2Label.TabIndex = 20;
            this.slash2Label.Text = "/";
            // 
            // typeLabel
            // 
            this.typeLabel.AutoSize = true;
            this.typeLabel.Location = new System.Drawing.Point(12, 41);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(47, 20);
            this.typeLabel.TabIndex = 0;
            this.typeLabel.Text = "Type:";
            // 
            // monsterCurHealthText
            // 
            this.monsterCurHealthText.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.monsterCurHealthText.Location = new System.Drawing.Point(144, 115);
            this.monsterCurHealthText.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.monsterCurHealthText.Name = "monsterCurHealthText";
            this.monsterCurHealthText.ReadOnly = true;
            this.monsterCurHealthText.Size = new System.Drawing.Size(39, 26);
            this.monsterCurHealthText.TabIndex = 19;
            // 
            // monsterHealthLabel
            // 
            this.monsterHealthLabel.AutoSize = true;
            this.monsterHealthLabel.Location = new System.Drawing.Point(12, 120);
            this.monsterHealthLabel.Name = "monsterHealthLabel";
            this.monsterHealthLabel.Size = new System.Drawing.Size(60, 20);
            this.monsterHealthLabel.TabIndex = 18;
            this.monsterHealthLabel.Text = "Health:";
            // 
            // meleeButton
            // 
            this.meleeButton.Location = new System.Drawing.Point(342, 479);
            this.meleeButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.meleeButton.Name = "meleeButton";
            this.meleeButton.Size = new System.Drawing.Size(123, 44);
            this.meleeButton.TabIndex = 4;
            this.meleeButton.Text = "Melee";
            this.meleeButton.UseVisualStyleBackColor = true;
            this.meleeButton.Click += new System.EventHandler(this.meleeButton_Click);
            // 
            // spellButton
            // 
            this.spellButton.Location = new System.Drawing.Point(529, 479);
            this.spellButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.spellButton.Name = "spellButton";
            this.spellButton.Size = new System.Drawing.Size(123, 44);
            this.spellButton.TabIndex = 5;
            this.spellButton.Text = "Spell";
            this.spellButton.UseVisualStyleBackColor = true;
            this.spellButton.Click += new System.EventHandler(this.spellButton_Click);
            // 
            // SimulatorGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 579);
            this.Controls.Add(this.spellButton);
            this.Controls.Add(this.meleeButton);
            this.Controls.Add(this.monsterGroup);
            this.Controls.Add(this.characterGroup);
            this.Controls.Add(this.monsterList);
            this.Controls.Add(this.characterList);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "SimulatorGUI";
            this.Text = "SimulatorGUI";
            this.characterGroup.ResumeLayout(false);
            this.characterGroup.PerformLayout();
            this.monsterGroup.ResumeLayout(false);
            this.monsterGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox characterList;
        private System.Windows.Forms.ListBox monsterList;
        private System.Windows.Forms.GroupBox characterGroup;
        private System.Windows.Forms.GroupBox monsterGroup;
        private System.Windows.Forms.Button meleeButton;
        private System.Windows.Forms.Button spellButton;
        private System.Windows.Forms.TextBox charCurHealthText;
        private System.Windows.Forms.Label charHealthLabel;
        private System.Windows.Forms.TextBox constitutionText;
        private System.Windows.Forms.Label constitutionLabel;
        private System.Windows.Forms.TextBox dexterityText;
        private System.Windows.Forms.Label dexterityLabel;
        private System.Windows.Forms.TextBox wisdomText;
        private System.Windows.Forms.TextBox intelligenceText;
        private System.Windows.Forms.Label wisdomLabel;
        private System.Windows.Forms.Label intelligenceLabel;
        private System.Windows.Forms.TextBox strengthText;
        private System.Windows.Forms.Label strengthLabel;
        private System.Windows.Forms.TextBox charMaxHealthText;
        private System.Windows.Forms.Label slash1Label;
        private System.Windows.Forms.TextBox professionText;
        private System.Windows.Forms.Label professionLabel;
        private System.Windows.Forms.TextBox monsterMaxHealthText;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label slash2Label;
        private System.Windows.Forms.Label typeLabel;
        private System.Windows.Forms.TextBox monsterCurHealthText;
        private System.Windows.Forms.Label monsterHealthLabel;
        private System.Windows.Forms.TextBox difficultyLevelText;
        private System.Windows.Forms.Label difficultyLevelLabel;
        private System.Windows.Forms.TextBox nameText;
        private System.Windows.Forms.TextBox typeText;
    }
}