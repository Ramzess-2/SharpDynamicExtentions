using System.Linq;
using System.Reflection;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SharpExtentions.Dynamic.Generic;

namespace SharpExtentions.Dynamic.Test.Generic
{
    [TestClass]
    public class AssemblyExplorerTest {


        [TestMethod]
        public void GetNestedClasses() {

            var types = AssemblyExplorer.Successors<Ancestor>(Assembly.GetExecutingAssembly());
            Assert.AreEqual(types.Count(), 3);

        }

        [TestMethod]
        public void GetClassesWithNameEnds() {

            var types = AssemblyExplorer.NameEnds("Class", Assembly.GetExecutingAssembly());
            Assert.AreEqual(types.Count(), 2);
        }

        [TestMethod]
        public void GetNestedClassesWithNameEnds() {
            
            var types = AssemblyExplorer.NameEnds<Ancestor>("Class", Assembly.GetExecutingAssembly());
            Assert.AreEqual(types.Count(), 1);
        }

        [TestMethod]
        public void GetClassesWithNameStarts()
        {

            var types = AssemblyExplorer.NameStarts("Second", Assembly.GetExecutingAssembly());
            Assert.AreEqual(types.Count(), 2);
        }

        [TestMethod]
        public void GetNestedClassesWithNameStarts()
        {

            var types = AssemblyExplorer.NameStarts<Ancestor>("Second", Assembly.GetExecutingAssembly());
            Assert.AreEqual(types.Count(), 1);
        }


    }
}
