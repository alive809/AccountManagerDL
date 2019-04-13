using System;
using AcccountManager.Core;
using Microsoft.EntityFrameworkCore;



namespace AcccountManager.Models
{
    public class Persona:ModelBasePersona<int>
    {
        public Persona(int id)
        {
            this.Id = id;
        }
        public Persona(string firstName)
        {
            this.FirstName = firstName;
        }

        public Persona Buscar()
        {
            //AcountManagerDBContext context = new AcountManagerDBContext(;


            return this;
        }

    }
}
