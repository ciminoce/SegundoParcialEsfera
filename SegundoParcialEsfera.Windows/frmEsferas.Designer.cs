namespace SegundoParcialEsfera.Windows
{
    partial class frmEsferas
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
            panelGrilla = new Panel();
            dgvDatos = new DataGridView();
            panelInformacion = new Panel();
            txtCantidad = new TextBox();
            label1 = new Label();
            toolStrip1 = new ToolStrip();
            tsbNuevo = new ToolStripButton();
            tsbBorrar = new ToolStripButton();
            tsbEditar = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            tsbFiltrar = new ToolStripDropDownButton();
            colorToolStripMenuItem = new ToolStripMenuItem();
            tsCboColores = new ToolStripComboBox();
            tsbActualizar = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            tsbOrdenar = new ToolStripDropDownButton();
            edadToolStripMenuItem = new ToolStripMenuItem();
            edad90ToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator3 = new ToolStripSeparator();
            tsbSalir = new ToolStripButton();
            colRadio = new DataGridViewTextBoxColumn();
            colDensidad = new DataGridViewTextBoxColumn();
            colVolumen = new DataGridViewTextBoxColumn();
            colMasa = new DataGridViewTextBoxColumn();
            colTipo = new DataGridViewTextBoxColumn();
            colColor = new DataGridViewTextBoxColumn();
            panelGrilla.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDatos).BeginInit();
            panelInformacion.SuspendLayout();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // panelGrilla
            // 
            panelGrilla.Controls.Add(dgvDatos);
            panelGrilla.Dock = DockStyle.Fill;
            panelGrilla.Location = new Point(0, 70);
            panelGrilla.Name = "panelGrilla";
            panelGrilla.Size = new Size(800, 423);
            panelGrilla.TabIndex = 5;
            // 
            // dgvDatos
            // 
            dgvDatos.AllowUserToAddRows = false;
            dgvDatos.AllowUserToDeleteRows = false;
            dgvDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDatos.Columns.AddRange(new DataGridViewColumn[] { colRadio, colDensidad, colVolumen, colMasa, colTipo, colColor });
            dgvDatos.Dock = DockStyle.Fill;
            dgvDatos.Location = new Point(0, 0);
            dgvDatos.Name = "dgvDatos";
            dgvDatos.ReadOnly = true;
            dgvDatos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDatos.Size = new Size(800, 423);
            dgvDatos.TabIndex = 0;
            // 
            // panelInformacion
            // 
            panelInformacion.Controls.Add(txtCantidad);
            panelInformacion.Controls.Add(label1);
            panelInformacion.Dock = DockStyle.Bottom;
            panelInformacion.Location = new Point(0, 493);
            panelInformacion.Name = "panelInformacion";
            panelInformacion.Size = new Size(800, 70);
            panelInformacion.TabIndex = 4;
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(123, 20);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.ReadOnly = true;
            txtCantidad.Size = new Size(100, 23);
            txtCantidad.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 23);
            label1.Name = "label1";
            label1.Size = new Size(58, 15);
            label1.TabIndex = 0;
            label1.Text = "Cantidad:";
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { tsbNuevo, tsbBorrar, tsbEditar, toolStripSeparator1, tsbFiltrar, tsbActualizar, toolStripSeparator2, tsbOrdenar, toolStripSeparator3, tsbSalir });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 70);
            toolStrip1.TabIndex = 3;
            toolStrip1.Text = "toolStrip1";
            // 
            // tsbNuevo
            // 
            tsbNuevo.Image = Properties.Resources.add_file_48px;
            tsbNuevo.ImageScaling = ToolStripItemImageScaling.None;
            tsbNuevo.ImageTransparentColor = Color.Magenta;
            tsbNuevo.Name = "tsbNuevo";
            tsbNuevo.Size = new Size(52, 67);
            tsbNuevo.Text = "Nuevo";
            tsbNuevo.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // tsbBorrar
            // 
            tsbBorrar.Image = Properties.Resources.delete_file_48px;
            tsbBorrar.ImageScaling = ToolStripItemImageScaling.None;
            tsbBorrar.ImageTransparentColor = Color.Magenta;
            tsbBorrar.Name = "tsbBorrar";
            tsbBorrar.Size = new Size(52, 67);
            tsbBorrar.Text = "Borrar";
            tsbBorrar.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // tsbEditar
            // 
            tsbEditar.Image = Properties.Resources.edit_file_48px;
            tsbEditar.ImageScaling = ToolStripItemImageScaling.None;
            tsbEditar.ImageTransparentColor = Color.Magenta;
            tsbEditar.Name = "tsbEditar";
            tsbEditar.Size = new Size(52, 67);
            tsbEditar.Text = "Editar";
            tsbEditar.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 70);
            // 
            // tsbFiltrar
            // 
            tsbFiltrar.DropDownItems.AddRange(new ToolStripItem[] { colorToolStripMenuItem });
            tsbFiltrar.Image = Properties.Resources.filled_filter_48px;
            tsbFiltrar.ImageScaling = ToolStripItemImageScaling.None;
            tsbFiltrar.ImageTransparentColor = Color.Magenta;
            tsbFiltrar.Name = "tsbFiltrar";
            tsbFiltrar.Size = new Size(61, 67);
            tsbFiltrar.Text = "Filtrar";
            tsbFiltrar.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // colorToolStripMenuItem
            // 
            colorToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { tsCboColores });
            colorToolStripMenuItem.Name = "colorToolStripMenuItem";
            colorToolStripMenuItem.Size = new Size(97, 22);
            colorToolStripMenuItem.Text = "Tipo";
            // 
            // tsCboColores
            // 
            tsCboColores.Name = "tsCboColores";
            tsCboColores.Size = new Size(121, 23);
            // 
            // tsbActualizar
            // 
            tsbActualizar.Image = Properties.Resources.restart_48px;
            tsbActualizar.ImageScaling = ToolStripItemImageScaling.None;
            tsbActualizar.ImageTransparentColor = Color.Magenta;
            tsbActualizar.Name = "tsbActualizar";
            tsbActualizar.Size = new Size(63, 67);
            tsbActualizar.Text = "Actualizar";
            tsbActualizar.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 70);
            // 
            // tsbOrdenar
            // 
            tsbOrdenar.DropDownItems.AddRange(new ToolStripItem[] { edadToolStripMenuItem, edad90ToolStripMenuItem });
            tsbOrdenar.Image = Properties.Resources.sorting_answers_48px;
            tsbOrdenar.ImageScaling = ToolStripItemImageScaling.None;
            tsbOrdenar.ImageTransparentColor = Color.Magenta;
            tsbOrdenar.Name = "tsbOrdenar";
            tsbOrdenar.Size = new Size(63, 67);
            tsbOrdenar.Text = "Ordenar";
            tsbOrdenar.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // edadToolStripMenuItem
            // 
            edadToolStripMenuItem.Image = Properties.Resources.numerical_sorting_12_48px;
            edadToolStripMenuItem.Name = "edadToolStripMenuItem";
            edadToolStripMenuItem.Size = new Size(135, 22);
            edadToolStripMenuItem.Text = "Radio (0-9)";
            // 
            // edad90ToolStripMenuItem
            // 
            edad90ToolStripMenuItem.Image = Properties.Resources.numerical_sorting_21_48px;
            edad90ToolStripMenuItem.Name = "edad90ToolStripMenuItem";
            edad90ToolStripMenuItem.Size = new Size(135, 22);
            edad90ToolStripMenuItem.Text = "Radio  (9-0)";
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(6, 70);
            // 
            // tsbSalir
            // 
            tsbSalir.Image = Properties.Resources.exit_48px;
            tsbSalir.ImageScaling = ToolStripItemImageScaling.None;
            tsbSalir.ImageTransparentColor = Color.Magenta;
            tsbSalir.Name = "tsbSalir";
            tsbSalir.Size = new Size(52, 67);
            tsbSalir.Text = "Salir";
            tsbSalir.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // colRadio
            // 
            colRadio.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colRadio.HeaderText = "Radio";
            colRadio.Name = "colRadio";
            colRadio.ReadOnly = true;
            // 
            // colDensidad
            // 
            colDensidad.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colDensidad.HeaderText = "Densidad";
            colDensidad.Name = "colDensidad";
            colDensidad.ReadOnly = true;
            // 
            // colVolumen
            // 
            colVolumen.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colVolumen.HeaderText = "Volumen";
            colVolumen.Name = "colVolumen";
            colVolumen.ReadOnly = true;
            // 
            // colMasa
            // 
            colMasa.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colMasa.HeaderText = "Masa";
            colMasa.Name = "colMasa";
            colMasa.ReadOnly = true;
            // 
            // colTipo
            // 
            colTipo.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colTipo.HeaderText = "Tipo Esfera";
            colTipo.Name = "colTipo";
            colTipo.ReadOnly = true;
            // 
            // colColor
            // 
            colColor.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colColor.HeaderText = "Color";
            colColor.Name = "colColor";
            colColor.ReadOnly = true;
            // 
            // frmEsferas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 563);
            Controls.Add(panelGrilla);
            Controls.Add(panelInformacion);
            Controls.Add(toolStrip1);
            MaximumSize = new Size(816, 602);
            MinimumSize = new Size(816, 602);
            Name = "frmEsferas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Lista de Esferas";
            panelGrilla.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDatos).EndInit();
            panelInformacion.ResumeLayout(false);
            panelInformacion.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelGrilla;
        private DataGridView dgvDatos;
        private Panel panelInformacion;
        private TextBox txtCantidad;
        private Label label1;
        private ToolStrip toolStrip1;
        private ToolStripButton tsbNuevo;
        private ToolStripButton tsbBorrar;
        private ToolStripButton tsbEditar;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripDropDownButton tsbFiltrar;
        private ToolStripButton tsbActualizar;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripDropDownButton tsbOrdenar;
        private ToolStripMenuItem edadToolStripMenuItem;
        private ToolStripMenuItem edad90ToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripButton tsbSalir;
        private ToolStripMenuItem colorToolStripMenuItem;
        private ToolStripComboBox tsCboColores;
        private DataGridViewTextBoxColumn colRadio;
        private DataGridViewTextBoxColumn colDensidad;
        private DataGridViewTextBoxColumn colVolumen;
        private DataGridViewTextBoxColumn colMasa;
        private DataGridViewTextBoxColumn colTipo;
        private DataGridViewTextBoxColumn colColor;
    }
}
