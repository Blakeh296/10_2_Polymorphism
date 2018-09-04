namespace _10_2
{
    partial class Polymorphism
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
            this.lbOutPut = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCreateAnimal
            // 
            this.btnCreateAnimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateAnimal.Location = new System.Drawing.Point(11, 114);
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
            this.btnCreateDog.Location = new System.Drawing.Point(106, 114);
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
            this.btnCreateCat.Location = new System.Drawing.Point(198, 114);
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
            this.button1.Location = new System.Drawing.Point(9, 164);
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
            this.exitToolStripMenuItem,
            this.clearToolStripMenuItem});
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
            // lbOutPut
            // 
            this.lbOutPut.FormattingEnabled = true;
            this.lbOutPut.Location = new System.Drawing.Point(12, 52);
            this.lbOutPut.Name = "lbOutPut";
            this.lbOutPut.Size = new System.Drawing.Size(269, 56);
            this.lbOutPut.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Animal(s) :";
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.clearToolStripMenuItem.Text = "&Clear";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // Polymorphism
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 195);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbOutPut);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnCreateCat);
            this.Controls.Add(this.btnCreateDog);
            this.Controls.Add(this.btnCreateAnimal);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Polymorphism";
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
        private System.Windows.Forms.ListBox lbOutPut;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
    }
}

