namespace örn
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
            this.mtbTc = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.mtbTel = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.mtbDogum = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.mtbKart = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.mtbIp = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // mtbTc
            // 
            this.mtbTc.Location = new System.Drawing.Point(172, 9);
            this.mtbTc.Name = "mtbTc";
            this.mtbTc.Size = new System.Drawing.Size(229, 31);
            this.mtbTc.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "T.C. No:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Telefon:";
            // 
            // mtbTel
            // 
            this.mtbTel.Location = new System.Drawing.Point(172, 46);
            this.mtbTel.Name = "mtbTel";
            this.mtbTel.Size = new System.Drawing.Size(229, 31);
            this.mtbTel.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Doğum Tarihi:";
            // 
            // mtbDogum
            // 
            this.mtbDogum.Location = new System.Drawing.Point(172, 86);
            this.mtbDogum.Name = "mtbDogum";
            this.mtbDogum.Size = new System.Drawing.Size(229, 31);
            this.mtbDogum.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Kart Numarası:";
            // 
            // mtbKart
            // 
            this.mtbKart.Location = new System.Drawing.Point(172, 123);
            this.mtbKart.Name = "mtbKart";
            this.mtbKart.Size = new System.Drawing.Size(229, 31);
            this.mtbKart.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(62, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "IP Adresi:";
            // 
            // mtbIp
            // 
            this.mtbIp.Location = new System.Drawing.Point(172, 160);
            this.mtbIp.Name = "mtbIp";
            this.mtbIp.Size = new System.Drawing.Size(229, 31);
            this.mtbIp.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 209);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.mtbIp);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.mtbKart);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.mtbDogum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.mtbTel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mtbTc);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox mtbTc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox mtbTel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox mtbDogum;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox mtbKart;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox mtbIp;
    }
}

