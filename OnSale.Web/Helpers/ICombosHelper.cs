using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace OnSale.Web.Helpers
{
    public interface ICombosHelper
    {
        IEnumerable<SelectListItem> GetComboCategories();// metodo que retorna la informacion del combo
    }

}
