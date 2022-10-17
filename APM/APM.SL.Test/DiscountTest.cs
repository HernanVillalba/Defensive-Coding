using APM.Utilities.Exceptions;
using System;
using System.Collections.Generic;
using Xunit;

namespace APM.SL.Test
{
    public class DiscountTest
    {
        private readonly Discount discountService;

        public DiscountTest()
        {
            discountService = new Discount();
        }

        [Theory]
        [InlineData("30% off")]
        public void FindDiscount_WhenTheNameEqual_ShoudlGetDiscount(string discountName)
        {
            List<Discount> discounts = new List<Discount>()
            {
                new Discount(){ DiscountName = discountName, PercentOff = 30 },
                new Discount(){ DiscountName = "dummy", PercentOff = 0 }
            };

            Discount discount = discountService.FindDiscount(discounts, discountName: discountName);

            Assert.Equal(discountName, discount.DiscountName);
        }

        [Theory]
        [InlineData("name")]
        public void FindDiscount_WhenNotFound_ShouldReturnNotFound(string discountName)
        {
            var discounts = new List<Discount>();

            NotFoundProjectException ex = Assert.Throws<NotFoundProjectException>(testCode: () => discountService.FindDiscount(discounts, discountName));

            Assert.Equal("Discount not found", ex.Message);
        }
    }
}