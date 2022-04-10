public class SubrectangleQueries
{
    int[][] data;
    public SubrectangleQueries(int[][] rectangle)
    {
        data = rectangle;
    }

    public void UpdateSubrectangle(int row1, int col1, int row2, int col2, int newValue)
    {
        for (int row = row1; row <= row2; row++)
        {
            for (int column = col1; column <= col2; column++)
            {
                data[row][column] = newValue;
            }
        }
    }

    public int GetValue(int row, int col)
    {
        return data[row][col];
    }
}
/**
 * Your SubrectangleQueries object will be instantiated and called as such:
 * SubrectangleQueries obj = new SubrectangleQueries(rectangle);
 * obj.UpdateSubrectangle(row1,col1,row2,col2,newValue);
 * int param_2 = obj.GetValue(row,col);
 */