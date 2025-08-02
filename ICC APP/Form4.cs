using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace ICC_APP
{
    public partial class FantasyCricket : Form
    {
        public FantasyCricket()
        {
            InitializeComponent();
        }
        private void txtUsername_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnLoadBatsmen_Click(object sender, EventArgs e)
        {
            listBoxAvailablePlayers.Items.Clear();

            string directoryPath = "Data";
            string filePath = Path.Combine(directoryPath, "batsmen.txt");

            string[] batsmen = File.ReadAllLines(filePath);

            foreach (string batsman in batsmen)
            {
                Player player = new Player(batsman);

                listBoxAvailablePlayers.Items.Add(batsman);
            }
        }


        private void btnLoadBowlers_Click(object sender, EventArgs e)
        {
            listBoxAvailablePlayers.Items.Clear();

            string directoryPath = "Data";

            string filePath = Path.Combine(directoryPath, "bowlers.txt");

            string[] bowlers = File.ReadAllLines(filePath);
            foreach (string bowler in bowlers)
            {
                Player player = new Player(bowler);

                listBoxAvailablePlayers.Items.Add(bowler);
            }
        }

        private void btnAllRounders_Click(object sender, EventArgs e)
        {
            listBoxAvailablePlayers.Items.Clear();

            string directoryPath = "Data";
            string filePath = Path.Combine(directoryPath, "allrounders.txt");

            string[] allrounders = File.ReadAllLines(filePath);
            foreach (string allrounder in allrounders)
            {
                Player player = new Player(allrounder);
                listBoxAvailablePlayers.Items.Add(allrounder);
            }
        }

        private void txtPlayerName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string playerName = txtPlayerName.Text.Trim();

                if (!string.IsNullOrEmpty(playerName))
                {
                    if (listBoxAvailablePlayers.Items.Contains(playerName))
                    {
                        if (!listBoxFantasyTeam.Items.Contains(playerName))
                        {

                            txtPlayerName.Clear();

                            listBoxFantasyTeam.Items.Add(playerName);

                            MessageBox.Show($"{playerName} has been added to your Fantasy Cricket team!", "Player Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show($"{playerName} is already in your Fantasy Cricket team!", "Duplicate Player", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show($"{playerName} does not exist in the available players' list. Please check the name.", "Invalid Player", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Please enter a player's name before pressing Enter.", "No Input", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {


            string username = txtUsername.Text.Trim();

            if (string.IsNullOrEmpty(username))
            {
                MessageBox.Show("Please enter a username.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            List<string> teamPlayers = new List<string>();
            foreach (var player in listBoxFantasyTeam.Items)
            {
                teamPlayers.Add(player.ToString());
            }

            string directoryPath = "FantasyTeams";
            string filePath = Path.Combine(directoryPath, $"{username}.txt");

            try
            {

                string dataToSave = $"Username: {username}\nTeam:\n {string.Join("\n ", teamPlayers)}";

                File.WriteAllText(filePath, dataToSave);

                MessageBox.Show($"Your team has been saved successfully! File: {filePath}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while saving the team:{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLoadTeam_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();

            if (string.IsNullOrEmpty(username))
            {
                MessageBox.Show("Please enter a username to load the team.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string directoryPath = "FantasyTeams";
            string filePath = Path.Combine(directoryPath, $"{username}.txt");

            if (File.Exists(filePath))
            {
                listBoxFantasyTeam.Items.Clear();

                string[] fileContents = File.ReadAllLines(filePath);

                foreach (string line in fileContents)
                {
                    if (!line.StartsWith("Username") && !line.StartsWith("Team:") && !string.IsNullOrWhiteSpace(line))
                    {
                        listBoxFantasyTeam.Items.Add(line.Trim());
                    }
                }

                MessageBox.Show($"Team for {username} has been added successfully!", "Team Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show($"No team found for the username: {username}.", "Team Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();

            Menu MainMenu = new Menu();


            MainMenu.Show();
        }

        private void txtRemovePlayer_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtRemovePlayer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string playerName = txtRemovePlayer.Text.Trim();

                if (!string.IsNullOrEmpty(playerName))
                {
                    
                    if (listBoxFantasyTeam.Items.Contains(playerName))
                    {
                        listBoxFantasyTeam.Items.Remove(playerName); 
                        txtRemovePlayer.Clear(); 

                        MessageBox.Show($"{playerName} has been removed from your Fantasy Cricket team ", "Player Removed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                     
                        MessageBox.Show("The entered player is not in your Fantasy Team ", "Wrong Player", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    
                    MessageBox.Show("Please enter a player's name before pressing Enter ", " Wrong Input", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
