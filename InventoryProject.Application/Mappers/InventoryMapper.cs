using AutoMapper;
using System;

namespace InventoryProject.Application.Mappers
{
    public class InventoryMapper
    {
        private static readonly Lazy<IMapper> Lazy = new(() => 
        {
            var config = new MapperConfiguration(cfg =>
            {
               cfg.ShouldMapProperty = p => p.GetMethod.IsPublic || p.GetMethod.IsAssembly;
               cfg.AddProfile<CategoryMappingProfile>();
            });
            var mapper = config.CreateMapper();
            return mapper;
        });

        public static IMapper Mapper => Lazy.Value;
    }
}
