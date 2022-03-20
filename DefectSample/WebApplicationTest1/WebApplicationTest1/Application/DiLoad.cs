namespace WebApplicationTest1.Application
{
    public class DiLoad : IDiLoad
    {
        private readonly string ConnectionString;

        public DiLoad(string connectionString)
        {
            ConnectionString = connectionString;
        }

        public string GetConnectionString() => ConnectionString;

    }
}
