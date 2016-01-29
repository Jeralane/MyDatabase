using System;
using System.Diagnostics;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyDatabase;

namespace TestProject1
{
    [TestClass]
    public class ActiveRecord_Find
    {
        [TestMethod]
        public void TestMethod1()
        {
            User user = ActiveRecord<User>.Find(1);
            Debug.Assert(user.ID == 1);
        }
    }
}
