namespace winCsGo
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
            this.weaponCombobox = new System.Windows.Forms.ComboBox();
            this.atesEt = new System.Windows.Forms.Button();
            this.WeaponDesc = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // weaponCombobox
            // 
            this.weaponCombobox.FormattingEnabled = true;
            this.weaponCombobox.Location = new System.Drawing.Point(64, 71);
            this.weaponCombobox.Name = "weaponCombobox";
            this.weaponCombobox.Size = new System.Drawing.Size(205, 24);
            this.weaponCombobox.TabIndex = 0;
            // 
            // atesEt
            // 
            this.atesEt.Location = new System.Drawing.Point(306, 63);
            this.atesEt.Name = "atesEt";
            this.atesEt.Size = new System.Drawing.Size(175, 38);
            this.atesEt.TabIndex = 1;
            this.atesEt.Text = "Ateş Et";
            this.atesEt.UseVisualStyleBackColor = true;
            this.atesEt.Click += new System.EventHandler(this.atesEt_Click);
            // 
            // WeaponDesc
            // 
            this.WeaponDesc.AutoSize = true;
            this.WeaponDesc.Location = new System.Drawing.Point(61, 152);
            this.WeaponDesc.Name = "WeaponDesc";
            this.WeaponDesc.Size = new System.Drawing.Size(71, 17);
            this.WeaponDesc.TabIndex = 2;
            this.WeaponDesc.Text = "Atış Bilgisi";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.WeaponDesc);
            this.Controls.Add(this.atesEt);
            this.Controls.Add(this.weaponCombobox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox weaponCombobox;
        private System.Windows.Forms.Button atesEt;
        private System.Windows.Forms.Label WeaponDesc;
    }
}

