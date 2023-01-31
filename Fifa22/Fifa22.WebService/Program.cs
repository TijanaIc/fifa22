using Fifa22.Data.Repositories;
using Fifa22.Data.Sql.Repositories;
using Fifa22.WebService;


var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<System.Data.IDbConnection>(sp => new System.Data.SqlClient.SqlConnection(sp.GetRequiredService<IConfiguration>().GetConnectionString("FifaDatabase")));
builder.Services.AddScoped<IGroupRepository, GroupRepository>();
builder.Services.AddScoped<ITeamRepository, TeamRepository>();
builder.Services.AddScoped<IPlayerRepository, PlayerRepository>();
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
