namespace PaymentsUI
{
    partial class frmPayments
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
            this.dgPayments = new System.Windows.Forms.DataGridView();
            this.gpoPayments = new System.Windows.Forms.GroupBox();
            this.gpoOpciones = new System.Windows.Forms.GroupBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lblTituloPaymentOpciones = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.gpoAddPayments = new System.Windows.Forms.GroupBox();
            this.lblAmount = new System.Windows.Forms.Label();
            this.numAmount = new System.Windows.Forms.NumericUpDown();
            this.dtDate = new System.Windows.Forms.DateTimePicker();
            this.lblPaymentId = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtConcepto = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.lblPaymentAction = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgPayments)).BeginInit();
            this.gpoPayments.SuspendLayout();
            this.gpoOpciones.SuspendLayout();
            this.gpoAddPayments.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // dgPayments
            // 
            this.dgPayments.AllowUserToAddRows = false;
            this.dgPayments.AllowUserToDeleteRows = false;
            this.dgPayments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPayments.Location = new System.Drawing.Point(11, 24);
            this.dgPayments.Name = "dgPayments";
            this.dgPayments.ReadOnly = true;
            this.dgPayments.Size = new System.Drawing.Size(550, 290);
            this.dgPayments.TabIndex = 1;
            this.dgPayments.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgPayments_CellClick);
            // 
            // gpoPayments
            // 
            this.gpoPayments.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gpoPayments.Controls.Add(this.dgPayments);
            this.gpoPayments.Location = new System.Drawing.Point(13, 13);
            this.gpoPayments.Name = "gpoPayments";
            this.gpoPayments.Size = new System.Drawing.Size(574, 324);
            this.gpoPayments.TabIndex = 0;
            this.gpoPayments.TabStop = false;
            this.gpoPayments.Text = "Lista de Tiendas";
            // 
            // gpoOpciones
            // 
            this.gpoOpciones.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gpoOpciones.Controls.Add(this.btnSalir);
            this.gpoOpciones.Controls.Add(this.lblTituloPaymentOpciones);
            this.gpoOpciones.Controls.Add(this.btnAgregar);
            this.gpoOpciones.Location = new System.Drawing.Point(609, 13);
            this.gpoOpciones.Name = "gpoOpciones";
            this.gpoOpciones.Size = new System.Drawing.Size(200, 321);
            this.gpoOpciones.TabIndex = 0;
            this.gpoOpciones.TabStop = false;
            this.gpoOpciones.Text = "gpoOpciones";
            // 
            // btnSalir
            // 
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Location = new System.Drawing.Point(67, 244);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 1;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lblTituloPaymentOpciones
            // 
            this.lblTituloPaymentOpciones.AutoSize = true;
            this.lblTituloPaymentOpciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTituloPaymentOpciones.Location = new System.Drawing.Point(35, 20);
            this.lblTituloPaymentOpciones.Name = "lblTituloPaymentOpciones";
            this.lblTituloPaymentOpciones.Size = new System.Drawing.Size(150, 20);
            this.lblTituloPaymentOpciones.TabIndex = 1;
            this.lblTituloPaymentOpciones.Text = "Opciones Payments";
            // 
            // btnAgregar
            // 
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Location = new System.Drawing.Point(67, 56);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 25);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // gpoAddPayments
            // 
            this.gpoAddPayments.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gpoAddPayments.Controls.Add(this.lblAmount);
            this.gpoAddPayments.Controls.Add(this.numAmount);
            this.gpoAddPayments.Controls.Add(this.dtDate);
            this.gpoAddPayments.Controls.Add(this.lblPaymentId);
            this.gpoAddPayments.Controls.Add(this.lblFecha);
            this.gpoAddPayments.Controls.Add(this.lblName);
            this.gpoAddPayments.Controls.Add(this.txtConcepto);
            this.gpoAddPayments.Controls.Add(this.btnGuardar);
            this.gpoAddPayments.Controls.Add(this.lblPaymentAction);
            this.gpoAddPayments.Controls.Add(this.btnCancelar);
            this.gpoAddPayments.Location = new System.Drawing.Point(608, 16);
            this.gpoAddPayments.Name = "gpoAddPayments";
            this.gpoAddPayments.Size = new System.Drawing.Size(200, 321);
            this.gpoAddPayments.TabIndex = 0;
            this.gpoAddPayments.TabStop = false;
            this.gpoAddPayments.Text = "Agregar Store";
            this.gpoAddPayments.Visible = false;
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(40, 111);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(43, 15);
            this.lblAmount.TabIndex = 8;
            this.lblAmount.Text = "Monto";
            // 
            // numAmount
            // 
            this.numAmount.Location = new System.Drawing.Point(39, 132);
            this.numAmount.Name = "numAmount";
            this.numAmount.Size = new System.Drawing.Size(100, 23);
            this.numAmount.TabIndex = 1;
            this.numAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // dtDate
            // 
            this.dtDate.CustomFormat = "dd/MM/yyyy";
            this.dtDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtDate.Location = new System.Drawing.Point(39, 189);
            this.dtDate.MaxDate = new System.DateTime(2050, 12, 31, 0, 0, 0, 0);
            this.dtDate.MinDate = new System.DateTime(2019, 1, 1, 0, 0, 0, 0);
            this.dtDate.Name = "dtDate";
            this.dtDate.Size = new System.Drawing.Size(100, 23);
            this.dtDate.TabIndex = 2;
            this.dtDate.Value = new System.DateTime(2020, 7, 31, 14, 6, 44, 0);
            // 
            // lblPaymentId
            // 
            this.lblPaymentId.AutoSize = true;
            this.lblPaymentId.Location = new System.Drawing.Point(23, 222);
            this.lblPaymentId.Name = "lblPaymentId";
            this.lblPaymentId.Size = new System.Drawing.Size(77, 15);
            this.lblPaymentId.TabIndex = 7;
            this.lblPaymentId.Text = "lblPaymentId";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(40, 167);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(38, 15);
            this.lblFecha.TabIndex = 6;
            this.lblFecha.Text = "Fecha";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(40, 53);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(54, 15);
            this.lblName.TabIndex = 5;
            this.lblName.Text = " Nombre";
            // 
            // txtConcepto
            // 
            this.txtConcepto.Location = new System.Drawing.Point(40, 75);
            this.txtConcepto.Name = "txtConcepto";
            this.txtConcepto.Size = new System.Drawing.Size(100, 23);
            this.txtConcepto.TabIndex = 0;
            // 
            // btnGuardar
            // 
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Location = new System.Drawing.Point(23, 241);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 4;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // lblPaymentAction
            // 
            this.lblPaymentAction.AutoSize = true;
            this.lblPaymentAction.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPaymentAction.Location = new System.Drawing.Point(35, 20);
            this.lblPaymentAction.Name = "lblPaymentAction";
            this.lblPaymentAction.Size = new System.Drawing.Size(107, 20);
            this.lblPaymentAction.TabIndex = 1;
            this.lblPaymentAction.Text = "Agregar Pago";
            // 
            // btnCancelar
            // 
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Location = new System.Drawing.Point(113, 241);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // frmPayments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 369);
            this.Controls.Add(this.gpoAddPayments);
            this.Controls.Add(this.gpoOpciones);
            this.Controls.Add(this.gpoPayments);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmPayments";
            this.Text = "Payments";
            ((System.ComponentModel.ISupportInitialize)(this.dgPayments)).EndInit();
            this.gpoPayments.ResumeLayout(false);
            this.gpoOpciones.ResumeLayout(false);
            this.gpoOpciones.PerformLayout();
            this.gpoAddPayments.ResumeLayout(false);
            this.gpoAddPayments.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAmount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        
        private System.Windows.Forms.DataGridView dgPayments;
        private System.Windows.Forms.GroupBox gpoPayments;
        private System.Windows.Forms.GroupBox gpoOpciones;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label lblTituloPaymentOpciones;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.GroupBox gpoAddPayments;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label lblPaymentAction;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblPaymentId;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtConcepto;
        private System.Windows.Forms.DateTimePicker dtDate;
        private System.Windows.Forms.NumericUpDown numAmount;
        private System.Windows.Forms.Label lblAmount;

    }
}

