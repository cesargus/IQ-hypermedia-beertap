﻿using System.Web.Mvc;
using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using IQ.Platform.Framework.WebApi.HelpGen;
using MyHypemediaWebApi.Documentation.Controllers;

namespace MyHypemediaWebApi.Documentation.Installers
{
    public class HelpControllerInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(
                Component.For<IiQApiExplorer>().ImplementedBy<iQApiExplorer>().LifestyleTransient(),
                Component.For<IController>().ImplementedBy<HelpController>().LifestyleTransient()
                );
        }
    }
}
