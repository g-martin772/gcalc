var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.CalculationService>("calc");

builder.Build().Run();