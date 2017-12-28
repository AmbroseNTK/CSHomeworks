using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// This is test library
/// </summary>
namespace TestLibrary
{
    /// <summary>
    /// Demo for Class1
    /// </summary>
    public class Class1
    {
        /// <summary>
        /// Create new Class1's object
        /// </summary>
        public Class1()
        {

        }
        /// <summary>
        /// Number #1
        /// </summary>
        private int num;

        public int Num { get => num; set => num = value; }
        /// <summary>
        /// Create new object
        /// </summary>
        /// <param name="num">The number #1</param>
        public Class1(int num)
        {
            this.Num = num;
        }
    }
}
