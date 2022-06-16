using System;
using Cloudweather.Report.Config;
using Cloudweather.Report.DataAccess;
using Microsoft.Extensions.Options;

namespace Cloudweather.Report.BusinessLogic
{
	public interface IWeatherReportAggregator
    {
		public Task<WeatherReport> BuildWeeklyReport(string zip, int days);
    }

	public class WeatherReportAggregator : IWeatherReportAggregator
	{
		private readonly IHttpClientFactory _http;
		private readonly ILogger<WeatherReportAggregator> _logger;
		private readonly WeatherDataConfig _weatherDataConfig;
		private readonly WeatherReportDbContext _db;

        public WeatherReportAggregator(
			IHttpClientFactory http,
			ILogger<WeatherReportAggregator> logger,
			IOptions<WeatherDataConfig> weatherConfig,
			WeatherReportDbContext db)
        {
			_http = http;
			_logger = logger;
			_weatherDataConfig = weatherConfig.Value;
			_db = db;
        }

        public Task<WeatherReport> BuildWeeklyReport(string zip, int days)
        {
            throw new NotImplementedException();
        }
    }
}

