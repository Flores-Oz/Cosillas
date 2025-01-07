namespace API_CORE.Models
{
    public class modelAPIResult
    {
        public string message { get; set; }
        public List<modelProduct> list { get; set; }
        public modelProduct product { get; set; }
    }
}
