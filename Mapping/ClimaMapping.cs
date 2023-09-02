using AutoMapper;

public class ClimaMapping : Profile{


    public ClimaMapping()
    {
            CreateMap(typeof(ResponseGenerico<>), typeof(ResponseGenerico<>));
            CreateMap<LocalizaDTO, LocalizaModel>();
            CreateMap<LocalizaModel, LocalizaDTO>();
    }


}