namespace SpaceFightServer
{
    partial class ClientsControl
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
            this.clientsinput = new System.Windows.Forms.TextBox();
            this.sendtoselected = new System.Windows.Forms.Button();
            this.sendtoall = new System.Windows.Forms.Button();
            this.clientsLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.playerDetailsBut = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.detailClientList = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // clientsinput
            // 
            this.clientsinput.Location = new System.Drawing.Point(47, 306);
            this.clientsinput.Name = "clientsinput";
            this.clientsinput.Size = new System.Drawing.Size(614, 20);
            this.clientsinput.TabIndex = 2;
            // 
            // sendtoselected
            // 
            this.sendtoselected.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sendtoselected.Font = new System.Drawing.Font("Agency FB", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendtoselected.Location = new System.Drawing.Point(676, 87);
            this.sendtoselected.Name = "sendtoselected";
            this.sendtoselected.Size = new System.Drawing.Size(75, 40);
            this.sendtoselected.TabIndex = 3;
            this.sendtoselected.Text = "Send To Selected";
            this.sendtoselected.UseVisualStyleBackColor = true;
            this.sendtoselected.Click += new System.EventHandler(this.sendtoselected_Click);
            // 
            // sendtoall
            // 
            this.sendtoall.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sendtoall.Font = new System.Drawing.Font("Agency FB", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendtoall.Location = new System.Drawing.Point(676, 41);
            this.sendtoall.Name = "sendtoall";
            this.sendtoall.Size = new System.Drawing.Size(75, 40);
            this.sendtoall.TabIndex = 4;
            this.sendtoall.Text = "Send To All";
            this.sendtoall.UseVisualStyleBackColor = true;
            this.sendtoall.Click += new System.EventHandler(this.sendtoall_Click);
            // 
            // clientsLabel
            // 
            this.clientsLabel.AutoSize = true;
            this.clientsLabel.BackColor = System.Drawing.Color.Transparent;
            this.clientsLabel.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientsLabel.Location = new System.Drawing.Point(44, 10);
            this.clientsLabel.Name = "clientsLabel";
            this.clientsLabel.Size = new System.Drawing.Size(52, 25);
            this.clientsLabel.TabIndex = 5;
            this.clientsLabel.Text = "Clients";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.label1.Location = new System.Drawing.Point(44, 278);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Message";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(80)))), ((int)(((byte)(66)))), ((int)(((byte)(1)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(174, 332);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(87, 38);
            this.button3.TabIndex = 30;
            this.button3.Text = "Ban";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(80)))), ((int)(((byte)(66)))), ((int)(((byte)(1)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(453, 332);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(208, 38);
            this.button2.TabIndex = 29;
            this.button2.Text = "Send Message";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(80)))), ((int)(((byte)(66)))), ((int)(((byte)(1)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(267, 332);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 38);
            this.button1.TabIndex = 28;
            this.button1.Text = "Grant";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // playerDetailsBut
            // 
            this.playerDetailsBut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(110)))), ((int)(((byte)(36)))), ((int)(((byte)(1)))));
            this.playerDetailsBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.playerDetailsBut.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerDetailsBut.ForeColor = System.Drawing.Color.White;
            this.playerDetailsBut.Location = new System.Drawing.Point(47, 332);
            this.playerDetailsBut.Name = "playerDetailsBut";
            this.playerDetailsBut.Size = new System.Drawing.Size(121, 38);
            this.playerDetailsBut.TabIndex = 27;
            this.playerDetailsBut.Text = "Details";
            this.playerDetailsBut.UseVisualStyleBackColor = false;
            this.playerDetailsBut.Click += new System.EventHandler(this.playerDetailsBut_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(80)))), ((int)(((byte)(66)))), ((int)(((byte)(1)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(360, 332);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(87, 38);
            this.button4.TabIndex = 31;
            this.button4.Text = "Control";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(45, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 33;
            this.label2.Text = "Connected IPs";
            // 
            // detailClientList
            // 
            this.detailClientList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(56)))), ((int)(((byte)(0)))));
            this.detailClientList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.detailClientList.ForeColor = System.Drawing.Color.White;
            this.detailClientList.Location = new System.Drawing.Point(49, 80);
            this.detailClientList.Name = "detailClientList";
            this.detailClientList.OwnerDraw = true;
            this.detailClientList.Size = new System.Drawing.Size(305, 195);
            this.detailClientList.TabIndex = 34;
            this.detailClientList.Tag = "";
            this.detailClientList.UseCompatibleStateImageBehavior = false;
            // 
            // ClientsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::SpaceFightServer.Properties.Resources.clients_512;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Controls.Add(this.detailClientList);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.playerDetailsBut);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.clientsLabel);
            this.Controls.Add(this.sendtoall);
            this.Controls.Add(this.sendtoselected);
            this.Controls.Add(this.clientsinput);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Name = "ClientsControl";
            this.Size = new System.Drawing.Size(767, 410);
            this.Load += new System.EventHandler(this.ClientsControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox clientsinput;
        private System.Windows.Forms.Button sendtoselected;
        private System.Windows.Forms.Button sendtoall;
        private System.Windows.Forms.Label clientsLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button playerDetailsBut;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView detailClientList;
    }
}
