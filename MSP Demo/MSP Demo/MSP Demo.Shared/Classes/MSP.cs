using System;
using System.Collections.Generic;
using System.Text;

namespace MSP_Demo.Classes
{
    class MSP
    {
        private string _name;
        public string name
        {
            get { return _name; }
            set { _name = value; }
        }

        private string _college;
        public string college
        {
            get { return _college; }
            set { _college = value; }
        }

        public MSP(string nm, string col)
        {
            _name = nm;
            _college = col;
        }
    }
}
