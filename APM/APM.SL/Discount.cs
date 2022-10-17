using APM.Utilities.Exceptions;
using System;
using System.Collections.Generic;

namespace APM.SL
{
    public class Discount
    {
        public int DiscountId { get; private set; }
        public string DiscountName { get; set; }

        public decimal PercentOff { get; set; }

        // ... Discount details

        public Discount FindDiscount(List<Discount> discounts, string discountName)
        {
            if (discounts is null) return null;

            Discount foundDiscount = discounts.Find(d => d.DiscountName == discountName);

            if (foundDiscount == null)
                throw new NotFoundProjectException("Discount not found");

            return foundDiscount;
        }
    }
}