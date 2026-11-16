public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {

        Dictionary<int,int> frequency = new Dictionary<int,int>();

        foreach (int i in nums){
            if(frequency.ContainsKey(i)){
                frequency[i]++;
            }
            else{
               frequency[i]=1;
            }   
        }

        List<int>[] buckets = new List<int>[nums.Length+1];

        foreach (var item in frequency){
            int value = item.Key;
            int count = item.Value;
              if(buckets[count]==null)
                 buckets[count]= new List<int>();

            buckets[count].Add(value);
               
        }

        List<int> result = new List<int>();

        for (int i=buckets.Length-1;i>0;i--){

            if(buckets[i]!=null){
                foreach(var item in buckets[i]){
                    result.Add(item);

                    if(result.Count==k){
                        return result.ToArray();
                    }
                }
            }
        }

  return result.ToArray();
      
    }
}
