var builder = DistributedApplication.CreateBuilder(args);

var calc = builder.AddProject<Projects.CalculationService>("calc");

builder.AddNpmApp("web", "../Web")
    .WithReference(calc)
    .WithHttpEndpoint(env: "VITE_PORT")
    .WithExternalHttpEndpoints()
    .PublishAsDockerFile();

builder.Build().Run();