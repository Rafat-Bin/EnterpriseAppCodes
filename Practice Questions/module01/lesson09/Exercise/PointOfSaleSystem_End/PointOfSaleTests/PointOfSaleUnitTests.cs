using PointOfSaleSystem;

namespace PointOfSaleTests
{
    public class PointOfSaleUnitTests
    {
        [Theory]
        [InlineData(10.0, 15.0, 5.0)]
        [InlineData(20.0, 20.0, 0.0)]
        public void ProcessTransaction_ValidNumbers_ReturnsExpectedValue(double finalPrice, double customerAmount, double expectedResult)
        {
            PointOfSale pointOfSale = new PointOfSale();

            double result = pointOfSale.ProcessTransaction(finalPrice, customerAmount);

            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void ProcessTransaction_AmountLessThanPrice_ThrowsException()
        {
            PointOfSale pointOfSale = new PointOfSale();

            Assert.Throws<ArgumentOutOfRangeException>(() => pointOfSale.ProcessTransaction(10.0, 5.0));
        }

        [Theory]
        [InlineData("None", 100, 100.0)]
        [InlineData("Bronze", 100, 90.0)]
        [InlineData("Silver", 100, 80.0)]
        [InlineData("Gold", 100, 70.0)]
        public void ApplyDiscount_ValidLoyalties_ReturnCorrectDiscount(string loyalty, double subtotal, double expectedValue)
        {
            PointOfSale pointOfSale = new PointOfSale();

            double result = pointOfSale.ApplyDiscount(loyalty, subtotal);

            Assert.Equal(Math.Round(expectedValue, 2), result);
        }

        [Theory]
        [InlineData(null)]
        [InlineData("")]
        [InlineData("  ")]
        public void ApplyDiscount_InvalidLoyalties_ThrowsException(string loyalty)
        {
            PointOfSale pointOfSale = new PointOfSale();

            Assert.Throws<ArgumentNullException>(() => pointOfSale.ApplyDiscount(loyalty, 100));
        }

        [Fact]
        public void ApplyCoupon_ValidCoupon_DiscountIsAppliedToItem()
        {
            PointOfSale pointOfSale = new PointOfSale();
            Coupon coupon = new Coupon(0.1, true);

            double result = pointOfSale.ApplyCoupon(100, coupon);

            Assert.Equal(90, result);
        }

        [Fact]
        public void ApplyCoupon_InValidCoupon_ThrowsException()
        {
            PointOfSale pointOfSale = new PointOfSale();
            Coupon coupon = new Coupon(0.1, false);

            Assert.Throws<ArgumentException>(() =>  pointOfSale.ApplyCoupon(100, coupon));
        }
    }
}
