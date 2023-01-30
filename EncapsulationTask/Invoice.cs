using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationTask
{
    internal class Invoice
    {
        public string account = string.Empty;
        private string customer = string.Empty;
        private string provider = string.Empty;

        public Invoice(string account, string customer, string provider)
        {
            this.account = account;
            this.customer = customer;
            this.provider = provider;
        }

        public string Article { get; set; }
        public string Quantity { get; set; }
        public decimal Price { get; set; }
        public void CostCalculation(bool vat)
        {
            if (vat == true)
            {
                Console.WriteLine(Convert.ToString($"Article - {Article}\nQuantity - {Quantity}\nTotal with VAT-{(Price = Price * Convert.ToDecimal(Quantity)) + Convert.ToDecimal(Convert.ToDecimal(0.18) * Price)}$"));
            }
            else
            {
                Console.WriteLine(Convert.ToString($"Article - {Article}\nQuantity - {Quantity}\nTotal without VAT-{Price *= Convert.ToDecimal(Quantity)}$"));
            }
        }
    }
}

