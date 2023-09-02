using AutoMapper;

public class CidadeMapping : Profile{

public CidadeMapping()
{
    
    CreateMap(typeof(ResponseGenerico<>), typeof(ResponseGenerico<>));
            CreateMap<CidadeDTO, CidadeModel>();
            CreateMap<CidadeModel, CidadeDTO>();


}




}