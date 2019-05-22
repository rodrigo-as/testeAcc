using ACC.Fundos.Business.Service.Interface;
using ACC.Fundos.Business.Service;
using System.Web.Http;
using Unity;
using Unity.Lifetime;
using Unity.WebApi;
using ACC.Fundos.Business.Integration.CVM.Interface;
using ACC.Fundos.Business.Integration.CVM;
using ACC.Fundos.Business.Mapping.Interface;
using ACC.Fundos.Business.Mapping;
using ACC.Fundos.Business.Repository;
using ACC.Fundos.Data.Repository;

namespace ACC.Fundos.WebApi
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            // Services
            container.RegisterType<IFundosService, FundosService>(new HierarchicalLifetimeManager());

            //Integration
            container.RegisterType<IIntegracaoCVM, IntegracaoCVM>(new HierarchicalLifetimeManager());

            // Repositories
            container.RegisterType<IFundosRepository, FundosRepository>(new HierarchicalLifetimeManager());
            
            // Mapping
            container.RegisterType<IFundosMapper, FundosMapper>(new HierarchicalLifetimeManager());
            

            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }
    }
}