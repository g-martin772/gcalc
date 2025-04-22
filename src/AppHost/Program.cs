var builder = DistributedApplication.CreateBuilder(args);

var app = builder.AddProject<Projects.App>("app");

builder.Build().Run();