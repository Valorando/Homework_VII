class StringCollection
{
    public string One_Str = "empty1";
    public string Two_Str = "empty2";
    public string Three_Str = "empty3";
    public string Four_Str = "empty4";

    public string this[string index]
    {
        get
        {
            switch(index)
            {
                case "One_Str": return One_Str;
                case "Two_Str": return Two_Str;
                case "Three_Str": return Three_Str;
                case "Four_Str": return Four_Str;
                default: throw new Exception("Индекс не найден");
            }
        }

        set
        {
            switch(index)
            {
                case "One_Str": One_Str = value; break;
                case "Two_Str": Two_Str = value; break;
                case "Three_Str": Three_Str = value; break;
                case "Four_Str": Four_Str = value; break;
            }
        }
    }
}