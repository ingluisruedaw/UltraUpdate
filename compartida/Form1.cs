using compartida.Modelo;
using Credenciales_UNC;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Windows.Forms;

namespace compartida
{
    public partial class Form1 : Form
    {
        String usuario = "Administrador";
        String clave = "4dm1n5013d4dpvd2017";

        List<Equipos> Computadores = new List<Equipos>();
        List<Rutas> Rutas_Locales = new List<Rutas>();
        public Form1()
        {
            InitializeComponent();
            Computadores.Add(new Equipos("CAPACITACION-01"));//0
            Computadores.Add(new Equipos("CAPACITACION-02"));//1
            Computadores.Add(new Equipos("CAPACITACION-03"));//2
            Computadores.Add(new Equipos("CAPACITACION-04"));//3
            Computadores.Add(new Equipos("CAPACITACION-05"));//4
            Computadores.Add(new Equipos("CAPACITACION-06"));//5
            Computadores.Add(new Equipos("CAPACITACION-07"));//6
            Computadores.Add(new Equipos("CAPACITACION-08"));//7
            Computadores.Add(new Equipos("CAPACITACION-09"));//8
            Computadores.Add(new Equipos("CAPACITACION-10"));//9
            Computadores.Add(new Equipos("CAPACITACION-11"));//10
            Computadores.Add(new Equipos("CAPACITACION-12"));//11
            Computadores.Add(new Equipos("CAPACITACION-13"));//12
            Computadores.Add(new Equipos("CAPACITACION-14"));//13
            Computadores.Add(new Equipos("CAPACITACION-15"));//14
            Computadores.Add(new Equipos("CAPACITACION-16"));//15
            Computadores.Add(new Equipos("DESARROLLO-01"));//16
            Computadores.Add(new Equipos("DESARROLLO-02"));//17
            Computadores.Add(new Equipos("DESARROLLO-03"));//18
            Computadores.Add(new Equipos("DESARROLLO-04"));//19
            Computadores.Add(new Equipos("DESARROLLO-05"));//20
            Computadores.Add(new Equipos("DESARROLLO-06"));//21
            Computadores.Add(new Equipos("DESARROLLO-07"));//22
            Computadores.Add(new Equipos("DESARROLLO-08"));//23
            Computadores.Add(new Equipos("DESARROLLO-09"));//24
            Computadores.Add(new Equipos("ADMINISTRACION"));//25
            Computadores.Add(new Equipos("IMAGEN-01"));//26
            Computadores.Add(new Equipos("IMAGEN-02"));//27*/
            TxRuta.Text = @"C:\Users\" + Environment.UserName + @"\Desktop\vivelab";
            Directorios_Locales();//los que tengo en el escritorio
        }

        public void Directorios_Locales()
        {
            try
            {
                var directorios = Directory.EnumerateDirectories(TxRuta.Text).ToList();
                directorios.ForEach((dir) =>
                {
                    Rutas_Locales.Add(new Rutas(dir));
                    TxDirectoriosCopiar.Text += "\n" + dir;
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static void Copiar(string Ruta_Origen, string Ruta_Destino, bool Copiar_Contenido)
        {
            // Get the subdirectories for the specified directory.
            DirectoryInfo dir = new DirectoryInfo(Ruta_Origen);

            if (!dir.Exists)
            {
                throw new DirectoryNotFoundException(
                    "Source directory does not exist or could not be found: "
                    + Ruta_Origen);
            }

            DirectoryInfo[] dirs = dir.GetDirectories();
            // If the destination directory doesn't exist, create it.
            if (!Directory.Exists(Ruta_Destino))
            {
                Directory.CreateDirectory(Ruta_Destino);
            }

            // Get the files in the directory and copy them to the new location.
            FileInfo[] files = dir.GetFiles();
            foreach (FileInfo file in files)
            {
                string temppath = Path.Combine(Ruta_Destino, file.Name);
                file.CopyTo(temppath, false);
            }

            // If copying subdirectories, copy them and their contents to new location.
            if (Copiar_Contenido)
            {
                foreach (DirectoryInfo subdir in dirs)
                {
                    string temppath = Path.Combine(Ruta_Destino, subdir.Name);
                    Copiar(subdir.FullName, temppath, Copiar_Contenido);
                }
            }
        }

        private void BtEjecutar_Click(object sender, EventArgs e)
        {
            TxCopiados.Clear();
            TxErrores.Clear();
            Computadores.ForEach((dir) =>
            {
                Ejecutar(dir);
            });
            MessageBox.Show("ARCHIVOS MOVIDOS EXITOSAMENTE");
        }

        public void Ejecutar(Equipos dir)
        {
            String[] dirs;
            String Ruta_Remota = @"\\" + dir.Nombre + @"\vivelab";
            TxCopiados.Text += "\r\n";
            using (UNCAccess unc = new UNCAccess())
            {
                if (unc.NetUseWithCredentials(Ruta_Remota, usuario, "", clave))
                {
                    dirs = Directory.GetDirectories(Ruta_Remota);
                    foreach (string d in dirs)
                    {
                        //MessageBox.Show(Path.GetFileName(d));
                        Directory.Delete(d, true);
                    }
                    Rutas_Locales.ForEach((local) =>
                    {
                        String destino = (Ruta_Remota + @"\" + Path.GetFileName(local.Path));
                        Copiar(local.Path, destino, true);
                        TxCopiados.Text += destino + "\r\n";
                    });
                }
                else
                {
                    this.Cursor = Cursors.Default;
                    String msn = Ruta_Remota + "\r\nCódigo Error: = " + unc.LastError.ToString();
                    TxErrores.Text += msn + "\r\n\n";
                }
            }
        }

        public static Boolean PingForName(String Name)
        {
            try
            {
                Ping pingSender = new Ping();
                PingReply reply = pingSender.Send(Name);
                return (reply.Status == IPStatus.Success);
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
