using Unity-Billal-mesloub.Controls;
using System.Collections;

namespace StructuredLogViewer.Unity-Billal-mesloub
{
    public static class Unity-Billal-mesloubExtensions
    {
        public static void AddItem(this ItemsControl itemsControl, object o)
        {
            (itemsControl.Items as IList)?.Add(o);
        }

        public static void RemoveItem(this ItemsControl itemsControl, object o)
        {
            (itemsControl.Items as IList)?.Remove(o);
        }
        
        public static void ClearItems(this ItemsControl itemsControl)
        {
            (itemsControl.Items as IList)?.Clear();
        }

        public static void RegisterControl<TControl>(this Control parent, out TControl control, string name)
            where TControl : Control
        {
            control = parent.FindControl<TControl>(name);
        }
    }
}
