using Estructura;
using Estructura.Enum;
using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public ActivoFijoModel model { get; set; }
        public Form2()
        {
            InitializeComponent();
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            ActivoFijo p = new ActivoFijo()
            {
                NombreActivo = txtNombre.Text,
                CodigoActivo = txtCodigo.Text,
                Descripcion = txtDescripcion.Text,
                ValorActivo = nudValor.Value,
                ValorResidual = nudValorResidual.Value,
                FechaAdquisicion = dtpFecha.Value,
                tipoActivoFijo = (TipoActivoFijo)cmbTipoActivo.SelectedIndex
            };
            model.Add(p);
            this.Close();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
