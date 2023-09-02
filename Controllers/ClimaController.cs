using System.Net;
using Microsoft.AspNetCore.Mvc;

namespace Teste.API.Controllers;

[ApiController]
[Route("api/v1/[controller]")]
public class ClimaController : ControllerBase{

    private readonly IClima _clima;

    public ClimaController(IClima clima)
    {
        _clima = clima;
    }

    [HttpGet("busca/{codigoCidade}")]
    public async Task<ActionResult> BuscarPrevisao([FromRoute] string codigoCidade){


        var response = await _clima.PrevisaoDoTempo(codigoCidade);
         if(response.CodigoHttp == HttpStatusCode.OK){


                return Ok(response.DadosRetorno);

            } else {

                return StatusCode((int)response.CodigoHttp, response.ErroRetorno);


            }




    }
}