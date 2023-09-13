namespace PongGame
{
    partial class CharacterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CharacterForm));
            this.titleLabel = new System.Windows.Forms.Label();
            this.pikachuCharacter = new System.Windows.Forms.PictureBox();
            this.jigglyPuffCharacter = new System.Windows.Forms.PictureBox();
            this.bulbasaurCharacter = new System.Windows.Forms.PictureBox();
            this.eeveeCharacter = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pikachuCharacter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jigglyPuffCharacter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bulbasaurCharacter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eeveeCharacter)).BeginInit();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.Font = new System.Drawing.Font("Segoe Script", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.titleLabel.Location = new System.Drawing.Point(65, 40);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(674, 78);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Click a character";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pikachuCharacter
            // 
            this.pikachuCharacter.Image = ((System.Drawing.Image)(resources.GetObject("pikachuCharacter.Image")));
            this.pikachuCharacter.Location = new System.Drawing.Point(25, 163);
            this.pikachuCharacter.Name = "pikachuCharacter";
            this.pikachuCharacter.Size = new System.Drawing.Size(160, 160);
            this.pikachuCharacter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pikachuCharacter.TabIndex = 1;
            this.pikachuCharacter.TabStop = false;
            this.pikachuCharacter.Click += new System.EventHandler(this.pikachuCharacter_Click);
            // 
            // jigglyPuffCharacter
            // 
            this.jigglyPuffCharacter.Image = ((System.Drawing.Image)(resources.GetObject("jigglyPuffCharacter.Image")));
            this.jigglyPuffCharacter.Location = new System.Drawing.Point(219, 163);
            this.jigglyPuffCharacter.Name = "jigglyPuffCharacter";
            this.jigglyPuffCharacter.Size = new System.Drawing.Size(160, 160);
            this.jigglyPuffCharacter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.jigglyPuffCharacter.TabIndex = 2;
            this.jigglyPuffCharacter.TabStop = false;
            this.jigglyPuffCharacter.Click += new System.EventHandler(this.jigglyPuffCharacter_Click);
            // 
            // bulbasaurCharacter
            // 
            this.bulbasaurCharacter.Image = ((System.Drawing.Image)(resources.GetObject("bulbasaurCharacter.Image")));
            this.bulbasaurCharacter.Location = new System.Drawing.Point(425, 163);
            this.bulbasaurCharacter.Name = "bulbasaurCharacter";
            this.bulbasaurCharacter.Size = new System.Drawing.Size(160, 160);
            this.bulbasaurCharacter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bulbasaurCharacter.TabIndex = 3;
            this.bulbasaurCharacter.TabStop = false;
            this.bulbasaurCharacter.Click += new System.EventHandler(this.bulbasaurCharacter_Click);
            // 
            // eeveeCharacter
            // 
            this.eeveeCharacter.Image = ((System.Drawing.Image)(resources.GetObject("eeveeCharacter.Image")));
            this.eeveeCharacter.Location = new System.Drawing.Point(628, 163);
            this.eeveeCharacter.Name = "eeveeCharacter";
            this.eeveeCharacter.Size = new System.Drawing.Size(160, 160);
            this.eeveeCharacter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.eeveeCharacter.TabIndex = 4;
            this.eeveeCharacter.TabStop = false;
            this.eeveeCharacter.Click += new System.EventHandler(this.eeveeCharacter_Click);
            // 
            // CharacterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.eeveeCharacter);
            this.Controls.Add(this.bulbasaurCharacter);
            this.Controls.Add(this.jigglyPuffCharacter);
            this.Controls.Add(this.pikachuCharacter);
            this.Controls.Add(this.titleLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(816, 489);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "CharacterForm";
            this.Text = "Choose a Character";
            ((System.ComponentModel.ISupportInitialize)(this.pikachuCharacter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jigglyPuffCharacter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bulbasaurCharacter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eeveeCharacter)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.PictureBox pikachuCharacter;
        private System.Windows.Forms.PictureBox jigglyPuffCharacter;
        private System.Windows.Forms.PictureBox bulbasaurCharacter;
        private System.Windows.Forms.PictureBox eeveeCharacter;
    }
}