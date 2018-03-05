using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Xml.Linq;

namespace EnglishStudy.Recourses.Style.Implement
{

    public class UpdateStyle
    {
        public static void SetThemes(string styleSource)
        {
            if (styleSource != "Без стилю")
            {
               // string path = "E:\\Програмування\\EnglishStudy\\EnglishStudy.Recourses.Style\\Resource\\" + styleSource + ".xaml";
               // var uri = new Uri(path, UriKind.Relative);
                                           

              //  if (File.Exists(path))
                {
                    string _prefix = String.Concat(typeof(App).Namespace, ";component/");
                    string path = @"/EnglishStudy.Recourses.Style;component/Dark.xaml";
                    // var uri = new Uri(_prefix + styleSource + ".xaml", UriKind.Relative);
                    var uri = new Uri(path, UriKind.Relative);
                      ResourceDictionary myResourceDictionary = Application.LoadComponent(uri) as ResourceDictionary;
                  //  ResourceDictionary myResourceDictionary = new ResourceDictionary() { Source = new Uri("/EnglishStudy.Recourses.Style;component/Dark.xaml") };
                    Application.Current.Resources.Clear();                 
                    Application.Current.Resources.MergedDictionaries.Add(myResourceDictionary);

                    MessageBox.Show("Load");
                    
                }

            }
        }
    }
}
