namespace FurRealEngine
{
    partial class ConfigGUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfigGUI));
            this.listBoxMonsters = new System.Windows.Forms.ListBox();
            this.selectedMonstersGroupBox = new System.Windows.Forms.GroupBox();
            this.buttonRemoveAll = new System.Windows.Forms.Button();
            this.buttonRemoveMonster = new System.Windows.Forms.Button();
            this.labelStartLevel = new System.Windows.Forms.Label();
            this.labelMonsters = new System.Windows.Forms.Label();
            this.labelRepeatTimes = new System.Windows.Forms.Label();
            this.labelDifficulty = new System.Windows.Forms.Label();
            this.labelNumOfChars = new System.Windows.Forms.Label();
            this.labelMaxLevel = new System.Windows.Forms.Label();
            this.numericUpDownStartLevel = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownMaxLevel = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownRepeat = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownNumOfChars = new System.Windows.Forms.NumericUpDown();
            this.comboBoxDifficulty = new System.Windows.Forms.ComboBox();
            this.comboBoxMonsters = new System.Windows.Forms.ComboBox();
            this.buttonAddMonster = new System.Windows.Forms.Button();
            this.buttonRandomizeNumOfChars = new System.Windows.Forms.Button();
            this.buttonQuit = new System.Windows.Forms.Button();
            this.buttonConfirm = new System.Windows.Forms.Button();
            this.labelMonstersCD = new System.Windows.Forms.Label();
            this.numericUpDownMonsterCD = new System.Windows.Forms.NumericUpDown();
            this.buttonRadomizeCD = new System.Windows.Forms.Button();
            this.labelEnviornment = new System.Windows.Forms.Label();
            this.comboBoxEnvironment = new System.Windows.Forms.ComboBox();
            this.buttonRandomizeEnvironment = new System.Windows.Forms.Button();
            this.labelTitle = new System.Windows.Forms.Label();
            this.groupBoxCharacterSettings = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelNumCharMsg = new System.Windows.Forms.Label();
            this.groupBoxCharacters = new System.Windows.Forms.GroupBox();
            this.buttonSelectProfessionLevel = new System.Windows.Forms.Button();
            this.comboBoxProfessionLevel = new System.Windows.Forms.ComboBox();
            this.buttonSelectRevive = new System.Windows.Forms.Button();
            this.comboBoxReviveOpt = new System.Windows.Forms.ComboBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.buttonSelect = new System.Windows.Forms.Button();
            this.comboBoxProfessions = new System.Windows.Forms.ComboBox();
            this.listBoxCharacters = new System.Windows.Forms.ListBox();
            this.checkedListBoxChars = new System.Windows.Forms.CheckedListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.selectedMonstersGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStartLevel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxLevel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRepeat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumOfChars)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMonsterCD)).BeginInit();
            this.groupBoxCharacterSettings.SuspendLayout();
            this.groupBoxCharacters.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxMonsters
            // 
            this.listBoxMonsters.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.listBoxMonsters.BackColor = System.Drawing.SystemColors.ControlLight;
            this.listBoxMonsters.FormattingEnabled = true;
            this.listBoxMonsters.ItemHeight = 16;
            this.listBoxMonsters.Location = new System.Drawing.Point(59, 23);
            this.listBoxMonsters.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxMonsters.Name = "listBoxMonsters";
            this.listBoxMonsters.Size = new System.Drawing.Size(440, 84);
            this.listBoxMonsters.TabIndex = 0;
            // 
            // selectedMonstersGroupBox
            // 
            this.selectedMonstersGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.selectedMonstersGroupBox.BackColor = System.Drawing.Color.Transparent;
            this.selectedMonstersGroupBox.Controls.Add(this.buttonRemoveAll);
            this.selectedMonstersGroupBox.Controls.Add(this.buttonRemoveMonster);
            this.selectedMonstersGroupBox.Controls.Add(this.listBoxMonsters);
            this.selectedMonstersGroupBox.ForeColor = System.Drawing.Color.White;
            this.selectedMonstersGroupBox.Location = new System.Drawing.Point(729, 108);
            this.selectedMonstersGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.selectedMonstersGroupBox.Name = "selectedMonstersGroupBox";
            this.selectedMonstersGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.selectedMonstersGroupBox.Size = new System.Drawing.Size(557, 201);
            this.selectedMonstersGroupBox.TabIndex = 1;
            this.selectedMonstersGroupBox.TabStop = false;
            this.selectedMonstersGroupBox.Text = "Selected Monsters";
            // 
            // buttonRemoveAll
            // 
            this.buttonRemoveAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.buttonRemoveAll.ForeColor = System.Drawing.Color.Black;
            this.buttonRemoveAll.Location = new System.Drawing.Point(335, 144);
            this.buttonRemoveAll.Margin = new System.Windows.Forms.Padding(4);
            this.buttonRemoveAll.Name = "buttonRemoveAll";
            this.buttonRemoveAll.Size = new System.Drawing.Size(100, 31);
            this.buttonRemoveAll.TabIndex = 2;
            this.buttonRemoveAll.Text = "Remove All";
            this.buttonRemoveAll.UseVisualStyleBackColor = true;
            this.buttonRemoveAll.Click += new System.EventHandler(this.buttonRemoveAll_Click);
            // 
            // buttonRemoveMonster
            // 
            this.buttonRemoveMonster.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.buttonRemoveMonster.ForeColor = System.Drawing.Color.Black;
            this.buttonRemoveMonster.Location = new System.Drawing.Point(169, 144);
            this.buttonRemoveMonster.Margin = new System.Windows.Forms.Padding(4);
            this.buttonRemoveMonster.Name = "buttonRemoveMonster";
            this.buttonRemoveMonster.Size = new System.Drawing.Size(100, 31);
            this.buttonRemoveMonster.TabIndex = 1;
            this.buttonRemoveMonster.Text = "Remove";
            this.buttonRemoveMonster.UseVisualStyleBackColor = true;
            this.buttonRemoveMonster.Click += new System.EventHandler(this.buttonRemoveMonster_Click);
            // 
            // labelStartLevel
            // 
            this.labelStartLevel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.labelStartLevel.AutoSize = true;
            this.labelStartLevel.BackColor = System.Drawing.Color.Transparent;
            this.labelStartLevel.ForeColor = System.Drawing.Color.White;
            this.labelStartLevel.Location = new System.Drawing.Point(945, 359);
            this.labelStartLevel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelStartLevel.Name = "labelStartLevel";
            this.labelStartLevel.Size = new System.Drawing.Size(99, 17);
            this.labelStartLevel.TabIndex = 2;
            this.labelStartLevel.Text = "Starting Level:";
            // 
            // labelMonsters
            // 
            this.labelMonsters.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.labelMonsters.AutoSize = true;
            this.labelMonsters.BackColor = System.Drawing.Color.Transparent;
            this.labelMonsters.ForeColor = System.Drawing.Color.White;
            this.labelMonsters.Location = new System.Drawing.Point(727, 55);
            this.labelMonsters.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMonsters.Name = "labelMonsters";
            this.labelMonsters.Size = new System.Drawing.Size(125, 17);
            this.labelMonsters.TabIndex = 3;
            this.labelMonsters.Text = "Monster Selection:";
            // 
            // labelRepeatTimes
            // 
            this.labelRepeatTimes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.labelRepeatTimes.AutoSize = true;
            this.labelRepeatTimes.BackColor = System.Drawing.Color.Transparent;
            this.labelRepeatTimes.ForeColor = System.Drawing.Color.White;
            this.labelRepeatTimes.Location = new System.Drawing.Point(1123, 443);
            this.labelRepeatTimes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelRepeatTimes.Name = "labelRepeatTimes";
            this.labelRepeatTimes.Size = new System.Drawing.Size(118, 17);
            this.labelRepeatTimes.TabIndex = 4;
            this.labelRepeatTimes.Text = "Repeat Scenario:";
            // 
            // labelDifficulty
            // 
            this.labelDifficulty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.labelDifficulty.AutoSize = true;
            this.labelDifficulty.BackColor = System.Drawing.Color.Transparent;
            this.labelDifficulty.ForeColor = System.Drawing.Color.White;
            this.labelDifficulty.Location = new System.Drawing.Point(725, 358);
            this.labelDifficulty.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDifficulty.Name = "labelDifficulty";
            this.labelDifficulty.Size = new System.Drawing.Size(118, 17);
            this.labelDifficulty.TabIndex = 5;
            this.labelDifficulty.Text = "Starting Difficulty:";
            // 
            // labelNumOfChars
            // 
            this.labelNumOfChars.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.labelNumOfChars.AutoSize = true;
            this.labelNumOfChars.Location = new System.Drawing.Point(27, 71);
            this.labelNumOfChars.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNumOfChars.Name = "labelNumOfChars";
            this.labelNumOfChars.Size = new System.Drawing.Size(151, 17);
            this.labelNumOfChars.TabIndex = 6;
            this.labelNumOfChars.Text = "Number of Characters:";
            // 
            // labelMaxLevel
            // 
            this.labelMaxLevel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.labelMaxLevel.AutoSize = true;
            this.labelMaxLevel.BackColor = System.Drawing.Color.Transparent;
            this.labelMaxLevel.ForeColor = System.Drawing.Color.White;
            this.labelMaxLevel.Location = new System.Drawing.Point(1160, 361);
            this.labelMaxLevel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMaxLevel.Name = "labelMaxLevel";
            this.labelMaxLevel.Size = new System.Drawing.Size(108, 17);
            this.labelMaxLevel.TabIndex = 7;
            this.labelMaxLevel.Text = "Maximum Level:";
            // 
            // numericUpDownStartLevel
            // 
            this.numericUpDownStartLevel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.numericUpDownStartLevel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.numericUpDownStartLevel.Location = new System.Drawing.Point(949, 379);
            this.numericUpDownStartLevel.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpDownStartLevel.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownStartLevel.Name = "numericUpDownStartLevel";
            this.numericUpDownStartLevel.Size = new System.Drawing.Size(160, 22);
            this.numericUpDownStartLevel.TabIndex = 8;
            this.numericUpDownStartLevel.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownStartLevel.ValueChanged += new System.EventHandler(this.numericUpDownStartLevel_ValueChanged);
            // 
            // numericUpDownMaxLevel
            // 
            this.numericUpDownMaxLevel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.numericUpDownMaxLevel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.numericUpDownMaxLevel.Location = new System.Drawing.Point(1164, 379);
            this.numericUpDownMaxLevel.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpDownMaxLevel.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownMaxLevel.Name = "numericUpDownMaxLevel";
            this.numericUpDownMaxLevel.Size = new System.Drawing.Size(160, 22);
            this.numericUpDownMaxLevel.TabIndex = 9;
            this.numericUpDownMaxLevel.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownMaxLevel.ValueChanged += new System.EventHandler(this.numericUpDownMaxLevel_ValueChanged);
            // 
            // numericUpDownRepeat
            // 
            this.numericUpDownRepeat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.numericUpDownRepeat.BackColor = System.Drawing.SystemColors.ControlLight;
            this.numericUpDownRepeat.Location = new System.Drawing.Point(1127, 463);
            this.numericUpDownRepeat.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpDownRepeat.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownRepeat.Name = "numericUpDownRepeat";
            this.numericUpDownRepeat.Size = new System.Drawing.Size(160, 22);
            this.numericUpDownRepeat.TabIndex = 10;
            this.numericUpDownRepeat.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDownNumOfChars
            // 
            this.numericUpDownNumOfChars.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.numericUpDownNumOfChars.BackColor = System.Drawing.SystemColors.ControlLight;
            this.numericUpDownNumOfChars.Location = new System.Drawing.Point(31, 91);
            this.numericUpDownNumOfChars.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpDownNumOfChars.Maximum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.numericUpDownNumOfChars.Name = "numericUpDownNumOfChars";
            this.numericUpDownNumOfChars.Size = new System.Drawing.Size(160, 22);
            this.numericUpDownNumOfChars.TabIndex = 11;
            this.numericUpDownNumOfChars.ValueChanged += new System.EventHandler(this.numericUpDownNumOfChars_ValueChanged);
            // 
            // comboBoxDifficulty
            // 
            this.comboBoxDifficulty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.comboBoxDifficulty.BackColor = System.Drawing.SystemColors.ControlLight;
            this.comboBoxDifficulty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDifficulty.FormattingEnabled = true;
            this.comboBoxDifficulty.Items.AddRange(new object[] {
            "Novice",
            "Apprentice",
            "Master"});
            this.comboBoxDifficulty.Location = new System.Drawing.Point(729, 378);
            this.comboBoxDifficulty.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxDifficulty.Name = "comboBoxDifficulty";
            this.comboBoxDifficulty.Size = new System.Drawing.Size(160, 24);
            this.comboBoxDifficulty.TabIndex = 12;
            // 
            // comboBoxMonsters
            // 
            this.comboBoxMonsters.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.comboBoxMonsters.BackColor = System.Drawing.SystemColors.ControlLight;
            this.comboBoxMonsters.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMonsters.FormattingEnabled = true;
            this.comboBoxMonsters.Items.AddRange(new object[] {
            "Kobold",
            "Goblin",
            "Orc",
            "Bugbear",
            "Skeleton",
            "Zombie",
            "Ghost",
            "Vampire",
            "Lich"});
            this.comboBoxMonsters.Location = new System.Drawing.Point(729, 75);
            this.comboBoxMonsters.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxMonsters.Name = "comboBoxMonsters";
            this.comboBoxMonsters.Size = new System.Drawing.Size(160, 24);
            this.comboBoxMonsters.TabIndex = 13;
            // 
            // buttonAddMonster
            // 
            this.buttonAddMonster.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.buttonAddMonster.Location = new System.Drawing.Point(899, 75);
            this.buttonAddMonster.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAddMonster.Name = "buttonAddMonster";
            this.buttonAddMonster.Size = new System.Drawing.Size(100, 25);
            this.buttonAddMonster.TabIndex = 2;
            this.buttonAddMonster.Text = "Add";
            this.buttonAddMonster.UseVisualStyleBackColor = true;
            this.buttonAddMonster.Click += new System.EventHandler(this.buttonAddMonster_Click);
            // 
            // buttonRandomizeNumOfChars
            // 
            this.buttonRandomizeNumOfChars.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.buttonRandomizeNumOfChars.ForeColor = System.Drawing.Color.Black;
            this.buttonRandomizeNumOfChars.Location = new System.Drawing.Point(199, 88);
            this.buttonRandomizeNumOfChars.Margin = new System.Windows.Forms.Padding(4);
            this.buttonRandomizeNumOfChars.Name = "buttonRandomizeNumOfChars";
            this.buttonRandomizeNumOfChars.Size = new System.Drawing.Size(100, 25);
            this.buttonRandomizeNumOfChars.TabIndex = 15;
            this.buttonRandomizeNumOfChars.Text = "Randomize";
            this.buttonRandomizeNumOfChars.UseVisualStyleBackColor = true;
            this.buttonRandomizeNumOfChars.Click += new System.EventHandler(this.buttonRandomizeNumOfChars_Click);
            // 
            // buttonQuit
            // 
            this.buttonQuit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.buttonQuit.Location = new System.Drawing.Point(1009, 540);
            this.buttonQuit.Margin = new System.Windows.Forms.Padding(4);
            this.buttonQuit.Name = "buttonQuit";
            this.buttonQuit.Size = new System.Drawing.Size(100, 30);
            this.buttonQuit.TabIndex = 17;
            this.buttonQuit.Text = "Quit";
            this.buttonQuit.UseVisualStyleBackColor = true;
            this.buttonQuit.Click += new System.EventHandler(this.buttonQuit_Click);
            // 
            // buttonConfirm
            // 
            this.buttonConfirm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.buttonConfirm.Location = new System.Drawing.Point(1187, 540);
            this.buttonConfirm.Margin = new System.Windows.Forms.Padding(4);
            this.buttonConfirm.Name = "buttonConfirm";
            this.buttonConfirm.Size = new System.Drawing.Size(100, 30);
            this.buttonConfirm.TabIndex = 18;
            this.buttonConfirm.Text = "Confirm";
            this.buttonConfirm.UseVisualStyleBackColor = true;
            this.buttonConfirm.Click += new System.EventHandler(this.buttonConfirm_Click);
            // 
            // labelMonstersCD
            // 
            this.labelMonstersCD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.labelMonstersCD.AutoSize = true;
            this.labelMonstersCD.BackColor = System.Drawing.Color.Transparent;
            this.labelMonstersCD.ForeColor = System.Drawing.Color.White;
            this.labelMonstersCD.Location = new System.Drawing.Point(1015, 55);
            this.labelMonstersCD.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMonstersCD.Name = "labelMonstersCD";
            this.labelMonstersCD.Size = new System.Drawing.Size(149, 17);
            this.labelMonstersCD.TabIndex = 19;
            this.labelMonstersCD.Text = "Monsters\' Starting CD:";
            // 
            // numericUpDownMonsterCD
            // 
            this.numericUpDownMonsterCD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.numericUpDownMonsterCD.BackColor = System.Drawing.SystemColors.ControlLight;
            this.numericUpDownMonsterCD.Location = new System.Drawing.Point(1019, 77);
            this.numericUpDownMonsterCD.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpDownMonsterCD.Name = "numericUpDownMonsterCD";
            this.numericUpDownMonsterCD.Size = new System.Drawing.Size(160, 22);
            this.numericUpDownMonsterCD.TabIndex = 20;
            // 
            // buttonRadomizeCD
            // 
            this.buttonRadomizeCD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.buttonRadomizeCD.Location = new System.Drawing.Point(1187, 73);
            this.buttonRadomizeCD.Margin = new System.Windows.Forms.Padding(4);
            this.buttonRadomizeCD.Name = "buttonRadomizeCD";
            this.buttonRadomizeCD.Size = new System.Drawing.Size(100, 26);
            this.buttonRadomizeCD.TabIndex = 21;
            this.buttonRadomizeCD.Text = "Randomize";
            this.buttonRadomizeCD.UseVisualStyleBackColor = true;
            this.buttonRadomizeCD.Click += new System.EventHandler(this.buttonRadomizeCD_Click);
            // 
            // labelEnviornment
            // 
            this.labelEnviornment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.labelEnviornment.AutoSize = true;
            this.labelEnviornment.BackColor = System.Drawing.Color.Transparent;
            this.labelEnviornment.ForeColor = System.Drawing.Color.White;
            this.labelEnviornment.Location = new System.Drawing.Point(725, 443);
            this.labelEnviornment.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelEnviornment.Name = "labelEnviornment";
            this.labelEnviornment.Size = new System.Drawing.Size(127, 17);
            this.labelEnviornment.TabIndex = 22;
            this.labelEnviornment.Text = "Battle Environment";
            // 
            // comboBoxEnvironment
            // 
            this.comboBoxEnvironment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.comboBoxEnvironment.BackColor = System.Drawing.SystemColors.ControlLight;
            this.comboBoxEnvironment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEnvironment.FormattingEnabled = true;
            this.comboBoxEnvironment.Items.AddRange(new object[] {
            "Dungeon",
            "Cavern",
            "Forest"});
            this.comboBoxEnvironment.Location = new System.Drawing.Point(729, 463);
            this.comboBoxEnvironment.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxEnvironment.Name = "comboBoxEnvironment";
            this.comboBoxEnvironment.Size = new System.Drawing.Size(160, 24);
            this.comboBoxEnvironment.TabIndex = 23;
            // 
            // buttonRandomizeEnvironment
            // 
            this.buttonRandomizeEnvironment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.buttonRandomizeEnvironment.Location = new System.Drawing.Point(899, 463);
            this.buttonRandomizeEnvironment.Margin = new System.Windows.Forms.Padding(4);
            this.buttonRandomizeEnvironment.Name = "buttonRandomizeEnvironment";
            this.buttonRandomizeEnvironment.Size = new System.Drawing.Size(100, 25);
            this.buttonRandomizeEnvironment.TabIndex = 24;
            this.buttonRandomizeEnvironment.Text = "Randomize";
            this.buttonRandomizeEnvironment.UseVisualStyleBackColor = true;
            this.buttonRandomizeEnvironment.Click += new System.EventHandler(this.buttonRandomizeEnvironment_Click);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.BackColor = System.Drawing.Color.Transparent;
            this.labelTitle.Font = new System.Drawing.Font("Matura MT Script Capitals", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.White;
            this.labelTitle.Location = new System.Drawing.Point(16, 22);
            this.labelTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(430, 42);
            this.labelTitle.TabIndex = 25;
            this.labelTitle.Text = "Configure Combat Simulator";
            // 
            // groupBoxCharacterSettings
            // 
            this.groupBoxCharacterSettings.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxCharacterSettings.Controls.Add(this.label1);
            this.groupBoxCharacterSettings.Controls.Add(this.labelNumCharMsg);
            this.groupBoxCharacterSettings.Controls.Add(this.groupBoxCharacters);
            this.groupBoxCharacterSettings.Controls.Add(this.checkedListBoxChars);
            this.groupBoxCharacterSettings.Controls.Add(this.labelNumOfChars);
            this.groupBoxCharacterSettings.Controls.Add(this.numericUpDownNumOfChars);
            this.groupBoxCharacterSettings.Controls.Add(this.buttonRandomizeNumOfChars);
            this.groupBoxCharacterSettings.ForeColor = System.Drawing.Color.White;
            this.groupBoxCharacterSettings.Location = new System.Drawing.Point(39, 80);
            this.groupBoxCharacterSettings.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxCharacterSettings.Name = "groupBoxCharacterSettings";
            this.groupBoxCharacterSettings.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxCharacterSettings.Size = new System.Drawing.Size(615, 490);
            this.groupBoxCharacterSettings.TabIndex = 26;
            this.groupBoxCharacterSettings.TabStop = false;
            this.groupBoxCharacterSettings.Text = "Character Settings";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(315, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 17);
            this.label1.TabIndex = 21;
            this.label1.Text = "Check a Character to Identify as Playable";
            // 
            // labelNumCharMsg
            // 
            this.labelNumCharMsg.AutoSize = true;
            this.labelNumCharMsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumCharMsg.ForeColor = System.Drawing.Color.White;
            this.labelNumCharMsg.Location = new System.Drawing.Point(27, 41);
            this.labelNumCharMsg.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNumCharMsg.Name = "labelNumCharMsg";
            this.labelNumCharMsg.Size = new System.Drawing.Size(134, 17);
            this.labelNumCharMsg.TabIndex = 20;
            this.labelNumCharMsg.Text = "Max of 6 Characters";
            // 
            // groupBoxCharacters
            // 
            this.groupBoxCharacters.Controls.Add(this.buttonSelectProfessionLevel);
            this.groupBoxCharacters.Controls.Add(this.comboBoxProfessionLevel);
            this.groupBoxCharacters.Controls.Add(this.buttonSelectRevive);
            this.groupBoxCharacters.Controls.Add(this.comboBoxReviveOpt);
            this.groupBoxCharacters.Controls.Add(this.richTextBox1);
            this.groupBoxCharacters.Controls.Add(this.buttonSelect);
            this.groupBoxCharacters.Controls.Add(this.comboBoxProfessions);
            this.groupBoxCharacters.Controls.Add(this.listBoxCharacters);
            this.groupBoxCharacters.ForeColor = System.Drawing.Color.White;
            this.groupBoxCharacters.Location = new System.Drawing.Point(27, 172);
            this.groupBoxCharacters.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxCharacters.Name = "groupBoxCharacters";
            this.groupBoxCharacters.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxCharacters.Size = new System.Drawing.Size(532, 310);
            this.groupBoxCharacters.TabIndex = 18;
            this.groupBoxCharacters.TabStop = false;
            this.groupBoxCharacters.Text = "Character Profession Selection";
            // 
            // buttonSelectProfessionLevel
            // 
            this.buttonSelectProfessionLevel.ForeColor = System.Drawing.Color.Black;
            this.buttonSelectProfessionLevel.Location = new System.Drawing.Point(197, 211);
            this.buttonSelectProfessionLevel.Name = "buttonSelectProfessionLevel";
            this.buttonSelectProfessionLevel.Size = new System.Drawing.Size(98, 30);
            this.buttonSelectProfessionLevel.TabIndex = 24;
            this.buttonSelectProfessionLevel.Text = "Select";
            this.buttonSelectProfessionLevel.UseVisualStyleBackColor = true;
            this.buttonSelectProfessionLevel.Click += new System.EventHandler(this.buttonSelectProfessionLevel_Click);
            // 
            // comboBoxProfessionLevel
            // 
            this.comboBoxProfessionLevel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.comboBoxProfessionLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxProfessionLevel.FormattingEnabled = true;
            this.comboBoxProfessionLevel.Items.AddRange(new object[] {
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15"});
            this.comboBoxProfessionLevel.Location = new System.Drawing.Point(8, 212);
            this.comboBoxProfessionLevel.Name = "comboBoxProfessionLevel";
            this.comboBoxProfessionLevel.Size = new System.Drawing.Size(160, 24);
            this.comboBoxProfessionLevel.TabIndex = 23;
            // 
            // buttonSelectRevive
            // 
            this.buttonSelectRevive.ForeColor = System.Drawing.Color.Black;
            this.buttonSelectRevive.Location = new System.Drawing.Point(197, 258);
            this.buttonSelectRevive.Name = "buttonSelectRevive";
            this.buttonSelectRevive.Size = new System.Drawing.Size(98, 29);
            this.buttonSelectRevive.TabIndex = 22;
            this.buttonSelectRevive.Text = "Select";
            this.buttonSelectRevive.UseVisualStyleBackColor = true;
            this.buttonSelectRevive.Click += new System.EventHandler(this.buttonSelectRevive_Click);
            // 
            // comboBoxReviveOpt
            // 
            this.comboBoxReviveOpt.BackColor = System.Drawing.SystemColors.ControlLight;
            this.comboBoxReviveOpt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxReviveOpt.FormattingEnabled = true;
            this.comboBoxReviveOpt.Items.AddRange(new object[] {
            "Never Revive",
            "Upon Death",
            "Each Level"});
            this.comboBoxReviveOpt.Location = new System.Drawing.Point(8, 261);
            this.comboBoxReviveOpt.Name = "comboBoxReviveOpt";
            this.comboBoxReviveOpt.Size = new System.Drawing.Size(160, 24);
            this.comboBoxReviveOpt.TabIndex = 21;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.richTextBox1.ForeColor = System.Drawing.Color.Black;
            this.richTextBox1.Location = new System.Drawing.Point(305, 38);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(219, 264);
            this.richTextBox1.TabIndex = 20;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // buttonSelect
            // 
            this.buttonSelect.ForeColor = System.Drawing.Color.Black;
            this.buttonSelect.Location = new System.Drawing.Point(197, 162);
            this.buttonSelect.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSelect.Name = "buttonSelect";
            this.buttonSelect.Size = new System.Drawing.Size(98, 28);
            this.buttonSelect.TabIndex = 19;
            this.buttonSelect.Text = "Select";
            this.buttonSelect.UseVisualStyleBackColor = true;
            this.buttonSelect.Click += new System.EventHandler(this.buttonSelect_Click);
            // 
            // comboBoxProfessions
            // 
            this.comboBoxProfessions.BackColor = System.Drawing.SystemColors.ControlLight;
            this.comboBoxProfessions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxProfessions.FormattingEnabled = true;
            this.comboBoxProfessions.Items.AddRange(new object[] {
            "Combat Mage",
            "Soldier",
            "Priest"});
            this.comboBoxProfessions.Location = new System.Drawing.Point(8, 162);
            this.comboBoxProfessions.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxProfessions.Name = "comboBoxProfessions";
            this.comboBoxProfessions.Size = new System.Drawing.Size(160, 24);
            this.comboBoxProfessions.TabIndex = 18;
            // 
            // listBoxCharacters
            // 
            this.listBoxCharacters.BackColor = System.Drawing.SystemColors.ControlLight;
            this.listBoxCharacters.FormattingEnabled = true;
            this.listBoxCharacters.ItemHeight = 16;
            this.listBoxCharacters.Location = new System.Drawing.Point(8, 38);
            this.listBoxCharacters.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxCharacters.Name = "listBoxCharacters";
            this.listBoxCharacters.Size = new System.Drawing.Size(287, 100);
            this.listBoxCharacters.TabIndex = 17;
            this.listBoxCharacters.SelectedIndexChanged += new System.EventHandler(this.listBoxCharacters_SelectedIndexChanged);
            // 
            // checkedListBoxChars
            // 
            this.checkedListBoxChars.BackColor = System.Drawing.SystemColors.ControlLight;
            this.checkedListBoxChars.Cursor = System.Windows.Forms.Cursors.Default;
            this.checkedListBoxChars.ForeColor = System.Drawing.SystemColors.WindowText;
            this.checkedListBoxChars.FormattingEnabled = true;
            this.checkedListBoxChars.Location = new System.Drawing.Point(332, 35);
            this.checkedListBoxChars.Margin = new System.Windows.Forms.Padding(4);
            this.checkedListBoxChars.Name = "checkedListBoxChars";
            this.checkedListBoxChars.Size = new System.Drawing.Size(227, 123);
            this.checkedListBoxChars.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(756, 22);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(407, 17);
            this.label2.TabIndex = 27;
            this.label2.Text = "Optionally Add Specific Monster and Set Their Combat Difficulty";
            // 
            // ConfigGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::FurRealEngine.Properties.Resources.settingsBackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1340, 602);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBoxCharacterSettings);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.buttonRandomizeEnvironment);
            this.Controls.Add(this.comboBoxEnvironment);
            this.Controls.Add(this.labelEnviornment);
            this.Controls.Add(this.buttonRadomizeCD);
            this.Controls.Add(this.numericUpDownMonsterCD);
            this.Controls.Add(this.labelMonstersCD);
            this.Controls.Add(this.buttonConfirm);
            this.Controls.Add(this.buttonQuit);
            this.Controls.Add(this.buttonAddMonster);
            this.Controls.Add(this.comboBoxMonsters);
            this.Controls.Add(this.comboBoxDifficulty);
            this.Controls.Add(this.numericUpDownRepeat);
            this.Controls.Add(this.numericUpDownMaxLevel);
            this.Controls.Add(this.numericUpDownStartLevel);
            this.Controls.Add(this.labelMaxLevel);
            this.Controls.Add(this.labelDifficulty);
            this.Controls.Add(this.labelRepeatTimes);
            this.Controls.Add(this.labelMonsters);
            this.Controls.Add(this.labelStartLevel);
            this.Controls.Add(this.selectedMonstersGroupBox);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "ConfigGUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FurReal Engine (Simulation Settings)";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ConfigGUI_FormClosed);
            this.selectedMonstersGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStartLevel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxLevel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRepeat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumOfChars)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMonsterCD)).EndInit();
            this.groupBoxCharacterSettings.ResumeLayout(false);
            this.groupBoxCharacterSettings.PerformLayout();
            this.groupBoxCharacters.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxMonsters;
        private System.Windows.Forms.GroupBox selectedMonstersGroupBox;
        private System.Windows.Forms.Button buttonRemoveMonster;
        private System.Windows.Forms.Label labelStartLevel;
        private System.Windows.Forms.Label labelMonsters;
        private System.Windows.Forms.Label labelRepeatTimes;
        private System.Windows.Forms.Label labelDifficulty;
        private System.Windows.Forms.Label labelNumOfChars;
        private System.Windows.Forms.Label labelMaxLevel;
        private System.Windows.Forms.NumericUpDown numericUpDownStartLevel;
        private System.Windows.Forms.NumericUpDown numericUpDownMaxLevel;
        private System.Windows.Forms.NumericUpDown numericUpDownRepeat;
        private System.Windows.Forms.NumericUpDown numericUpDownNumOfChars;
        private System.Windows.Forms.ComboBox comboBoxDifficulty;
        private System.Windows.Forms.ComboBox comboBoxMonsters;
        private System.Windows.Forms.Button buttonAddMonster;
        private System.Windows.Forms.Button buttonRandomizeNumOfChars;
        private System.Windows.Forms.Button buttonQuit;
        private System.Windows.Forms.Button buttonConfirm;
        private System.Windows.Forms.Label labelMonstersCD;
        private System.Windows.Forms.NumericUpDown numericUpDownMonsterCD;
        private System.Windows.Forms.Button buttonRadomizeCD;
        private System.Windows.Forms.Label labelEnviornment;
        private System.Windows.Forms.ComboBox comboBoxEnvironment;
        private System.Windows.Forms.Button buttonRandomizeEnvironment;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.GroupBox groupBoxCharacters;
        private System.Windows.Forms.ListBox listBoxCharacters;
        private System.Windows.Forms.CheckedListBox checkedListBoxChars;
        private System.Windows.Forms.GroupBox groupBoxCharacterSettings;
        private System.Windows.Forms.Button buttonSelect;
        private System.Windows.Forms.ComboBox comboBoxProfessions;
        private System.Windows.Forms.Button buttonRemoveAll;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelNumCharMsg;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonSelectProfessionLevel;
        private System.Windows.Forms.ComboBox comboBoxProfessionLevel;
        private System.Windows.Forms.Button buttonSelectRevive;
        private System.Windows.Forms.ComboBox comboBoxReviveOpt;
    }
}

