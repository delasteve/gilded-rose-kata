using System.Collections.Generic;
using Dojo;
using Xunit;

namespace DojoTests
{
    public class GildedRoseTest
    {
        [Fact]
        public void UpdateQuality()
        {
            // Arrange
            var items = new List<Item> { new Item { Name = "foo", SellIn = 0, Quality = 0 } };
            var app = new GildedRose(items);

            // Act
            app.UpdateQuality();

            // Assert
            Assert.Equal("foo", items[0].Name);
        }
    }
}