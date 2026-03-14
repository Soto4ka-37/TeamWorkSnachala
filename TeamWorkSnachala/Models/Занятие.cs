using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamWorkSnachala.Models
{
    public class ЗанятиеКонтроллер
    {
        public int ID_занятия { get; set; }
        public int ID_предмета_FK { get; set; } // Внешний ключ к предмету
        public int ID_студента_FK { get; set; } // Внешний ключ к студенту
        public bool Посещение { get; set; } // Логический тип для отметки "был/не был"
        public int? Оценка { get; set; } // Знак вопроса означает, что оценка может быть NULL (не поставлена)
        public string КомментарийОценки { get; set; }

    }
}
