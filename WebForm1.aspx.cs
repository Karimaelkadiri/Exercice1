using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Exercice1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_PreRender(object sender, EventArgs e)
        {
            chkReadOnly.Checked = txtMultiLigne.ReadOnly;
            chkWrap.Checked = txtMultiLigne.Wrap;
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = "label simple";
            Label2.Text = "Label sophistiqué";
            Literal1.Text = "Je suis lr letirale";
            Literal2.Text = " je suis <b> le letirale rusé </b>";
        }

        protected void txtPasAuto_TextChanged(object sender, EventArgs e)
        {
            lblPasAuto.Text = txtPasAuto.Text;
        }

        protected void txtAuto_TextChanged(object sender, EventArgs e)
        {
            LabellblAuto.Text = txtAuto.Text;
        }

        protected void chkWrap_CheckedChanged(object sender, EventArgs e)
        {
            txtMultiLigne.Wrap = chkWrap.Checked;
        }

        protected void chkReadOnly_CheckedChanged(object sender, EventArgs e)
        {
            txtMultiLigne.ReadOnly = chkReadOnly.Checked;
        }
    }
}