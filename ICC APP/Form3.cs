using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ICC_APP
{
    public partial class MatchResults : Form
    {
        public MatchResults()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void lblMatchResults_Click(object sender, EventArgs e)
        {

        }

        private void btnMatchResults_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();


            dataGridView1.Rows.Add("Feb 19, 2025", "Pakistan vs India", "Group A", "Rawalpindi Cricket Stadium", "Pak beat Ind by 3 wickets");
            dataGridView1.Rows.Add("Feb 20, 2025", "New Zealand vs Bangladesh", "Group A", "Multan Cricket Stadium", "NZ beat Ban by 99 runs");
            dataGridView1.Rows.Add("Feb 23, 2025", "Pakistan vs New Zealand", "Group A", "Lahore Cricket Stadium", "Pak beat NZ by 46 runs");
            dataGridView1.Rows.Add("Feb 24, 2025", "India vs Bangladesh", "Group A", "Rawalpindi Cricket Stadium", "Ind beat Ban by 163 runs");
            dataGridView1.Rows.Add("Feb 27, 2025", "Pakistan vs Bangladesh", "Group A", "Multan Cricket Stadium", "Pak  beat Ban by 8 runs");
            dataGridView1.Rows.Add("Feb 28, 2025", "India vs New Zealand", "Group A", "Lahore Cricket Stadium", "Ind beat NZ by 16 runs");


            dataGridView1.Rows.Add("Feb 19, 2025", "Australia vs England", "Group B", "Rawalpindi Cricket Stadium", "Aus beat Eng by 79 runs");
            dataGridView1.Rows.Add("Feb 21, 2025", "South Africa vs Afghanistan", "Group B", "Multan Cricket Stadium", "SA beat Afg by 6 wickets");
            dataGridView1.Rows.Add("Feb 25, 2025", "Australia vs South Africa", "Group B", "Lahore Cricket Stadium", "Aus beat SA by 55 runs");
            dataGridView1.Rows.Add("Feb 26, 2025", "England vs Afghanistan", "Group B", "Rawalpindi Cricket Stadium", "Afg beat Eng by 102 runs");
            dataGridView1.Rows.Add("Mar 1, 2025", "Australia vs Afghanistan", "Group B", "Multan Cricket Stadium", "Aus beat Afg by 17 runs");
            dataGridView1.Rows.Add("Mar 2, 2025", "England vs South Africa", "Group B", "Lahore Cricket Stadium", "SA beat Eng by 1 wickets");


            dataGridView1.Rows.Add("Mar 6, 2025", "Pakistan vs South Africa", "Semi-Final 1", "Lahore Cricket Stadium", "TBA");
            dataGridView1.Rows.Add("Mar 7, 2025", "Australia vs India", "Semi-Final 2", "Rawalpindi Cricket Stadium", "TBA");
            dataGridView1.Rows.Add("Mar 9, 2025", "Semi-Final 1 Winner vs Semi-Final 2 Winner", "Final", "Lahore Cricket Stadium", "TBA");
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTeamName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string teamName = txtTeamName.Text.ToLower();
                dataGridView1.Rows.Clear();

                if (teamName == "pakistan")
                {
                    dataGridView1.Rows.Add("Feb 19, 2025", "Pakistan vs India", "Group A", "Rawalpindi Cricket Stadium", "Pak beat Ind by 3 wickets");
                    dataGridView1.Rows.Add("Feb 23, 2025", "Pakistan vs New Zealand", "Group A", "Lahore Cricket Stadium", "Pak beat NZ by 46 runs");
                    dataGridView1.Rows.Add("Feb 27, 2025", "Pakistan vs Bangladesh", "Group A", "Multan Cricket Stadium", "Pak  beat Ban by 8 runs");
                    dataGridView1.Rows.Add("Mar 6, 2025", "Pakistan vs South Africa", "Semi-Final 1", "Lahore Cricket Stadium", "TBA");
                    dataGridView1.Rows.Add("Mar 9, 2025", "Semi-Final 1 Winner vs Semi-Final 2 Winner", "Final", "Lahore Cricket Stadium");
                }
                else if (teamName == "india")
                {
                    dataGridView1.Rows.Add("Feb 19, 2025", "India vs Pakistan", "Group A", "Rawalpindi Cricket Stadium", "Pak beat Ind by 3 wickets");
                    dataGridView1.Rows.Add("Feb 24, 2025", "India vs Bangladesh", "Group A", "Lahore Cricket Stadium", "Ind beat Ban by 163 runs");
                    dataGridView1.Rows.Add("Feb 28, 2025", "India vs New Zealand", "Group A", "Multan Cricket Stadium", "Ind beat NZ by 16 runs");
                    dataGridView1.Rows.Add("Mar 7, 2025", "India vs Australia", "Semi-Final 2", "Rawalpindi Cricket Stadium", "TBA");
                    dataGridView1.Rows.Add("Mar 9, 2025", "Semi-Final 1 Winner vs Semi-Final 2 Winner", "Final", "Lahore Cricket Stadium");
                }
                else if (teamName == "new zealand")
                {
                    dataGridView1.Rows.Add("Feb 20, 2025", "New Zealand vs Bangladesh", "Group A", "Multan Cricket Stadium", "NZ beat Ban by 99 runs");
                    dataGridView1.Rows.Add("Feb 23, 2025", "New Zealand vs Pakistan", "Group A", "Rawalpindi Cricket Stadium", "Pak beat NZ by 46 runs");
                    dataGridView1.Rows.Add("Feb 28, 2025", "New Zealand vs India", "Group A", "Lahore Cricket Stadium", "Ind beat NZ by 16 runs");
                    dataGridView1.Rows.Add("Did", "Not", "Qualify", "For Semi Final");
                }
                else if (teamName == "bangladesh")
                {
                    dataGridView1.Rows.Add("Feb 20, 2025", "Bangladesh vs New Zealand", "Group A", "Multan Cricket Stadium", "NZ beat Ban by 99 runs");
                    dataGridView1.Rows.Add("Feb 24, 2025", "Bangladesh vs India", "Group A", "Rawalpindi Cricket Stadium", "Ind beat Ban by 163 runs");
                    dataGridView1.Rows.Add("Feb 27, 2025", "Bangladesh vs Pakistan", "Group A", "Lahore Cricket Stadium", "Pak beat Ban by 8 runs");
                    dataGridView1.Rows.Add("Did", "Not", "Qualify", "For Semi Final");
                }
                else if (teamName == "australia")
                {
                    dataGridView1.Rows.Add("Feb 19, 2025", "Australia vs England", "Group B", "Rawalpindi Cricket Stadium", "Aus beat Eng by 79 runs");
                    dataGridView1.Rows.Add("Feb 25, 2025", "Australia vs South Africa", "Group B", "Multan Cricket Stadium", "Aus beat SA by 55 runs");
                    dataGridView1.Rows.Add("Mar 1, 2025", "Australia vs Afghanistan", "Group B", "Lahore Cricket Stadium", "Aus beat Afg by 17 runs");
                    dataGridView1.Rows.Add("Mar 7, 2025", "Australia vs India", "Semi-Final 2", "Rawalpindi Cricket Stadium", "TBA");
                    dataGridView1.Rows.Add("Mar 9, 2025", "Semi-Final 1 Winner vs Semi-Final 2 Winner", "Final", "Lahore Cricket Stadium");
                }
                else if (teamName == "england")
                {
                    dataGridView1.Rows.Add("Feb 19, 2025", "England vs Australia", "Group B", "Rawalpindi Cricket Stadium", "Aus beat Eng by 79 runs");
                    dataGridView1.Rows.Add("Feb 26, 2025", "England vs Afghanistan", "Group B", "Lahore Cricket Stadium", "Afg beat Eng by 102 runs");
                    dataGridView1.Rows.Add("Mar 2, 2025", "England vs South Africa", "Group B", "Multan Cricket Stadium", "SA beat Eng by 1 wickets");
                    dataGridView1.Rows.Add("Did", "Not", "Qualify", "For Semi Final");
                }
                else if (teamName == "south africa")
                {
                    dataGridView1.Rows.Add("Feb 21, 2025", "South Africa vs Afghanistan", "Group B", "Multan Cricket Stadium", "SA beat Afg by 6 wickets");
                    dataGridView1.Rows.Add("Feb 25, 2025", "South Africa vs Australia", "Group B", "Rawalpindi Cricket Stadium", "Aus beat SA by 55 runs");
                    dataGridView1.Rows.Add("Mar 2, 2025", "South Africa vs England", "Group B", "Lahore Cricket Stadium", "SA beat Eng by 1 wickets");
                    dataGridView1.Rows.Add("Mar 6, 2025", "South Africa vs Pakistan", "Semi-Final 1", "Lahore Cricket Stadium", "TBA");
                    dataGridView1.Rows.Add("Mar 9, 2025", "Semi-Final 1 Winner vs Semi-Final 2 Winner", "Final", "Lahore Cricket Stadium");
                }
                else if (teamName == "afghanistan")
                {
                    dataGridView1.Rows.Add("Feb 21, 2025", "Afghanistan vs South Africa", "Group B", "Multan Cricket Stadium", "SA beat Afg by 6 wickets");
                    dataGridView1.Rows.Add("Feb 26, 2025", "Afghanistan vs England", "Group B", "Rawalpindi Cricket Stadium", "Afg beat Eng by 102 runs");
                    dataGridView1.Rows.Add("Mar 1, 2025", "Afghanistan vs Australia", "Group B", "Lahore Cricket Stadium", "Aus beat Afg by 17 runs");
                    dataGridView1.Rows.Add("Did", "Not", "Qualify", "For Semi Final");
                }
                else
                {

                    MessageBox.Show("No result found for the entered team.", "Team", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();

            Menu MainMenu = new Menu();


            MainMenu.Show();

        }
    }
}

