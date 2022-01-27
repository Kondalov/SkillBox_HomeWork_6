using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SkillBox_HM6
{
    public struct worker
    {
        /// <summary>
        /// идентификатор пользователя
        /// </summary>
        static public int ID;
        /// <summary>
        /// Дата и время добавления записи
        /// </summary>
        static public DateTime AddTimeorDateNote;
        /// <summary>
        /// Имя сотрудника
        /// </summary>
        static public string FirstName;
        /// <summary>
        /// Фамилия сотрудника
        /// </summary>
        static public string LastName;
        /// <summary>
        /// Второе имя (отчество)
        /// </summary>
        static public string MiddleName;
        /// <summary>
        /// Возраст сотрудника
        /// </summary>
        static public byte Age;
        /// <summary>
        /// Рост сотрудника
        /// </summary>
        static public byte Height;
        /// <summary>
        /// Дата рождения
        /// </summary>
        static public DateTime DateBirthDay;
        /// <summary>
        /// Место рождения
        /// </summary>
        static public string City;

    }
}