﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AccesoDatos;
using Entidades;

namespace Manejador
{
    public class ManejaadorProductos
    {
        AccesoDatosProductos ade = new AccesoDatosProductos();
        Complementos c = new Complementos();
        public void Mostrar(DataGridView tabla, string f)
        {
            tabla.Columns.Clear();
            tabla.DataSource = ade.Mostrar(f).Tables[0];
            //tabla.Columns.Insert(4, c.Boton("Eliminar"));
            //tabla.Columns.Insert(5, c.Boton("Editar"));
            tabla.AutoResizeColumns();
            tabla.AutoResizeRows();
        }
        public DataSet Mostrar(string f)
        {
            throw new NotImplementedException();
        }
        public string Guardar(dynamic Entidad)
        {
            return ade.Guardar(Entidad);
        }
    }
}