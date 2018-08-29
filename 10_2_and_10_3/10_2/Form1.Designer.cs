namespace _10_2
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
            this.btnCreateAnimal = new System.Windows.Forms.Button();
            this.btnCreateDog = new System.Windows.Forms.Button();
            this.btnCreateCat = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCreateAnimal
            // 
            this.btnCreateAnimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateAnimal.Location = new System.Drawing.Point(14, 33);
            this.btnCreateAnimal.Name = "btnCreateAnimal";
            this.btnCreateAnimal.Size = new System.Drawing.Size(88, 44);
            this.btnCreateAnimal.TabIndex = 0;
            this.btnCreateAnimal.Text = "Create an Animal";
            this.btnCreateAnimal.UseVisualStyleBackColor = true;
            this.btnCreateAnimal.Click += new System.EventHandler(this.btnCreateAnimal_Click);
            // 
            // btnCreateDog
            // 
            this.btnCreateDog.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateDog.Location = new System.Drawing.Point(109, 33);
            this.btnCreateDog.Name = "btnCreateDog";
            this.btnCreateDog.Size = new System.Drawing.Size(85, 44);
            this.btnCreateDog.TabIndex = 1;
            this.btnCreateDog.Text = "Create a Dog";
            this.btnCreateDog.UseVisualStyleBackColor = true;
            this.btnCreateDog.Click += new System.EventHandler(this.btnCreateDog_Click);
            // 
            // btnCreateCat
            // 
            this.btnCreateCat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateCat.Location = new System.Drawing.Point(201, 33);
            this.btnCreateCat.Name = "btnCreateCat";
            this.btnCreateCat.Size = new System.Drawing.Size(85, 44);
            this.btnCreateCat.TabIndex = 2;
            this.btnCreateCat.Text = "Create a Cat";
            this.btnCreateCat.UseVisualStyleBackColor = true;
            this.btnCreateCat.Click += new System.EventHandler(this.btnCreateCat_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(14, 83);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(272, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Go to Tutorial 10.2";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuStrip1.Size = new System.Drawing.Size(298, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.exitToolStripMenuItem.Text = "&Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 119);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnCreateCat);
            this.Controls.Add(this.btnCreateDog);
            this.Controls.Add(this.btnCreateAnimal);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "10.2 Polymorphism";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCreateAnimal;
        private System.Windows.Forms.Button btnCreateDog;
        private System.Windows.Forms.Button btnCreateCat;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}

