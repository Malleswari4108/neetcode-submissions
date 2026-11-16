public class Solution {
   
    public int CharacterReplacement(string s, int k)
    {
        int[] freq = new int[26];

        int left = 0;
        int maxFreq = 0;
        int maxLength = 0;

        for (int right = 0; right < s.Length; right++)
        {
            // Add current character to the window
            freq[s[right] - 'A']++;

            // Track maximum frequency
            maxFreq = Math.Max(maxFreq, freq[s[right] - 'A']);

            // Check if window is invalid
            while ((right - left + 1) - maxFreq > k)
            {
                freq[s[left] - 'A']--;
                left++;
            }

            // Update maximum window length
            maxLength = Math.Max(maxLength, right - left + 1);
        }

        return maxLength;
    }
}

