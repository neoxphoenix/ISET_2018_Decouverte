using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace ISET_2018_Decouverte
{
    sealed class ParamApplication : ApplicationSettingsBase
        //Permet d'aller voir les paramètres de l'application
    {
        [UserScopedSetting()] //attribut pour que cela fonctionne, simplemennt ^^
        public string ChConnBD
        {
            get { return (string)this["csPerso"]; } //lire
            set { this["csPerso"] = value; } //modifier
        }
    }

    static class Program
    {
        public static ParamApplication PA = new ParamApplication(); //permet d'y accèder partout
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new EcranAccueil());  //une fois qu'on l'aura fermé, cela exécutera la ligne suivante
            Application.Run(new FicPrincipal());
        }
    }
}
