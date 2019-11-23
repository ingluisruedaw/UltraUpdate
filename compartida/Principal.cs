// ----------------------------------------------------------------------------
// <copyright file="Principal.cs">
//     COPYRIGHT(C) 2019, Luis Domingo Rueda Wilches
// </copyright>
// <author>Luis Domingo Rueda Wilches - ingluisruedaw@gmail.com.</author>
// <date>11/23/2019</date>
// <summary>Define User Interface Definition.</summary>
// ----------------------------------------------------------------------------
namespace compartida
{
    using compartida.Modelo;
    using Credenciales_UNC;
    using System;
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;
    using System.IO;
    using System.Linq;
    using System.Net.NetworkInformation;
    using System.Windows.Forms;

    /// <summary>Define User Interface Definition.</summary>
    /// <author>Luis Domingo Rueda Wilches - ingluisruedaw@gmail.com.</author>
    /// <date>11/23/2019</date>
    public partial class Principal : Form
    {
        #region Constants
        /// <summary>Username network.</summary>
        /// <author>Luis Domingo Rueda Wilches - ingluisruedaw@gmail.com.</author>
        /// <date>11/23/2019</date>
        private const string Username = "Username";

        /// <summary>Password network.</summary>
        /// <author>Luis Domingo Rueda Wilches - ingluisruedaw@gmail.com.</author>
        /// <date>11/23/2019</date>
        private const string Password = "Key";
        #endregion

        #region Variables
        /// <summary>Desktops Available</summary>
        /// <author>Luis Domingo Rueda Wilches - ingluisruedaw@gmail.com.</author>
        /// <date>11/23/2019</date>
        private List<Desktop> Desktops;

        /// <summary>Local Paths Available</summary>
        /// <author>Luis Domingo Rueda Wilches - ingluisruedaw@gmail.com.</author>
        /// <date>11/23/2019</date>
        private List<Route> LocalPaths;
        #endregion

        #region Constructors
        /// <summary>Initialize instance type <see cref="Principal"/>.</summary>
        /// <author>Luis Domingo Rueda Wilches - ingluisruedaw@gmail.com.</author>
        /// <date>11/23/2019</date>
        public Principal()
        {
            InitializeComponent();
            this.InitializeObjects();
            this.InitializeDesktops();
            this.InitializePath();            
            this.LocalPathFiles();
        }
        #endregion

        #region Private Methods
        /// <summary>Start instance objects.</summary>
        /// <author>Luis Domingo Rueda Wilches - ingluisruedaw@gmail.com.</author>
        /// <date>11/23/2019</date>
        private void InitializeObjects()
        {
            this.Desktops = new List<Desktop>();
            this.LocalPaths = new List<Route>();
        }

        /// <summary>Start Path Files</summary>
        /// <author>Luis Domingo Rueda Wilches - ingluisruedaw@gmail.com.</author>
        /// <date>11/23/2019</date>
        private void InitializePath()
        {
            TxRute.Text = @"C:\Users\" + Environment.UserName + @"\Desktop\vivelab";
        }

        /// <summary>Start Desktops Availables</summary>
        /// <author>Luis Domingo Rueda Wilches - ingluisruedaw@gmail.com.</author>
        /// <date>11/23/2019</date>
        private void InitializeDesktops()
        {
            for (int i = 1; i <= 16; i++)
            {
                Desktops.Add(new Desktop("CAPACITACION-0" + i.ToString()));
            }
        }

        /// <summary>Start Local Path Files</summary>
        /// <author>Luis Domingo Rueda Wilches - ingluisruedaw@gmail.com.</author>
        /// <date>11/23/2019</date>
        [SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes", Justification = "Excepcion en ultima capa.")]
        private void LocalPathFiles()
        {
            try
            {
                var directories = Directory.EnumerateDirectories(TxRute.Text).ToList();
                directories.ForEach((dir) =>
                {
                    LocalPaths.Add(new Route(dir));
                    TxCopyDirectories.Text += "\n" + dir;
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>Start Copy Files</summary>
        /// <param name="originPath">Represent origin path.</param>
        /// <param name="destinationPath">Represent destination path..</param>
        /// <param name="copyContent">Represent copy content rute.</param>
        /// <author>Luis Domingo Rueda Wilches - ingluisruedaw@gmail.com.</author>
        /// <date>11/23/2019</date>
        private void CopyFiles(string originPath, string destinationPath, bool copyContent)
        {
            DirectoryInfo dir = new DirectoryInfo(originPath);
            if (!dir.Exists)
            {
                throw new DirectoryNotFoundException("Source directory does not exist or could not be found: "+ originPath);
            }

            DirectoryInfo[] dirs = dir.GetDirectories();
            if (!Directory.Exists(destinationPath))
            {
                Directory.CreateDirectory(destinationPath);
            }

            FileInfo[] files = dir.GetFiles();
            foreach (FileInfo file in files)
            {
                string temppath = Path.Combine(destinationPath, file.Name);
                file.CopyTo(temppath, false);
            }

            if (copyContent)
            {
                foreach (DirectoryInfo subdir in dirs)
                {
                    string temppath = Path.Combine(destinationPath, subdir.Name);
                    CopyFiles(subdir.FullName, temppath, copyContent);
                }
            }
        }

        /// <summary>Execute commands.</param>
        /// <param name="desktop">Object type Desktop.</param>
        /// <author>Luis Domingo Rueda Wilches - ingluisruedaw@gmail.com.</author>
        /// <date>11/23/2019</date>
        public void ExecuteCommands(Desktop desktop)
        {
            string[] dirs;
            string remotePath = @"\\" + desktop.Name + @"\vivelab";
            TxCopied.Text += "\r\n";
            using (UNCAccess unc = new UNCAccess())
            {
                if (unc.NetUseWithCredentials(remotePath, Username, "", Password))
                {
                    dirs = Directory.GetDirectories(remotePath);
                    foreach (string d in dirs)
                    {
                        Directory.Delete(d, true);
                    }
                    LocalPaths.ForEach((local) =>
                    {
                        string destination = (remotePath + @"\" + Path.GetFileName(local.Path));
                        CopyFiles(local.Path, destination, true);
                        TxCopied.Text += destination + "\r\n";
                    });
                }
                else
                {
                    this.Cursor = Cursors.Default;
                    string msn = remotePath + "\r\nCódigo Error: = " + unc.LastError.ToString();
                    TxErrors.Text += msn + "\r\n\n";
                }
            }
        }

        /// <summary>Ping in network.</param>
        /// <param name="Name">Object type string.</param>
        /// <author>Luis Domingo Rueda Wilches - ingluisruedaw@gmail.com.</author>
        /// <date>11/23/2019</date>
        [SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes", Justification = "Excepcion en ultima capa.")]
        public static bool PingForName(string Name)
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
        #endregion

        #region Events
        /// <summary>Execute event click.</summary>
        /// <param name="sender">Información del evento generado.</param>
        /// <param name="e">Información del evento generado.</param>
        /// <author>Luis Domingo Rueda Wilches - ingluisruedaw@gmail.com.</author>
        /// <date>11/23/2019</date>

        [SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes", Justification = "Excepcion en ultima capa.")]
        private void BtExecute_Click(object sender, EventArgs e)
        {
            try
            {
                TxCopied.Clear();
                TxErrors.Clear();
                Desktops.ForEach((dir) =>
                {
                    ExecuteCommands(dir);
                });
                MessageBox.Show("ARCHIVOS MOVIDOS EXITOSAMENTE");
            }
            catch (Exception ex)
            {
                throw ex;
            }            
        }
        #endregion
    }
}
