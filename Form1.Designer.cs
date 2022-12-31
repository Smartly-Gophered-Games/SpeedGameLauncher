namespace SpeedGameLauncher
{
    partial class Launcher
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Launcher));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Play = new System.Windows.Forms.Button();
            this.Quit = new System.Windows.Forms.Button();
            this.PlayDX12 = new System.Windows.Forms.Button();
            this.PlayRegen = new System.Windows.Forms.Button();
            this.GameLauncherLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-4, -5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(300, 572);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Black;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(51, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(192, 192);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // Play
            // 
            this.Play.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Play.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Play.ForeColor = System.Drawing.Color.White;
            this.Play.Location = new System.Drawing.Point(12, 261);
            this.Play.Name = "Play";
            this.Play.Size = new System.Drawing.Size(267, 51);
            this.Play.TabIndex = 2;
            this.Play.Text = "Play Game";
            this.Play.UseVisualStyleBackColor = false;
            this.Play.Click += new System.EventHandler(this.Play_Click);
            // 
            // Quit
            // 
            this.Quit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Quit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Quit.ForeColor = System.Drawing.Color.White;
            this.Quit.Location = new System.Drawing.Point(12, 432);
            this.Quit.Name = "Quit";
            this.Quit.Size = new System.Drawing.Size(267, 51);
            this.Quit.TabIndex = 3;
            this.Quit.Text = "Quit Launcher";
            this.Quit.UseVisualStyleBackColor = false;
            this.Quit.Click += new System.EventHandler(this.Quit_Click);
            // 
            // PlayDX12
            // 
            this.PlayDX12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.PlayDX12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PlayDX12.ForeColor = System.Drawing.Color.White;
            this.PlayDX12.Location = new System.Drawing.Point(12, 318);
            this.PlayDX12.Name = "PlayDX12";
            this.PlayDX12.Size = new System.Drawing.Size(267, 51);
            this.PlayDX12.TabIndex = 4;
            this.PlayDX12.Text = "Play Game using DirectX12";
            this.PlayDX12.UseVisualStyleBackColor = false;
            this.PlayDX12.Click += new System.EventHandler(this.PlayDX12_Click);
            // 
            // PlayRegen
            // 
            this.PlayRegen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.PlayRegen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PlayRegen.ForeColor = System.Drawing.Color.White;
            this.PlayRegen.Location = new System.Drawing.Point(12, 375);
            this.PlayRegen.Name = "PlayRegen";
            this.PlayRegen.Size = new System.Drawing.Size(267, 51);
            this.PlayRegen.TabIndex = 5;
            this.PlayRegen.Text = "Play Game and Regenerate Configs";
            this.PlayRegen.UseVisualStyleBackColor = false;
            this.PlayRegen.Click += new System.EventHandler(this.PlayRegen_Click);
            // 
            // GameLauncherLabel
            // 
            this.GameLauncherLabel.AutoSize = true;
            this.GameLauncherLabel.BackColor = System.Drawing.Color.Black;
            this.GameLauncherLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GameLauncherLabel.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GameLauncherLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(27)))), ((int)(((byte)(60)))));
            this.GameLauncherLabel.Location = new System.Drawing.Point(46, 217);
            this.GameLauncherLabel.Name = "GameLauncherLabel";
            this.GameLauncherLabel.Size = new System.Drawing.Size(203, 28);
            this.GameLauncherLabel.TabIndex = 6;
            this.GameLauncherLabel.Text = "GAME LAUNCHER";
            this.GameLauncherLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Launcher
            // 
            this.AcceptButton = this.Play;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Quit;
            this.ClientSize = new System.Drawing.Size(291, 496);
            this.Controls.Add(this.GameLauncherLabel);
            this.Controls.Add(this.PlayRegen);
            this.Controls.Add(this.PlayDX12);
            this.Controls.Add(this.Quit);
            this.Controls.Add(this.Play);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.Color.Black;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximumSize = new System.Drawing.Size(307, 535);
            this.MinimumSize = new System.Drawing.Size(307, 535);
            this.Name = "Launcher";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game Launcher";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button Play;
        private System.Windows.Forms.Button Quit;
        private System.Windows.Forms.Button PlayDX12;
        private System.Windows.Forms.Button PlayRegen;
        private System.Windows.Forms.Label GameLauncherLabel;
    }
}

