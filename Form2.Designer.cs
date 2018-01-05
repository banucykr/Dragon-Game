namespace oyun
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            this.grpname = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnroll = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbldname = new System.Windows.Forms.Label();
            this.lbldattack = new System.Windows.Forms.Label();
            this.lbldhealth = new System.Windows.Forms.Label();
            this.lblyaz = new System.Windows.Forms.Label();
            this.lblplayername = new System.Windows.Forms.Label();
            this.lblplayerhealth = new System.Windows.Forms.Label();
            this.lblplayerattack = new System.Windows.Forms.Label();
            this.grpname.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpname
            // 
            this.grpname.Controls.Add(this.lblplayerattack);
            this.grpname.Controls.Add(this.lblplayerhealth);
            this.grpname.Controls.Add(this.lblplayername);
            this.grpname.Controls.Add(this.label8);
            this.grpname.Controls.Add(this.label10);
            this.grpname.Controls.Add(this.label3);
            this.grpname.Controls.Add(this.label2);
            this.grpname.Location = new System.Drawing.Point(12, 41);
            this.grpname.Name = "grpname";
            this.grpname.Size = new System.Drawing.Size(180, 189);
            this.grpname.TabIndex = 0;
            this.grpname.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.Firebrick;
            this.label8.Location = new System.Drawing.Point(17, 37);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 16);
            this.label8.TabIndex = 13;
            this.label8.Text = "Class";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(427, 39);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(0, 13);
            this.label10.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Firebrick;
            this.label3.Location = new System.Drawing.Point(14, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Attack";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Firebrick;
            this.label2.Location = new System.Drawing.Point(14, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Health";
            // 
            // btnroll
            // 
            this.btnroll.BackColor = System.Drawing.Color.Firebrick;
            this.btnroll.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnroll.ForeColor = System.Drawing.Color.Silver;
            this.btnroll.Location = new System.Drawing.Point(224, 111);
            this.btnroll.Name = "btnroll";
            this.btnroll.Size = new System.Drawing.Size(75, 50);
            this.btnroll.TabIndex = 0;
            this.btnroll.Text = "Roll";
            this.btnroll.UseVisualStyleBackColor = false;
            this.btnroll.Click += new System.EventHandler(this.btnroll_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.Firebrick;
            this.label6.Location = new System.Drawing.Point(19, 129);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "Attack";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.Firebrick;
            this.label5.Location = new System.Drawing.Point(19, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Health";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.ForeColor = System.Drawing.Color.Firebrick;
            this.label11.Location = new System.Drawing.Point(19, 34);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(47, 16);
            this.label11.TabIndex = 14;
            this.label11.Text = "Class";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbldname);
            this.groupBox2.Controls.Add(this.lbldattack);
            this.groupBox2.Controls.Add(this.lbldhealth);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(320, 44);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(185, 186);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Über Dragon";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // lbldname
            // 
            this.lbldname.AutoSize = true;
            this.lbldname.Location = new System.Drawing.Point(89, 44);
            this.lbldname.Name = "lbldname";
            this.lbldname.Size = new System.Drawing.Size(0, 13);
            this.lbldname.TabIndex = 17;
            // 
            // lbldattack
            // 
            this.lbldattack.AutoSize = true;
            this.lbldattack.Location = new System.Drawing.Point(86, 133);
            this.lbldattack.Name = "lbldattack";
            this.lbldattack.Size = new System.Drawing.Size(0, 13);
            this.lbldattack.TabIndex = 16;
            // 
            // lbldhealth
            // 
            this.lbldhealth.AutoSize = true;
            this.lbldhealth.Location = new System.Drawing.Point(83, 84);
            this.lbldhealth.Name = "lbldhealth";
            this.lbldhealth.Size = new System.Drawing.Size(0, 13);
            this.lbldhealth.TabIndex = 15;
            // 
            // lblyaz
            // 
            this.lblyaz.AutoSize = true;
            this.lblyaz.Location = new System.Drawing.Point(224, 271);
            this.lblyaz.Name = "lblyaz";
            this.lblyaz.Size = new System.Drawing.Size(0, 13);
            this.lblyaz.TabIndex = 16;
            // 
            // lblplayername
            // 
            this.lblplayername.AutoSize = true;
            this.lblplayername.Location = new System.Drawing.Point(93, 39);
            this.lblplayername.Name = "lblplayername";
            this.lblplayername.Size = new System.Drawing.Size(0, 13);
            this.lblplayername.TabIndex = 14;
            // 
            // lblplayerhealth
            // 
            this.lblplayerhealth.AutoSize = true;
            this.lblplayerhealth.Location = new System.Drawing.Point(92, 79);
            this.lblplayerhealth.Name = "lblplayerhealth";
            this.lblplayerhealth.Size = new System.Drawing.Size(0, 13);
            this.lblplayerhealth.TabIndex = 15;
            // 
            // lblplayerattack
            // 
            this.lblplayerattack.AutoSize = true;
            this.lblplayerattack.Location = new System.Drawing.Point(95, 130);
            this.lblplayerattack.Name = "lblplayerattack";
            this.lblplayerattack.Size = new System.Drawing.Size(0, 13);
            this.lblplayerattack.TabIndex = 16;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 343);
            this.Controls.Add(this.lblyaz);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.grpname);
            this.Controls.Add(this.btnroll);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.grpname.ResumeLayout(false);
            this.grpname.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpname;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnroll;
        private System.Windows.Forms.Label lblyaz;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbldattack;
        private System.Windows.Forms.Label lbldhealth;
        private System.Windows.Forms.Label lbldname;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblpname;
        private System.Windows.Forms.Label lblpattack;
        private System.Windows.Forms.Label lblphealth;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblplayerattack;
        private System.Windows.Forms.Label lblplayerhealth;
        private System.Windows.Forms.Label lblplayername;
    }
}