using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace EnglishStudy.BL.Implement.Implement
{
    public class SomeSetting
    {
        public static void AddTB(ObservableCollection<TextBox> collection, int length)
        {
            for (int i = 0; i < length; i++)
            {
                collection.Add(new TextBox());
            }
        }

        public static void SettingTB(ObservableCollection<TextBox> collection)
        {
            foreach (var item in collection)
            {
                item.Margin = new Thickness(10);
                item.MinHeight = 50;
                item.MinWidth = 50;
                item.FontSize = 32;
                item.HorizontalContentAlignment = HorizontalAlignment.Center;
                item.VerticalContentAlignment = VerticalAlignment.Center;
            }
        }

        public static void AddTextToTB( char [] mas, ObservableCollection<TextBox> collection)
        {
            for (int i = 0; i < collection.Count; i++)
            {
                collection[i].Text = mas[i].ToString();
            }
        }
    }
}
