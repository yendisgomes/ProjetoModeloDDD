using AutoMapper;
using ProjetoModeloDDD.Domain.Entities;
using ProjetoModeloDDD.MVC.ViewModels;

namespace ProjetoModeloDDD.MVC.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public override string ProfileName => "ViewModelToDomainMappings";

        protected void Configure()
        {
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<ClienteViewModel, Cliente>();
            });

            IMapper mapper = config.CreateMapper();
            var source = new ClienteViewModel();
            var dest = mapper.Map<ClienteViewModel, Cliente>(source);
        }
    }
}