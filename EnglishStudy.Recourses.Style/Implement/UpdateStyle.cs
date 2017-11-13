using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnglishStudy.Recourses.Style.Implement
{

    public class UpdateStyle
    {
        public static void SetThemes(string styleSource)
        {
            if (styleSource != "Без стилю")
            {
                string path = @"\BrainRingGame.Style\" + styleSource + ".xaml";
                var uri = new Uri(path,
                    UriKind.RelativeOrAbsolute);

                if (File.Exists(path))
                {
                    ResourceDictionary resourceDict = Application.LoadComponent(uri)
                        as ResourceDictionary;
                    Application.Current.Resources.Clear();
                    Application.Current.Resources.MergedDictionaries.Add(resourceDict);
                }

            }
        }
    }
}
