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
    public partial class EditarProducto : System.Web.UI.Page
    {
        static List<Productos> Alimento = new List<Productos>();
        static string codigoProductos;

        protected void Page_Load(object sender, EventArgs e)
        {
            string archivo = Server.MapPath("Productos.json");
            StreamReader jsonStream = File.OpenText(archivo);
            string json = jsonStream.ReadToEnd();
            jsonStream.Close();

           Alimento = JsonConvert.DeserializeObject<List<Productos>>(json);
        }

        protected void GuardarProductoEditado()
        {
            string json = JsonConvert.SerializeObject(Alimento);
            string archivo = Server.MapPath("Productos.json");
            System.IO.File.WriteAllText(archivo, json);
        }


        protected void btnBuscarP_Click(object sender, EventArgs e)
        {
            codigoProductos  = txtCodigoPro.Text;
            bool encontrar = false;

            foreach (var u in Alimento)
            {
                Productos AlEditado = Alimento.Find(c => c.CodigoP == codigoProductos );

                if (AlEditado != null)
                {
                    txtNombrePro.Text = AlEditado.NombreP;
                    txtDescripcion.Text = AlEditado.DescripcionP;
                    txtCompra.Text = AlEditado.PrecioCompraP.ToString();
                    txtVenta.Text = AlEditado.PrecioVentaP.ToString();
                    CalendarVencimiento.SelectedDate = AlEditado.FechaVencimientoP;
                    txtUnidad.Text = AlEditado.UnidadMedidaP;
                    encontrar = true;
                }
            }
            if (!encontrar)
            {
                Response.Write("<script>alert('El producto no se ha encotrado')</script>");
                codigoProductos = "";
                txtNombrePro.Text = " ";
                txtDescripcion.Text = " ";
                txtCompra.Text = " ";
                txtVenta.Text = " ";
                txtUnidad.Text = " ";
            }
        }

        protected void btnModificar_Click(object sender, EventArgs e)
        {
            foreach (var u in Alimento)
            {
                //en modificar se usa findIndex
                int editadoAdmin = Alimento.FindIndex(c => c.CodigoP == codigoProductos);

                if (editadoAdmin > -1)
                {
                    u.NombreP = txtNombrePro.Text;
                    u.DescripcionP = txtDescripcion.Text;
                    u.PrecioCompraP = Convert.ToInt32(txtCompra.Text);
                    u.PrecioVentaP = Convert.ToInt32(txtVenta.Text);
                    u.FechaVencimientoP = CalendarVencimiento.SelectedDate;
                    u.UnidadMedidaP = txtUnidad.Text;

                    GuardarProductoEditado();
                }

            }
        }
    }
}