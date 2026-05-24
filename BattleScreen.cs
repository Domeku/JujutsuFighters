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
    public partial class BattleScreen : Form
    {
        private string playerCharacter;
        private string enemyCharacter;
        public BattleScreen(string player, string enemy)
        {
            InitializeComponent();
            playerCharacter = player;
            enemyCharacter = enemy;
        }
    }
}
