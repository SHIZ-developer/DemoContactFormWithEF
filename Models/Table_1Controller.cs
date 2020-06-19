using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using DemoContactFormWithEF;

namespace DemoContactFormWithEF.Models
{

    //Инициализация базы - обнуление и создание трёх демонстрационных записей.
    //public class TableInitializer : DropCreateDatabaseAlways<DemoEFEntities1>
    //{
    //    protected override void Seed(DemoEFEntities1 db)
    //    {
    //        int UniId = 1;
    //        db.Table.AddOrUpdate(new Table_1 { Id = UniId, FIO = "Владислав Владимирович", Email = "mail@mail.net", Tel = "+7-777-777-7777", Foto = "https://thispersondoesnotexist.com/image" });
    //        UniId +=1;
    //        db.Table.AddOrUpdate(new Table_1 { Id = UniId, FIO = "Иван Иванович", Email = "mail@yandex.net", Tel = "+7-777-777-8888", Foto = "https://thispersondoesnotexist.com/image?19999991" });
    //        UniId += 1;
    //        db.Table.AddOrUpdate(new Table_1 { Id = UniId, FIO = "Багдат Багдатулы", Email = "mail@gmail.net", Tel = "+7-777-777-9999", Foto = "https://www.thispersondoesnotexist.com/image?777777" });
    //        base.Seed(db);
    //    }
    //}

    //Инициализация базы - создание трёх демонстрационных записей если таблицы нет.
    public class TableInitializer : CreateDatabaseIfNotExists<DemoEFEntities1>
    {
        protected override void Seed(DemoEFEntities1 db)
        {
            int UniId = 1;
            db.Table.AddOrUpdate(new Table_1 { Id = UniId, FIO = "Владислав Владимирович", Email = "mail@mail.net", Tel = "+7-777-777-7777", Foto = "https://thispersondoesnotexist.com/image" });
            UniId += 1;
            db.Table.AddOrUpdate(new Table_1 { Id = UniId, FIO = "Иван Иванович", Email = "mail@yandex.net", Tel = "+7-777-777-8888", Foto = "https://thispersondoesnotexist.com/image?19999991" });
            UniId += 1;
            db.Table.AddOrUpdate(new Table_1 { Id = UniId, FIO = "Багдат Багдатулы", Email = "mail@gmail.net", Tel = "+7-777-777-9999", Foto = "https://www.thispersondoesnotexist.com/image?777777" });
            base.Seed(db);
        }
    }

}