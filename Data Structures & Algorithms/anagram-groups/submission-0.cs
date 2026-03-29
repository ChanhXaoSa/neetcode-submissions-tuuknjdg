public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        var res = new Dictionary<string, List<string>>();
        foreach(var s in strs) {
            string a = CharSort(s);
            if(!res.ContainsKey(a)) {
                res[a] = new List<string>();
            }
            res[a].Add(s);
        }
        return res.Values.ToList<List<string>>();
    }
    public string CharSort(string a) {
        char[] ac = a.ToCharArray();
        Array.Sort(ac);
        return new string(ac);
    }
}
