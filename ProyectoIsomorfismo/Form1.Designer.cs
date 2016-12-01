﻿namespace ProyectoIsomorfismo
{
    partial class Form1
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
            this.btnGrafo1 = new System.Windows.Forms.Button();
            this.btnGrafo2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnComprobar = new System.Windows.Forms.Button();
            this.pbLoading = new System.Windows.Forms.ProgressBar();
            this.cbFunciones = new System.Windows.Forms.ComboBox();
            this.dgvMostrarFuncion = new System.Windows.Forms.DataGridView();
            this.colV1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.volV2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.testToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cargarDatosDeNuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrarFuncion)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGrafo1
            // 
            this.btnGrafo1.Location = new System.Drawing.Point(10, 32);
            this.btnGrafo1.Name = "btnGrafo1";
            this.btnGrafo1.Size = new System.Drawing.Size(75, 23);
            this.btnGrafo1.TabIndex = 0;
            this.btnGrafo1.Text = "Grafo 1";
            this.btnGrafo1.UseVisualStyleBackColor = true;
            this.btnGrafo1.Click += new System.EventHandler(this.btnGrafo1_Click);
            // 
            // btnGrafo2
            // 
            this.btnGrafo2.Location = new System.Drawing.Point(91, 32);
            this.btnGrafo2.Name = "btnGrafo2";
            this.btnGrafo2.Size = new System.Drawing.Size(75, 23);
            this.btnGrafo2.TabIndex = 1;
            this.btnGrafo2.Text = "Grafo 2";
            this.btnGrafo2.UseVisualStyleBackColor = true;
            this.btnGrafo2.Click += new System.EventHandler(this.btnGrafo2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnGrafo2);
            this.groupBox1.Controls.Add(this.btnGrafo1);
            this.groupBox1.Controls.Add(this.btnComprobar);
            this.groupBox1.Location = new System.Drawing.Point(14, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(181, 91);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Carga de grafos";
            // 
            // btnComprobar
            // 
            this.btnComprobar.Enabled = false;
            this.btnComprobar.Location = new System.Drawing.Point(35, 61);
            this.btnComprobar.Name = "btnComprobar";
            this.btnComprobar.Size = new System.Drawing.Size(129, 23);
            this.btnComprobar.TabIndex = 2;
            this.btnComprobar.Text = "Comprobar Isomorfismo";
            this.btnComprobar.UseVisualStyleBackColor = true;
            this.btnComprobar.Click += new System.EventHandler(this.btnComprobar_Click);
            // 
            // pbLoading
            // 
            this.pbLoading.Location = new System.Drawing.Point(14, 334);
            this.pbLoading.Name = "pbLoading";
            this.pbLoading.Size = new System.Drawing.Size(181, 23);
            this.pbLoading.TabIndex = 3;
            // 
            // cbFunciones
            // 
            this.cbFunciones.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFunciones.Enabled = false;
            this.cbFunciones.FormattingEnabled = true;
            this.cbFunciones.Location = new System.Drawing.Point(14, 151);
            this.cbFunciones.Name = "cbFunciones";
            this.cbFunciones.Size = new System.Drawing.Size(181, 21);
            this.cbFunciones.TabIndex = 4;
            this.cbFunciones.SelectedIndexChanged += new System.EventHandler(this.cbFunciones_SelectedIndexChanged);
            // 
            // dgvMostrarFuncion
            // 
            this.dgvMostrarFuncion.AllowUserToAddRows = false;
            this.dgvMostrarFuncion.AllowUserToDeleteRows = false;
            this.dgvMostrarFuncion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMostrarFuncion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colV1,
            this.volV2});
            this.dgvMostrarFuncion.Enabled = false;
            this.dgvMostrarFuncion.Location = new System.Drawing.Point(17, 178);
            this.dgvMostrarFuncion.Name = "dgvMostrarFuncion";
            this.dgvMostrarFuncion.Size = new System.Drawing.Size(166, 150);
            this.dgvMostrarFuncion.TabIndex = 5;
            // 
            // colV1
            // 
            this.colV1.HeaderText = "V1";
            this.colV1.Name = "colV1";
            this.colV1.ReadOnly = true;
            this.colV1.Width = 60;
            // 
            // volV2
            // 
            this.volV2.HeaderText = "V2";
            this.volV2.Name = "volV2";
            this.volV2.ReadOnly = true;
            this.volV2.Width = 60;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.testToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(207, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // testToolStripMenuItem
            // 
            this.testToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cargarDatosDeNuevoToolStripMenuItem});
            this.testToolStripMenuItem.Name = "testToolStripMenuItem";
            this.testToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.testToolStripMenuItem.Text = "Test";
            // 
            // cargarDatosDeNuevoToolStripMenuItem
            // 
            this.cargarDatosDeNuevoToolStripMenuItem.Name = "cargarDatosDeNuevoToolStripMenuItem";
            this.cargarDatosDeNuevoToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.cargarDatosDeNuevoToolStripMenuItem.Text = "Cargar datos de nuevo";
            this.cargarDatosDeNuevoToolStripMenuItem.Click += new System.EventHandler(this.cargarDatosDeNuevoToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Seleccione una función:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(207, 387);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvMostrarFuncion);
            this.Controls.Add(this.cbFunciones);
            this.Controls.Add(this.pbLoading);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrarFuncion)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGrafo1;
        private System.Windows.Forms.Button btnGrafo2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnComprobar;
        private System.Windows.Forms.ProgressBar pbLoading;
        private System.Windows.Forms.ComboBox cbFunciones;
        private System.Windows.Forms.DataGridView dgvMostrarFuncion;
        private System.Windows.Forms.DataGridViewTextBoxColumn colV1;
        private System.Windows.Forms.DataGridViewTextBoxColumn volV2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem testToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cargarDatosDeNuevoToolStripMenuItem;
        private System.Windows.Forms.Label label1;
    }
}

