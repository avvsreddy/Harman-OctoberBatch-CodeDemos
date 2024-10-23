using AutoMapper;
using KnowledgeHubPortal.Domain.DTO;
using KnowledgeHubPortal.Domain.Entities;

namespace KnowledgeHubPortal.Domain.Managers.Mappings
{
    public class AutomapperProfile : Profile
    {
        public AutomapperProfile()
        {
            CreateMap<Category, CategoryCreateDTO>().ReverseMap();
            //CreateMap<CategoryCreateDTO, Category>();

            CreateMap<List<Category>, List<CategoryListDTO>>().ReverseMap();
        }


    }
}
