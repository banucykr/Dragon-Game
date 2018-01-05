namespace oyun
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
            this.txtname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbmage = new System.Windows.Forms.RadioButton();
            this.rbwarrior = new System.Windows.Forms.RadioButton();
            this.btnbattle = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(131, 31);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(100, 20);
            this.txtname.TabIndex = 0;
            this.txtname.TextChanged += new System.EventHandler(this.txtname_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbmage);
            this.groupBox1.Controls.Add(this.rbwarrior);
            this.groupBox1.Location = new System.Drawing.Point(131, 83);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(157, 106);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Choose Your Hero";
            // 
            // rbmage
            // 
            this.rbmage.AutoSize = true;
            this.rbmage.Location = new System.Drawing.Point(16, 66);
            this.rbmage.Name = "rbmage";
            this.rbmage.Size = new System.Drawing.Size(52, 17);
            this.rbmage.TabIndex = 1;
            this.rbmage.Text = "Mage";
            this.rbmage.UseVisualStyleBackColor = true;
            // 
            // rbwarrior
            // 
            this.rbwarrior.AutoSize = true;
            this.rbwarrior.Checked = true;
            this.rbwarrior.Location = new System.Drawing.Point(16, 33);
            this.rbwarrior.Name = "rbwarrior";
            this.rbwarrior.Size = new System.Drawing.Size(59, 17);
            this.rbwarrior.TabIndex = 0;
            this.rbwarrior.TabStop = true;
            this.rbwarrior.Text = "Warrior";
            this.rbwarrior.UseVisualStyleBackColor = true;
            // 
            // btnbattle
            // 
            this.btnbattle.Location = new System.Drawing.Point(131, 209);
            this.btnbattle.Name = "btnbattle";
            this.btnbattle.Size = new System.Drawing.Size(132, 38);
            this.btnbattle.TabIndex = 3;
            this.btnbattle.Text = "To Battle!";
            this.btnbattle.UseVisualStyleBackColor = true;
            this.btnbattle.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnexit
            // 
            this.btnexit.Location = new System.Drawing.Point(258, 253);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(75, 23);
            this.btnexit.TabIndex = 4;
            this.btnexit.Text = "Quit";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 318);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnbattle);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtname);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbmage;
        private System.Windows.Forms.RadioButton rbwarrior;
        private System.Windows.Forms.Button btnbattle;
        private System.Windows.Forms.Button btnexit;
    }
}

