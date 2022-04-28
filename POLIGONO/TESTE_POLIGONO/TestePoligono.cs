using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POLIGONO_API;
using NUnit.Framework;

namespace TESTE_POLIGONO
{
    [TestFixture]
    public class TestePoligono
    {
        [Test]
        public void TestarCirculo()

        {
            Circulo obj = new Circulo(10);
            Assert.AreEqual(20, obj.Diametro());
            Assert.AreEqual(62.831853071795864, obj.Perimetro());
            Assert.AreEqual(314.15926535897932, obj.Area());
        }

        [Test]
        public void TestarTriangulo()
        {
            Triangulo obj = new Triangulo(10, 10, 10);
            Assert.AreEqual(30, obj.Perimetro());
            Assert.AreEqual(50, obj.Area(10));
            Assert.AreEqual("equilatero", obj.Tipo());
        }
    }
}
