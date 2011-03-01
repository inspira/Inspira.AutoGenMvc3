using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Inspira.AutoGenMvc3.Infrastructure.DataAccess.NHibernate;
using Inspira.AutoGenMvc3.TestModel;

namespace CodeGeneratorTest
{
    [TestClass]
    public class nhibernate
    {
        [TestMethod]
        public void one_to_one_with_unique_key()
        {
            SessionManager.DomainAssembly = typeof(OneToOneParent).Assembly;
            SessionManager.ConfigurationPath = @"..\..\hibernate.cfg.xml";

            var session = SessionManager.GetNewSession();
            var parent = new OneToOneParent { Name = "parent" };
            var child = new OneToOneChild { Name = "child" };

            child.Parent = parent;

            session.Save(child);

            session.Flush();
            session.Clear();

            var childFromDb = session.Get<OneToOneChild>(child.ID);
            Assert.IsNotNull(childFromDb.Parent);
        }

        [TestMethod]
        public void one_to_one_with_unique_key_load_only()
        {
            SessionManager.DomainAssembly = typeof(OneToOneParent).Assembly;
            SessionManager.ConfigurationPath = @"..\..\hibernate.cfg.xml";

            var session = SessionManager.GetNewSession();

            var childFromDb = session.Get<OneToOneChild>(1);
            Assert.IsNotNull(childFromDb.Parent);
        }

    }
}
