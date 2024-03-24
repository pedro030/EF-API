using AutoMapper;

namespace API.Dependencies
{
    public static class AutoMapperDependencyInjection
    {
        public static IServiceCollection AgregarAutoMapper(this IServiceCollection services)
        {
            // Auto Mapper Configurations
            var mappingConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new PersonaDtoMappingProfile());
            });

            var mapper = mappingConfig.CreateMapper();

            return services.AddSingleton(mapper);
        }
    }
}
