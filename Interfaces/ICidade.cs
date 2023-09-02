public interface ICidade{



        Task<ResponseGenerico<List<CidadeModel>>> BuscarCidadePorNome(string nome);



}