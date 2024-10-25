using NUnit;
using Task1624;

namespace Task1624Test
{
    public class Tests
    {
      
        [Test]
        public void Substraction_MustReturnCorrectValue()
        {
            var calc = new Calculator();
            Assert.That(calc.Subtraction(10, 5) == 5);
        }
        //Task 1625
        [Test]
        public void Division_MustReturnCorrectValue()
        {
            var calc = new Calculator();
            Assert.That(calc.Division(4, 2) == 2);
        }
        //Task1626
        [Test]
        public void Division_MustReturnDivideByZeroException()
        {
            var calc = new Calculator();
            Assert.Throws<DivideByZeroException>(() => calc.Division(4, 0));
        }
        [Test]
        public void AddAlwaysReturnExpectedValue()
        {
            var calc = new Calculator();
            Assert.That(calc.Add(10,220),Is.EqualTo(230));
        }
        [Test]
        public void GetTicketPriceMustReturnExistingPrice()
        {
            var ticketServiceTest = new TicketService();
            Assert.IsNotNull(ticketServiceTest.GetTicketPrice(1));
        }
        [Test]
        public void GetTicketPriceMustThrowException()
        {
            var ticketServiceTest = new TicketService();
            Assert.Throws<TicketNotFoundException>(() => ticketServiceTest.GetTicketPrice(100));
        }

    }
}