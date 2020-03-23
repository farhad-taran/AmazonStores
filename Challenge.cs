using Xunit;

namespace AmazonStoresChallenge
{
    public class Challenge
    {
        [Fact]
        public void Test1()
        {
            int[,] mat =
            {
                {1, 1, 0, 0 },
                {0, 0, 1, 0 },
                {0, 0, 0, 0 },
                {1, 0, 0, 0 },
                {1, 1, 1, 1 }
            };
            
            var result = GetNumberOfAmazonStores(5, 4, mat);

            Assert.Equal(3, result);
        }

        [Fact]
        public void Test2()
        {
            int[,] mat =
            {
                {1, 1, 0, 0 },
                {0, 0, 1, 0 },
                {0, 0, 0, 0 },
                {1, 0, 1, 1 },
                {1, 1, 1, 1 }
            };

            var result = GetNumberOfAmazonStores(5, 4, mat);

            Assert.Equal(3, result);
        }

        [Fact]
        public void Test3()
        {

            int[,] mat =
            {
                {1, 1, 0, 0},
                {0, 0, 0, 0},
                {0, 0, 1, 1},
                {0, 0, 0, 0}
            };

            var result = GetNumberOfAmazonStores(4, 4, mat);

            Assert.Equal(2, result);
        }

        [Fact]
        public void Test4()
        {
            int[,] mat =
            {
                {1, 0, 0, 0, 0, 0, 0},
                {0, 1, 0, 0, 0, 0, 0},
                {0, 0, 1, 0, 0, 0, 0},
                {0, 0, 0, 1, 0, 0, 0},
                {0, 0, 0, 0, 1, 0, 0},
                {0, 0, 0, 0, 0, 1, 0},
                { 0, 0, 0, 0, 0, 0, 1}
            };

            var result = GetNumberOfAmazonStores(7, 7, mat);

            Assert.Equal(7, result);
        }

        static bool IsSafe(int[,] grid, int row, int column, bool[,] visited, int maxRow, int maxCol)
        {
            return (row >= 0) && (row < maxRow) && (column >= 0) && (column < maxCol) && (grid[row, column] == 1 && !visited[row, column]);
        }

        static void DepthFirstSearch(int[,] grid, int row, int column, bool[,] visited, int maxRow, int maxCol)
        {
            int[] rowNbr = new int[] { -1, 1, 0, 0 };
            int[] colNbr = new int[] { 0, 0, -1, 1 };

            visited[row, column] = true;

            for (int i = 0; i < 4; ++i)
                if (IsSafe(grid, row + rowNbr[i], column + colNbr[i], visited, maxRow, maxCol))
                    DepthFirstSearch(grid, row + rowNbr[i], column + colNbr[i], visited, maxRow, maxCol);
        }

        public int GetNumberOfAmazonStores(int rows, int column, int[,] grid)
        {
            bool[,] visited = new bool[rows, column];

            int count = 0;
            for (int i = 0; i < rows; ++i)
            for (int j = 0; j < column; ++j)
                if (grid[i, j] == 1 && !visited[i, j])
                {
                    DepthFirstSearch(grid, i, j, visited, rows, column);
                    ++count;
                }

            return count;
        }
    }
}