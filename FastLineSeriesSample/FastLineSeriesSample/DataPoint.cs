using System;
using System.Diagnostics;

namespace FastLineSeriesSample
{
    [DebuggerDisplay("{DebuggerDisplay,nq}")]
    public class DataPoint
    {
        public DataPoint(DateTime dateTime, double? value)
        {
            DateTime = dateTime;
            Value = value;
        }

        public DateTime DateTime { get; }

        public double? Value { get; }

        public string DebuggerDisplay => $"{DateTime} | {Value}";
    }
}

