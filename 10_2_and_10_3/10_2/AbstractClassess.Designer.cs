namespace AbstractClasses
{
    partial class AbstractClasses
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnGetHours = new System.Windows.Forms.Button();
            this.lblOutPutRequiredHours = new System.Windows.Forms.Label();
            this.lblRequiredHours = new System.Windows.Forms.Label();
            this.rbSoftwareEngineering = new System.Windows.Forms.RadioButton();
            this.rbInfoSystems = new System.Windows.Forms.RadioButton();
            this.lblRadioBtn = new System.Windows.Forms.Label();
            this.tbIDNumber = new System.Windows.Forms.TextBox();
            this.tbStudentName = new System.Windows.Forms.TextBox();
            this.lblIDNumber = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnOtherForm = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(118, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Computer Sience Student";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnGetHours);
            this.groupBox1.Controls.Add(this.lblOutPutRequiredHours);
            this.groupBox1.Controls.Add(this.lblRequiredHours);
            this.groupBox1.Controls.Add(this.rbSoftwareEngineering);
            this.groupBox1.Controls.Add(this.rbInfoSystems);
            this.groupBox1.Controls.Add(this.lblRadioBtn);
            this.groupBox1.Controls.Add(this.tbIDNumber);
            this.groupBox1.Controls.Add(this.tbStudentName);
            this.groupBox1.Controls.Add(this.lblIDNumber);
            this.groupBox1.Controls.Add(this.lblName);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(16, 60);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(399, 303);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Student Data";
            // 
            // btnGetHours
            // 
            this.btnGetHours.Location = new System.Drawing.Point(48, 244);
            this.btnGetHours.Margin = new System.Windows.Forms.Padding(4);
            this.btnGetHours.Name = "btnGetHours";
            this.btnGetHours.Size = new System.Drawing.Size(324, 51);
            this.btnGetHours.TabIndex = 9;
            this.btnGetHours.Text = "&Get Required Hours";
            this.btnGetHours.UseVisualStyleBackColor = true;
            this.btnGetHours.Click += new System.EventHandler(this.btnGetHours_Click);
            // 
            // lblOutPutRequiredHours
            // 
            this.lblOutPutRequiredHours.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblOutPutRequiredHours.Location = new System.Drawing.Point(179, 187);
            this.lblOutPutRequiredHours.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOutPutRequiredHours.Name = "lblOutPutRequiredHours";
            this.lblOutPutRequiredHours.Size = new System.Drawing.Size(193, 41);
            this.lblOutPutRequiredHours.TabIndex = 8;
            this.lblOutPutRequiredHours.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRequiredHours
            // 
            this.lblRequiredHours.AutoSize = true;
            this.lblRequiredHours.Location = new System.Drawing.Point(45, 199);
            this.lblRequiredHours.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRequiredHours.Name = "lblRequiredHours";
            this.lblRequiredHours.Size = new System.Drawing.Size(109, 16);
            this.lblRequiredHours.TabIndex = 7;
            this.lblRequiredHours.Text = "Required Hours :";
            // 
            // rbSoftwareEngineering
            // 
            this.rbSoftwareEngineering.AutoSize = true;
            this.rbSoftwareEngineering.Location = new System.Drawing.Point(179, 148);
            this.rbSoftwareEngineering.Margin = new System.Windows.Forms.Padding(4);
            this.rbSoftwareEngineering.Name = "rbSoftwareEngineering";
            this.rbSoftwareEngineering.Size = new System.Drawing.Size(153, 20);
            this.rbSoftwareEngineering.TabIndex = 6;
            this.rbSoftwareEngineering.TabStop = true;
            this.rbSoftwareEngineering.Text = "Software Engineering";
            this.rbSoftwareEngineering.UseVisualStyleBackColor = true;
            // 
            // rbInfoSystems
            // 
            this.rbInfoSystems.AutoSize = true;
            this.rbInfoSystems.Location = new System.Drawing.Point(179, 116);
            this.rbInfoSystems.Margin = new System.Windows.Forms.Padding(4);
            this.rbInfoSystems.Name = "rbInfoSystems";
            this.rbInfoSystems.Size = new System.Drawing.Size(146, 20);
            this.rbInfoSystems.TabIndex = 5;
            this.rbInfoSystems.TabStop = true;
            this.rbInfoSystems.Text = "Information Systems";
            this.rbInfoSystems.UseVisualStyleBackColor = true;
            // 
            // lblRadioBtn
            // 
            this.lblRadioBtn.AutoSize = true;
            this.lblRadioBtn.Location = new System.Drawing.Point(34, 132);
            this.lblRadioBtn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRadioBtn.Name = "lblRadioBtn";
            this.lblRadioBtn.Size = new System.Drawing.Size(120, 16);
            this.lblRadioBtn.TabIndex = 4;
            this.lblRadioBtn.Text = "Achademic Track :";
            // 
            // tbIDNumber
            // 
            this.tbIDNumber.Location = new System.Drawing.Point(179, 78);
            this.tbIDNumber.Margin = new System.Windows.Forms.Padding(4);
            this.tbIDNumber.Name = "tbIDNumber";
            this.tbIDNumber.Size = new System.Drawing.Size(204, 22);
            this.tbIDNumber.TabIndex = 3;
            // 
            // tbStudentName
            // 
            this.tbStudentName.Location = new System.Drawing.Point(179, 43);
            this.tbStudentName.Margin = new System.Windows.Forms.Padding(4);
            this.tbStudentName.Name = "tbStudentName";
            this.tbStudentName.Size = new System.Drawing.Size(204, 22);
            this.tbStudentName.TabIndex = 2;
            // 
            // lblIDNumber
            // 
            this.lblIDNumber.AutoSize = true;
            this.lblIDNumber.Location = new System.Drawing.Point(76, 81);
            this.lblIDNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIDNumber.Name = "lblIDNumber";
            this.lblIDNumber.Size = new System.Drawing.Size(78, 16);
            this.lblIDNumber.TabIndex = 1;
            this.lblIDNumber.Text = "ID Number :";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(103, 47);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(51, 16);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name :";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuStrip1.Size = new System.Drawing.Size(423, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.exitToolStripMenuItem.Text = "&Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // btnOtherForm
            // 
            this.btnOtherForm.Location = new System.Drawing.Point(259, 370);
            this.btnOtherForm.Name = "btnOtherForm";
            this.btnOtherForm.Size = new System.Drawing.Size(156, 28);
            this.btnOtherForm.TabIndex = 3;
            this.btnOtherForm.Text = "&Tutorial 10.2";
            this.btnOtherForm.UseVisualStyleBackColor = true;
            this.btnOtherForm.Click += new System.EventHandler(this.btnOtherForm_Click);
            // 
            // AbstractClasses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 403);
            this.Controls.Add(this.btnOtherForm);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AbstractClasses";
            this.Text = "10.3 Abstract Classes";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbSoftwareEngineering;
        private System.Windows.Forms.RadioButton rbInfoSystems;
        private System.Windows.Forms.Label lblRadioBtn;
        private System.Windows.Forms.TextBox tbIDNumber;
        private System.Windows.Forms.TextBox tbStudentName;
        private System.Windows.Forms.Label lblIDNumber;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblOutPutRequiredHours;
        private System.Windows.Forms.Label lblRequiredHours;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button btnGetHours;
        private System.Windows.Forms.Button btnOtherForm;
    }
}