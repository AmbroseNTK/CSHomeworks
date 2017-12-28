using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSHomeWorks.Tuan11
{
    class Bank : List<Account>
    {
        public Bank()
        {

        }
        public void Output()
        {
            foreach(Account account in this)
            {
                account.Output();
            }
        }
    }
}
