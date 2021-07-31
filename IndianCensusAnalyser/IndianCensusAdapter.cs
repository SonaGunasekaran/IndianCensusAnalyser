using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace IndianCensusAnalyser
{
    public class IndianCensusAdapter : CensusAdapter
    {
        string[] censusData;
        Dictionary<string, CensusDTO> dataMap;
        public Dictionary<string, CensusDTO> LoadCensusData(string csvFilePath, string dataHeader)
        {
            dataMap = new Dictionary<string, CensusDTO>();
            censusData = GetCensusData(csvFilePath, dataHeader);
            foreach (string data in censusData.Skip(1))
            {
                if (!data.Contains(","))
                  throw new CensusAnalyserException("File contains invalid Delimiter", CensusAnalyserException.ExceptionType.INCORRECT_DELIMITER);
                string[] column = data.Split(",");
                if (csvFilePath.Contains("StateCensusData.csv"))
                    dataMap.Add(column[0], new CensusDTO(new CensusDataDAO(column[0], column[1], column[2], column[3])));
                if (csvFilePath.Contains("IndianStateCode.csv"))
                    dataMap.Add(column[1], new CensusDTO(new StateDataDAO(column[0], column[1], column[2], column[3])));
            }
            return dataMap;
        }
    }
}
