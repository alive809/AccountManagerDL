using System;
namespace AcccountManager.Core
{
    public class ModelBasePersona<T>
    {
        public T Id { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string NumIdentif { get; set; }
        public DateTime CreatedDate { get; set; }
        public string UserCreater { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string ModifierUser { get; set; }

    }
}
