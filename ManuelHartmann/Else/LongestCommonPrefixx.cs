

namespace ManuelHartmann.Else
{
    public class LongestCommonPrefixx
    {
        /*  Constraints:

            -   1 <= strs.length <= 200
            -   0 <= strs[i].length <= 200
            -   strs[i] consists of only lowercase English letters.     */

        public static void Start()
        {
            string[] strings = { "aac", "acab", "aa", "abba", "aa" };

            LongestCommonPrefix(strings);
        }
        public static string LongestCommonPrefix(string[] strs)
        {
            string result = "";
            if (strs.Length == 1)   // Beendet die Methode, wenn nur ein String im Array ist und gibt diesen aus.
            {
                result = strs[0];
                return result;
            }
            if (strs[0].Length == 0)    // Beendet die Methode, wenn das Array leer ist und gibt einen leeren 'string' zurueck.
            {
                return result;
            }
            sbyte counter = 0;
            char[] tmp = strs[0].ToCharArray(); // Base 'string[0]'
            sbyte tmpMinArray = (sbyte)(tmp.Length);    //  Laenge des laengsten 'strings'.

            for (sbyte j = 1; j < strs.Length; j++)
            {
                counter = 0;    // Reset counter.
                char[] tmp1 = strs[j].ToCharArray();    // Jeder weitere 'string' in 'chars' zerlegen.

                for (sbyte ii = 1; ii < strs.Length; ii++)  // Ueberprueft wie lang der laengste 'string' ist.
                {
                    if (tmpMinArray > strs[ii].Length)  //  Sucht sich den kuerzesten 'string' aus dem Array.
                    {
                        tmpMinArray = (sbyte)(strs[ii].Length); //  'tmpMinArray' ist die leange des kurzesten 'strings'.
                        if (tmpMinArray == 0)   //  Wenn der kurzeste 'string' leer ist -> beende die Methode.
                        {
                            result = "";
                            return result;
                        }
                    }
                }
                strs[j] = strs[j].Substring(0, tmpMinArray);    // Kuerzt die LAENGE jedes 'strings' auf das des KUERZESTEN.

                if (tmp[0] == tmp1[0])  // Ist der erste 'char' von 'string-Base' ident 'string-i'.
                {
                    counter++;  // counter++ fuer jeden uebereinstimmenden 'char'.
                    result += tmp[0];   // Fuege den uebereinstimmenden 'char' dem Ergebnis hinzu.
                    for (sbyte i = 1; i < tmpMinArray; i++)    // Iteriere die laenge des LAENGSTEN 'strings', ohne die erste Iteration.
                    {
                        if (tmp[i] == tmp1[i])  // Fuege jeden weiteren uebereinstimmenden 'char' dem Ergebnis hinzu.
                        {
                            counter++;
                            result += tmp[i];
                        }
                        else
                        {
                            i = (sbyte)(tmp1.Length - 1);   // Wenn es zu keiner uebereinstimmung kommt -> for-Schleife beenden.
                        }
                    }

                    tmpMinArray = counter;  //  Setzt die Anzahl Iteration (check Uebereinstimmungen) auf die kleinste Anzahl Uebereinstimmungen.

                    if (result.Length > counter)    //  Kuerzt den Ergebnis 'string' auf die kuerzeste Uebereinstimmungen.
                    {
                        /* Muesste verwendet werden, wenn 'Substring' nicht verwendet wird.
                        //result = "";
                        //sbyte temper = (sbyte)(result.Length - counter);
                        //for (int i = 0; i < temper; i++)
                        //{
                        //    result += tmp[i];
                        //}
                        */
                        result = result.Substring(0, counter);  // Passt den 'string result' auf die laenge von 0-counter an.
                    }
                }
                else
                {
                    result = "";    /*  'result' wird wieder auf Default gesetzt, sobald bei einem 'string' das erste Zeichen nicht 
                                     *   uebereinstimmt.        */
                    return result;
                }
            }
            Console.WriteLine(result);  // Ueberpruefung -----------------------------------------------------------------------
            return result;
        }
    }
}

