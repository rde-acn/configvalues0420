using ConfigValues;
using CoreWCF.Configuration;
using Microsoft.Extensions.Options;
using System.Configuration;

var builder = WebApplication.CreateBuilder(args);

builder.Services
    .AddServiceModelServices()
    .AddServiceModelMetadata()
    .AddOtherServices(builder.Configuration);

builder.Services.AddTransient<TaskService>();

builder.Services.AddTransient<ChatService>();

builder.Services.AddScoped<AuthenticatorService>();

builder.Services.AddScoped<LoggingService>();

builder.Services.Configure<ChatServiceConfiguration>(builder.Configuration.GetSection("ChatServiceConfiguration"));

builder.Services.Configure<AuthServiceConfiguration>(builder.Configuration.GetSection("AuthServiceConfiguration"));

builder.Services.Configure<LoggingConfiguration>(builder.Configuration.GetSection("LoggingConfiguration"));

var app = builder.Build();

app.UseServiceModel(builder =>
{
    builder.AddService<TaskService>(serviceOptions => { });
    builder.AddService<ChatService>(serviceOptions => { });
    builder.AddService<AuthenticatorService>(serviceOptions => { });
    builder.AddService<LoggingService>(serviceOptions => { });
    builder.AddServiceEndpoint<TaskService, ITaskService>(new CoreWCF.BasicHttpBinding(), "/TaskService/basicHttp");
    builder.AddServiceEndpoint<ChatService, IChatService>(new CoreWCF.BasicHttpBinding(), "/ChatService/basicHttp");
    builder.AddServiceEndpoint<AuthenticatorService, IAuthenticatorService>(new CoreWCF.BasicHttpBinding(), "/AuthService/basicHttp");
    builder.AddServiceEndpoint<LoggingService, ILoggingService>(new CoreWCF.BasicHttpBinding(), "/LogService/basicHttp");



});

var serviceMetaDataBehavior = app.Services.GetRequiredService<CoreWCF.Description.ServiceMetadataBehavior>();
serviceMetaDataBehavior.HttpGetEnabled = true;

app.MapGet("/", () => "Hello World!");

app.Run();
