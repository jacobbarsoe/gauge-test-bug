using System;
using System.Collections.Generic;
using System.Linq;
using FluentAssertions;
using Gauge.CSharp.Lib;
using Gauge.CSharp.Lib.Attribute;

namespace BugGauge
{
    public class StepImplementation
    {
        [Step("Nop")]
        public void Nop()
        {
        }
    }
}
