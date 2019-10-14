using System;
using System.Windows;

namespace MemoryTest
{
    public static class NavigationHelper
    {
        public static void NavigateTo(Type targetWindow, Window currentWindow)
        {
            Window newWindowInstance = Activator.CreateInstance(targetWindow) as Window;
            if (newWindowInstance != null)
            {
                newWindowInstance.Show();
                currentWindow.Close();
            }
        }
    }
}
