
namespace TirrekSimulatorRedux
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.title = new System.Windows.Forms.Label();
            this.moneyAndKekoluk = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.walk = new System.Windows.Forms.Button();
            this.Squat = new System.Windows.Forms.Button();
            this.bagcılarInfo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // title
            // 
            resources.ApplyResources(this.title, "title");
            this.title.Name = "title";
            // 
            // moneyAndKekoluk
            // 
            resources.ApplyResources(this.moneyAndKekoluk, "moneyAndKekoluk");
            this.moneyAndKekoluk.Name = "moneyAndKekoluk";
            this.moneyAndKekoluk.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // walk
            // 
            resources.ApplyResources(this.walk, "walk");
            this.walk.Name = "walk";
            this.walk.UseVisualStyleBackColor = true;
            // 
            // Squat
            // 
            resources.ApplyResources(this.Squat, "Squat");
            this.Squat.Name = "Squat";
            this.Squat.UseVisualStyleBackColor = true;
            // 
            // bagcılarInfo
            // 
            resources.ApplyResources(this.bagcılarInfo, "bagcılarInfo");
            this.bagcılarInfo.Name = "bagcılarInfo";
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bagcılarInfo);
            this.Controls.Add(this.Squat);
            this.Controls.Add(this.walk);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.moneyAndKekoluk);
            this.Controls.Add(this.title);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label moneyAndKekoluk;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button walk;
        private System.Windows.Forms.Button Squat;
        private System.Windows.Forms.Label bagcılarInfo;
    }
}

