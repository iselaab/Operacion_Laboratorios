using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace OperacionLaboratorios
{
    public partial class DemostracionDeEquipo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            if (FileUpload1.HasFile)
            {
                string ext = System.IO.Path.GetExtension(FileUpload1.FileName);
                ext = ext.ToLower();

                if(ext==".pptx" || ext==".wav")
                {
                    FileUpload1.SaveAs(Server.MapPath("~/ArchivosCargados/" + FileUpload1.FileName));
                    LblRespuesta.Text = "Archivo cargado con éxito";
                }
                else
                {
                    LblRespuesta.Text = "Seleccione un archivo .pptx o .mp4 a subir";
                }
            }
        
            else
            {
                LblRespuesta.Text = "Seleccione un archivo .pptx o .mp4 a subir";
            }
        }
    }
}