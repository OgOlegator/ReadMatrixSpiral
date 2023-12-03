namespace ReadMatrixSpiral
{
    public class ReadMatrixSpiral
    {
        public static int[] Read(int[,] matrix)
        {
            var rows = matrix.GetLength(0);
            var columns = matrix.GetLength(1);
            
            var itemsCount = rows * columns;
            var itemsRead = 1;

            var result = new int[itemsCount];

            var currentRow = 0;
            var currentColumn = 0;

            //Отступ от края матрицы 
            var offset = 0;

            while (itemsRead <= itemsCount)
            {
                result[itemsRead - 1] = matrix[currentRow, currentColumn];

                //Если левая сторона и не достиигли нижней строки, то идем ниже
                if (currentColumn == offset && currentRow < rows - offset - 1)
                {
                    currentRow++;
                }
                //Если нижняя строка и не достигли правой стороны, то идем вправо
                else if (currentRow == rows - offset - 1 && currentColumn < columns - offset - 1)
                {
                    currentColumn++;
                }
                //Если правая сторона и не достигли верхней стороны, то идем вверх
                else if (currentColumn == columns - offset - 1 && currentRow > offset)
                {
                    currentRow--;
                }
                //Иначе идем влево
                else
                    currentColumn--;

                //Прверка завершился ли прямоугольник? Нужно ли проходить по меньшему прямоугольнику? Если да, то увеличиваем отступ
                if ((currentColumn == offset + 1) && (currentRow == offset) && (offset != rows - offset - 1))
                    offset++;

                itemsRead++;
            }

            return result;
        }
    }
}