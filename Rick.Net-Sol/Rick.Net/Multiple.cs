using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rick
{
    /// <summary>
    /// Defines an API request that has multiple items of <typeparamref name="T"/>
    /// <para>Inherits <see cref="CanError"/></para>
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public sealed class Multiple<T> : CanError where T : class
    {
        internal Multiple() { }

        /// <summary>
        /// The info on this request
        /// </summary>
        public Info Info { get; set; }

        /// <summary>
        /// All results included in request
        /// </summary>
        public T[] Results { get; set; }

    }
}
