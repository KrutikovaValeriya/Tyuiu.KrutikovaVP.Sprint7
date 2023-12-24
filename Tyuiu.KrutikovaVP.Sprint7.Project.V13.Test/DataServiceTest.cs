using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KrutikovaVP.Sprint7.Project.V13.LIb;
namespace Tyuiu.KrutikovaVP.Sprint7.Project.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidSquareSort()
        {
            DataService ds = new DataService();

            object[,] dataTest = new object[2, 4] {{ "Страна1", "Площадь1", 20645, 458},
                                                    {"Страна2", "Площадь2", 20522, 444}};

            object[,] dataWait = new object[2, 4] { { "Страна2", "Площадь2", 20522, 444 },
                                                    { "Страна1", "Площадь1", 20645, 458} };

            CollectionAssert.AreEqual(dataWait, ds.SquareSort(dataTest));
        }
        [TestMethod]
        public void ValidPopulationSort()
        {
            DataService ds = new DataService();

            object[,] dataTest = new object[2, 3] {{ "Страна1", "Площадь1", 4654651},
                                                    {"Страна2", "Площадь2", 1548488} };

            object[,] dataWait = new object[2, 3] { { "Страна2", "Площадь2", 1548488 },
                                                    { "Страна1", "Площадь1", 4654651} };

            CollectionAssert.AreEqual(dataWait, ds.PopulationSort(dataTest));
        }

        [TestMethod]
        public void ValidSearch()
        {
            DataService ds = new DataService();

            object[,] dataTest = new object[2, 3] {{"Страна1", "Площадь1", "да"},
                                                   {"Страна2", "Площадь2", "да"}};

            string[] dataWait = new string[3] { "Страна2", "Площадь2", "да" };

            CollectionAssert.AreEqual(dataWait, ds.Search(dataTest, "Страна2"));
        }

        [TestMethod]
        public void ValidDataStatisticsSum()
        {
            DataService ds = new DataService();

            object[,] dataTest = new object[3, 2] {{"Страна1", "100"},
                                                   {"Страна2", "200"},
                                                   {"Страна3", "50"}};

            double dataWait = 350;

            string command = "sum";
            int column = 1;

            Assert.AreEqual(dataWait, ds.DataStatistics(dataTest, command, column));
        }

        [TestMethod]
        public void ValidDataStatisticsMin()
        {
            DataService ds = new DataService();

            object[,] dataTest = new object[3, 2] {{"Страна1", "100"},
                                                   {"Страна2", "200"},
                                                   {"Страна3", "50"}};

            double dataWait = 50;

            string command = "min";
            int column = 1;

            Assert.AreEqual(dataWait, ds.DataStatistics(dataTest, command, column));
        }

        [TestMethod]
        public void ValidDataStatisticsMax()
        {
            DataService ds = new DataService();

            object[,] dataTest = new object[3, 2] {{"Страна1", "100"},
                                                   {"Страна2", "200"},
                                                   {"Страна3", "50"}};

            double dataWait = 200;

            string command = "max";
            int column = 1;

            Assert.AreEqual(dataWait, ds.DataStatistics(dataTest, command, column));
        }

        [TestMethod]
        public void ValidDataStatisticsAvarage()
        {
            DataService ds = new DataService();

            object[,] dataTest = new object[3, 2] {{"Страна1", "100"},
                                                   {"Страна2", "200"},
                                                   {"Страна3", "50"}};

            double dataWait = 116.67;

            string command = "avarage";
            int column = 1;

            Assert.AreEqual(dataWait, ds.DataStatistics(dataTest, command, column));
        }




    }
}
