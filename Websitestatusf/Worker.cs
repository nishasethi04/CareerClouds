using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace Websitestatusf
{
    public class Worker : BackgroundService
    {
        private readonly ILogger<Worker> _logger;
        private  HttpClient client;

        public Worker(ILogger<Worker> logger)
        {
            _logger = logger;
        }
        public override Task StartAsync(CancellationToken cancellationToken)
        {
            client = new HttpClient();

            return base.StartAsync(cancellationToken);
        }
        public override Task StopAsync(CancellationToken cancellationToken)
        {
            client.Dispose();
            return base.StopAsync(cancellationToken);
        }
        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            var result = await client.GetAsync("https://www.google.com");
            if(result.IsSuccessStatusCode)
            {

                _logger.LogInformation("The website is up and status code={StatusCode}",result.StatusCode);


            }
            else
            {
                _logger.LogError("The website is down and status code={StatusCode}", result.StatusCode);
            }
            while (!stoppingToken.IsCancellationRequested)
            {
               
                await Task.Delay(5000, stoppingToken);
            }
        }
    }
}
