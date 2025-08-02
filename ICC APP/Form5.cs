using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ICC_APP
{
    public partial class PlayerStatistics : Form
    {
        public PlayerStatistics()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }


        private void btnAllRounders_Click(object sender, EventArgs e)
        {
            ListboxAvailablePlayers.Items.Clear();

            string directoryPath = "PlayerStats";

            string FilePath = Path.Combine(directoryPath, "allrounders.txt");

            string[] allrounders = File.ReadAllLines(FilePath);
            foreach (string allrounder in allrounders)
            {
                ListboxAvailablePlayers.Items.Add(allrounder);
            }
        }

        private void btnBowlers_Click(object sender, EventArgs e)
        {
            ListboxAvailablePlayers.Items.Clear();

            string directoryPath = "PlayerStats";

            string FilePath = Path.Combine(directoryPath, "bowlers.txt");

            string[] bowlers = File.ReadAllLines(FilePath);
            foreach (string bowler in bowlers)
            {
                ListboxAvailablePlayers.Items.Add(bowler);
            }
        }

        private void btnBatsmen_Click(object sender, EventArgs e)
        {
            ListboxAvailablePlayers.Items.Clear();

            string directoryPath = "PlayerStats";

            string filePath = Path.Combine(directoryPath, "batsmen.txt");

            string[] batsmen = File.ReadAllLines(filePath);
            foreach (string batsman in batsmen)
            {
                ListboxAvailablePlayers.Items.Add(batsman);
            }
        }

        private void txtPlayerName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();

            Menu MainMenu = new Menu();


            MainMenu.Show();
        }
    }
}
