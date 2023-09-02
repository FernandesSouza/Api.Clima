using System.Net;
using Microsoft.AspNetCore.Mvc;

namespace Teste.API.Controllers;

[ApiController]
[Route("api/v1/[controller]")]
public class CidadeController : ControllerBase{

private readonly ICidade _cidade;

    public CidadeController(ICidade cidade)
    {
        _cidade = cidade;
    }

    [HttpGet("buscar/{nome}")]
    public async Task<ActionResult> BuscarPorNome([FromRoute] string nome){


        var response = await _cidade.BuscarCidadePorNome(nome);

         if(response.CodigoHttp == HttpStatusCode.OK){


                return Ok(response.DadosRetorno);

            } else {

                return StatusCode((int)response.CodigoHttp, response.ErroRetorno);


            }


    }

}