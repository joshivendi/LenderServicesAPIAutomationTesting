using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;

namespace apiPrepTestingFramework.QA.Framework
{
    public class TestEnvironment
    {
        public static string Location => Assembly.GetExecutingAssembly().Location;

        public static string Directory => Path.GetDirectoryName(Location);
    }
}
