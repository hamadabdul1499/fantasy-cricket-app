namespace ICC_APP
{
    partial class Menu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            btnUpcomingMatches = new Button();
            btnMatchResults = new Button();
            btnFantasyCricket = new Button();
            btnPlayerStats = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            label2 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.DodgerBlue;
            label1.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(192, 0, 0);
            label1.Location = new Point(12, 52);
            label1.Name = "label1";
            label1.Size = new Size(395, 50);
            label1.TabIndex = 0;
            label1.Text = "Welcome To The Cham";
            label1.Click += label1_Click;
            // 
            // btnUpcomingMatches
            // 
            btnUpcomingMatches.BackColor = Color.Green;
            btnUpcomingMatches.ForeColor = Color.White;
            btnUpcomingMatches.Location = new Point(305, 129);
            btnUpcomingMatches.Name = "btnUpcomingMatches";
            btnUpcomingMatches.Size = new Size(165, 44);
            btnUpcomingMatches.TabIndex = 1;
            btnUpcomingMatches.Text = "Upcoming Matches";
            btnUpcomingMatches.UseVisualStyleBackColor = false;
            btnUpcomingMatches.Click += btnUpcomingMatches_Click;
            // 
            // btnMatchResults
            // 
            btnMatchResults.BackColor = Color.FromArgb(128, 255, 255);
            btnMatchResults.ForeColor = Color.FromArgb(255, 128, 0);
            btnMatchResults.Location = new Point(305, 195);
            btnMatchResults.Name = "btnMatchResults";
            btnMatchResults.Size = new Size(165, 44);
            btnMatchResults.TabIndex = 2;
            btnMatchResults.Text = "Match Results";
            btnMatchResults.UseVisualStyleBackColor = false;
            btnMatchResults.Click += btnMatchResults_Click;
            // 
            // btnFantasyCricket
            // 
            btnFantasyCricket.BackColor = Color.FromArgb(0, 64, 0);
            btnFantasyCricket.ForeColor = Color.FromArgb(255, 128, 0);
            btnFantasyCricket.Location = new Point(305, 270);
            btnFantasyCricket.Name = "btnFantasyCricket";
            btnFantasyCricket.Size = new Size(165, 44);
            btnFantasyCricket.TabIndex = 3;
            btnFantasyCricket.Text = "Fantasy Cricket";
            btnFantasyCricket.UseVisualStyleBackColor = false;
            btnFantasyCricket.Click += btnFantasyCricket_Click;
            // 
            // btnPlayerStats
            // 
            btnPlayerStats.BackColor = Color.Blue;
            btnPlayerStats.ForeColor = Color.White;
            btnPlayerStats.Location = new Point(305, 339);
            btnPlayerStats.Name = "btnPlayerStats";
            btnPlayerStats.Size = new Size(165, 44);
            btnPlayerStats.TabIndex = 5;
            btnPlayerStats.Text = "Player Statistics";
            btnPlayerStats.UseVisualStyleBackColor = false;
            btnPlayerStats.Click += btnPlayerStats_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Green;
            label2.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(255, 255, 128);
            label2.Location = new Point(396, 52);
            label2.Name = "label2";
            label2.Size = new Size(402, 50);
            label2.TabIndex = 7;
            label2.Text = "pions Trophy 2025 App";
            label2.Click += label2_Click_1;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Cyan;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnUpcomingMatches);
            Controls.Add(btnPlayerStats);
            Controls.Add(btnMatchResults);
            Controls.Add(btnFantasyCricket);
            Name = "Menu";
            Text = "3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Button btnMatchResults;
        private Button btnFantasyCricket;
        private Button btnPlayerStats;
        private GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button btnUpcomingMatches;
        private Label label2;
    }
}
