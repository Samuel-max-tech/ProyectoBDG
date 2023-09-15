﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using Manejador;

namespace Proyecto_BD_and_Git
{
    public partial class FrmProductos : Form
    {
        ManejaadorProductos me;
        int fila = 0, columna = 0;
        public static Productos producto = new Productos(0, "", "", 0.0);
        public static string nombre = "";
        public static string descripcion = "";
        public static double precio = 0.0;
        public FrmProductos()
        {
            InitializeComponent();
            me = new ManejaadorProductos();
        }

        private void BtnAgregar1_Click(object sender, EventArgs e)
        {
            producto._Idproductos = 0;
            FrmAgregarProducto pd = new FrmAgregarProducto();
            pd.ShowDialog();
            Actualizar();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            Actualizar();
        }

        private void dtgProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            switch (columna)
            {
                case 4:
                    {
                        MessageBox.Show(me.Borrar(producto));
                        Actualizar();
                    }
                    break;
                case 5:
                    {
                        FrmAgregarProducto pd = new FrmAgregarProducto();
                        pd.ShowDialog();
                        Actualizar();
                    }
                    break;
                default: break;
            }
        }

        private void dtgProductos_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            fila = e.RowIndex;
            columna = e.ColumnIndex;
            producto._Idproductos = int.Parse(dtgProductos.Rows[fila].Cells[0].Value.ToString());
            producto._Nombre = dtgProductos.Rows[fila].Cells[1].Value.ToString();
            producto._Descripcion = dtgProductos.Rows[fila].Cells[2].Value.ToString();
            producto._Precio = double.Parse(dtgProductos.Rows[fila].Cells[3].Value.ToString());
        }

        void Actualizar()
        {
            me.Mostrar(dtgProductos, txtBuscar.Text);
        }
    }
}
