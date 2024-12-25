using GrpcService; // Replace with your actual namespace

var builder = WebApplication.CreateBuilder(args);

// Add gRPC service to the container
builder.Services.AddGrpc();

var app = builder.Build();

// Ensure routing middleware is added
app.UseRouting();

// Map gRPC services
app.UseEndpoints(endpoints =>
{
    endpoints.MapGrpcService<ProductServiceImplementation>(); // Use your implementation class
    endpoints.MapGet("/", () => "Communication with gRPC endpoints must be made through a gRPC client.");
});

app.Run();