namespace Examen_Simulacion
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvSimulaciones = new System.Windows.Forms.DataGridView();
            this.nroFila = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reloj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rndAtencion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.atencion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rndGenero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rndTiempoAtencion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tiempoAtencion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.finAtencion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rndVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.venta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rndCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ganancia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gananciaAcumulada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costoAcumulado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contadorVisitas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contadorVentas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contadorSuscripciones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.lblProbabilidad = new System.Windows.Forms.Label();
            this.lblCantidadSusc = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSimulaciones)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(786, 239);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(470, 75);
            this.label1.TabIndex = 0;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(21, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(752, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Un vendedor de suscripciones a libros va de puerta en puerta intentando generar g" +
    "anancias. Este es su historial de ventas\r\n";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(95, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Probabilidad de atención";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(353, 75);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(64, 23);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "0,7";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(353, 115);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(64, 23);
            this.textBox4.TabIndex = 9;
            this.textBox4.Text = "0,8";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(95, 118);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(212, 15);
            this.label6.TabIndex = 8;
            this.label6.Text = "Probabilidad de que atienda una mujer";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(353, 199);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(64, 23);
            this.textBox2.TabIndex = 13;
            this.textBox2.Text = "0,3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(95, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(176, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "Probabilidad de venta a hombre";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(353, 159);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(64, 23);
            this.textBox3.TabIndex = 11;
            this.textBox3.Text = "0,15";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(95, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(165, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "Probabilidad de venta a mujer";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(353, 287);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(64, 23);
            this.textBox5.TabIndex = 17;
            this.textBox5.Text = "0,5";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(95, 290);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 15);
            this.label7.TabIndex = 16;
            this.label7.Text = "Gasto por casa $";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(353, 247);
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(64, 23);
            this.textBox6.TabIndex = 15;
            this.textBox6.Text = "5";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(95, 250);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(141, 15);
            this.label8.TabIndex = 14;
            this.label8.Text = "Utilidad por suscripción $";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(1133, 154);
            this.textBox7.Name = "textBox7";
            this.textBox7.ReadOnly = true;
            this.textBox7.Size = new System.Drawing.Size(64, 23);
            this.textBox7.TabIndex = 29;
            this.textBox7.Text = "20 (max)";
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(1133, 112);
            this.textBox8.Name = "textBox8";
            this.textBox8.ReadOnly = true;
            this.textBox8.Size = new System.Drawing.Size(64, 23);
            this.textBox8.TabIndex = 27;
            this.textBox8.Text = "25 (max)";
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(1044, 196);
            this.textBox9.Name = "textBox9";
            this.textBox9.ReadOnly = true;
            this.textBox9.Size = new System.Drawing.Size(64, 23);
            this.textBox9.TabIndex = 25;
            this.textBox9.Text = "4";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(786, 199);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(245, 15);
            this.label11.TabIndex = 24;
            this.label11.Text = "Demora extra por cada suscripción (minutos)";
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(1044, 156);
            this.textBox10.Name = "textBox10";
            this.textBox10.ReadOnly = true;
            this.textBox10.Size = new System.Drawing.Size(64, 23);
            this.textBox10.TabIndex = 23;
            this.textBox10.Text = "15 (min)";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(786, 159);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(152, 15);
            this.label12.TabIndex = 22;
            this.label12.Text = "Demora en venta (minutos)";
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(1044, 112);
            this.textBox11.Name = "textBox11";
            this.textBox11.ReadOnly = true;
            this.textBox11.Size = new System.Drawing.Size(64, 23);
            this.textBox11.TabIndex = 21;
            this.textBox11.Text = "15 (min)";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(786, 115);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(169, 15);
            this.label13.TabIndex = 20;
            this.label13.Text = "Demora en no venta (minutos)";
            // 
            // textBox12
            // 
            this.textBox12.Location = new System.Drawing.Point(1044, 72);
            this.textBox12.Name = "textBox12";
            this.textBox12.ReadOnly = true;
            this.textBox12.Size = new System.Drawing.Size(64, 23);
            this.textBox12.TabIndex = 19;
            this.textBox12.Text = "2";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(786, 75);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(186, 15);
            this.label14.TabIndex = 18;
            this.label14.Text = "Demora en no atención (minutos)";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvSimulaciones);
            this.panel1.Location = new System.Drawing.Point(29, 402);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1311, 409);
            this.panel1.TabIndex = 30;
            // 
            // dgvSimulaciones
            // 
            this.dgvSimulaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSimulaciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nroFila,
            this.reloj,
            this.rndAtencion,
            this.atencion,
            this.rndGenero,
            this.genero,
            this.rndTiempoAtencion,
            this.tiempoAtencion,
            this.finAtencion,
            this.rndVenta,
            this.venta,
            this.rndCantidad,
            this.cantidad,
            this.ganancia,
            this.gananciaAcumulada,
            this.costo,
            this.costoAcumulado,
            this.contadorVisitas,
            this.contadorVentas,
            this.contadorSuscripciones});
            this.dgvSimulaciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSimulaciones.Location = new System.Drawing.Point(0, 0);
            this.dgvSimulaciones.Name = "dgvSimulaciones";
            this.dgvSimulaciones.RowTemplate.Height = 25;
            this.dgvSimulaciones.Size = new System.Drawing.Size(1311, 409);
            this.dgvSimulaciones.TabIndex = 0;
            // 
            // nroFila
            // 
            this.nroFila.HeaderText = "Nro fila";
            this.nroFila.Name = "nroFila";
            this.nroFila.ReadOnly = true;
            // 
            // reloj
            // 
            this.reloj.HeaderText = "Reloj";
            this.reloj.Name = "reloj";
            // 
            // rndAtencion
            // 
            this.rndAtencion.HeaderText = "RND atención";
            this.rndAtencion.Name = "rndAtencion";
            // 
            // atencion
            // 
            this.atencion.HeaderText = "Es atendido";
            this.atencion.Name = "atencion";
            this.atencion.ReadOnly = true;
            // 
            // rndGenero
            // 
            this.rndGenero.HeaderText = "RND género";
            this.rndGenero.Name = "rndGenero";
            this.rndGenero.ReadOnly = true;
            // 
            // genero
            // 
            this.genero.HeaderText = "Género";
            this.genero.Name = "genero";
            this.genero.ReadOnly = true;
            // 
            // rndTiempoAtencion
            // 
            this.rndTiempoAtencion.HeaderText = "RND tiempo atención";
            this.rndTiempoAtencion.Name = "rndTiempoAtencion";
            this.rndTiempoAtencion.ReadOnly = true;
            // 
            // tiempoAtencion
            // 
            this.tiempoAtencion.HeaderText = "Tiempo atención";
            this.tiempoAtencion.Name = "tiempoAtencion";
            this.tiempoAtencion.ReadOnly = true;
            // 
            // finAtencion
            // 
            this.finAtencion.HeaderText = "Fin atención";
            this.finAtencion.Name = "finAtencion";
            this.finAtencion.ReadOnly = true;
            // 
            // rndVenta
            // 
            this.rndVenta.HeaderText = "RND venta";
            this.rndVenta.Name = "rndVenta";
            this.rndVenta.ReadOnly = true;
            // 
            // venta
            // 
            this.venta.HeaderText = "Hubo venta";
            this.venta.Name = "venta";
            // 
            // rndCantidad
            // 
            this.rndCantidad.HeaderText = "RND Cantidad suscripciones";
            this.rndCantidad.Name = "rndCantidad";
            this.rndCantidad.ReadOnly = true;
            // 
            // cantidad
            // 
            this.cantidad.HeaderText = "Cantidad suscripciones";
            this.cantidad.Name = "cantidad";
            // 
            // ganancia
            // 
            this.ganancia.HeaderText = "Ganancia";
            this.ganancia.Name = "ganancia";
            // 
            // gananciaAcumulada
            // 
            this.gananciaAcumulada.HeaderText = "Ganancia acumulada";
            this.gananciaAcumulada.Name = "gananciaAcumulada";
            this.gananciaAcumulada.ReadOnly = true;
            // 
            // costo
            // 
            this.costo.HeaderText = "Costo";
            this.costo.Name = "costo";
            this.costo.ReadOnly = true;
            // 
            // costoAcumulado
            // 
            this.costoAcumulado.HeaderText = "Costo acumulado";
            this.costoAcumulado.Name = "costoAcumulado";
            this.costoAcumulado.ReadOnly = true;
            // 
            // contadorVisitas
            // 
            this.contadorVisitas.HeaderText = "Cantidad de visitas";
            this.contadorVisitas.Name = "contadorVisitas";
            this.contadorVisitas.ReadOnly = true;
            // 
            // contadorVentas
            // 
            this.contadorVentas.HeaderText = "Cantidad ventas";
            this.contadorVentas.Name = "contadorVentas";
            this.contadorVentas.ReadOnly = true;
            // 
            // contadorSuscripciones
            // 
            this.contadorSuscripciones.HeaderText = "Cantidad suscripciones";
            this.contadorSuscripciones.Name = "contadorSuscripciones";
            this.contadorSuscripciones.ReadOnly = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1056, 317);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 61);
            this.button1.TabIndex = 31;
            this.button1.Text = "Simular";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblProbabilidad
            // 
            this.lblProbabilidad.AutoSize = true;
            this.lblProbabilidad.Location = new System.Drawing.Point(34, 844);
            this.lblProbabilidad.Name = "lblProbabilidad";
            this.lblProbabilidad.Size = new System.Drawing.Size(212, 15);
            this.lblProbabilidad.TabIndex = 32;
            this.lblProbabilidad.Text = "Probabilidad de vender suscripciones:  ";
            // 
            // lblCantidadSusc
            // 
            this.lblCantidadSusc.AutoSize = true;
            this.lblCantidadSusc.Location = new System.Drawing.Point(34, 878);
            this.lblCantidadSusc.Name = "lblCantidadSusc";
            this.lblCantidadSusc.Size = new System.Drawing.Size(283, 15);
            this.lblCantidadSusc.TabIndex = 33;
            this.lblCantidadSusc.Text = "Cantidad de suscripciones a vender en 10000 visitas: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1368, 925);
            this.Controls.Add(this.lblCantidadSusc);
            this.Controls.Add(this.lblProbabilidad);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.textBox10);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.textBox11);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.textBox12);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Simulación";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSimulaciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvSimulaciones;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nroFila;
        private System.Windows.Forms.DataGridViewTextBoxColumn reloj;
        private System.Windows.Forms.DataGridViewTextBoxColumn rndAtencion;
        private System.Windows.Forms.DataGridViewTextBoxColumn atencion;
        private System.Windows.Forms.DataGridViewTextBoxColumn rndGenero;
        private System.Windows.Forms.DataGridViewTextBoxColumn genero;
        private System.Windows.Forms.DataGridViewTextBoxColumn rndTiempoAtencion;
        private System.Windows.Forms.DataGridViewTextBoxColumn tiempoAtencion;
        private System.Windows.Forms.DataGridViewTextBoxColumn finAtencion;
        private System.Windows.Forms.DataGridViewTextBoxColumn rndVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn venta;
        private System.Windows.Forms.DataGridViewTextBoxColumn rndCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn ganancia;
        private System.Windows.Forms.DataGridViewTextBoxColumn gananciaAcumulada;
        private System.Windows.Forms.DataGridViewTextBoxColumn costo;
        private System.Windows.Forms.DataGridViewTextBoxColumn costoAcumulado;
        private System.Windows.Forms.DataGridViewTextBoxColumn contadorVisitas;
        private System.Windows.Forms.DataGridViewTextBoxColumn contadorVentas;
        private System.Windows.Forms.DataGridViewTextBoxColumn contadorSuscripciones;
        private System.Windows.Forms.Label lblProbabilidad;
        private System.Windows.Forms.Label lblCantidadSusc;
    }
}
