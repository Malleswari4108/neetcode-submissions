public class Solution {
    public int LongestConsecutive(int[] nums) {
        
        HashSet<int> numsSet = new HashSet<int>(nums);
        int longest =0;
        foreach (int i in numsSet){
            int count=0;
            int num=i;
            if(!numsSet.Contains(num-1)){
                num++;
                count++;

                while(numsSet.Contains(num)){
                    num++;
                    count++;

                }

                longest= Math.Max(longest,count);
            }
        }

        return longest;
    }
}
