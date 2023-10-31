using System;
using System.Text;
using System.Data;
using System.Data.Common;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Data.Schema.UnitTesting;
using Microsoft.Data.Schema.UnitTesting.Conditions;

namespace TestProject1
{
    [TestClass()]
    public class DatabaseUnitTest1 : DatabaseTestClass
    {

        public DatabaseUnitTest1()
        {
            InitializeComponent();
        }

        [TestInitialize()]
        public void TestInitialize()
        {
            base.InitializeTest();
        }
        [TestCleanup()]
        public void TestCleanup()
        {
            base.CleanupTest();
        }

        [TestMethod()]
        public void DatabaseTest1()
        {
            DatabaseTestActions testActions = this.DatabaseTest1Data;
            // Ejecutar script previo a la prueba
            // 
            System.Diagnostics.Trace.WriteLineIf((testActions.PretestAction != null), "Ejecutando script previo a la prueba...");
            ExecutionResult[] pretestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PretestAction);
            // Ejecutar script de prueba
            // 
            System.Diagnostics.Trace.WriteLineIf((testActions.TestAction != null), "Ejecutando script de prueba...");
            ExecutionResult[] testResults = TestService.Execute(this.ExecutionContext, this.PrivilegedContext, testActions.TestAction);
            // Ejecutar script posterior a la prueba
            // 
            System.Diagnostics.Trace.WriteLineIf((testActions.PosttestAction != null), "Ejecutando script posterior a la prueba...");
            ExecutionResult[] posttestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PosttestAction);
        }

        #region Código de soporte del diseñador

        /// <summary> 
        /// Método necesario para la compatibilidad con el diseñador. No modifique 
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.DatabaseTest1Data = new Microsoft.Data.Schema.UnitTesting.DatabaseTestActions();
            // 
            // DatabaseTest1Data
            // 
            this.DatabaseTest1Data.PosttestAction = null;
            this.DatabaseTest1Data.PretestAction = null;
            this.DatabaseTest1Data.TestAction = null;
        }

        #endregion


        #region Atributos de prueba adicionales
        //
        // Puede usar los siguientes atributos adicionales conforme escribe las pruebas:
        //
        // Use ClassInitialize para ejecutar el código antes de ejecutar la primera prueba en la clase
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup para ejecutar el código después de haberse ejecutado todas las pruebas en una clase
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        #endregion

        private DatabaseTestActions DatabaseTest1Data;
    }
}
