using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RelicviaShope.Models
{
    public class HelpTraders
    {
        public static HelpTraders? ActiveHelpTrader { get; set; } // активная помощь
        public int Id { get; set; } // id помощи
        public int UserId { get; set; } // id пользователя
        public string UserName { get; set; } = null!; // имя пользователя
        public string INN { get; set; } = null!; // ИНН
        public List<User> Users { get; set; } = []; // список пользователей
        public override string ToString()
        {
            return $"{Id} - {UserName} - {UserId} - {INN}";
        }
    }
}
