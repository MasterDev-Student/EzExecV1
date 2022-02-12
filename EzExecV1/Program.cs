using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MasterDevExec
{
    static class Program
    {

        [STAThread]
        static void Main()
        {
            //Message box pour confirmer que l'utilisateur a lancer roblox !
            string message = ("Inject ?");
            string title = ("MasterDev : (Only if Roblox is started)");
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                //Si l'utilisateur fait "oui" alors lancer le EzExec
                Console.Beep();
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Form1());
            }
            else
            {
                //Si l'utilisateur fait "non" alors fermer le cheat
                Thread.Sleep(1500);
            }
        }
    }
}

// By MasterDev
// Si tu vend cette source tu est vraiment un sans race

