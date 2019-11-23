// ----------------------------------------------------------------------------
// <copyright file="Desktop.cs">
//     COPYRIGHT(C) 2019, Luis Domingo Rueda Wilches
// </copyright>
// <author>Luis Domingo Rueda Wilches - ingluisruedaw@gmail.com.</author>
// <date>11/23/2019</date>
// <summary>Define Desktop Definition.</summary>
// ----------------------------------------------------------------------------
namespace compartida.Modelo
{
    using System;

    /// <summary>Define Desktop Definition.</summary>
    /// <author>Luis Domingo Rueda Wilches - ingluisruedaw@gmail.com.</author>
    /// <date>11/23/2019</date>
    public class Desktop
    {
        /// <summary>Represents name desktop.</summary>
        /// <value>Name desktop.</value>
        /// <author>Luis Domingo Rueda Wilches - ingluisruedaw@gmail.com.</author>
        /// <date>11/23/2019</date>
        public String Name { get; set; }

        /// <summary>Represents ip address desktop.</summary>
        /// <value>Ip Address desktop.</value>
        /// <author>Luis Domingo Rueda Wilches - ingluisruedaw@gmail.com.</author>
        /// <date>11/23/2019</date>
        public String IpAddress { get; set; }

        /// <summary>Initialize instance type <see cref="Desktop"/>.</summary>
        /// <author>Luis Domingo Rueda Wilches - ingluisruedaw@gmail.com.</author>
        /// <date>11/23/2019</date>
        public Desktop(string name)
        {
            this.Name = name;
        }
    }
}
