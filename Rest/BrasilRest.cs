using System.Dynamic;
using System.Text.Json;

public class BrasilRest : IBrasilApi{

   public async Task<ResponseGenerico<List<CidadeModel>>> BuscarCidadePorNome(string nome){


    var request = new HttpRequestMessage(HttpMethod.Get, $"https://brasilapi.com.br/api/cptec/v1/cidade/{nome}");

            // defino a variavel para armazenar informações da solicitação
            // new GenericResponse<EnderecoModel>() uma instancia da classe GenericResponse que lida com o tipo EnderecoModel
           var response = new ResponseGenerico<List<CidadeModel>>();

           // esse using cria uma instancia de HttpClient para enviar a solicitação Http para a API BrasilApi processar a resposta e no final ser descartado adequadamente
           using (var client = new HttpClient()){

                //envia a solicitação HTTP definida pelo objeto request para a responseBrasilApi
                var responseBrasilApi = await client.SendAsync(request);
                // responseBrasilApi e lida como uma string e  transformada em texto e armazenada no var contentResp
                var contentResp = await responseBrasilApi.Content.ReadAsStringAsync();

                // o contentResp e desserializado para um objeto do tipo EnderecoModel e armazenado no objResponse
                // Os dados vem da API em Formato JSON
                var objResponse = JsonSerializer.Deserialize<List<CidadeModel>>(contentResp);

                    //IsSuccessStatusCode verifica se foi bem sucedido com base no status Http retornado
                if(responseBrasilApi.IsSuccessStatusCode){

                    // o status do codigo http e retorna para CodigoHttp
                    response.CodigoHttp = responseBrasilApi.StatusCode;
                    //armazena os dados do endereco e retorna para DadosRetorno
                    response.DadosRetorno = objResponse; 

                } else {


                    // o status do codigo http e retorna para CodigoHttp
                    response.CodigoHttp = responseBrasilApi.StatusCode;
                    // desserialização em um objeto ExpandoObject e armazenado no ErroRetorno
                    response.ErroRetorno = JsonSerializer.Deserialize<ExpandoObject>(contentResp);

                }

        
           }
            // retorna o resultado do método 
           return response;




   }

    public async Task<ResponseGenerico<LocalizaModel>> PrevisaoDoTempo(string codigoCidade)
    {

        var request = new HttpRequestMessage(HttpMethod.Get, $"https://brasilapi.com.br/api/cptec/v1/clima/previsao/{codigoCidade}");

            // defino a variavel para armazenar informações da solicitação
            // new GenericResponse<EnderecoModel>() uma instancia da classe GenericResponse que lida com o tipo EnderecoModel
           var response = new ResponseGenerico<LocalizaModel>();

           // esse using cria uma instancia de HttpClient para enviar a solicitação Http para a API BrasilApi processar a resposta e no final ser descartado adequadamente
           using (var client = new HttpClient()){

                //envia a solicitação HTTP definida pelo objeto request para a responseBrasilApi
                var responseBrasilApi = await client.SendAsync(request);
                // responseBrasilApi e lida como uma string e  transformada em texto e armazenada no var contentResp
                var contentResp = await responseBrasilApi.Content.ReadAsStringAsync();

                // o contentResp e desserializado para um objeto do tipo EnderecoModel e armazenado no objResponse
                // Os dados vem da API em Formato JSON
                var objResponse = JsonSerializer.Deserialize<LocalizaModel>(contentResp);

                    //IsSuccessStatusCode verifica se foi bem sucedido com base no status Http retornado
                if(responseBrasilApi.IsSuccessStatusCode){

                    // o status do codigo http e retorna para CodigoHttp
                    response.CodigoHttp = responseBrasilApi.StatusCode;
                    //armazena os dados do endereco e retorna para DadosRetorno
                    response.DadosRetorno = objResponse; 

                } else {


                    // o status do codigo http e retorna para CodigoHttp
                    response.CodigoHttp = responseBrasilApi.StatusCode;
                    // desserialização em um objeto ExpandoObject e armazenado no ErroRetorno
                    response.ErroRetorno = JsonSerializer.Deserialize<ExpandoObject>(contentResp);

                }

        
           }
            // retorna o resultado do método 
           return response;

        
    }

   
}