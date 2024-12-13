using Autofac;
using System.Reflection;

namespace Jazani.Senace.Reuniones.Infraestructura.Infraestructura.Contextos
{
    public class InfraestructuraAutofacModule : Autofac.Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            base.Load(builder);

            builder.RegisterAssemblyTypes(Assembly.GetExecutingAssembly())
                .AsImplementedInterfaces()
                .InstancePerLifetimeScope();
        }
    }
}
