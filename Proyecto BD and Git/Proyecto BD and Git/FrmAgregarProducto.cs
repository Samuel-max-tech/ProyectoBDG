using Entidades;
using Manejador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_BD_and_Git
{
    public partial class FrmAgregarProducto : Form
    {
        ManejaadorProductos me;
        public FrmAgregarProducto()
        {
            InitializeComponent();
            me = new ManejaadorProductos();
            if (FrmProductos.producto._Idproductos > 0)
            {
                txtNombre.Text = FrmProductos.producto._Nombre.ToString();
                txtDescripcion.Text = FrmProductos.producto._Descripcion.ToString();
                txtPrecio.Text = FrmProductos.producto._Precio.ToString();
            }
        }

        private void BtnAgregar1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(me.Guardar(new Productos(0, txtNombre.Text, txtDescripcion.Text, double.Parse(txtPrecio.Text))));
            Close();
        }
    }
}
