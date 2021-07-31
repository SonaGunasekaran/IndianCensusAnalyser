using System;
using System.Collections.Generic;
using System.Text;

namespace IndianCensusAnalyser
{
    public class StateDataDAO
    {
        public string SNo;
        public string State;
        public string Tin;
        public string StateCode;
        public StateDataDAO(string sno, string state, string Tin, string stateCode)
        {
            this.SNo = sno;
            this.State = state;
            this.Tin = Tin;
            this.StateCode = stateCode;
        }
    }
}
