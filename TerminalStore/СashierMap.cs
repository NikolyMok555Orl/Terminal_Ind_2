using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TerminalStore
{
    /// <summary>
    /// Карточка кассира
    /// </summary>
    public class СashierMap
    {

        [Key]
        public int CassiraMapId { get; set; }
        [MaxLength(20)]
        public string Login { get; set; }
        [MaxLength(20)]
        public string Pass { get; set; }
        [MaxLength(20)]
        public string Name { get; set; }


        public List<ShoppingSession> ShoppingSessions { get; set; }

        public СashierMap(string login, string pass, string name)
        {
            Login = login;
            Pass = pass;
            Name = name;
            ShoppingSessions = new List<ShoppingSession>();
        }

        public СashierMap()
        {
            ShoppingSessions = new List<ShoppingSession>();
        }
    }
}
