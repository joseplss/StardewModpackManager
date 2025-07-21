using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace StardewModpackManager.utils
{
    public class FormUtils
    {
        private bool isDragging = false;
        private Point lastCursor;
        private Point lastFormLocation;

        public void DefaultForm(Form form)
        {
            // Set the form to be borderless  
            form.FormBorderStyle = FormBorderStyle.None;

            // Allow resizing if needed (though custom resizing would be required for a borderless form)  
            EnableDoubleBuffering(form);

            // Call the helper method to set the style  
            SetControlStyle(form, ControlStyles.ResizeRedraw, true);
        }

        private static void EnableDoubleBuffering(Control control)
        {
            // Use reflection to set the DoubleBuffered property since it's protected  
            var doubleBufferedProperty = typeof(Control).GetProperty("DoubleBuffered", BindingFlags.Instance | BindingFlags.NonPublic);
            doubleBufferedProperty?.SetValue(control, true); // Helps with smooth resizing/drawing  
        }

        private static void SetControlStyle(Control control, ControlStyles style, bool value)
        {
            // Use reflection to access the protected SetStyle method  
            var setStyleMethod = typeof(Control).GetMethod("SetStyle", BindingFlags.Instance | BindingFlags.NonPublic);
            setStyleMethod?.Invoke(control, new object[] { style, value });
        }
    }
}
