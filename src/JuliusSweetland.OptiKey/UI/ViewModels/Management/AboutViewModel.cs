using JuliusSweetland.OptiKey.Properties;
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
            get { return optiKeyVersion; }
            set { SetProperty(ref optiKeyVersion, value); }
        }

        private string minecraftModVersion;
        public string MinecraftModVersion
        {
            get { return minecraftModVersion; }
            set { SetProperty(ref minecraftModVersion, value); }
        }
       
        #endregion
        
        #region Methods

        private void Load()
        {
            OptiKeyVersion = "1.2.3";
            MinecraftModVersion = "3.4.5";
            
        }

        public void ApplyChanges()
        {
            
        }

        #endregion
    }
}
