using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamWorkSnachala.Models
{
    public class СтудентКонтроллер
    {
        public int ID_Студента { get; set; }
        public string Фамилия { get; set; }
        public string Имя { get; set; }
        public string Отчество { get; set; }
        public decimal Стипендия { get; set; } // Используем decimal для денежных значений
        public string НазваниеГруппы_FK { get; set; } // Внешний ключ к группе
        public double СреднийБалл { get; set; } // Используем double для дробных чисел
        public bool Должник { get; set; } // Логический тип (да/нет)

    }
}
