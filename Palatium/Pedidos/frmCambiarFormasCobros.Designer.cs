﻿namespace Palatium.Pedidos
{
    partial class frmCambiarFormasCobros
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle111 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle112 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle109 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle110 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle116 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle117 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle113 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle114 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle115 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.dgvDetalleDeuda = new System.Windows.Forms.DataGridView();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valor_detalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvPagos = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fpago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_sri = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlFormasCobros = new System.Windows.Forms.Panel();
            this.btnGrabarPagos = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnRemoverPago = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleDeuda)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPagos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnSiguiente.Image = global::Palatium.Properties.Resources.derecha;
            this.btnSiguiente.Location = new System.Drawing.Point(162, 441);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(153, 71);
            this.btnSiguiente.TabIndex = 149;
            this.btnSiguiente.UseVisualStyleBackColor = false;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // btnAnterior
            // 
            this.btnAnterior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnAnterior.Enabled = false;
            this.btnAnterior.Image = global::Palatium.Properties.Resources.izquierda;
            this.btnAnterior.Location = new System.Drawing.Point(9, 441);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(153, 71);
            this.btnAnterior.TabIndex = 148;
            this.btnAnterior.UseVisualStyleBackColor = false;
            this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
            // 
            // dgvDetalleDeuda
            // 
            this.dgvDetalleDeuda.AllowUserToAddRows = false;
            this.dgvDetalleDeuda.AllowUserToDeleteRows = false;
            this.dgvDetalleDeuda.AllowUserToResizeColumns = false;
            this.dgvDetalleDeuda.AllowUserToResizeRows = false;
            this.dgvDetalleDeuda.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvDetalleDeuda.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvDetalleDeuda.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvDetalleDeuda.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvDetalleDeuda.ColumnHeadersHeight = 30;
            this.dgvDetalleDeuda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvDetalleDeuda.ColumnHeadersVisible = false;
            this.dgvDetalleDeuda.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.descripcion,
            this.valor_detalle});
            dataGridViewCellStyle111.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle111.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle111.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle111.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle111.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle111.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle111.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDetalleDeuda.DefaultCellStyle = dataGridViewCellStyle111;
            this.dgvDetalleDeuda.EnableHeadersVisualStyles = false;
            this.dgvDetalleDeuda.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dgvDetalleDeuda.Location = new System.Drawing.Point(368, 321);
            this.dgvDetalleDeuda.MultiSelect = false;
            this.dgvDetalleDeuda.Name = "dgvDetalleDeuda";
            this.dgvDetalleDeuda.ReadOnly = true;
            this.dgvDetalleDeuda.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvDetalleDeuda.RowHeadersVisible = false;
            dataGridViewCellStyle112.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDetalleDeuda.RowsDefaultCellStyle = dataGridViewCellStyle112;
            this.dgvDetalleDeuda.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDetalleDeuda.Size = new System.Drawing.Size(390, 118);
            this.dgvDetalleDeuda.TabIndex = 155;
            // 
            // descripcion
            // 
            this.descripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle109.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle109.Font = new System.Drawing.Font("Maiandra GD", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descripcion.DefaultCellStyle = dataGridViewCellStyle109;
            this.descripcion.FillWeight = 168.8291F;
            this.descripcion.HeaderText = "DESCRIPCIÓN";
            this.descripcion.Name = "descripcion";
            this.descripcion.ReadOnly = true;
            // 
            // valor_detalle
            // 
            dataGridViewCellStyle110.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle110.Font = new System.Drawing.Font("Maiandra GD", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valor_detalle.DefaultCellStyle = dataGridViewCellStyle110;
            this.valor_detalle.FillWeight = 70.25717F;
            this.valor_detalle.HeaderText = "VALOR";
            this.valor_detalle.Name = "valor_detalle";
            this.valor_detalle.ReadOnly = true;
            this.valor_detalle.Width = 62;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Controls.Add(this.lblTotal);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(304, 69);
            this.panel2.TabIndex = 154;
            // 
            // lblTotal
            // 
            this.lblTotal.Font = new System.Drawing.Font("Maiandra GD", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.Lime;
            this.lblTotal.Location = new System.Drawing.Point(150, 20);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(142, 31);
            this.lblTotal.TabIndex = 25;
            this.lblTotal.Text = "$ 0.00";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Maiandra GD", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Lime;
            this.label3.Location = new System.Drawing.Point(14, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 29);
            this.label3.TabIndex = 22;
            this.label3.Text = "TOTAL:";
            // 
            // dgvPagos
            // 
            this.dgvPagos.AllowUserToAddRows = false;
            this.dgvPagos.AllowUserToDeleteRows = false;
            this.dgvPagos.AllowUserToResizeColumns = false;
            this.dgvPagos.AllowUserToResizeRows = false;
            this.dgvPagos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvPagos.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvPagos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvPagos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvPagos.ColumnHeadersHeight = 30;
            this.dgvPagos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvPagos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.fpago,
            this.valor,
            this.id_sri});
            dataGridViewCellStyle116.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle116.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle116.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle116.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle116.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle116.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle116.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPagos.DefaultCellStyle = dataGridViewCellStyle116;
            this.dgvPagos.EnableHeadersVisualStyles = false;
            this.dgvPagos.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dgvPagos.Location = new System.Drawing.Point(368, 12);
            this.dgvPagos.MultiSelect = false;
            this.dgvPagos.Name = "dgvPagos";
            this.dgvPagos.ReadOnly = true;
            this.dgvPagos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvPagos.RowHeadersVisible = false;
            dataGridViewCellStyle117.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPagos.RowsDefaultCellStyle = dataGridViewCellStyle117;
            this.dgvPagos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPagos.Size = new System.Drawing.Size(390, 280);
            this.dgvPagos.TabIndex = 150;
            // 
            // ID
            // 
            dataGridViewCellStyle113.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle113.Font = new System.Drawing.Font("Maiandra GD", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID.DefaultCellStyle = dataGridViewCellStyle113;
            this.ID.FillWeight = 60.9137F;
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 53;
            // 
            // fpago
            // 
            this.fpago.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle114.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle114.Font = new System.Drawing.Font("Maiandra GD", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fpago.DefaultCellStyle = dataGridViewCellStyle114;
            this.fpago.FillWeight = 168.8291F;
            this.fpago.HeaderText = "FORMA DE PAGO";
            this.fpago.Name = "fpago";
            this.fpago.ReadOnly = true;
            // 
            // valor
            // 
            dataGridViewCellStyle115.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle115.Font = new System.Drawing.Font("Maiandra GD", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valor.DefaultCellStyle = dataGridViewCellStyle115;
            this.valor.FillWeight = 70.25717F;
            this.valor.HeaderText = "VALOR";
            this.valor.Name = "valor";
            this.valor.ReadOnly = true;
            this.valor.Width = 62;
            // 
            // id_sri
            // 
            this.id_sri.HeaderText = "ID_SRI";
            this.id_sri.Name = "id_sri";
            this.id_sri.ReadOnly = true;
            this.id_sri.Visible = false;
            // 
            // pnlFormasCobros
            // 
            this.pnlFormasCobros.Location = new System.Drawing.Point(9, 87);
            this.pnlFormasCobros.Name = "pnlFormasCobros";
            this.pnlFormasCobros.Size = new System.Drawing.Size(307, 352);
            this.pnlFormasCobros.TabIndex = 147;
            // 
            // btnGrabarPagos
            // 
            this.btnGrabarPagos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnGrabarPagos.Font = new System.Drawing.Font("Maiandra GD", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGrabarPagos.Location = new System.Drawing.Point(504, 441);
            this.btnGrabarPagos.Name = "btnGrabarPagos";
            this.btnGrabarPagos.Size = new System.Drawing.Size(121, 71);
            this.btnGrabarPagos.TabIndex = 156;
            this.btnGrabarPagos.Text = "GRABAR LAS FORMAS DE PAGO";
            this.btnGrabarPagos.UseVisualStyleBackColor = false;
            this.btnGrabarPagos.Click += new System.EventHandler(this.btnGrabarPagos_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnSalir.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Bold);
            this.btnSalir.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnSalir.Location = new System.Drawing.Point(637, 439);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(121, 71);
            this.btnSalir.TabIndex = 157;
            this.btnSalir.Text = "SALIR DE COBROS";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnRemoverPago
            // 
            this.btnRemoverPago.AccessibleDescription = "";
            this.btnRemoverPago.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnRemoverPago.Font = new System.Drawing.Font("Maiandra GD", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoverPago.Location = new System.Drawing.Point(368, 441);
            this.btnRemoverPago.Name = "btnRemoverPago";
            this.btnRemoverPago.Size = new System.Drawing.Size(121, 71);
            this.btnRemoverPago.TabIndex = 158;
            this.btnRemoverPago.Text = "REMOVER EL PAGO";
            this.btnRemoverPago.UseVisualStyleBackColor = false;
            this.btnRemoverPago.Click += new System.EventHandler(this.btnRemoverPago_Click);
            // 
            // frmCambiarFormasCobros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(766, 519);
            this.Controls.Add(this.btnRemoverPago);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnGrabarPagos);
            this.Controls.Add(this.btnSiguiente);
            this.Controls.Add(this.btnAnterior);
            this.Controls.Add(this.dgvDetalleDeuda);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dgvPagos);
            this.Controls.Add(this.pnlFormasCobros);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCambiarFormasCobros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Módulo par Cambiar las Formas de Cobros";
            this.Load += new System.EventHandler(this.frmCambiarFormasCobros_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleDeuda)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPagos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.Button btnAnterior;
        public System.Windows.Forms.DataGridView dgvDetalleDeuda;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn valor_detalle;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.DataGridView dgvPagos;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn fpago;
        private System.Windows.Forms.DataGridViewTextBoxColumn valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_sri;
        private System.Windows.Forms.Panel pnlFormasCobros;
        private System.Windows.Forms.Button btnGrabarPagos;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnRemoverPago;
    }
}