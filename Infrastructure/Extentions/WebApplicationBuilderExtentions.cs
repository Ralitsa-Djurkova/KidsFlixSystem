namespace KidsFlixSystem.Web.Infrastructure.Extentions
{
    using Microsoft.Extensions.DependencyInjection;
    
    using System.Reflection;

    public static class WebApplicationBuilderExtentions
    {
        /// <summary>
        /// This method registers all services with their interfaces and implementations of given assembly.
        /// </summary>
        /// <param name="serviceType"></param>
        /// 
        /// <exception cref="InvalidOperationException"></exception>
        public static void AddApplicationServices(this IServiceCollection services, Type serviceType)
        {
            Assembly serviceAccembly = Assembly.GetAssembly(serviceType);

            if(serviceAccembly == null)
            {
                throw new InvalidOperationException("Invalid service type provider");
            }
            Type[] serviceTypes = serviceAccembly
                .GetTypes()
                .Where(t => t.Name.EndsWith("Service") && !t.IsInterface)
                .ToArray();

            foreach(Type type in serviceTypes)
            {
                Type? interfaceType = type.GetInterface($"{type.Name}");
                if(interfaceType == null)
                {
                    throw new InvalidOperationException($"No interface is provided for the service with name:{type.Name}");
                }

                services.AddScoped(interfaceType, type);
            }

            //services.AddScoped<IMovieService, MovieService>();
        }
    }
}
