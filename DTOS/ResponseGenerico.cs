using System.Dynamic;
using System.Net;

public class ResponseGenerico<T> where T : class{

                 //Codigo HTTP retornado da API
                public HttpStatusCode CodigoHttp {get; set;}
                 
				// RETORNO DOS DADOS DA AQUISIÇÃO
                public T? DadosRetorno {get; set;}

                //RETORNAR ERRO CONFORME A API EXTERNA
                public ExpandoObject? ErroRetorno{get; set;}

}