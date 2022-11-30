using Autofac;
using Microsoft.Extensions.Configuration;
using SpecFlow.Autofac;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace apiPrepTestingFramework.QA.Framework
{
    public static class TestDependencies
    {
        [ScenarioDependencies]
        public static ContainerBuilder CreateScenarioContainerBuilder()
        {
            var builder = new ContainerBuilder();
            builder.RegisterTypes(typeof(TestDependencies).Assembly.GetTypes().Where(TypesAreBindings).ToArray()).SingleInstance();
            builder.RegisterInstance(BuildConfiguration());
            return builder;
        }

        private static IConfiguration BuildConfiguration()
        {
            string environmentName = Environment.GetEnvironmentVariable("EnvironmentName");
            return new ConfigurationBuilder()
                .AddJsonFile(Path.Combine(TestEnvironment.Directory, "appsettings.json"))
                .AddJsonFile(Path.Combine(TestEnvironment.Directory, $"appsettings.{environmentName}.json"))
                .Build();
        }

        private static bool TypesAreBindings(Type type)
        {
            return Attribute.IsDefined(type, typeof(BindingAttribute));
        }
    }
}
