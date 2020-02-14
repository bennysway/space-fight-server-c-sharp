namespace SpaceFightServer
{
    partial class DatabaseControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.playerDetailsBut = new System.Windows.Forms.Button();
            this.playerDelete = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.refreshDatabase = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.addPlayerBut = new System.Windows.Forms.Button();
            this.playerList = new System.Windows.Forms.ListView();
            this.DetailsPanel = new System.Windows.Forms.Panel();
            this.BannedLabel = new System.Windows.Forms.Label();
            this.RankLabel = new System.Windows.Forms.Label();
            this.MapLabel = new System.Windows.Forms.Label();
            this.HealthLabel = new System.Windows.Forms.Label();
            this.AmmoLabel = new System.Windows.Forms.Label();
            this.OnlineStatusLabel = new System.Windows.Forms.Label();
            this.ScoreLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.subtitlelabel = new System.Windows.Forms.Label();
            this.playerName = new System.Windows.Forms.Label();
            this.DeselectButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.DetailsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = global::SpaceFightServer.Properties.Resources.clients_32;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(32, 187);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 40);
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // playerDetailsBut
            // 
            this.playerDetailsBut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(110)))), ((int)(((byte)(36)))), ((int)(((byte)(1)))));
            this.playerDetailsBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.playerDetailsBut.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerDetailsBut.ForeColor = System.Drawing.Color.White;
            this.playerDetailsBut.Location = new System.Drawing.Point(152, 367);
            this.playerDetailsBut.Name = "playerDetailsBut";
            this.playerDetailsBut.Size = new System.Drawing.Size(121, 38);
            this.playerDetailsBut.TabIndex = 10;
            this.playerDetailsBut.Text = "Details";
            this.playerDetailsBut.UseVisualStyleBackColor = false;
            this.playerDetailsBut.Click += new System.EventHandler(this.playerDetailsBut_Click);
            // 
            // playerDelete
            // 
            this.playerDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(80)))), ((int)(((byte)(66)))), ((int)(((byte)(1)))));
            this.playerDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.playerDelete.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerDelete.ForeColor = System.Drawing.Color.White;
            this.playerDelete.Location = new System.Drawing.Point(279, 367);
            this.playerDelete.Name = "playerDelete";
            this.playerDelete.Size = new System.Drawing.Size(87, 38);
            this.playerDelete.TabIndex = 15;
            this.playerDelete.Text = "Delete";
            this.playerDelete.UseVisualStyleBackColor = false;
            this.playerDelete.Click += new System.EventHandler(this.playerDelete_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(80)))), ((int)(((byte)(66)))), ((int)(((byte)(1)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(372, 367);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(87, 38);
            this.button4.TabIndex = 14;
            this.button4.Text = "Password";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(80)))), ((int)(((byte)(66)))), ((int)(((byte)(1)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(465, 367);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(87, 38);
            this.button3.TabIndex = 13;
            this.button3.Text = "Ban";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(80)))), ((int)(((byte)(66)))), ((int)(((byte)(1)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(558, 367);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(87, 38);
            this.button2.TabIndex = 12;
            this.button2.Text = "Message";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(80)))), ((int)(((byte)(66)))), ((int)(((byte)(1)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(651, 367);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 38);
            this.button1.TabIndex = 11;
            this.button1.Text = "Control";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // refreshDatabase
            // 
            this.refreshDatabase.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.refreshDatabase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refreshDatabase.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refreshDatabase.Image = global::SpaceFightServer.Properties.Resources.db_sync_32;
            this.refreshDatabase.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.refreshDatabase.Location = new System.Drawing.Point(527, 190);
            this.refreshDatabase.Name = "refreshDatabase";
            this.refreshDatabase.Size = new System.Drawing.Size(210, 55);
            this.refreshDatabase.TabIndex = 16;
            this.refreshDatabase.Text = "Refresh";
            this.refreshDatabase.UseVisualStyleBackColor = false;
            this.refreshDatabase.Click += new System.EventHandler(this.refreshDatabase_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Khaki;
            this.label3.Location = new System.Drawing.Point(27, 223);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 25);
            this.label3.TabIndex = 17;
            this.label3.Text = "Players";
            // 
            // addPlayerBut
            // 
            this.addPlayerBut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(100)))), ((int)(((byte)(126)))), ((int)(((byte)(1)))));
            this.addPlayerBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addPlayerBut.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPlayerBut.ForeColor = System.Drawing.Color.White;
            this.addPlayerBut.Location = new System.Drawing.Point(32, 251);
            this.addPlayerBut.Name = "addPlayerBut";
            this.addPlayerBut.Size = new System.Drawing.Size(117, 111);
            this.addPlayerBut.TabIndex = 18;
            this.addPlayerBut.Text = "Add Player...";
            this.addPlayerBut.UseVisualStyleBackColor = false;
            this.addPlayerBut.Click += new System.EventHandler(this.addPlayerBut_Click);
            // 
            // playerList
            // 
            this.playerList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(56)))), ((int)(((byte)(0)))));
            this.playerList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.playerList.Location = new System.Drawing.Point(152, 251);
            this.playerList.MultiSelect = false;
            this.playerList.Name = "playerList";
            this.playerList.OwnerDraw = true;
            this.playerList.Size = new System.Drawing.Size(586, 111);
            this.playerList.TabIndex = 24;
            this.playerList.Tag = "";
            this.playerList.UseCompatibleStateImageBehavior = false;
            this.playerList.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.playerList_ItemSelectionChanged);
            this.playerList.SelectedIndexChanged += new System.EventHandler(this.playerList_SelectedIndexChanged);
            this.playerList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.playerList_MouseDoubleClick);
            // 
            // DetailsPanel
            // 
            this.DetailsPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(28)))), ((int)(((byte)(74)))));
            this.DetailsPanel.Controls.Add(this.BannedLabel);
            this.DetailsPanel.Controls.Add(this.RankLabel);
            this.DetailsPanel.Controls.Add(this.MapLabel);
            this.DetailsPanel.Controls.Add(this.HealthLabel);
            this.DetailsPanel.Controls.Add(this.AmmoLabel);
            this.DetailsPanel.Controls.Add(this.OnlineStatusLabel);
            this.DetailsPanel.Controls.Add(this.ScoreLabel);
            this.DetailsPanel.Controls.Add(this.label6);
            this.DetailsPanel.Controls.Add(this.label5);
            this.DetailsPanel.Controls.Add(this.label4);
            this.DetailsPanel.Controls.Add(this.label2);
            this.DetailsPanel.Controls.Add(this.label1);
            this.DetailsPanel.Controls.Add(this.subtitlelabel);
            this.DetailsPanel.Controls.Add(this.playerName);
            this.DetailsPanel.Location = new System.Drawing.Point(89, 3);
            this.DetailsPanel.Name = "DetailsPanel";
            this.DetailsPanel.Size = new System.Drawing.Size(432, 242);
            this.DetailsPanel.TabIndex = 25;
            this.DetailsPanel.Visible = false;
            // 
            // BannedLabel
            // 
            this.BannedLabel.AutoSize = true;
            this.BannedLabel.BackColor = System.Drawing.Color.Transparent;
            this.BannedLabel.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BannedLabel.ForeColor = System.Drawing.Color.Red;
            this.BannedLabel.Location = new System.Drawing.Point(351, 5);
            this.BannedLabel.Name = "BannedLabel";
            this.BannedLabel.Size = new System.Drawing.Size(68, 25);
            this.BannedLabel.TabIndex = 16;
            this.BannedLabel.Text = "BANNED!";
            // 
            // RankLabel
            // 
            this.RankLabel.AutoSize = true;
            this.RankLabel.BackColor = System.Drawing.Color.Transparent;
            this.RankLabel.Font = new System.Drawing.Font("Agency FB", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RankLabel.ForeColor = System.Drawing.Color.DodgerBlue;
            this.RankLabel.Location = new System.Drawing.Point(84, 158);
            this.RankLabel.Name = "RankLabel";
            this.RankLabel.Size = new System.Drawing.Size(36, 45);
            this.RankLabel.TabIndex = 15;
            this.RankLabel.Text = "3";
            // 
            // MapLabel
            // 
            this.MapLabel.AutoSize = true;
            this.MapLabel.BackColor = System.Drawing.Color.Transparent;
            this.MapLabel.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MapLabel.ForeColor = System.Drawing.Color.DodgerBlue;
            this.MapLabel.Location = new System.Drawing.Point(84, 83);
            this.MapLabel.Name = "MapLabel";
            this.MapLabel.Size = new System.Drawing.Size(39, 25);
            this.MapLabel.TabIndex = 14;
            this.MapLabel.Text = "Map1";
            // 
            // HealthLabel
            // 
            this.HealthLabel.AutoSize = true;
            this.HealthLabel.BackColor = System.Drawing.Color.Transparent;
            this.HealthLabel.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HealthLabel.ForeColor = System.Drawing.Color.DodgerBlue;
            this.HealthLabel.Location = new System.Drawing.Point(84, 108);
            this.HealthLabel.Name = "HealthLabel";
            this.HealthLabel.Size = new System.Drawing.Size(39, 25);
            this.HealthLabel.TabIndex = 13;
            this.HealthLabel.Text = "352";
            // 
            // AmmoLabel
            // 
            this.AmmoLabel.AutoSize = true;
            this.AmmoLabel.BackColor = System.Drawing.Color.Transparent;
            this.AmmoLabel.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AmmoLabel.ForeColor = System.Drawing.Color.DodgerBlue;
            this.AmmoLabel.Location = new System.Drawing.Point(84, 133);
            this.AmmoLabel.Name = "AmmoLabel";
            this.AmmoLabel.Size = new System.Drawing.Size(33, 25);
            this.AmmoLabel.TabIndex = 12;
            this.AmmoLabel.Text = "100";
            // 
            // OnlineStatusLabel
            // 
            this.OnlineStatusLabel.AutoSize = true;
            this.OnlineStatusLabel.BackColor = System.Drawing.Color.Transparent;
            this.OnlineStatusLabel.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OnlineStatusLabel.ForeColor = System.Drawing.Color.DodgerBlue;
            this.OnlineStatusLabel.Location = new System.Drawing.Point(84, 58);
            this.OnlineStatusLabel.Name = "OnlineStatusLabel";
            this.OnlineStatusLabel.Size = new System.Drawing.Size(47, 25);
            this.OnlineStatusLabel.TabIndex = 11;
            this.OnlineStatusLabel.Text = "Offline";
            // 
            // ScoreLabel
            // 
            this.ScoreLabel.BackColor = System.Drawing.Color.Transparent;
            this.ScoreLabel.Font = new System.Drawing.Font("Agency FB", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScoreLabel.ForeColor = System.Drawing.Color.DodgerBlue;
            this.ScoreLabel.Location = new System.Drawing.Point(158, 91);
            this.ScoreLabel.Name = "ScoreLabel";
            this.ScoreLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ScoreLabel.Size = new System.Drawing.Size(271, 77);
            this.ScoreLabel.TabIndex = 10;
            this.ScoreLabel.Text = "100000";
            this.ScoreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label6.Location = new System.Drawing.Point(8, 158);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 25);
            this.label6.TabIndex = 9;
            this.label6.Text = "Rank";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label5.Location = new System.Drawing.Point(351, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "High Score";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label4.Location = new System.Drawing.Point(8, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Map";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label2.Location = new System.Drawing.Point(8, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Health";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label1.Location = new System.Drawing.Point(8, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ammo";
            // 
            // subtitlelabel
            // 
            this.subtitlelabel.AutoSize = true;
            this.subtitlelabel.BackColor = System.Drawing.Color.Transparent;
            this.subtitlelabel.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtitlelabel.ForeColor = System.Drawing.Color.RoyalBlue;
            this.subtitlelabel.Location = new System.Drawing.Point(8, 58);
            this.subtitlelabel.Name = "subtitlelabel";
            this.subtitlelabel.Size = new System.Drawing.Size(70, 25);
            this.subtitlelabel.TabIndex = 4;
            this.subtitlelabel.Text = "Availability";
            // 
            // playerName
            // 
            this.playerName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.playerName.AutoSize = true;
            this.playerName.BackColor = System.Drawing.Color.Transparent;
            this.playerName.Font = new System.Drawing.Font("Agency FB", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerName.ForeColor = System.Drawing.Color.DodgerBlue;
            this.playerName.Location = new System.Drawing.Point(3, 0);
            this.playerName.Name = "playerName";
            this.playerName.Size = new System.Drawing.Size(112, 58);
            this.playerName.TabIndex = 3;
            this.playerName.Text = "Name";
            // 
            // DeselectButton
            // 
            this.DeselectButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(80)))), ((int)(((byte)(66)))), ((int)(((byte)(1)))));
            this.DeselectButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeselectButton.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeselectButton.ForeColor = System.Drawing.Color.White;
            this.DeselectButton.Location = new System.Drawing.Point(32, 367);
            this.DeselectButton.Name = "DeselectButton";
            this.DeselectButton.Size = new System.Drawing.Size(117, 38);
            this.DeselectButton.TabIndex = 26;
            this.DeselectButton.Text = "Deselect";
            this.DeselectButton.UseVisualStyleBackColor = false;
            this.DeselectButton.Click += new System.EventHandler(this.DeselectButton_Click);
            // 
            // DatabaseControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = global::SpaceFightServer.Properties.Resources.database1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Controls.Add(this.DeselectButton);
            this.Controls.Add(this.playerList);
            this.Controls.Add(this.addPlayerBut);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.refreshDatabase);
            this.Controls.Add(this.playerDelete);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.playerDetailsBut);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.DetailsPanel);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.Khaki;
            this.Name = "DatabaseControl";
            this.Size = new System.Drawing.Size(767, 410);
            this.Load += new System.EventHandler(this.DatabaseControl_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.DatabaseControl_MouseClick);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.DetailsPanel.ResumeLayout(false);
            this.DetailsPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button playerDetailsBut;
        private System.Windows.Forms.Button playerDelete;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button refreshDatabase;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button addPlayerBut;
        private System.Windows.Forms.ListView playerList;
        private System.Windows.Forms.Panel DetailsPanel;
        private System.Windows.Forms.Label playerName;
        private System.Windows.Forms.Label RankLabel;
        private System.Windows.Forms.Label MapLabel;
        private System.Windows.Forms.Label HealthLabel;
        private System.Windows.Forms.Label AmmoLabel;
        private System.Windows.Forms.Label OnlineStatusLabel;
        private System.Windows.Forms.Label ScoreLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label subtitlelabel;
        private System.Windows.Forms.Button DeselectButton;
        private System.Windows.Forms.Label BannedLabel;
    }
}
