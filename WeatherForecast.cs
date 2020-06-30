using System;

namespace testgit
{
    public class WeatherForecast
    {
        public DateTime Date2333 { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        public string Summary { get; set; }

        public string Grade {get; set; }

        public int Salary {get; set; }
		
		public int Salary2 {get; set; }
    }
}
