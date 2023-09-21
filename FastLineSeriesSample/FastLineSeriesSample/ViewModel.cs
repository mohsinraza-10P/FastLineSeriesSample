using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace FastLineSeriesSample
{
	public class ViewModel
    {
        public List<DataPoint> DataPointsSource { get; private set; }

        public ViewModel()
		{
            var now = DateTime.Now;
            var startDate = new DateTime(now.Year, now.Month, now.Day, 0, 0, 0);
            DataPointsSource = GenerateDataSource(startDate, 24);
        }

        private List<DataPoint> GenerateDataSource(DateTime startDate, int numberOfHours)
        {
            var rand = new Random();
            var multiplier = 5;
            var dataPoints = new List<DataPoint>();

            for (int i = 0; i <= numberOfHours; i++)
            {
                if (i == 0)
                {
                    continue;
                }

                var value = multiplier * rand.Next(10, 40) * 0.25;
                var dp = new DataPoint(startDate.AddHours(i), value);
                dataPoints.Add(dp);
            }

            dataPoints.Insert(0, new DataPoint(startDate, null));

            foreach (var dp in dataPoints)
            {
                Debug.WriteLine($"DataPoint = {dp.DebuggerDisplay}");
            }

            return dataPoints;
        }
    }
}

