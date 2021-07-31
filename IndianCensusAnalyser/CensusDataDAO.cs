using System;
using System.Collections.Generic;
using System.Text;

namespace IndianCensusAnalyser
{
   public class CensusDataDAO
    {
        public string State;
        public string Population;
        public string Area;
        public string Density;

        public CensusDataDAO(string State, string Population, string Area, string Density)
        {
            this.State = State;
            this.Population = Population;
            this.Area = Area;
            this.Density = Density;
        }
    }
}
