﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Name_the_project_References_brant_isaiah
{
    internal interface IAutomobile
    {

        public double Speed { get; }

        public int Wheels { get; }

        public string LicensePlate { get; }

        public void Stringify();

    }
}
