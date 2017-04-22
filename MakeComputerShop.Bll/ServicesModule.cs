using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using MakeComputerShop.Bll.Services.Impl;
using Module = Autofac.Module;

namespace MakeComputerShop.Bll
{
    public class ServicesModule: Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            Assembly assembly = typeof(ProducentService).GetTypeInfo().Assembly;

            builder.RegisterAssemblyTypes(assembly)
                .Where(t => t.Name.EndsWith("Service"))
                .AsImplementedInterfaces();
        }
    }
}
