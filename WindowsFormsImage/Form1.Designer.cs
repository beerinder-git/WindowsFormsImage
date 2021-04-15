
namespace WindowsFormsImage
{
    partial class Form1
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
            this.btn_ChangeImage = new System.Windows.Forms.Button();
            this.btn_PlaySound = new System.Windows.Forms.Button();
            this.lbl_Image = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_Sound = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_ChangeImage
            // 
            this.btn_ChangeImage.Location = new System.Drawing.Point(87, 70);
            this.btn_ChangeImage.Name = "btn_ChangeImage";
            this.btn_ChangeImage.Size = new System.Drawing.Size(118, 36);
            this.btn_ChangeImage.TabIndex = 1;
            this.btn_ChangeImage.Text = "Change_Image";
            this.btn_ChangeImage.UseVisualStyleBackColor = true;
            this.btn_ChangeImage.Click += new System.EventHandler(this.btn_ChangeImage_Click);
            // 
            // btn_PlaySound
            // 
            this.btn_PlaySound.Location = new System.Drawing.Point(87, 182);
            this.btn_PlaySound.Name = "btn_PlaySound";
            this.btn_PlaySound.Size = new System.Drawing.Size(118, 38);
            this.btn_PlaySound.TabIndex = 3;
            this.btn_PlaySound.Text = "Play_Sound";
            this.btn_PlaySound.UseVisualStyleBackColor = true;
            this.btn_PlaySound.Click += new System.EventHandler(this.btn_PlaySound_Click);
            // 
            // lbl_Image
            // 
            this.lbl_Image.Location = new System.Drawing.Point(471, 302);
            this.lbl_Image.Name = "lbl_Image";
            this.lbl_Image.Size = new System.Drawing.Size(100, 23);
            this.lbl_Image.TabIndex = 4;
            this.lbl_Image.Text = "Original_Image";
            this.lbl_Image.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::WindowsFormsImage.Properties.Resources.gun_to_head;
            this.pictureBox1.Image = global::WindowsFormsImage.Properties.Resources.images;
            this.pictureBox1.Location = new System.Drawing.Point(395, 70);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(228, 204);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lbl_Sound
            // 
            this.lbl_Sound.Location = new System.Drawing.Point(144, 260);
            this.lbl_Sound.Name = "lbl_Sound";
            this.lbl_Sound.Size = new System.Drawing.Size(100, 23);
            this.lbl_Sound.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_Sound);
            this.Controls.Add(this.lbl_Image);
            this.Controls.Add(this.btn_PlaySound);
            this.Controls.Add(this.btn_ChangeImage);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_ChangeImage;
        private System.Windows.Forms.Button btn_PlaySound;
        private System.Windows.Forms.Label lbl_Image;
        private System.Windows.Forms.Label lbl_Sound;
    }
}

