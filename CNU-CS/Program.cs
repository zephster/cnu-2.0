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

namespace CNU_CS
{
    static class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            foreach (string param in args)
            {
                switch (param)
                {
                    case "--update":
                        /*
                         * auto update possible flow:
                         *      regular main app usage:
                         *          check for latest version
                         *              xml file
                         *                  latest version build number
                         *                  filename of latest version
                         *                  md5 hash
                         *                  description of changes
                         *          ask to download/install
                         *          download the update - .exe format so it can be executed
                         *          VERIFY UPDATE
                         *          run update with param --update so this code runs
                         *          exit
                         *          
                         *      --update mode:
                         *          *this exe will be named something different every time. keep it in mind
                         *          verify main cnup program is closed
                         *          delete main app
                         *          
                         * 
                         */
                        Console.WriteLine("updating...");
                        
                        
                        //Environment.Exit(0);
                        break;
                }
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new main());
        }
    }
}
