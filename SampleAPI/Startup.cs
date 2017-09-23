﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using SampleAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace SampleAPI
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            //  To be corrected later when DB is creeated
            services.AddDbContext<SampleAPIContext>(opt => opt.UseInMemoryDatabase("RETAIL_DB"));
            services.AddMvc();
        }

        public void Configure(IApplicationBuilder app)
        {
            app.UseMvc();
        }
    }
}
