using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JujutsuFighters
{
    public partial class ResultScreen : Form
    {
        private string winner;
        private string loser;
        private List<string> battleLog;
        public ResultScreen(string winner, string loser, List<string> log)
        {
            InitializeComponent();
            this.winner = winner;
            this.loser = loser;
            this.battleLog = log;
        }

        private void ResultScreen_Load(object sender, EventArgs e)
        {
            // Mostrar ganador y perdedor
            lblWinner.Text = "🏆 " + winner.ToUpper() + " GANA!";
            lblLoser.Text = loser.ToUpper() + " fue derrotado.";

            // Llenar el resumen con el log completo
            foreach (string line in battleLog)
            {
                Color color = Color.White;

                if (line.Contains("TURNO")) color = Color.Yellow;
                else if (line.Contains("CRÍTICO")) color = Color.Orange;
                else if (line.Contains("esquivó")) color = Color.Cyan;
                else if (line.Contains("falló")) color = Color.Gray;
                else if (line.Contains("mareado")) color = Color.Orange;
                else if (line.Contains("regenera")) color = Color.LimeGreen;
                else if (line.Contains("atacó") && battleLog.IndexOf(line) % 2 == 0) color = Color.LimeGreen;
                else if (line.Contains("atacó")) color = Color.Red;
                else if (line.Contains("GANA")) color = Color.Gold;
                else if (line.Contains("══")) color = Color.Gray;

                rtbSummary.SelectionStart = rtbSummary.TextLength;
                rtbSummary.SelectionLength = 0;
                rtbSummary.SelectionColor = color;
                rtbSummary.AppendText(line + "\n");
            }

            rtbSummary.SelectionStart = 0;
            rtbSummary.ScrollToCaret();
        }

        private void btnPlayAgain_Click(object sender, EventArgs e)
        {
            CharacterSelect characterSelect = new CharacterSelect();
            characterSelect.Show();
            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
