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
    public partial class UpcomingMatches : Form
    {
        public UpcomingMatches()
        {
            InitializeComponent();
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnShowAllMatches_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();

            
            dataGridView1.Rows.Add("Feb 19, 2025", "Pakistan vs India", "Group A", "Rawalpindi Cricket Stadium");
            dataGridView1.Rows.Add("Feb 20, 2025", "New Zealand vs Bangladesh", "Group A", "Multan Cricket Stadium");
            dataGridView1.Rows.Add("Feb 23, 2025", "Pakistan vs New Zealand", "Group A", "Lahore Cricket Stadium");
            dataGridView1.Rows.Add("Feb 24, 2025", "India vs Bangladesh", "Group A", "Rawalpindi Cricket Stadium");
            dataGridView1.Rows.Add("Feb 27, 2025", "Pakistan vs Bangladesh", "Group A", "Multan Cricket Stadium");
            dataGridView1.Rows.Add("Feb 28, 2025", "India vs New Zealand", "Group A", "Lahore Cricket Stadium");

            
            dataGridView1.Rows.Add("Feb 19, 2025", "Australia vs England", "Group B", "Rawalpindi Cricket Stadium");
            dataGridView1.Rows.Add("Feb 21, 2025", "South Africa vs Afghanistan", "Group B", "Multan Cricket Stadium");
            dataGridView1.Rows.Add("Feb 25, 2025", "Australia vs South Africa", "Group B", "Lahore Cricket Stadium");
            dataGridView1.Rows.Add("Feb 26, 2025", "England vs Afghanistan", "Group B", "Rawalpindi Cricket Stadium");
            dataGridView1.Rows.Add("Mar 1, 2025", "Australia vs Afghanistan", "Group B", "Multan Cricket Stadium");
            dataGridView1.Rows.Add("Mar 2, 2025", "England vs South Africa", "Group B", "Lahore Cricket Stadium");

            
            dataGridView1.Rows.Add("Mar 6, 2025", "Group A Winner vs Group B Runner-up", "Semi-Final 1", "Lahore Cricket Stadium");
            dataGridView1.Rows.Add("Mar 7, 2025", "Group B Winner vs Group A Runner-up", "Semi-Final 2", "Rawalpindi Cricket Stadium");
            dataGridView1.Rows.Add("Mar 9, 2025", "Semi-Final 1 Winner vs Semi-Final 2 Winner", "Final", "Lahore Cricket Stadium");
        }

        private void btnBack_Click(object sender, EventArgs e)
        {

            this.Close();

            Menu MainMenu = new Menu();

            
            MainMenu.Show();

        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string teamName = txtTeamName.Text.ToLower();
                dataGridView1.Rows.Clear();

                if (teamName == "pakistan")
                {
                    dataGridView1.Rows.Add("Feb 19, 2025", "Pakistan vs India", "Group A", "Rawalpindi Cricket Stadium");
                    dataGridView1.Rows.Add("Feb 23, 2025", "Pakistan vs New Zealand", "Group A", "Lahore Cricket Stadium");
                    dataGridView1.Rows.Add("Feb 27, 2025", "Pakistan vs Bangladesh", "Group A", "Multan Cricket Stadium");
                    dataGridView1.Rows.Add("Mar 6, 2025", "Group A Winner vs Group B Runner-up", "Semi-Final 1", "Lahore Cricket Stadium");
                    dataGridView1.Rows.Add("Mar 7, 2025", "Group B Winner vs Group A Runner-up", "Semi-Final 2", "Rawalpindi Cricket Stadium");
                    dataGridView1.Rows.Add("Mar 9, 2025", "Semi-Final 1 Winner vs Semi-Final 2 Winner", "Final", "Lahore Cricket Stadium");
                }
                else if (teamName == "india")
                {
                    dataGridView1.Rows.Add("Feb 19, 2025", "India vs Pakistan", "Group A", "Rawalpindi Cricket Stadium");
                    dataGridView1.Rows.Add("Feb 24, 2025", "India vs Bangladesh", "Group A", "Lahore Cricket Stadium");
                    dataGridView1.Rows.Add("Feb 28, 2025", "India vs New Zealand", "Group A", "Multan Cricket Stadium");
                    dataGridView1.Rows.Add("Mar 6, 2025", "Group A Winner vs Group B Runner-up", "Semi-Final 1", "Lahore Cricket Stadium");
                    dataGridView1.Rows.Add("Mar 7, 2025", "Group B Winner vs Group A Runner-up", "Semi-Final 2", "Rawalpindi Cricket Stadium");
                    dataGridView1.Rows.Add("Mar 9, 2025", "Semi-Final 1 Winner vs Semi-Final 2 Winner", "Final", "Lahore Cricket Stadium");
                }
                else if (teamName == "new zealand")
                {
                    dataGridView1.Rows.Add("Feb 20, 2025", "New Zealand vs Bangladesh", "Group A", "Multan Cricket Stadium");
                    dataGridView1.Rows.Add("Feb 23, 2025", "New Zealand vs Pakistan", "Group A", "Rawalpindi Cricket Stadium");
                    dataGridView1.Rows.Add("Feb 28, 2025", "New Zealand vs India", "Group A", "Lahore Cricket Stadium");
                    dataGridView1.Rows.Add("Mar 6, 2025", "Group A Winner vs Group B Runner-up", "Semi-Final 1", "Lahore Cricket Stadium");
                    dataGridView1.Rows.Add("Mar 7, 2025", "Group B Winner vs Group A Runner-up", "Semi-Final 2", "Rawalpindi Cricket Stadium");
                    dataGridView1.Rows.Add("Mar 9, 2025", "Semi-Final 1 Winner vs Semi-Final 2 Winner", "Final", "Lahore Cricket Stadium");
                }
                else if (teamName == "bangladesh")
                {
                    dataGridView1.Rows.Add("Feb 20, 2025", "Bangladesh vs New Zealand", "Group A", "Multan Cricket Stadium");
                    dataGridView1.Rows.Add("Feb 24, 2025", "Bangladesh vs India", "Group A", "Rawalpindi Cricket Stadium");
                    dataGridView1.Rows.Add("Feb 27, 2025", "Bangladesh vs Pakistan", "Group A", "Lahore Cricket Stadium");
                    dataGridView1.Rows.Add("Mar 6, 2025", "Group A Winner vs Group B Runner-up", "Semi-Final 1", "Lahore Cricket Stadium");
                    dataGridView1.Rows.Add("Mar 7, 2025", "Group B Winner vs Group A Runner-up", "Semi-Final 2", "Rawalpindi Cricket Stadium");
                    dataGridView1.Rows.Add("Mar 9, 2025", "Semi-Final 1 Winner vs Semi-Final 2 Winner", "Final", "Lahore Cricket Stadium");
                }
                else if (teamName == "australia")
                {
                    dataGridView1.Rows.Add("Feb 19, 2025", "Australia vs England", "Group B", "Rawalpindi Cricket Stadium");
                    dataGridView1.Rows.Add("Feb 25, 2025", "Australia vs South Africa", "Group B", "Multan Cricket Stadium");
                    dataGridView1.Rows.Add("Mar 1, 2025", "Australia vs Afghanistan", "Group B", "Lahore Cricket Stadium");
                    dataGridView1.Rows.Add("Mar 6, 2025", "Group A Winner vs Group B Runner-up", "Semi-Final 1", "Lahore Cricket Stadium");
                    dataGridView1.Rows.Add("Mar 7, 2025", "Group B Winner vs Group A Runner-up", "Semi-Final 2", "Rawalpindi Cricket Stadium");
                    dataGridView1.Rows.Add("Mar 9, 2025", "Semi-Final 1 Winner vs Semi-Final 2 Winner", "Final", "Lahore Cricket Stadium");
                }
                else if (teamName == "england")
                {
                    dataGridView1.Rows.Add("Feb 19, 2025", "England vs Australia", "Group B", "Rawalpindi Cricket Stadium");
                    dataGridView1.Rows.Add("Feb 26, 2025", "England vs Afghanistan", "Group B", "Lahore Cricket Stadium");
                    dataGridView1.Rows.Add("Mar 2, 2025", "England vs South Africa", "Group B", "Multan Cricket Stadium");
                    dataGridView1.Rows.Add("Mar 6, 2025", "Group A Winner vs Group B Runner-up", "Semi-Final 1", "Lahore Cricket Stadium");
                    dataGridView1.Rows.Add("Mar 7, 2025", "Group B Winner vs Group A Runner-up", "Semi-Final 2", "Rawalpindi Cricket Stadium");
                    dataGridView1.Rows.Add("Mar 9, 2025", "Semi-Final 1 Winner vs Semi-Final 2 Winner", "Final", "Lahore Cricket Stadium");
                }
                else if (teamName == "south africa")
                {
                    dataGridView1.Rows.Add("Feb 21, 2025", "South Africa vs Afghanistan", "Group B", "Multan Cricket Stadium");
                    dataGridView1.Rows.Add("Feb 25, 2025", "South Africa vs Australia", "Group B", "Rawalpindi Cricket Stadium");
                    dataGridView1.Rows.Add("Mar 2, 2025", "South Africa vs England", "Group B", "Lahore Cricket Stadium");
                    dataGridView1.Rows.Add("Mar 6, 2025", "Group A Winner vs Group B Runner-up", "Semi-Final 1", "Lahore Cricket Stadium");
                    dataGridView1.Rows.Add("Mar 7, 2025", "Group B Winner vs Group A Runner-up", "Semi-Final 2", "Rawalpindi Cricket Stadium");
                    dataGridView1.Rows.Add("Mar 9, 2025", "Semi-Final 1 Winner vs Semi-Final 2 Winner", "Final", "Lahore Cricket Stadium");
                }
                else if (teamName == "afghanistan")
                {
                    dataGridView1.Rows.Add("Feb 21, 2025", "Afghanistan vs South Africa", "Group B", "Multan Cricket Stadium");
                    dataGridView1.Rows.Add("Feb 26, 2025", "Afghanistan vs England", "Group B", "Rawalpindi Cricket Stadium");
                    dataGridView1.Rows.Add("Mar 1, 2025", "Afghanistan vs Australia", "Group B", "Lahore Cricket Stadium");
                    dataGridView1.Rows.Add("Mar 6, 2025", "Group A Winner vs Group B Runner-up", "Semi-Final 1", "Lahore Cricket Stadium");
                    dataGridView1.Rows.Add("Mar 7, 2025", "Group B Winner vs Group A Runner-up", "Semi-Final 2", "Rawalpindi Cricket Stadium");
                    dataGridView1.Rows.Add("Mar 9, 2025", "Semi-Final 1 Winner vs Semi-Final 2 Winner", "Final", "Lahore Cricket Stadium");
                }
                else
                {
                    
                    MessageBox.Show("No matches found for the entered team.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }





        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}





