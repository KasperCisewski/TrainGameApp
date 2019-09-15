using Autofac;
using Microsoft.Extensions.Configuration;
using TrainQuiz_BackEnd.Ioc.Modules;

namespace TrainQuiz_BackEnd.Ioc
{
    public class ContainerModule : Autofac.Module
    {
        private readonly IConfiguration _configuration;

        public ContainerModule(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterModule<RepositoryModule>();
            builder.RegisterModule<ServiceModule>();
        }
    }
}
