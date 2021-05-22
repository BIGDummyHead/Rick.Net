using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rick
{
    /// <summary>
    /// The status of a character, used for searching
    /// </summary>
    public enum Status
    {
        /// <summary>
        /// The character is Alive
        /// </summary>
        alive,
        /// <summary>
        /// The character is dead
        /// </summary>
        dead,
        /// <summary>
        /// The character is not known to be dead or alive
        /// </summary>
        unknown
    }
}
