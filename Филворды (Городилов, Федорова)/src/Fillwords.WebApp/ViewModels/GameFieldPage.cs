using Fillwords.BLL.Models;

namespace Fillwords.WebApp.ViewModels
{
    public class GameFieldPage : ViewModelBase
    {
        public GameField GameField { get; set; }

        public GameFieldPage() : base("Игра")
        {
        }
    }
}