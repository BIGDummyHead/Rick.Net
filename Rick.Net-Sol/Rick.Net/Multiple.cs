using System.Collections;
using System.Collections.Generic;

namespace Rick
{
    /// <summary>
    /// Defines an API request that has multiple items of <typeparamref name="T"/>
    /// <para>Inherits <see cref="CanError"/></para>
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public sealed class Multiple<T> : CanError, IEnumerable<T> where T : class
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

        public IEnumerator<T> GetEnumerator()
        {
            foreach (T item in Results)
            {
                yield return item;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public T this[int index]
        {
            get
            {
                return Results[index];
            }

            set
            {
                Results[index] = value;
            }
        }
    }
}
