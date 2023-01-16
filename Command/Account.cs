using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    internal class Account
    {
        public int Balance { get; set; }

        public void Process(CommandClass c)
        {
            switch (c.TheAction)
            {
                case CommandClass.Action.Deposit:
                    Balance += c.Amount;
                    c.Success = true;
                    break;
                case CommandClass.Action.Withdraw:
                    c.Success = Balance >= c.Amount;
                    if (c.Success) Balance -= c.Amount;
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
    }
}
