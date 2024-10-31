namespace SayisalLoto
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
            this.components = new System.ComponentModel.Container();
            this.btnOyna = new System.Windows.Forms.Button();
            this.lbxSansliSayilar = new System.Windows.Forms.ListBox();
            this.grpSansliSayilar = new System.Windows.Forms.GroupBox();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lbl4 = new System.Windows.Forms.Label();
            this.lbl5 = new System.Windows.Forms.Label();
            this.lbl6 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.grpSansliSayilar.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOyna
            // 
            this.btnOyna.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnOyna.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOyna.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnOyna.Location = new System.Drawing.Point(21, 9);
            this.btnOyna.Name = "btnOyna";
            this.btnOyna.Size = new System.Drawing.Size(118, 39);
            this.btnOyna.TabIndex = 0;
            this.btnOyna.Text = "PLAY";
            this.btnOyna.UseVisualStyleBackColor = false;
            this.btnOyna.Click += new System.EventHandler(this.btnOyna_Click);
            // 
            // lbxSansliSayilar
            // 
            this.lbxSansliSayilar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbxSansliSayilar.FormattingEnabled = true;
            this.lbxSansliSayilar.ItemHeight = 29;
            this.lbxSansliSayilar.Location = new System.Drawing.Point(21, 54);
            this.lbxSansliSayilar.Name = "lbxSansliSayilar";
            this.lbxSansliSayilar.Size = new System.Drawing.Size(118, 207);
            this.lbxSansliSayilar.TabIndex = 1;
            // 
            // grpSansliSayilar
            // 
            this.grpSansliSayilar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.grpSansliSayilar.Controls.Add(this.lbl6);
            this.grpSansliSayilar.Controls.Add(this.lbl5);
            this.grpSansliSayilar.Controls.Add(this.lbl4);
            this.grpSansliSayilar.Controls.Add(this.lbl3);
            this.grpSansliSayilar.Controls.Add(this.lbl2);
            this.grpSansliSayilar.Controls.Add(this.lbl1);
            this.grpSansliSayilar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpSansliSayilar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.grpSansliSayilar.Location = new System.Drawing.Point(145, 75);
            this.grpSansliSayilar.Name = "grpSansliSayilar";
            this.grpSansliSayilar.Size = new System.Drawing.Size(601, 136);
            this.grpSansliSayilar.TabIndex = 2;
            this.grpSansliSayilar.TabStop = false;
            this.grpSansliSayilar.Text = "Lucky Numbers";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl1.Location = new System.Drawing.Point(24, 44);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(83, 58);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "00";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl2.Location = new System.Drawing.Point(119, 44);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(83, 58);
            this.lbl2.TabIndex = 1;
            this.lbl2.Text = "00";
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl3.Location = new System.Drawing.Point(214, 44);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(83, 58);
            this.lbl3.TabIndex = 2;
            this.lbl3.Text = "00";
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl4.Location = new System.Drawing.Point(309, 44);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(83, 58);
            this.lbl4.TabIndex = 3;
            this.lbl4.Text = "00";
            // 
            // lbl5
            // 
            this.lbl5.AutoSize = true;
            this.lbl5.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl5.Location = new System.Drawing.Point(404, 44);
            this.lbl5.Name = "lbl5";
            this.lbl5.Size = new System.Drawing.Size(83, 58);
            this.lbl5.TabIndex = 4;
            this.lbl5.Text = "00";
            // 
            // lbl6
            // 
            this.lbl6.AutoSize = true;
            this.lbl6.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl6.Location = new System.Drawing.Point(499, 44);
            this.lbl6.Name = "lbl6";
            this.lbl6.Size = new System.Drawing.Size(83, 58);
            this.lbl6.TabIndex = 5;
            this.lbl6.Text = "00";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 279);
            this.Controls.Add(this.grpSansliSayilar);
            this.Controls.Add(this.lbxSansliSayilar);
            this.Controls.Add(this.btnOyna);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpSansliSayilar.ResumeLayout(false);
            this.grpSansliSayilar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOyna;
        private System.Windows.Forms.ListBox lbxSansliSayilar;
        private System.Windows.Forms.GroupBox grpSansliSayilar;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl6;
        private System.Windows.Forms.Label lbl5;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Timer timer1;
    }
}

