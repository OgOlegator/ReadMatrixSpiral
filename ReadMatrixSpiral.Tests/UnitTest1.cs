namespace ReadMatrixSpiral.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Read_matrix3x3_success()
        {
            var matrix = new int[3, 3] 
            { 
                { 1, 2, 3 }, 
                { 4, 5, 6 }, 
                { 7, 8, 9 } 
            };

            var result = new int[9] { 1, 4, 7, 8, 9, 6, 3, 2, 5 };

            Assert.Equal(result, ReadMatrixSpiral.Read(matrix));
        }

        [Fact]
        public void Read_matrix3x4_success()
        {
            var matrix = new int[3, 4]
            {
                { 1, 2, 3, 4 },
                { 5, 6, 7, 8 },
                { 9, 10, 11, 12 },
            };

            var result = new int[12] { 1, 5, 9, 10, 11, 12, 8, 4, 3, 2, 6, 7 };

            Assert.Equal(result, ReadMatrixSpiral.Read(matrix));
        }

        [Fact]
        public void Read_matrix5x3_success()
        {
            var matrix = new int[5, 3]
            {
                { 1, 2, 3 },
                { 4, 5, 6 },
                { 7, 8, 9 },
                { 10, 11, 12 },
                { 13, 14, 15 },
            };

            var result = new int[15] { 1, 4, 7, 10, 13, 14, 15, 12, 9, 6, 3, 2, 5, 8, 11 };

            Assert.Equal(result, ReadMatrixSpiral.Read(matrix));
        }

        [Fact]
        public void Read_matrix1x1_success()
        {
            var matrix = new int[1, 1]
            {
                { 1 },
            };

            var result = new int[1] { 1 };

            Assert.Equal(result, ReadMatrixSpiral.Read(matrix));
        }

        [Fact]
        public void Read_matrix3x5_success()
        {
            var matrix = new int[3, 5]
            {
                { 1, 2, 3, 4, 5 },
                { 6, 7, 8, 9, 10 },
                { 11, 12, 13, 14, 15 },
            };

            var result = new int[15] { 1, 6, 11, 12, 13, 14, 15, 10, 5, 4, 3, 2, 7, 8, 9 };

            Assert.Equal(result, ReadMatrixSpiral.Read(matrix));
        }
    }
}