namespace MVVM.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public string ImagePath { get; set; }
        public int Discont { get; set; }
        public int Count { get; set; }
    }
}
