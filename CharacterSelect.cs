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
    public partial class CharacterSelect : Form
    {
        private string[] allCharacters = { "Gojo", "Itadori", "Maki", "Sukuna" };
        public CharacterSelect()
        {
            InitializeComponent();
        }

        private void SelectCharacter(string selectedCharacter)
        {
            Random rand = new Random();
            string enemyCharacter;

            // Elegir enemigo aleatorio que no sea el personaje seleccionado
            do
            {
                enemyCharacter = allCharacters[rand.Next(allCharacters.Length)];
            } while (enemyCharacter == selectedCharacter);

            // Abrir pantalla de batalla pasando los personajes
            BattleScreen battle = new BattleScreen(selectedCharacter, enemyCharacter);
            battle.Show();
            this.Hide();
        }

        private void btnGojo_Click(object sender, EventArgs e)
        {
            SelectCharacter("Gojo");
        }

        private void btnItadori_Click(object sender, EventArgs e)
        {
            SelectCharacter("Itadori");
        }

        private void btnMaki_Click(object sender, EventArgs e)
        {
            SelectCharacter("Maki");
        }

        private void btnSukuna_Click(object sender, EventArgs e)
        {
            SelectCharacter("Sukuna");
        }
    }
}
