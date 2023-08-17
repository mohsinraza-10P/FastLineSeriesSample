using System;
using System.Collections.Generic;

namespace FastLineSeriesSample
{
	public class ViewModel
    {
        public List<DataPoint> DataPointsSource { get; private set; }

        public ViewModel()
		{
            var now = DateTime.Now;
            var value = 5;

            DataPointsSource = new List<DataPoint>()
            {
                new DataPoint(now, value * 1),
                new DataPoint(now.AddHours(1), value * 1.5),
                new DataPoint(now.AddHours(2), value * 2),
                new DataPoint(now.AddHours(3), value * 2.5),
                new DataPoint(now.AddHours(4), value * 3),
                new DataPoint(now.AddHours(5), value * 3.5),
                new DataPoint(now.AddHours(6), value * 4),
                new DataPoint(now.AddHours(7), value * 4.5),
                new DataPoint(now.AddHours(8), value * 5),
            };
        }
	}
}

