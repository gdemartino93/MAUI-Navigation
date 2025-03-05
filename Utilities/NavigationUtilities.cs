using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAUI_Navigation.Utilities
{
    public static class NavigationUtilities
    {
        public static void Examine(INavigation navigation)
        {
            StringBuilder builder = new StringBuilder();
            foreach (var page in navigation.NavigationStack)
            {
                builder.AppendLine(page.GetType().Name.ToString());
            }
            Debug.WriteLine("----------------");
            Debug.WriteLine(builder.ToString());
        }

        public static void RemovePage(INavigation navigation, string namePageToRemove)
        {
            Page? pageToRemove = navigation.NavigationStack.FirstOrDefault(p => p.GetType().Name == namePageToRemove);
            if (pageToRemove != null)
            {
                navigation.RemovePage(pageToRemove);
            }
        }

        public static void AddPage(INavigation navigation, Page pageToInsert, Page pageBefore)
        {
            if (pageToInsert == null) return;

            navigation.InsertPageBefore(pageToInsert, pageBefore);
        }
    }
}
