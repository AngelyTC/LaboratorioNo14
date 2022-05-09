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
    public partial class EliminarProducto : System.Web.UI.Page
    {
        static List<Productos> Alimento = new List<Productos>();
        static string codigoProd;
        protected void Page_Load(object sender, EventArgs e)
        {
            string archivop = Server.MapPath("Productos.json");
            StreamReader jsonStreamp = File.OpenText(archivop);
            string jsonp = jsonStreamp.ReadToEnd();
            jsonStreamp.Close();

           Alimento = JsonConvert.DeserializeObject<List<Productos>>(jsonp);

        }


        protected void GuardarProductoBorrado()
        {
            string json = JsonConvert.SerializeObject(Alimento);
            string archivo = Server.MapPath("Productos.json");
            System.IO.File.WriteAllText(archivo, json);
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            codigoProd  = txtCodigo.Text;
            bool encontrar2 = false;

            foreach (var u in Alimento)
            {
                Productos borrar = Alimento.Find(c => c.CodigoP== codigoProd);

                if (borrar != null)
                {
                    txtNombreProducto.Text = borrar.NombreP;
                    txtNombreDescrip.Text = borrar.DescripcionP;
                    encontrar2 = true;
                }
            }
            if (!encontrar2)
            {
                Response.Write("<script>alert('El producto no se ha encotrado')</script>");
                codigoProd = "";
            }
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            foreach (var u in Alimento)
            {
                Productos eliminado = Alimento.Find(c => c.CodigoP == codigoProd);

                if (eliminado != null)
                {
                    Alimento.Remove(eliminado);
                    break;
                }

            }
            GuardarProductoBorrado();
        }
    }
}