var builder = WebApplication.CreateBuilder(args);
{
    builder.Services.AddControllers(); //for dependancy injection and configuration
}

var app = builder.Build();
{
    app.UseHttpsRedirection();
    app.MapControllers();
    app.Run();
}

