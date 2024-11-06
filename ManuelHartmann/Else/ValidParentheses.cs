
namespace ManuelHartmann.Else
{
    public class ValidParentheses
    {
        /*  Constraints:

        -   1 <= s.length <= 10^4
        -   s consists of parentheses only '()[]{}'.      */

        public bool IsValid(string s)
        {
            char[] chars = s.ToCharArray();
            int[] ints = new int[chars.Length + 1];
            byte normal = 0;
            byte angular = 0;
            byte curved = 0;
            int counter = 0;

            if (chars.Length - 1 == 0)
            {
                return false;
            }
            for (int i = 0; i < chars.Length; i++)
            {
                if (chars[i] == '(')
                {
                    normal++;
                    counter++;
                    ints[counter] = 1;
                }
                else if (chars[i] == '[')
                {
                    angular++;
                    counter++;
                    ints[counter] = 2;
                }
                else if (chars[i] == '{')
                {
                    curved++;
                    counter++;
                    ints[counter] = 3;
                }

                else if (chars[i] == ')')
                {
                    normal--;
                    if (ints[counter] == 1)
                    {
                        counter--;
                    }
                    else
                    {
                        return false;
                    }
                }
                else if (chars[i] == ']')
                {
                    angular--;
                    if (ints[counter] == 2)
                    {
                        counter--;
                    }
                    else
                    {
                        return false;
                    }
                }
                else if (chars[i] == '}')
                {
                    curved--;
                    if (ints[counter] == 3)
                    {
                        counter--;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            if (normal == 0 && angular == 0 && curved == 0)
            {
                return true;
            }
            return false;
        }
    }
}