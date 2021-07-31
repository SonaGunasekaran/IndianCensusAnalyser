using Microsoft.VisualStudio.TestTools.UnitTesting;
using IndianCensusAnalyser;
using System.Collections.Generic;

namespace CensusAnalyserTest
{
    [TestClass]
    public class UnitTest1
    {
        string stateCensusPath = @"C:\Users\Sona G\source\repos\IndianCensusAnalyser\IndianCensusAnalyser\StateCensusData.csv";
        string wrongPath = @"C:\Users\HP1\source\repos\Lambda\IndianStateCensusAnalyser\TextFile1.txt";
        string wrongFileType = @"C:\Users\Sona G\source\repos\IndianCensusAnalyser\IndianCensusAnalyser\TextFile1.txt";
        string invalidDelimeter = @"C:\Users\Sona G\source\repos\IndianCensusAnalyser\IndianCensusAnalyser\WrongDelimiter.csv";
        
        IndianCensusAnalyser.CensusAdapterFactory csv = null;
        CensusAdapter adapter;
        Dictionary<string,CensusDataDAO> totalRecord;
        string[] record;

        [TestInitialize]
        public void Setup()
        {
            csv = new CensusAdapterFactory();
            adapter = new CensusAdapter();
            totalRecord = new Dictionary<string, CensusDataDAO>();
        }

        //TC 1.1
        [TestMethod]
        public void StateReturnTotalRecord()
        {
            record = adapter.GetCensusData(stateCensusPath, "State,Population,Area,Density");
            int actual = record.Length - 1;
            int expected = 35;
            Assert.AreEqual(actual, expected);
        }
        //TC 1.2
        [TestMethod]
        [TestCategory("CensusAnalyser")]
        public void IncorrectPath()
        {
            try
            {
                var stateRecord = adapter.GetCensusData(wrongPath, "State,Population,Area,Density");

            }
            catch (CensusAnalyserException ex)
            {
                Assert.AreEqual("File Not Found", ex.Message);
            }
        }
        //TC 1.3
        [TestMethod]
        [TestCategory("CensusAnalyser")]
        public void InvalidFile()
        {
            try
            {
                var stateRecord = adapter.GetCensusData(wrongFileType, "State,Population,Area,Density");

            }
            catch (CensusAnalyserException ex)
            {
                Assert.AreEqual("Invalid File Type", ex.Message);
            }
        }
        //TC 1.4
        [TestMethod]
        [TestCategory("CensusAnalyser")]
        public void InvalidDelimeter()
        {
            try
            {
                var stateRecord = adapter.GetCensusData(invalidDelimeter, "State,Population,Area,Density");

            }
            catch (CensusAnalyserException ex)
            {
                Assert.AreEqual("File contains invalid Delimiter", ex.Message);
            }
        }
        //TC 1.5
        [TestMethod]
        [TestCategory("CensusAnalyser")]
        public void IncorrectHeader()
        {
            try
            {
                var stateRecord = adapter.GetCensusData(invalidDelimeter, "State,Population,Area,Density");

            }
            catch (CensusAnalyserException ex)
            {
                Assert.AreEqual("Data header in not matched", ex.Message);
            }
        }
    }
}
