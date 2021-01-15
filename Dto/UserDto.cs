namespace Dto
{
    /// <summary>
    /// в зависимости от языка в данной дто лежит либо руские Фио
    /// либо фио на  английском языке
    /// </summary>
    public class UserDto
    {/// <summary>
        /// first name - имя
        /// </summary>
        public string FName;
        /// <summary>
        /// last name - фамилия
        /// </summary>
        public string LName;
        /// <summary>
        /// отчество - от midddlename
        /// </summary>
        public string MName;
        /// <summary>
        /// Номер паспорта
        /// </summary>
        public string PassportNumber;
        /// <summary>
        /// язык на котором запись введена
        /// </summary>
        public ELang Lang;
    }
}