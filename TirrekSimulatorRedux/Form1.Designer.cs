
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
            this.money = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.walk = new System.Windows.Forms.Button();
            this.Squat = new System.Windows.Forms.Button();
            this.bagcılarInfo = new System.Windows.Forms.Label();
            this.health = new System.Windows.Forms.Label();
            this.hunger = new System.Windows.Forms.Label();
            this.thirst = new System.Windows.Forms.Label();
            this.kekoluk = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
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
            // money
            // 
            resources.ApplyResources(this.money, "money");
            this.money.Name = "money";
            this.money.Click += new System.EventHandler(this.label2_Click);
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
            // health
            // 
            resources.ApplyResources(this.health, "health");
            this.health.Name = "health";
            // 
            // hunger
            // 
            resources.ApplyResources(this.hunger, "hunger");
            this.hunger.Name = "hunger";
            // 
            // thirst
            // 
            resources.ApplyResources(this.thirst, "thirst");
            this.thirst.Name = "thirst";
            // 
            // kekoluk
            // 
            resources.ApplyResources(this.kekoluk, "kekoluk");
            this.kekoluk.Name = "kekoluk";
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            resources.ApplyResources(this.pictureBox2, "pictureBox2");
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.kekoluk);
            this.Controls.Add(this.thirst);
            this.Controls.Add(this.hunger);
            this.Controls.Add(this.health);
            this.Controls.Add(this.bagcılarInfo);
            this.Controls.Add(this.Squat);
            this.Controls.Add(this.walk);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.money);
            this.Controls.Add(this.title);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label money;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button walk;
        private System.Windows.Forms.Button Squat;
        private System.Windows.Forms.Label bagcılarInfo;
        private System.Windows.Forms.Label health;
        private System.Windows.Forms.Label hunger;
        private System.Windows.Forms.Label thirst;
        private System.Windows.Forms.Label kekoluk;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

