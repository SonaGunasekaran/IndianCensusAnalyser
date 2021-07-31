using System;
using System.Collections.Generic;
using System.Text;

namespace IndianCensusAnalyser
{
    public class CensusDTO
    {
        public string SNo;
        public string State;
        public string Tin;
        public string StateCode;
        public string Population;
        public string Area;
        public string Density;

        public CensusDTO(StateDataDAO stateCodeData)
        {
            this.SNo = stateCodeData.SNo;
            this.State = stateCodeData.State;
            this.Tin = stateCodeData.Tin;
            this.StateCode = stateCodeData.StateCode;
        }

        public CensusDTO(CensusDataDAO censusDataDAO)
        {
            this.State = censusDataDAO.State;
            this.Population = censusDataDAO.Population;
            this.Area = censusDataDAO.Area;
            this.Density = censusDataDAO.Density;
        }

    }
}
