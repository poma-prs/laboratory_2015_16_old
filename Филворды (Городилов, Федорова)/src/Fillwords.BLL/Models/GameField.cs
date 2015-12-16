namespace Fillwords.BLL.Models
{
    public class GameField
    {
        public int Height { get; set; }
        public int Width { get; set; }
        public string[] Field { get; set; }
        public string[] Words { get; set; }
    }
}