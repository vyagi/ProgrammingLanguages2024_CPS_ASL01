using FluentAssertions;

namespace InvoiceApplication.BusinessLogic.Tests
{
    public class InvoiceProcessorTests
    {
        [Fact]
        public void CategoriesExpenses_returns_expenses_by_categories()
        {
            var processor = new InvoiceProcessor();
           
            var categorized = processor.CategoriesExpenses(new string[]
            {
                "Name;Price;Category",
                "Bread; 1000; Food",
                "Sushi; 2000; Food",
                "Lego; 2500; Toys",
                "Pizza; 100; Food",
                "New laptop; 50000; Equipment",
            });

            categorized.Should().HaveCount(3);
            categorized.First().Item1.Should().Be("Food");
            categorized.First().Item2.Should().Be(3100);
            
            categorized.Skip(1).First().Item1.Should().Be("Toys");
            categorized.Skip(1).First().Item2.Should().Be(2500);

            categorized.Skip(2).First().Item1.Should().Be("Equipment");
            categorized.Skip(2).First().Item2.Should().Be(50000);
        }
    }
}