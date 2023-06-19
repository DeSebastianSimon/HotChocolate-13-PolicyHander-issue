using HotChocolate_13_1_Authhandler.Auth;
using HotChocolate_13_1_Authhandler.Query;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddAuthentication(StubAuthHandler.AuthenticationScheme)
                .AddScheme<StubAuthHandlerOptions, StubAuthHandler>(StubAuthHandler.AuthenticationScheme, options => { });

builder.Services.AddAuthorization(options =>
{
    options.AddPolicy("TestPolicy", policy =>
    {
        policy.RequireAuthenticatedUser();
        policy.Requirements.Add(new TestAuthorizationRequirement());
    });
});

builder.Services.AddGraphQLServer()
                .AddAuthorization()
                .AddQueryType<QueryType>()
                .AddType<BookType>()
                .AddType<AuthorType>() // This like will not work.
                //.AddType<AuthorTypeWithApplyBeforeResolver>()  // This line will work.
                .AddType<PublisherType>();

builder.Services.AddSingleton<Microsoft.AspNetCore.Authorization.IAuthorizationHandler, TestAuthorizationHandler>();

var app = builder.Build();

app.UseAuthentication();
app.UseAuthorization();

app.MapGraphQL();

app.Run();