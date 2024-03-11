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
            categorized.First().Category.Should().Be("Food");
            categorized.First().Amount.Should().Be(3100);
            
            categorized.Skip(1).First().Category.Should().Be("Toys");
            categorized.Skip(1).First().Amount.Should().Be(2500);

            categorized.Skip(2).First().Category.Should().Be("Equipment");
            categorized.Skip(2).First().Amount.Should().Be(50000);
        }
    }
}