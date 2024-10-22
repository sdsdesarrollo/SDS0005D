namespace SDSB005D.Componentes.Texto
{
    partial class SdsTextBox
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
            // CajaTexto
            // 
            this.CajaTexto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CajaTexto.Location = new System.Drawing.Point(44, 2);
            this.CajaTexto.Name = "CajaTexto";
            this.CajaTexto.Size = new System.Drawing.Size(100, 20);
            this.CajaTexto.TabIndex = 1;
            this.CajaTexto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CajaTexto_KeyPress);
            this.CajaTexto.Leave += new System.EventHandler(this.CajaTexto_Leave);
            // 
            // SdsTextBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.CajaTexto);
            this.Controls.Add(this.Etiqueta);
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "SdsTextBox";
            this.Size = new System.Drawing.Size(146, 24);
            this.Resize += new System.EventHandler(this.SdsTextBox_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Etiqueta;
        private System.Windows.Forms.TextBox CajaTexto;
    }
}
