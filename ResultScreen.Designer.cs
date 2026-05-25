namespace JujutsuFighters
{
    partial class ResultScreen
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
            this.lblWinner = new System.Windows.Forms.Label();
            this.lblLoser = new System.Windows.Forms.Label();
            this.lblSummaryTitle = new System.Windows.Forms.Label();
            this.rtbSummary = new System.Windows.Forms.RichTextBox();
            this.btnPlayAgain = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblWinner
            // 
            this.lblWinner.AutoSize = true;
            this.lblWinner.BackColor = System.Drawing.Color.Transparent;
            this.lblWinner.Font = new System.Drawing.Font("Microsoft Sans Serif", 42F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWinner.ForeColor = System.Drawing.Color.Gold;
            this.lblWinner.Location = new System.Drawing.Point(302, 22);
            this.lblWinner.Name = "lblWinner";
            this.lblWinner.Size = new System.Drawing.Size(494, 79);
            this.lblWinner.TabIndex = 0;
            this.lblWinner.Text = "🏆 GANADOR";
            // 
            // lblLoser
            // 
            this.lblLoser.AutoSize = true;
            this.lblLoser.BackColor = System.Drawing.Color.Transparent;
            this.lblLoser.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoser.ForeColor = System.Drawing.Color.Gray;
            this.lblLoser.Location = new System.Drawing.Point(466, 101);
            this.lblLoser.Name = "lblLoser";
            this.lblLoser.Size = new System.Drawing.Size(107, 38);
            this.lblLoser.TabIndex = 1;
            this.lblLoser.Text = "perdió";
            // 
            // lblSummaryTitle
            // 
            this.lblSummaryTitle.AutoSize = true;
            this.lblSummaryTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblSummaryTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSummaryTitle.ForeColor = System.Drawing.Color.White;
            this.lblSummaryTitle.Location = new System.Drawing.Point(428, 204);
            this.lblSummaryTitle.Name = "lblSummaryTitle";
            this.lblSummaryTitle.Size = new System.Drawing.Size(432, 36);
            this.lblSummaryTitle.TabIndex = 2;
            this.lblSummaryTitle.Text = "📜 RESUMEN DE LA PELEA";
            // 
            // rtbSummary
            // 
            this.rtbSummary.BackColor = System.Drawing.Color.Black;
            this.rtbSummary.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbSummary.ForeColor = System.Drawing.Color.White;
            this.rtbSummary.Location = new System.Drawing.Point(216, 245);
            this.rtbSummary.Name = "rtbSummary";
            this.rtbSummary.ReadOnly = true;
            this.rtbSummary.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rtbSummary.Size = new System.Drawing.Size(880, 360);
            this.rtbSummary.TabIndex = 3;
            this.rtbSummary.Text = "";
            // 
            // btnPlayAgain
            // 
            this.btnPlayAgain.BackColor = System.Drawing.Color.DarkGreen;
            this.btnPlayAgain.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPlayAgain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlayAgain.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlayAgain.ForeColor = System.Drawing.Color.White;
            this.btnPlayAgain.Location = new System.Drawing.Point(383, 611);
            this.btnPlayAgain.Name = "btnPlayAgain";
            this.btnPlayAgain.Size = new System.Drawing.Size(247, 50);
            this.btnPlayAgain.TabIndex = 4;
            this.btnPlayAgain.Text = "JUGAR DE NUEVO";
            this.btnPlayAgain.UseVisualStyleBackColor = false;
            this.btnPlayAgain.Click += new System.EventHandler(this.btnPlayAgain_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.DarkRed;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(675, 611);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(247, 50);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "SALIR";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // ResultScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::JujutsuFighters.Properties.Resources.ResumenBanner;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnPlayAgain);
            this.Controls.Add(this.rtbSummary);
            this.Controls.Add(this.lblSummaryTitle);
            this.Controls.Add(this.lblLoser);
            this.Controls.Add(this.lblWinner);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ResultScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "JujutsuFighters - Resultado";
            this.Load += new System.EventHandler(this.ResultScreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWinner;
        private System.Windows.Forms.Label lblLoser;
        private System.Windows.Forms.Label lblSummaryTitle;
        private System.Windows.Forms.RichTextBox rtbSummary;
        private System.Windows.Forms.Button btnPlayAgain;
        private System.Windows.Forms.Button btnExit;
    }
}