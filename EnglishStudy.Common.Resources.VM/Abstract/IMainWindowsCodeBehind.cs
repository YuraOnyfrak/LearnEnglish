using EnglishStudy.Entity.Abstract.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnglishStudy.Common.Resources.VM.Abstract
{
    public interface IMainWindowsCodeBehind
    {
        void LoadView(ViewType typeView);
    }
}
