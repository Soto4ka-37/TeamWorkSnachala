using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamWorkSnachala.Models
{
    public class ПредметКонтроллер
    {
        public int ID_Предмета { get; set; }
        public int ID_Преподавателя_FK { get; set; } // Внешний ключ к преподавателю
        public string НазваниеПредмета { get; set; }

    }
}
