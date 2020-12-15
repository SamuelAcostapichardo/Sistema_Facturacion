namespace sinnombre
{
    partial class Registro_Terminal
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
            this.Txtid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Btngen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Txtid
            // 
            this.Txtid.Location = new System.Drawing.Point(165, 63);
            this.Txtid.Multiline = true;
            this.Txtid.Name = "Txtid";
            this.Txtid.Size = new System.Drawing.Size(270, 51);
            this.Txtid.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Identificador";
            // 
            // Btngen
            // 
            this.Btngen.Location = new System.Drawing.Point(273, 182);
            this.Btngen.Name = "Btngen";
            this.Btngen.Size = new System.Drawing.Size(75, 23);
            this.Btngen.TabIndex = 2;
            this.Btngen.Text = "&Generar";
            this.Btngen.UseVisualStyleBackColor = true;
            this.Btngen.Click += new System.EventHandler(this.Btngen_Click);
            // 
            // Registro_Terminal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 235);
            this.Controls.Add(this.Btngen);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Txtid);
            this.Name = "Registro_Terminal";
            this.Text = "Registro_Terminal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Txtid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btngen;
    }
}