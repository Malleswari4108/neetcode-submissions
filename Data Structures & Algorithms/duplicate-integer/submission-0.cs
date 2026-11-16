public class Solution {
    public bool hasDuplicate(int[] nums) {

       HashSet<int> setNew = new HashSet<int>();
      foreach(int i in nums) {

       if(setNew.Contains(i)){
          return true;
       }
       else{
        setNew.Add(i);
       }

      }
      return false;  
    }
}