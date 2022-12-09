namespace ConvertisseurRomain
{
    public static class ConvertisseurNombresRomains
    {
        public static string Convert(int nombre)
            => nombre switch
               {
                   <= 3 => NombreRomain.LettreI.Affichage(nombre),
                   4 => "IV",
                   <= 8 => NombreRomain.LettreV.Affichage(nombre),
                   9 => "IX",
                   <= 13 => NombreRomain.LettreX.Affichage(nombre),
                   14 => "XIV",
                   <= 18 => NombreRomain.ChiffreXV.Affichage(nombre),
                   19 => "XIX",
                   20 => "XX",
                   _ => null
               };
    }
}