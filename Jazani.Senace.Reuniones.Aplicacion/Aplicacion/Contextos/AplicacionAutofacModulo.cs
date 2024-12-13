using Autofac;
using System.Reflection;

namespace Jazani.Senace.Reuniones.Aplicacion.Aplicacion.Contextos
{
    public class AplicacionAutofacModulo : Autofac.Module
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
