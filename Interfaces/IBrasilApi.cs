public interface IBrasilApi{


    Task<ResponseGenerico<List<CidadeModel>>> BuscarCidadePorNome(string nome);
    Task<ResponseGenerico<LocalizaModel>> PrevisaoDoTempo(string codigoCidade);



}