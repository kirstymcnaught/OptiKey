using JuliusSweetland.OptiKey.Properties;
using JuliusSweetland.OptiKey.Static;
using log4net;
using Prism.Mvvm;

namespace JuliusSweetland.OptiKey.UI.ViewModels.Management
{
    public class AboutViewModel : BindableBase
    {
        #region Private Member Vars

        private static readonly ILog Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        #endregion
        
        #region Ctor

        public AboutViewModel()
        {
            Load();
        }

        #endregion

        #region Properties

        private string optiKeyVersion;
        public string OptiKeyVersion
        {
            get { return DiagnosticInfo.AssemblyVersion; }
        }

        private string minecraftModVersion;
        public string MinecraftModVersion
        {
            get { return DiagnosticInfo.MinecraftModVersion; }
        }

        #endregion

        #region Methods

        private void Load()
        {
            
        }

        public void ApplyChanges()
        {
            
        }

        #endregion
    }
}
