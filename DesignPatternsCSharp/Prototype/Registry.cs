using System.Diagnostics;
using System.Collections.Generic;
using System;

namespace DesignPatternsCSharp.Prototype
{
    public class Registry
    {
        private Dictionary<string, Item> items = new Dictionary<string, Item>();

        public Registry()
        {
            loadItems();
        }

        public Item createItem(string type)
        {
            Item item = null;
            try
            {
                item = (Item) items[type].Clone();
            }
            catch (Exception e)
            {
                Console.Write(e.Message);
            }
            return item;
        }

        private void loadItems()
        {
            Movie movie = new Movie();
            movie.title = "Basic Movie";
            movie.price = 24.99;
            movie.runtime = "2 hours";
            items.Add("Movie", movie);

            Book book = new Book();
            book.numberOfPages = 335;
            book.price = 19.99;
            book.title = "Basic Book";
            items.Add("Book", book);
        }
    }
}
