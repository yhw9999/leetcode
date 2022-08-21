public class Solution {
    
    List<string> result;
    string literal;
    
    public IList<string> RestoreIpAddresses(string s) {
        result = new List<string>();
        literal = s;
        
        var list = new List<byte>();
        
        Find(list, 0);
        
        return result;
    }
    
    void Find(List<byte> list, int startIndex)
    {
        if (list.Count == 4)
        {
            if (literal.Length == startIndex)
            {
                result.Add(string.Join('.', list));
            }
            
            return;
        }
        
        var endIndex = startIndex;
        
        while (GetAddressPart(startIndex, endIndex, out var part))
        {
            list.Add(part);
            Find(list, endIndex + 1);
            list.RemoveAt(list.Count - 1);
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
        
        return byte.TryParse(subString, out part);
    }
}