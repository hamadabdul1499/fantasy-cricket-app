namespace ICC_APP
{
    partial class UpcomingMatches
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
            txtTeamName = new TextBox();
            label2 = new Label();
            btnShowAllMatches = new Button();
            label3 = new Label();
            btnBack = new Button();
            dataGridView1 = new DataGridView();
            Date = new DataGridViewTextBoxColumn();
            Match = new DataGridViewTextBoxColumn();
            Stage = new DataGridViewTextBoxColumn();
            Location = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Green;
            label1.ForeColor = Color.White;
            label1.Location = new Point(39, 90);
            label1.Name = "label1";
            label1.Size = new Size(160, 15);
            label1.TabIndex = 0;
            label1.Text = "Enter The Name Of The Team";
            label1.Click += label1_Click;
            // 
            // txtTeamName
            // 
            txtTeamName.BackColor = Color.White;
            txtTeamName.Location = new Point(219, 87);
            txtTeamName.Name = "txtTeamName";
            txtTeamName.Size = new Size(132, 23);
            txtTeamName.TabIndex = 1;
            txtTeamName.Text = "Team Name.............";
            txtTeamName.TextChanged += textBox1_TextChanged;
            txtTeamName.KeyDown += textBox1_KeyDown;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Green;
            label2.ForeColor = Color.White;
            label2.Location = new Point(387, 90);
            label2.Name = "label2";
            label2.Size = new Size(23, 15);
            label2.TabIndex = 2;
            label2.Text = "OR";
            // 
            // btnShowAllMatches
            // 
            btnShowAllMatches.BackColor = Color.Green;
            btnShowAllMatches.ForeColor = Color.White;
            btnShowAllMatches.Location = new Point(441, 73);
            btnShowAllMatches.Name = "btnShowAllMatches";
            btnShowAllMatches.Size = new Size(289, 48);
            btnShowAllMatches.TabIndex = 3;
            btnShowAllMatches.Text = "View All Upcoming Matches";
            btnShowAllMatches.UseVisualStyleBackColor = false;
            btnShowAllMatches.Click += btnShowAllMatches_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.Info;
            label3.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Green;
            label3.Location = new Point(228, 9);
            label3.Name = "label3";
            label3.Size = new Size(340, 50);
            label3.TabIndex = 4;
            label3.Text = "Upcoming Matches";
            label3.Click += label3_Click;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(39, 382);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(85, 34);
            btnBack.TabIndex = 5;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Date, Match, Stage, Location });
            dataGridView1.Location = new Point(39, 176);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(731, 135);
            dataGridView1.TabIndex = 6;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Date
            // 
            Date.HeaderText = "Date";
            Date.Name = "Date";
            // 
            // Match
            // 
            Match.HeaderText = "Match";
            Match.Name = "Match";
            Match.Width = 260;
            // 
            // Stage
            // 
            Stage.HeaderText = "Stage";
            Stage.Name = "Stage";
            // 
            // Location
            // 
            Location.HeaderText = "Location ";
            Location.Name = "Location";
            Location.Width = 230;
            // 
            // UpcomingMatches
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Green;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(btnBack);
            Controls.Add(label3);
            Controls.Add(btnShowAllMatches);
            Controls.Add(label2);
            Controls.Add(txtTeamName);
            Controls.Add(label1);
            Name = "UpcomingMatches";
            Text = "Upcoming Matches";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtTeamName;
        private Label label2;
        private Button btnShowAllMatches;
        private Label label3;
        private Button btnBack;
        private ListBox listBox1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Date;
        private DataGridViewTextBoxColumn Match;
        private DataGridViewTextBoxColumn Stage;
        private DataGridViewTextBoxColumn Location;
    }
}