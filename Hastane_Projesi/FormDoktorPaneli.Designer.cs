namespace Hastane_Projesi
{
    partial class FormDoktorPaneli
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
            this.adTextbox = new System.Windows.Forms.TextBox();
            this.soyadTextBox = new System.Windows.Forms.TextBox();
            this.bransComboBox = new System.Windows.Forms.ComboBox();
            this.tcMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.sifreTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // adTextbox
            // 
            this.adTextbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.adTextbox.Font = new System.Drawing.Font("Dubai", 12F);
            this.adTextbox.Location = new System.Drawing.Point(118, 43);
            this.adTextbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.adTextbox.Name = "adTextbox";
            this.adTextbox.Size = new System.Drawing.Size(121, 35);
            this.adTextbox.TabIndex = 0;
            // 
            // soyadTextBox
            // 
            this.soyadTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.soyadTextBox.Font = new System.Drawing.Font("Dubai", 12F);
            this.soyadTextBox.Location = new System.Drawing.Point(118, 86);
            this.soyadTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.soyadTextBox.Name = "soyadTextBox";
            this.soyadTextBox.Size = new System.Drawing.Size(121, 35);
            this.soyadTextBox.TabIndex = 1;
            // 
            // bransComboBox
            // 
            this.bransComboBox.Font = new System.Drawing.Font("Dubai", 12F);
            this.bransComboBox.FormattingEnabled = true;
            this.bransComboBox.Location = new System.Drawing.Point(118, 129);
            this.bransComboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bransComboBox.Name = "bransComboBox";
            this.bransComboBox.Size = new System.Drawing.Size(121, 35);
            this.bransComboBox.TabIndex = 2;
            // 
            // tcMaskedTextBox
            // 
            this.tcMaskedTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tcMaskedTextBox.Font = new System.Drawing.Font("Dubai", 12F);
            this.tcMaskedTextBox.Location = new System.Drawing.Point(118, 172);
            this.tcMaskedTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tcMaskedTextBox.Mask = "00000000000";
            this.tcMaskedTextBox.Name = "tcMaskedTextBox";
            this.tcMaskedTextBox.Size = new System.Drawing.Size(121, 35);
            this.tcMaskedTextBox.TabIndex = 3;
            this.tcMaskedTextBox.ValidatingType = typeof(int);
            // 
            // sifreTextBox
            // 
            this.sifreTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sifreTextBox.Font = new System.Drawing.Font("Dubai", 12F);
            this.sifreTextBox.Location = new System.Drawing.Point(118, 215);
            this.sifreTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.sifreTextBox.Name = "sifreTextBox";
            this.sifreTextBox.PasswordChar = '*';
            this.sifreTextBox.Size = new System.Drawing.Size(121, 35);
            this.sifreTextBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(77, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 27);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(54, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 27);
            this.label2.TabIndex = 6;
            this.label2.Text = "Soyad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(57, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 27);
            this.label3.TabIndex = 7;
            this.label3.Text = "Brans:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(79, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 27);
            this.label4.TabIndex = 8;
            this.label4.Text = "TC:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(65, 217);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 27);
            this.label5.TabIndex = 9;
            this.label5.Text = "Sifre:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkRed;
            this.button1.Font = new System.Drawing.Font("Dubai", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(118, 257);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(60, 25);
            this.button1.TabIndex = 10;
            this.button1.Text = "Ekle";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkRed;
            this.button2.Font = new System.Drawing.Font("Dubai", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(179, 257);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(60, 25);
            this.button2.TabIndex = 11;
            this.button2.Text = "Sil";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DarkRed;
            this.button3.Font = new System.Drawing.Font("Dubai", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(118, 288);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(121, 25);
            this.button3.TabIndex = 12;
            this.button3.Text = "Güncelle";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(258, 43);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(350, 270);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // FormDoktorPaneli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 348);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sifreTextBox);
            this.Controls.Add(this.tcMaskedTextBox);
            this.Controls.Add(this.bransComboBox);
            this.Controls.Add(this.soyadTextBox);
            this.Controls.Add(this.adTextbox);
            this.Font = new System.Drawing.Font("Dubai", 8.25F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormDoktorPaneli";
            this.Text = "DoktorPaneli";
            this.Load += new System.EventHandler(this.FormDoktorPaneli_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox adTextbox;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.TextBox soyadTextBox;
        private System.Windows.Forms.ComboBox bransComboBox;
        private System.Windows.Forms.MaskedTextBox tcMaskedTextBox;
        private System.Windows.Forms.TextBox sifreTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}