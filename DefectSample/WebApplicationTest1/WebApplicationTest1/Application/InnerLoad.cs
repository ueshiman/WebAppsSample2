namespace WebApplicationTest1.Application
{
    public class InnerLoad : IInnerLoad
    {
        private readonly string ConnectionString;

        public InnerLoad()
        {
            WebApplicationBuilder builder = WebApplication.CreateBuilder();

            string? connectionString = builder.Configuration.GetConnectionString("ComplianceViewProto01Context");
            ConnectionString = connectionString;
        }

        public string GetConnectionString() => ConnectionString;
    }
}
