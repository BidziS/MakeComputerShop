using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using MakeComputerShop.Dal.Repositories.impl;
using Module = Autofac.Module;

namespace MakeComputerShop.Bll
{
    public class RepositoriesModule:Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            Assembly assembly = typeof(MotherboardRepository).GetTypeInfo().Assembly;

            builder.RegisterAssemblyTypes(assembly)
                .Where(t => t.Name.EndsWith("Repository"))
                .AsImplementedInterfaces();
        }
    }
}
