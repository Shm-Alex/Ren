using System;

namespace Dto
{
    public class User : UserDto
    {
        public string GetFullName()
        {
            switch (Lang)
            {
                case ELang.Rus:
                case ELang.Eng:
                    return $"{LName} {FName} {MName}";
                case ELang.Unknown:
                    return null;// чтобы поддерживать совместимость со старым  методом GetFullName 
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
    }
}