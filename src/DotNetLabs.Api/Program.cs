using DotNetLabs.Api.Features.CancellationTokenLab;
using DotNetLabs.Api.Features.OptionsPatternLab;
using DotNetLabs.Api.Features.OptionsPatternLab.Services;

var builder = WebApplication.CreateBuilder(args);

#region .: Laboratório CancellationToken :.
builder.Services.AddScoped<CancellationTokenService>();
builder.Services.AddScoped<CancellationTokenRepository>();
#endregion

#region .: Laboratório Options Pattern :.
builder.Services.AddTransient<IProcessamentoConfiguracaoService, ProcessamentoConfiguracaoService>();

builder.Services.Configure<ProcessamentoOptions>(
    builder.Configuration.GetSection(ProcessamentoOptions.Secao));
#endregion

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddCors(options =>
{
    options.AddPolicy("DotNetLabsBlazor", policy =>
    {
        policy
            .WithOrigins("https://localhost:7246", "http://localhost:5089")
            .AllowAnyHeader()
            .AllowAnyMethod();
    });
});

var app = builder.Build();

app.UseCors("DotNetLabsBlazor");

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
