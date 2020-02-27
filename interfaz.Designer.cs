namespace Criptografia
{
    partial class interfaz
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTextoCifrado = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTextoPlano = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtFileLocation = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbOpciones = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chContraseña = new System.Windows.Forms.CheckBox();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.abrirImagen = new System.Windows.Forms.OpenFileDialog();
            this.abrirArchivo = new System.Windows.Forms.OpenFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.btnEncriptar = new System.Windows.Forms.Button();
            this.btnDesencriptar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtTextoCifrado);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtTextoPlano);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnBuscar);
            this.groupBox1.Controls.Add(this.txtFileLocation);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cbOpciones);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("DM Sans", 14.25F, System.Drawing.FontStyle.Bold);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(451, 312);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // txtTextoCifrado
            // 
            this.txtTextoCifrado.Location = new System.Drawing.Point(140, 207);
            this.txtTextoCifrado.Multiline = true;
            this.txtTextoCifrado.Name = "txtTextoCifrado";
            this.txtTextoCifrado.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtTextoCifrado.Size = new System.Drawing.Size(295, 93);
            this.txtTextoCifrado.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Texto cifrado";
            // 
            // txtTextoPlano
            // 
            this.txtTextoPlano.Enabled = false;
            this.txtTextoPlano.Location = new System.Drawing.Point(140, 108);
            this.txtTextoPlano.Multiline = true;
            this.txtTextoPlano.Name = "txtTextoPlano";
            this.txtTextoPlano.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtTextoPlano.Size = new System.Drawing.Size(295, 93);
            this.txtTextoPlano.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Texto plano";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.Enabled = false;
            this.btnBuscar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Location = new System.Drawing.Point(391, 70);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(44, 32);
            this.btnBuscar.TabIndex = 4;
            this.btnBuscar.Text = "...";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtFileLocation
            // 
            this.txtFileLocation.Enabled = false;
            this.txtFileLocation.Location = new System.Drawing.Point(140, 70);
            this.txtFileLocation.Name = "txtFileLocation";
            this.txtFileLocation.ReadOnly = true;
            this.txtFileLocation.Size = new System.Drawing.Size(245, 32);
            this.txtFileLocation.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(84, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ruta";
            // 
            // cbOpciones
            // 
            this.cbOpciones.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbOpciones.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbOpciones.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbOpciones.FormattingEnabled = true;
            this.cbOpciones.Items.AddRange(new object[] {
            "Archivo",
            "Imagen",
            "Texto plano"});
            this.cbOpciones.Location = new System.Drawing.Point(140, 31);
            this.cbOpciones.Name = "cbOpciones";
            this.cbOpciones.Size = new System.Drawing.Size(295, 33);
            this.cbOpciones.TabIndex = 1;
            this.cbOpciones.SelectedValueChanged += new System.EventHandler(this.cbDropdown_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tipo";
            // 
            // chContraseña
            // 
            this.chContraseña.AutoSize = true;
            this.chContraseña.Font = new System.Drawing.Font("DM Sans", 14.25F, System.Drawing.FontStyle.Bold);
            this.chContraseña.ForeColor = System.Drawing.Color.White;
            this.chContraseña.Location = new System.Drawing.Point(36, 395);
            this.chContraseña.Name = "chContraseña";
            this.chContraseña.Size = new System.Drawing.Size(216, 29);
            this.chContraseña.TabIndex = 2;
            this.chContraseña.Text = "Mostrar contraseña";
            this.chContraseña.UseVisualStyleBackColor = true;
            this.chContraseña.CheckedChanged += new System.EventHandler(this.chPritaveKey_CheckedChanged);
            // 
            // txtPrivateKey
            // 
            this.txtContraseña.Font = new System.Drawing.Font("DM Sans", 14.25F, System.Drawing.FontStyle.Bold);
            this.txtContraseña.Location = new System.Drawing.Point(36, 430);
            this.txtContraseña.Name = "txtPrivateKey";
            this.txtContraseña.Size = new System.Drawing.Size(158, 32);
            this.txtContraseña.TabIndex = 3;
            this.txtContraseña.UseSystemPasswordChar = true;
            // 
            // abrirImagen
            // 
            this.abrirImagen.Filter = "JPG files|*.jpg|PNG files|*.png";
            // 
            // abrirArchivo
            // 
            this.abrirArchivo.Filter = "PDF files|*.pdf|Word files|*.docx";
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Image = global::Criptografia.Properties.Resources.icons8_cancel_48;
            this.button1.Location = new System.Drawing.Point(403, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(44, 45);
            this.button1.TabIndex = 6;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnEncriptar
            // 
            this.btnEncriptar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEncriptar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnEncriptar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnEncriptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEncriptar.Font = new System.Drawing.Font("DM Sans", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnEncriptar.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnEncriptar.Image = global::Criptografia.Properties.Resources.icons8_lock_64;
            this.btnEncriptar.Location = new System.Drawing.Point(255, 395);
            this.btnEncriptar.Name = "btnEncriptar";
            this.btnEncriptar.Size = new System.Drawing.Size(70, 66);
            this.btnEncriptar.TabIndex = 5;
            this.btnEncriptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnEncriptar.UseVisualStyleBackColor = true;
            this.btnEncriptar.Click += new System.EventHandler(this.btnEncriptar_Click);
            // 
            // btnDesencriptar
            // 
            this.btnDesencriptar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDesencriptar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnDesencriptar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnDesencriptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDesencriptar.Font = new System.Drawing.Font("DM Sans", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnDesencriptar.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnDesencriptar.Image = global::Criptografia.Properties.Resources.icons8_padlock_64;
            this.btnDesencriptar.Location = new System.Drawing.Point(351, 396);
            this.btnDesencriptar.Name = "btnDesencriptar";
            this.btnDesencriptar.Size = new System.Drawing.Size(70, 66);
            this.btnDesencriptar.TabIndex = 4;
            this.btnDesencriptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnDesencriptar.UseVisualStyleBackColor = true;
            this.btnDesencriptar.Click += new System.EventHandler(this.btnDesencriptar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("DM Sans", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(29, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(357, 38);
            this.label5.TabIndex = 7;
            this.label5.Text = "Encriptar y desencriptar";
            // 
            // interfaz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(491, 512);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnEncriptar);
            this.Controls.Add(this.btnDesencriptar);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.chContraseña);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(491, 512);
            this.MinimumSize = new System.Drawing.Size(491, 512);
            this.Name = "interfaz";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jose Estrada: Encriptación con AES";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chContraseña;
        private System.Windows.Forms.Button btnDesencriptar;
        private System.Windows.Forms.TextBox txtTextoPlano;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtFileLocation;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtContraseña;
        protected System.Windows.Forms.ComboBox cbOpciones;
        private System.Windows.Forms.OpenFileDialog abrirImagen;
        private System.Windows.Forms.OpenFileDialog abrirArchivo;
        private System.Windows.Forms.Button btnEncriptar;
        private System.Windows.Forms.TextBox txtTextoCifrado;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
    }
}