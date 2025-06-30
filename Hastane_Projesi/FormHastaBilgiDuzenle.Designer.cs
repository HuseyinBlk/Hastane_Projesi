namespace Hastane_Projesi
{
    partial class FormHastaBilgiDuzenle
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
            this.label7 = new System.Windows.Forms.Label();
            this.genderComboBox = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.phoneMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.tcMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.soyadTextBox = new System.Windows.Forms.TextBox();
            this.adTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Dubai", 20F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.label7.Location = new System.Drawing.Point(19, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(283, 45);
            this.label7.TabIndex = 28;
            this.label7.Text = "Hasta Bilgi Düzenleme ";
            // 
            // genderComboBox
            // 
            this.genderComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.genderComboBox.FormattingEnabled = true;
            this.genderComboBox.Location = new System.Drawing.Point(134, 290);
            this.genderComboBox.Name = "genderComboBox";
            this.genderComboBox.Size = new System.Drawing.Size(130, 33);
            this.genderComboBox.TabIndex = 27;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(107, 340);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 37);
            this.button1.TabIndex = 26;
            this.button1.Text = "Kaydet";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(56, 293);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 27);
            this.label6.TabIndex = 25;
            this.label6.Text = "Cinsiyet:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(75, 251);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 27);
            this.label5.TabIndex = 24;
            this.label5.Text = "Şifre:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(59, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 27);
            this.label4.TabIndex = 23;
            this.label4.Text = "Telefon:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 27);
            this.label3.TabIndex = 22;
            this.label3.Text = "TC Kimlik No:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(68, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 27);
            this.label2.TabIndex = 21;
            this.label2.Text = "Soyad:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(91, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 27);
            this.label1.TabIndex = 20;
            this.label1.Text = "Ad:";
            // 
            // phoneMaskedTextBox
            // 
            this.phoneMaskedTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.phoneMaskedTextBox.Location = new System.Drawing.Point(134, 204);
            this.phoneMaskedTextBox.Mask = "(999) 000-0000";
            this.phoneMaskedTextBox.Name = "phoneMaskedTextBox";
            this.phoneMaskedTextBox.Size = new System.Drawing.Size(130, 30);
            this.phoneMaskedTextBox.TabIndex = 19;
            // 
            // tcMaskedTextBox
            // 
            this.tcMaskedTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.tcMaskedTextBox.Location = new System.Drawing.Point(134, 162);
            this.tcMaskedTextBox.Mask = "00000000000";
            this.tcMaskedTextBox.Name = "tcMaskedTextBox";
            this.tcMaskedTextBox.Size = new System.Drawing.Size(130, 30);
            this.tcMaskedTextBox.TabIndex = 18;
            this.tcMaskedTextBox.ValidatingType = typeof(int);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.passwordTextBox.Location = new System.Drawing.Point(134, 246);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.Size = new System.Drawing.Size(130, 30);
            this.passwordTextBox.TabIndex = 17;
            // 
            // soyadTextBox
            // 
            this.soyadTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.soyadTextBox.Location = new System.Drawing.Point(134, 120);
            this.soyadTextBox.Name = "soyadTextBox";
            this.soyadTextBox.Size = new System.Drawing.Size(130, 30);
            this.soyadTextBox.TabIndex = 16;
            // 
            // adTextBox
            // 
            this.adTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.adTextBox.Location = new System.Drawing.Point(134, 78);
            this.adTextBox.Name = "adTextBox";
            this.adTextBox.Size = new System.Drawing.Size(130, 30);
            this.adTextBox.TabIndex = 15;
            // 
            // FormHastaBilgiDuzenle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 400);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.genderComboBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.phoneMaskedTextBox);
            this.Controls.Add(this.tcMaskedTextBox);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.soyadTextBox);
            this.Controls.Add(this.adTextBox);
            this.Name = "FormHastaBilgiDuzenle";
            this.Text = "FormHastaBilgiDuzenle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox genderComboBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox phoneMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox tcMaskedTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox soyadTextBox;
        private System.Windows.Forms.TextBox adTextBox;
    }
}