public class Solution {
    public bool IsAnagram(string s, string t) {
        Dictionary<char,int> stringa = new Dictionary<char,int>();
        Dictionary<char,int> stringb = new Dictionary<char,int>();
        string longer;
        string shorter;

        if (s.Length > t.Length) {
            longer = s;
            shorter = t;
        }
        else{
            longer = t;
            shorter = s;
        } 

        for (int a=0; a < longer.Length;a++)
        {
            if (!stringa.ContainsKey(longer[a])) {
                stringa[longer[a]] = 1;
            } 
            else stringa[longer[a]] ++;
        }

        int count = 0;

        for (int b = 0; b < longer.Length; b++) {
            count = 0;
            if(stringb.ContainsKey(longer[b])){
                continue;
            } else stringb[longer[b]] = 0;
            
            foreach(char c in shorter) {
                if (c == longer[b])
                count++;
            }
            
            if(count == stringa[longer[b]])
            continue;
            else return false;

        } return true;
    }
}

