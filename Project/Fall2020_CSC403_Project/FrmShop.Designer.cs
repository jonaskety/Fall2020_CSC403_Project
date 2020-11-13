namespace Fall2020_CSC403_Project
{
    partial class FrmShop
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmShop));
            this.labelMerchant = new System.Windows.Forms.Label();
            this.btnContinue = new System.Windows.Forms.Button();
            this.btnLeave = new System.Windows.Forms.Button();
            this.picMerchantItem3 = new System.Windows.Forms.PictureBox();
            this.picMerchantItem2 = new System.Windows.Forms.PictureBox();
            this.picMerchantItem1 = new System.Windows.Forms.PictureBox();
            this.picNPCMerchant = new System.Windows.Forms.PictureBox();
            this.picPlayer = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picMerchantItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMerchantItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMerchantItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNPCMerchant)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // labelMerchant
            // 
            this.labelMerchant.Location = new System.Drawing.Point(238, 210);
            this.labelMerchant.Name = "labelMerchant";
            this.labelMerchant.Size = new System.Drawing.Size(358, 42);
            this.labelMerchant.TabIndex = 2;
            this.labelMerchant.Text = "label1";
            this.labelMerchant.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnContinue
            // 
            this.btnContinue.Location = new System.Drawing.Point(169, 282);
            this.btnContinue.Name = "btnContinue";
            this.btnContinue.Size = new System.Drawing.Size(75, 23);
            this.btnContinue.TabIndex = 3;
            this.btnContinue.Text = "Continue";
            this.btnContinue.UseVisualStyleBackColor = true;
            this.btnContinue.Click += new System.EventHandler(this.btnContinue_Click);
            // 
            // btnLeave
            // 
            this.btnLeave.Location = new System.Drawing.Point(68, 282);
            this.btnLeave.Name = "btnLeave";
            this.btnLeave.Size = new System.Drawing.Size(75, 23);
            this.btnLeave.TabIndex = 7;
            this.btnLeave.Text = "Leave";
            this.btnLeave.UseVisualStyleBackColor = true;
            this.btnLeave.Click += new System.EventHandler(this.btnLeave_Click);
            // 
            // picMerchantItem3
            // 
            this.picMerchantItem3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picMerchantItem3.BackgroundImage")));
            this.picMerchantItem3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picMerchantItem3.Location = new System.Drawing.Point(464, 255);
            this.picMerchantItem3.Name = "picMerchantItem3";
            this.picMerchantItem3.Size = new System.Drawing.Size(63, 74);
            this.picMerchantItem3.TabIndex = 6;
            this.picMerchantItem3.TabStop = false;
            this.picMerchantItem3.Visible = false;
            this.picMerchantItem3.Click += new System.EventHandler(this.picMerchantItem3_Click);
            // 
            // picMerchantItem2
            // 
            this.picMerchantItem2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picMerchantItem2.BackgroundImage")));
            this.picMerchantItem2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picMerchantItem2.Location = new System.Drawing.Point(384, 255);
            this.picMerchantItem2.Name = "picMerchantItem2";
            this.picMerchantItem2.Size = new System.Drawing.Size(63, 74);
            this.picMerchantItem2.TabIndex = 5;
            this.picMerchantItem2.TabStop = false;
            this.picMerchantItem2.Visible = false;
            this.picMerchantItem2.Click += new System.EventHandler(this.picMerchantItem2_Click);
            // 
            // picMerchantItem1
            // 
            this.picMerchantItem1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picMerchantItem1.BackgroundImage")));
            this.picMerchantItem1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picMerchantItem1.Location = new System.Drawing.Point(306, 255);
            this.picMerchantItem1.Name = "picMerchantItem1";
            this.picMerchantItem1.Size = new System.Drawing.Size(63, 74);
            this.picMerchantItem1.TabIndex = 4;
            this.picMerchantItem1.TabStop = false;
            this.picMerchantItem1.Visible = false;
            this.picMerchantItem1.Click += new System.EventHandler(this.picMerchantItem1_Click);
            // 
            // picNPCMerchant
            // 
            this.picNPCMerchant.BackColor = System.Drawing.SystemColors.ControlLight;
            this.picNPCMerchant.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.player;
            this.picNPCMerchant.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picNPCMerchant.Location = new System.Drawing.Point(369, 88);
            this.picNPCMerchant.Name = "picNPCMerchant";
            this.picNPCMerchant.Size = new System.Drawing.Size(96, 119);
            this.picNPCMerchant.TabIndex = 1;
            this.picNPCMerchant.TabStop = false;
            // 
            // picPlayer
            // 
            this.picPlayer.BackColor = System.Drawing.SystemColors.ControlLight;
            this.picPlayer.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.player;
            this.picPlayer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picPlayer.Location = new System.Drawing.Point(121, 141);
            this.picPlayer.Name = "picPlayer";
            this.picPlayer.Size = new System.Drawing.Size(71, 117);
            this.picPlayer.TabIndex = 0;
            this.picPlayer.TabStop = false;
            // 
            // FrmShop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.btnLeave);
            this.Controls.Add(this.picMerchantItem3);
            this.Controls.Add(this.picMerchantItem2);
            this.Controls.Add(this.picMerchantItem1);
            this.Controls.Add(this.btnContinue);
            this.Controls.Add(this.labelMerchant);
            this.Controls.Add(this.picNPCMerchant);
            this.Controls.Add(this.picPlayer);
            this.KeyPreview = true;
            this.Name = "FrmShop";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmShop_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmShop_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.picMerchantItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMerchantItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMerchantItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNPCMerchant)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picPlayer;
        private System.Windows.Forms.PictureBox picNPCMerchant;
        private System.Windows.Forms.Label labelMerchant;
        private System.Windows.Forms.Button btnContinue;
        private System.Windows.Forms.PictureBox picMerchantItem1;
        private System.Windows.Forms.PictureBox picMerchantItem2;
        private System.Windows.Forms.PictureBox picMerchantItem3;
        private System.Windows.Forms.Button btnLeave;
    }
}