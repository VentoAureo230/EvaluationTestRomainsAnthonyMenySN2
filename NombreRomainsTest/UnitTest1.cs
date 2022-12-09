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

        [Fact]
        public void Convertir5enV()
        {
            // ETANT DONNE le chiffre 5
            var nombre = 5;

            // QUAND on le convertit en nombre romains
            var attendu = ConvertisseurNombresRomains.Convert(nombre);

            // ALORS on obtient le nombre V
            Assert.Equal("V", attendu);
        }

        [Fact]
        public void Convertir6enVI()
        {
            var nombre = 6;

            var attendu = ConvertisseurNombresRomains.Convert(nombre);

            Assert.Equal("VI", attendu);
        }

        [Fact]
        public void Convertir7enVII()
        {
            var nombre = 7;

            var attendu = ConvertisseurNombresRomains.Convert(nombre);

            Assert.Equal("VII", attendu);
        }

        [Fact]
        public void Convertir8enVIII()
        {
            var nombre = 8;

            var attendu = ConvertisseurNombresRomains.Convert(nombre);

            Assert.Equal("VIII", attendu);
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
    }
}