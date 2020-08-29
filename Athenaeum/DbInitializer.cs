using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Athenaeum
{
    public class DbInitializer
    {
        public static void Initialize(MyDbContext context, IServiceProvider services)
        {
            var logger = services.GetRequiredService<ILogger<DbInitializer>>();

            context.Database.EnsureCreated();
            //    var stars = File.ReadLines(@"StarData.csv").Select(a => a.Split(';'));
            //     logger.LogInformation(stars.ToString());

            if (context.Books.Any() && context.Users.Any())
            {
                logger.LogInformation("Db already seeded");
                return;
            }

        }
    }
}
