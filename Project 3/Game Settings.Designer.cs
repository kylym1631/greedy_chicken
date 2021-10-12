
namespace Project_3
{
    partial class GameSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameSettings));
            this.labMain = new System.Windows.Forms.Label();
            this.gbSettings = new System.Windows.Forms.GroupBox();
            this.butCon = new System.Windows.Forms.Button();
            this.tbGoal = new System.Windows.Forms.TextBox();
            this.tbNumPeo = new System.Windows.Forms.TextBox();
            this.labGoal = new System.Windows.Forms.Label();
            this.labNumPeo = new System.Windows.Forms.Label();
            this.gbNames = new System.Windows.Forms.GroupBox();
            this.gbPlayer4 = new System.Windows.Forms.GroupBox();
            this.butPlayer4 = new System.Windows.Forms.Button();
            this.tbPlayer4 = new System.Windows.Forms.TextBox();
            this.labPlayer4 = new System.Windows.Forms.Label();
            this.gbPlayer3 = new System.Windows.Forms.GroupBox();
            this.butPlayer3 = new System.Windows.Forms.Button();
            this.tbPlayer3 = new System.Windows.Forms.TextBox();
            this.labPlayer3 = new System.Windows.Forms.Label();
            this.gbPlayer2 = new System.Windows.Forms.GroupBox();
            this.butPlayer2 = new System.Windows.Forms.Button();
            this.tbPlayer2 = new System.Windows.Forms.TextBox();
            this.labPlayer2 = new System.Windows.Forms.Label();
            this.gbPlayer1 = new System.Windows.Forms.GroupBox();
            this.butPlayer1 = new System.Windows.Forms.Button();
            this.tbPlayer1 = new System.Windows.Forms.TextBox();
            this.labPlayer1 = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.colorDialog2 = new System.Windows.Forms.ColorDialog();
            this.colorDialog3 = new System.Windows.Forms.ColorDialog();
            this.colorDialog4 = new System.Windows.Forms.ColorDialog();
            this.butStart = new System.Windows.Forms.Button();
            this.gbSettings.SuspendLayout();
            this.gbNames.SuspendLayout();
            this.gbPlayer4.SuspendLayout();
            this.gbPlayer3.SuspendLayout();
            this.gbPlayer2.SuspendLayout();
            this.gbPlayer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labMain
            // 
            this.labMain.AutoSize = true;
            this.labMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labMain.Location = new System.Drawing.Point(271, 26);
            this.labMain.Name = "labMain";
            this.labMain.Size = new System.Drawing.Size(170, 26);
            this.labMain.TabIndex = 0;
            this.labMain.Text = "Game Settings";
            this.labMain.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gbSettings
            // 
            this.gbSettings.Controls.Add(this.butCon);
            this.gbSettings.Controls.Add(this.tbGoal);
            this.gbSettings.Controls.Add(this.tbNumPeo);
            this.gbSettings.Controls.Add(this.labGoal);
            this.gbSettings.Controls.Add(this.labNumPeo);
            this.gbSettings.Location = new System.Drawing.Point(12, 73);
            this.gbSettings.Name = "gbSettings";
            this.gbSettings.Size = new System.Drawing.Size(735, 146);
            this.gbSettings.TabIndex = 1;
            this.gbSettings.TabStop = false;
            this.gbSettings.Text = "Settings";
            // 
            // butCon
            // 
            this.butCon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butCon.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butCon.Location = new System.Drawing.Point(531, 32);
            this.butCon.Name = "butCon";
            this.butCon.Size = new System.Drawing.Size(184, 94);
            this.butCon.TabIndex = 4;
            this.butCon.Text = "Confirm";
            this.butCon.UseVisualStyleBackColor = true;
            this.butCon.Click += new System.EventHandler(this.butCon_Click);
            // 
            // tbGoal
            // 
            this.tbGoal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbGoal.Location = new System.Drawing.Point(309, 91);
            this.tbGoal.Name = "tbGoal";
            this.tbGoal.Size = new System.Drawing.Size(185, 26);
            this.tbGoal.TabIndex = 3;
            // 
            // tbNumPeo
            // 
            this.tbNumPeo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNumPeo.Location = new System.Drawing.Point(309, 37);
            this.tbNumPeo.Name = "tbNumPeo";
            this.tbNumPeo.Size = new System.Drawing.Size(185, 26);
            this.tbNumPeo.TabIndex = 2;
            // 
            // labGoal
            // 
            this.labGoal.AutoSize = true;
            this.labGoal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labGoal.Location = new System.Drawing.Point(22, 91);
            this.labGoal.Name = "labGoal";
            this.labGoal.Size = new System.Drawing.Size(53, 24);
            this.labGoal.TabIndex = 1;
            this.labGoal.Text = "Goal";
            // 
            // labNumPeo
            // 
            this.labNumPeo.AutoSize = true;
            this.labNumPeo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labNumPeo.Location = new System.Drawing.Point(22, 32);
            this.labNumPeo.Name = "labNumPeo";
            this.labNumPeo.Size = new System.Drawing.Size(180, 24);
            this.labNumPeo.TabIndex = 0;
            this.labNumPeo.Text = "Number of People";
            // 
            // gbNames
            // 
            this.gbNames.Controls.Add(this.gbPlayer4);
            this.gbNames.Controls.Add(this.gbPlayer3);
            this.gbNames.Controls.Add(this.gbPlayer2);
            this.gbNames.Controls.Add(this.gbPlayer1);
            this.gbNames.Enabled = false;
            this.gbNames.Location = new System.Drawing.Point(12, 271);
            this.gbNames.Name = "gbNames";
            this.gbNames.Size = new System.Drawing.Size(735, 214);
            this.gbNames.TabIndex = 2;
            this.gbNames.TabStop = false;
            this.gbNames.Text = "Names";
            // 
            // gbPlayer4
            // 
            this.gbPlayer4.Controls.Add(this.butPlayer4);
            this.gbPlayer4.Controls.Add(this.tbPlayer4);
            this.gbPlayer4.Controls.Add(this.labPlayer4);
            this.gbPlayer4.Location = new System.Drawing.Point(382, 136);
            this.gbPlayer4.Name = "gbPlayer4";
            this.gbPlayer4.Size = new System.Drawing.Size(333, 61);
            this.gbPlayer4.TabIndex = 3;
            this.gbPlayer4.TabStop = false;
            // 
            // butPlayer4
            // 
            this.butPlayer4.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.butPlayer4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butPlayer4.Location = new System.Drawing.Point(285, 17);
            this.butPlayer4.Name = "butPlayer4";
            this.butPlayer4.Size = new System.Drawing.Size(42, 36);
            this.butPlayer4.TabIndex = 2;
            this.butPlayer4.UseVisualStyleBackColor = false;
            this.butPlayer4.Click += new System.EventHandler(this.butPlayer4_Click);
            // 
            // tbPlayer4
            // 
            this.tbPlayer4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPlayer4.Location = new System.Drawing.Point(127, 17);
            this.tbPlayer4.Name = "tbPlayer4";
            this.tbPlayer4.Size = new System.Drawing.Size(151, 26);
            this.tbPlayer4.TabIndex = 1;
            // 
            // labPlayer4
            // 
            this.labPlayer4.AutoSize = true;
            this.labPlayer4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labPlayer4.Location = new System.Drawing.Point(6, 19);
            this.labPlayer4.Name = "labPlayer4";
            this.labPlayer4.Size = new System.Drawing.Size(78, 20);
            this.labPlayer4.TabIndex = 0;
            this.labPlayer4.Text = "Player 4:";
            // 
            // gbPlayer3
            // 
            this.gbPlayer3.Controls.Add(this.butPlayer3);
            this.gbPlayer3.Controls.Add(this.tbPlayer3);
            this.gbPlayer3.Controls.Add(this.labPlayer3);
            this.gbPlayer3.Location = new System.Drawing.Point(6, 136);
            this.gbPlayer3.Name = "gbPlayer3";
            this.gbPlayer3.Size = new System.Drawing.Size(333, 61);
            this.gbPlayer3.TabIndex = 3;
            this.gbPlayer3.TabStop = false;
            // 
            // butPlayer3
            // 
            this.butPlayer3.BackColor = System.Drawing.Color.Lime;
            this.butPlayer3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butPlayer3.Location = new System.Drawing.Point(285, 17);
            this.butPlayer3.Name = "butPlayer3";
            this.butPlayer3.Size = new System.Drawing.Size(42, 36);
            this.butPlayer3.TabIndex = 2;
            this.butPlayer3.UseVisualStyleBackColor = false;
            this.butPlayer3.Click += new System.EventHandler(this.butPlayer3_Click);
            // 
            // tbPlayer3
            // 
            this.tbPlayer3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPlayer3.Location = new System.Drawing.Point(127, 17);
            this.tbPlayer3.Name = "tbPlayer3";
            this.tbPlayer3.Size = new System.Drawing.Size(151, 26);
            this.tbPlayer3.TabIndex = 1;
            // 
            // labPlayer3
            // 
            this.labPlayer3.AutoSize = true;
            this.labPlayer3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labPlayer3.Location = new System.Drawing.Point(6, 19);
            this.labPlayer3.Name = "labPlayer3";
            this.labPlayer3.Size = new System.Drawing.Size(78, 20);
            this.labPlayer3.TabIndex = 0;
            this.labPlayer3.Text = "Player 3:";
            // 
            // gbPlayer2
            // 
            this.gbPlayer2.Controls.Add(this.butPlayer2);
            this.gbPlayer2.Controls.Add(this.tbPlayer2);
            this.gbPlayer2.Controls.Add(this.labPlayer2);
            this.gbPlayer2.Location = new System.Drawing.Point(382, 37);
            this.gbPlayer2.Name = "gbPlayer2";
            this.gbPlayer2.Size = new System.Drawing.Size(333, 61);
            this.gbPlayer2.TabIndex = 3;
            this.gbPlayer2.TabStop = false;
            // 
            // butPlayer2
            // 
            this.butPlayer2.BackColor = System.Drawing.Color.Gold;
            this.butPlayer2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butPlayer2.Location = new System.Drawing.Point(285, 17);
            this.butPlayer2.Name = "butPlayer2";
            this.butPlayer2.Size = new System.Drawing.Size(42, 36);
            this.butPlayer2.TabIndex = 2;
            this.butPlayer2.UseVisualStyleBackColor = false;
            this.butPlayer2.Click += new System.EventHandler(this.butPlayer2_Click);
            // 
            // tbPlayer2
            // 
            this.tbPlayer2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPlayer2.Location = new System.Drawing.Point(127, 17);
            this.tbPlayer2.Name = "tbPlayer2";
            this.tbPlayer2.Size = new System.Drawing.Size(151, 26);
            this.tbPlayer2.TabIndex = 1;
            // 
            // labPlayer2
            // 
            this.labPlayer2.AutoSize = true;
            this.labPlayer2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labPlayer2.Location = new System.Drawing.Point(6, 19);
            this.labPlayer2.Name = "labPlayer2";
            this.labPlayer2.Size = new System.Drawing.Size(78, 20);
            this.labPlayer2.TabIndex = 0;
            this.labPlayer2.Text = "Player 2:";
            // 
            // gbPlayer1
            // 
            this.gbPlayer1.Controls.Add(this.butPlayer1);
            this.gbPlayer1.Controls.Add(this.tbPlayer1);
            this.gbPlayer1.Controls.Add(this.labPlayer1);
            this.gbPlayer1.Location = new System.Drawing.Point(6, 37);
            this.gbPlayer1.Name = "gbPlayer1";
            this.gbPlayer1.Size = new System.Drawing.Size(333, 61);
            this.gbPlayer1.TabIndex = 0;
            this.gbPlayer1.TabStop = false;
            // 
            // butPlayer1
            // 
            this.butPlayer1.BackColor = System.Drawing.Color.Red;
            this.butPlayer1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butPlayer1.Location = new System.Drawing.Point(285, 17);
            this.butPlayer1.Name = "butPlayer1";
            this.butPlayer1.Size = new System.Drawing.Size(42, 36);
            this.butPlayer1.TabIndex = 2;
            this.butPlayer1.UseVisualStyleBackColor = false;
            this.butPlayer1.Click += new System.EventHandler(this.butPlayer1_Click);
            // 
            // tbPlayer1
            // 
            this.tbPlayer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPlayer1.Location = new System.Drawing.Point(127, 17);
            this.tbPlayer1.Name = "tbPlayer1";
            this.tbPlayer1.Size = new System.Drawing.Size(151, 26);
            this.tbPlayer1.TabIndex = 1;
            // 
            // labPlayer1
            // 
            this.labPlayer1.AutoSize = true;
            this.labPlayer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labPlayer1.Location = new System.Drawing.Point(6, 19);
            this.labPlayer1.Name = "labPlayer1";
            this.labPlayer1.Size = new System.Drawing.Size(78, 20);
            this.labPlayer1.TabIndex = 0;
            this.labPlayer1.Text = "Player 1:";
            // 
            // butStart
            // 
            this.butStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butStart.Location = new System.Drawing.Point(12, 502);
            this.butStart.Name = "butStart";
            this.butStart.Size = new System.Drawing.Size(735, 72);
            this.butStart.TabIndex = 5;
            this.butStart.Text = "START";
            this.butStart.UseVisualStyleBackColor = true;
            this.butStart.Click += new System.EventHandler(this.butStart_Click);
            // 
            // GameSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 586);
            this.Controls.Add(this.butStart);
            this.Controls.Add(this.gbNames);
            this.Controls.Add(this.gbSettings);
            this.Controls.Add(this.labMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GameSettings";
            this.Text = "Game Settings";
            this.Load += new System.EventHandler(this.GameSettings_Load);
            this.gbSettings.ResumeLayout(false);
            this.gbSettings.PerformLayout();
            this.gbNames.ResumeLayout(false);
            this.gbPlayer4.ResumeLayout(false);
            this.gbPlayer4.PerformLayout();
            this.gbPlayer3.ResumeLayout(false);
            this.gbPlayer3.PerformLayout();
            this.gbPlayer2.ResumeLayout(false);
            this.gbPlayer2.PerformLayout();
            this.gbPlayer1.ResumeLayout(false);
            this.gbPlayer1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labMain;
        private System.Windows.Forms.GroupBox gbSettings;
        private System.Windows.Forms.Button butCon;
        private System.Windows.Forms.TextBox tbGoal;
        private System.Windows.Forms.TextBox tbNumPeo;
        private System.Windows.Forms.Label labGoal;
        private System.Windows.Forms.Label labNumPeo;
        private System.Windows.Forms.GroupBox gbNames;
        private System.Windows.Forms.GroupBox gbPlayer1;
        private System.Windows.Forms.Button butPlayer1;
        private System.Windows.Forms.TextBox tbPlayer1;
        private System.Windows.Forms.Label labPlayer1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.GroupBox gbPlayer4;
        private System.Windows.Forms.Button butPlayer4;
        private System.Windows.Forms.TextBox tbPlayer4;
        private System.Windows.Forms.Label labPlayer4;
        private System.Windows.Forms.GroupBox gbPlayer3;
        private System.Windows.Forms.Button butPlayer3;
        private System.Windows.Forms.TextBox tbPlayer3;
        private System.Windows.Forms.Label labPlayer3;
        private System.Windows.Forms.GroupBox gbPlayer2;
        private System.Windows.Forms.Button butPlayer2;
        private System.Windows.Forms.TextBox tbPlayer2;
        private System.Windows.Forms.Label labPlayer2;
        private System.Windows.Forms.ColorDialog colorDialog2;
        private System.Windows.Forms.ColorDialog colorDialog3;
        private System.Windows.Forms.ColorDialog colorDialog4;
        private System.Windows.Forms.Button butStart;
    }
}