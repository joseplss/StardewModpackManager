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

        public static string CreateFolderIfNotExists(string folderName)
        {
            Console.WriteLine("In Create folder if not exists");
            string appDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string folderPath = Path.Combine(appDirectory, folderName);

            if (!Directory.Exists(folderPath))
            {
                Console.WriteLine("creatfolder if");
                Directory.CreateDirectory(folderPath);
            }

            Console.WriteLine("returning value:");
            return folderPath;
        }
    }
}
