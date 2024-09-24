var builder = WebApplication.CreateBuilder(args);

ConfigureServices(builder.Services);  //��� ������������
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

    app.UseDefaultFiles();// ��� ����, ����� ����������� �� ������� �������� index
    app.UseStaticFiles(); // ��� ����������� ������ � wwwroot
    

    app.UseRouting();// ���� ��������� ��������� ��� �������� �� ����������
    app.UseEndpoints(endpoints =>
    {

        endpoints.MapGet("/hello�", () => "Hello World!");
        endpoints.MapGet("/goodbye", () => "Goodbye World!");
        endpoints.MapRazorPages();
        //���� ��� ������� razor
    });


}