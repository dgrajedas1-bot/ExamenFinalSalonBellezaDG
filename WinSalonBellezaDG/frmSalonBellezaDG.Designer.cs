namespace WinSalonBellezaDG
{
    partial class frmSalonBellezaDG
    {
        /// <summary>Contenedor de componentes.</summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Libera los recursos usados.
        /// </summary>
        /// <param name="disposing">true para liberar recursos administrados.</param>
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
        /// Inicializa los controles del formulario.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlEncabezadoDG = new System.Windows.Forms.Panel();
            this.lblTituloDG = new System.Windows.Forms.Label();
            this.lblAutoraDG = new System.Windows.Forms.Label();
            this.tlpPrincipalDG = new System.Windows.Forms.TableLayoutPanel();
            this.grpDatosDG = new System.Windows.Forms.GroupBox();
            this.tlpDatosDG = new System.Windows.Forms.TableLayoutPanel();
            this.lblNombreCompletoDG = new System.Windows.Forms.Label();
            this.txtNombreCompletoDG = new System.Windows.Forms.TextBox();
            this.lblServicioUnasDG = new System.Windows.Forms.Label();
            this.nudServicioUnasDG = new System.Windows.Forms.NumericUpDown();
            this.lblHonorariosDG = new System.Windows.Forms.Label();
            this.nudHonorariosDG = new System.Windows.Forms.NumericUpDown();
            this.lblPeinadoDG = new System.Windows.Forms.Label();
            this.nudPeinadoDG = new System.Windows.Forms.NumericUpDown();
            this.lblAplicacionTinteDG = new System.Windows.Forms.Label();
            this.nudAplicacionTinteDG = new System.Windows.Forms.NumericUpDown();
            this.lblBasesDG = new System.Windows.Forms.Label();
            this.nudBasesDG = new System.Windows.Forms.NumericUpDown();
            this.lblOtrosDG = new System.Windows.Forms.Label();
            this.nudOtrosDG = new System.Windows.Forms.NumericUpDown();
            this.flpBotonesDG = new System.Windows.Forms.FlowLayoutPanel();
            this.btnCalcularCuentaDG = new System.Windows.Forms.Button();
            this.btnLimpiarDG = new System.Windows.Forms.Button();
            this.pnlResultadoDG = new System.Windows.Forms.Panel();
            this.lblCuentaTituloDG = new System.Windows.Forms.Label();
            this.lblTotalServiciosDG = new System.Windows.Forms.Label();
            this.lblTotalServiciosValorDG = new System.Windows.Forms.Label();
            this.lblTotalOtrosDG = new System.Windows.Forms.Label();
            this.lblTotalOtrosValorDG = new System.Windows.Forms.Label();
            this.lblSuCuentaDG = new System.Windows.Forms.Label();
            this.lblSuCuentaValorDG = new System.Windows.Forms.Label();
            this.grpHistorialDG = new System.Windows.Forms.GroupBox();
            this.dgvHistorialDG = new System.Windows.Forms.DataGridView();
            this.btnActualizarDG = new System.Windows.Forms.Button();
            this.lblEstadoDG = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorialDG)).BeginInit();
            this.SuspendLayout();
            //
            // pnlEncabezadoDG
            //
            this.pnlEncabezadoDG.BackColor = System.Drawing.Color.FromArgb(214, 51, 132);
            this.pnlEncabezadoDG.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlEncabezadoDG.Height = 78;
            this.pnlEncabezadoDG.Padding = new System.Windows.Forms.Padding(18, 10, 18, 8);
            this.lblTituloDG.Text = "Salón de Belleza · Cuenta del cliente";
            this.lblTituloDG.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Bold);
            this.lblTituloDG.ForeColor = System.Drawing.Color.White;
            this.lblTituloDG.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTituloDG.Height = 38;
            this.lblAutoraDG.Text = "Daniela Paola Grajeda Sandoval  ·  Carné 0900-25-15929  ·  Sección A  ·  Programación II";
            this.lblAutoraDG.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblAutoraDG.ForeColor = System.Drawing.Color.FromArgb(255, 228, 240);
            this.lblAutoraDG.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlEncabezadoDG.Controls.Add(this.lblAutoraDG);
            this.pnlEncabezadoDG.Controls.Add(this.lblTituloDG);
            //
            // tlpPrincipalDG
            //
            this.tlpPrincipalDG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpPrincipalDG.Padding = new System.Windows.Forms.Padding(12);
            this.tlpPrincipalDG.ColumnCount = 2;
            this.tlpPrincipalDG.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52F));
            this.tlpPrincipalDG.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48F));
            this.tlpPrincipalDG.RowCount = 2;
            this.tlpPrincipalDG.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 340F));
            this.tlpPrincipalDG.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            //
            // grpDatosDG
            //
            this.grpDatosDG.Text = "Datos del cliente";
            this.grpDatosDG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpDatosDG.ForeColor = System.Drawing.Color.FromArgb(74, 20, 50);
            this.grpDatosDG.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpDatosDG.Padding = new System.Windows.Forms.Padding(10);
            this.tlpDatosDG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpDatosDG.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tlpDatosDG.ColumnCount = 2;
            this.tlpDatosDG.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 165F));
            this.tlpDatosDG.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpDatosDG.RowCount = 8;
            this.tlpDatosDG.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tlpDatosDG.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tlpDatosDG.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tlpDatosDG.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tlpDatosDG.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tlpDatosDG.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tlpDatosDG.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tlpDatosDG.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.lblNombreCompletoDG.Text = "Nombre completo:";
            this.lblNombreCompletoDG.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblNombreCompletoDG.AutoSize = true;
            this.txtNombreCompletoDG.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.txtNombreCompletoDG.MaxLength = 150;
            this.txtNombreCompletoDG.Name = "txtNombreCompletoDG";
            this.txtNombreCompletoDG.TabIndex = 1;
            this.tlpDatosDG.Controls.Add(this.lblNombreCompletoDG, 0, 0);
            this.tlpDatosDG.Controls.Add(this.txtNombreCompletoDG, 1, 0);
            this.lblServicioUnasDG.Text = "Servicio de uñas:";
            this.lblServicioUnasDG.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblServicioUnasDG.AutoSize = true;
            this.nudServicioUnasDG.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.nudServicioUnasDG.DecimalPlaces = 2;
            this.nudServicioUnasDG.Maximum = new decimal(new int[] { 999999999, 0, 0, 131072 });
            this.nudServicioUnasDG.ThousandsSeparator = true;
            this.nudServicioUnasDG.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudServicioUnasDG.Name = "nudServicioUnasDG";
            this.nudServicioUnasDG.TabIndex = 2;
            this.tlpDatosDG.Controls.Add(this.lblServicioUnasDG, 0, 1);
            this.tlpDatosDG.Controls.Add(this.nudServicioUnasDG, 1, 1);
            this.lblHonorariosDG.Text = "Honorarios:";
            this.lblHonorariosDG.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblHonorariosDG.AutoSize = true;
            this.nudHonorariosDG.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.nudHonorariosDG.DecimalPlaces = 2;
            this.nudHonorariosDG.Maximum = new decimal(new int[] { 999999999, 0, 0, 131072 });
            this.nudHonorariosDG.ThousandsSeparator = true;
            this.nudHonorariosDG.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudHonorariosDG.Name = "nudHonorariosDG";
            this.nudHonorariosDG.TabIndex = 3;
            this.tlpDatosDG.Controls.Add(this.lblHonorariosDG, 0, 2);
            this.tlpDatosDG.Controls.Add(this.nudHonorariosDG, 1, 2);
            this.lblPeinadoDG.Text = "Peinado:";
            this.lblPeinadoDG.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblPeinadoDG.AutoSize = true;
            this.nudPeinadoDG.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.nudPeinadoDG.DecimalPlaces = 2;
            this.nudPeinadoDG.Maximum = new decimal(new int[] { 999999999, 0, 0, 131072 });
            this.nudPeinadoDG.ThousandsSeparator = true;
            this.nudPeinadoDG.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudPeinadoDG.Name = "nudPeinadoDG";
            this.nudPeinadoDG.TabIndex = 4;
            this.tlpDatosDG.Controls.Add(this.lblPeinadoDG, 0, 3);
            this.tlpDatosDG.Controls.Add(this.nudPeinadoDG, 1, 3);
            this.lblAplicacionTinteDG.Text = "Aplicación de tinte:";
            this.lblAplicacionTinteDG.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblAplicacionTinteDG.AutoSize = true;
            this.nudAplicacionTinteDG.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.nudAplicacionTinteDG.DecimalPlaces = 2;
            this.nudAplicacionTinteDG.Maximum = new decimal(new int[] { 999999999, 0, 0, 131072 });
            this.nudAplicacionTinteDG.ThousandsSeparator = true;
            this.nudAplicacionTinteDG.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudAplicacionTinteDG.Name = "nudAplicacionTinteDG";
            this.nudAplicacionTinteDG.TabIndex = 5;
            this.tlpDatosDG.Controls.Add(this.lblAplicacionTinteDG, 0, 4);
            this.tlpDatosDG.Controls.Add(this.nudAplicacionTinteDG, 1, 4);
            this.lblBasesDG.Text = "Bases:";
            this.lblBasesDG.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblBasesDG.AutoSize = true;
            this.nudBasesDG.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.nudBasesDG.DecimalPlaces = 2;
            this.nudBasesDG.Maximum = new decimal(new int[] { 999999999, 0, 0, 131072 });
            this.nudBasesDG.ThousandsSeparator = true;
            this.nudBasesDG.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudBasesDG.Name = "nudBasesDG";
            this.nudBasesDG.TabIndex = 6;
            this.tlpDatosDG.Controls.Add(this.lblBasesDG, 0, 5);
            this.tlpDatosDG.Controls.Add(this.nudBasesDG, 1, 5);
            this.lblOtrosDG.Text = "Otros:";
            this.lblOtrosDG.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblOtrosDG.AutoSize = true;
            this.nudOtrosDG.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.nudOtrosDG.DecimalPlaces = 2;
            this.nudOtrosDG.Maximum = new decimal(new int[] { 999999999, 0, 0, 131072 });
            this.nudOtrosDG.ThousandsSeparator = true;
            this.nudOtrosDG.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudOtrosDG.Name = "nudOtrosDG";
            this.nudOtrosDG.TabIndex = 7;
            this.tlpDatosDG.Controls.Add(this.lblOtrosDG, 0, 6);
            this.tlpDatosDG.Controls.Add(this.nudOtrosDG, 1, 6);
            //
            // botones
            //
            this.flpBotonesDG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpBotonesDG.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flpBotonesDG.Padding = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.btnCalcularCuentaDG.Text = "Calcular Cuenta";
            this.btnCalcularCuentaDG.Name = "btnCalcularCuentaDG";
            this.btnCalcularCuentaDG.BackColor = System.Drawing.Color.FromArgb(214, 51, 132);
            this.btnCalcularCuentaDG.ForeColor = System.Drawing.Color.White;
            this.btnCalcularCuentaDG.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalcularCuentaDG.FlatAppearance.BorderSize = 0;
            this.btnCalcularCuentaDG.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnCalcularCuentaDG.Size = new System.Drawing.Size(160, 38);
            this.btnCalcularCuentaDG.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCalcularCuentaDG.TabIndex = 8;
            this.btnCalcularCuentaDG.Click += new System.EventHandler(this.btnCalcularCuentaDG_Click);
            this.btnLimpiarDG.Text = "Limpiar";
            this.btnLimpiarDG.Name = "btnLimpiarDG";
            this.btnLimpiarDG.BackColor = System.Drawing.Color.White;
            this.btnLimpiarDG.ForeColor = System.Drawing.Color.FromArgb(214, 51, 132);
            this.btnLimpiarDG.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiarDG.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(214, 51, 132);
            this.btnLimpiarDG.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnLimpiarDG.Size = new System.Drawing.Size(110, 38);
            this.btnLimpiarDG.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiarDG.TabIndex = 9;
            this.btnLimpiarDG.Click += new System.EventHandler(this.btnLimpiarDG_Click);
            this.flpBotonesDG.Controls.Add(this.btnCalcularCuentaDG);
            this.flpBotonesDG.Controls.Add(this.btnLimpiarDG);
            this.tlpDatosDG.Controls.Add(this.flpBotonesDG, 0, 7);
            this.tlpDatosDG.SetColumnSpan(this.flpBotonesDG, 2);
            this.grpDatosDG.Controls.Add(this.tlpDatosDG);
            //
            // pnlResultadoDG
            //
            this.pnlResultadoDG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlResultadoDG.BackColor = System.Drawing.Color.White;
            this.pnlResultadoDG.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlResultadoDG.Margin = new System.Windows.Forms.Padding(10, 8, 3, 3);
            this.pnlResultadoDG.Padding = new System.Windows.Forms.Padding(18);
            this.lblCuentaTituloDG.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblCuentaTituloDG.Height = 60;
            this.lblCuentaTituloDG.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblCuentaTituloDG.ForeColor = System.Drawing.Color.FromArgb(214, 51, 132);
            this.lblCuentaTituloDG.Location = new System.Drawing.Point(18, 18);
            this.lblTotalServiciosDG.Text = "Total Servicios:";
            this.lblTotalServiciosDG.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblTotalServiciosDG.ForeColor = System.Drawing.Color.FromArgb(74, 20, 50);
            this.lblTotalServiciosDG.Location = new System.Drawing.Point(20, 95);
            this.lblTotalServiciosDG.AutoSize = true;
            this.lblTotalServiciosValorDG.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold);
            this.lblTotalServiciosValorDG.ForeColor = System.Drawing.Color.FromArgb(74, 20, 50);
            this.lblTotalServiciosValorDG.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblTotalServiciosValorDG.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            this.lblTotalServiciosValorDG.Bounds = new System.Drawing.Rectangle(160, 92, 180, 26);
            this.lblTotalOtrosDG.Text = "Total Otros:";
            this.lblTotalOtrosDG.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblTotalOtrosDG.ForeColor = System.Drawing.Color.FromArgb(74, 20, 50);
            this.lblTotalOtrosDG.Location = new System.Drawing.Point(20, 135);
            this.lblTotalOtrosDG.AutoSize = true;
            this.lblTotalOtrosValorDG.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold);
            this.lblTotalOtrosValorDG.ForeColor = System.Drawing.Color.FromArgb(74, 20, 50);
            this.lblTotalOtrosValorDG.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblTotalOtrosValorDG.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            this.lblTotalOtrosValorDG.Bounds = new System.Drawing.Rectangle(160, 132, 180, 26);
            this.lblSuCuentaDG.Text = "SU CUENTA ES:";
            this.lblSuCuentaDG.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblSuCuentaDG.ForeColor = System.Drawing.Color.White;
            this.lblSuCuentaDG.BackColor = System.Drawing.Color.FromArgb(214, 51, 132);
            this.lblSuCuentaDG.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblSuCuentaDG.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.lblSuCuentaDG.Bounds = new System.Drawing.Rectangle(18, 185, 322, 48);
            this.lblSuCuentaDG.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.lblSuCuentaValorDG.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Bold);
            this.lblSuCuentaValorDG.ForeColor = System.Drawing.Color.White;
            this.lblSuCuentaValorDG.BackColor = System.Drawing.Color.FromArgb(214, 51, 132);
            this.lblSuCuentaValorDG.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblSuCuentaValorDG.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            this.lblSuCuentaValorDG.Bounds = new System.Drawing.Rectangle(160, 190, 175, 38);
            this.pnlResultadoDG.Controls.Add(this.lblSuCuentaValorDG);
            this.pnlResultadoDG.Controls.Add(this.lblSuCuentaDG);
            this.pnlResultadoDG.Controls.Add(this.lblTotalOtrosValorDG);
            this.pnlResultadoDG.Controls.Add(this.lblTotalOtrosDG);
            this.pnlResultadoDG.Controls.Add(this.lblTotalServiciosValorDG);
            this.pnlResultadoDG.Controls.Add(this.lblTotalServiciosDG);
            this.pnlResultadoDG.Controls.Add(this.lblCuentaTituloDG);
            //
            // grpHistorialDG
            //
            this.grpHistorialDG.Text = "Historial de cuentas (base de datos)";
            this.grpHistorialDG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpHistorialDG.ForeColor = System.Drawing.Color.FromArgb(74, 20, 50);
            this.grpHistorialDG.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpHistorialDG.Padding = new System.Windows.Forms.Padding(10);
            this.dgvHistorialDG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvHistorialDG.ReadOnly = true;
            this.dgvHistorialDG.AllowUserToAddRows = false;
            this.dgvHistorialDG.AllowUserToDeleteRows = false;
            this.dgvHistorialDG.RowHeadersVisible = false;
            this.dgvHistorialDG.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHistorialDG.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHistorialDG.BackgroundColor = System.Drawing.Color.White;
            this.dgvHistorialDG.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvHistorialDG.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.dgvHistorialDG.EnableHeadersVisualStyles = false;
            this.dgvHistorialDG.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(252, 214, 231);
            this.dgvHistorialDG.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(74, 20, 50);
            this.dgvHistorialDG.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(255, 240, 246);
            this.dgvHistorialDG.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(214, 51, 132);
            this.btnActualizarDG.Text = "Actualizar historial";
            this.btnActualizarDG.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnActualizarDG.Height = 32;
            this.btnActualizarDG.BackColor = System.Drawing.Color.FromArgb(252, 214, 231);
            this.btnActualizarDG.ForeColor = System.Drawing.Color.FromArgb(74, 20, 50);
            this.btnActualizarDG.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizarDG.FlatAppearance.BorderSize = 0;
            this.btnActualizarDG.Click += new System.EventHandler(this.btnActualizarDG_Click);
            this.grpHistorialDG.Controls.Add(this.dgvHistorialDG);
            this.grpHistorialDG.Controls.Add(this.btnActualizarDG);
            this.tlpPrincipalDG.Controls.Add(this.grpDatosDG, 0, 0);
            this.tlpPrincipalDG.Controls.Add(this.pnlResultadoDG, 1, 0);
            this.tlpPrincipalDG.Controls.Add(this.grpHistorialDG, 0, 1);
            this.tlpPrincipalDG.SetColumnSpan(this.grpHistorialDG, 2);
            //
            // lblEstadoDG
            //
            this.lblEstadoDG.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblEstadoDG.Height = 24;
            this.lblEstadoDG.BackColor = System.Drawing.Color.FromArgb(252, 214, 231);
            this.lblEstadoDG.ForeColor = System.Drawing.Color.FromArgb(74, 20, 50);
            this.lblEstadoDG.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.lblEstadoDG.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            //
            // frmSalonBellezaDG
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(255, 240, 246);
            this.ClientSize = new System.Drawing.Size(900, 680);
            this.MinimumSize = new System.Drawing.Size(860, 640);
            this.Controls.Add(this.tlpPrincipalDG);
            this.Controls.Add(this.lblEstadoDG);
            this.Controls.Add(this.pnlEncabezadoDG);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Name = "frmSalonBellezaDG";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Salón de Belleza - Daniela Grajeda";
            this.AcceptButton = this.btnCalcularCuentaDG;
            this.Load += new System.EventHandler(this.frmSalonBellezaDG_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorialDG)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        /// <summary>Encabezado rosa.</summary>
        private System.Windows.Forms.Panel pnlEncabezadoDG;

        /// <summary>Título.</summary>
        private System.Windows.Forms.Label lblTituloDG;

        /// <summary>Datos de la autora.</summary>
        private System.Windows.Forms.Label lblAutoraDG;

        /// <summary>Distribución principal.</summary>
        private System.Windows.Forms.TableLayoutPanel tlpPrincipalDG;

        /// <summary>Grupo de datos del cliente.</summary>
        private System.Windows.Forms.GroupBox grpDatosDG;

        /// <summary>Distribución de los campos.</summary>
        private System.Windows.Forms.TableLayoutPanel tlpDatosDG;

        /// <summary>Etiqueta nombre.</summary>
        private System.Windows.Forms.Label lblNombreCompletoDG;

        /// <summary>Nombre completo del cliente.</summary>
        private System.Windows.Forms.TextBox txtNombreCompletoDG;

        /// <summary>Etiqueta Servicio de uñas.</summary>
        private System.Windows.Forms.Label lblServicioUnasDG;

        /// <summary>Importe Servicio de uñas.</summary>
        private System.Windows.Forms.NumericUpDown nudServicioUnasDG;

        /// <summary>Etiqueta Honorarios.</summary>
        private System.Windows.Forms.Label lblHonorariosDG;

        /// <summary>Importe Honorarios.</summary>
        private System.Windows.Forms.NumericUpDown nudHonorariosDG;

        /// <summary>Etiqueta Peinado.</summary>
        private System.Windows.Forms.Label lblPeinadoDG;

        /// <summary>Importe Peinado.</summary>
        private System.Windows.Forms.NumericUpDown nudPeinadoDG;

        /// <summary>Etiqueta Aplicación de tinte.</summary>
        private System.Windows.Forms.Label lblAplicacionTinteDG;

        /// <summary>Importe Aplicación de tinte.</summary>
        private System.Windows.Forms.NumericUpDown nudAplicacionTinteDG;

        /// <summary>Etiqueta Bases.</summary>
        private System.Windows.Forms.Label lblBasesDG;

        /// <summary>Importe Bases.</summary>
        private System.Windows.Forms.NumericUpDown nudBasesDG;

        /// <summary>Etiqueta Otros.</summary>
        private System.Windows.Forms.Label lblOtrosDG;

        /// <summary>Importe Otros.</summary>
        private System.Windows.Forms.NumericUpDown nudOtrosDG;

        /// <summary>Contenedor de botones.</summary>
        private System.Windows.Forms.FlowLayoutPanel flpBotonesDG;

        /// <summary>Botón Calcular Cuenta.</summary>
        private System.Windows.Forms.Button btnCalcularCuentaDG;

        /// <summary>Botón Limpiar.</summary>
        private System.Windows.Forms.Button btnLimpiarDG;

        /// <summary>Panel de la cuenta.</summary>
        private System.Windows.Forms.Panel pnlResultadoDG;

        /// <summary>Título CUENTA [nombre].</summary>
        private System.Windows.Forms.Label lblCuentaTituloDG;

        /// <summary>Etiqueta Total Servicios.</summary>
        private System.Windows.Forms.Label lblTotalServiciosDG;

        /// <summary>Valor Total Servicios.</summary>
        private System.Windows.Forms.Label lblTotalServiciosValorDG;

        /// <summary>Etiqueta Total Otros.</summary>
        private System.Windows.Forms.Label lblTotalOtrosDG;

        /// <summary>Valor Total Otros.</summary>
        private System.Windows.Forms.Label lblTotalOtrosValorDG;

        /// <summary>Etiqueta SU CUENTA ES.</summary>
        private System.Windows.Forms.Label lblSuCuentaDG;

        /// <summary>Valor SU CUENTA ES.</summary>
        private System.Windows.Forms.Label lblSuCuentaValorDG;

        /// <summary>Grupo del historial.</summary>
        private System.Windows.Forms.GroupBox grpHistorialDG;

        /// <summary>Historial de cuentas.</summary>
        private System.Windows.Forms.DataGridView dgvHistorialDG;

        /// <summary>Botón Actualizar historial.</summary>
        private System.Windows.Forms.Button btnActualizarDG;

        /// <summary>Estado de la conexión.</summary>
        private System.Windows.Forms.Label lblEstadoDG;
    }
}
