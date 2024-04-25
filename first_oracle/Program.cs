
using Oracle.ManagedDataAccess.Client;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run(async (context) =>
{
    //Demo: Basic ODP.NET Core application for ASP.NET Core
    // to connect, query, and return results to a web page

    //Create a connection to Oracle			
    string conString = "User Id=hr;Password=hr;" +

    //How to connect to an Oracle DB without SQL*Net configuration file
    //  also known as tnsnames.ora.
    "Data Source=localhost:1521/orcl;";

    //How to connect to an Oracle DB with a DB alias.
    //Uncomment below and comment above.
    //"Data Source=<service name alias>;";

    using (OracleConnection con = new OracleConnection(conString))
    {
        using (OracleCommand cmd = con.CreateCommand())
        {
            try
            {
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
