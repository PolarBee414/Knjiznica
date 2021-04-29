
namespace Knjiznic
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
            this.Ucenici = new System.Windows.Forms.Label();
            this.Knjige = new System.Windows.Forms.Label();
            this.PosudeneKnjige = new System.Windows.Forms.Label();
            this.UceniciButton = new System.Windows.Forms.Button();
            this.KnjigeButton = new System.Windows.Forms.Button();
            this.listBox = new System.Windows.Forms.ListBox();
            this.Posudi = new System.Windows.Forms.Button();
            this.Izmjeni = new System.Windows.Forms.Button();
            this.Vrati = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Ucenici
            // 
            this.Ucenici.AutoSize = true;
            this.Ucenici.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Ucenici.Location = new System.Drawing.Point(24, 25);
            this.Ucenici.Name = "Ucenici";
            this.Ucenici.Size = new System.Drawing.Size(54, 17);
            this.Ucenici.TabIndex = 0;
            this.Ucenici.Text = "Učenici";
            // 
            // Knjige
            // 
            this.Knjige.AutoSize = true;
            this.Knjige.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Knjige.Location = new System.Drawing.Point(94, 25);
            this.Knjige.Name = "Knjige";
            this.Knjige.Size = new System.Drawing.Size(47, 17);
            this.Knjige.TabIndex = 1;
            this.Knjige.Text = "Knjige";
            // 
            // PosudeneKnjige
            // 
            this.PosudeneKnjige.AutoSize = true;
            this.PosudeneKnjige.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.PosudeneKnjige.Location = new System.Drawing.Point(12, 67);
            this.PosudeneKnjige.Name = "PosudeneKnjige";
            this.PosudeneKnjige.Size = new System.Drawing.Size(119, 17);
            this.PosudeneKnjige.TabIndex = 2;
            this.PosudeneKnjige.Text = "Posuđene Knjige:";
            // 
            // UceniciButton
            // 
            this.UceniciButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.UceniciButton.Location = new System.Drawing.Point(147, 59);
            this.UceniciButton.Name = "UceniciButton";
            this.UceniciButton.Size = new System.Drawing.Size(115, 25);
            this.UceniciButton.TabIndex = 3;
            this.UceniciButton.Text = "Učenici";
            this.UceniciButton.UseVisualStyleBackColor = true;
            // 
            // KnjigeButton
            // 
            this.KnjigeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.KnjigeButton.Location = new System.Drawing.Point(268, 59);
            this.KnjigeButton.Name = "KnjigeButton";
            this.KnjigeButton.Size = new System.Drawing.Size(115, 25);
            this.KnjigeButton.TabIndex = 4;
            this.KnjigeButton.Text = "Knjige";
            this.KnjigeButton.UseVisualStyleBackColor = true;
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.Location = new System.Drawing.Point(12, 87);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(661, 290);
            this.listBox.TabIndex = 5;
            this.listBox.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // Posudi
            // 
            this.Posudi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Posudi.Location = new System.Drawing.Point(695, 87);
            this.Posudi.Name = "Posudi";
            this.Posudi.Size = new System.Drawing.Size(100, 40);
            this.Posudi.TabIndex = 6;
            this.Posudi.Text = "Posudi";
            this.Posudi.UseVisualStyleBackColor = true;
            // 
            // Izmjeni
            // 
            this.Izmjeni.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Izmjeni.Location = new System.Drawing.Point(695, 142);
            this.Izmjeni.Name = "Izmjeni";
            this.Izmjeni.Size = new System.Drawing.Size(100, 40);
            this.Izmjeni.TabIndex = 7;
            this.Izmjeni.Text = "Izmjeni";
            this.Izmjeni.UseVisualStyleBackColor = true;
            // 
            // Vrati
            // 
            this.Vrati.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Vrati.Location = new System.Drawing.Point(695, 222);
            this.Vrati.Name = "Vrati";
            this.Vrati.Size = new System.Drawing.Size(100, 40);
            this.Vrati.TabIndex = 8;
            this.Vrati.Text = "Vrati";
            this.Vrati.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 399);
            this.Controls.Add(this.Vrati);
            this.Controls.Add(this.Izmjeni);
            this.Controls.Add(this.Posudi);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.KnjigeButton);
            this.Controls.Add(this.UceniciButton);
            this.Controls.Add(this.PosudeneKnjige);
            this.Controls.Add(this.Knjige);
            this.Controls.Add(this.Ucenici);
            this.Name = "Form1";
            this.Text = "Knjiznica";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Ucenici;
        private System.Windows.Forms.Label Knjige;
        private System.Windows.Forms.Label PosudeneKnjige;
        private System.Windows.Forms.Button UceniciButton;
        private System.Windows.Forms.Button KnjigeButton;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.Button Posudi;
        private System.Windows.Forms.Button Izmjeni;
        private System.Windows.Forms.Button Vrati;
    }
}

