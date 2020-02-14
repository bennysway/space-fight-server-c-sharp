namespace SpaceFightServer
{
    partial class CustomPopUp
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
            this.CaptionLabel = new System.Windows.Forms.Label();
            this.MessageLabel = new System.Windows.Forms.Label();
            this.noBut = new System.Windows.Forms.Button();
            this.yesBut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CaptionLabel
            // 
            this.CaptionLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CaptionLabel.AutoSize = true;
            this.CaptionLabel.BackColor = System.Drawing.Color.Transparent;
            this.CaptionLabel.Font = new System.Drawing.Font("Agency FB", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CaptionLabel.ForeColor = System.Drawing.Color.Gold;
            this.CaptionLabel.Location = new System.Drawing.Point(12, 9);
            this.CaptionLabel.Name = "CaptionLabel";
            this.CaptionLabel.Size = new System.Drawing.Size(97, 42);
            this.CaptionLabel.TabIndex = 0;
            this.CaptionLabel.Text = "Caption";
            // 
            // MessageLabel
            // 
            this.MessageLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MessageLabel.AutoSize = true;
            this.MessageLabel.BackColor = System.Drawing.Color.Transparent;
            this.MessageLabel.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MessageLabel.ForeColor = System.Drawing.Color.Khaki;
            this.MessageLabel.Location = new System.Drawing.Point(14, 51);
            this.MessageLabel.Name = "MessageLabel";
            this.MessageLabel.Size = new System.Drawing.Size(181, 25);
            this.MessageLabel.TabIndex = 0;
            this.MessageLabel.Text = "Message Here... or Question";
            // 
            // noBut
            // 
            this.noBut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(110)))), ((int)(((byte)(36)))), ((int)(((byte)(1)))));
            this.noBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.noBut.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noBut.ForeColor = System.Drawing.Color.White;
            this.noBut.Image = global::SpaceFightServer.Properties.Resources.close_32;
            this.noBut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.noBut.Location = new System.Drawing.Point(19, 178);
            this.noBut.Name = "noBut";
            this.noBut.Size = new System.Drawing.Size(134, 41);
            this.noBut.TabIndex = 2;
            this.noBut.Text = "No";
            this.noBut.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.noBut.UseVisualStyleBackColor = false;
            this.noBut.Click += new System.EventHandler(this.noBut_Click);
            // 
            // yesBut
            // 
            this.yesBut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(80)))), ((int)(((byte)(66)))), ((int)(((byte)(1)))));
            this.yesBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.yesBut.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yesBut.ForeColor = System.Drawing.Color.White;
            this.yesBut.Image = global::SpaceFightServer.Properties.Resources.check_64;
            this.yesBut.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.yesBut.Location = new System.Drawing.Point(159, 145);
            this.yesBut.Name = "yesBut";
            this.yesBut.Size = new System.Drawing.Size(212, 74);
            this.yesBut.TabIndex = 1;
            this.yesBut.Text = "Yes";
            this.yesBut.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.yesBut.UseVisualStyleBackColor = false;
            this.yesBut.Click += new System.EventHandler(this.yesBut_Click);
            // 
            // CustomPopUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(47)))), ((int)(((byte)(1)))));
            this.ClientSize = new System.Drawing.Size(383, 231);
            this.Controls.Add(this.yesBut);
            this.Controls.Add(this.noBut);
            this.Controls.Add(this.MessageLabel);
            this.Controls.Add(this.CaptionLabel);
            this.ForeColor = System.Drawing.Color.Khaki;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CustomPopUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CustomPopUp";
            this.Load += new System.EventHandler(this.CustomPopUp_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CaptionLabel;
        private System.Windows.Forms.Label MessageLabel;
        private System.Windows.Forms.Button noBut;
        private System.Windows.Forms.Button yesBut;
    }
}