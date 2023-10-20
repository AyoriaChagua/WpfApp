using Data;
using Entity;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussines
{
    public class BInvoice
    {

        public List<Invoice> GetByDate(DateTime date)
        { 
            DInvoice data = new DInvoice();
            var invoices = data.GetInvoices();
            var result = invoices.Where(x => x.Date.Date == date.Date).ToList();
            return result;
        }
    }
}
