// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Repository.cs" company="Bridgelabz">
//   Copyright © 2020 Company="BridgeLabz"
// </copyright>
// <creator name="Manish Reddy"/>
// --------------------------------------------------------------------------------------------------------------------
namespace Mocking
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    public class Repository
    {
        /// <summary>
        /// Implemented method.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public int Sum(int a, int b)
        {
            ////Should return the Addition value
            return a+b;
        }

        /// <summary>
        /// Non Implemented method.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public virtual int Sub(int a, int b)
        {
            throw new NotImplementedException();
        }
    }
}
