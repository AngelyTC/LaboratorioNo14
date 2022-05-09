using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Newtonsoft.Json;
using System.IO;

namespace LaboratorioNo14
{
    public partial class _Default : Page
    {

        static List<Productos> Alimento = new List<Productos> ();
        static List<IngresoProductos> ingresoP = new List<IngresoProductos>();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnIngresoP_Click(object sender, EventArgs e)
        {
            IngresoProductos ingreso1 = new IngresoProductos();
            ingreso1.CodigoP1 = txtCodigoP.Text;
            ingreso1.NombreP1 = txtNombreP.Text;
            ingreso1.DescripcionP1 = txtDescripcionP.Text;

            ingresoP.Add(ingreso1);

            GridView1.DataSource = ingresoP;
            GridView1.DataBind();

            Productos producA = new Productos();
            producA.CodigoP = txtCodigoP.Text;
            producA.NombreP = txtNombreP.Text;
            producA.DescripcionP = txtDescripcionP.Text;
            producA.PrecioCompraP = Convert.ToInt32(txtPrecioCompra.Text);
            producA.PrecioVentaP = Convert.ToInt32(txtPrecioVenta.Text);
            producA.FechaVencimientoP = CalendarFechaV.SelectedDate;
            producA.UnidadMedidaP = txtUnidad.Text;

            Alimento.Add(producA);

            GuardarProducto();            
        }

        private void GuardarProducto()
        {
            string json = JsonConvert.SerializeObject(Alimento );

            string archivo = Server.MapPath("Productos.json");

            System.IO.File.WriteAllText(archivo, json);
        }



    }
}