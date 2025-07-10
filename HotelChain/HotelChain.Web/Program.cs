/*
 * Голукович Тимофей 3 курс 9 группа
 *
 * Crud-приложение на тему "Cеть отелей"
 * 
 * 1) Возможность получения информации об отеле по его id
 * 2) Добавление новых и удаление существующих отелей
 */

using HotelChain.Persistence.PostgreSql;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddPostgreSqlStores(builder.Configuration);

builder.Services.AddControllers();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapControllers();

app.Run();