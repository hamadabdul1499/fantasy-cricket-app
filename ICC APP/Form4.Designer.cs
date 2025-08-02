namespace ICC_APP
{
    partial class FantasyCricket
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
            listBoxAvailablePlayers = new ListBox();
            txtUsername = new TextBox();
            label2 = new Label();
            btnSave = new Button();
            btnLoadBatsmen = new Button();
            listBoxFantasyTeam = new ListBox();
            label3 = new Label();
            btnLoadBowlers = new Button();
            btnAllRounders = new Button();
            txtPlayerName = new TextBox();
            btnLoadTeam = new Button();
            btnBack = new Button();
            label4 = new Label();
            txtRemovePlayer = new TextBox();
            label5 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 27.75F);
            label1.ForeColor = Color.FromArgb(255, 128, 0);
            label1.Location = new Point(266, 9);
            label1.Name = "label1";
            label1.Size = new Size(267, 50);
            label1.TabIndex = 0;
            label1.Text = "Fantasy Cricket";
            // 
            // listBoxAvailablePlayers
            // 
            listBoxAvailablePlayers.FormattingEnabled = true;
            listBoxAvailablePlayers.ItemHeight = 15;
            listBoxAvailablePlayers.Location = new Point(643, 98);
            listBoxAvailablePlayers.Name = "listBoxAvailablePlayers";
            listBoxAvailablePlayers.Size = new Size(156, 349);
            listBoxAvailablePlayers.TabIndex = 1;
            // 
            // txtUsername
            // 
            txtUsername.BackColor = Color.FromArgb(0, 64, 0);
            txtUsername.ForeColor = Color.FromArgb(255, 128, 0);
            txtUsername.Location = new Point(145, 77);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(100, 23);
            txtUsername.TabIndex = 2;
            txtUsername.KeyDown += txtUsername_KeyDown;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.FromArgb(255, 128, 0);
            label2.Location = new Point(12, 80);
            label2.Name = "label2";
            label2.Size = new Size(117, 15);
            label2.TabIndex = 3;
            label2.Text = "Enter Your Username";
            label2.Click += label2_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(255, 128, 0);
            btnSave.ForeColor = Color.FromArgb(0, 64, 0);
            btnSave.Location = new Point(347, 407);
            btnSave.Name = "btnSave";
            btnSave.RightToLeft = RightToLeft.No;
            btnSave.Size = new Size(91, 31);
            btnSave.TabIndex = 4;
            btnSave.Text = "Save Team";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnLoadBatsmen
            // 
            btnLoadBatsmen.BackColor = Color.FromArgb(255, 128, 0);
            btnLoadBatsmen.Location = new Point(643, 69);
            btnLoadBatsmen.Name = "btnLoadBatsmen";
            btnLoadBatsmen.Size = new Size(156, 23);
            btnLoadBatsmen.TabIndex = 5;
            btnLoadBatsmen.Text = "Load Available Batsmen";
            btnLoadBatsmen.UseVisualStyleBackColor = false;
            btnLoadBatsmen.Click += btnLoadBatsmen_Click;
            // 
            // listBoxFantasyTeam
            // 
            listBoxFantasyTeam.AccessibleName = "";
            listBoxFantasyTeam.FormattingEnabled = true;
            listBoxFantasyTeam.ItemHeight = 15;
            listBoxFantasyTeam.Location = new Point(470, 98);
            listBoxFantasyTeam.Name = "listBoxFantasyTeam";
            listBoxFantasyTeam.Size = new Size(156, 349);
            listBoxFantasyTeam.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.FromArgb(255, 128, 0);
            label3.Location = new Point(12, 125);
            label3.Name = "label3";
            label3.Size = new Size(315, 15);
            label3.TabIndex = 7;
            label3.Text = "Enter The Name Of The Player That You Would Like To Add";
            // 
            // btnLoadBowlers
            // 
            btnLoadBowlers.BackColor = Color.FromArgb(255, 128, 0);
            btnLoadBowlers.Location = new Point(643, 40);
            btnLoadBowlers.Name = "btnLoadBowlers";
            btnLoadBowlers.Size = new Size(156, 23);
            btnLoadBowlers.TabIndex = 8;
            btnLoadBowlers.Text = "Load Available Bowler";
            btnLoadBowlers.UseVisualStyleBackColor = false;
            btnLoadBowlers.Click += btnLoadBowlers_Click;
            // 
            // btnAllRounders
            // 
            btnAllRounders.BackColor = Color.FromArgb(255, 128, 0);
            btnAllRounders.Location = new Point(618, 12);
            btnAllRounders.Name = "btnAllRounders";
            btnAllRounders.Size = new Size(181, 23);
            btnAllRounders.TabIndex = 9;
            btnAllRounders.Text = "Load Available All Rounders";
            btnAllRounders.UseVisualStyleBackColor = false;
            btnAllRounders.Click += btnAllRounders_Click;
            // 
            // txtPlayerName
            // 
            txtPlayerName.BackColor = Color.FromArgb(0, 64, 0);
            txtPlayerName.ForeColor = Color.FromArgb(255, 128, 0);
            txtPlayerName.Location = new Point(333, 122);
            txtPlayerName.Name = "txtPlayerName";
            txtPlayerName.Size = new Size(100, 23);
            txtPlayerName.TabIndex = 10;
            txtPlayerName.KeyDown += txtPlayerName_KeyDown;
            // 
            // btnLoadTeam
            // 
            btnLoadTeam.BackColor = Color.FromArgb(255, 128, 0);
            btnLoadTeam.Location = new Point(266, 72);
            btnLoadTeam.Name = "btnLoadTeam";
            btnLoadTeam.Size = new Size(95, 30);
            btnLoadTeam.TabIndex = 11;
            btnLoadTeam.Text = "Load Team";
            btnLoadTeam.UseVisualStyleBackColor = false;
            btnLoadTeam.Click += btnLoadTeam_Click;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.FromArgb(255, 128, 0);
            btnBack.Location = new Point(12, 407);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(79, 31);
            btnBack.TabIndex = 12;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(255, 128, 0);
            label4.Location = new Point(12, 167);
            label4.Name = "label4";
            label4.Size = new Size(297, 20);
            label4.TabIndex = 13;
            label4.Text = "Press Enter To Add The Player To Your Team";
            // 
            // txtRemovePlayer
            // 
            txtRemovePlayer.BackColor = Color.FromArgb(0, 64, 0);
            txtRemovePlayer.ForeColor = Color.FromArgb(255, 128, 0);
            txtRemovePlayer.Location = new Point(347, 225);
            txtRemovePlayer.Name = "txtRemovePlayer";
            txtRemovePlayer.Size = new Size(100, 23);
            txtRemovePlayer.TabIndex = 14;
            txtRemovePlayer.TextChanged += txtRemovePlayer_TextChanged;
            txtRemovePlayer.KeyDown += txtRemovePlayer_KeyDown;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.FromArgb(255, 128, 0);
            label5.Location = new Point(5, 233);
            label5.Name = "label5";
            label5.Size = new Size(336, 15);
            label5.TabIndex = 15;
            label5.Text = "Enter The Name Of The Player That You Would Like To Remove";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.FromArgb(255, 128, 0);
            label6.Location = new Point(37, 271);
            label6.Name = "label6";
            label6.Size = new Size(208, 15);
            label6.TabIndex = 16;
            label6.Text = "Make Sure You Put The Correct Name ";
            // 
            // FantasyCricket
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 64, 0);
            ClientSize = new Size(800, 450);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(txtRemovePlayer);
            Controls.Add(label4);
            Controls.Add(btnBack);
            Controls.Add(btnLoadTeam);
            Controls.Add(txtPlayerName);
            Controls.Add(btnAllRounders);
            Controls.Add(btnLoadBowlers);
            Controls.Add(label3);
            Controls.Add(listBoxFantasyTeam);
            Controls.Add(btnLoadBatsmen);
            Controls.Add(btnSave);
            Controls.Add(label2);
            Controls.Add(txtUsername);
            Controls.Add(listBoxAvailablePlayers);
            Controls.Add(label1);
            ForeColor = Color.FromArgb(0, 64, 0);
            Name = "FantasyCricket";
            Text = "Fantasy Cricket";
            Load += Form4_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox listBoxAvailablePlayers;
        private TextBox txtUsername;
        private Label label2;
        private Button btnSave;
        private Button btnLoadBatsmen;
        private ListBox listBoxFantasyTeam;
        private Label label3;
        private Button btnLoadBowlers;
        private Button btnAllRounders;
        private TextBox txtPlayerName;
        private Button btnLoadTeam;
        private Button btnBack;
        private Label label4;
        private TextBox txtRemovePlayer;
        private Label label5;
        private Label label6;
    }
}