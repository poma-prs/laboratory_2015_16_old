using System.Linq;
using Fillwords.BLL.Models;

namespace Fillwords.BLL
{
    public static class GameFieldManager
    {
        private static readonly GameField _gameField;

        static GameFieldManager()
        {
            _gameField = new GameField
            {
                Height = 6,
                Width = 6,

                Field = new[]
                {
                    "пбаина",
                    "ладмтк",
                    "еваноч",
                    "исаино",
                    "нырерт",
                    "авбвак",
                },

                Words = new[]
                {
                    "плавание",
                    "бадминтон",
                    "карточка",
                    "вбрасывание"
                }
            };
        }

        public static GameField Get()
        {
            return _gameField;
        }

        public static CheckWordResult CheckWord(string word)
        {
            return _gameField.Words.Contains(word) ? CheckWordResult.Correct : CheckWordResult.Incorrect;
        }
    }
}