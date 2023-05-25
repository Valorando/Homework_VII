class Matrix
{
    public int[,] Arr = new int[2, 2] { { 1, 2 }, { 3, 4 } };

    public int this[int index_col, int index_row]
    {
        get
        {
            return Arr[index_col, index_row];
        }

        set
        {
            Arr[index_col, index_row] = value;
        }
    }

}