using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ValveLibraryTest
{
    [TestClass]
    public class ValveLibraryTest
    {
        [TestMethod]
        public void CheckAccuracyFor50PercentOf100Identifiers()
        {
            int delta = 10;
            int sampledCount = 0;
            int percentEnabled = 50;
            int datasetSize = 100;
            for (int i = 0; i < datasetSize; i++)
            {
                String identifier = Guid.NewGuid().ToString();
                sampledCount = Valve.Valve.Control(identifier, percentEnabled) ? sampledCount + 1 : sampledCount;
            }
            double sampledPercent = ((double)sampledCount / datasetSize) * 100.0;
            Assert.AreEqual(percentEnabled, sampledPercent, delta);
        }


        [TestMethod]
        public void CheckAccuracyFor100PercentOf100Identifiers()
        {
            int delta = 0;
            int sampledCount = 0;
            int percentEnabled = 100;
            int datasetSize = 100;
            for (int i = 0; i < datasetSize; i++)
            {
                String identifier = Guid.NewGuid().ToString();
                sampledCount = Valve.Valve.Control(identifier, percentEnabled) ? sampledCount + 1 : sampledCount;
            }
            double sampledPercent = ((double)sampledCount / datasetSize) * 100.0;
            Assert.AreEqual(percentEnabled, sampledPercent, delta);
        }

        [TestMethod]
        public void CheckAccuracyFor1PercentOf1000Identifiers()
        {
            int sampledCount = 0;
            int percentEnabled = 1;
            int datasetSize = 1000;
            for (int i = 0; i < datasetSize; i++)
            {
                String identifier = Guid.NewGuid().ToString();
                sampledCount = Valve.Valve.Control(identifier, percentEnabled) ? sampledCount + 1 : sampledCount;
            }
            double sampledPercent = ((double)sampledCount / datasetSize) * 100.0;
            Assert.AreEqual(percentEnabled, sampledPercent, 5.0);
        }

        [TestMethod]
        public void CheckAccuracyFor10PercentOf1000Identifiers()
        {
            int sampledCount = 0;
            int percentEnabled = 10;
            int datasetSize = 1000;
            for (int i = 0; i < datasetSize; i++)
            {
                String identifier = Guid.NewGuid().ToString();
                sampledCount = Valve.Valve.Control(identifier, percentEnabled) ? sampledCount + 1 : sampledCount;
            }
            double sampledPercent = ((double)sampledCount / datasetSize) * 100.0;
            Assert.AreEqual(percentEnabled, sampledPercent, 5.0);
        }

        [TestMethod]
        public void CheckAccuracyFor25PercentOf1000Identifiers()
        {
            int sampledCount = 0;
            int percentEnabled = 25;
            int datasetSize = 1000;
            for (int i = 0; i < datasetSize; i++)
            {
                String identifier = Guid.NewGuid().ToString();
                sampledCount = Valve.Valve.Control(identifier, percentEnabled) ? sampledCount + 1 : sampledCount;
            }
            double sampledPercent = ((double)sampledCount / datasetSize) * 100.0;
            Assert.AreEqual(percentEnabled, sampledPercent, 5.0);
        }

        [TestMethod]
        public void CheckAccuracyFor50PercentOf1000Identifiers()
        {
            int sampledCount = 0;
            int percentEnabled = 50;
            int datasetSize = 1000;
            for (int i = 0; i < datasetSize; i++)
            {
                String identifier = Guid.NewGuid().ToString();
                sampledCount = Valve.Valve.Control(identifier, percentEnabled) ? sampledCount + 1 : sampledCount;
            }
            double sampledPercent = ((double)sampledCount / datasetSize) * 100.0;
            Assert.AreEqual(percentEnabled, sampledPercent, 5.0);
        }

        [TestMethod]
        public void CheckAccuracyFor75PercentOf1000Identifiers()
        {
            int sampledCount = 0;
            int percentEnabled = 75;
            int datasetSize = 1000;
            for (int i = 0; i < datasetSize; i++)
            {
                String identifier = Guid.NewGuid().ToString();
                sampledCount = Valve.Valve.Control(identifier, percentEnabled) ? sampledCount + 1 : sampledCount;
            }
            double sampledPercent = ((double)sampledCount / datasetSize) * 100.0;
            Assert.AreEqual(percentEnabled, sampledPercent, 5.0);
        }

        [TestMethod]
        public void CheckAccuracyFor100PercentOf1000Identifiers()
        {
            int sampledCount = 0;
            int percentEnabled = 100;
            int datasetSize = 1000;
            for (int i = 0; i < datasetSize; i++)
            {
                String identifier = Guid.NewGuid().ToString();
                sampledCount = Valve.Valve.Control(identifier, percentEnabled) ? sampledCount + 1 : sampledCount;
            }
            double sampledPercent = ((double)sampledCount / datasetSize) * 100.0;
            Assert.AreEqual(percentEnabled, sampledPercent, 0.0);
        }

        [TestMethod]
        public void CheckAccuracyFor1PercentOf10000Identifiers()
        {
            int sampledCount = 0;
            int percentEnabled = 1;
            int datasetSize = 10000;
            for (int i = 0; i < datasetSize; i++)
            {
                String identifier = Guid.NewGuid().ToString();
                sampledCount = Valve.Valve.Control(identifier, percentEnabled) ? sampledCount + 1 : sampledCount;
            }
            double sampledPercent = ((double)sampledCount / datasetSize) * 100.0;
            Assert.AreEqual(percentEnabled, sampledPercent, 2.0);
        }

        [TestMethod]
        public void CheckAccuracyFor10PercentOf10000Identifiers()
        {
            int sampledCount = 0;
            int percentEnabled = 10;
            int datasetSize = 10000;
            for (int i = 0; i < datasetSize; i++)
            {
                String identifier = Guid.NewGuid().ToString();
                sampledCount = Valve.Valve.Control(identifier, percentEnabled) ? sampledCount + 1 : sampledCount;
            }
            double sampledPercent = ((double)sampledCount / datasetSize) * 100.0;
            Assert.AreEqual(percentEnabled, sampledPercent, 2.0);
        }

        [TestMethod]
        public void CheckAccuracyFor25PercentOf10000Identifiers()
        {
            int sampledCount = 0;
            int percentEnabled = 25;
            int datasetSize = 10000;
            for (int i = 0; i < datasetSize; i++)
            {
                String identifier = Guid.NewGuid().ToString();
                sampledCount = Valve.Valve.Control(identifier, percentEnabled) ? sampledCount + 1 : sampledCount;
            }
            double sampledPercent = ((double)sampledCount / datasetSize) * 100.0;
            Assert.AreEqual(percentEnabled, sampledPercent, 2.0);
        }

        [TestMethod]
        public void CheckAccuracyFor50PercentOf10000Identifiers()
        {
            int sampledCount = 0;
            int percentEnabled = 50;
            int datasetSize = 10000;
            for (int i = 0; i < datasetSize; i++)
            {
                String identifier = Guid.NewGuid().ToString();
                sampledCount = Valve.Valve.Control(identifier, percentEnabled) ? sampledCount + 1 : sampledCount;
            }
            double sampledPercent = ((double)sampledCount / datasetSize) * 100.0;
            Assert.AreEqual(percentEnabled, sampledPercent, 2.0);
        }

        [TestMethod]
        public void CheckAccuracyFor75PercentOf10000Identifiers()
        {
            int sampledCount = 0;
            int percentEnabled = 75;
            int datasetSize = 10000;
            for (int i = 0; i < datasetSize; i++)
            {
                String identifier = Guid.NewGuid().ToString();
                sampledCount = Valve.Valve.Control(identifier, percentEnabled) ? sampledCount + 1 : sampledCount;
            }
            double sampledPercent = ((double)sampledCount / datasetSize) * 100.0;
            Assert.AreEqual(percentEnabled, sampledPercent, 2.0);
        }

        [TestMethod]
        public void CheckAccuracyFor100PercentOf10000Identifiers()
        {
            int sampledCount = 0;
            int percentEnabled = 100;
            int datasetSize = 10000;
            for (int i = 0; i < datasetSize; i++)
            {
                String identifier = Guid.NewGuid().ToString();
                sampledCount = Valve.Valve.Control(identifier, percentEnabled) ? sampledCount + 1 : sampledCount;
            }
            double sampledPercent = ((double)sampledCount / datasetSize) * 100.0;
            Assert.AreEqual(percentEnabled, sampledPercent, 0.0);
        }
    }
}
