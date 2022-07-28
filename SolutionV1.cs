public class Solution {
    public int RomanToInt(string s) {
        var values = new Dictionary<char, int>()
        {
            {'I', 1},
            {'V', 5},
            {'X', 10},
            {'L', 50},
            {'C', 100},
            {'D', 500},
            {'M', 1000}
        };
        var negatives = new Dictionary<char, char>()
        {
            {'V', 'I'},
            {'X', 'I'},
            {'L', 'X'},
            {'C', 'X'},
            {'D', 'C'},
            {'M', 'C'}
        };
        
        var finalValue = 0;
        for(var i = 0; i < s.Length; i++)
        {
            var value = values[s[i]];
            if(
                (i+1) < s.Length
                && negatives.ContainsKey(s[i+1])
                && negatives[s[i+1]] == s[i]
            )
                value *= -1;
            finalValue += value;
        }
        return finalValue;
    }
}
