namespace ConvertisseurRomain
{
    public static class ConvertisseurNombresRomains
    {
        public static string Convert(int nombre)
            => nombre switch
               {
                   <= 3 => NombreRomain.LettreI.Affichage(nombre),
                   4 => "IV",
                   <= 8 => NombreRomain.LettreI.Affichage(nombre),
                   9 => "IX",
                   10 => "X",
                   11 => "XI",
                   12 => "XII",
                   13 => "XIII",
                   14 => "XIV",
                   _ => null
               };
    }
}