namespace Fall2020_CSC403_Project
{
    partial class FrmCharacter
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
            this.character = new System.Windows.Forms.Label();
            this.picMrPeanut = new System.Windows.Forms.PictureBox();
            this.picLadyPeanut = new System.Windows.Forms.PictureBox();
            this.picIRLPeanut = new System.Windows.Forms.PictureBox();
            this.picKingPeanut = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picMrPeanut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLadyPeanut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picIRLPeanut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picKingPeanut)).BeginInit();
            this.SuspendLayout();
            // 
            // character
            // 
            this.character.AutoSize = true;
            this.character.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.25F);
            this.character.Location = new System.Drawing.Point(202, 40);
            this.character.Name = "character";
            this.character.Size = new System.Drawing.Size(377, 39);
            this.character.TabIndex = 0;
            this.character.Text = "Choose your Character!";
            // 
            // picMrPeanut
            // 
            this.picMrPeanut.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.player;
            this.picMrPeanut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picMrPeanut.Location = new System.Drawing.Point(58, 122);
            this.picMrPeanut.Name = "picMrPeanut";
            this.picMrPeanut.Size = new System.Drawing.Size(138, 214);
            this.picMrPeanut.TabIndex = 1;
            this.picMrPeanut.TabStop = false;
            this.picMrPeanut.Click += new System.EventHandler(this.picMrPeanut_Click);
            // 
            // picLadyPeanut
            // 
            this.picLadyPeanut.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.ladypeanut;
            this.picLadyPeanut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picLadyPeanut.Location = new System.Drawing.Point(241, 122);
            this.picLadyPeanut.Name = "picLadyPeanut";
            this.picLadyPeanut.Size = new System.Drawing.Size(138, 214);
            this.picLadyPeanut.TabIndex = 2;
            this.picLadyPeanut.TabStop = false;
            this.picLadyPeanut.Click += new System.EventHandler(this.picLadyPeanut_Click);
            // 
            // picIRLPeanut
            // 
            this.picIRLPeanut.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.irlpeanut;
            this.picIRLPeanut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picIRLPeanut.Location = new System.Drawing.Point(607, 122);
            this.picIRLPeanut.Name = "picIRLPeanut";
            this.picIRLPeanut.Size = new System.Drawing.Size(138, 214);
            this.picIRLPeanut.TabIndex = 3;
            this.picIRLPeanut.TabStop = false;
            this.picIRLPeanut.Click += new System.EventHandler(this.picIRLPeanut_Click);
            // 
            // picKingPeanut
            // 
            this.picKingPeanut.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.kingpeanut;
            this.picKingPeanut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picKingPeanut.Location = new System.Drawing.Point(423, 122);
            this.picKingPeanut.Name = "picKingPeanut";
            this.picKingPeanut.Size = new System.Drawing.Size(138, 214);
            this.picKingPeanut.TabIndex = 4;
            this.picKingPeanut.TabStop = false;
            this.picKingPeanut.Click += new System.EventHandler(this.picKingPeanut_Click);
            // 
            // FrmCharacter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.picKingPeanut);
            this.Controls.Add(this.picIRLPeanut);
            this.Controls.Add(this.picLadyPeanut);
            this.Controls.Add(this.picMrPeanut);
            this.Controls.Add(this.character);
            this.Name = "FrmCharacter";
            this.Text = "Character Selection";
            ((System.ComponentModel.ISupportInitialize)(this.picMrPeanut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLadyPeanut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picIRLPeanut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picKingPeanut)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label character;
        private System.Windows.Forms.PictureBox picMrPeanut;
        private System.Windows.Forms.PictureBox picLadyPeanut;
        private System.Windows.Forms.PictureBox picIRLPeanut;
        private System.Windows.Forms.PictureBox picKingPeanut;
    }
}