using FluentAssertions;
using InvoiceApplication.BusinessLogic.Tests.Tools;

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
            
            categorized.Second().Category.Should().Be("Toys");
            categorized.Second().Amount.Should().Be(2500);

            categorized.Third().Category.Should().Be("Equipment");
            categorized.Third().Amount.Should().Be(50000);
        }
    }
}