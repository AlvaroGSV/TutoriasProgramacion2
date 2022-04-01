namespace AerolineaUI
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
            this.txtPrimerNombre = new System.Windows.Forms.TextBox();
            this.txtSegundoNombre = new System.Windows.Forms.TextBox();
            this.txtSegundoApellido = new System.Windows.Forms.TextBox();
            this.txtPrimerApellido = new System.Windows.Forms.TextBox();
            this.cmbNacionaliad = new System.Windows.Forms.ComboBox();
            this.txteMail = new System.Windows.Forms.TextBox();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.numudEdad = new System.Windows.Forms.NumericUpDown();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbSi = new System.Windows.Forms.RadioButton();
            this.rdbNO = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdbNoMascota = new System.Windows.Forms.RadioButton();
            this.rdbSiMascota = new System.Windows.Forms.RadioButton();
            this.lblRes = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numudEdad)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtPrimerNombre
            // 
            this.txtPrimerNombre.Location = new System.Drawing.Point(12, 33);
            this.txtPrimerNombre.MaxLength = 25;
            this.txtPrimerNombre.Name = "txtPrimerNombre";
            this.txtPrimerNombre.Size = new System.Drawing.Size(190, 20);
            this.txtPrimerNombre.TabIndex = 0;
            // 
            // txtSegundoNombre
            // 
            this.txtSegundoNombre.Location = new System.Drawing.Point(292, 33);
            this.txtSegundoNombre.MaxLength = 25;
            this.txtSegundoNombre.Name = "txtSegundoNombre";
            this.txtSegundoNombre.Size = new System.Drawing.Size(190, 20);
            this.txtSegundoNombre.TabIndex = 1;
            // 
            // txtSegundoApellido
            // 
            this.txtSegundoApellido.Location = new System.Drawing.Point(292, 88);
            this.txtSegundoApellido.MaxLength = 25;
            this.txtSegundoApellido.Name = "txtSegundoApellido";
            this.txtSegundoApellido.Size = new System.Drawing.Size(190, 20);
            this.txtSegundoApellido.TabIndex = 3;
            // 
            // txtPrimerApellido
            // 
            this.txtPrimerApellido.Location = new System.Drawing.Point(12, 88);
            this.txtPrimerApellido.MaxLength = 25;
            this.txtPrimerApellido.Name = "txtPrimerApellido";
            this.txtPrimerApellido.Size = new System.Drawing.Size(190, 20);
            this.txtPrimerApellido.TabIndex = 2;
            // 
            // cmbNacionaliad
            // 
            this.cmbNacionaliad.FormattingEnabled = true;
            this.cmbNacionaliad.Items.AddRange(new object[] {
            "MX",
            "USA",
            "CA",
            "DE",
            "FR",
            "SK",
            "CH",
            "JP",
            "TH"});
            this.cmbNacionaliad.Location = new System.Drawing.Point(12, 148);
            this.cmbNacionaliad.Name = "cmbNacionaliad";
            this.cmbNacionaliad.Size = new System.Drawing.Size(190, 21);
            this.cmbNacionaliad.TabIndex = 4;
            // 
            // txteMail
            // 
            this.txteMail.Location = new System.Drawing.Point(292, 207);
            this.txteMail.MaxLength = 200;
            this.txteMail.Name = "txteMail";
            this.txteMail.Size = new System.Drawing.Size(190, 20);
            this.txteMail.TabIndex = 7;
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(12, 207);
            this.txtTel.MaxLength = 10;
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(190, 20);
            this.txtTel.TabIndex = 6;
            // 
            // numudEdad
            // 
            this.numudEdad.Location = new System.Drawing.Point(292, 149);
            this.numudEdad.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.numudEdad.Name = "numudEdad";
            this.numudEdad.Size = new System.Drawing.Size(190, 20);
            this.numudEdad.TabIndex = 8;
            this.numudEdad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numudEdad.Value = new decimal(new int[] {
            18,
            0,
            0,
            0});
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnSave.Location = new System.Drawing.Point(347, 261);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 40);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnCancel.Location = new System.Drawing.Point(92, 261);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 40);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbNO);
            this.groupBox1.Controls.Add(this.rdbSi);
            this.groupBox1.Location = new System.Drawing.Point(12, 343);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(167, 80);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "¿tiene seguro?";
            // 
            // rdbSi
            // 
            this.rdbSi.AutoSize = true;
            this.rdbSi.Location = new System.Drawing.Point(6, 40);
            this.rdbSi.Name = "rdbSi";
            this.rdbSi.Size = new System.Drawing.Size(35, 17);
            this.rdbSi.TabIndex = 0;
            this.rdbSi.Text = "SI";
            this.rdbSi.UseVisualStyleBackColor = true;
            // 
            // rdbNO
            // 
            this.rdbNO.AutoSize = true;
            this.rdbNO.Checked = true;
            this.rdbNO.Location = new System.Drawing.Point(80, 40);
            this.rdbNO.Name = "rdbNO";
            this.rdbNO.Size = new System.Drawing.Size(41, 17);
            this.rdbNO.TabIndex = 1;
            this.rdbNO.TabStop = true;
            this.rdbNO.Text = "NO";
            this.rdbNO.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdbNoMascota);
            this.groupBox2.Controls.Add(this.rdbSiMascota);
            this.groupBox2.Location = new System.Drawing.Point(292, 343);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(167, 80);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "¿viajas con tu mascota?";
            // 
            // rdbNoMascota
            // 
            this.rdbNoMascota.AutoSize = true;
            this.rdbNoMascota.Checked = true;
            this.rdbNoMascota.Location = new System.Drawing.Point(80, 40);
            this.rdbNoMascota.Name = "rdbNoMascota";
            this.rdbNoMascota.Size = new System.Drawing.Size(41, 17);
            this.rdbNoMascota.TabIndex = 1;
            this.rdbNoMascota.TabStop = true;
            this.rdbNoMascota.Text = "NO";
            this.rdbNoMascota.UseVisualStyleBackColor = true;
            // 
            // rdbSiMascota
            // 
            this.rdbSiMascota.AutoSize = true;
            this.rdbSiMascota.Location = new System.Drawing.Point(6, 40);
            this.rdbSiMascota.Name = "rdbSiMascota";
            this.rdbSiMascota.Size = new System.Drawing.Size(35, 17);
            this.rdbSiMascota.TabIndex = 0;
            this.rdbSiMascota.Text = "SI";
            this.rdbSiMascota.UseVisualStyleBackColor = true;
            // 
            // lblRes
            // 
            this.lblRes.AutoSize = true;
            this.lblRes.Location = new System.Drawing.Point(236, 13);
            this.lblRes.Name = "lblRes";
            this.lblRes.Size = new System.Drawing.Size(35, 13);
            this.lblRes.TabIndex = 13;
            this.lblRes.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 471);
            this.Controls.Add(this.lblRes);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.numudEdad);
            this.Controls.Add(this.txteMail);
            this.Controls.Add(this.txtTel);
            this.Controls.Add(this.cmbNacionaliad);
            this.Controls.Add(this.txtSegundoApellido);
            this.Controls.Add(this.txtPrimerApellido);
            this.Controls.Add(this.txtSegundoNombre);
            this.Controls.Add(this.txtPrimerNombre);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Registro de pasajeros";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numudEdad)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPrimerNombre;
        private System.Windows.Forms.TextBox txtSegundoNombre;
        private System.Windows.Forms.TextBox txtSegundoApellido;
        private System.Windows.Forms.TextBox txtPrimerApellido;
        private System.Windows.Forms.ComboBox cmbNacionaliad;
        private System.Windows.Forms.TextBox txteMail;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.NumericUpDown numudEdad;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbNO;
        private System.Windows.Forms.RadioButton rdbSi;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdbNoMascota;
        private System.Windows.Forms.RadioButton rdbSiMascota;
        private System.Windows.Forms.Label lblRes;
    }
}

