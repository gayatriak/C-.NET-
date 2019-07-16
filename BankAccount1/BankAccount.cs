using System;

namespace BankAccount1
{
    internal class BankAccount
    {
        private string v1;
        private int v2;

        public BankAccount(string v1, int v2)
        {
            this.v1 = v1;
            this.v2 = v2;
        }

        public object Number { get; internal set; }
        public object Owner { get; internal set; }
        public object Balance { get; internal set; }

        internal void MakeWithdrawal(int v1, DateTime now, string v2)
        {
            throw new NotImplementedException();
        }

        internal void MakeDeposit(int v1, DateTime now, string v2)
        {
            throw new NotImplementedException();
        }

        internal bool GetAccountHistory()
        {
            throw new NotImplementedException();
        }
    }
}