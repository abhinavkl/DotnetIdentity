namespace DotnetIdentity
{
    public class Startup
    {
        public Startup(IConfiguration configuration, IWebHostEnvironment env)
        {
            Configuration = configuration;
            HostingEnvironment = env;
            contentRoot = env.ContentRootPath;
        }
        public static IWebHostEnvironment HostingEnvironment { get; private set; }
        public static string contentRoot { get; private set; }
        private static IConfiguration _Configuration { get; set; }
        public static IConfiguration Configuration { get { return _Configuration; } set { _Configuration = value; } }

        public static string NoteDbConnectionString { get { return Configuration.GetConnectionString("NoteDbConnectionString"); } }
        public static string AppUserDbConnectionString { get { return Configuration.GetConnectionString("AppUserDbConnectionString"); } }

    }
}

