using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OperacionLaboratorios
{
    public partial class PresentacionDocente : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (FileUpload1.HasFile)
            {
                string ext = System.IO.Path.GetExtension(FileUpload1.FileName);
                ext = ext.ToLower();

                if (ext == ".pdf")
                {
                    FileUpload1.SaveAs(Server.MapPath("~/ArchivosCargados/" + FileUpload1.FileName));
                    LblRespuesta.Text = "Carta cargada con éxito";
                }
                else
                {
                    LblRespuesta.Text = "Seleccione un archivo PDF a subir";
                }
            }

            else
            {
                LblRespuesta.Text = "Seleccione un archivo PDF a subir";
            }

            
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            if (FileUpload2.HasFile)
            {
                string ext = System.IO.Path.GetExtension(FileUpload2.FileName);
                ext = ext.ToLower();

                if (ext == ".pptx")
                {
                    FileUpload2.SaveAs(Server.MapPath("~/ArchivosCargados/" + FileUpload2.FileName));
                    LblRespuesta2.Text = "Presentación cargada con éxito";
                }
                else
                {
                    LblRespuesta2.Text = "Seleccione un archivo .pptx a subir";
                }
            }

            else
            {
                LblRespuesta2.Text = "Seleccione un archivo .pptx a subir";
            }
        }
    }
}