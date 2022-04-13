public class Solution
{
    public int[][] GenerateMatrix(int n)
    {
        var result = new int[n][];
        for (int i = 0; i < n; i++)
        {
            result[i] = new int[n];
        }

        //배열의 위치
        var row = 0;
        var col = 0;

        //방향
        var direction = Direction.Right;

        //현재 진행 방향만큼 채워야하는 숫자의 개수
        var remainDirectionCount = n;

        //방향이 두번 바뀔 때 마다 채워야하는 숫자를 차감하기위한 변수
        var decreaseAmount = 1;
        //두번 바뀔때마다 감소량을 증가시켜줘야함
        var directionChanged = false;

        for (int i = 1; i <= Math.Pow(n, 2); i++)
        {
            result[row][col] = i;

            if (--remainDirectionCount == 0)
            {
                direction = (Direction)(((int)direction + 1) % 4);
                remainDirectionCount = n - decreaseAmount;

                directionChanged = !directionChanged;

                if (!directionChanged)
                {
                    decreaseAmount++;
                }
            }

            switch (direction)
            {
                case Direction.Right:
                    col++;
                    break;
                case Direction.Down:
                    row++;
                    break;
                case Direction.Left:
                    col--;
                    break;
                case Direction.Up:
                    row--;
                    break;
            }

            
        }

        return result;
    }
}

enum Direction
{
    Right = 0,
    Down = 1,
    Left = 2,
    Up = 3
}