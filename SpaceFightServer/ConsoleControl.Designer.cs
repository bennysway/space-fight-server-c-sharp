namespace SpaceFightServer
{
    partial class ConsoleControl
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
            this.ConsoleLog = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dumpToFile = new System.Windows.Forms.Label();
            this.clearLog = new System.Windows.Forms.Label();
            this.copyLog = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ConsoleLog
            // 
            this.ConsoleLog.BackColor = System.Drawing.Color.Black;
            this.ConsoleLog.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ConsoleLog.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.ConsoleLog.Location = new System.Drawing.Point(289, 168);
            this.ConsoleLog.Multiline = true;
            this.ConsoleLog.Name = "ConsoleLog";
            this.ConsoleLog.ReadOnly = true;
            this.ConsoleLog.Size = new System.Drawing.Size(298, 137);
            this.ConsoleLog.TabIndex = 2;
            this.ConsoleLog.WordWrap = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Agency FB", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.label2.Location = new System.Drawing.Point(168, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 34);
            this.label2.TabIndex = 8;
            this.label2.Text = "Logs";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // dumpToFile
            // 
            this.dumpToFile.AutoSize = true;
            this.dumpToFile.BackColor = System.Drawing.Color.Transparent;
            this.dumpToFile.Font = new System.Drawing.Font("Agency FB", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dumpToFile.ForeColor = System.Drawing.Color.SaddleBrown;
            this.dumpToFile.Location = new System.Drawing.Point(443, 371);
            this.dumpToFile.Name = "dumpToFile";
            this.dumpToFile.Size = new System.Drawing.Size(66, 17);
            this.dumpToFile.TabIndex = 9;
            this.dumpToFile.Text = "Dump Log to File";
            this.dumpToFile.Click += new System.EventHandler(this.dumpToFile_Click);
            // 
            // clearLog
            // 
            this.clearLog.AutoSize = true;
            this.clearLog.BackColor = System.Drawing.Color.Transparent;
            this.clearLog.Font = new System.Drawing.Font("Agency FB", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearLog.ForeColor = System.Drawing.Color.SaddleBrown;
            this.clearLog.Location = new System.Drawing.Point(515, 371);
            this.clearLog.Name = "clearLog";
            this.clearLog.Size = new System.Drawing.Size(27, 17);
            this.clearLog.TabIndex = 10;
            this.clearLog.Text = "Clear";
            // 
            // copyLog
            // 
            this.copyLog.AutoSize = true;
            this.copyLog.BackColor = System.Drawing.Color.Transparent;
            this.copyLog.Font = new System.Drawing.Font("Agency FB", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.copyLog.ForeColor = System.Drawing.Color.SaddleBrown;
            this.copyLog.Location = new System.Drawing.Point(548, 371);
            this.copyLog.Name = "copyLog";
            this.copyLog.Size = new System.Drawing.Size(25, 17);
            this.copyLog.TabIndex = 11;
            this.copyLog.Text = "Copy";
            // 
            // ConsoleControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = global::SpaceFightServer.Properties.Resources.command_line1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Controls.Add(this.copyLog);
            this.Controls.Add(this.clearLog);
            this.Controls.Add(this.dumpToFile);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ConsoleLog);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.Khaki;
            this.Name = "ConsoleControl";
            this.Size = new System.Drawing.Size(767, 410);
            this.Load += new System.EventHandler(this.ConsoleControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ConsoleLog;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label dumpToFile;
        private System.Windows.Forms.Label clearLog;
        private System.Windows.Forms.Label copyLog;
    }
}
