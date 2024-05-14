namespace PacMan
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.PbGrille = new System.Windows.Forms.PictureBox();
            this.PbForce1 = new System.Windows.Forms.PictureBox();
            this.PbForce2 = new System.Windows.Forms.PictureBox();
            this.PbForce3 = new System.Windows.Forms.PictureBox();
            this.PbForce4 = new System.Windows.Forms.PictureBox();
            this.LNomFantome1 = new System.Windows.Forms.Label();
            this.LNomFantome2 = new System.Windows.Forms.Label();
            this.LNomFantome3 = new System.Windows.Forms.Label();
            this.LNomFantome4 = new System.Windows.Forms.Label();
            this.L200Pts = new System.Windows.Forms.Label();
            this.L400Pts = new System.Windows.Forms.Label();
            this.L800Pts = new System.Windows.Forms.Label();
            this.L1600Pts = new System.Windows.Forms.Label();
            this.PbJouer = new System.Windows.Forms.PictureBox();
            this.PbQuitter = new System.Windows.Forms.PictureBox();
            this.LScore = new System.Windows.Forms.Label();
            this.T200Pts = new System.Windows.Forms.Timer(this.components);
            this.T400Pts = new System.Windows.Forms.Timer(this.components);
            this.T800Pts = new System.Windows.Forms.Timer(this.components);
            this.T1600Pts = new System.Windows.Forms.Timer(this.components);
            this.TTimer = new System.Windows.Forms.Timer(this.components);
            this.TAttaque = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.PbGrille)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbForce1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbForce2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbForce3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbForce4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbJouer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbQuitter)).BeginInit();
            this.SuspendLayout();
            // 
            // PbGrille
            // 
            this.PbGrille.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.PbGrille.Image = ((System.Drawing.Image)(resources.GetObject("PbGrille.Image")));
            this.PbGrille.Location = new System.Drawing.Point(12, 12);
            this.PbGrille.Name = "PbGrille";
            this.PbGrille.Size = new System.Drawing.Size(460, 500);
            this.PbGrille.TabIndex = 0;
            this.PbGrille.TabStop = false;
            this.PbGrille.Click += new System.EventHandler(this.PbGrille_Click);
            // 
            // PbForce1
            // 
            this.PbForce1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.PbForce1.Image = ((System.Drawing.Image)(resources.GetObject("PbForce1.Image")));
            this.PbForce1.Location = new System.Drawing.Point(217, 283);
            this.PbForce1.Name = "PbForce1";
            this.PbForce1.Size = new System.Drawing.Size(10, 10);
            this.PbForce1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PbForce1.TabIndex = 1;
            this.PbForce1.TabStop = false;
            // 
            // PbForce2
            // 
            this.PbForce2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.PbForce2.Image = ((System.Drawing.Image)(resources.GetObject("PbForce2.Image")));
            this.PbForce2.Location = new System.Drawing.Point(188, 283);
            this.PbForce2.Name = "PbForce2";
            this.PbForce2.Size = new System.Drawing.Size(10, 10);
            this.PbForce2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PbForce2.TabIndex = 2;
            this.PbForce2.TabStop = false;
            // 
            // PbForce3
            // 
            this.PbForce3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.PbForce3.Image = ((System.Drawing.Image)(resources.GetObject("PbForce3.Image")));
            this.PbForce3.Location = new System.Drawing.Point(245, 283);
            this.PbForce3.Name = "PbForce3";
            this.PbForce3.Size = new System.Drawing.Size(10, 10);
            this.PbForce3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PbForce3.TabIndex = 3;
            this.PbForce3.TabStop = false;
            // 
            // PbForce4
            // 
            this.PbForce4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.PbForce4.Image = ((System.Drawing.Image)(resources.GetObject("PbForce4.Image")));
            this.PbForce4.Location = new System.Drawing.Point(272, 283);
            this.PbForce4.Name = "PbForce4";
            this.PbForce4.Size = new System.Drawing.Size(10, 10);
            this.PbForce4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PbForce4.TabIndex = 4;
            this.PbForce4.TabStop = false;
            // 
            // LNomFantome1
            // 
            this.LNomFantome1.AutoSize = true;
            this.LNomFantome1.BackColor = System.Drawing.Color.Transparent;
            this.LNomFantome1.Font = new System.Drawing.Font("Snap ITC", 12F);
            this.LNomFantome1.ForeColor = System.Drawing.Color.White;
            this.LNomFantome1.Location = new System.Drawing.Point(110, 151);
            this.LNomFantome1.Name = "LNomFantome1";
            this.LNomFantome1.Size = new System.Drawing.Size(60, 22);
            this.LNomFantome1.TabIndex = 5;
            this.LNomFantome1.Text = "label1";
            // 
            // LNomFantome2
            // 
            this.LNomFantome2.AutoSize = true;
            this.LNomFantome2.BackColor = System.Drawing.Color.Transparent;
            this.LNomFantome2.Font = new System.Drawing.Font("Snap ITC", 12F);
            this.LNomFantome2.ForeColor = System.Drawing.Color.White;
            this.LNomFantome2.Location = new System.Drawing.Point(110, 184);
            this.LNomFantome2.Name = "LNomFantome2";
            this.LNomFantome2.Size = new System.Drawing.Size(60, 22);
            this.LNomFantome2.TabIndex = 6;
            this.LNomFantome2.Text = "label1";
            // 
            // LNomFantome3
            // 
            this.LNomFantome3.AutoSize = true;
            this.LNomFantome3.BackColor = System.Drawing.Color.Transparent;
            this.LNomFantome3.Font = new System.Drawing.Font("Snap ITC", 12F);
            this.LNomFantome3.ForeColor = System.Drawing.Color.White;
            this.LNomFantome3.Location = new System.Drawing.Point(110, 118);
            this.LNomFantome3.Name = "LNomFantome3";
            this.LNomFantome3.Size = new System.Drawing.Size(60, 22);
            this.LNomFantome3.TabIndex = 7;
            this.LNomFantome3.Text = "label1";
            // 
            // LNomFantome4
            // 
            this.LNomFantome4.AutoSize = true;
            this.LNomFantome4.BackColor = System.Drawing.Color.Transparent;
            this.LNomFantome4.Font = new System.Drawing.Font("Snap ITC", 12F);
            this.LNomFantome4.ForeColor = System.Drawing.Color.White;
            this.LNomFantome4.Location = new System.Drawing.Point(110, 216);
            this.LNomFantome4.Name = "LNomFantome4";
            this.LNomFantome4.Size = new System.Drawing.Size(60, 22);
            this.LNomFantome4.TabIndex = 8;
            this.LNomFantome4.Text = "label1";
            // 
            // L200Pts
            // 
            this.L200Pts.AutoSize = true;
            this.L200Pts.BackColor = System.Drawing.Color.Transparent;
            this.L200Pts.Font = new System.Drawing.Font("Snap ITC", 12F);
            this.L200Pts.ForeColor = System.Drawing.Color.White;
            this.L200Pts.Location = new System.Drawing.Point(315, 118);
            this.L200Pts.Name = "L200Pts";
            this.L200Pts.Size = new System.Drawing.Size(49, 22);
            this.L200Pts.TabIndex = 9;
            this.L200Pts.Text = "200";
            // 
            // L400Pts
            // 
            this.L400Pts.AutoSize = true;
            this.L400Pts.BackColor = System.Drawing.Color.Transparent;
            this.L400Pts.Font = new System.Drawing.Font("Snap ITC", 12F);
            this.L400Pts.ForeColor = System.Drawing.Color.White;
            this.L400Pts.Location = new System.Drawing.Point(315, 151);
            this.L400Pts.Name = "L400Pts";
            this.L400Pts.Size = new System.Drawing.Size(50, 22);
            this.L400Pts.TabIndex = 10;
            this.L400Pts.Text = "400";
            // 
            // L800Pts
            // 
            this.L800Pts.AutoSize = true;
            this.L800Pts.BackColor = System.Drawing.Color.Transparent;
            this.L800Pts.Font = new System.Drawing.Font("Snap ITC", 12F);
            this.L800Pts.ForeColor = System.Drawing.Color.White;
            this.L800Pts.Location = new System.Drawing.Point(315, 184);
            this.L800Pts.Name = "L800Pts";
            this.L800Pts.Size = new System.Drawing.Size(49, 22);
            this.L800Pts.TabIndex = 11;
            this.L800Pts.Text = "800";
            // 
            // L1600Pts
            // 
            this.L1600Pts.AutoSize = true;
            this.L1600Pts.BackColor = System.Drawing.Color.Transparent;
            this.L1600Pts.Font = new System.Drawing.Font("Snap ITC", 12F);
            this.L1600Pts.ForeColor = System.Drawing.Color.White;
            this.L1600Pts.Location = new System.Drawing.Point(315, 216);
            this.L1600Pts.Name = "L1600Pts";
            this.L1600Pts.Size = new System.Drawing.Size(57, 22);
            this.L1600Pts.TabIndex = 12;
            this.L1600Pts.Text = "1600";
            // 
            // PbJouer
            // 
            this.PbJouer.BackColor = System.Drawing.Color.Transparent;
            this.PbJouer.Image = ((System.Drawing.Image)(resources.GetObject("PbJouer.Image")));
            this.PbJouer.Location = new System.Drawing.Point(114, 405);
            this.PbJouer.Name = "PbJouer";
            this.PbJouer.Size = new System.Drawing.Size(105, 35);
            this.PbJouer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PbJouer.TabIndex = 13;
            this.PbJouer.TabStop = false;
            this.PbJouer.Click += new System.EventHandler(this.PbJouer_Click);
            this.PbJouer.MouseLeave += new System.EventHandler(this.PbJouer_MouseLeave);
            this.PbJouer.MouseHover += new System.EventHandler(this.PbJouer_MouseHover);
            // 
            // PbQuitter
            // 
            this.PbQuitter.BackColor = System.Drawing.Color.Transparent;
            this.PbQuitter.Image = ((System.Drawing.Image)(resources.GetObject("PbQuitter.Image")));
            this.PbQuitter.Location = new System.Drawing.Point(245, 405);
            this.PbQuitter.Name = "PbQuitter";
            this.PbQuitter.Size = new System.Drawing.Size(150, 35);
            this.PbQuitter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PbQuitter.TabIndex = 14;
            this.PbQuitter.TabStop = false;
            this.PbQuitter.Click += new System.EventHandler(this.PbQuitter_Click);
            this.PbQuitter.MouseLeave += new System.EventHandler(this.PbQuitter_MouseLeave);
            this.PbQuitter.MouseHover += new System.EventHandler(this.PbQuitter_MouseHover);
            // 
            // LScore
            // 
            this.LScore.AutoSize = true;
            this.LScore.Font = new System.Drawing.Font("Snap ITC", 16F);
            this.LScore.ForeColor = System.Drawing.Color.White;
            this.LScore.Location = new System.Drawing.Point(172, 523);
            this.LScore.Name = "LScore";
            this.LScore.Size = new System.Drawing.Size(132, 29);
            this.LScore.TabIndex = 15;
            this.LScore.Text = "Score : 0";
            // 
            // T200Pts
            // 
            this.T200Pts.Interval = 3500;
            this.T200Pts.Tick += new System.EventHandler(this.T200Pts_Tick);
            // 
            // T400Pts
            // 
            this.T400Pts.Interval = 3500;
            // 
            // T800Pts
            // 
            this.T800Pts.Interval = 3500;
            // 
            // T1600Pts
            // 
            this.T1600Pts.Interval = 3500;
            // 
            // TTimer
            // 
            this.TTimer.Enabled = true;
            this.TTimer.Interval = 20;
            this.TTimer.Tick += new System.EventHandler(this.TTimer_Tick);
            // 
            // TAttaque
            // 
            this.TAttaque.Enabled = true;
            this.TAttaque.Interval = 5000;
            this.TAttaque.Tick += new System.EventHandler(this.TAttaque_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(484, 561);
            this.Controls.Add(this.LScore);
            this.Controls.Add(this.PbQuitter);
            this.Controls.Add(this.PbJouer);
            this.Controls.Add(this.L1600Pts);
            this.Controls.Add(this.L800Pts);
            this.Controls.Add(this.L400Pts);
            this.Controls.Add(this.L200Pts);
            this.Controls.Add(this.LNomFantome4);
            this.Controls.Add(this.LNomFantome3);
            this.Controls.Add(this.LNomFantome2);
            this.Controls.Add(this.LNomFantome1);
            this.Controls.Add(this.PbForce4);
            this.Controls.Add(this.PbForce3);
            this.Controls.Add(this.PbForce2);
            this.Controls.Add(this.PbForce1);
            this.Controls.Add(this.PbGrille);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PacMan";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.PbGrille)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbForce1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbForce2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbForce3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbForce4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbJouer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbQuitter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PbGrille;
        private System.Windows.Forms.Label LNomFantome1;
        private System.Windows.Forms.Label LNomFantome2;
        private System.Windows.Forms.Label LNomFantome3;
        private System.Windows.Forms.Label LNomFantome4;
        private System.Windows.Forms.Label L200Pts;
        private System.Windows.Forms.Label L400Pts;
        private System.Windows.Forms.Label L800Pts;
        private System.Windows.Forms.Label L1600Pts;
        private System.Windows.Forms.PictureBox PbJouer;
        private System.Windows.Forms.PictureBox PbQuitter;
        private System.Windows.Forms.Label LScore;
        private System.Windows.Forms.Timer T200Pts;
        private System.Windows.Forms.Timer T400Pts;
        private System.Windows.Forms.Timer T800Pts;
        private System.Windows.Forms.Timer T1600Pts;
        private System.Windows.Forms.Timer TTimer;
        public System.Windows.Forms.PictureBox PbForce1;
        public System.Windows.Forms.PictureBox PbForce2;
        public System.Windows.Forms.PictureBox PbForce3;
        public System.Windows.Forms.PictureBox PbForce4;
        private System.Windows.Forms.Timer TAttaque;
    }
}

