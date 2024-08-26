using TestingRazorPrj;
using TestingRazorPrj.Pages;


var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSingleton<IMyinter, myMathcls>();

builder.Services.AddLogging(
    c => { c.AddConsole();c.AddDebug(); }
    );




// Add services to the container.
builder.Services.AddRazorPages(
    c=> c.Conventions.AddPageRoute("/newPage","abcde")
       
);


var app = builder.Build();
//app.UseStatusCodePages();
app.UseStatusCodePagesWithReExecute("/ErrorPage");


//if (app.Environment.IsEnvironment("abcd"))
//{
//    app.UseExceptionHandler("/showMessage");
//}
if (app.Environment.IsDevelopment())
{

}
else
{
    app.UseExceptionHandler("/showMessage");
}

//// Configure the HTTP request pipeline.
//if (!app.Environment.IsDevelopment())
//{
//    app.UseExceptionHandler("/Error");
//    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
//    app.UseHsts();
//}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();
// how to create custom middleware
//app.Use(async (context, next) =>
//{
//    await context.Response.WriteAsync("<div> Hello World from the middleware 2 </div>");
//    await next.Invoke();
//    await context.Response.WriteAsync("<div> Returning from the middleware 2 </div>");
//});

//app.Use(async (context, next) =>
//{
//    await context.Response.WriteAsync("<div> India</div>");
//    await next.Invoke();
//    await context.Response.WriteAsync("<div> Canada </div>");
//});

//app.Use(async (context, next) =>
//{
//    await context.Response.WriteAsync("<div> Swiz </div>");
//    await next.Invoke();
//    await context.Response.WriteAsync("<div> America</div>");
//});


//app.MapGet("/a", () =>  "hello world");

app.Run();
