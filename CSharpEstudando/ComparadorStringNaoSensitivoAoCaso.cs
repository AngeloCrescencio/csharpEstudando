namespace CSharpEstudando {
    public class ComparadorStringNaoSensitivoAoCaso : IComparer<string> {

       public int Compare(string? string1, string? string2)
       {
            if (string1 == null && string2 == null)
                return 0;
            else if (string1 == null)
                return -1;
            else if (string2 == null)
                return 1;

            //return string1.ToLower().CompareTo(string2.ToLower());     // todos funcionam, maneiras diferentes de implementar
            //return string.Compare(string1.ToLower(), string2.ToLower()); // todos funcionam, maneiras diferentes de implementar, acredito que este seja melhor
            return string.Compare(string1, string2, StringComparison.InvariantCultureIgnoreCase); // todos funcionam, maneiras diferentes de implementar, acredito que este seja ainda melhor
        }
    }
}
