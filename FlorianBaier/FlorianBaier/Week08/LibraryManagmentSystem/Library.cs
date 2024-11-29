using System;

namespace FlorianBaier.Week08
{
    public class Library
    {
        private Dictionary<string, Medium> mediaCollection = new Dictionary<string, Medium>();

        public void AddMedium(Medium medium)
        {
            if (!mediaCollection.ContainsKey(medium.ISBN))
            {
                mediaCollection.Add(medium.ISBN, medium);
                Console.WriteLine($"Added: {medium}");
            }
            else
            {
                Console.WriteLine($"Medium with ISBN {medium.ISBN} already exists.");
            }
        }

        public void RemoveMedium(string isbn)
        {
            if (mediaCollection.ContainsKey(isbn))
            {
                var mediumToRemove = mediaCollection[isbn];
                mediaCollection.Remove(isbn);
                Console.WriteLine($"Removed: {mediumToRemove}");
            }
            else
            {
                Console.WriteLine($"No medium found with ISBN: {isbn}");
            }
        }
        public List<Medium> Search(string searchTerm)
        {
            return mediaCollection.Values.Where(m => m.Title.Contains(searchTerm) || m.Author.Contains(searchTerm)).ToList();
        }

        public void DisplayAllMedia()
        {
            Console.WriteLine("Library contents:");
            foreach (var medium in mediaCollection.Values)
            {
                Console.WriteLine(medium.ToString());
            }
        }
    }

}