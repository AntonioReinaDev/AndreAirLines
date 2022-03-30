namespace AndreAirLines.Data
{
    public static class Configuration
    {
        static string datasource = "ANTONIO";
        static string database = "AirlinesAndre";
        static string username = "sa";
        static string password = "afdpnmY#2000";
        public static string ConnectionString
        {
            get
            {
                return @$"Data Source={datasource};Initial Catalog={database};Persist Security Info=True;User ID={username};Password={password};";
            }
        }
    }
}
