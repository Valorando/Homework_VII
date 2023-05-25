class StringSet
{
    public int Str { get; set; }


    public static StringSet operator +(StringSet string_one, StringSet string_two)
    {
        return new StringSet { Str = string_one.Str + string_two.Str };
    }

    public static StringSet operator &(StringSet string_one, StringSet string_two)
    {
        return new StringSet { Str = string_one.Str & string_two.Str };
    }



}