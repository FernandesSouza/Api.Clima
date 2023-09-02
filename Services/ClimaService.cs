
using AutoMapper;

public class ClimaService : IClima
{
    private readonly IMapper _mapper;
    private readonly IBrasilApi _brasilApi;

    public ClimaService(IMapper mapper, IBrasilApi brasilApi)
    {
        _mapper = mapper;
        _brasilApi = brasilApi;
    }

    public async Task<ResponseGenerico<LocalizaModel>> PrevisaoDoTempo(string codigoCidade)
    {
       var previsao = await _brasilApi.PrevisaoDoTempo(codigoCidade);
        return _mapper.Map<ResponseGenerico<LocalizaModel>>(previsao);
    }
}