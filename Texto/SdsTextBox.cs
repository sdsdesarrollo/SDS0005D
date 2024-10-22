using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Numerics;
using System.Windows.Forms;

namespace SDSB005D.Componentes.Texto
{
    [DefaultEvent(nameof(TextoLostFocus))]
    public partial class SdsTextBox : UserControl
    {
        #region Internos
        private int Posicion;
        private bool EsNumerico;
        private int NoDecimales;
        private int AltoBase;

        #endregion

        #region Titulo
        [Browsable(true)]
        public string Titulo
        {
            get => Etiqueta.Text;
            set
            {
                Etiqueta.Text = value;
                Reposicionar();
            }
        }

        [Browsable(true)]
        public ContentAlignment TituloAlign
        {
            get => Etiqueta.TextAlign;
            set => Etiqueta.TextAlign = value;
        }

        [Browsable(true)]
        public int TituloPosicion
        {
            get => this.Posicion;
            set
            {
                this.Posicion = value;
                Reposicionar();
            }
        }

        [Browsable(true)]
        public Color TituloForeColor
        {
            get => Etiqueta.ForeColor;
            set => Etiqueta.ForeColor = value;
        }

        [Browsable(true)]
        public Color TituloBackColor
        {
            get => Etiqueta.BackColor;
            set => Etiqueta.BackColor = value;
        }

        [Browsable(true)]
        public Font TituloFont
        {
            get => Etiqueta.Font;
            set
            {
                Etiqueta.Font = value;
                Reposicionar();
            }
        }
        #endregion

        #region Texto

        [Browsable(true)]
        public string Texto
        {
            get => CajaTexto.Text;
            set
            {
                CajaTexto.Text = value;
                Reposicionar();
            }
        }

        [Browsable(true)]
        public object TextoTag
        {
            get => this.Tag;
            set => this.Tag = value;
        }

        [Browsable(true)]
        public Font TextoFont
        {
            get => CajaTexto.Font;
            set
            {
                CajaTexto.Font = value;
                Reposicionar();
            }
        }

        [Browsable(true)]
        public bool TextoMultiline
        {
            get => CajaTexto.Multiline;
            set => CajaTexto.Multiline = value;
        }

        [Browsable(true)]
        public ScrollBars TextoScrollBars
        {
            get => CajaTexto.ScrollBars;
            set => CajaTexto.ScrollBars = value;
        }

        [Browsable(true)]
        public bool TextoReadOnly
        {
            get => CajaTexto.ReadOnly;
            set => CajaTexto.ReadOnly = value;
        }

        [Browsable(true)]
        public BorderStyle TextoBorderStyle
        {
            get => CajaTexto.BorderStyle;
            set => CajaTexto.BorderStyle = value;
        }

        [Browsable(true)]
        public char TextoPasswordChar
        {
            get => CajaTexto.PasswordChar;
            set => CajaTexto.PasswordChar = value;
        }

        [Browsable(true)]
        public HorizontalAlignment TextoAlign
        {
            get => CajaTexto.TextAlign;
            set => CajaTexto.TextAlign = value;
        }

        [Browsable(true)]
        public int TextoNumericoNoDecimales
        {
            get => this.NoDecimales;
            set => this.NoDecimales = value;
        }

        [Browsable(true)]
        public bool TextoEsNumerico
        {
            get => this.EsNumerico;
            set
            {
                this.EsNumerico = value;
                if (!this.EsNumerico)
                {
                    this.NoDecimales = 0;
                }
            }
        }

        [Browsable(true)]
        public bool TextoWordWrap
        {
            get => CajaTexto.WordWrap;
            set => CajaTexto.WordWrap = value;
        }

        [Browsable(true)]
        public Color TextoBackColor
        {
            get => CajaTexto.BackColor;
            set => CajaTexto.BackColor = value;
        }

        [Browsable(true)]
        public Color TextoForeColor
        {
            get => CajaTexto.ForeColor;
            set => CajaTexto.ForeColor = value;
        }
        #endregion

        #region Eventos

        //[Browsable(true)]
        //public new event EventHandler TextoTextChanged
        //{
        //    add => CajaTexto.TextChanged += value;
        //    remove => CajaTexto.TextChanged -= value;
        //}

        //[Browsable(true)]
        //public new event KeyPressEventHandler TextoKeyPress
        //{
        //    add => CajaTexto.KeyPress += value;
        //    remove => CajaTexto.KeyPress -= value;
        //}

        [Browsable(true)]
        public event EventHandler TextoLostFocus
        {
            add => CajaTexto.LostFocus += value;
            remove => CajaTexto.LostFocus -= value;
        }

        [Browsable(true)]
        public event EventHandler TextoClick
        {
            add => CajaTexto.Click += value;
            remove => CajaTexto.Click -= value;
        }

        [Browsable(true)]
        public event EventHandler TextoDoubleClick
        {
            add => CajaTexto.DoubleClick += value;
            remove => CajaTexto.DoubleClick -= value;
        }
        #endregion

        #region DiseñoAutomatico

        private void Reposicionar()
        {

            //  Alto base
            List<int> numbers = new List<int> { this.Etiqueta.Height, this.CajaTexto.Height };
            AltoBase = numbers.Max();
            //this.AltoBase = this.Etiqueta.Height + this.CajaTexto.Height;

            this.CajaTexto.Width = 0;
            this.CajaTexto.Height = (int)AltoBase;
            this.Etiqueta.Height = (int)AltoBase;

            this.Etiqueta.Location = new System.Drawing.Point(2, 2);
            if (this.Posicion == 0)
            {
                this.CajaTexto.Location = new System.Drawing.Point(this.Etiqueta.Width + 4, 2);
                //this.Height = ((int)AltoBase + 4);
            }
            else
            {
                this.CajaTexto.Location = new System.Drawing.Point(4, this.Etiqueta.Height + 4);
                if (this.TextoMultiline) this.CajaTexto.Height = this.Height - this.Etiqueta.Height - 4;
                //this.Height = this.TextoMultiline ? : (((int)AltoBase * 2) + 6);
            }
            this.CajaTexto.Width = this.Width - (this.Posicion == 0 ? (this.Etiqueta.Width + 8) : 10);
        }

        #endregion

        public SdsTextBox()
        {
            InitializeComponent();
        }

        private void CajaTexto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!this.EsNumerico) return;
            if (e.KeyChar == (char)Keys.Back) return;
            //  Solo números
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            //  Solo un punto decimal
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
            //  Numero de decimales
            if ((sender as TextBox).Text.IndexOf('.') > -1)
            {
                if (this.NoDecimales > 0)
                {
                    if ((sender as TextBox).Text.Trim().Substring((sender as TextBox).Text.IndexOf('.')).Length > this.NoDecimales) e.Handled = true;
                }
                else
                {
                    e.Handled = true;
                }
            }
        }

        private void CajaTexto_Leave(object sender, EventArgs e)
        {
            if (this.EsNumerico && CajaTexto.PasswordChar == '\0')
            {
                NumberFormatInfo nfi = new CultureInfo("es-MX", false).NumberFormat;
                nfi.NumberDecimalDigits = (int)NoDecimales;
                decimal d;
                if (!decimal.TryParse(CajaTexto.Text, out d)) d = 0;
                CajaTexto.Text = d.ToString("N", nfi);
                CajaTexto.SelectionStart = CajaTexto.Text.Length;
            }
        }

        private void SdsTextBox_Resize(object sender, EventArgs e)
        {
            Reposicionar();
        }
    }
}
