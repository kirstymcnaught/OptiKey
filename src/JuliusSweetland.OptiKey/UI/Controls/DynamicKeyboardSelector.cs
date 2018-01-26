using System;
using JuliusSweetland.OptiKey.UI.ViewModels.Keyboards.Base;

namespace JuliusSweetland.OptiKey.UI.ViewModels.Keyboards
{
    public class DynamicKeyboardSelector : BackActionKeyboard
    {
        private int pageIndex;
        private string folderLocation;

        public DynamicKeyboardSelector(Action backAction, 
                                       string folderLocation, 
                                       int pageIndex)
            : base(backAction)
        {
            this.folderLocation = folderLocation;
            this.pageIndex = pageIndex;
        }

        public int PageIndex
        {
            get { return pageIndex; }
        }

        public string FolderLocation
        {
            get { return folderLocation; }
        }
    }
}
