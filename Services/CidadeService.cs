
using AutoMapper;

public class CidadeService : ICidade
{

    private readonly IMapper _mapper;
    private readonly IBrasilApi _brasilApi;

    public CidadeService(IMapper mapper, IBrasilApi brasilApi)
    {
        _mapper = mapper;
        _brasilApi = brasilApi;
    }

    public async Task<ResponseGenerico<List<CidadeModel>>> BuscarCidadePorNome(string nome)
    {

        var cidade = await _brasilApi.BuscarCidadePorNome(nome);
        return _mapper.Map<ResponseGenerico<List<CidadeModel>>>(cidade);

       
    }
}