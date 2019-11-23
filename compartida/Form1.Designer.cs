namespace compartida
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.TxRuta = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BtEjecutar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.TxDirectoriosCopiar = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxCopiados = new System.Windows.Forms.RichTextBox();
            this.TxErrores = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label34 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // TxRuta
            // 
            this.TxRuta.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxRuta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.TxRuta.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxRuta.ForeColor = System.Drawing.Color.Black;
            this.TxRuta.Location = new System.Drawing.Point(153, 164);
            this.TxRuta.Multiline = true;
            this.TxRuta.Name = "TxRuta";
            this.TxRuta.ReadOnly = true;
            this.TxRuta.Size = new System.Drawing.Size(908, 42);
            this.TxRuta.TabIndex = 2;
            this.TxRuta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(12, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ruta Archivo:";
            // 
            // BtEjecutar
            // 
            this.BtEjecutar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtEjecutar.BackColor = System.Drawing.Color.Navy;
            this.BtEjecutar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtEjecutar.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtEjecutar.ForeColor = System.Drawing.Color.White;
            this.BtEjecutar.Location = new System.Drawing.Point(812, 217);
            this.BtEjecutar.Name = "BtEjecutar";
            this.BtEjecutar.Size = new System.Drawing.Size(249, 42);
            this.BtEjecutar.TabIndex = 7;
            this.BtEjecutar.Text = "EJECUTAR COPIADO";
            this.BtEjecutar.UseVisualStyleBackColor = false;
            this.BtEjecutar.Click += new System.EventHandler(this.BtEjecutar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(12, 235);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(203, 24);
            this.label3.TabIndex = 10;
            this.label3.Text = "Directorios A Copiar:";
            // 
            // TxDirectoriosCopiar
            // 
            this.TxDirectoriosCopiar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxDirectoriosCopiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.TxDirectoriosCopiar.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxDirectoriosCopiar.ForeColor = System.Drawing.Color.Black;
            this.TxDirectoriosCopiar.Location = new System.Drawing.Point(16, 270);
            this.TxDirectoriosCopiar.Name = "TxDirectoriosCopiar";
            this.TxDirectoriosCopiar.ReadOnly = true;
            this.TxDirectoriosCopiar.Size = new System.Drawing.Size(1045, 122);
            this.TxDirectoriosCopiar.TabIndex = 12;
            this.TxDirectoriosCopiar.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(12, 395);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(210, 24);
            this.label4.TabIndex = 13;
            this.label4.Text = "Directorios Copiados:";
            // 
            // TxCopiados
            // 
            this.TxCopiados.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxCopiados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.TxCopiados.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxCopiados.ForeColor = System.Drawing.Color.Black;
            this.TxCopiados.Location = new System.Drawing.Point(16, 422);
            this.TxCopiados.Name = "TxCopiados";
            this.TxCopiados.ReadOnly = true;
            this.TxCopiados.Size = new System.Drawing.Size(540, 149);
            this.TxCopiados.TabIndex = 14;
            this.TxCopiados.Text = "";
            // 
            // TxErrores
            // 
            this.TxErrores.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxErrores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.TxErrores.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxErrores.ForeColor = System.Drawing.Color.Black;
            this.TxErrores.Location = new System.Drawing.Point(562, 422);
            this.TxErrores.Name = "TxErrores";
            this.TxErrores.ReadOnly = true;
            this.TxErrores.Size = new System.Drawing.Size(499, 149);
            this.TxErrores.TabIndex = 15;
            this.TxErrores.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(562, 395);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(207, 24);
            this.label5.TabIndex = 16;
            this.label5.Text = "Errores Presentados:";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Navy;
            this.panel1.Controls.Add(this.label34);
            this.panel1.Location = new System.Drawing.Point(-6, 577);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1085, 40);
            this.panel1.TabIndex = 17;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = global::compartida.Properties.Resources.ministerio_tic_logo_vd;
            this.pictureBox1.Location = new System.Drawing.Point(-6, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1082, 111);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // label34
            // 
            this.label34.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label34.AutoSize = true;
            this.label34.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label34.ForeColor = System.Drawing.Color.White;
            this.label34.Location = new System.Drawing.Point(605, 6);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(477, 25);
            this.label34.TabIndex = 3;
            this.label34.Text = "Desarrollado por Luis Rueda y Jesus Osorio";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.Navy;
            this.panel2.Controls.Add(this.label6);
            this.panel2.Location = new System.Drawing.Point(-6, 108);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1082, 40);
            this.panel2.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(18, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(1049, 25);
            this.label6.TabIndex = 3;
            this.label6.Text = "Sistema De Copiado";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1073, 632);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TxErrores);
            this.Controls.Add(this.TxCopiados);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxDirectoriosCopiar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BtEjecutar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxRuta);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Punto Vive Digital Lab Soledad";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxRuta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtEjecutar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox TxDirectoriosCopiar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox TxCopiados;
        private System.Windows.Forms.RichTextBox TxErrores;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
    }
}

