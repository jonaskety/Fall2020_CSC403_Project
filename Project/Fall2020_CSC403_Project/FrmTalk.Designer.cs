namespace Fall2020_CSC403_Project
{
    partial class FrmTalk
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTalk));
            this.picPlayer = new System.Windows.Forms.PictureBox();
            this.picNPC = new System.Windows.Forms.PictureBox();
            this.labelNPC = new System.Windows.Forms.Label();
            this.btnContinue = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNPC)).BeginInit();
            this.SuspendLayout();
            // 
            // picPlayer
            // 
            this.picPlayer.BackColor = System.Drawing.SystemColors.ControlLight;
            this.picPlayer.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.player;
            resources.ApplyResources(this.picPlayer, "picPlayer");
            this.picPlayer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picPlayer.Name = "picPlayer";
            this.picPlayer.TabStop = false;
            // 
            // picNPC
            // 
            this.picNPC.BackColor = System.Drawing.SystemColors.ControlLight;
            this.picNPC.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.player;
            resources.ApplyResources(this.picNPC, "picNPC");
            this.picNPC.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picNPC.Name = "picNPC";
            this.picNPC.TabStop = false;
            // 
            // labelNPC
            // 
            resources.ApplyResources(this.labelNPC, "labelNPC");
            this.labelNPC.Name = "labelNPC";
            // 
            // btnContinue
            // 
            resources.ApplyResources(this.btnContinue, "btnContinue");
            this.btnContinue.Name = "btnContinue";
            this.btnContinue.UseVisualStyleBackColor = true;
            this.btnContinue.Click += new System.EventHandler(this.btnContinue_Click);
            // 
            // FrmTalk
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ControlBox = false;
            this.Controls.Add(this.btnContinue);
            this.Controls.Add(this.labelNPC);
            this.Controls.Add(this.picPlayer);
            this.Controls.Add(this.picNPC);
            this.KeyPreview = true;
            this.Name = "FrmTalk";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmTalk_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNPC)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picPlayer;
        private System.Windows.Forms.PictureBox picNPC;
        private System.Windows.Forms.Label labelNPC;
        private System.Windows.Forms.Button btnContinue;
    }
}