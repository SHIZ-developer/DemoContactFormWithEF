using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using DemoContactFormWithEF.Models;

namespace DemoContactFormWithEF
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            //� ������� ������� ������� ��������� ������������� ���� ��� �������� ��� �������
            //Database.SetInitializer(new TableInitializer());
            //������ ������� ����� �� ������� �������� ���������
            Database.SetInitializer(new CreateDatabaseIfNotExists<DemoEFEntities1>());

            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}
