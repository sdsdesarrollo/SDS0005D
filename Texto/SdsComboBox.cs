using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace SDSB005D.Componentes.Texto
{
    public partial class SdsComboBox : UserControl
    {
        #region Internos
        private bool CajaTxtMostrar;
        private int Posicion;
        private int Ancho;
        private int AltoBase;
        private string DisplayDesc;
        private object Row;

        #endregion

        [Browsable(true)]
        public bool SdsCajaTextoMostrar
        {
            get => this.CajaTxtMostrar;
            set => this.CajaTxtMostrar = value;
        }

        [Browsable(true)]
        public object SdsRow
        {
            get => this.Row;
        }

        #region Combos

        [Browsable(true)]
        public int CboWidth
        {
            get => Combo.Width;
            set
            {
                Combo.Width = value;
                Reposicionar();
            }
        }

        [Browsable(true)]
        public Font CboFont
        {
            get => Combo.Font;
            set
            {
                Combo.Font = value;
                CajaTexto.Font = Combo.Font;
            }
        }

        [Browsable(true)]
        public Color CboBackColor
        {
            get => Combo.BackColor;
            set => Combo.BackColor = value;
        }

        [Browsable(true)]
        public object CboDataSource
        {
            get => Combo.DataSource;
            set => Combo.DataSource = value;
        }

        [Browsable(true)]
        public string CboDisplayMember
        {
            get => Combo.DisplayMember;
            set => Combo.DisplayMember = value;
        }

        [Browsable(true)]
        public ComboBoxStyle CboDropDownStyle
        {
            get => Combo.DropDownStyle;
            set => Combo.DropDownStyle = value;
        }

        [Browsable(true)]
        public string CboDisplayDesc
        {
            get => this.DisplayDesc;
            set => this.DisplayDesc = value;
        }

        [Browsable(true)]
        public int CboDropDownHeight
        {
            get => Combo.DropDownHeight;
            set => Combo.DropDownHeight = value;
        }

        [Browsable(true)]
        public int CboDropDownWidth
        {
            get => Combo.DropDownWidth;
            set => Combo.DropDownWidth = value;
        }

        [Browsable(true)]
        public FlatStyle CboFlatStyle
        {
            get => Combo.FlatStyle;
            set => Combo.FlatStyle = value;
        }

        [Browsable(true)]
        public Color CboForeColor
        {
            get => Combo.ForeColor;
            set => Combo.ForeColor = value;
        }

        [Browsable(true)]
        public int CboItemHeight
        {
            get => Combo.ItemHeight;
            set => Combo.ItemHeight = value;
        }

        [Browsable(true)]
        public int CboMaxDropDownItems
        {
            get => Combo.MaxDropDownItems;
            set => Combo.MaxDropDownItems = value;
        }

        [Browsable(true)]
        public object CboTag
        {
            get => Combo.Tag;
            set => Combo.Tag = value;
        }

        [Browsable(true)]
        public string CboText
        {
            get => Combo.Text;
            set => Combo.Text = value;
        }

        [Browsable(true)]
        public string CboValueMember
        {
            get => Combo.ValueMember;
            set => Combo.ValueMember = value;
        }

        [Browsable(true)]
        public object CboSelectedValue
        {
            get => Combo.SelectedValue;
            set => Combo.SelectedValue = value;
        }

        [Browsable(true)]
        public object CboSelectedItem
        {
            get => Combo.SelectedItem;
            set => Combo.SelectedItem = value;
        }

        [Browsable(true)]
        public string CboSelectedText
        {
            get => Combo.SelectedText;
            set => Combo.SelectedText = value;
        }

        [Browsable(true)]
        public int CboSelectedIndex
        {
            get => Combo.SelectedIndex;
            set => Combo.SelectedIndex = value;
        }
        #endregion

        #region Texto

        [Browsable(true)]
        public string Texto
        {
            get => CajaTexto.Text;
            set => CajaTexto.Text = value;
        }

        [Browsable(true)]
        public object TextoTag
        {
            get => this.Tag;
            set => this.Tag = value;
        }

        [Browsable(true)]
        public BorderStyle TextoBorderStyle
        {
            get => CajaTexto.BorderStyle;
            set => CajaTexto.BorderStyle = value;
        }

        [Browsable(true)]
        public HorizontalAlignment TextoAlign
        {
            get => CajaTexto.TextAlign;
            set => CajaTexto.TextAlign = value;
        }

        //[Browsable(true)]
        //public bool TextoWordWrap
        //{
        //    get => CajaTexto.WordWrap;
        //    set => CajaTexto.WordWrap = value;
        //}

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

        #region Eventos
        [Browsable(true)]
        public event EventHandler CboSelectedValueChanged
        {
            add => Combo.SelectedValueChanged += value;
            remove => Combo.SelectedValueChanged -= value;
        }

        [Browsable(true)]
        public new event EventHandler CboSelectedIndexChanged
        {
            add => Combo.SelectedIndexChanged += value;
            remove => Combo.SelectedIndexChanged -= value;
        }

        [Browsable(true)]
        public new event EventHandler CboValidated
        {
            add => Combo.Validated += value;
            remove => Combo.Validated -= value;
        }

        [Browsable(true)]
        public new event CancelEventHandler CboValidating
        {
            add => Combo.Validating += value;
            remove => Combo.Validating -= value;
        }

        [Browsable(true)]
        public new event EventHandler CboClick
        {
            add => Combo.Click += value;
            remove => Combo.Click -= value;
        }

        [Browsable(true)]
        public new event ListControlConvertEventHandler CboFormat
        {
            add => Combo.Format += value;
            remove => Combo.Format -= value;
        }

        [Browsable(true)]
        public new event KeyEventHandler CboKeyDown
        {
            add => Combo.KeyDown += value;
            remove => Combo.KeyDown -= value;
        }

        [Browsable(true)]
        public new event KeyPressEventHandler CboKeyPress
        {
            add => Combo.KeyPress += value;
            remove => Combo.KeyPress -= value;
        }

        [Browsable(true)]
        public new event MouseEventHandler CboMouseClick
        {
            add => Combo.MouseClick += value;
            remove => Combo.MouseClick -= value;
        }

        [Browsable(true)]
        public new event PreviewKeyDownEventHandler CboPreviewKeyDown
        {
            add => Combo.PreviewKeyDown += value;
            remove => Combo.PreviewKeyDown -= value;
        }

        [Browsable(true)]
        public new event EventHandler CboTextChanged
        {
            add => Combo.TextChanged += value;
            remove => Combo.TextChanged -= value;
        }

        [Browsable(true)]
        public new event EventHandler CboTextUpdate
        {
            add => Combo.TextUpdate += value;
            remove => Combo.TextUpdate -= value;
        }

        #endregion

        private void Reposicionar()
        {
            //  Alto base
            List<int> numbers = new List<int> { this.Etiqueta.Height, this.CajaTexto.Height };
            AltoBase = numbers.Max();

            this.CajaTexto.Width = 0;
            this.CajaTexto.Height = AltoBase;
            this.Etiqueta.Height = AltoBase;
            this.Combo.Height = AltoBase;


            this.Etiqueta.Location = new System.Drawing.Point(2, 2);
            if (this.Posicion == 0)
            {
                this.Combo.Location = new System.Drawing.Point(this.Etiqueta.Width + 4, 2);
                if (this.SdsCajaTextoMostrar) this.CajaTexto.Location = new System.Drawing.Point(this.Etiqueta.Width + this.Combo.Width + 6, 2);
                this.Height = AltoBase + 6;
            }
            else
            {
                this.Combo.Location = new System.Drawing.Point(2, this.Etiqueta.Height + 4);
                if (this.SdsCajaTextoMostrar) this.CajaTexto.Location = new System.Drawing.Point(this.Combo.Width + 4, this.Etiqueta.Height + 4);
                this.Height = (AltoBase * 2) + 6;
            }
            if (this.SdsCajaTextoMostrar) this.CajaTexto.Width = this.Width - (this.Posicion == 0 ? this.Combo.Width + this.Etiqueta.Width + 10 : this.Combo.Width +  8);
        }


        public SdsComboBox()
        {
            InitializeComponent();
        }

        //  Ultimo evento mapeado, realzar la devolución del valor Desc y el objeto ROW seleccionado
        //  Por el momento solo DataRow u objeto si esta enlazado a otro colección
        private void Combo_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (Combo.SelectedIndex >= 0 && !string.IsNullOrEmpty(this.DisplayDesc))
            {
                if (Combo.DataSource.GetType() == typeof(System.Data.DataTable))
                {
                    this.CajaTexto.Text = ((System.Data.DataTable)Combo.DataSource).Rows[Combo.SelectedIndex][this.DisplayDesc].ToString();
                    this.Row = ((System.Data.DataTable)Combo.DataSource).Rows[Combo.SelectedIndex];
                }
                else
                {
                    //dynamic Sdk;
                    //Type Sk;
                    //Sk = Type.GetTypeFromCLSID(Combo.SelectedItem.GetType().BaseType.GUID);
                    //Sdk = Activator.CreateInstance(Sk);
                    this.Row = Combo.SelectedItem;
                    this.CajaTexto.Text = "--";
                }
            }
            else
            {
                this.CajaTexto.Text = string.Empty;
                this.Row = null;
            }
        }
        private void Combo_SelectedValueChanged(object sender, System.EventArgs e) { }
        //  Al perder el foco si es dropdownlist
        private void Combo_Validated(object sender, System.EventArgs e) { }
        private void Combo_Validating(object sender, CancelEventArgs e) { }
        //
        private void Combo_Click(object sender, System.EventArgs e) { }
        private void Combo_Format(object sender, ListControlConvertEventArgs e) { }
        private void Combo_KeyDown(object sender, KeyEventArgs e) { }
        private void Combo_KeyPress(object sender, KeyPressEventArgs e) { }
        private void Combo_MouseClick(object sender, MouseEventArgs e) { }
        private void Combo_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e) { }
        private void Combo_TextChanged(object sender, System.EventArgs e) { }
        private void Combo_TextUpdate(object sender, System.EventArgs e) { }

        private void SdsComboBox_Resize(object sender, EventArgs e)
        {
            Reposicionar();
        }
    }
}
