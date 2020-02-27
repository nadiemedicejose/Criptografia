namespace Criptografia
{
    partial class configuracion
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
            this.algoritmoAES = new System.Windows.Forms.RadioButton();
            this.algoritmoDES = new System.Windows.Forms.RadioButton();
            this.algoritmo3DES = new System.Windows.Forms.RadioButton();
            this.algoritmoRijndael192 = new System.Windows.Forms.RadioButton();
            this.algoritmoRijndael256 = new System.Windows.Forms.RadioButton();
            this.algoritmoTwofish = new System.Windows.Forms.RadioButton();
            this.modoECB = new System.Windows.Forms.RadioButton();
            this.modoOFB = new System.Windows.Forms.RadioButton();
            this.modoNOFB = new System.Windows.Forms.RadioButton();
            this.modoCBC = new System.Windows.Forms.RadioButton();
            this.modoCFB = new System.Windows.Forms.RadioButton();
            this.modoNCFB = new System.Windows.Forms.RadioButton();
            this.hashSHA256 = new System.Windows.Forms.RadioButton();
            this.hashSHA512 = new System.Windows.Forms.RadioButton();
            this.hashNinguno = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // algoritmoAES
            // 
            this.algoritmoAES.AutoSize = true;
            this.algoritmoAES.Font = new System.Drawing.Font("DM Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.algoritmoAES.Location = new System.Drawing.Point(44, 37);
            this.algoritmoAES.Name = "algoritmoAES";
            this.algoritmoAES.Size = new System.Drawing.Size(57, 25);
            this.algoritmoAES.TabIndex = 4;
            this.algoritmoAES.TabStop = true;
            this.algoritmoAES.Text = "AES";
            this.algoritmoAES.UseVisualStyleBackColor = true;
            // 
            // algoritmoDES
            // 
            this.algoritmoDES.AutoSize = true;
            this.algoritmoDES.Enabled = false;
            this.algoritmoDES.Font = new System.Drawing.Font("DM Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.algoritmoDES.Location = new System.Drawing.Point(44, 68);
            this.algoritmoDES.Name = "algoritmoDES";
            this.algoritmoDES.Size = new System.Drawing.Size(57, 25);
            this.algoritmoDES.TabIndex = 5;
            this.algoritmoDES.TabStop = true;
            this.algoritmoDES.Text = "DES";
            this.algoritmoDES.UseVisualStyleBackColor = true;
            // 
            // algoritmo3DES
            // 
            this.algoritmo3DES.AutoSize = true;
            this.algoritmo3DES.Enabled = false;
            this.algoritmo3DES.Font = new System.Drawing.Font("DM Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.algoritmo3DES.Location = new System.Drawing.Point(44, 99);
            this.algoritmo3DES.Name = "algoritmo3DES";
            this.algoritmo3DES.Size = new System.Drawing.Size(74, 25);
            this.algoritmo3DES.TabIndex = 6;
            this.algoritmo3DES.TabStop = true;
            this.algoritmo3DES.Text = "3-DES";
            this.algoritmo3DES.UseVisualStyleBackColor = true;
            // 
            // algoritmoRijndael192
            // 
            this.algoritmoRijndael192.AutoSize = true;
            this.algoritmoRijndael192.Enabled = false;
            this.algoritmoRijndael192.Font = new System.Drawing.Font("DM Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.algoritmoRijndael192.Location = new System.Drawing.Point(207, 37);
            this.algoritmoRijndael192.Name = "algoritmoRijndael192";
            this.algoritmoRijndael192.Size = new System.Drawing.Size(114, 25);
            this.algoritmoRijndael192.TabIndex = 7;
            this.algoritmoRijndael192.TabStop = true;
            this.algoritmoRijndael192.Text = "Rijndael 192";
            this.algoritmoRijndael192.UseVisualStyleBackColor = true;
            // 
            // algoritmoRijndael256
            // 
            this.algoritmoRijndael256.AutoSize = true;
            this.algoritmoRijndael256.Enabled = false;
            this.algoritmoRijndael256.Font = new System.Drawing.Font("DM Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.algoritmoRijndael256.Location = new System.Drawing.Point(207, 68);
            this.algoritmoRijndael256.Name = "algoritmoRijndael256";
            this.algoritmoRijndael256.Size = new System.Drawing.Size(119, 25);
            this.algoritmoRijndael256.TabIndex = 8;
            this.algoritmoRijndael256.TabStop = true;
            this.algoritmoRijndael256.Text = "Rijndael 256";
            this.algoritmoRijndael256.UseVisualStyleBackColor = true;
            // 
            // algoritmoTwofish
            // 
            this.algoritmoTwofish.AutoSize = true;
            this.algoritmoTwofish.Enabled = false;
            this.algoritmoTwofish.Font = new System.Drawing.Font("DM Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.algoritmoTwofish.Location = new System.Drawing.Point(207, 99);
            this.algoritmoTwofish.Name = "algoritmoTwofish";
            this.algoritmoTwofish.Size = new System.Drawing.Size(83, 25);
            this.algoritmoTwofish.TabIndex = 9;
            this.algoritmoTwofish.TabStop = true;
            this.algoritmoTwofish.Text = "Twofish";
            this.algoritmoTwofish.UseVisualStyleBackColor = true;
            // 
            // modoECB
            // 
            this.modoECB.AutoSize = true;
            this.modoECB.Enabled = false;
            this.modoECB.Font = new System.Drawing.Font("DM Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modoECB.Location = new System.Drawing.Point(44, 37);
            this.modoECB.Name = "modoECB";
            this.modoECB.Size = new System.Drawing.Size(59, 25);
            this.modoECB.TabIndex = 10;
            this.modoECB.TabStop = true;
            this.modoECB.Text = "ECB";
            this.modoECB.UseVisualStyleBackColor = true;
            // 
            // modoOFB
            // 
            this.modoOFB.AutoSize = true;
            this.modoOFB.Enabled = false;
            this.modoOFB.Font = new System.Drawing.Font("DM Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modoOFB.Location = new System.Drawing.Point(44, 68);
            this.modoOFB.Name = "modoOFB";
            this.modoOFB.Size = new System.Drawing.Size(60, 25);
            this.modoOFB.TabIndex = 11;
            this.modoOFB.TabStop = true;
            this.modoOFB.Text = "OFB";
            this.modoOFB.UseVisualStyleBackColor = true;
            // 
            // modoNOFB
            // 
            this.modoNOFB.AutoSize = true;
            this.modoNOFB.Enabled = false;
            this.modoNOFB.Font = new System.Drawing.Font("DM Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modoNOFB.Location = new System.Drawing.Point(44, 99);
            this.modoNOFB.Name = "modoNOFB";
            this.modoNOFB.Size = new System.Drawing.Size(71, 25);
            this.modoNOFB.TabIndex = 12;
            this.modoNOFB.TabStop = true;
            this.modoNOFB.Text = "NOFB";
            this.modoNOFB.UseVisualStyleBackColor = true;
            // 
            // modoCBC
            // 
            this.modoCBC.AutoSize = true;
            this.modoCBC.Font = new System.Drawing.Font("DM Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modoCBC.Location = new System.Drawing.Point(207, 37);
            this.modoCBC.Name = "modoCBC";
            this.modoCBC.Size = new System.Drawing.Size(62, 25);
            this.modoCBC.TabIndex = 13;
            this.modoCBC.TabStop = true;
            this.modoCBC.Text = "CBC";
            this.modoCBC.UseVisualStyleBackColor = true;
            // 
            // modoCFB
            // 
            this.modoCFB.AutoSize = true;
            this.modoCFB.Enabled = false;
            this.modoCFB.Font = new System.Drawing.Font("DM Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modoCFB.Location = new System.Drawing.Point(207, 68);
            this.modoCFB.Name = "modoCFB";
            this.modoCFB.Size = new System.Drawing.Size(59, 25);
            this.modoCFB.TabIndex = 14;
            this.modoCFB.TabStop = true;
            this.modoCFB.Text = "CFB";
            this.modoCFB.UseVisualStyleBackColor = true;
            // 
            // modoNCFB
            // 
            this.modoNCFB.AutoSize = true;
            this.modoNCFB.Enabled = false;
            this.modoNCFB.Font = new System.Drawing.Font("DM Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modoNCFB.Location = new System.Drawing.Point(207, 99);
            this.modoNCFB.Name = "modoNCFB";
            this.modoNCFB.Size = new System.Drawing.Size(70, 25);
            this.modoNCFB.TabIndex = 15;
            this.modoNCFB.TabStop = true;
            this.modoNCFB.Text = "NCFB";
            this.modoNCFB.UseVisualStyleBackColor = true;
            // 
            // hashSHA256
            // 
            this.hashSHA256.AutoSize = true;
            this.hashSHA256.Font = new System.Drawing.Font("DM Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hashSHA256.Location = new System.Drawing.Point(39, 37);
            this.hashSHA256.Name = "hashSHA256";
            this.hashSHA256.Size = new System.Drawing.Size(96, 25);
            this.hashSHA256.TabIndex = 16;
            this.hashSHA256.TabStop = true;
            this.hashSHA256.Text = "SHA-256";
            this.hashSHA256.UseVisualStyleBackColor = true;
            // 
            // hashSHA512
            // 
            this.hashSHA512.AutoSize = true;
            this.hashSHA512.Enabled = false;
            this.hashSHA512.Font = new System.Drawing.Font("DM Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hashSHA512.Location = new System.Drawing.Point(39, 68);
            this.hashSHA512.Name = "hashSHA512";
            this.hashSHA512.Size = new System.Drawing.Size(91, 25);
            this.hashSHA512.TabIndex = 17;
            this.hashSHA512.TabStop = true;
            this.hashSHA512.Text = "SHA-512";
            this.hashSHA512.UseVisualStyleBackColor = true;
            // 
            // hashNinguno
            // 
            this.hashNinguno.AutoSize = true;
            this.hashNinguno.Enabled = false;
            this.hashNinguno.Font = new System.Drawing.Font("DM Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hashNinguno.Location = new System.Drawing.Point(39, 99);
            this.hashNinguno.Name = "hashNinguno";
            this.hashNinguno.Size = new System.Drawing.Size(97, 25);
            this.hashNinguno.TabIndex = 18;
            this.hashNinguno.TabStop = true;
            this.hashNinguno.Text = "No incluir";
            this.hashNinguno.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.algoritmoAES);
            this.groupBox1.Controls.Add(this.algoritmoDES);
            this.groupBox1.Controls.Add(this.algoritmo3DES);
            this.groupBox1.Controls.Add(this.algoritmoRijndael192);
            this.groupBox1.Controls.Add(this.algoritmoRijndael256);
            this.groupBox1.Controls.Add(this.algoritmoTwofish);
            this.groupBox1.Font = new System.Drawing.Font("DM Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(52, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(371, 140);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Algoritmo";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.modoECB);
            this.groupBox2.Controls.Add(this.modoOFB);
            this.groupBox2.Controls.Add(this.modoNOFB);
            this.groupBox2.Controls.Add(this.modoCBC);
            this.groupBox2.Controls.Add(this.modoCFB);
            this.groupBox2.Controls.Add(this.modoNCFB);
            this.groupBox2.Font = new System.Drawing.Font("DM Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(52, 187);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(371, 140);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Modo";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.hashSHA256);
            this.groupBox3.Controls.Add(this.hashSHA512);
            this.groupBox3.Controls.Add(this.hashNinguno);
            this.groupBox3.Font = new System.Drawing.Font("DM Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(52, 333);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(185, 140);
            this.groupBox3.TabIndex = 22;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Hash";
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.Transparent;
            this.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("DM Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnGuardar.Image = global::Criptografia.Properties.Resources.icons8_save_all_64;
            this.btnGuardar.Location = new System.Drawing.Point(303, 379);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(70, 66);
            this.btnGuardar.TabIndex = 19;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // configuracion
            // 
            this.AcceptButton = this.btnGuardar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(475, 473);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnGuardar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(491, 512);
            this.MinimumSize = new System.Drawing.Size(491, 512);
            this.Name = "configuracion";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configuración";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton algoritmoAES;
        private System.Windows.Forms.RadioButton algoritmoDES;
        private System.Windows.Forms.RadioButton algoritmo3DES;
        private System.Windows.Forms.RadioButton algoritmoRijndael192;
        private System.Windows.Forms.RadioButton algoritmoRijndael256;
        private System.Windows.Forms.RadioButton algoritmoTwofish;
        private System.Windows.Forms.RadioButton modoECB;
        private System.Windows.Forms.RadioButton modoOFB;
        private System.Windows.Forms.RadioButton modoNOFB;
        private System.Windows.Forms.RadioButton modoCBC;
        private System.Windows.Forms.RadioButton modoCFB;
        private System.Windows.Forms.RadioButton modoNCFB;
        private System.Windows.Forms.RadioButton hashSHA256;
        private System.Windows.Forms.RadioButton hashSHA512;
        private System.Windows.Forms.RadioButton hashNinguno;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}

