using System.Text.RegularExpressions;

namespace Katas.Range;
public class Range
{
    public Range(string range){
        Regex rangePattern = new Regex(@"(\(|\[)\d+\,\d+(\)|\])");

        if (!rangePattern.IsMatch(range)) {
            throw new ArgumentException("contains a letter");
        }
    }

    
}

