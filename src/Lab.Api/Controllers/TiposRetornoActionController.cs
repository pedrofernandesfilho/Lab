using Microsoft.AspNetCore.Mvc;

namespace Lab.Api.Controllers;

public record MinhaClasse(string Nome);

[ApiController]
[Route("[controller]")]
public class TiposRetornoActionController : Controller
{
    [HttpGet("tipo-primitivo")]
    public string RetornoTipoPrimitivo()
    {
        if (DateTime.Now == new DateTime(2022, 1, 20))
        {
            //return BadRequest(); // -> Erro CS0029 Cannot implicitly convert type 'Microsoft.AspNetCore.Mvc.BadRequestResult' to 'string'
            return "badrequest";
        }

        return DateTime.Now.ToString();
    }

    [HttpGet("tipo-complexo")]
    public MinhaClasse RetornoTipoComplexo()
    {
        if (DateTime.Now == new DateTime(2022, 1, 20))
        {
            //return BadRequest(); // -> Erro CS0029  Cannot implicitly convert type 'Microsoft.AspNetCore.Mvc.BadRequestResult' to 'Lab.Api.Controllers.MinhaClasse'
            return new("badrequest");
        }

        return new("Pedro");
    }

    [HttpGet("tipo-primitivo-action-result")]
    public ActionResult<string> RetornoActionResultTipoPrimitivo()
    {
        if (DateTime.Now == new DateTime(2022, 1, 20))
            return BadRequest();

        return DateTime.Now.ToString();
    }

    [HttpGet("tipo-complexo-action-result")]
    public ActionResult<MinhaClasse> RetornoActionResultTipoComplexo()
    {
        if (DateTime.Now == new DateTime(2022, 1, 20))
            return BadRequest();

        var retorno = new MinhaClasse("Pedro");
        return Ok(retorno);
    }
}
