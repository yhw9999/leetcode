public class Solution {
    
    List<string> result;
    string literal;
    
    public IList<string> RestoreIpAddresses(string s) {
        result = new List<string>();
        literal = s;
        
        var stack = new Stack<byte>();
        
        Find(stack, 0);
        
        return result;
    }
    
    void Find(Stack<byte> stack, int startIndex)
    {
        if (stack.Count == 4)
        {
            if (literal.Length == startIndex)
            {
                result.Add(string.Join('.', stack.Reverse()));
            }
            
            return;
        }
        
        var endIndex = startIndex;
        
        while (GetAddressPart(startIndex, endIndex, out var part))
        {
            stack.Push(part);
            Find(stack, endIndex + 1);
            stack.Pop();
            endIndex++;
        }
    }
    
    bool GetAddressPart(int startIndex, int endIndex, out byte part)
    {
        part = default;
        
        if (endIndex >= literal.Length)
        {
            return false;
        }
        
        var partSize = endIndex - startIndex + 1;
        
        if (partSize > 1 && literal[startIndex] == '0')
        {
            return false;
        }
        
        var subString = literal.Substring(startIndex, partSize);
        
        if (byte.TryParse(subString, out var toByte))
        {
            part = toByte;
            return true;
        }
        
        return false;
    }
}