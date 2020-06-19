﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DemoContactFormWithEF
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class DemoEFEntities1 : DbContext
    {
        public DemoEFEntities1()
            : base("name=DemoEFEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }

        //Возможно я несовсем понял задание соотношению названия таблицы в коде и по факту
        //Поэтому если изменять модель, то нужно обязательно переименовать
        //автоматически создаваемое имя класса Table_1 в Table.
        //Как показано ниже:
        //public virtual DbSet<Table_1> Table { get; set; }
        //Иначе будет ошибка, т.к. грубо говоря массив с данные назван классом Table и Table_1 нет.
        public virtual DbSet<Table_1> Table { get; set; }
    
        public virtual ObjectResult<Procedure_Result> Procedure(Nullable<int> param1, string param2, string param3, string param4, string param5)
        {
            var param1Parameter = param1.HasValue ?
                new ObjectParameter("param1", param1) :
                new ObjectParameter("param1", typeof(int));
    
            var param2Parameter = param2 != null ?
                new ObjectParameter("param2", param2) :
                new ObjectParameter("param2", typeof(string));
    
            var param3Parameter = param3 != null ?
                new ObjectParameter("param3", param3) :
                new ObjectParameter("param3", typeof(string));
    
            var param4Parameter = param4 != null ?
                new ObjectParameter("param4", param4) :
                new ObjectParameter("param4", typeof(string));
    
            var param5Parameter = param5 != null ?
                new ObjectParameter("param5", param5) :
                new ObjectParameter("param5", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Procedure_Result>("Procedure", param1Parameter, param2Parameter, param3Parameter, param4Parameter, param5Parameter);
        }
    }
}
