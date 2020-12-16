namespace sinnombre
{
    partial class Registro_de_terminales
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
            this.Txtnombre = new System.Windows.Forms.TextBox();
            this.Btnguardar = new System.Windows.Forms.Button();
            this.Txtidenti = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Cmbestatus = new System.Windows.Forms.ComboBox();
            this.Error = new System.Windows.Forms.ErrorProvider(this.components);
            this.Btngenerar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Error)).BeginInit();
            this.SuspendLayout();
            // 
            // Txtnombre
            // 
            this.Txtnombre.Location = new System.Drawing.Point(86, 38);
            this.Txtnombre.Name = "Txtnombre";
            this.Txtnombre.Size = new System.Drawing.Size(128, 20);
            this.Txtnombre.TabIndex = 0;
            // 
            // Btnguardar
            // 
            this.Btnguardar.Location = new System.Drawing.Point(86, 332);
            this.Btnguardar.Name = "Btnguardar";
            this.Btnguardar.Size = new System.Drawing.Size(75, 23);
            this.Btnguardar.TabIndex = 1;
            this.Btnguardar.Text = "&Guardar";
            this.Btnguardar.UseVisualStyleBackColor = true;
            this.Btnguardar.Click += new System.EventHandler(this.Btnguardar_Click);
            // 
            // Txtidenti
            // 
            this.Txtidenti.Location = new System.Drawing.Point(86, 94);
            this.Txtidenti.Multiline = true;
            this.Txtidenti.Name = "Txtidenti";
            this.Txtidenti.Size = new System.Drawing.Size(311, 44);
            this.Txtidenti.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Identificador:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Estatus:";
            // 
            // Cmbestatus
            // 
            this.Cmbestatus.FormattingEnabled = true;
            this.Cmbestatus.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.Cmbestatus.Location = new System.Drawing.Point(86, 191);
            this.Cmbestatus.Name = "Cmbestatus";
            this.Cmbestatus.Size = new System.Drawing.Size(128, 21);
            this.Cmbestatus.TabIndex = 7;
            this.Cmbestatus.Text = "Activo";
            // 
            // Error
            // 
            this.Error.ContainerControl = this;
            // 
            // Btngenerar
            // 
            this.Btngenerar.Location = new System.Drawing.Point(214, 332);
            this.Btngenerar.Name = "Btngenerar";
            this.Btngenerar.Size = new System.Drawing.Size(133, 23);
            this.Btngenerar.TabIndex = 8;
            this.Btngenerar.Text = "Generar identificador";
            this.Btngenerar.UseVisualStyleBackColor = true;
            this.Btngenerar.Click += new System.EventHandler(this.Btngenerar_Click);
            // 
            // Registro_de_terminales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 367);
            this.Controls.Add(this.Btngenerar);
            this.Controls.Add(this.Cmbestatus);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Txtidenti);
            this.Controls.Add(this.Btnguardar);
            this.Controls.Add(this.Txtnombre);
            this.Name = "Registro_de_terminales";
            this.Text = "Registro_de_terminales";
            ((System.ComponentModel.ISupportInitialize)(this.Error)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Txtnombre;
        private System.Windows.Forms.Button Btnguardar;
        private System.Windows.Forms.TextBox Txtidenti;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox Cmbestatus;
        private System.Windows.Forms.ErrorProvider Error;
        private System.Windows.Forms.Button Btngenerar;
    }
}