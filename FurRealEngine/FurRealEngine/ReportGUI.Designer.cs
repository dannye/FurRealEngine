namespace FurRealEngine
{
    partial class ReportGUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportGUI));
            this.groupBoxReportSelectin = new System.Windows.Forms.GroupBox();
            this.buttonSelectReport = new System.Windows.Forms.Button();
            this.listBoxReports = new System.Windows.Forms.ListBox();
            this.groupBoxReport = new System.Windows.Forms.GroupBox();
            this.textBoxTreasure = new System.Windows.Forms.TextBox();
            this.labelTreasure = new System.Windows.Forms.Label();
            this.labelEnvironment = new System.Windows.Forms.Label();
            this.labelCD = new System.Windows.Forms.Label();
            this.labelDamageTaken = new System.Windows.Forms.Label();
            this.labelMonstersDefeated = new System.Windows.Forms.Label();
            this.labelCharsDefeated = new System.Windows.Forms.Label();
            this.labelNumMonsters = new System.Windows.Forms.Label();
            this.labelDamageGiven = new System.Windows.Forms.Label();
            this.labelNumOfChars = new System.Windows.Forms.Label();
            this.labelRepeated = new System.Windows.Forms.Label();
            this.labelDifficulty = new System.Windows.Forms.Label();
            this.labelLevelsRan = new System.Windows.Forms.Label();
            this.textBoxTotalCD = new System.Windows.Forms.TextBox();
            this.textBoxMonstersDefeated = new System.Windows.Forms.TextBox();
            this.textBoxDamageGiven = new System.Windows.Forms.TextBox();
            this.textBoxDamageTaken = new System.Windows.Forms.TextBox();
            this.textBoxTotalMonsters = new System.Windows.Forms.TextBox();
            this.textBoxEnv = new System.Windows.Forms.TextBox();
            this.textBoxCharacterDeaths = new System.Windows.Forms.TextBox();
            this.textBoxNumOfChars = new System.Windows.Forms.TextBox();
            this.textBoxReplays = new System.Windows.Forms.TextBox();
            this.textBoxDifficulty = new System.Windows.Forms.TextBox();
            this.textBoxLevelsCompleted = new System.Windows.Forms.TextBox();
            this.buttonExitApp = new System.Windows.Forms.Button();
            this.buttonNewSim = new System.Windows.Forms.Button();
            this.groupBoxReportSelectin.SuspendLayout();
            this.groupBoxReport.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxReportSelectin
            // 
            this.groupBoxReportSelectin.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxReportSelectin.Controls.Add(this.buttonSelectReport);
            this.groupBoxReportSelectin.Controls.Add(this.listBoxReports);
            this.groupBoxReportSelectin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxReportSelectin.Location = new System.Drawing.Point(39, 38);
            this.groupBoxReportSelectin.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxReportSelectin.Name = "groupBoxReportSelectin";
            this.groupBoxReportSelectin.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxReportSelectin.Size = new System.Drawing.Size(321, 558);
            this.groupBoxReportSelectin.TabIndex = 0;
            this.groupBoxReportSelectin.TabStop = false;
            this.groupBoxReportSelectin.Text = "Report Selection";
            // 
            // buttonSelectReport
            // 
            this.buttonSelectReport.Location = new System.Drawing.Point(87, 433);
            this.buttonSelectReport.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSelectReport.Name = "buttonSelectReport";
            this.buttonSelectReport.Size = new System.Drawing.Size(144, 62);
            this.buttonSelectReport.TabIndex = 3;
            this.buttonSelectReport.Text = "Select";
            this.buttonSelectReport.UseVisualStyleBackColor = true;
            this.buttonSelectReport.Click += new System.EventHandler(this.buttonSelectReport_Click);
            // 
            // listBoxReports
            // 
            this.listBoxReports.FormattingEnabled = true;
            this.listBoxReports.ItemHeight = 24;
            this.listBoxReports.Location = new System.Drawing.Point(29, 79);
            this.listBoxReports.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxReports.Name = "listBoxReports";
            this.listBoxReports.Size = new System.Drawing.Size(260, 268);
            this.listBoxReports.TabIndex = 0;
            // 
            // groupBoxReport
            // 
            this.groupBoxReport.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxReport.Controls.Add(this.textBoxTreasure);
            this.groupBoxReport.Controls.Add(this.labelTreasure);
            this.groupBoxReport.Controls.Add(this.labelEnvironment);
            this.groupBoxReport.Controls.Add(this.labelCD);
            this.groupBoxReport.Controls.Add(this.labelDamageTaken);
            this.groupBoxReport.Controls.Add(this.labelMonstersDefeated);
            this.groupBoxReport.Controls.Add(this.labelCharsDefeated);
            this.groupBoxReport.Controls.Add(this.labelNumMonsters);
            this.groupBoxReport.Controls.Add(this.labelDamageGiven);
            this.groupBoxReport.Controls.Add(this.labelNumOfChars);
            this.groupBoxReport.Controls.Add(this.labelRepeated);
            this.groupBoxReport.Controls.Add(this.labelDifficulty);
            this.groupBoxReport.Controls.Add(this.labelLevelsRan);
            this.groupBoxReport.Controls.Add(this.textBoxTotalCD);
            this.groupBoxReport.Controls.Add(this.textBoxMonstersDefeated);
            this.groupBoxReport.Controls.Add(this.textBoxDamageGiven);
            this.groupBoxReport.Controls.Add(this.textBoxDamageTaken);
            this.groupBoxReport.Controls.Add(this.textBoxTotalMonsters);
            this.groupBoxReport.Controls.Add(this.textBoxEnv);
            this.groupBoxReport.Controls.Add(this.textBoxCharacterDeaths);
            this.groupBoxReport.Controls.Add(this.textBoxNumOfChars);
            this.groupBoxReport.Controls.Add(this.textBoxReplays);
            this.groupBoxReport.Controls.Add(this.textBoxDifficulty);
            this.groupBoxReport.Controls.Add(this.textBoxLevelsCompleted);
            this.groupBoxReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxReport.Location = new System.Drawing.Point(412, 38);
            this.groupBoxReport.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxReport.Name = "groupBoxReport";
            this.groupBoxReport.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxReport.Size = new System.Drawing.Size(796, 457);
            this.groupBoxReport.TabIndex = 1;
            this.groupBoxReport.TabStop = false;
            this.groupBoxReport.Text = "Simulation Stats Breakdown";
            // 
            // textBoxTreasure
            // 
            this.textBoxTreasure.Enabled = false;
            this.textBoxTreasure.Location = new System.Drawing.Point(595, 383);
            this.textBoxTreasure.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxTreasure.Name = "textBoxTreasure";
            this.textBoxTreasure.ReadOnly = true;
            this.textBoxTreasure.Size = new System.Drawing.Size(132, 29);
            this.textBoxTreasure.TabIndex = 29;
            // 
            // labelTreasure
            // 
            this.labelTreasure.AutoSize = true;
            this.labelTreasure.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTreasure.Location = new System.Drawing.Point(576, 350);
            this.labelTreasure.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTreasure.Name = "labelTreasure";
            this.labelTreasure.Size = new System.Drawing.Size(129, 22);
            this.labelTreasure.TabIndex = 28;
            this.labelTreasure.Text = "Total Treasure";
            // 
            // labelEnvironment
            // 
            this.labelEnvironment.AutoSize = true;
            this.labelEnvironment.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEnvironment.Location = new System.Drawing.Point(555, 165);
            this.labelEnvironment.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelEnvironment.Name = "labelEnvironment";
            this.labelEnvironment.Size = new System.Drawing.Size(161, 22);
            this.labelEnvironment.TabIndex = 27;
            this.labelEnvironment.Text = "Battle Environment";
            // 
            // labelCD
            // 
            this.labelCD.AutoSize = true;
            this.labelCD.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCD.Location = new System.Drawing.Point(585, 266);
            this.labelCD.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCD.Name = "labelCD";
            this.labelCD.Size = new System.Drawing.Size(82, 22);
            this.labelCD.TabIndex = 26;
            this.labelCD.Text = "Total CD";
            // 
            // labelDamageTaken
            // 
            this.labelDamageTaken.AutoSize = true;
            this.labelDamageTaken.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDamageTaken.Location = new System.Drawing.Point(292, 350);
            this.labelDamageTaken.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDamageTaken.Name = "labelDamageTaken";
            this.labelDamageTaken.Size = new System.Drawing.Size(179, 22);
            this.labelDamageTaken.TabIndex = 25;
            this.labelDamageTaken.Text = "Total Damage Taken";
            // 
            // labelMonstersDefeated
            // 
            this.labelMonstersDefeated.AutoSize = true;
            this.labelMonstersDefeated.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMonstersDefeated.Location = new System.Drawing.Point(309, 266);
            this.labelMonstersDefeated.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMonstersDefeated.Name = "labelMonstersDefeated";
            this.labelMonstersDefeated.Size = new System.Drawing.Size(161, 22);
            this.labelMonstersDefeated.TabIndex = 24;
            this.labelMonstersDefeated.Text = "Monsters Defeated";
            // 
            // labelCharsDefeated
            // 
            this.labelCharsDefeated.AutoSize = true;
            this.labelCharsDefeated.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCharsDefeated.Location = new System.Drawing.Point(295, 165);
            this.labelCharsDefeated.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCharsDefeated.Name = "labelCharsDefeated";
            this.labelCharsDefeated.Size = new System.Drawing.Size(151, 22);
            this.labelCharsDefeated.TabIndex = 23;
            this.labelCharsDefeated.Text = "Character Deaths";
            // 
            // labelNumMonsters
            // 
            this.labelNumMonsters.AutoSize = true;
            this.labelNumMonsters.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumMonsters.Location = new System.Drawing.Point(5, 266);
            this.labelNumMonsters.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNumMonsters.Name = "labelNumMonsters";
            this.labelNumMonsters.Size = new System.Drawing.Size(171, 22);
            this.labelNumMonsters.TabIndex = 22;
            this.labelNumMonsters.Text = "Number of Monsters";
            // 
            // labelDamageGiven
            // 
            this.labelDamageGiven.AutoSize = true;
            this.labelDamageGiven.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDamageGiven.Location = new System.Drawing.Point(0, 350);
            this.labelDamageGiven.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDamageGiven.Name = "labelDamageGiven";
            this.labelDamageGiven.Size = new System.Drawing.Size(175, 22);
            this.labelDamageGiven.TabIndex = 21;
            this.labelDamageGiven.Text = "Total Damage Given";
            // 
            // labelNumOfChars
            // 
            this.labelNumOfChars.AutoSize = true;
            this.labelNumOfChars.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumOfChars.Location = new System.Drawing.Point(7, 165);
            this.labelNumOfChars.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNumOfChars.Name = "labelNumOfChars";
            this.labelNumOfChars.Size = new System.Drawing.Size(186, 22);
            this.labelNumOfChars.TabIndex = 20;
            this.labelNumOfChars.Text = "Number of Characters";
            // 
            // labelRepeated
            // 
            this.labelRepeated.AutoSize = true;
            this.labelRepeated.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRepeated.Location = new System.Drawing.Point(541, 46);
            this.labelRepeated.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelRepeated.Name = "labelRepeated";
            this.labelRepeated.Size = new System.Drawing.Size(163, 22);
            this.labelRepeated.TabIndex = 19;
            this.labelRepeated.Text = "Number of Replays";
            // 
            // labelDifficulty
            // 
            this.labelDifficulty.AutoSize = true;
            this.labelDifficulty.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDifficulty.Location = new System.Drawing.Point(325, 44);
            this.labelDifficulty.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDifficulty.Name = "labelDifficulty";
            this.labelDifficulty.Size = new System.Drawing.Size(78, 22);
            this.labelDifficulty.TabIndex = 18;
            this.labelDifficulty.Text = "Difficulty";
            // 
            // labelLevelsRan
            // 
            this.labelLevelsRan.AutoSize = true;
            this.labelLevelsRan.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLevelsRan.Location = new System.Drawing.Point(8, 46);
            this.labelLevelsRan.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelLevelsRan.Name = "labelLevelsRan";
            this.labelLevelsRan.Size = new System.Drawing.Size(199, 22);
            this.labelLevelsRan.TabIndex = 17;
            this.labelLevelsRan.Text = "Total Levels Completed";
            // 
            // textBoxTotalCD
            // 
            this.textBoxTotalCD.Enabled = false;
            this.textBoxTotalCD.Location = new System.Drawing.Point(595, 300);
            this.textBoxTotalCD.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxTotalCD.Name = "textBoxTotalCD";
            this.textBoxTotalCD.ReadOnly = true;
            this.textBoxTotalCD.Size = new System.Drawing.Size(132, 29);
            this.textBoxTotalCD.TabIndex = 16;
            // 
            // textBoxMonstersDefeated
            // 
            this.textBoxMonstersDefeated.Enabled = false;
            this.textBoxMonstersDefeated.Location = new System.Drawing.Point(332, 300);
            this.textBoxMonstersDefeated.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxMonstersDefeated.Name = "textBoxMonstersDefeated";
            this.textBoxMonstersDefeated.ReadOnly = true;
            this.textBoxMonstersDefeated.Size = new System.Drawing.Size(132, 29);
            this.textBoxMonstersDefeated.TabIndex = 15;
            // 
            // textBoxDamageGiven
            // 
            this.textBoxDamageGiven.Enabled = false;
            this.textBoxDamageGiven.Location = new System.Drawing.Point(55, 383);
            this.textBoxDamageGiven.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxDamageGiven.Name = "textBoxDamageGiven";
            this.textBoxDamageGiven.ReadOnly = true;
            this.textBoxDamageGiven.Size = new System.Drawing.Size(132, 29);
            this.textBoxDamageGiven.TabIndex = 14;
            // 
            // textBoxDamageTaken
            // 
            this.textBoxDamageTaken.Enabled = false;
            this.textBoxDamageTaken.Location = new System.Drawing.Point(332, 383);
            this.textBoxDamageTaken.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxDamageTaken.Name = "textBoxDamageTaken";
            this.textBoxDamageTaken.ReadOnly = true;
            this.textBoxDamageTaken.Size = new System.Drawing.Size(132, 29);
            this.textBoxDamageTaken.TabIndex = 13;
            // 
            // textBoxTotalMonsters
            // 
            this.textBoxTotalMonsters.Enabled = false;
            this.textBoxTotalMonsters.Location = new System.Drawing.Point(52, 300);
            this.textBoxTotalMonsters.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxTotalMonsters.Name = "textBoxTotalMonsters";
            this.textBoxTotalMonsters.ReadOnly = true;
            this.textBoxTotalMonsters.Size = new System.Drawing.Size(132, 29);
            this.textBoxTotalMonsters.TabIndex = 12;
            // 
            // textBoxEnv
            // 
            this.textBoxEnv.Enabled = false;
            this.textBoxEnv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEnv.Location = new System.Drawing.Point(560, 198);
            this.textBoxEnv.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxEnv.Name = "textBoxEnv";
            this.textBoxEnv.ReadOnly = true;
            this.textBoxEnv.Size = new System.Drawing.Size(213, 26);
            this.textBoxEnv.TabIndex = 11;
            // 
            // textBoxCharacterDeaths
            // 
            this.textBoxCharacterDeaths.Enabled = false;
            this.textBoxCharacterDeaths.Location = new System.Drawing.Point(332, 198);
            this.textBoxCharacterDeaths.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxCharacterDeaths.Name = "textBoxCharacterDeaths";
            this.textBoxCharacterDeaths.ReadOnly = true;
            this.textBoxCharacterDeaths.Size = new System.Drawing.Size(132, 29);
            this.textBoxCharacterDeaths.TabIndex = 10;
            // 
            // textBoxNumOfChars
            // 
            this.textBoxNumOfChars.Enabled = false;
            this.textBoxNumOfChars.Location = new System.Drawing.Point(52, 198);
            this.textBoxNumOfChars.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxNumOfChars.Name = "textBoxNumOfChars";
            this.textBoxNumOfChars.ReadOnly = true;
            this.textBoxNumOfChars.Size = new System.Drawing.Size(132, 29);
            this.textBoxNumOfChars.TabIndex = 9;
            // 
            // textBoxReplays
            // 
            this.textBoxReplays.Enabled = false;
            this.textBoxReplays.Location = new System.Drawing.Point(595, 79);
            this.textBoxReplays.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxReplays.Name = "textBoxReplays";
            this.textBoxReplays.ReadOnly = true;
            this.textBoxReplays.Size = new System.Drawing.Size(132, 29);
            this.textBoxReplays.TabIndex = 8;
            // 
            // textBoxDifficulty
            // 
            this.textBoxDifficulty.Enabled = false;
            this.textBoxDifficulty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDifficulty.Location = new System.Drawing.Point(300, 79);
            this.textBoxDifficulty.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxDifficulty.Name = "textBoxDifficulty";
            this.textBoxDifficulty.ReadOnly = true;
            this.textBoxDifficulty.Size = new System.Drawing.Size(205, 26);
            this.textBoxDifficulty.TabIndex = 7;
            // 
            // textBoxLevelsCompleted
            // 
            this.textBoxLevelsCompleted.Enabled = false;
            this.textBoxLevelsCompleted.Location = new System.Drawing.Point(52, 79);
            this.textBoxLevelsCompleted.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxLevelsCompleted.Name = "textBoxLevelsCompleted";
            this.textBoxLevelsCompleted.ReadOnly = true;
            this.textBoxLevelsCompleted.Size = new System.Drawing.Size(132, 29);
            this.textBoxLevelsCompleted.TabIndex = 6;
            this.textBoxLevelsCompleted.TextChanged += new System.EventHandler(this.textBoxLevelsCompleted_TextChanged);
            // 
            // buttonExitApp
            // 
            this.buttonExitApp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExitApp.Location = new System.Drawing.Point(585, 523);
            this.buttonExitApp.Margin = new System.Windows.Forms.Padding(4);
            this.buttonExitApp.Name = "buttonExitApp";
            this.buttonExitApp.Size = new System.Drawing.Size(144, 62);
            this.buttonExitApp.TabIndex = 4;
            this.buttonExitApp.Text = "Exit";
            this.buttonExitApp.UseVisualStyleBackColor = true;
            this.buttonExitApp.Click += new System.EventHandler(this.buttonExitApp_Click);
            // 
            // buttonNewSim
            // 
            this.buttonNewSim.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNewSim.Location = new System.Drawing.Point(897, 524);
            this.buttonNewSim.Margin = new System.Windows.Forms.Padding(4);
            this.buttonNewSim.Name = "buttonNewSim";
            this.buttonNewSim.Size = new System.Drawing.Size(144, 62);
            this.buttonNewSim.TabIndex = 5;
            this.buttonNewSim.Text = "New Simulation";
            this.buttonNewSim.UseVisualStyleBackColor = true;
            this.buttonNewSim.Click += new System.EventHandler(this.buttonNewSim_Click);
            // 
            // ReportGUI
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1225, 601);
            this.Controls.Add(this.buttonExitApp);
            this.Controls.Add(this.buttonNewSim);
            this.Controls.Add(this.groupBoxReport);
            this.Controls.Add(this.groupBoxReportSelectin);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "ReportGUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Post Simulation Report";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ReportGUI_FormClosed);
            this.groupBoxReportSelectin.ResumeLayout(false);
            this.groupBoxReport.ResumeLayout(false);
            this.groupBoxReport.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxReportSelectin;
        private System.Windows.Forms.Button buttonSelectReport;
        private System.Windows.Forms.ListBox listBoxReports;
        private System.Windows.Forms.GroupBox groupBoxReport;
        private System.Windows.Forms.Button buttonExitApp;
        private System.Windows.Forms.Button buttonNewSim;
        private System.Windows.Forms.TextBox textBoxTotalCD;
        private System.Windows.Forms.TextBox textBoxMonstersDefeated;
        private System.Windows.Forms.TextBox textBoxDamageGiven;
        private System.Windows.Forms.TextBox textBoxDamageTaken;
        private System.Windows.Forms.TextBox textBoxTotalMonsters;
        private System.Windows.Forms.TextBox textBoxEnv;
        private System.Windows.Forms.TextBox textBoxCharacterDeaths;
        private System.Windows.Forms.TextBox textBoxNumOfChars;
        private System.Windows.Forms.TextBox textBoxReplays;
        private System.Windows.Forms.TextBox textBoxDifficulty;
        private System.Windows.Forms.TextBox textBoxLevelsCompleted;
        private System.Windows.Forms.Label labelEnvironment;
        private System.Windows.Forms.Label labelCD;
        private System.Windows.Forms.Label labelDamageTaken;
        private System.Windows.Forms.Label labelMonstersDefeated;
        private System.Windows.Forms.Label labelCharsDefeated;
        private System.Windows.Forms.Label labelNumMonsters;
        private System.Windows.Forms.Label labelDamageGiven;
        private System.Windows.Forms.Label labelNumOfChars;
        private System.Windows.Forms.Label labelRepeated;
        private System.Windows.Forms.Label labelDifficulty;
        private System.Windows.Forms.Label labelLevelsRan;
        private System.Windows.Forms.TextBox textBoxTreasure;
        private System.Windows.Forms.Label labelTreasure;
    }
}