using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Prototipo
{
    class conexion
    {
        public static string miservidor;
        public static string usuario, clave, bd;
        public static string servidor;
        public static string cadena;

        public static void conec()
        {
            servidor = miservidor;
            bd = "ComplejoEducativo"; usuario = "sa"; clave = "123456";
            cadena = "server=" + servidor + ";uid=" + usuario + ";pwd=" + clave + ";database=" + bd;

        }
        public static void instanInstaladas()
        {

            Microsoft.Win32.RegistryKey baseKey = Microsoft.Win32.RegistryKey.OpenBaseKey(Microsoft.Win32.RegistryHive.LocalMachine, Microsoft.Win32.RegistryView.Registry64);
            Microsoft.Win32.RegistryKey key = baseKey.OpenSubKey(@"SOFTWARE\Microsoft\Microsoft SQL Server\Instance Names\SQL");


            foreach (string s in key.GetValueNames())
            {

                if (s == "MSSQLSERVER")
                {
                    miservidor = "(local)";
                }
                else
                {
                    miservidor = @"(local)\" + s;
                }

            }
        }
    }
}
