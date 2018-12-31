﻿using MathNet.Numerics.LinearAlgebra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenComplexMultiAgentSimulator
{
    class AgentBase
    {
        int AgentID { get; set; }
        Vector<double> PosVector { get; set; }
    }
}