﻿namespace FurRealEngine
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
            this.playableText = new System.Windows.Forms.TextBox();
            this.playableLabel = new System.Windows.Forms.Label();
            this.levelLabel = new System.Windows.Forms.Label();
            this.levelText = new System.Windows.Forms.TextBox();
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
            this.characterPicture = new System.Windows.Forms.PictureBox();
            this.monsterPicture = new System.Windows.Forms.PictureBox();
            this.characterGroup.SuspendLayout();
            this.monsterGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.characterPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.monsterPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // characterList
            // 
            this.characterList.FormattingEnabled = true;
            this.characterList.ItemHeight = 16;
            this.characterList.Location = new System.Drawing.Point(57, 73);
            this.characterList.Name = "characterList";
            this.characterList.Size = new System.Drawing.Size(120, 196);
            this.characterList.TabIndex = 0;
            this.characterList.SelectedIndexChanged += new System.EventHandler(this.characterList_SelectedIndexChanged);
            // 
            // monsterList
            // 
            this.monsterList.FormattingEnabled = true;
            this.monsterList.ItemHeight = 16;
            this.monsterList.Location = new System.Drawing.Point(1257, 73);
            this.monsterList.Name = "monsterList";
            this.monsterList.Size = new System.Drawing.Size(120, 196);
            this.monsterList.TabIndex = 1;
            this.monsterList.SelectedIndexChanged += new System.EventHandler(this.monsterList_SelectedIndexChanged);
            // 
            // characterGroup
            // 
            this.characterGroup.Controls.Add(this.playableText);
            this.characterGroup.Controls.Add(this.playableLabel);
            this.characterGroup.Controls.Add(this.levelLabel);
            this.characterGroup.Controls.Add(this.levelText);
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
            this.characterGroup.Location = new System.Drawing.Point(216, 73);
            this.characterGroup.Name = "characterGroup";
            this.characterGroup.Size = new System.Drawing.Size(234, 351);
            this.characterGroup.TabIndex = 2;
            this.characterGroup.TabStop = false;
            this.characterGroup.Text = "Character Stats";
            // 
            // playableText
            // 
            this.playableText.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.playableText.Location = new System.Drawing.Point(109, 315);
            this.playableText.Name = "playableText";
            this.playableText.ReadOnly = true;
            this.playableText.Size = new System.Drawing.Size(99, 22);
            this.playableText.TabIndex = 21;
            // 
            // playableLabel
            // 
            this.playableLabel.AutoSize = true;
            this.playableLabel.Location = new System.Drawing.Point(16, 315);
            this.playableLabel.Name = "playableLabel";
            this.playableLabel.Size = new System.Drawing.Size(66, 17);
            this.playableLabel.TabIndex = 20;
            this.playableLabel.Text = "Playable:";
            // 
            // levelLabel
            // 
            this.levelLabel.AutoSize = true;
            this.levelLabel.Location = new System.Drawing.Point(16, 61);
            this.levelLabel.Name = "levelLabel";
            this.levelLabel.Size = new System.Drawing.Size(46, 17);
            this.levelLabel.TabIndex = 19;
            this.levelLabel.Text = "Level:";
            // 
            // levelText
            // 
            this.levelText.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.levelText.Location = new System.Drawing.Point(109, 58);
            this.levelText.Name = "levelText";
            this.levelText.ReadOnly = true;
            this.levelText.Size = new System.Drawing.Size(99, 22);
            this.levelText.TabIndex = 18;
            // 
            // professionText
            // 
            this.professionText.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.professionText.Location = new System.Drawing.Point(109, 28);
            this.professionText.Name = "professionText";
            this.professionText.ReadOnly = true;
            this.professionText.Size = new System.Drawing.Size(99, 22);
            this.professionText.TabIndex = 17;
            // 
            // professionLabel
            // 
            this.professionLabel.AutoSize = true;
            this.professionLabel.Location = new System.Drawing.Point(16, 28);
            this.professionLabel.Name = "professionLabel";
            this.professionLabel.Size = new System.Drawing.Size(79, 17);
            this.professionLabel.TabIndex = 16;
            this.professionLabel.Text = "Profession:";
            // 
            // charMaxHealthText
            // 
            this.charMaxHealthText.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.charMaxHealthText.Location = new System.Drawing.Point(170, 92);
            this.charMaxHealthText.Name = "charMaxHealthText";
            this.charMaxHealthText.ReadOnly = true;
            this.charMaxHealthText.Size = new System.Drawing.Size(38, 22);
            this.charMaxHealthText.TabIndex = 15;
            // 
            // slash1Label
            // 
            this.slash1Label.AutoSize = true;
            this.slash1Label.Location = new System.Drawing.Point(152, 95);
            this.slash1Label.Name = "slash1Label";
            this.slash1Label.Size = new System.Drawing.Size(12, 17);
            this.slash1Label.TabIndex = 14;
            this.slash1Label.Text = "/";
            // 
            // charCurHealthText
            // 
            this.charCurHealthText.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.charCurHealthText.Location = new System.Drawing.Point(109, 92);
            this.charCurHealthText.Name = "charCurHealthText";
            this.charCurHealthText.ReadOnly = true;
            this.charCurHealthText.Size = new System.Drawing.Size(37, 22);
            this.charCurHealthText.TabIndex = 13;
            // 
            // charHealthLabel
            // 
            this.charHealthLabel.AutoSize = true;
            this.charHealthLabel.Location = new System.Drawing.Point(16, 92);
            this.charHealthLabel.Name = "charHealthLabel";
            this.charHealthLabel.Size = new System.Drawing.Size(53, 17);
            this.charHealthLabel.TabIndex = 12;
            this.charHealthLabel.Text = "Health:";
            // 
            // constitutionText
            // 
            this.constitutionText.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.constitutionText.Location = new System.Drawing.Point(109, 280);
            this.constitutionText.Name = "constitutionText";
            this.constitutionText.ReadOnly = true;
            this.constitutionText.Size = new System.Drawing.Size(99, 22);
            this.constitutionText.TabIndex = 11;
            // 
            // constitutionLabel
            // 
            this.constitutionLabel.AutoSize = true;
            this.constitutionLabel.Location = new System.Drawing.Point(16, 280);
            this.constitutionLabel.Name = "constitutionLabel";
            this.constitutionLabel.Size = new System.Drawing.Size(86, 17);
            this.constitutionLabel.TabIndex = 10;
            this.constitutionLabel.Text = "Constitution:";
            // 
            // dexterityText
            // 
            this.dexterityText.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.dexterityText.Location = new System.Drawing.Point(109, 242);
            this.dexterityText.Name = "dexterityText";
            this.dexterityText.ReadOnly = true;
            this.dexterityText.Size = new System.Drawing.Size(99, 22);
            this.dexterityText.TabIndex = 9;
            // 
            // dexterityLabel
            // 
            this.dexterityLabel.AutoSize = true;
            this.dexterityLabel.Location = new System.Drawing.Point(16, 242);
            this.dexterityLabel.Name = "dexterityLabel";
            this.dexterityLabel.Size = new System.Drawing.Size(71, 17);
            this.dexterityLabel.TabIndex = 8;
            this.dexterityLabel.Text = "Dexterity: ";
            // 
            // wisdomText
            // 
            this.wisdomText.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.wisdomText.Location = new System.Drawing.Point(109, 204);
            this.wisdomText.Name = "wisdomText";
            this.wisdomText.ReadOnly = true;
            this.wisdomText.Size = new System.Drawing.Size(99, 22);
            this.wisdomText.TabIndex = 7;
            // 
            // intelligenceText
            // 
            this.intelligenceText.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.intelligenceText.Location = new System.Drawing.Point(109, 166);
            this.intelligenceText.Name = "intelligenceText";
            this.intelligenceText.ReadOnly = true;
            this.intelligenceText.Size = new System.Drawing.Size(99, 22);
            this.intelligenceText.TabIndex = 3;
            // 
            // wisdomLabel
            // 
            this.wisdomLabel.AutoSize = true;
            this.wisdomLabel.Location = new System.Drawing.Point(16, 204);
            this.wisdomLabel.Name = "wisdomLabel";
            this.wisdomLabel.Size = new System.Drawing.Size(62, 17);
            this.wisdomLabel.TabIndex = 6;
            this.wisdomLabel.Text = "Wisdom:";
            // 
            // intelligenceLabel
            // 
            this.intelligenceLabel.AutoSize = true;
            this.intelligenceLabel.Location = new System.Drawing.Point(16, 166);
            this.intelligenceLabel.Name = "intelligenceLabel";
            this.intelligenceLabel.Size = new System.Drawing.Size(87, 17);
            this.intelligenceLabel.TabIndex = 2;
            this.intelligenceLabel.Text = "Intelligence: ";
            // 
            // strengthText
            // 
            this.strengthText.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.strengthText.Location = new System.Drawing.Point(109, 128);
            this.strengthText.Name = "strengthText";
            this.strengthText.ReadOnly = true;
            this.strengthText.Size = new System.Drawing.Size(99, 22);
            this.strengthText.TabIndex = 1;
            // 
            // strengthLabel
            // 
            this.strengthLabel.AutoSize = true;
            this.strengthLabel.Location = new System.Drawing.Point(16, 128);
            this.strengthLabel.Name = "strengthLabel";
            this.strengthLabel.Size = new System.Drawing.Size(70, 17);
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
            this.monsterGroup.Location = new System.Drawing.Point(964, 73);
            this.monsterGroup.Name = "monsterGroup";
            this.monsterGroup.Size = new System.Drawing.Size(255, 196);
            this.monsterGroup.TabIndex = 3;
            this.monsterGroup.TabStop = false;
            this.monsterGroup.Text = "Monster Stats";
            // 
            // nameText
            // 
            this.nameText.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.nameText.Location = new System.Drawing.Point(128, 66);
            this.nameText.Name = "nameText";
            this.nameText.ReadOnly = true;
            this.nameText.Size = new System.Drawing.Size(97, 22);
            this.nameText.TabIndex = 25;
            // 
            // typeText
            // 
            this.typeText.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.typeText.Location = new System.Drawing.Point(128, 32);
            this.typeText.Name = "typeText";
            this.typeText.ReadOnly = true;
            this.typeText.Size = new System.Drawing.Size(97, 22);
            this.typeText.TabIndex = 24;
            // 
            // difficultyLevelText
            // 
            this.difficultyLevelText.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.difficultyLevelText.Location = new System.Drawing.Point(128, 102);
            this.difficultyLevelText.Name = "difficultyLevelText";
            this.difficultyLevelText.ReadOnly = true;
            this.difficultyLevelText.Size = new System.Drawing.Size(97, 22);
            this.difficultyLevelText.TabIndex = 23;
            // 
            // difficultyLevelLabel
            // 
            this.difficultyLevelLabel.AutoSize = true;
            this.difficultyLevelLabel.Location = new System.Drawing.Point(10, 105);
            this.difficultyLevelLabel.Name = "difficultyLevelLabel";
            this.difficultyLevelLabel.Size = new System.Drawing.Size(103, 17);
            this.difficultyLevelLabel.TabIndex = 22;
            this.difficultyLevelLabel.Text = "Difficulty Level:";
            // 
            // monsterMaxHealthText
            // 
            this.monsterMaxHealthText.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.monsterMaxHealthText.Location = new System.Drawing.Point(185, 140);
            this.monsterMaxHealthText.Name = "monsterMaxHealthText";
            this.monsterMaxHealthText.ReadOnly = true;
            this.monsterMaxHealthText.Size = new System.Drawing.Size(40, 22);
            this.monsterMaxHealthText.TabIndex = 21;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(11, 66);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(49, 17);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "Name:";
            // 
            // slash2Label
            // 
            this.slash2Label.AutoSize = true;
            this.slash2Label.Location = new System.Drawing.Point(169, 142);
            this.slash2Label.Name = "slash2Label";
            this.slash2Label.Size = new System.Drawing.Size(12, 17);
            this.slash2Label.TabIndex = 20;
            this.slash2Label.Text = "/";
            // 
            // typeLabel
            // 
            this.typeLabel.AutoSize = true;
            this.typeLabel.Location = new System.Drawing.Point(11, 33);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(44, 17);
            this.typeLabel.TabIndex = 0;
            this.typeLabel.Text = "Type:";
            // 
            // monsterCurHealthText
            // 
            this.monsterCurHealthText.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.monsterCurHealthText.Location = new System.Drawing.Point(128, 140);
            this.monsterCurHealthText.Name = "monsterCurHealthText";
            this.monsterCurHealthText.ReadOnly = true;
            this.monsterCurHealthText.Size = new System.Drawing.Size(35, 22);
            this.monsterCurHealthText.TabIndex = 19;
            // 
            // monsterHealthLabel
            // 
            this.monsterHealthLabel.AutoSize = true;
            this.monsterHealthLabel.Location = new System.Drawing.Point(11, 144);
            this.monsterHealthLabel.Name = "monsterHealthLabel";
            this.monsterHealthLabel.Size = new System.Drawing.Size(53, 17);
            this.monsterHealthLabel.TabIndex = 18;
            this.monsterHealthLabel.Text = "Health:";
            // 
            // meleeButton
            // 
            this.meleeButton.Location = new System.Drawing.Point(57, 302);
            this.meleeButton.Name = "meleeButton";
            this.meleeButton.Size = new System.Drawing.Size(120, 35);
            this.meleeButton.TabIndex = 4;
            this.meleeButton.Text = "Melee";
            this.meleeButton.UseVisualStyleBackColor = true;
            this.meleeButton.Click += new System.EventHandler(this.meleeButton_Click);
            // 
            // spellButton
            // 
            this.spellButton.Location = new System.Drawing.Point(57, 364);
            this.spellButton.Name = "spellButton";
            this.spellButton.Size = new System.Drawing.Size(120, 35);
            this.spellButton.TabIndex = 5;
            this.spellButton.Text = "Spell";
            this.spellButton.UseVisualStyleBackColor = true;
            this.spellButton.Click += new System.EventHandler(this.spellButton_Click);
            // 
            // characterPicture
            // 
            this.characterPicture.BackColor = System.Drawing.Color.Transparent;
            this.characterPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.characterPicture.Location = new System.Drawing.Point(468, 277);
            this.characterPicture.Name = "characterPicture";
            this.characterPicture.Size = new System.Drawing.Size(397, 374);
            this.characterPicture.TabIndex = 6;
            this.characterPicture.TabStop = false;
            // 
            // monsterPicture
            // 
            this.monsterPicture.BackColor = System.Drawing.Color.Transparent;
            this.monsterPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.monsterPicture.Location = new System.Drawing.Point(890, 277);
            this.monsterPicture.Name = "monsterPicture";
            this.monsterPicture.Size = new System.Drawing.Size(374, 374);
            this.monsterPicture.TabIndex = 7;
            this.monsterPicture.TabStop = false;
            // 
            // SimulatorGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1434, 663);
            this.Controls.Add(this.monsterPicture);
            this.Controls.Add(this.characterPicture);
            this.Controls.Add(this.spellButton);
            this.Controls.Add(this.meleeButton);
            this.Controls.Add(this.monsterGroup);
            this.Controls.Add(this.characterGroup);
            this.Controls.Add(this.monsterList);
            this.Controls.Add(this.characterList);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "SimulatorGUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SimulatorGUI";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SimulatorGUI_FormClosed);
            this.characterGroup.ResumeLayout(false);
            this.characterGroup.PerformLayout();
            this.monsterGroup.ResumeLayout(false);
            this.monsterGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.characterPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.monsterPicture)).EndInit();
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
        private System.Windows.Forms.Label levelLabel;
        private System.Windows.Forms.TextBox levelText;
        private System.Windows.Forms.TextBox playableText;
        private System.Windows.Forms.Label playableLabel;
        private System.Windows.Forms.PictureBox characterPicture;
        private System.Windows.Forms.PictureBox monsterPicture;
    }
}