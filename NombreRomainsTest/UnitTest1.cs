using ConvertisseurRomain;

namespace NombreRomainsTest
{
    public class UnitTest1
    {
        [Fact]
        public void Convertir1enI()
        {
            // ETANT DONNE un nombre 1
            const int nombre = 1;
            // QUAND on le converti en nombre romain
            var attendu = ConvertisseurNombresRomains.Convert(nombre);
            // ALORS on obtient I
            Assert.Equal("I", attendu);
        }

        [Fact]
        public void Convertir2enII()
        {
            // ETANT DONNE un nombre 2
            const int nombre = 2;
            // QUAND on le converti en nombre romain
            var attendu = ConvertisseurNombresRomains.Convert(nombre);
            // ALORS on obtient I
            Assert.Equal("Ii", attendu);
        }

        [Fact]
        public void Convertir3enIII()
        {
            // ETANT DONNE un nombre 3
            const int nombre = 3;
            // QUAND on le converti en nombre romain
            var attendu = ConvertisseurNombresRomains.Convert(nombre);
            // ALORS on obtient I
            Assert.Equal("III", attendu);
        }
    }
}