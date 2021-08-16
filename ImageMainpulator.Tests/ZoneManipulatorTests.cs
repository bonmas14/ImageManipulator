using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace ImageManipulator.Tests
{
    /// <summary>
    /// Сводное описание для UnitTest1
    /// </summary>
    [TestClass]
    public class ZoneManipulatorTests
    {

        public ZoneManipulatorTests()
        {
        }

        private TestContext testContextInstance;

        /// <summary>
        ///Получает или устанавливает контекст теста, в котором предоставляются
        ///сведения о текущем тестовом запуске и обеспечивается его функциональность.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Дополнительные атрибуты тестирования
        //
        // При написании тестов можно использовать следующие дополнительные атрибуты:
        //
        // ClassInitialize используется для выполнения кода до запуска первого теста в классе
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // ClassCleanup используется для выполнения кода после завершения работы всех тестов в классе
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // TestInitialize используется для выполнения кода перед запуском каждого теста 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // TestCleanup используется для выполнения кода после завершения каждого теста
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        public Zone GetManipulator()
        {
            return new Zone(20, 20);
        }

        [TestMethod]
        public void SetSizeX()
        {
            var zone = GetManipulator();

            var a = zone.SetSizeX(50);

            var b = zone.SetSizeX(-5);

            Assert.IsFalse(a || b);
        }

        [TestMethod]
        public void SetSizeY()
        {
            var zone = GetManipulator();

            var a = zone.SetSizeY(50);

            var b = zone.SetSizeY(-5);

            Assert.IsFalse(a || b);
        }

        [TestMethod]
        public void SetPosX()
        {
            var zone = GetManipulator();

            zone.SetSizeX(2);

            var a = zone.SetPositionX(50);

            var b = zone.SetPositionX(-5);

            Assert.IsFalse(a || b);
        }

        [TestMethod]
        public void SetPosY()
        {
            var zone = GetManipulator();

            zone.SetSizeY(2);

            var a = zone.SetPositionY(50);

            var b = zone.SetPositionY(-5);

            Assert.IsFalse(a || b);
        }


        [TestMethod]
        public void GetSize()
        {
            var zone = GetManipulator();

            zone.SetSizeX(5);
            zone.SetSizeY(2);

            var size = zone.GetSize();

            Assert.AreEqual(new Point(5, 2), size);
        }

        [TestMethod]
        public void GetPos()
        {
            var zone = GetManipulator();

            zone.SetPositionX(5);
            zone.SetPositionY(2);

            var size = zone.GetPosition();

            Assert.AreEqual(new Point(5, 2), size);
        }
    }
}
