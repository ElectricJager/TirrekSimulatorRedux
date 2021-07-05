
namespace TirrekSimulatorRedux
{
    partial class SplashScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SplashScreen));
            this.label1 = new System.Windows.Forms.Label();
            this.githubLink = new System.Windows.Forms.LinkLabel();
            this.version = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(400, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tirrek Simulator Redux";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // githubLink
            // 
            this.githubLink.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.githubLink.Location = new System.Drawing.Point(4, 251);
            this.githubLink.Name = "githubLink";
            this.githubLink.Size = new System.Drawing.Size(400, 13);
            this.githubLink.TabIndex = 69;
            this.githubLink.TabStop = true;
            this.githubLink.Text = "https://github.com/ElectricJager/TirrekSimulatorRedux";
            this.githubLink.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.githubLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.githubLink_LinkClicked);
            // 
            // version
            // 
            this.version.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.version.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.version.Location = new System.Drawing.Point(0, 50);
            this.version.Name = "version";
            this.version.Size = new System.Drawing.Size(400, 24);
            this.version.TabIndex = 70;
            this.version.Text = "0.1.0 © 2021 ElectricJager";
            this.version.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(22, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(357, 158);
            this.label2.TabIndex = 71;
            this.label2.Text = resources.GetString("label2.Text");
            // 
            // SplashScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 273);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.version);
            this.Controls.Add(this.githubLink);
            this.Controls.Add(this.label1);
            this.Name = "SplashScreen";
            this.Text = "SplashScreen";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel githubLink;
        private System.Windows.Forms.Label version;
        private System.Windows.Forms.Label label2;
    }
}