using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;

namespace apiPrepTestingFramework.QA.Helpers
{
    public static class ScenarioContextExtensions
    {
        public static void AddUpdate<T>(this ScenarioContext context, string name, T item)
        {
            if (context.ContainsKey(name))
            {
                context.Remove(name);
            }

            context.Add(name, item);
        }
    }
}
