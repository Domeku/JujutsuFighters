namespace JujutsuFighters
{
    partial class BattleScreen
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
            this.lblPlayerName = new System.Windows.Forms.Label();
            this.pbPlayerHP = new System.Windows.Forms.ProgressBar();
            this.lblPlayerHP = new System.Windows.Forms.Label();
            this.pbPlayer = new System.Windows.Forms.PictureBox();
            this.lblEnemyName = new System.Windows.Forms.Label();
            this.pbEnemyHP = new System.Windows.Forms.ProgressBar();
            this.lblEnemyHP = new System.Windows.Forms.Label();
            this.pbEnemy = new System.Windows.Forms.PictureBox();
            this.lblTurn = new System.Windows.Forms.Label();
            this.rtbLog = new System.Windows.Forms.RichTextBox();
            this.btnStart = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEnemy)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPlayerName
            // 
            this.lblPlayerName.AutoSize = true;
            this.lblPlayerName.BackColor = System.Drawing.Color.Transparent;
            this.lblPlayerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerName.ForeColor = System.Drawing.Color.White;
            this.lblPlayerName.Location = new System.Drawing.Point(12, 9);
            this.lblPlayerName.Name = "lblPlayerName";
            this.lblPlayerName.Size = new System.Drawing.Size(168, 36);
            this.lblPlayerName.TabIndex = 0;
            this.lblPlayerName.Text = "JUGADOR";
            // 
            // pbPlayerHP
            // 
            this.pbPlayerHP.ForeColor = System.Drawing.Color.Lime;
            this.pbPlayerHP.Location = new System.Drawing.Point(18, 78);
            this.pbPlayerHP.Maximum = 1000;
            this.pbPlayerHP.Name = "pbPlayerHP";
            this.pbPlayerHP.Size = new System.Drawing.Size(400, 30);
            this.pbPlayerHP.TabIndex = 1;
            this.pbPlayerHP.Value = 1000;
            // 
            // lblPlayerHP
            // 
            this.lblPlayerHP.AutoSize = true;
            this.lblPlayerHP.BackColor = System.Drawing.Color.Transparent;
            this.lblPlayerHP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerHP.ForeColor = System.Drawing.Color.White;
            this.lblPlayerHP.Location = new System.Drawing.Point(24, 45);
            this.lblPlayerHP.Name = "lblPlayerHP";
            this.lblPlayerHP.Size = new System.Drawing.Size(127, 25);
            this.lblPlayerHP.TabIndex = 2;
            this.lblPlayerHP.Text = "1000 / 1000";
            // 
            // pbPlayer
            // 
            this.pbPlayer.BackColor = System.Drawing.Color.Transparent;
            this.pbPlayer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbPlayer.Location = new System.Drawing.Point(18, 135);
            this.pbPlayer.Name = "pbPlayer";
            this.pbPlayer.Size = new System.Drawing.Size(300, 350);
            this.pbPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPlayer.TabIndex = 3;
            this.pbPlayer.TabStop = false;
            // 
            // lblEnemyName
            // 
            this.lblEnemyName.AutoSize = true;
            this.lblEnemyName.BackColor = System.Drawing.Color.Transparent;
            this.lblEnemyName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnemyName.ForeColor = System.Drawing.Color.Red;
            this.lblEnemyName.Location = new System.Drawing.Point(1067, 9);
            this.lblEnemyName.Name = "lblEnemyName";
            this.lblEnemyName.Size = new System.Drawing.Size(162, 36);
            this.lblEnemyName.TabIndex = 4;
            this.lblEnemyName.Text = "ENEMIGO";
            // 
            // pbEnemyHP
            // 
            this.pbEnemyHP.ForeColor = System.Drawing.Color.Red;
            this.pbEnemyHP.Location = new System.Drawing.Point(829, 78);
            this.pbEnemyHP.Maximum = 1000;
            this.pbEnemyHP.Name = "pbEnemyHP";
            this.pbEnemyHP.Size = new System.Drawing.Size(400, 30);
            this.pbEnemyHP.TabIndex = 5;
            this.pbEnemyHP.Value = 1000;
            // 
            // lblEnemyHP
            // 
            this.lblEnemyHP.AutoSize = true;
            this.lblEnemyHP.BackColor = System.Drawing.Color.Transparent;
            this.lblEnemyHP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnemyHP.ForeColor = System.Drawing.Color.White;
            this.lblEnemyHP.Location = new System.Drawing.Point(1102, 45);
            this.lblEnemyHP.Name = "lblEnemyHP";
            this.lblEnemyHP.Size = new System.Drawing.Size(127, 25);
            this.lblEnemyHP.TabIndex = 6;
            this.lblEnemyHP.Text = "1000 / 1000";
            // 
            // pbEnemy
            // 
            this.pbEnemy.BackColor = System.Drawing.Color.Transparent;
            this.pbEnemy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbEnemy.Location = new System.Drawing.Point(929, 135);
            this.pbEnemy.Name = "pbEnemy";
            this.pbEnemy.Size = new System.Drawing.Size(300, 350);
            this.pbEnemy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbEnemy.TabIndex = 7;
            this.pbEnemy.TabStop = false;
            // 
            // lblTurn
            // 
            this.lblTurn.AutoSize = true;
            this.lblTurn.BackColor = System.Drawing.Color.Transparent;
            this.lblTurn.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTurn.ForeColor = System.Drawing.Color.Yellow;
            this.lblTurn.Location = new System.Drawing.Point(533, 18);
            this.lblTurn.Name = "lblTurn";
            this.lblTurn.Size = new System.Drawing.Size(202, 46);
            this.lblTurn.TabIndex = 8;
            this.lblTurn.Text = "TURNO 1";
            // 
            // rtbLog
            // 
            this.rtbLog.BackColor = System.Drawing.Color.Black;
            this.rtbLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbLog.ForeColor = System.Drawing.Color.White;
            this.rtbLog.Location = new System.Drawing.Point(353, 455);
            this.rtbLog.Name = "rtbLog";
            this.rtbLog.ReadOnly = true;
            this.rtbLog.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rtbLog.Size = new System.Drawing.Size(550, 150);
            this.rtbLog.TabIndex = 9;
            this.rtbLog.Text = " ";
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.DarkRed;
            this.btnStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.ForeColor = System.Drawing.Color.White;
            this.btnStart.Location = new System.Drawing.Point(520, 621);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(233, 40);
            this.btnStart.TabIndex = 10;
            this.btnStart.Text = "INICIAR BATALLA";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // BattleScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::JujutsuFighters.Properties.Resources.Battleground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.rtbLog);
            this.Controls.Add(this.lblTurn);
            this.Controls.Add(this.pbEnemy);
            this.Controls.Add(this.lblEnemyHP);
            this.Controls.Add(this.pbEnemyHP);
            this.Controls.Add(this.lblEnemyName);
            this.Controls.Add(this.pbPlayer);
            this.Controls.Add(this.lblPlayerHP);
            this.Controls.Add(this.pbPlayerHP);
            this.Controls.Add(this.lblPlayerName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "BattleScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "JujutsuFighters - Batalla";
            this.Load += new System.EventHandler(this.BattleScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEnemy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPlayerName;
        private System.Windows.Forms.ProgressBar pbPlayerHP;
        private System.Windows.Forms.Label lblPlayerHP;
        private System.Windows.Forms.PictureBox pbPlayer;
        private System.Windows.Forms.Label lblEnemyName;
        private System.Windows.Forms.ProgressBar pbEnemyHP;
        private System.Windows.Forms.Label lblEnemyHP;
        private System.Windows.Forms.PictureBox pbEnemy;
        private System.Windows.Forms.Label lblTurn;
        private System.Windows.Forms.RichTextBox rtbLog;
        private System.Windows.Forms.Button btnStart;
    }
}