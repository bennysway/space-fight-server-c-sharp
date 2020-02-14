namespace SpaceFightServer
{
    partial class AddPlayerPopUp
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
            this.Title = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.addBut = new System.Windows.Forms.Button();
            this.closeBut = new System.Windows.Forms.Button();
            this.usernameInput = new System.Windows.Forms.TextBox();
            this.playerNameInput = new System.Windows.Forms.TextBox();
            this.passwordInput = new System.Windows.Forms.TextBox();
            this.healthTrackBar = new System.Windows.Forms.TrackBar();
            this.ammoTrackBar = new System.Windows.Forms.TrackBar();
            this.healthAmount = new System.Windows.Forms.Label();
            this.ammoAmount = new System.Windows.Forms.Label();
            this.bannedCheck = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.healthTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ammoTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.BackColor = System.Drawing.Color.Black;
            this.Title.Font = new System.Drawing.Font("Agency FB", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.Color.Gold;
            this.Title.Location = new System.Drawing.Point(12, 9);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(130, 42);
            this.Title.TabIndex = 0;
            this.Title.Text = "Add Player";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Khaki;
            this.label3.Location = new System.Drawing.Point(62, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Khaki;
            this.label2.Location = new System.Drawing.Point(62, 218);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 25);
            this.label2.TabIndex = 20;
            this.label2.Text = "Ammunition";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Khaki;
            this.label4.Location = new System.Drawing.Point(62, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 25);
            this.label4.TabIndex = 21;
            this.label4.Text = "Health";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Khaki;
            this.label5.Location = new System.Drawing.Point(62, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 25);
            this.label5.TabIndex = 22;
            this.label5.Text = "Player Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Khaki;
            this.label6.Location = new System.Drawing.Point(62, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 25);
            this.label6.TabIndex = 23;
            this.label6.Text = "Password";
            // 
            // addBut
            // 
            this.addBut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(80)))), ((int)(((byte)(66)))), ((int)(((byte)(1)))));
            this.addBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addBut.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBut.ForeColor = System.Drawing.Color.White;
            this.addBut.Image = global::SpaceFightServer.Properties.Resources.check_64;
            this.addBut.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.addBut.Location = new System.Drawing.Point(127, 295);
            this.addBut.Name = "addBut";
            this.addBut.Size = new System.Drawing.Size(212, 75);
            this.addBut.TabIndex = 6;
            this.addBut.Text = "Add";
            this.addBut.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.addBut.UseVisualStyleBackColor = false;
            this.addBut.Click += new System.EventHandler(this.addBut_Click);
            // 
            // closeBut
            // 
            this.closeBut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(110)))), ((int)(((byte)(36)))), ((int)(((byte)(1)))));
            this.closeBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeBut.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeBut.ForeColor = System.Drawing.Color.White;
            this.closeBut.Image = global::SpaceFightServer.Properties.Resources.close_32;
            this.closeBut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.closeBut.Location = new System.Drawing.Point(26, 295);
            this.closeBut.Name = "closeBut";
            this.closeBut.Size = new System.Drawing.Size(95, 75);
            this.closeBut.TabIndex = 7;
            this.closeBut.Text = "Cancel";
            this.closeBut.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.closeBut.UseVisualStyleBackColor = false;
            this.closeBut.Click += new System.EventHandler(this.closeBut_Click);
            // 
            // usernameInput
            // 
            this.usernameInput.BackColor = System.Drawing.Color.Black;
            this.usernameInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.usernameInput.ForeColor = System.Drawing.Color.Khaki;
            this.usernameInput.Location = new System.Drawing.Point(160, 63);
            this.usernameInput.Name = "usernameInput";
            this.usernameInput.Size = new System.Drawing.Size(179, 20);
            this.usernameInput.TabIndex = 1;
            this.usernameInput.Leave += new System.EventHandler(this.usernameInput_Leave);
            // 
            // playerNameInput
            // 
            this.playerNameInput.BackColor = System.Drawing.Color.Black;
            this.playerNameInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.playerNameInput.ForeColor = System.Drawing.Color.Khaki;
            this.playerNameInput.Location = new System.Drawing.Point(160, 128);
            this.playerNameInput.Name = "playerNameInput";
            this.playerNameInput.Size = new System.Drawing.Size(179, 20);
            this.playerNameInput.TabIndex = 3;
            // 
            // passwordInput
            // 
            this.passwordInput.BackColor = System.Drawing.Color.Black;
            this.passwordInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.passwordInput.ForeColor = System.Drawing.Color.Khaki;
            this.passwordInput.Location = new System.Drawing.Point(160, 88);
            this.passwordInput.Name = "passwordInput";
            this.passwordInput.PasswordChar = '*';
            this.passwordInput.Size = new System.Drawing.Size(179, 20);
            this.passwordInput.TabIndex = 2;
            this.passwordInput.UseSystemPasswordChar = true;
            // 
            // healthTrackBar
            // 
            this.healthTrackBar.LargeChange = 50;
            this.healthTrackBar.Location = new System.Drawing.Point(160, 168);
            this.healthTrackBar.Maximum = 1000;
            this.healthTrackBar.Minimum = 10;
            this.healthTrackBar.Name = "healthTrackBar";
            this.healthTrackBar.Size = new System.Drawing.Size(179, 45);
            this.healthTrackBar.SmallChange = 10;
            this.healthTrackBar.TabIndex = 4;
            this.healthTrackBar.Value = 1000;
            this.healthTrackBar.Scroll += new System.EventHandler(this.healthTrackBar_Scroll);
            // 
            // ammoTrackBar
            // 
            this.ammoTrackBar.LargeChange = 20;
            this.ammoTrackBar.Location = new System.Drawing.Point(160, 218);
            this.ammoTrackBar.Maximum = 100;
            this.ammoTrackBar.Minimum = 10;
            this.ammoTrackBar.Name = "ammoTrackBar";
            this.ammoTrackBar.Size = new System.Drawing.Size(179, 45);
            this.ammoTrackBar.SmallChange = 10;
            this.ammoTrackBar.TabIndex = 5;
            this.ammoTrackBar.Value = 100;
            this.ammoTrackBar.Scroll += new System.EventHandler(this.ammoTrackBar_Scroll);
            // 
            // healthAmount
            // 
            this.healthAmount.AutoSize = true;
            this.healthAmount.BackColor = System.Drawing.Color.Transparent;
            this.healthAmount.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.healthAmount.ForeColor = System.Drawing.Color.Khaki;
            this.healthAmount.Location = new System.Drawing.Point(107, 193);
            this.healthAmount.Name = "healthAmount";
            this.healthAmount.Size = new System.Drawing.Size(42, 25);
            this.healthAmount.TabIndex = 31;
            this.healthAmount.Text = "1000";
            // 
            // ammoAmount
            // 
            this.ammoAmount.AutoSize = true;
            this.ammoAmount.BackColor = System.Drawing.Color.Transparent;
            this.ammoAmount.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ammoAmount.ForeColor = System.Drawing.Color.Khaki;
            this.ammoAmount.Location = new System.Drawing.Point(107, 243);
            this.ammoAmount.Name = "ammoAmount";
            this.ammoAmount.Size = new System.Drawing.Size(42, 25);
            this.ammoAmount.TabIndex = 32;
            this.ammoAmount.Text = "1000";
            // 
            // bannedCheck
            // 
            this.bannedCheck.AutoSize = true;
            this.bannedCheck.Location = new System.Drawing.Point(86, 272);
            this.bannedCheck.Name = "bannedCheck";
            this.bannedCheck.Size = new System.Drawing.Size(63, 17);
            this.bannedCheck.TabIndex = 34;
            this.bannedCheck.Text = "Banned";
            this.bannedCheck.UseVisualStyleBackColor = true;
            // 
            // AddPlayerPopUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(351, 382);
            this.Controls.Add(this.bannedCheck);
            this.Controls.Add(this.ammoAmount);
            this.Controls.Add(this.healthAmount);
            this.Controls.Add(this.ammoTrackBar);
            this.Controls.Add(this.healthTrackBar);
            this.Controls.Add(this.passwordInput);
            this.Controls.Add(this.playerNameInput);
            this.Controls.Add(this.usernameInput);
            this.Controls.Add(this.closeBut);
            this.Controls.Add(this.addBut);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Title);
            this.ForeColor = System.Drawing.Color.Khaki;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddPlayerPopUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddPlayerPopUp";
            this.Load += new System.EventHandler(this.AddPlayerPopUp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.healthTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ammoTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button addBut;
        private System.Windows.Forms.Button closeBut;
        private System.Windows.Forms.TextBox usernameInput;
        private System.Windows.Forms.TextBox playerNameInput;
        private System.Windows.Forms.TextBox passwordInput;
        private System.Windows.Forms.TrackBar healthTrackBar;
        private System.Windows.Forms.TrackBar ammoTrackBar;
        private System.Windows.Forms.Label healthAmount;
        private System.Windows.Forms.Label ammoAmount;
        private System.Windows.Forms.CheckBox bannedCheck;
    }
}