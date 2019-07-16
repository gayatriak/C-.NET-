using System;
using System.Collections.Generic;
using System.IO;
using System.Transactions;

namespace bankAccount
{


    class Program
    {
        static void Main(string[] args)
        {
            string fileName = @"gayatri\somefile.txt";

            try

            {
                StreamReader reader = new StreamReader(fileName);
                Console.WriteLine(
                        "File {0} successfully opened.", fileName);
                Console.WriteLine("File contents:");
                using (reader){
                    Console.WriteLine(reader.ReadToEnd());
                }

            }

            catch (FileNotFoundException)

            {
                Console.Error.WriteLine(
                    "Can not find file {0}.", fileName);
            }

            catch (DirectoryNotFoundException)

            {
                Console.Error.WriteLine(
                    "Invalid directory in the file path.");
            }
            catch (IOException){

                Console.Error.WriteLine(

                    "Can not open the file {0}", fileName);

            }
        }
        public long accountNumber { get; set; }
        public decimal accountBal { get; set; }
        public int accountType { get; set; }

        abstract class Account
        {
           
            public class CheckingAccount : Account
            {
                private int accountBal;

                public void MakeDeposit(int amount)
                {
                    int deposited = accountBal += amount;
                }
                public void MakeWithdraw(int amount)
                {
                    int withdrawl = accountBal -= amount;
                }


            }
             

    /*        private class bankTransaction(float amount){
           private List<Transaction> allTransactions = new List<Transaction>();
           


        }
        */
    }
}

   
}
