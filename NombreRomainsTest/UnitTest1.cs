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
    }
}