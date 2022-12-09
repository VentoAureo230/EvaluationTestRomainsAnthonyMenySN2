using System.Runtime.InteropServices.ComTypes;
using ConvertisseurRomain;

namespace NombreRomainsTest
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(3)]

        public void Convertir1et2et3(int x)
        {
            // ETANT DONNE un nombre x compris entre 1 et 3
            // QUAND on le convertit en nombre romains
            var attendu = ConvertisseurNombresRomains.Convert(x);

            // ALORS on obtient x fois le nombre I
            var result = new String('I', x);
        }

        [Fact]

        public void Convertir4enIV()
        {
            // ETANT DONNE le chiffre 4
            var nombre = 4;

            // QUAND on le convertit en nombre romains
            var attendu = ConvertisseurNombresRomains.Convert(nombre);

            // ALORS on obtient le nombre IV
            Assert.Equal("IV", attendu);
        }

        [Theory]
        [InlineData(5)]
        [InlineData(6)]
        [InlineData(7)]
        [InlineData(8)]

        public void Convertir5et6et7et8(int x)
        {
            // ETANT DONNE un chiffre x allant de 5 à 8
            // QUAND on le convertit en nombre romains
            var attendu = ConvertisseurNombresRomains.Convert(x);

            // ALORS on obtient le nombre romain V + I ou II ou III
            var result = 'V' + new String('I', x - 5);
            Assert.Equal(result, attendu);
        }


        [Fact]
        public void Convertir9enIX()
        {
            var nombre = 9;

            var attendu = ConvertisseurNombresRomains.Convert(nombre);

            Assert.Equal("IX", attendu);
        }

        [Fact]
        public void Convertir10enX()
        {
            var nombre = 10;

            var attendu = ConvertisseurNombresRomains.Convert(nombre);

            Assert.Equal("X", attendu);
        }

        [Theory]
        [InlineData(11)]
        [InlineData(12)]
        [InlineData(13)]

        public void Convertir11et12et13(int x)
        {
            // ETANT DONNE un chiffre xcompris en 11 et 13
            // QUAND on le convertit en nombre romain
            var attendu = ConvertisseurNombresRomains.Convert(x);

            // ALORS on obtient un nombre romain X + I ou II ou III
            var result = 'X' + new String('I', x - 10);
            Assert.Equal(result, attendu);
        }
    }
}