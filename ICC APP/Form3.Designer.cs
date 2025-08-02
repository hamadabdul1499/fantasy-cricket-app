namespace ICC_APP
{
    partial class MatchResults
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
            lblMatchResults = new Label();
            btnMatchResults = new Button();
            txtTeamName = new TextBox();
            label1 = new Label();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            Date = new DataGridViewTextBoxColumn();
            Match = new DataGridViewTextBoxColumn();
            Stage = new DataGridViewTextBoxColumn();
            Location = new DataGridViewTextBoxColumn();
            Result = new DataGridViewTextBoxColumn();
            btnBack = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // lblMatchResults
            // 
            lblMatchResults.AutoSize = true;
            lblMatchResults.BackColor = Color.Cyan;
            lblMatchResults.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMatchResults.ForeColor = Color.FromArgb(255, 128, 0);
            lblMatchResults.Location = new Point(305, 9);
            lblMatchResults.Name = "lblMatchResults";
            lblMatchResults.Size = new Size(250, 50);
            lblMatchResults.TabIndex = 0;
            lblMatchResults.Text = "Match Results";
            lblMatchResults.Click += lblMatchResults_Click;
            // 
            // btnMatchResults
            // 
            btnMatchResults.BackColor = Color.Aqua;
            btnMatchResults.ForeColor = Color.FromArgb(255, 128, 0);
            btnMatchResults.Location = new Point(488, 73);
            btnMatchResults.Name = "btnMatchResults";
            btnMatchResults.Size = new Size(242, 45);
            btnMatchResults.TabIndex = 1;
            btnMatchResults.Text = "View Match Results";
            btnMatchResults.UseVisualStyleBackColor = false;
            btnMatchResults.Click += btnMatchResults_Click;
            // 
            // txtTeamName
            // 
            txtTeamName.Location = new Point(235, 84);
            txtTeamName.Name = "txtTeamName";
            txtTeamName.Size = new Size(100, 23);
            txtTeamName.TabIndex = 2;
            txtTeamName.TextChanged += textBox1_TextChanged;
            txtTeamName.KeyDown += txtTeamName_KeyDown;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.FromArgb(255, 128, 0);
            label1.Location = new Point(56, 87);
            label1.Name = "label1";
            label1.Size = new Size(160, 15);
            label1.TabIndex = 3;
            label1.Text = "Enter The Name Of The Team";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.FromArgb(255, 128, 0);
            label2.Location = new Point(403, 88);
            label2.Name = "label2";
            label2.Size = new Size(23, 15);
            label2.TabIndex = 4;
            label2.Text = "OR";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.FromArgb(128, 255, 255);
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Date, Match, Stage, Location, Result });
            dataGridView1.GridColor = SystemColors.WindowText;
            dataGridView1.Location = new Point(12, 157);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(797, 150);
            dataGridView1.TabIndex = 5;
            // 
            // Date
            // 
            Date.HeaderText = "Date";
            Date.Name = "Date";
            Date.Width = 75;
            // 
            // Match
            // 
            Match.HeaderText = "Match";
            Match.Name = "Match";
            Match.Width = 250;
            // 
            // Stage
            // 
            Stage.HeaderText = "Stage";
            Stage.Name = "Stage";
            Stage.Width = 85;
            // 
            // Location
            // 
            Location.HeaderText = "Location";
            Location.Name = "Location";
            Location.Width = 180;
            // 
            // Result
            // 
            Result.HeaderText = "Result";
            Result.Name = "Result";
            Result.Width = 170;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(22, 400);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(75, 23);
            btnBack.TabIndex = 6;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // MatchResults
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Aqua;
            ClientSize = new Size(821, 450);
            Controls.Add(btnBack);
            Controls.Add(dataGridView1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtTeamName);
            Controls.Add(lblMatchResults);
            Controls.Add(btnMatchResults);
            Name = "MatchResults";
            Text = "Match Results";
            Load += Form3_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMatchResults;
        private Button btnMatchResults;
        private TextBox txtTeamName;
        private Label label1;
        private Label label2;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Date;
        private DataGridViewTextBoxColumn Match;
        private DataGridViewTextBoxColumn Stage;
        private DataGridViewTextBoxColumn Location;
        private DataGridViewTextBoxColumn Result;
        private Button btnBack;
    }
}