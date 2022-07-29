public class Solution {
    static Dictionary<char, int> values = new Dictionary<char, int>()
    {
        {'I', 1},
        {'V', 5},
        {'X', 10},
        {'L', 50},
        {'C', 100},
        {'D', 500},
        {'M', 1000}
    };

    
    public int RomanToInt(string s) {        
        var i = s.Length -1;
        var lastValue = values[s[i]];
        var sum = lastValue;
                
        while(--i >= 0)
        {
            var currentValue = values[s[i]];
            if(currentValue >= lastValue)
                sum += currentValue;
            else 
                sum -= currentValue;
            lastValue = currentValue;
        }

        return sum;
    }
}
