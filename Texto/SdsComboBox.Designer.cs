namespace SDSB005D.Componentes.Texto
{
    partial class SdsComboBox
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Etiqueta = new System.Windows.Forms.Label();
            this.Combo = new System.Windows.Forms.ComboBox();
            this.CajaTexto = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Etiqueta
            // 
            this.Etiqueta.AutoSize = true;
            this.Etiqueta.Location = new System.Drawing.Point(4, 3);
            this.Etiqueta.Margin = new System.Windows.Forms.Padding(2);
            this.Etiqueta.Name = "Etiqueta";
            this.Etiqueta.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.Etiqueta.Size = new System.Drawing.Size(35, 17);
            this.Etiqueta.TabIndex = 0;
            this.Etiqueta.Text = "label1";
            this.Etiqueta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Combo
            // 
            this.Combo.FormattingEnabled = true;
            this.Combo.Location = new System.Drawing.Point(45, 2);
            this.Combo.Name = "Combo";
            this.Combo.Size = new System.Drawing.Size(121, 21);
            this.Combo.TabIndex = 1;
            this.Combo.SelectedIndexChanged += new System.EventHandler(this.Combo_SelectedIndexChanged);
            this.Combo.TextUpdate += new System.EventHandler(this.Combo_TextUpdate);
            this.Combo.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.Combo_Format);
            this.Combo.SelectedValueChanged += new System.EventHandler(this.Combo_SelectedValueChanged);
            this.Combo.TextChanged += new System.EventHandler(this.Combo_TextChanged);
            this.Combo.Click += new System.EventHandler(this.Combo_Click);
            this.Combo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Combo_KeyDown);
            this.Combo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Combo_KeyPress);
            this.Combo.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Combo_MouseClick);
            this.Combo.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.Combo_PreviewKeyDown);
            this.Combo.Validating += new System.ComponentModel.CancelEventHandler(this.Combo_Validating);
            this.Combo.Validated += new System.EventHandler(this.Combo_Validated);
            // 
            // CajaTexto
            // 
            this.CajaTexto.Location = new System.Drawing.Point(166, 2);
            this.CajaTexto.Name = "CajaTexto";
            this.CajaTexto.ReadOnly = true;
            this.CajaTexto.Size = new System.Drawing.Size(2, 20);
            this.CajaTexto.TabIndex = 2;
            // 
            // SdsComboBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.CajaTexto);
            this.Controls.Add(this.Combo);
            this.Controls.Add(this.Etiqueta);
            this.Name = "SdsComboBox";
            this.Size = new System.Drawing.Size(171, 24);
            this.Resize += new System.EventHandler(this.SdsComboBox_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Etiqueta;
        private System.Windows.Forms.ComboBox Combo;
        private System.Windows.Forms.TextBox CajaTexto;
    }
}
