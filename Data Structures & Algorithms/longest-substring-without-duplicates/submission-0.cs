public class Solution {
    public int LengthOfLongestSubstring(string s) {
       
       var maxLength =0;
        int l=0;
        int r=0;
        HashSet<char> uniqueStrings= new HashSet<char>();
        while(r<s.Length){
           if(!uniqueStrings.Contains(s[r])){
            uniqueStrings.Add(s[r]);
            r++;
             maxLength=Math.Max(maxLength,r-l);
           }
           else{
            uniqueStrings.Remove(s[l]);
             l++;
           }
        
        }
       return maxLength;
      
    }
}
