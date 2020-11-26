using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OperacionLaboratorios
{
    public partial class Responsabilidad : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSub_Click(object sender, EventArgs e)
        {
            LblRespuesta.Text = "Asegurar la implantacion de la presente instrucción de trabajo en todas las jefaturas de departamento y " +
                "en todos los laboratorios impartidos en las licenciaturas de la FIME";
        }

        protected void btnCoo_Click(object sender, EventArgs e)
        {
            LblRespuesta.Text = "Dar a conocer esta instrucción de trabajo en las jefaturas de Academia, de Laboratorio y de Departamento " +
                "para su implantación, aspi como coordinar y auxiliar en los requerimientos surgidos en los laboratorios de su área.";
        }

        protected void btnInst_Click(object sender, EventArgs e)
        {
            LblRespuesta.Text = "Asistir a las Juntas de Academia, participar en la elaboración de las cartas descriptivas de laboratorio " +
                "en su academia, e implmentar la presente instrucción de trabajo.";
        }

        protected void btnDue_Click(object sender, EventArgs e)
        {
            LblRespuesta.Text = "Contribuir al desarrollo de las buenas técnicas en materia de seguridad y salud ocupacional, previniendo lesiones y envermedades, " +
                "así como fomentar el cuidado del medio ambiente en el desarrollo de las actividades de la comunidad de la FIME, a través de la identificación de " +
                "riesgos respecto a salud y seguridad ocupacional, así como de medio ambiente.";
        }
    }
}