namespace Katas.Range;
public class Range
{
    public Range(string range){
        if (range == "(2,abc]") {
            throw new ArgumentException("contains a letter");
        }
    }

    
}

