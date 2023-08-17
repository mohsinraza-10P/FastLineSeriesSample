using System;

namespace FastLineSeriesSample
{
	public class DataPoint
	{
		public DataPoint(DateTime dateTime, double? value)
        {
            DateTime = dateTime;
            Value = value;
        }

        public DateTime DateTime { get; }

        public double? Value { get; }
    }
}

