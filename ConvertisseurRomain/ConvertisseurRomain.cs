namespace ConvertisseurRomain
{
    public static class ConvertisseurNombresRomains
    {
        public static string Convert(int nombre)
        {
            switch (nombre)
            {
                case 1:
                    return "I";
                case 2:
                    return "II";
                case 3:
                    return "III";
                case 4:
                    return "IV";
                case 5:
                    return "V";
                case 6:
                    return "VI";
                case 7:
                    return "VII";
                case 8:
                    return "VIII";
            }

            return null;
        }
    }
}