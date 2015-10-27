using JuliusSweetland.OptiKey.UI.Controls;

namespace JuliusSweetland.OptiKey.UI.Views.Keyboards.Common
{
    /// <summary>
    /// Interaction logic for Minecraft.xaml
    /// </summary>
    public partial class Minecraft : KeyboardView
    {
        public Minecraft() 
            : base(supportsCollapsedDock:true)
        {
            InitializeComponent();
        }
    }
}
