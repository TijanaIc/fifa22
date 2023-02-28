using Fifa22.Business.Layer.Groups;
using Fifa22.Business.Layer.Players;
using Fifa22.Business.Layer.Teams;
using Fifa22.Data.Repositories;
using Fifa22.Data.Sql.Repositories;
using Fifa22.WebService;
using NLog.Web;

var builder = WebApplication.CreateBuilder(args);

// NLog: Setup NLog for Dependency injection
builder.Logging.ClearProviders();
builder.Host.UseNLog();

builder.Services.AddScoped<System.Data.IDbConnection>(sp => new System.Data.SqlClient.SqlConnection(sp.GetRequiredService<IConfiguration>().GetConnectionString("FifaDatabase")));
builder.Services.AddScoped<IGroupRepository, GroupRepository>();
builder.Services.AddScoped<ITeamRepository, TeamRepository>();
builder.Services.AddScoped<IPlayerRepository, PlayerRepository>();
builder.Services.AddScoped<IGroupService, GroupService>();
builder.Services.AddScoped<ITeamService, TeamService>();
builder.Services.AddScoped<IPlayerService, PlayerService>();
builder.Services.AddHttpClient();

// Add services to the container.
builder.Services.AddCors(policyBuilder =>
    policyBuilder.AddDefaultPolicy(policy =>
        policy.WithOrigins("*").AllowAnyHeader().AllowAnyHeader())
);



builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();



var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.RegisterMyFirstMiddleware();
app.UseCors();
app.UseAuthorization();

app.MapControllers();

app.Run();
