namespace Quete_MVC_Razor.Models
{
    public class Expenditure
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public DateTime Date { get; set; }
        public double Price { get; set; }
    }
}
