using Microsoft.AspNetCore.Builder;
using System;

var app = WebApplication
    .CreateBuilder()
    .Build();

app.MapGet("/", (Func<string>)(() => "Hello World!"));
app.Run();