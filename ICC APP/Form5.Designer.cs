namespace ICC_APP
{
    partial class PlayerStatistics
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            ListboxAvailablePlayers = new ListBox();
            btnBatsmen = new Button();
            btnBowlers = new Button();
            btnAllRounders = new Button();
            btnBack = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(262, 9);
            label1.Name = "label1";
            label1.Size = new Size(275, 50);
            label1.TabIndex = 0;
            label1.Text = "Player Statistics";
            // 
            // ListboxAvailablePlayers
            // 
            ListboxAvailablePlayers.BackColor = Color.Blue;
            ListboxAvailablePlayers.ForeColor = SystemColors.Window;
            ListboxAvailablePlayers.FormattingEnabled = true;
            ListboxAvailablePlayers.ItemHeight = 15;
            ListboxAvailablePlayers.Location = new Point(198, 118);
            ListboxAvailablePlayers.Name = "ListboxAvailablePlayers";
            ListboxAvailablePlayers.Size = new Size(489, 304);
            ListboxAvailablePlayers.TabIndex = 4;
            // 
            // btnBatsmen
            // 
            btnBatsmen.BackColor = Color.Blue;
            btnBatsmen.ForeColor = SystemColors.Control;
            btnBatsmen.Location = new Point(12, 227);
            btnBatsmen.Name = "btnBatsmen";
            btnBatsmen.Size = new Size(138, 38);
            btnBatsmen.TabIndex = 5;
            btnBatsmen.Text = "View Batsmen Stats";
            btnBatsmen.UseVisualStyleBackColor = false;
            btnBatsmen.Click += btnBatsmen_Click;
            // 
            // btnBowlers
            // 
            btnBowlers.BackColor = Color.Blue;
            btnBowlers.ForeColor = SystemColors.ButtonHighlight;
            btnBowlers.Location = new Point(12, 166);
            btnBowlers.Name = "btnBowlers";
            btnBowlers.Size = new Size(138, 36);
            btnBowlers.TabIndex = 6;
            btnBowlers.Text = "View Bowler Stats";
            btnBowlers.UseVisualStyleBackColor = false;
            btnBowlers.Click += btnBowlers_Click;
            // 
            // btnAllRounders
            // 
            btnAllRounders.BackColor = Color.Blue;
            btnAllRounders.ForeColor = SystemColors.ButtonHighlight;
            btnAllRounders.Location = new Point(12, 297);
            btnAllRounders.Name = "btnAllRounders";
            btnAllRounders.Size = new Size(138, 38);
            btnAllRounders.TabIndex = 7;
            btnAllRounders.Text = "View All Rounder Stats";
            btnAllRounders.UseVisualStyleBackColor = false;
            btnAllRounders.Click += btnAllRounders_Click;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.Blue;
            btnBack.ForeColor = Color.White;
            btnBack.Location = new Point(22, 415);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(75, 23);
            btnBack.TabIndex = 8;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // PlayerStatistics
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Blue;
            ClientSize = new Size(800, 450);
            Controls.Add(btnBack);
            Controls.Add(btnAllRounders);
            Controls.Add(btnBowlers);
            Controls.Add(btnBatsmen);
            Controls.Add(ListboxAvailablePlayers);
            Controls.Add(label1);
            ForeColor = Color.White;
            Name = "PlayerStatistics";
            Text = "Player Statistics";
            Load += Form5_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox ListboxAvailablePlayers;
        private Button btnBatsmen;
        private Button btnBowlers;
        private Button btnAllRounders;
        private Button btnBack;
    }
}