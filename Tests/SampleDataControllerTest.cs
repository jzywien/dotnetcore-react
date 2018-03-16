using System;
using Application.Controllers;
using Xunit;
using System.Linq;

namespace Tests
{
    public class SampleDataControllerTest
    {
        [Fact]
        public void TestCanGetWeatherData()
        {
            SampleDataController controller = new SampleDataController();
            var forecasts = controller.WeatherForecasts(0);

            foreach (var item in forecasts.Select((value, i) => new {i, value}))
            {
                var date = DateTime.Now.AddDays(item.i+1).ToString("d");
                Assert.Equal(item.value.DateFormatted, date);
            }
        }
    }
}
