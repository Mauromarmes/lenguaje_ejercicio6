using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ejercicio6
{
    public partial class ejercio6 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            double presupuesto, vlrgine, vlrtrau, vlrpedia;
            presupuesto = Convert.ToDouble(txtpresu.Text);
            vlrgine = presupuesto /.40;
            vlrtrau = presupuesto / .30;
            vlrpedia = presupuesto / .30;

            lblgine.Text = System.Convert.ToString(vlrgine);
            lbltrau.Text = System.Convert.ToString(vlrtrau);
            lblpedia.Text = System.Convert.ToString(vlrpedia);

        }
    }
}