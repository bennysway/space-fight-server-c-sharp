namespace SpaceFightServer
{
    partial class ServerInterface
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.subtitlelabel = new System.Windows.Forms.Label();
            this.titlelabel = new System.Windows.Forms.Label();
            this.minimizebutton = new System.Windows.Forms.Button();
            this.closebutton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.clientbutton = new System.Windows.Forms.Button();
            this.mapsbutton = new System.Windows.Forms.Button();
            this.databasebutton = new System.Windows.Forms.Button();
            this.consolebutton = new System.Windows.Forms.Button();
            this.optionsbutton = new System.Windows.Forms.Button();
            this.dashboardbutton = new System.Windows.Forms.Button();
            this.storeitemsbutton = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.databaseConnectionLabel = new System.Windows.Forms.Label();
            this.databaseConnectionIcon = new System.Windows.Forms.PictureBox();
            this.servernumber = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.clientnumber = new System.Windows.Forms.Label();
            this.clientsnumberlabel = new System.Windows.Forms.Label();
            this.serverConnectionLabel = new System.Windows.Forms.Label();
            this.serverConnectionIcon = new System.Windows.Forms.PictureBox();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.serverTimer = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.databaseConnectionIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serverConnectionIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.subtitlelabel);
            this.panel1.Controls.Add(this.titlelabel);
            this.panel1.Controls.Add(this.minimizebutton);
            this.panel1.Controls.Add(this.closebutton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(896, 37);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ServerInterface_MouseDown);
            // 
            // subtitlelabel
            // 
            this.subtitlelabel.AutoSize = true;
            this.subtitlelabel.BackColor = System.Drawing.Color.Black;
            this.subtitlelabel.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtitlelabel.ForeColor = System.Drawing.Color.Khaki;
            this.subtitlelabel.Location = new System.Drawing.Point(135, 3);
            this.subtitlelabel.Name = "subtitlelabel";
            this.subtitlelabel.Size = new System.Drawing.Size(76, 25);
            this.subtitlelabel.TabIndex = 3;
            this.subtitlelabel.Text = "Dashboard";
            // 
            // titlelabel
            // 
            this.titlelabel.AutoSize = true;
            this.titlelabel.BackColor = System.Drawing.Color.Black;
            this.titlelabel.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titlelabel.ForeColor = System.Drawing.Color.Gold;
            this.titlelabel.Location = new System.Drawing.Point(3, 2);
            this.titlelabel.Name = "titlelabel";
            this.titlelabel.Size = new System.Drawing.Size(126, 25);
            this.titlelabel.TabIndex = 2;
            this.titlelabel.Text = "Space Fight Server";
            this.titlelabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // minimizebutton
            // 
            this.minimizebutton.BackgroundImage = global::SpaceFightServer.Properties.Resources.minimize_32;
            this.minimizebutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.minimizebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimizebutton.ForeColor = System.Drawing.Color.Black;
            this.minimizebutton.Location = new System.Drawing.Point(823, 2);
            this.minimizebutton.Name = "minimizebutton";
            this.minimizebutton.Size = new System.Drawing.Size(32, 32);
            this.minimizebutton.TabIndex = 1;
            this.minimizebutton.UseVisualStyleBackColor = true;
            this.minimizebutton.Click += new System.EventHandler(this.button2_Click);
            // 
            // closebutton
            // 
            this.closebutton.BackgroundImage = global::SpaceFightServer.Properties.Resources.close_32;
            this.closebutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.closebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closebutton.ForeColor = System.Drawing.Color.Black;
            this.closebutton.Location = new System.Drawing.Point(861, 3);
            this.closebutton.Name = "closebutton";
            this.closebutton.Size = new System.Drawing.Size(32, 32);
            this.closebutton.TabIndex = 0;
            this.closebutton.UseVisualStyleBackColor = true;
            this.closebutton.Click += new System.EventHandler(this.closebutton_Click);
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 37);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(896, 39);
            this.panel2.TabIndex = 2;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ServerInterface_MouseDown);
            // 
            // panel3
            // 
            this.panel3.AutoSize = true;
            this.panel3.Controls.Add(this.clientbutton);
            this.panel3.Controls.Add(this.mapsbutton);
            this.panel3.Controls.Add(this.databasebutton);
            this.panel3.Controls.Add(this.consolebutton);
            this.panel3.Controls.Add(this.optionsbutton);
            this.panel3.Controls.Add(this.dashboardbutton);
            this.panel3.Controls.Add(this.storeitemsbutton);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 76);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(129, 410);
            this.panel3.TabIndex = 3;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // clientbutton
            // 
            this.clientbutton.Enabled = false;
            this.clientbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clientbutton.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientbutton.ForeColor = System.Drawing.Color.Khaki;
            this.clientbutton.Image = global::SpaceFightServer.Properties.Resources.clients_32;
            this.clientbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.clientbutton.Location = new System.Drawing.Point(3, 55);
            this.clientbutton.Name = "clientbutton";
            this.clientbutton.Size = new System.Drawing.Size(123, 50);
            this.clientbutton.TabIndex = 6;
            this.clientbutton.Text = "Clients";
            this.clientbutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.clientbutton.UseVisualStyleBackColor = true;
            this.clientbutton.Click += new System.EventHandler(this.clientbutton_Click);
            this.clientbutton.MouseHover += new System.EventHandler(this.clientbutton_MouseHover);
            // 
            // mapsbutton
            // 
            this.mapsbutton.Enabled = false;
            this.mapsbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mapsbutton.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mapsbutton.ForeColor = System.Drawing.Color.Khaki;
            this.mapsbutton.Image = global::SpaceFightServer.Properties.Resources.maps_32;
            this.mapsbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mapsbutton.Location = new System.Drawing.Point(3, 104);
            this.mapsbutton.Name = "mapsbutton";
            this.mapsbutton.Size = new System.Drawing.Size(123, 50);
            this.mapsbutton.TabIndex = 5;
            this.mapsbutton.Text = "Maps";
            this.mapsbutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.mapsbutton.UseVisualStyleBackColor = true;
            this.mapsbutton.Click += new System.EventHandler(this.mapsbutton_Click);
            this.mapsbutton.MouseHover += new System.EventHandler(this.mapsbutton_MouseHover);
            // 
            // databasebutton
            // 
            this.databasebutton.Enabled = false;
            this.databasebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.databasebutton.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.databasebutton.ForeColor = System.Drawing.Color.Khaki;
            this.databasebutton.Image = global::SpaceFightServer.Properties.Resources.database_32;
            this.databasebutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.databasebutton.Location = new System.Drawing.Point(3, 153);
            this.databasebutton.Name = "databasebutton";
            this.databasebutton.Size = new System.Drawing.Size(123, 50);
            this.databasebutton.TabIndex = 4;
            this.databasebutton.Text = "Database";
            this.databasebutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.databasebutton.UseVisualStyleBackColor = true;
            this.databasebutton.Click += new System.EventHandler(this.databasebutton_Click);
            this.databasebutton.MouseHover += new System.EventHandler(this.databasebutton_MouseHover);
            // 
            // consolebutton
            // 
            this.consolebutton.Enabled = false;
            this.consolebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.consolebutton.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.consolebutton.ForeColor = System.Drawing.Color.Khaki;
            this.consolebutton.Image = global::SpaceFightServer.Properties.Resources.command_line_32;
            this.consolebutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.consolebutton.Location = new System.Drawing.Point(3, 300);
            this.consolebutton.Name = "consolebutton";
            this.consolebutton.Size = new System.Drawing.Size(123, 50);
            this.consolebutton.TabIndex = 2;
            this.consolebutton.Text = "Console";
            this.consolebutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.consolebutton.UseVisualStyleBackColor = true;
            this.consolebutton.Click += new System.EventHandler(this.consolebutton_Click);
            this.consolebutton.MouseHover += new System.EventHandler(this.consolebutton_MouseHover);
            // 
            // optionsbutton
            // 
            this.optionsbutton.Enabled = false;
            this.optionsbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.optionsbutton.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optionsbutton.ForeColor = System.Drawing.Color.Khaki;
            this.optionsbutton.Image = global::SpaceFightServer.Properties.Resources.options_32;
            this.optionsbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.optionsbutton.Location = new System.Drawing.Point(3, 251);
            this.optionsbutton.Name = "optionsbutton";
            this.optionsbutton.Size = new System.Drawing.Size(123, 50);
            this.optionsbutton.TabIndex = 1;
            this.optionsbutton.Text = "Options";
            this.optionsbutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.optionsbutton.UseVisualStyleBackColor = true;
            this.optionsbutton.Click += new System.EventHandler(this.optionsbutton_Click);
            this.optionsbutton.MouseHover += new System.EventHandler(this.optionsbutton_MouseHover);
            // 
            // dashboardbutton
            // 
            this.dashboardbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dashboardbutton.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboardbutton.ForeColor = System.Drawing.Color.Khaki;
            this.dashboardbutton.Image = global::SpaceFightServer.Properties.Resources.dashboard_32;
            this.dashboardbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dashboardbutton.Location = new System.Drawing.Point(3, 6);
            this.dashboardbutton.Name = "dashboardbutton";
            this.dashboardbutton.Size = new System.Drawing.Size(123, 50);
            this.dashboardbutton.TabIndex = 0;
            this.dashboardbutton.Text = "Dashboard";
            this.dashboardbutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.dashboardbutton.UseVisualStyleBackColor = true;
            this.dashboardbutton.Click += new System.EventHandler(this.dashboardbutton_Click);
            this.dashboardbutton.MouseHover += new System.EventHandler(this.dashboardbutton_MouseHover);
            // 
            // storeitemsbutton
            // 
            this.storeitemsbutton.Enabled = false;
            this.storeitemsbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.storeitemsbutton.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.storeitemsbutton.ForeColor = System.Drawing.Color.Khaki;
            this.storeitemsbutton.Image = global::SpaceFightServer.Properties.Resources.store_32;
            this.storeitemsbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.storeitemsbutton.Location = new System.Drawing.Point(3, 202);
            this.storeitemsbutton.Name = "storeitemsbutton";
            this.storeitemsbutton.Size = new System.Drawing.Size(123, 50);
            this.storeitemsbutton.TabIndex = 3;
            this.storeitemsbutton.Text = "Store Items";
            this.storeitemsbutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.storeitemsbutton.UseVisualStyleBackColor = true;
            this.storeitemsbutton.Click += new System.EventHandler(this.itemsbutton_Click);
            this.storeitemsbutton.MouseHover += new System.EventHandler(this.storeitemsbutton_MouseHover);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.databaseConnectionLabel);
            this.panel4.Controls.Add(this.databaseConnectionIcon);
            this.panel4.Controls.Add(this.servernumber);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.clientnumber);
            this.panel4.Controls.Add(this.clientsnumberlabel);
            this.panel4.Controls.Add(this.serverConnectionLabel);
            this.panel4.Controls.Add(this.serverConnectionIcon);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 486);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(896, 35);
            this.panel4.TabIndex = 7;
            this.panel4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ServerInterface_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Agency FB", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Khaki;
            this.label1.Location = new System.Drawing.Point(761, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "by Farai Charumbira (Benny Sway)";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // databaseConnectionLabel
            // 
            this.databaseConnectionLabel.AutoSize = true;
            this.databaseConnectionLabel.BackColor = System.Drawing.Color.Black;
            this.databaseConnectionLabel.Font = new System.Drawing.Font("Agency FB", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.databaseConnectionLabel.ForeColor = System.Drawing.Color.Khaki;
            this.databaseConnectionLabel.Location = new System.Drawing.Point(178, 9);
            this.databaseConnectionLabel.Name = "databaseConnectionLabel";
            this.databaseConnectionLabel.Size = new System.Drawing.Size(89, 17);
            this.databaseConnectionLabel.TabIndex = 11;
            this.databaseConnectionLabel.Text = "Database Disconnected";
            // 
            // databaseConnectionIcon
            // 
            this.databaseConnectionIcon.BackgroundImage = global::SpaceFightServer.Properties.Resources.db_cloud_32;
            this.databaseConnectionIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.databaseConnectionIcon.Location = new System.Drawing.Point(148, 6);
            this.databaseConnectionIcon.Name = "databaseConnectionIcon";
            this.databaseConnectionIcon.Size = new System.Drawing.Size(24, 24);
            this.databaseConnectionIcon.TabIndex = 10;
            this.databaseConnectionIcon.TabStop = false;
            // 
            // servernumber
            // 
            this.servernumber.AutoSize = true;
            this.servernumber.BackColor = System.Drawing.Color.Black;
            this.servernumber.Font = new System.Drawing.Font("Agency FB", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.servernumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(203)))), ((int)(((byte)(0)))));
            this.servernumber.Location = new System.Drawing.Point(347, 9);
            this.servernumber.Name = "servernumber";
            this.servernumber.Size = new System.Drawing.Size(13, 17);
            this.servernumber.TabIndex = 9;
            this.servernumber.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("Agency FB", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Khaki;
            this.label2.Location = new System.Drawing.Point(366, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Servers";
            // 
            // clientnumber
            // 
            this.clientnumber.AutoSize = true;
            this.clientnumber.BackColor = System.Drawing.Color.Black;
            this.clientnumber.Font = new System.Drawing.Font("Agency FB", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientnumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(203)))), ((int)(((byte)(0)))));
            this.clientnumber.Location = new System.Drawing.Point(279, 9);
            this.clientnumber.Name = "clientnumber";
            this.clientnumber.Size = new System.Drawing.Size(13, 17);
            this.clientnumber.TabIndex = 7;
            this.clientnumber.Text = "0";
            // 
            // clientsnumberlabel
            // 
            this.clientsnumberlabel.AutoSize = true;
            this.clientsnumberlabel.BackColor = System.Drawing.Color.Black;
            this.clientsnumberlabel.Font = new System.Drawing.Font("Agency FB", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientsnumberlabel.ForeColor = System.Drawing.Color.Khaki;
            this.clientsnumberlabel.Location = new System.Drawing.Point(298, 9);
            this.clientsnumberlabel.Name = "clientsnumberlabel";
            this.clientsnumberlabel.Size = new System.Drawing.Size(32, 17);
            this.clientsnumberlabel.TabIndex = 6;
            this.clientsnumberlabel.Text = "Clients";
            // 
            // serverConnectionLabel
            // 
            this.serverConnectionLabel.AutoSize = true;
            this.serverConnectionLabel.BackColor = System.Drawing.Color.Black;
            this.serverConnectionLabel.Font = new System.Drawing.Font("Agency FB", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serverConnectionLabel.ForeColor = System.Drawing.Color.Khaki;
            this.serverConnectionLabel.Location = new System.Drawing.Point(44, 9);
            this.serverConnectionLabel.Name = "serverConnectionLabel";
            this.serverConnectionLabel.Size = new System.Drawing.Size(82, 17);
            this.serverConnectionLabel.TabIndex = 4;
            this.serverConnectionLabel.Text = "Server Disconnected";
            this.serverConnectionLabel.Click += new System.EventHandler(this.connectionlabel_Click);
            // 
            // serverConnectionIcon
            // 
            this.serverConnectionIcon.BackgroundImage = global::SpaceFightServer.Properties.Resources.disconnected_32;
            this.serverConnectionIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.serverConnectionIcon.Location = new System.Drawing.Point(14, 6);
            this.serverConnectionIcon.Name = "serverConnectionIcon";
            this.serverConnectionIcon.Size = new System.Drawing.Size(24, 24);
            this.serverConnectionIcon.TabIndex = 0;
            this.serverConnectionIcon.TabStop = false;
            // 
            // mainPanel
            // 
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(129, 76);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(767, 410);
            this.mainPanel.TabIndex = 8;
            this.mainPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.mainPanel_Paint);
            // 
            // ServerInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(896, 521);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(208)))), ((int)(((byte)(0)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ServerInterface";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.ServerInterface_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ServerInterface_MouseDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.databaseConnectionIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.serverConnectionIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button minimizebutton;
        private System.Windows.Forms.Button closebutton;
        private System.Windows.Forms.Label titlelabel;
        private System.Windows.Forms.Label subtitlelabel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button clientbutton;
        private System.Windows.Forms.Button mapsbutton;
        private System.Windows.Forms.Button databasebutton;
        private System.Windows.Forms.Button consolebutton;
        private System.Windows.Forms.Button optionsbutton;
        private System.Windows.Forms.Button dashboardbutton;
        private System.Windows.Forms.Button storeitemsbutton;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label serverConnectionLabel;
        private System.Windows.Forms.PictureBox serverConnectionIcon;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Label clientnumber;
        private System.Windows.Forms.Label clientsnumberlabel;
        private System.Windows.Forms.Label servernumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label databaseConnectionLabel;
        private System.Windows.Forms.PictureBox databaseConnectionIcon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer serverTimer;
    }
}

