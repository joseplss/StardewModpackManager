using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace StardewModpackManager.utils
{
    public static class CommonUtils
    {
        public static void DefaultForm(Form form, Panel panel)
        {
            FormUtils formUtils = new FormUtils();
            formUtils.SetDefaultFormProperties(form);
        }
    }
}
