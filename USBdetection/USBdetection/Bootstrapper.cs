using Microsoft.Practices.Unity;
using Prism.Modularity;
using Prism.Unity;
using USBdetection.Views;
using System.IO;
using System.Windows;

namespace USBdetection
{
  /*
  Post-build event command line: 
  xcopy "$(ProjectDir)Modular.config" "$(TargetDir)" /Y

  or

  <Content Include="Module.config">
    <CopyToOutputDirectory>Always</CopyToOutputDirectory>
  </Content>
  */
  class Bootstrapper : UnityBootstrapper
  {
    protected override DependencyObject CreateShell()
    {
      return Microsoft.Practices.ServiceLocation.ServiceLocator.Current.GetInstance<MainWindow>();
    }

    protected override void InitializeShell()
    {
      Application.Current.MainWindow = (Window)this.Shell;
      Application.Current.MainWindow.Show();
    }

    protected override IModuleCatalog CreateModuleCatalog()
    {
      FileInfo fileInfo = new FileInfo(@".\Modules.config");

      if (!fileInfo.Exists)
      {
        // Discovering Modules in a Directory
        return new DirectoryModuleCatalog() { ModulePath = @".\DirectoryModules" };
      }
      else
      {
        // Registering Modules Using a Configuration File
        return new ConfigModuleCatalog(fileInfo.FullName);
      }
    }
  }

  public class ConfigModuleCatalog : ConfigurationModuleCatalog
  {
    public ConfigModuleCatalog(string configFile)
    {
      this.Store = new ConfigStore(configFile);
    }
  }

  public class ConfigStore : IConfigurationStore
  {
    public ConfigStore(string configFile)
    {
      var fileMap = new System.Configuration.ExeConfigurationFileMap() { ExeConfigFilename = configFile };
      var userLevel = System.Configuration.ConfigurationUserLevel.None;
      Config = System.Configuration.ConfigurationManager.OpenMappedExeConfiguration(fileMap, userLevel);
    }

    public System.Configuration.Configuration Config { get; set; }

    public ModulesConfigurationSection RetrieveModuleConfigurationSection()
    {
      if (!Config.HasFile)
      {
        return System.Configuration.ConfigurationManager.GetSection("modules") as ModulesConfigurationSection;
      }
      else
      {
        return Config.GetSection("modules") as ModulesConfigurationSection;
      }
    }
  }
}
