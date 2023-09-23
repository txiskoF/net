namespace CalculadoraProgramador
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.D = new System.Windows.Forms.TextBox();
            this.B = new System.Windows.Forms.TextBox();
            this.O = new System.Windows.Forms.TextBox();
            this.H = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Quince = new System.Windows.Forms.Button();
            this.Catorce = new System.Windows.Forms.Button();
            this.Trece = new System.Windows.Forms.Button();
            this.Doce = new System.Windows.Forms.Button();
            this.Once = new System.Windows.Forms.Button();
            this.Diez = new System.Windows.Forms.Button();
            this.Tres = new System.Windows.Forms.Button();
            this.Seis = new System.Windows.Forms.Button();
            this.Nueve = new System.Windows.Forms.Button();
            this.Borrar = new System.Windows.Forms.Button();
            this.Dos = new System.Windows.Forms.Button();
            this.Cinco = new System.Windows.Forms.Button();
            this.Ocho = new System.Windows.Forms.Button();
            this.Cero = new System.Windows.Forms.Button();
            this.Uno = new System.Windows.Forms.Button();
            this.Cuatro = new System.Windows.Forms.Button();
            this.Siete = new System.Windows.Forms.Button();
            this.Del = new System.Windows.Forms.Button();
            this.Hexadecimal = new System.Windows.Forms.RadioButton();
            this.Octal = new System.Windows.Forms.RadioButton();
            this.Binario = new System.Windows.Forms.RadioButton();
            this.Decimal = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // D
            // 
            this.D.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.D.Location = new System.Drawing.Point(6, 28);
            this.D.Name = "D";
            this.D.ReadOnly = true;
            this.D.Size = new System.Drawing.Size(292, 29);
            this.D.TabIndex = 0;
            this.D.TabStop = false;
            this.D.Text = "0";
            this.D.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // B
            // 
            this.B.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B.Location = new System.Drawing.Point(6, 63);
            this.B.Name = "B";
            this.B.ReadOnly = true;
            this.B.Size = new System.Drawing.Size(292, 29);
            this.B.TabIndex = 1;
            this.B.TabStop = false;
            this.B.Text = "0";
            this.B.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // O
            // 
            this.O.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.O.Location = new System.Drawing.Point(6, 98);
            this.O.Name = "O";
            this.O.ReadOnly = true;
            this.O.Size = new System.Drawing.Size(292, 29);
            this.O.TabIndex = 2;
            this.O.TabStop = false;
            this.O.Text = "0";
            this.O.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // H
            // 
            this.H.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.H.Location = new System.Drawing.Point(6, 133);
            this.H.Name = "H";
            this.H.ReadOnly = true;
            this.H.Size = new System.Drawing.Size(292, 29);
            this.H.TabIndex = 3;
            this.H.TabStop = false;
            this.H.Text = "0";
            this.H.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Quince);
            this.groupBox1.Controls.Add(this.Catorce);
            this.groupBox1.Controls.Add(this.Trece);
            this.groupBox1.Controls.Add(this.Doce);
            this.groupBox1.Controls.Add(this.Once);
            this.groupBox1.Controls.Add(this.Diez);
            this.groupBox1.Controls.Add(this.Tres);
            this.groupBox1.Controls.Add(this.Seis);
            this.groupBox1.Controls.Add(this.Nueve);
            this.groupBox1.Controls.Add(this.Borrar);
            this.groupBox1.Controls.Add(this.Dos);
            this.groupBox1.Controls.Add(this.Cinco);
            this.groupBox1.Controls.Add(this.Ocho);
            this.groupBox1.Controls.Add(this.Cero);
            this.groupBox1.Controls.Add(this.Uno);
            this.groupBox1.Controls.Add(this.Cuatro);
            this.groupBox1.Controls.Add(this.Siete);
            this.groupBox1.Controls.Add(this.Del);
            this.groupBox1.Controls.Add(this.Hexadecimal);
            this.groupBox1.Controls.Add(this.Octal);
            this.groupBox1.Controls.Add(this.Binario);
            this.groupBox1.Controls.Add(this.Decimal);
            this.groupBox1.Controls.Add(this.D);
            this.groupBox1.Controls.Add(this.H);
            this.groupBox1.Controls.Add(this.B);
            this.groupBox1.Controls.Add(this.O);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(395, 333);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Base";
            // 
            // Quince
            // 
            this.Quince.Enabled = false;
            this.Quince.Location = new System.Drawing.Point(330, 248);
            this.Quince.Name = "Quince";
            this.Quince.Size = new System.Drawing.Size(59, 74);
            this.Quince.TabIndex = 24;
            this.Quince.Text = "F";
            this.Quince.UseVisualStyleBackColor = true;
            this.Quince.Click += new System.EventHandler(this.Quince_Click);
            // 
            // Catorce
            // 
            this.Catorce.Enabled = false;
            this.Catorce.Location = new System.Drawing.Point(330, 168);
            this.Catorce.Name = "Catorce";
            this.Catorce.Size = new System.Drawing.Size(59, 74);
            this.Catorce.TabIndex = 23;
            this.Catorce.Text = "E";
            this.Catorce.UseVisualStyleBackColor = true;
            this.Catorce.Click += new System.EventHandler(this.Catorce_Click);
            // 
            // Trece
            // 
            this.Trece.Enabled = false;
            this.Trece.Location = new System.Drawing.Point(249, 288);
            this.Trece.Name = "Trece";
            this.Trece.Size = new System.Drawing.Size(75, 34);
            this.Trece.TabIndex = 22;
            this.Trece.Text = "D";
            this.Trece.UseVisualStyleBackColor = true;
            this.Trece.Click += new System.EventHandler(this.Trece_Click);
            // 
            // Doce
            // 
            this.Doce.Enabled = false;
            this.Doce.Location = new System.Drawing.Point(249, 248);
            this.Doce.Name = "Doce";
            this.Doce.Size = new System.Drawing.Size(75, 34);
            this.Doce.TabIndex = 21;
            this.Doce.Text = "C";
            this.Doce.UseVisualStyleBackColor = true;
            this.Doce.Click += new System.EventHandler(this.Doce_Click);
            // 
            // Once
            // 
            this.Once.Enabled = false;
            this.Once.Location = new System.Drawing.Point(249, 208);
            this.Once.Name = "Once";
            this.Once.Size = new System.Drawing.Size(75, 34);
            this.Once.TabIndex = 20;
            this.Once.Text = "B";
            this.Once.UseVisualStyleBackColor = true;
            this.Once.Click += new System.EventHandler(this.Once_Click);
            // 
            // Diez
            // 
            this.Diez.Enabled = false;
            this.Diez.Location = new System.Drawing.Point(249, 168);
            this.Diez.Name = "Diez";
            this.Diez.Size = new System.Drawing.Size(75, 34);
            this.Diez.TabIndex = 19;
            this.Diez.Text = "A";
            this.Diez.UseVisualStyleBackColor = true;
            this.Diez.Click += new System.EventHandler(this.Diez_Click);
            // 
            // Tres
            // 
            this.Tres.Location = new System.Drawing.Point(168, 288);
            this.Tres.Name = "Tres";
            this.Tres.Size = new System.Drawing.Size(75, 34);
            this.Tres.TabIndex = 18;
            this.Tres.Text = "3";
            this.Tres.UseVisualStyleBackColor = true;
            this.Tres.Click += new System.EventHandler(this.Tres_Click);
            // 
            // Seis
            // 
            this.Seis.Location = new System.Drawing.Point(168, 248);
            this.Seis.Name = "Seis";
            this.Seis.Size = new System.Drawing.Size(75, 34);
            this.Seis.TabIndex = 17;
            this.Seis.Text = "6";
            this.Seis.UseVisualStyleBackColor = true;
            this.Seis.Click += new System.EventHandler(this.Seis_Click);
            // 
            // Nueve
            // 
            this.Nueve.Location = new System.Drawing.Point(168, 208);
            this.Nueve.Name = "Nueve";
            this.Nueve.Size = new System.Drawing.Size(75, 34);
            this.Nueve.TabIndex = 16;
            this.Nueve.Text = "9";
            this.Nueve.UseVisualStyleBackColor = true;
            this.Nueve.Click += new System.EventHandler(this.Nueve_Click);
            // 
            // Borrar
            // 
            this.Borrar.Location = new System.Drawing.Point(168, 168);
            this.Borrar.Name = "Borrar";
            this.Borrar.Size = new System.Drawing.Size(75, 34);
            this.Borrar.TabIndex = 15;
            this.Borrar.Text = "Borrar";
            this.Borrar.UseVisualStyleBackColor = true;
            this.Borrar.Click += new System.EventHandler(this.Borrar_Click);
            // 
            // Dos
            // 
            this.Dos.Location = new System.Drawing.Point(87, 288);
            this.Dos.Name = "Dos";
            this.Dos.Size = new System.Drawing.Size(75, 34);
            this.Dos.TabIndex = 14;
            this.Dos.Text = "2";
            this.Dos.UseVisualStyleBackColor = true;
            this.Dos.Click += new System.EventHandler(this.Dos_Click);
            // 
            // Cinco
            // 
            this.Cinco.Location = new System.Drawing.Point(87, 248);
            this.Cinco.Name = "Cinco";
            this.Cinco.Size = new System.Drawing.Size(75, 34);
            this.Cinco.TabIndex = 13;
            this.Cinco.Text = "5";
            this.Cinco.UseVisualStyleBackColor = true;
            this.Cinco.Click += new System.EventHandler(this.Cinco_Click);
            // 
            // Ocho
            // 
            this.Ocho.Location = new System.Drawing.Point(87, 208);
            this.Ocho.Name = "Ocho";
            this.Ocho.Size = new System.Drawing.Size(75, 34);
            this.Ocho.TabIndex = 12;
            this.Ocho.Text = "8";
            this.Ocho.UseVisualStyleBackColor = true;
            this.Ocho.Click += new System.EventHandler(this.Ocho_Click);
            // 
            // Cero
            // 
            this.Cero.Location = new System.Drawing.Point(87, 168);
            this.Cero.Name = "Cero";
            this.Cero.Size = new System.Drawing.Size(75, 34);
            this.Cero.TabIndex = 11;
            this.Cero.Text = "0";
            this.Cero.UseVisualStyleBackColor = true;
            this.Cero.Click += new System.EventHandler(this.Cero_Click);
            // 
            // Uno
            // 
            this.Uno.Location = new System.Drawing.Point(6, 288);
            this.Uno.Name = "Uno";
            this.Uno.Size = new System.Drawing.Size(75, 34);
            this.Uno.TabIndex = 10;
            this.Uno.Text = "1";
            this.Uno.UseVisualStyleBackColor = true;
            this.Uno.Click += new System.EventHandler(this.Uno_Click);
            // 
            // Cuatro
            // 
            this.Cuatro.Location = new System.Drawing.Point(6, 248);
            this.Cuatro.Name = "Cuatro";
            this.Cuatro.Size = new System.Drawing.Size(75, 34);
            this.Cuatro.TabIndex = 9;
            this.Cuatro.Text = "4";
            this.Cuatro.UseVisualStyleBackColor = true;
            this.Cuatro.Click += new System.EventHandler(this.Cuatro_Click);
            // 
            // Siete
            // 
            this.Siete.Location = new System.Drawing.Point(6, 208);
            this.Siete.Name = "Siete";
            this.Siete.Size = new System.Drawing.Size(75, 34);
            this.Siete.TabIndex = 8;
            this.Siete.Text = "7";
            this.Siete.UseVisualStyleBackColor = true;
            this.Siete.Click += new System.EventHandler(this.Siete_Click);
            // 
            // Del
            // 
            this.Del.Location = new System.Drawing.Point(6, 168);
            this.Del.Name = "Del";
            this.Del.Size = new System.Drawing.Size(75, 34);
            this.Del.TabIndex = 5;
            this.Del.Text = "←";
            this.Del.UseVisualStyleBackColor = true;
            this.Del.Click += new System.EventHandler(this.Del_Click);
            // 
            // Hexadecimal
            // 
            this.Hexadecimal.AutoSize = true;
            this.Hexadecimal.Location = new System.Drawing.Point(304, 134);
            this.Hexadecimal.Name = "Hexadecimal";
            this.Hexadecimal.Size = new System.Drawing.Size(84, 25);
            this.Hexadecimal.TabIndex = 7;
            this.Hexadecimal.TabStop = true;
            this.Hexadecimal.Text = "HEX[16]";
            this.Hexadecimal.UseVisualStyleBackColor = true;
            this.Hexadecimal.CheckedChanged += new System.EventHandler(this.Hexadecimal_CheckedChanged);
            // 
            // Octal
            // 
            this.Octal.AutoSize = true;
            this.Octal.Location = new System.Drawing.Point(304, 98);
            this.Octal.Name = "Octal";
            this.Octal.Size = new System.Drawing.Size(77, 25);
            this.Octal.TabIndex = 6;
            this.Octal.TabStop = true;
            this.Octal.Text = "OCT[8]";
            this.Octal.UseVisualStyleBackColor = true;
            this.Octal.CheckedChanged += new System.EventHandler(this.Octal_CheckedChanged);
            // 
            // Binario
            // 
            this.Binario.AutoSize = true;
            this.Binario.Location = new System.Drawing.Point(304, 64);
            this.Binario.Name = "Binario";
            this.Binario.Size = new System.Drawing.Size(72, 25);
            this.Binario.TabIndex = 5;
            this.Binario.TabStop = true;
            this.Binario.Text = "BIN[2]";
            this.Binario.UseVisualStyleBackColor = true;
            this.Binario.CheckedChanged += new System.EventHandler(this.Binario_CheckedChanged);
            // 
            // Decimal
            // 
            this.Decimal.AutoSize = true;
            this.Decimal.Checked = true;
            this.Decimal.Location = new System.Drawing.Point(304, 29);
            this.Decimal.Name = "Decimal";
            this.Decimal.Size = new System.Drawing.Size(85, 25);
            this.Decimal.TabIndex = 4;
            this.Decimal.TabStop = true;
            this.Decimal.Text = "DEC[10]";
            this.Decimal.UseVisualStyleBackColor = true;
            this.Decimal.CheckedChanged += new System.EventHandler(this.Decimal_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 349);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Calculadora Programador";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox D;
        private System.Windows.Forms.TextBox B;
        private System.Windows.Forms.TextBox O;
        private System.Windows.Forms.TextBox H;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton Hexadecimal;
        private System.Windows.Forms.RadioButton Octal;
        private System.Windows.Forms.RadioButton Binario;
        private System.Windows.Forms.RadioButton Decimal;
        private System.Windows.Forms.Button Quince;
        private System.Windows.Forms.Button Catorce;
        private System.Windows.Forms.Button Trece;
        private System.Windows.Forms.Button Doce;
        private System.Windows.Forms.Button Once;
        private System.Windows.Forms.Button Diez;
        private System.Windows.Forms.Button Tres;
        private System.Windows.Forms.Button Seis;
        private System.Windows.Forms.Button Nueve;
        private System.Windows.Forms.Button Borrar;
        private System.Windows.Forms.Button Dos;
        private System.Windows.Forms.Button Cinco;
        private System.Windows.Forms.Button Ocho;
        private System.Windows.Forms.Button Cero;
        private System.Windows.Forms.Button Uno;
        private System.Windows.Forms.Button Cuatro;
        private System.Windows.Forms.Button Siete;
        private System.Windows.Forms.Button Del;
    }
}

