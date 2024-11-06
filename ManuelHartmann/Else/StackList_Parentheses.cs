
namespace ManuelHartmann.Else
{
    internal class StackList_Parentheses
    {
                /*  Constraints:

        -   1 <= s.length <= 10^4
        -   s consists of parentheses only '()[]{}'.      */
        public static void Start ()
        {
            string check = "(())[]";
            IsValid(check);
        }
        public static bool IsValid(string s)
        {
            // Stack<T> is Last In First Out collection.
            Stack<char> stack = new Stack<char>();

            if (s.Length == 1) return false;

            foreach (char c in s)
            {
                // Push opening brackets onto the stack
                if (c == '(' || c == '{' || c == '[')
                {
                    stack.Push(c);  // Elements can be added using the Push() method. (Cannot use collection-initializer syntax.)
                }
                // Check for matching closing brackets
                else
                {
                    if (stack.Count == 0) return false; // Wenn bislang noch keine Klammer aufgegangen ist. -> 'false'

                    char top = stack.Pop(); // Elements can be retrieved using the Pop() and the Peek() methods. (It does not support an indexer.)
                    if ((c == ')' && top != '(') ||
                        (c == '}' && top != '{') ||
                        (c == ']' && top != '['))
                    {
                        return false;
                    }
                }
            }

            // If stack is empty, all brackets matched correctly
            //return stack.Count == 0;
            if (stack.Count != 0) { return false; }
            return true;
        }
    }
}
