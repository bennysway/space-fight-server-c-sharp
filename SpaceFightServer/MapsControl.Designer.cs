namespace SpaceFightServer
{
    partial class MapsControl
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
            this.components = new System.ComponentModel.Container();
            this.map1But = new System.Windows.Forms.Button();
            this.textMap = new System.Windows.Forms.TextBox();
            this.mapUpdate = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // map1But
            // 
            this.map1But.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.map1But.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.map1But.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.map1But.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.map1But.Location = new System.Drawing.Point(46, 53);
            this.map1But.Name = "map1But";
            this.map1But.Size = new System.Drawing.Size(117, 55);
            this.map1But.TabIndex = 17;
            this.map1But.Text = "Map 1";
            this.map1But.UseVisualStyleBackColor = false;
            this.map1But.Click += new System.EventHandler(this.map1But_Click);
            // 
            // textMap
            // 
            this.textMap.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textMap.BackColor = System.Drawing.Color.Black;
            this.textMap.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textMap.Font = new System.Drawing.Font("OCR A Extended", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textMap.ForeColor = System.Drawing.Color.White;
            this.textMap.Location = new System.Drawing.Point(414, 3);
            this.textMap.Multiline = true;
            this.textMap.Name = "textMap";
            this.textMap.ReadOnly = true;
            this.textMap.Size = new System.Drawing.Size(350, 362);
            this.textMap.TabIndex = 18;
            this.textMap.TabStop = false;
            this.textMap.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // mapUpdate
            // 
            this.mapUpdate.Interval = 500;
            this.mapUpdate.Tick += new System.EventHandler(this.mapUpdate_Tick);
            // 
            // MapsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = global::SpaceFightServer.Properties.Resources.map;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Controls.Add(this.textMap);
            this.Controls.Add(this.map1But);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.Khaki;
            this.Name = "MapsControl";
            this.Size = new System.Drawing.Size(767, 410);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button map1But;
        private System.Windows.Forms.TextBox textMap;
        private System.Windows.Forms.Timer mapUpdate;
    }
}
