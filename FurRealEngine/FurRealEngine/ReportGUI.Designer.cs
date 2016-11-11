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
            this.groupBoxReportSelectin = new System.Windows.Forms.GroupBox();
            this.buttonSelectReport = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.labelCharsDefeated = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelDamageOutput = new System.Windows.Forms.Label();
            this.labelNumOfChars = new System.Windows.Forms.Label();
            this.labelRepeated = new System.Windows.Forms.Label();
            this.labelDifficulty = new System.Windows.Forms.Label();
            this.labelLevelsRan = new System.Windows.Forms.Label();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonExitApp = new System.Windows.Forms.Button();
            this.buttonNewSim = new System.Windows.Forms.Button();
            this.groupBoxReportSelectin.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxReportSelectin
            // 
            this.groupBoxReportSelectin.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxReportSelectin.Controls.Add(this.buttonSelectReport);
            this.groupBoxReportSelectin.Controls.Add(this.listBox1);
            this.groupBoxReportSelectin.Font = new System.Drawing.Font("Matura MT Script Capitals", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxReportSelectin.Location = new System.Drawing.Point(29, 31);
            this.groupBoxReportSelectin.Name = "groupBoxReportSelectin";
            this.groupBoxReportSelectin.Size = new System.Drawing.Size(241, 453);
            this.groupBoxReportSelectin.TabIndex = 0;
            this.groupBoxReportSelectin.TabStop = false;
            this.groupBoxReportSelectin.Text = "Report Selection";
            // 
            // buttonSelectReport
            // 
            this.buttonSelectReport.Location = new System.Drawing.Point(54, 375);
            this.buttonSelectReport.Name = "buttonSelectReport";
            this.buttonSelectReport.Size = new System.Drawing.Size(108, 50);
            this.buttonSelectReport.TabIndex = 3;
            this.buttonSelectReport.Text = "Select";
            this.buttonSelectReport.UseVisualStyleBackColor = true;
            this.buttonSelectReport.Click += new System.EventHandler(this.buttonSelectReport_Click);
            // 
            // listBox1
            // 
            this.listBox1.Enabled = false;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 25;
            this.listBox1.Location = new System.Drawing.Point(22, 64);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(178, 254);
            this.listBox1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.labelCharsDefeated);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.labelDamageOutput);
            this.groupBox2.Controls.Add(this.labelNumOfChars);
            this.groupBox2.Controls.Add(this.labelRepeated);
            this.groupBox2.Controls.Add(this.labelDifficulty);
            this.groupBox2.Controls.Add(this.labelLevelsRan);
            this.groupBox2.Controls.Add(this.textBox11);
            this.groupBox2.Controls.Add(this.textBox10);
            this.groupBox2.Controls.Add(this.textBox9);
            this.groupBox2.Controls.Add(this.textBox8);
            this.groupBox2.Controls.Add(this.textBox7);
            this.groupBox2.Controls.Add(this.textBox6);
            this.groupBox2.Controls.Add(this.textBox5);
            this.groupBox2.Controls.Add(this.textBox4);
            this.groupBox2.Controls.Add(this.textBox3);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Font = new System.Drawing.Font("Matura MT Script Capitals", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(309, 31);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(597, 371);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Simulation Stats Breakdown";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Matura MT Script Capitals", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(416, 134);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(169, 24);
            this.label11.TabIndex = 27;
            this.label11.Text = "Battle Environment";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Matura MT Script Capitals", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(439, 216);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 24);
            this.label10.TabIndex = 26;
            this.label10.Text = "Total CD";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Matura MT Script Capitals", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(316, 284);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(189, 24);
            this.label9.TabIndex = 25;
            this.label9.Text = "Total Damage Taken";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Matura MT Script Capitals", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(232, 216);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(177, 24);
            this.label8.TabIndex = 24;
            this.label8.Text = "Monsters Defeated";
            // 
            // labelCharsDefeated
            // 
            this.labelCharsDefeated.AutoSize = true;
            this.labelCharsDefeated.Font = new System.Drawing.Font("Matura MT Script Capitals", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCharsDefeated.Location = new System.Drawing.Point(221, 134);
            this.labelCharsDefeated.Name = "labelCharsDefeated";
            this.labelCharsDefeated.Size = new System.Drawing.Size(159, 24);
            this.labelCharsDefeated.TabIndex = 23;
            this.labelCharsDefeated.Text = "Character Deaths";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Matura MT Script Capitals", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(4, 216);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(192, 24);
            this.label6.TabIndex = 22;
            this.label6.Text = "Number of Monsters";
            // 
            // labelDamageOutput
            // 
            this.labelDamageOutput.AutoSize = true;
            this.labelDamageOutput.Font = new System.Drawing.Font("Matura MT Script Capitals", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDamageOutput.Location = new System.Drawing.Point(97, 284);
            this.labelDamageOutput.Name = "labelDamageOutput";
            this.labelDamageOutput.Size = new System.Drawing.Size(184, 24);
            this.labelDamageOutput.TabIndex = 21;
            this.labelDamageOutput.Text = "Total Damage Given";
            // 
            // labelNumOfChars
            // 
            this.labelNumOfChars.AutoSize = true;
            this.labelNumOfChars.Font = new System.Drawing.Font("Matura MT Script Capitals", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumOfChars.Location = new System.Drawing.Point(5, 134);
            this.labelNumOfChars.Name = "labelNumOfChars";
            this.labelNumOfChars.Size = new System.Drawing.Size(197, 24);
            this.labelNumOfChars.TabIndex = 20;
            this.labelNumOfChars.Text = "Number of Characters";
            // 
            // labelRepeated
            // 
            this.labelRepeated.AutoSize = true;
            this.labelRepeated.Font = new System.Drawing.Font("Matura MT Script Capitals", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRepeated.Location = new System.Drawing.Point(406, 37);
            this.labelRepeated.Name = "labelRepeated";
            this.labelRepeated.Size = new System.Drawing.Size(175, 24);
            this.labelRepeated.TabIndex = 19;
            this.labelRepeated.Text = "Number of Replays";
            // 
            // labelDifficulty
            // 
            this.labelDifficulty.AutoSize = true;
            this.labelDifficulty.Font = new System.Drawing.Font("Matura MT Script Capitals", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDifficulty.Location = new System.Drawing.Point(244, 36);
            this.labelDifficulty.Name = "labelDifficulty";
            this.labelDifficulty.Size = new System.Drawing.Size(97, 24);
            this.labelDifficulty.TabIndex = 18;
            this.labelDifficulty.Text = "Difficulty";
            // 
            // labelLevelsRan
            // 
            this.labelLevelsRan.AutoSize = true;
            this.labelLevelsRan.Font = new System.Drawing.Font("Matura MT Script Capitals", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLevelsRan.Location = new System.Drawing.Point(6, 37);
            this.labelLevelsRan.Name = "labelLevelsRan";
            this.labelLevelsRan.Size = new System.Drawing.Size(210, 24);
            this.labelLevelsRan.TabIndex = 17;
            this.labelLevelsRan.Text = "Total Levels Completed";
            // 
            // textBox11
            // 
            this.textBox11.Enabled = false;
            this.textBox11.Location = new System.Drawing.Point(446, 244);
            this.textBox11.Name = "textBox11";
            this.textBox11.ReadOnly = true;
            this.textBox11.Size = new System.Drawing.Size(100, 32);
            this.textBox11.TabIndex = 16;
            // 
            // textBox10
            // 
            this.textBox10.Enabled = false;
            this.textBox10.Location = new System.Drawing.Point(249, 244);
            this.textBox10.Name = "textBox10";
            this.textBox10.ReadOnly = true;
            this.textBox10.Size = new System.Drawing.Size(100, 32);
            this.textBox10.TabIndex = 15;
            // 
            // textBox9
            // 
            this.textBox9.Enabled = false;
            this.textBox9.Location = new System.Drawing.Point(138, 311);
            this.textBox9.Name = "textBox9";
            this.textBox9.ReadOnly = true;
            this.textBox9.Size = new System.Drawing.Size(100, 32);
            this.textBox9.TabIndex = 14;
            // 
            // textBox8
            // 
            this.textBox8.Enabled = false;
            this.textBox8.Location = new System.Drawing.Point(346, 311);
            this.textBox8.Name = "textBox8";
            this.textBox8.ReadOnly = true;
            this.textBox8.Size = new System.Drawing.Size(100, 32);
            this.textBox8.TabIndex = 13;
            // 
            // textBox7
            // 
            this.textBox7.Enabled = false;
            this.textBox7.Location = new System.Drawing.Point(39, 244);
            this.textBox7.Name = "textBox7";
            this.textBox7.ReadOnly = true;
            this.textBox7.Size = new System.Drawing.Size(100, 32);
            this.textBox7.TabIndex = 12;
            // 
            // textBox6
            // 
            this.textBox6.Enabled = false;
            this.textBox6.Location = new System.Drawing.Point(446, 161);
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(100, 32);
            this.textBox6.TabIndex = 11;
            // 
            // textBox5
            // 
            this.textBox5.Enabled = false;
            this.textBox5.Location = new System.Drawing.Point(249, 161);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(100, 32);
            this.textBox5.TabIndex = 10;
            // 
            // textBox4
            // 
            this.textBox4.Enabled = false;
            this.textBox4.Location = new System.Drawing.Point(39, 161);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(100, 32);
            this.textBox4.TabIndex = 9;
            // 
            // textBox3
            // 
            this.textBox3.Enabled = false;
            this.textBox3.Location = new System.Drawing.Point(446, 64);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(100, 32);
            this.textBox3.TabIndex = 8;
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(249, 64);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(100, 32);
            this.textBox2.TabIndex = 7;
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(39, 64);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(100, 32);
            this.textBox1.TabIndex = 6;
            // 
            // buttonExitApp
            // 
            this.buttonExitApp.Font = new System.Drawing.Font("Matura MT Script Capitals", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExitApp.Location = new System.Drawing.Point(439, 425);
            this.buttonExitApp.Name = "buttonExitApp";
            this.buttonExitApp.Size = new System.Drawing.Size(108, 50);
            this.buttonExitApp.TabIndex = 4;
            this.buttonExitApp.Text = "Exit";
            this.buttonExitApp.UseVisualStyleBackColor = true;
            this.buttonExitApp.Click += new System.EventHandler(this.buttonExitApp_Click);
            // 
            // buttonNewSim
            // 
            this.buttonNewSim.Font = new System.Drawing.Font("Matura MT Script Capitals", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNewSim.Location = new System.Drawing.Point(673, 426);
            this.buttonNewSim.Name = "buttonNewSim";
            this.buttonNewSim.Size = new System.Drawing.Size(108, 50);
            this.buttonNewSim.TabIndex = 5;
            this.buttonNewSim.Text = "New Simulation";
            this.buttonNewSim.UseVisualStyleBackColor = true;
            this.buttonNewSim.Click += new System.EventHandler(this.buttonNewSim_Click);
            // 
            // ReportGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FurRealEngine.Properties.Resources.temple_parchment_desktop_by_gladlad_d4zbkdw;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(919, 488);
            this.Controls.Add(this.buttonExitApp);
            this.Controls.Add(this.buttonNewSim);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBoxReportSelectin);
            this.Name = "ReportGUI";
            this.Text = "Post Simulation Report";
            this.groupBoxReportSelectin.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxReportSelectin;
        private System.Windows.Forms.Button buttonSelectReport;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonExitApp;
        private System.Windows.Forms.Button buttonNewSim;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label labelCharsDefeated;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelDamageOutput;
        private System.Windows.Forms.Label labelNumOfChars;
        private System.Windows.Forms.Label labelRepeated;
        private System.Windows.Forms.Label labelDifficulty;
        private System.Windows.Forms.Label labelLevelsRan;
    }
}