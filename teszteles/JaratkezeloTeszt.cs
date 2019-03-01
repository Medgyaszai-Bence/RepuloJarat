using System;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teszteles.Tests
{
    [TestFixture]
    public class JaratkezeloTeszt
    {
        JaratKezelo jk = new JaratKezelo();

        [Test]
        public void UjJarat()
        {
            jk.UjJarat("2000","valami","valahova",DateTime.Now);   
        }


        [Test]
        public void UjJarat2()
        {
            jk.UjJarat("2000", "valami", "valahova", DateTime.Now);

            Assert.Throws<UjJaratException>(
                () =>
                {
                    jk.UjJarat("2000", "valami", "valahova", DateTime.Now);
                }
            );
        }

        [Test]
        public void Keses()
        {
            Assert.Throws<NegativKesesException>(
                () =>
                {
                    jk.Keses("hfm300", -10);
                }
            );

            jk.Keses("hfm300",15);
           // jk.Keses("jkl100", -20);
        }

        [Test]
        public void Mikorindul()
        {
            jk.MikorIndul("hfm300");
           
        }
    }
}
