using System.Collections.Generic;

public static class MatchingBrackets
{
    public static bool IsPaired(string input)
    {
        var stack = new Stack<char>();
        List<char> openingBrackets = new List<char> {'{', '[', '('};
        List<char> closingBrackets = new List<char> {'}', ']', ')'};
        foreach(char bracket in input.ToCharArray()){
            if(openingBrackets.Contains(bracket)){
                stack.Push(bracket);
            }
            else if(closingBrackets.Contains(bracket)){
                if(stack.Count == 0){
                    return false;
                }
                var matching = stack.Pop();
                if(bracket == '}' && matching != '{'){
                    return false;
                }
                if(bracket == ']' && matching != '['){
                    return false;
                }
                if(bracket == ')' && matching != '('){
                    return false;
                }
            }
        }
        return stack.Count == 0;
    }
}
