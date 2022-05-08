using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Knygos.lt.Test
{
    class KnygosTest : BaseTest
    {
        [Test]
        public static void AcceptCokies()
        {
            _knygosPage.NavigateToDefaultPage();
            _knygosPage.AcceptCookies();
        }
    }
}
