using AutoMapper;

namespace Uspeak.Infrastructure.Mapping
{
    internal static class UspeakMapper
    {
        private static IMapper _innerMapper;

        internal static void Initialize()
        {
            var config = new MapperConfiguration(x => x.AddProfile<UspeakProfile>());
            _innerMapper = config.CreateMapper();
            config.AssertConfigurationIsValid();
        }


        internal static TDestination Map<TSource, TDestination>(this TSource obj) => _innerMapper.Map<TSource, TDestination>(obj);
    }
}
