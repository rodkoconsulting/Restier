using System;
using System.ServiceProcess;
using System.Web;
using RestierServiceV2;

public static class Program
{
    #region Nested classes to support running as service
    public const string ServiceName = "OData driver";

    public class Service : ServiceBase
    {
        public static HttpApplication app;
        public Service()
        {
            ServiceName = Program.ServiceName;
        }

        protected override void OnStart(string[] args)
        {
            Start(args);
        }

        protected override void OnStop()
        {
            Program.Stop();
        }
    }
    #endregion
    
    static void Main(string[] args)
    {
        if (!Environment.UserInteractive)
            // running as service
            using (var service = new Service())
                ServiceBase.Run(service);
        else
        {
            // running as console app
            Start(args);

            Console.WriteLine("Press any key to stop...");
            Console.ReadKey(true);

            Stop();
        }
    }
    
    private static void Start(string[] args)
    {
        Service.app = new WebApiApplication();
    }

    private static void Stop()
    {
        Service.app.Dispose();
        Service.app = null;
    }
}