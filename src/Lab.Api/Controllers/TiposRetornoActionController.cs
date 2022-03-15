using Microsoft.AspNetCore.Mvc;

namespace Lab.Api.Controllers
{
    public record MinhaClasse(string Nome);

    public class TiposRetornoActionController : Controller
    {
        public string RetornoTipoPrimitivo()
        {
            if (DateTime.Now == new DateTime(2022, 1, 20))
            {
                //return BadRequest(); // -> Erro CS0029 Cannot implicitly convert type 'Microsoft.AspNetCore.Mvc.BadRequestResult' to 'string'
                return "badrequest";
            }

            return DateTime.Now.ToString();
        }
        public MinhaClasse RetornoTipoComplexo()
        {
            if (DateTime.Now == new DateTime(2022, 1, 20))
            {
                //return BadRequest(); // -> Erro CS0029  Cannot implicitly convert type 'Microsoft.AspNetCore.Mvc.BadRequestResult' to 'Lab.Api.Controllers.MinhaClasse'
                return new("badrequest");
            }

            return new("Pedro");
        }
        public ActionResult<string> RetornoActionResultTipoPrimitivo()
        {
            if (DateTime.Now == new DateTime(2022, 1, 20))
                return BadRequest();

            return DateTime.Now.ToString();
        }
        public ActionResult<MinhaClasse> RetornoActionResultTipoComplexo()
        {
            if (DateTime.Now == new DateTime(2022, 1, 20))
                return BadRequest();

            var retorno = new MinhaClasse("Pedro");
            return Ok(retorno);
        }
    }
}
