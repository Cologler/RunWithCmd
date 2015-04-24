using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RunWithCmd
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length > 0 && System.IO.File.Exists(args[0]))
            {
                var folder = System.IO.Path.GetDirectoryName(args[0]);
                System.IO.Directory.SetCurrentDirectory(folder);
                System.Diagnostics.Process.Start("cmd.exe", "/c \"" + args[0] + "\"");
            }
        }
    }
}
