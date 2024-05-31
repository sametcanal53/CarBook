using AutoMapper;
using CarBook.Application.Features.CQRS.Commands.AboutCommands;
using CarBook.Application.Features.CQRS.Commands.BannerCommands;
using CarBook.Application.Features.CQRS.Commands.BrandCommands;
using CarBook.Application.Features.CQRS.Results.AboutResults;
using CarBook.Application.Features.CQRS.Results.BannerResults;
using CarBook.Application.Features.CQRS.Results.BrandResults;
using CarBook.Domain.Entities;

namespace CarBook.Application.Features.AutoMapper
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            // CreateMap<Source, Destination>();
            //About
            CreateMap<About, GetAboutByIdQueryResult>();
            CreateMap<About, GetAboutQueryResult>();
            CreateMap<CreateAboutCommand, About>();
            CreateMap<UpdateAboutCommand, About>();
            CreateMap<RemoveAboutCommand, About>();

            //Banner 
            CreateMap<Banner, GetBannerByIdQueryResult>();
            CreateMap<Banner, GetBannerQueryResult>();
            CreateMap<CreateBannerCommand, Banner>();
            CreateMap<UpdateBannerCommand, Banner>();
            CreateMap<RemoveBannerCommand, Banner>();

            //Brand
            CreateMap<Brand, GetBrandByIdQueryResult>();
            CreateMap<Brand, GetBrandQueryResult>();
            CreateMap<CreateBrandCommand, Brand>();
            CreateMap<UpdateBrandCommand, Brand>();
            CreateMap<RemoveBrandCommand, Brand>();

        }
    }
}
