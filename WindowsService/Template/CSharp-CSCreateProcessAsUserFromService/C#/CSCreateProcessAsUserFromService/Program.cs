using System;
using System.ServiceProcess;

namespace CSCreateProcessAsUserFromService
{
    static class Program
    {
    /// <summary>
    /// The main entry point for the application.
    /// </summary>
    static void Main()
    {
#if DEBUG
      string[] argStr = { "0", "0" };
      Service1 myServiceDebug = new Service1();
      myServiceDebug.OnDebug(argStr);
#else
      ServiceBase[] ServicesToRun;
      ServicesToRun = new ServiceBase[]
      {
              new Service1()
      };
      ServiceBase.Run(ServicesToRun);
#endif

    }
    }
}
