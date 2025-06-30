namespace Hastane_Projesi
{
    partial class FormBransPaneli
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.guncelleButton = new System.Windows.Forms.Button();
            this.silButton = new System.Windows.Forms.Button();
            this.ekleButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.adTextbox = new System.Windows.Forms.TextBox();
            this.idTextbox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(242, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(323, 151);
            this.dataGridView1.TabIndex = 27;
            // 
            // guncelleButton
            // 
            this.guncelleButton.BackColor = System.Drawing.Color.DarkRed;
            this.guncelleButton.Font = new System.Drawing.Font("Dubai", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guncelleButton.ForeColor = System.Drawing.Color.White;
            this.guncelleButton.Location = new System.Drawing.Point(69, 138);
            this.guncelleButton.Name = "guncelleButton";
            this.guncelleButton.Size = new System.Drawing.Size(121, 25);
            this.guncelleButton.TabIndex = 26;
            this.guncelleButton.Text = "Güncelle";
            this.guncelleButton.UseVisualStyleBackColor = false;
            // 
            // silButton
            // 
            this.silButton.BackColor = System.Drawing.Color.DarkRed;
            this.silButton.Font = new System.Drawing.Font("Dubai", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.silButton.ForeColor = System.Drawing.Color.White;
            this.silButton.Location = new System.Drawing.Point(130, 107);
            this.silButton.Name = "silButton";
            this.silButton.Size = new System.Drawing.Size(60, 25);
            this.silButton.TabIndex = 25;
            this.silButton.Text = "Sil";
            this.silButton.UseVisualStyleBackColor = false;
            // 
            // ekleButton
            // 
            this.ekleButton.BackColor = System.Drawing.Color.DarkRed;
            this.ekleButton.Font = new System.Drawing.Font("Dubai", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ekleButton.ForeColor = System.Drawing.Color.White;
            this.ekleButton.Location = new System.Drawing.Point(69, 107);
            this.ekleButton.Name = "ekleButton";
            this.ekleButton.Size = new System.Drawing.Size(60, 25);
            this.ekleButton.TabIndex = 24;
            this.ekleButton.Text = "Ekle";
            this.ekleButton.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(17, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 27);
            this.label2.TabIndex = 20;
            this.label2.Text = "Branş Ad:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(24, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 27);
            this.label1.TabIndex = 19;
            this.label1.Text = "Branş id:";
            // 
            // adTextbox
            // 
            this.adTextbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.adTextbox.Font = new System.Drawing.Font("Dubai", 12F);
            this.adTextbox.Location = new System.Drawing.Point(105, 56);
            this.adTextbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.adTextbox.Name = "adTextbox";
            this.adTextbox.Size = new System.Drawing.Size(121, 35);
            this.adTextbox.TabIndex = 15;
            // 
            // idTextbox
            // 
            this.idTextbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.idTextbox.Font = new System.Drawing.Font("Dubai", 12F);
            this.idTextbox.Location = new System.Drawing.Point(105, 13);
            this.idTextbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.idTextbox.Name = "idTextbox";
            this.idTextbox.Size = new System.Drawing.Size(121, 35);
            this.idTextbox.TabIndex = 14;
            // 
            // FormBransPaneli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 172);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.guncelleButton);
            this.Controls.Add(this.silButton);
            this.Controls.Add(this.ekleButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.adTextbox);
            this.Controls.Add(this.idTextbox);
            this.Name = "FormBransPaneli";
            this.Text = "BranşPaneli";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button guncelleButton;
        private System.Windows.Forms.Button silButton;
        private System.Windows.Forms.Button ekleButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox adTextbox;
        private System.Windows.Forms.TextBox idTextbox;
    }
}