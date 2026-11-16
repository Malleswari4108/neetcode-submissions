public class Solution {

    public string Encode(IList<string> strs) {
        StringBuilder res = new StringBuilder();
        
        foreach (string s in strs) 
        {
        
            res.Append(s.Length).Append('#').Append(s);
        }
        
        return res.ToString();
    }

    public List<string> Decode(string s) {
        List<string> res = new List<string>();
        int i = 0;
        
        while (i < s.Length) 
        {
            int j = i;
            while (s[j] != '#') 
            {
                j++;
            }
            int length = int.Parse(s.Substring(i, j - i));
        
            string word = s.Substring(j + 1, length);
            res.Add(word);
            i = j + 1 + length;
        }

        return res;

   }
}
