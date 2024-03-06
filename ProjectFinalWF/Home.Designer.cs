namespace ProjectFinalWF
{
    partial class Home
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
            this.ucNavigator1 = new ProjectFinalWF.UCNavigator();
            this.SuspendLayout();
            // 
            // ucNavigator1
            // 
            this.ucNavigator1.BackgroundImage = global::ProjectFinalWF.Properties.Resources._5_dieu_can_biet_khi_thiet_ke_website_du_lich__1_;
            this.ucNavigator1.Location = new System.Drawing.Point(0, 0);
            this.ucNavigator1.Name = "ucNavigator1";
            this.ucNavigator1.Size = new System.Drawing.Size(236, 515);
            this.ucNavigator1.TabIndex = 0;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1066, 460);
            this.Controls.Add(this.ucNavigator1);
            this.Name = "Home";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private UCNavigator ucNavigator1;
    }
}