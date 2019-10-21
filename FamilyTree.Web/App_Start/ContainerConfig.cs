using System.Web.Mvc;
using Autofac;
using Autofac.Integration.Mvc;
using FamilyTree.ApplicationCore.Interfaces;
using FamilyTree.Data.Data;

namespace FamilyTree.Web.App_Start
{
    public class ContainerConfig
    {
        internal static void RegisterContainer()
        {
            var builder = new ContainerBuilder();

            builder.RegisterControllers(typeof(MvcApplication).Assembly);
            builder.RegisterType<FamilyTreeRepository>()
                .As<IFamilyTreeRepository>()
                //.SingleInstance(); // for InMemoryFamilyTreeRepository
                .InstancePerRequest(); //for sql instance
           builder.RegisterType<FamilyTreeContext>().InstancePerRequest();

            var container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}