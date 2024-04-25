using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace secocnd
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddRazorPages();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages();
            });
            app.Run(async (context) =>
            {
                //Demo: Basic ODP.NET Core application for ASP.NET Core
                // to connect, query, and return results to a web page

                //Create a connection to Oracle			
                string conString = "User Id=hr;Password=hr;" +

                //How to connect to an Oracle DB without SQL*Net configuration file
                //  also known as tnsnames.ora.
                "Data Source=orclpdb;";

                //How to connect to an Oracle DB with a DB alias.
                //Uncomment below and comment above.
                //"Data Source=<service name alias>;";

                using (OracleConnection con = new OracleConnection(conString))
                {
                    using (OracleCommand cmd = con.CreateCommand())
                    {
                        try
                        {
                            // This sample demonstrates how to use ODP.NET Core Configuration API

                            // Add connect descriptors and net service names entries.
                            OracleConfiguration.OracleDataSources.Add("orclpdb", "(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=<hostname or IP>)(PORT=1521))(CONNECT_DATA=(SERVICE_NAME=<service name>)(SERVER=dedicated)))");
                            OracleConfiguration.OracleDataSources.Add("orcl", "(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=<hostname or IP>)(PORT=1521))(CONNECT_DATA=(SERVICE_NAME=<service name>)(SERVER=dedicated)))");

                            // Set default statement cache size to be used by all connections.
                            OracleConfiguration.StatementCacheSize = 25;

                            // Disable self tuning by default.
                            OracleConfiguration.SelfTuning = false;

                            // Bind all parameters by name.
                            OracleConfiguration.BindByName = true;

                            // Set default timeout to 60 seconds.
                            OracleConfiguration.CommandTimeout = 60;

                            // Set default fetch size as 1 MB.
                            OracleConfiguration.FetchSize = 1024 * 1024;

                            // Set tracing options
                            OracleConfiguration.TraceOption = 1;
                            OracleConfiguration.TraceFileLocation = @"D:\traces";
                            // Uncomment below to generate trace files
                            //OracleConfiguration.TraceLevel = 7;

                            // Set network properties
                            OracleConfiguration.SendBufferSize = 8192;
                            OracleConfiguration.ReceiveBufferSize = 8192;
                            OracleConfiguration.DisableOOB = true;



                            con.Open();
                            cmd.BindByName = true;

                            //Use the command to display employee names from 
                            // the EMPLOYEES table
                            cmd.CommandText = "select first_name from employees where department_id = :id";

                            // Assign id to the department number 50 
                            OracleParameter id = new OracleParameter("id", 50);
                            cmd.Parameters.Add(id);

                            //Execute the command and use DataReader to display the data
                            OracleDataReader reader = cmd.ExecuteReader();
                            while (reader.Read())
                            {
                                await context.Response.WriteAsync("Employee First Name: " + reader.GetString(0) + "\n");
                            }

                            reader.Dispose();
                        }
                        catch (Exception ex)
                        {
                            await context.Response.WriteAsync(ex.Message);
                        }
                    }
                }

            });
        }
    }
}
