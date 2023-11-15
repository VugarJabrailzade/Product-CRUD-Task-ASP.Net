using System.ComponentModel.DataAnnotations;

namespace Task1_asp.Net.Database.Models
{
    public class Navbar
    {
        //public Navbar(int id, string title, int orderCount, bool isHeader)
        //{
        //    Id = id;
        //    Title = title;
        //    OrderCount = orderCount;
        //    IsHeader = isHeader;
        //}
        
        public int Id { get; set; }
        public string Title { get; set; }
 
        public int OrderCount { get; set; }

        public bool IsHeader { get; set; }
        

    }
}
