using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace QueryString_19796703
{
    public partial class QueryString : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnBack_Click(object sender, EventArgs e)
        {
            Response.Redirect
                (
                "ProductionConfirmQueryStrings.aspx" +
                "?ddlCategory=" + ddlCategory.SelectedValue +
				"&ddlSupplier=" + ddlSupplier.SelectedValue +
				"&strProduct=" + txtProduct.Text +
				"&strDescription=" + TextArea1.InnerText +
				"&strImage=" + txtImage.Text +
				"&decPrice=" + txtPrice.Text +
				"&bytNumberInStock=" + txtNumberInStock.Text +
				"&bytNumberOnOrder=" + txtNumberOnOrder.Text +
				"&bytReorderLevel=" + txtReorderLevel.Text
				);
        }
    }
}