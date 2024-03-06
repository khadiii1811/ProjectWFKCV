namespace ProjectFinalWF
{
    partial class SignUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUp));
            this.ucSignUp1 = new ProjectFinalWF.UCSignUp();
            this.ucNavigator1 = new ProjectFinalWF.UCNavigator();
            this.SuspendLayout();
            // 
            // ucSignUp1
            // 
            this.ucSignUp1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ucSignUp1.BackgroundImage")));
            this.ucSignUp1.Location = new System.Drawing.Point(0, 0);
            this.ucSignUp1.Name = "ucSignUp1";
            this.ucSignUp1.Size = new System.Drawing.Size(1264, 513);
            this.ucSignUp1.TabIndex = 0;
            // 
            // ucNavigator1
            // 
            this.ucNavigator1.BackgroundImage = global::ProjectFinalWF.Properties.Resources._5_dieu_can_biet_khi_thiet_ke_website_du_lich__1_;
            this.ucNavigator1.Location = new System.Drawing.Point(0, 0);
            this.ucNavigator1.Name = "ucNavigator1";
            this.ucNavigator1.Size = new System.Drawing.Size(236, 515);
            this.ucNavigator1.TabIndex = 1;
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1204, 482);
            this.Controls.Add(this.ucNavigator1);
            this.Controls.Add(this.ucSignUp1);
            this.Name = "SignUp";
            this.Text = "SignUp";
            this.ResumeLayout(false);

        }

        #endregion

        private UCSignUp ucSignUp1;
        private UCNavigator ucNavigator1;
    }
}