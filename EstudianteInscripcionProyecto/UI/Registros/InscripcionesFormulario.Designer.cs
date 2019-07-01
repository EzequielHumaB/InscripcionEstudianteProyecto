namespace EstudianteInscripcionProyecto.UI.Registros
{
    partial class InscripcionesFormulario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InscripcionesFormulario));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.IdnumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.MontonumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.FechadateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.Eliminarbutton = new System.Windows.Forms.Button();
            this.GuardarButton = new System.Windows.Forms.Button();
            this.Nuevobutton = new System.Windows.Forms.Button();
            this.Buscarbutton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.DetalledataGridView = new System.Windows.Forms.DataGridView();
            this.DetalleIdnumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.MyerrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.AgregarAlGridbutton = new System.Windows.Forms.Button();
            this.RemoverAlGrid = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.EstudiantecomboBox = new System.Windows.Forms.ComboBox();
            this.AsignaturacomboBox = new System.Windows.Forms.ComboBox();
            this.Asignaturabutton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.ResultadoNumerohumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.AcumularCreditosnumericUpDown = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.IdnumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MontonumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DetalledataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DetalleIdnumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyerrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResultadoNumerohumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AcumularCreditosnumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Inscripcion Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fecha Inscripcion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Monto";
            // 
            // IdnumericUpDown
            // 
            this.IdnumericUpDown.Location = new System.Drawing.Point(132, 24);
            this.IdnumericUpDown.Maximum = new decimal(new int[] {
            1316134912,
            2328,
            0,
            0});
            this.IdnumericUpDown.Name = "IdnumericUpDown";
            this.IdnumericUpDown.Size = new System.Drawing.Size(50, 20);
            this.IdnumericUpDown.TabIndex = 3;
            // 
            // MontonumericUpDown
            // 
            this.MontonumericUpDown.Location = new System.Drawing.Point(126, 97);
            this.MontonumericUpDown.Name = "MontonumericUpDown";
            this.MontonumericUpDown.Size = new System.Drawing.Size(56, 20);
            this.MontonumericUpDown.TabIndex = 4;
            // 
            // FechadateTimePicker
            // 
            this.FechadateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.FechadateTimePicker.Location = new System.Drawing.Point(132, 59);
            this.FechadateTimePicker.Name = "FechadateTimePicker";
            this.FechadateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.FechadateTimePicker.TabIndex = 5;
            // 
            // Eliminarbutton
            // 
            this.Eliminarbutton.Image = ((System.Drawing.Image)(resources.GetObject("Eliminarbutton.Image")));
            this.Eliminarbutton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Eliminarbutton.Location = new System.Drawing.Point(262, 450);
            this.Eliminarbutton.Name = "Eliminarbutton";
            this.Eliminarbutton.Size = new System.Drawing.Size(75, 57);
            this.Eliminarbutton.TabIndex = 34;
            this.Eliminarbutton.Text = "Eliminar";
            this.Eliminarbutton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Eliminarbutton.UseVisualStyleBackColor = true;
            this.Eliminarbutton.Click += new System.EventHandler(this.Eliminarbutton_Click);
            // 
            // GuardarButton
            // 
            this.GuardarButton.Image = ((System.Drawing.Image)(resources.GetObject("GuardarButton.Image")));
            this.GuardarButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.GuardarButton.Location = new System.Drawing.Point(155, 450);
            this.GuardarButton.Name = "GuardarButton";
            this.GuardarButton.Size = new System.Drawing.Size(75, 57);
            this.GuardarButton.TabIndex = 33;
            this.GuardarButton.Text = "Guardar";
            this.GuardarButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.GuardarButton.UseVisualStyleBackColor = true;
            this.GuardarButton.Click += new System.EventHandler(this.GuardarButton_Click);
            // 
            // Nuevobutton
            // 
            this.Nuevobutton.Image = ((System.Drawing.Image)(resources.GetObject("Nuevobutton.Image")));
            this.Nuevobutton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Nuevobutton.Location = new System.Drawing.Point(40, 450);
            this.Nuevobutton.Name = "Nuevobutton";
            this.Nuevobutton.Size = new System.Drawing.Size(75, 57);
            this.Nuevobutton.TabIndex = 32;
            this.Nuevobutton.Text = "Nuevo";
            this.Nuevobutton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Nuevobutton.UseVisualStyleBackColor = true;
            this.Nuevobutton.Click += new System.EventHandler(this.Nuevobutton_Click);
            // 
            // Buscarbutton
            // 
            this.Buscarbutton.Image = ((System.Drawing.Image)(resources.GetObject("Buscarbutton.Image")));
            this.Buscarbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Buscarbutton.Location = new System.Drawing.Point(217, 10);
            this.Buscarbutton.Name = "Buscarbutton";
            this.Buscarbutton.Size = new System.Drawing.Size(90, 34);
            this.Buscarbutton.TabIndex = 35;
            this.Buscarbutton.Text = "Buscar";
            this.Buscarbutton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Buscarbutton.UseVisualStyleBackColor = true;
            this.Buscarbutton.Click += new System.EventHandler(this.Buscarbutton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 36;
            this.label4.Text = "Detalle Id";
            // 
            // DetalledataGridView
            // 
            this.DetalledataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DetalledataGridView.Location = new System.Drawing.Point(40, 262);
            this.DetalledataGridView.Name = "DetalledataGridView";
            this.DetalledataGridView.Size = new System.Drawing.Size(355, 150);
            this.DetalledataGridView.TabIndex = 38;
            // 
            // DetalleIdnumericUpDown
            // 
            this.DetalleIdnumericUpDown.Location = new System.Drawing.Point(126, 134);
            this.DetalleIdnumericUpDown.Name = "DetalleIdnumericUpDown";
            this.DetalleIdnumericUpDown.Size = new System.Drawing.Size(56, 20);
            this.DetalleIdnumericUpDown.TabIndex = 39;
            // 
            // MyerrorProvider
            // 
            this.MyerrorProvider.ContainerControl = this;
            // 
            // AgregarAlGridbutton
            // 
            this.AgregarAlGridbutton.Image = ((System.Drawing.Image)(resources.GetObject("AgregarAlGridbutton.Image")));
            this.AgregarAlGridbutton.Location = new System.Drawing.Point(320, 222);
            this.AgregarAlGridbutton.Name = "AgregarAlGridbutton";
            this.AgregarAlGridbutton.Size = new System.Drawing.Size(75, 34);
            this.AgregarAlGridbutton.TabIndex = 41;
            this.AgregarAlGridbutton.UseVisualStyleBackColor = true;
            this.AgregarAlGridbutton.Click += new System.EventHandler(this.AgregarAlGridbutton_Click);
            // 
            // RemoverAlGrid
            // 
            this.RemoverAlGrid.Location = new System.Drawing.Point(38, 418);
            this.RemoverAlGrid.Name = "RemoverAlGrid";
            this.RemoverAlGrid.Size = new System.Drawing.Size(75, 23);
            this.RemoverAlGrid.TabIndex = 42;
            this.RemoverAlGrid.Text = "Remover";
            this.RemoverAlGrid.UseVisualStyleBackColor = true;
            this.RemoverAlGrid.Click += new System.EventHandler(this.RemoverAlGrid_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(181, 161);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 23);
            this.button1.TabIndex = 43;
            this.button1.Text = "Agregar Estudiante";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.EstudianteButton_Click);
            // 
            // EstudiantecomboBox
            // 
            this.EstudiantecomboBox.FormattingEnabled = true;
            this.EstudiantecomboBox.Location = new System.Drawing.Point(38, 161);
            this.EstudiantecomboBox.Name = "EstudiantecomboBox";
            this.EstudiantecomboBox.Size = new System.Drawing.Size(121, 21);
            this.EstudiantecomboBox.TabIndex = 44;
            // 
            // AsignaturacomboBox
            // 
            this.AsignaturacomboBox.FormattingEnabled = true;
            this.AsignaturacomboBox.Location = new System.Drawing.Point(38, 198);
            this.AsignaturacomboBox.Name = "AsignaturacomboBox";
            this.AsignaturacomboBox.Size = new System.Drawing.Size(121, 21);
            this.AsignaturacomboBox.TabIndex = 45;
            // 
            // Asignaturabutton
            // 
            this.Asignaturabutton.Location = new System.Drawing.Point(181, 198);
            this.Asignaturabutton.Name = "Asignaturabutton";
            this.Asignaturabutton.Size = new System.Drawing.Size(120, 23);
            this.Asignaturabutton.TabIndex = 46;
            this.Asignaturabutton.Text = "Agregar Asignatura";
            this.Asignaturabutton.UseVisualStyleBackColor = true;
            this.Asignaturabutton.Click += new System.EventHandler(this.Asignaturabutton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(259, 428);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 47;
            this.label5.Text = "Monto";
            // 
            // ResultadoNumerohumericUpDown
            // 
            this.ResultadoNumerohumericUpDown.Location = new System.Drawing.Point(316, 428);
            this.ResultadoNumerohumericUpDown.Name = "ResultadoNumerohumericUpDown";
            this.ResultadoNumerohumericUpDown.Size = new System.Drawing.Size(61, 20);
            this.ResultadoNumerohumericUpDown.TabIndex = 48;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(35, 233);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 49;
            this.label6.Text = "Creditos";
            // 
            // AcumularCreditosnumericUpDown
            // 
            this.AcumularCreditosnumericUpDown.Location = new System.Drawing.Point(86, 233);
            this.AcumularCreditosnumericUpDown.Name = "AcumularCreditosnumericUpDown";
            this.AcumularCreditosnumericUpDown.Size = new System.Drawing.Size(73, 20);
            this.AcumularCreditosnumericUpDown.TabIndex = 50;
            this.AcumularCreditosnumericUpDown.ValueChanged += new System.EventHandler(this.AcumularCreditosnumericUpDown_ValueChanged);
            // 
            // InscripcionesFormulario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 521);
            this.Controls.Add(this.AcumularCreditosnumericUpDown);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ResultadoNumerohumericUpDown);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Asignaturabutton);
            this.Controls.Add(this.AsignaturacomboBox);
            this.Controls.Add(this.EstudiantecomboBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.RemoverAlGrid);
            this.Controls.Add(this.AgregarAlGridbutton);
            this.Controls.Add(this.DetalleIdnumericUpDown);
            this.Controls.Add(this.DetalledataGridView);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Buscarbutton);
            this.Controls.Add(this.Eliminarbutton);
            this.Controls.Add(this.GuardarButton);
            this.Controls.Add(this.Nuevobutton);
            this.Controls.Add(this.FechadateTimePicker);
            this.Controls.Add(this.MontonumericUpDown);
            this.Controls.Add(this.IdnumericUpDown);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "InscripcionesFormulario";
            this.Text = "Registro de Inscripciones";
            ((System.ComponentModel.ISupportInitialize)(this.IdnumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MontonumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DetalledataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DetalleIdnumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyerrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResultadoNumerohumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AcumularCreditosnumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown IdnumericUpDown;
        private System.Windows.Forms.NumericUpDown MontonumericUpDown;
        private System.Windows.Forms.DateTimePicker FechadateTimePicker;
        private System.Windows.Forms.Button Eliminarbutton;
        private System.Windows.Forms.Button GuardarButton;
        private System.Windows.Forms.Button Nuevobutton;
        private System.Windows.Forms.Button Buscarbutton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView DetalledataGridView;
        private System.Windows.Forms.NumericUpDown DetalleIdnumericUpDown;
        private System.Windows.Forms.ErrorProvider MyerrorProvider;
        private System.Windows.Forms.Button RemoverAlGrid;
        private System.Windows.Forms.Button AgregarAlGridbutton;
        private System.Windows.Forms.ComboBox EstudiantecomboBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Asignaturabutton;
        private System.Windows.Forms.ComboBox AsignaturacomboBox;
        private System.Windows.Forms.NumericUpDown ResultadoNumerohumericUpDown;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown AcumularCreditosnumericUpDown;
        private System.Windows.Forms.Label label6;
    }
}