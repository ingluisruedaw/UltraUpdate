// ----------------------------------------------------------------------------
// <copyright file="Route.cs">
//     COPYRIGHT(C) 2019, Luis Domingo Rueda Wilches
// </copyright>
// <author>Luis Domingo Rueda Wilches - ingluisruedaw@gmail.com.</author>
// <date>11/23/2019</date>
// <summary>Define Route Definition.</summary>
// ----------------------------------------------------------------------------
namespace compartida.Modelo
{
    using System;

    /// <summary>Define Route Definition.</summary>
    /// <author>Luis Domingo Rueda Wilches - ingluisruedaw@gmail.com.</author>
    /// <date>11/23/2019</date>
    public class Route
    {
        /// <summary>Represents path file.</summary>
        /// <value>Path file.</value>
        /// <author>Luis Domingo Rueda Wilches - ingluisruedaw@gmail.com.</author>
        /// <date>11/23/2019</date>
        public String Path { get; set; }

        /// <summary>Initialize instance type <see cref="Route"/>.</summary>
        /// <author>Luis Domingo Rueda Wilches - ingluisruedaw@gmail.com.</author>
        /// <date>11/23/2019</date>
        public Route(string path)
        {
            this.Path = path;
        }
    }
}
