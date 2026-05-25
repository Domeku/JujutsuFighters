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
    }
}
