using Cloudweather.Report.DataAccess;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<WeatherReportDbContext>(
    opts =>
    {
        opts.EnableSensitiveDataLogging();
        opts.EnableDetailedErrors();
        opts.UseNpgsql(builder.Configuration.GetConnectionString("AppDb"));
    },
    ServiceLifetime.Transient);

var app = builder.Build();

//app.MapGet("/observation3/{zip}", async (string zip, [FromQuery] int? days, WeatherReportDbContext db) =>
//{
//    if (days == null || days < 1 || days > 30)
//    {
//        return Results.BadRequest("Please provide a 'days' query parameter between 1 and 30");
//    }
//    var startDate = DateTime.UtcNow - TimeSpan.FromDays(days.Value);
//    var results = await db.WeatherReports
//                    .Where(p => p.ZipCode == zip && p.CreatedOn >= startDate)
//                    .ToListAsync();
//    return Results.Ok(results);
//});

app.Run();
