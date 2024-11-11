namespace SegundoParcialEsfera.Windows
{
    partial class frmEsferasAE
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            txtRadio = new TextBox();
            groupBox1 = new GroupBox();
            rbtJuguete = new RadioButton();
            rbtIngenieria = new RadioButton();
            rbtCientifica = new RadioButton();
            rbtDecorativa = new RadioButton();
            label2 = new Label();
            cboColores = new ComboBox();
            btnOK = new Button();
            btnCancelar = new Button();
            label3 = new Label();
            txtDensidad = new TextBox();
            errorProvider1 = new ErrorProvider(components);
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(56, 31);
            label1.Name = "label1";
            label1.Size = new Size(37, 15);
            label1.TabIndex = 0;
            label1.Text = "Radio";
            // 
            // txtRadio
            // 
            txtRadio.Location = new Point(117, 28);
            txtRadio.Name = "txtRadio";
            txtRadio.Size = new Size(135, 23);
            txtRadio.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rbtJuguete);
            groupBox1.Controls.Add(rbtIngenieria);
            groupBox1.Controls.Add(rbtCientifica);
            groupBox1.Controls.Add(rbtDecorativa);
            groupBox1.Location = new Point(52, 64);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 150);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = " Tios de Esferas ";
            // 
            // rbtJuguete
            // 
            rbtJuguete.AutoSize = true;
            rbtJuguete.Location = new Point(19, 102);
            rbtJuguete.Name = "rbtJuguete";
            rbtJuguete.Size = new Size(66, 19);
            rbtJuguete.TabIndex = 0;
            rbtJuguete.Text = "Juguete";
            rbtJuguete.UseVisualStyleBackColor = true;
            // 
            // rbtIngenieria
            // 
            rbtIngenieria.AutoSize = true;
            rbtIngenieria.Location = new Point(19, 77);
            rbtIngenieria.Name = "rbtIngenieria";
            rbtIngenieria.Size = new Size(77, 19);
            rbtIngenieria.TabIndex = 0;
            rbtIngenieria.Text = "Ingeniería";
            rbtIngenieria.UseVisualStyleBackColor = true;
            // 
            // rbtCientifica
            // 
            rbtCientifica.AutoSize = true;
            rbtCientifica.Location = new Point(19, 52);
            rbtCientifica.Name = "rbtCientifica";
            rbtCientifica.Size = new Size(75, 19);
            rbtCientifica.TabIndex = 0;
            rbtCientifica.Text = "Científica";
            rbtCientifica.UseVisualStyleBackColor = true;
            // 
            // rbtDecorativa
            // 
            rbtDecorativa.AutoSize = true;
            rbtDecorativa.Checked = true;
            rbtDecorativa.Location = new Point(19, 27);
            rbtDecorativa.Name = "rbtDecorativa";
            rbtDecorativa.Size = new Size(81, 19);
            rbtDecorativa.TabIndex = 0;
            rbtDecorativa.TabStop = true;
            rbtDecorativa.Text = "Decorativa";
            rbtDecorativa.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(56, 229);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 3;
            label2.Text = "Color:";
            // 
            // cboColores
            // 
            cboColores.FormattingEnabled = true;
            cboColores.Location = new Point(102, 226);
            cboColores.Name = "cboColores";
            cboColores.Size = new Size(150, 23);
            cboColores.TabIndex = 4;
            // 
            // btnOK
            // 
            btnOK.Location = new Point(32, 293);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(75, 53);
            btnOK.TabIndex = 5;
            btnOK.Text = "OK";
            btnOK.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(204, 293);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 53);
            btnCancelar.TabIndex = 5;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(51, 261);
            label3.Name = "label3";
            label3.Size = new Size(56, 15);
            label3.TabIndex = 0;
            label3.Text = "Densidad";
            // 
            // txtDensidad
            // 
            txtDensidad.Location = new Point(117, 258);
            txtDensidad.Name = "txtDensidad";
            txtDensidad.Size = new Size(135, 23);
            txtDensidad.TabIndex = 1;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // frmEsferasAE
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(313, 365);
            Controls.Add(btnCancelar);
            Controls.Add(btnOK);
            Controls.Add(cboColores);
            Controls.Add(label2);
            Controls.Add(groupBox1);
            Controls.Add(txtDensidad);
            Controls.Add(txtRadio);
            Controls.Add(label3);
            Controls.Add(label1);
            MaximumSize = new Size(329, 404);
            MinimumSize = new Size(329, 404);
            Name = "frmEsferasAE";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmEsferasAE";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtRadio;
        private GroupBox groupBox1;
        private RadioButton rbtJuguete;
        private RadioButton rbtIngenieria;
        private RadioButton rbtCientifica;
        private RadioButton rbtDecorativa;
        private Label label2;
        private ComboBox cboColores;
        private Button btnOK;
        private Button btnCancelar;
        private Label label3;
        private TextBox txtDensidad;
        private ErrorProvider errorProvider1;
    }
}