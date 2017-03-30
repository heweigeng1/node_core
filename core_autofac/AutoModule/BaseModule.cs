using Autofac;
using core_autofac.Service;

namespace core_autofac.AutoModule
{
    public class BaseModule:Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<MsgService>().As<IMsgService>();
        }
    }
}
