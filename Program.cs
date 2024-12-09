var builder = WebApplication.CreateBuilder(args); //

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddRouting(option => option.LowercaseUrls = true);//forçando as urls em lowercase

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{   
    //se for desenvolvimento chama o swagger
    app.UseSwagger();
    app.UseSwaggerUI();
}

//redireciona para https
app.UseHttpsRedirection();

app.UseAuthorization();

//mapeamento dos controlers 
app.MapControllers();

app.Run();
