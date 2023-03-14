using System.ComponentModel.DataAnnotations;

namespace WebRazorTest.Model
{
    public class PizzaOrder
    {
        
        public int Id { get; set; }
        [StringLength(20)]
        public string Name { get; set; }
        public float Price { get; set; }
        public DateTime Date { get; set; }

    }
}
