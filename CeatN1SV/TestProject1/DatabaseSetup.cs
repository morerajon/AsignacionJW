using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Configuration;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Data.Schema.UnitTesting;

namespace TestProject1
{
    [TestClass()]
    public class DatabaseSetup
    {

        [AssemblyInitialize()]
        public static void InitializeAssembly(TestContext ctx)
        {
            //   Configure la base de datos de prueba según el valor del
            // archivo de configuración
            DatabaseTestClass.TestService.DeployDatabaseProject();
            DatabaseTestClass.TestService.GenerateData();
        }

    }
}
