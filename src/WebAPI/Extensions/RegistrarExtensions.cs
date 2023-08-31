using WebAPI.AddServices;

namespace WebAPI.Extensions
{
    public static class RegistrarExtensions
    {
        public static void AddServices(this WebApplicationBuilder builder,Type scanningType)
        {
            var registrars = GetRegistrars<IWebAppliacationBuilderAddServices>(scanningType);

            foreach (var registrar in registrars)
            {
                registrar.AddServices(builder);
            }
        }
        public static void AddServicesPipeline(this WebApplication app, Type scanningType)
        {
            var registrars = GetRegistrars<IWebAppliacationAddServices>(scanningType);
            foreach (var registrar in registrars)
            {
                registrar.AddServicesPipeline(app);
            }
        }

      
        private static IEnumerable<T> GetRegistrars<T>(Type scanningType) where T : IRegistrar
        {
            return scanningType.Assembly.GetTypes()
                .Where(t => t.IsAssignableTo(typeof(T)) && !t.IsAbstract && !t.IsInterface)
                .Select(Activator.CreateInstance)
                .Cast<T>();
        }
    }
}
