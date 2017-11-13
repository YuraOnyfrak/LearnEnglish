
using EnglishStudy.Common.Resources.VM.Abstract;
using static EnglishStudy.Common.Resources.VM.Base.ViewModalBase;

namespace EnglishLearn.Common.Resources.VM.VMForUserControl
{
   public class ShooseStyleVM : ViewModelBase
    {
        IMainWindowsCodeBehind _codeBehind;

        public ShooseStyleVM(IMainWindowsCodeBehind codeBehind)
        {
            _codeBehind = codeBehind;
        }
    }
}
