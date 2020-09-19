using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mocking
{
    public class Bussiness
    {
        private readonly Repository repo;
        public Bussiness(Repository repo)
        {
            this.repo = repo;
        }

        /// <summary>
        /// Calling Repository Sum method from bussiness call.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public int Addition(int a,int b)
        {
            return this.repo.Sum(a, b);
        }

        /// <summary>
        /// Calling Repository SUb method from bussiness class.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public int Substraction(int a, int b)
        {
            return this.repo.Sub(a, b);
        }
    }
}
