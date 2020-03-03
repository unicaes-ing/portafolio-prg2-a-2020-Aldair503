namespace Ejercicio_2_G2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCant = new System.Windows.Forms.TextBox();
            this.txtPrec = new System.Windows.Forms.TextBox();
            this.Descuento = new System.Windows.Forms.GroupBox();
            this.rdb0 = new System.Windows.Forms.RadioButton();
            this.radio5 = new System.Windows.Forms.RadioButton();
            this.radio10 = new System.Windows.Forms.RadioButton();
            this.radio15 = new System.Windows.Forms.RadioButton();
            this.radio20 = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDescuento = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.Descuento.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cantidad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Precio";
            // 
            // txtCant
            // 
            this.txtCant.Location = new System.Drawing.Point(105, 32);
            this.txtCant.Name = "txtCant";
            this.txtCant.Size = new System.Drawing.Size(100, 20);
            this.txtCant.TabIndex = 3;
            // 
            // txtPrec
            // 
            this.txtPrec.Location = new System.Drawing.Point(105, 77);
            this.txtPrec.Name = "txtPrec";
            this.txtPrec.Size = new System.Drawing.Size(100, 20);
            this.txtPrec.TabIndex = 4;
            // 
            // Descuento
            // 
            this.Descuento.Controls.Add(this.radio20);
            this.Descuento.Controls.Add(this.radio15);
            this.Descuento.Controls.Add(this.radio10);
            this.Descuento.Controls.Add(this.radio5);
            this.Descuento.Controls.Add(this.rdb0);
            this.Descuento.Location = new System.Drawing.Point(243, 32);
            this.Descuento.Name = "Descuento";
            this.Descuento.Size = new System.Drawing.Size(108, 144);
            this.Descuento.TabIndex = 5;
            this.Descuento.TabStop = false;
            this.Descuento.Text = "Descuento";
            // 
            // rdb0
            // 
            this.rdb0.AutoSize = true;
            this.rdb0.Location = new System.Drawing.Point(7, 20);
            this.rdb0.Name = "rdb0";
            this.rdb0.Size = new System.Drawing.Size(39, 17);
            this.rdb0.TabIndex = 0;
            this.rdb0.TabStop = true;
            this.rdb0.Text = "0%";
            this.rdb0.UseVisualStyleBackColor = true;
            // 
            // radio5
            // 
            this.radio5.AutoSize = true;
            this.radio5.Location = new System.Drawing.Point(7, 43);
            this.radio5.Name = "radio5";
            this.radio5.Size = new System.Drawing.Size(39, 17);
            this.radio5.TabIndex = 1;
            this.radio5.TabStop = true;
            this.radio5.Text = "5%";
            this.radio5.UseVisualStyleBackColor = true;
            // 
            // radio10
            // 
            this.radio10.AutoSize = true;
            this.radio10.Location = new System.Drawing.Point(7, 66);
            this.radio10.Name = "radio10";
            this.radio10.Size = new System.Drawing.Size(45, 17);
            this.radio10.TabIndex = 2;
            this.radio10.TabStop = true;
            this.radio10.Text = "10%";
            this.radio10.UseVisualStyleBackColor = true;
            // 
            // radio15
            // 
            this.radio15.AutoSize = true;
            this.radio15.Location = new System.Drawing.Point(7, 85);
            this.radio15.Name = "radio15";
            this.radio15.Size = new System.Drawing.Size(45, 17);
            this.radio15.TabIndex = 3;
            this.radio15.TabStop = true;
            this.radio15.Text = "15%";
            this.radio15.UseVisualStyleBackColor = true;
            // 
            // radio20
            // 
            this.radio20.AutoSize = true;
            this.radio20.Location = new System.Drawing.Point(7, 108);
            this.radio20.Name = "radio20";
            this.radio20.Size = new System.Drawing.Size(45, 17);
            this.radio20.TabIndex = 4;
            this.radio20.TabStop = true;
            this.radio20.Text = "20%";
            this.radio20.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Descuento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Total";
            // 
            // txtDescuento
            // 
            this.txtDescuento.Location = new System.Drawing.Point(121, 173);
            this.txtDescuento.Name = "txtDescuento";
            this.txtDescuento.Size = new System.Drawing.Size(100, 20);
            this.txtDescuento.TabIndex = 8;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(121, 207);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(100, 20);
            this.txtTotal.TabIndex = 9;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(121, 117);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 10;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(121, 255);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 11;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(217, 254);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 12;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtDescuento);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Descuento);
            this.Controls.Add(this.txtPrec);
            this.Controls.Add(this.txtCant);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Descuento.ResumeLayout(false);
            this.Descuento.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCant;
        private System.Windows.Forms.TextBox txtPrec;
        private System.Windows.Forms.GroupBox Descuento;
        private System.Windows.Forms.RadioButton radio20;
        private System.Windows.Forms.RadioButton radio15;
        private System.Windows.Forms.RadioButton radio10;
        private System.Windows.Forms.RadioButton radio5;
        private System.Windows.Forms.RadioButton rdb0;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDescuento;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnSalir;
    }
}

