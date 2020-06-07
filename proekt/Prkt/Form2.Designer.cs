namespace Prkt
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.lblScore = new System.Windows.Forms.Label();
            this.lblMissShot = new System.Windows.Forms.Label();
            this.lblTotalShot = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblLevel = new System.Windows.Forms.Label();
            this.blood = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blood)).BeginInit();
            this.SuspendLayout();
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.BackColor = System.Drawing.Color.Lime;
            this.lblScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.Location = new System.Drawing.Point(39, 26);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(68, 25);
            this.lblScore.TabIndex = 0;
            this.lblScore.Text = "Score";
            // 
            // lblMissShot
            // 
            this.lblMissShot.AutoSize = true;
            this.lblMissShot.BackColor = System.Drawing.Color.Red;
            this.lblMissShot.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMissShot.Location = new System.Drawing.Point(39, 51);
            this.lblMissShot.Name = "lblMissShot";
            this.lblMissShot.Size = new System.Drawing.Size(104, 25);
            this.lblMissShot.TabIndex = 1;
            this.lblMissShot.Text = "Miss shot";
            // 
            // lblTotalShot
            // 
            this.lblTotalShot.AutoSize = true;
            this.lblTotalShot.BackColor = System.Drawing.Color.Aqua;
            this.lblTotalShot.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalShot.Location = new System.Drawing.Point(39, 76);
            this.lblTotalShot.Name = "lblTotalShot";
            this.lblTotalShot.Size = new System.Drawing.Size(122, 25);
            this.lblTotalShot.TabIndex = 2;
            this.lblTotalShot.Text = "Total Score";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-98, 371);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(102, 87);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 2000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblLevel
            // 
            this.lblLevel.AutoSize = true;
            this.lblLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLevel.Location = new System.Drawing.Point(294, 13);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(64, 25);
            this.lblLevel.TabIndex = 4;
            this.lblLevel.Text = "Level";
            // 
            // blood
            // 
            this.blood.BackColor = System.Drawing.Color.Transparent;
            this.blood.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("blood.BackgroundImage")));
            this.blood.Image = ((System.Drawing.Image)(resources.GetObject("blood.Image")));
            this.blood.Location = new System.Drawing.Point(299, 203);
            this.blood.MaximumSize = new System.Drawing.Size(100, 100);
            this.blood.MinimumSize = new System.Drawing.Size(100, 100);
            this.blood.Name = "blood";
            this.blood.Size = new System.Drawing.Size(100, 100);
            this.blood.TabIndex = 5;
            this.blood.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1084, 661);
            this.Controls.Add(this.blood);
            this.Controls.Add(this.lblLevel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblTotalShot);
            this.Controls.Add(this.lblMissShot);
            this.Controls.Add(this.lblScore);
            this.Cursor = System.Windows.Forms.Cursors.NoMove2D;
            this.DoubleBuffered = true;
            this.Name = "Form2";
            this.Text = "Form2";
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form2_MouseClick);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blood)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblMissShot;
        private System.Windows.Forms.Label lblTotalShot;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblLevel;
        private System.Windows.Forms.PictureBox blood;
    }
}