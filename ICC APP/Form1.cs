namespace ICC_APP
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void btnUpcomingMatches_Click(object sender, EventArgs e)
        {
            this.Hide();


            UpcomingMatches UpcomingMatches = new UpcomingMatches();
            UpcomingMatches.Show();

        }
        private void btnMatchResults_Click(object sender, EventArgs e)
        {
            this.Hide();

            MatchResults MatchResults = new MatchResults();
            MatchResults.Show();

        }

        private void btnFantasyCricket_Click(object sender, EventArgs e)
        {
            this.Hide();

            FantasyCricket FantasyCricket = new FantasyCricket();
            FantasyCricket.Show();
        }

        private void btnSearchMatch_Click(object sender, EventArgs e)
        {

        }

        private void btnPlayerStats_Click(object sender, EventArgs e)
        {
            this.Hide();

            PlayerStatistics PlayerStatistics = new PlayerStatistics();
            PlayerStatistics.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }


        private void label2_Click_1(object sender, EventArgs e)
        {

        }
    }
}
