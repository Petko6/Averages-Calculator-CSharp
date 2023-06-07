
namespace Prumer
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
            this.textBoxCislo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.addNumberBtn = new System.Windows.Forms.Button();
            this.vysledekBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxCislo
            // 
            this.textBoxCislo.Location = new System.Drawing.Point(12, 25);
            this.textBoxCislo.Name = "textBoxCislo";
            this.textBoxCislo.Size = new System.Drawing.Size(100, 20);
            this.textBoxCislo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Zadej hodnotu";
            // 
            // addNumberBtn
            // 
            this.addNumberBtn.Location = new System.Drawing.Point(118, 25);
            this.addNumberBtn.Name = "addNumberBtn";
            this.addNumberBtn.Size = new System.Drawing.Size(20, 20);
            this.addNumberBtn.TabIndex = 2;
            this.addNumberBtn.Text = "+";
            this.addNumberBtn.UseVisualStyleBackColor = true;
            this.addNumberBtn.Click += new System.EventHandler(this.addNumberBtn_Click);
            // 
            // vysledekBtn
            // 
            this.vysledekBtn.Location = new System.Drawing.Point(13, 52);
            this.vysledekBtn.Name = "vysledekBtn";
            this.vysledekBtn.Size = new System.Drawing.Size(75, 23);
            this.vysledekBtn.TabIndex = 3;
            this.vysledekBtn.Text = "Průměr";
            this.vysledekBtn.UseVisualStyleBackColor = true;
            this.vysledekBtn.Click += new System.EventHandler(this.vysledekBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(166, 101);
            this.Controls.Add(this.vysledekBtn);
            this.Controls.Add(this.addNumberBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxCislo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxCislo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addNumberBtn;
        private System.Windows.Forms.Button vysledekBtn;
    }
}

