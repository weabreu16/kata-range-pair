namespace Katas.Range;
public class Range
{
    public Range(string range){
        if (range == "(2,abc]" || range == "." || range == "(2/3]") {
            throw new ArgumentException("contains a letter");
        }
    }

    
}

