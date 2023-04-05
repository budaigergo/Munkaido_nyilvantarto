using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Munkaido_nyilvantarto
{
    internal static class Program
    {
        static public FormLogin Login = null;
        static public Alkalmazottak_kezelese Alkalmazottak_kezelese = null;
        static public FormFooldal Fooldal = null;
        static public FormMegtekintés Megtekintés = null;
        static public FormJelenletFeljegyzese JelenletFeljegyzese= null;
        static public FormJelenlétÖsszegző JelenletOsszegzo= null;
        static public FormFizetes Fizetes = null;

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Login = new FormLogin();
            Fooldal = new FormFooldal();
            Megtekintés = new FormMegtekintés();
            Alkalmazottak_kezelese=new Alkalmazottak_kezelese();    
            JelenletFeljegyzese = new FormJelenletFeljegyzese();
            JelenletOsszegzo = new FormJelenlétÖsszegző();
            Fizetes = new FormFizetes();
            Application.Run(Fooldal);
        }
    }
}
