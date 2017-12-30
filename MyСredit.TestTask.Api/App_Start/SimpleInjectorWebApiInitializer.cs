using System;
using SimpleInjector;
using SimpleInjector.Integration.WebApi;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SimpleInjector.Lifestyles;
using System.Web.Http;
using MyCredit.TestTask.Services.Interfaces;
using MyCredit.TestTask.Services.Services;
using MyСredit.TestTask.Api.Controllers;

namespace MyСredit.TestTask.Api.App_Start
{
    public static class SimpleInjectorWebApiInitializer
    {
        static readonly Container container;

        static SimpleInjectorWebApiInitializer()
        {
            container = new Container();
        }

        public static void Initialize()
        {
            container.Options.DefaultScopedLifestyle = new AsyncScopedLifestyle();

            container.RegisterWebApiControllers(GlobalConfiguration.Configuration);

            //Register services
            container.RegisterConditional<IGreeter, HelloAllService>(
                c => c.Consumer.ImplementationType == typeof(HelloController));
            container.RegisterConditional<IGreeter, HelloService>(
                c => c.Consumer.ImplementationType == typeof(HiController));

            container.Verify();

            GlobalConfiguration.Configuration.DependencyResolver = new SimpleInjectorWebApiDependencyResolver(container);
        }
    }
}