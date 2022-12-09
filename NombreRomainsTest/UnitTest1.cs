
using ConvertisseurRomain;

namespace NombreRomainsTest
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(3)]

        public void Convertir1Et2Et3(int x)
        {
            // ETANT DONNE un nombre x compris entre 1 et 3
            // QUAND on le convertit en nombre romains
            var attendu = ConvertisseurNombresRomains.Convert(x);

            // ALORS on obtient x fois le nombre I
            var result = new String('I', x);
        }

        [Fact]

        public void Convertir4EnIv()
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

        public void Convertir5Et6Et7Et8(int x)
        {
            // ETANT DONNE un chiffre x allant de 5 à 8
            // QUAND on le convertit en nombre romains
            var attendu = ConvertisseurNombresRomains.Convert(x);

            // ALORS on obtient le nombre romain V + I ou II ou III
            var result = 'V' + new String('I', x - 5);
            Assert.Equal(result, attendu);
        }


        [Fact]
        public void Convertir9EnIx()
        {
            var nombre = 9;

            var attendu = ConvertisseurNombresRomains.Convert(nombre);

            Assert.Equal("IX", attendu);
        }

        [Theory]
        [InlineData(10)]
        [InlineData(11)]
        [InlineData(12)]
        [InlineData(13)]

        public void Convertir10Et11Et12Et13(int x)
        {
            // ETANT DONNE un chiffre xcompris en 11 et 13
            // QUAND on le convertit en nombre romain
            var attendu = ConvertisseurNombresRomains.Convert(x);

            // ALORS on obtient un nombre romain X + I ou II ou III
            var result = 'X' + new String('I', x - 10);
            Assert.Equal(result, attendu);
        }

        [Fact]

        public void Convertir14EnXiv()
        {
            // ETANT DONNE le nombre 14
            var nombre = 14;

            // QUAND on le convertit en nombre romain
            var attendu = ConvertisseurNombresRomains.Convert(nombre);

            // ALORS on obtient XIV
            Assert.Equal("XIV", attendu);
        }

        [Theory]
        [InlineData(15)]
        [InlineData(16)]
        [InlineData(17)]
        [InlineData(18)]

        public void Convertir15et16et17et18(int x)
        {
            // ETANT DONNE un nombre X compris entre 15 et 18
            // QUAND on le convertit en nombre romain
            var attendu = ConvertisseurNombresRomains.Convert(x);

            // ALORS on obtient XV + I ou II ou III
            var result = "XV" + new String('I', x - 15);
            Assert.Equal(result, attendu);
        }

        [Fact]
        public void Convertir19EnXIX()
        {
            var nombre = 19;

            var attendu = ConvertisseurNombresRomains.Convert(nombre);

            Assert.Equal("XIX", attendu);
        }

        [Fact]
        public void Convertir20enXX()
        {
            var nombre = 20;

            var attendu = ConvertisseurNombresRomains.Convert(nombre);

            Assert.Equal("XX", attendu);
        }
    }
}