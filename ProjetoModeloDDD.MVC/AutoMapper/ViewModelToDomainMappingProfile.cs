using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using ProjetoModeloDDD.Domain.Entities;
using ProjetoModeloDDD.MVC.ViewModels;

namespace ProjetoModeloDDD.MVC.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public override string ProfileName => "DomainToViewModelMappings";

        protected void Configure()
        {
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<Cliente, ClienteViewModel>();
            });

            IMapper mapper = config.CreateMapper();
            var source = new Cliente();
            var dest = mapper.Map<Cliente, ClienteViewModel>(source);
        }
    }
}