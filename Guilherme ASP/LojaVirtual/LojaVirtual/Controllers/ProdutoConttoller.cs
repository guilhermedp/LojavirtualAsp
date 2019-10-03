using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LojaVirtual.Controllers
{
    public class ProdutoConttoller : Controller
    {
        /*
         * ActionResult
         * IActionResul.
         * 
         */
        public ActionResult Visualizar()
        {
            return  new ContentResult() { Content =  "<h3> Produto - > Visualiza</h3>",ContentType = "text/html" };
        }
    }

}
