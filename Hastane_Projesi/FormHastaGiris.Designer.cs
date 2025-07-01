namespace Hastane_Projesi
{
    partial class FormHastaGiris
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.sifreTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tcMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.üyeOlLinkLabel = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Dubai", 20F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.label1.Location = new System.Drawing.Point(81, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hasta Giris Paneli";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Dubai", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tc Kimlik No:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Dubai", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(84, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Sifre:";
            // 
            // sifreTextBox
            // 
            this.sifreTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.sifreTextBox.Location = new System.Drawing.Point(147, 140);
            this.sifreTextBox.Name = "sifreTextBox";
            this.sifreTextBox.Size = new System.Drawing.Size(143, 30);
            this.sifreTextBox.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(142, 200);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 42);
            this.button1.TabIndex = 5;
            this.button1.Text = " Devam Et";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tcMaskedTextBox
            // 
            this.tcMaskedTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.tcMaskedTextBox.Location = new System.Drawing.Point(147, 91);
            this.tcMaskedTextBox.Mask = "00000000000";
            this.tcMaskedTextBox.Name = "tcMaskedTextBox";
            this.tcMaskedTextBox.Size = new System.Drawing.Size(143, 30);
            this.tcMaskedTextBox.TabIndex = 6;
            this.tcMaskedTextBox.ValidatingType = typeof(int);
            // 
            // üyeOlLinkLabel
            // 
            this.üyeOlLinkLabel.AutoSize = true;
            this.üyeOlLinkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.üyeOlLinkLabel.Location = new System.Drawing.Point(166, 257);
            this.üyeOlLinkLabel.Name = "üyeOlLinkLabel";
            this.üyeOlLinkLabel.Size = new System.Drawing.Size(53, 18);
            this.üyeOlLinkLabel.TabIndex = 7;
            this.üyeOlLinkLabel.TabStop = true;
            this.üyeOlLinkLabel.Text = "Üye Ol";
            this.üyeOlLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.üyeOlLinkLabel_LinkClicked);
            // 
            // FormHastaGiris
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 343);
            this.Controls.Add(this.üyeOlLinkLabel);
            this.Controls.Add(this.tcMaskedTextBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.sifreTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormHastaGiris";
            this.Text = "Hasta Girişi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox sifreTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MaskedTextBox tcMaskedTextBox;
        private System.Windows.Forms.LinkLabel üyeOlLinkLabel;
    }
}