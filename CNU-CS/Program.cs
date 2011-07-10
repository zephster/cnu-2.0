/*
 * Chrome Nightly Updater+ 2.0, ©2010 Brandon <antizeph@gmail.com>
 * 
This program is free software: you can redistribute it and/or modify
it under the terms of the GNU General Public License as published by
the Free Software Foundation, either version 3 of the License, or
(at your option) any later version.

This program is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the
GNU General Public License for more details.

You should have received a copy of the GNU General Public License
along with this program. If not, see <http://www.gnu.org/licenses/>.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.IO;

namespace CNU_CS
{
    static class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            string appPath = Path.GetDirectoryName(Application.ExecutablePath);

            foreach (string param in args)
            {
                switch (param)
                {
                    case "--update":
                        /*
                         * auto update possible flow - im sure this is a really stupid way to do this :-( :
                         *      regular main app usage:
                         *          check for latest version
                         *              xml file
                         *                  latest version build number
                         *                  filename of latest version
                         *                  md5 hash
                         *                  description of changes
                         *          ask to download/install
                         *          download the update - cnuupdate.exe or something
                         *          verify on-server md5 is the same as downloaded files md5
                         *          run update with param --update so this code runs
                         *          exit
                         *          
                         *      --update mode:
                         *          the file downloaded is the new version
                         *          verify itself
                         *          make copy of itself named CNU2.exe (file.copy)
                         *          run CNU2.exe with --updated param (have that delete cnuupdate.exe)
                         *          
                         */
                        Console.WriteLine("running with parameter: --update");
                        
                        //Environment.Exit(0);
                        break;

                    case "--auto":
                        Console.WriteLine("testing one-click auto-update");
                        Console.ReadLine();

                        
                        break;

                    default:
                        continue;
                }
            }

            //run main
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new main());
        }
    }
}
