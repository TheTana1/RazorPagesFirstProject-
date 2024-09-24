var builder = WebApplication.CreateBuilder(args);

ConfigureServices(builder.Services);  //для зависимостей
var app = builder.Build();
Configure(app,app.Environment);

app.Run();

Console.WriteLine("Some text");

void ConfigureServices(IServiceCollection services)
{
    services.AddRazorPages();
}

void Configure(IApplicationBuilder app, IWebHostEnvironment env)
{
    if (env.IsDevelopment())
    {
        app.UseExceptionHandler("/Error");
        app.UseHsts();
    }

    app.UseHttpsRedirection();

    app.UseDefaultFiles();// для того, чтобы запускались по дефолту страницы index
    app.UseStaticFiles(); // для статических файлов в wwwroot
    

    app.UseRouting();// обяз настройка маршрутов для перехода по страничкам
    app.UseEndpoints(endpoints =>
    {

        endpoints.MapGet("/helloЫ", () => "Hello World!");
        endpoints.MapGet("/goodbye", () => "Goodbye World!");
        endpoints.MapRazorPages();
        //обяз для страниц razor
    });


}