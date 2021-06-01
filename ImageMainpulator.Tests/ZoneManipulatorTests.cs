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

        public ZoneManipulator GetManipulator()
        {
            return new ZoneManipulator(20, 20);
        }

        [TestMethod]
        public void SetSizeX()
        {
            var zone = GetManipulator();

            var expectedFalse = zone.SetSizeX(50);

            var expectedTrue = zone.SetSizeX(5);

            Assert.IsFalse(expectedFalse);

            Assert.IsTrue(expectedTrue);
        }

        [TestMethod]
        public void SetSizeY()
        {
            var zone = GetManipulator();

            var expectedFalse = zone.SetSizeY(50);

            var expectedTrue = zone.SetSizeY(5);

            Assert.IsFalse(expectedFalse);

            Assert.IsTrue(expectedTrue);
        }

        [TestMethod]
        public void ShiftPosX()
        {
            var zone = GetManipulator();

            zone.SetSizeX(2);

            var expectedFalse = zone.ShiftPositionX(50);

            var expectedTrue = zone.ShiftPositionX(5);

            Assert.IsFalse(expectedFalse);

            Assert.IsTrue(expectedTrue);
        }

        [TestMethod]
        public void ShiftPosY()
        {
            var zone = GetManipulator();
            
            zone.SetSizeY(2);

            var expectedFalse = zone.ShiftPositionY(50);

            var expectedTrue = zone.ShiftPositionY(5);

            Assert.IsFalse(expectedFalse);

            Assert.IsTrue(expectedTrue);
        }

        [TestMethod]
        public void SetPosX()
        {
            var zone = GetManipulator();

            zone.SetSizeX(2);

            var expectedFalse = zone.SetPositionX(50);

            var expectedTrue = zone.SetPositionX(5);

            Assert.IsFalse(expectedFalse);

            Assert.IsTrue(expectedTrue);
        }

        [TestMethod]
        public void SetPosY()
        {
            var zone = GetManipulator();

            zone.SetSizeY(2);

            var expectedFalse = zone.SetPositionY(50);

            var expectedTrue = zone.SetPositionY(5);

            Assert.IsFalse(expectedFalse);

            Assert.IsTrue(expectedTrue);
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
