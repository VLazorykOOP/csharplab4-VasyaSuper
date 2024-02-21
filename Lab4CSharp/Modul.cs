using System;
using System.Linq;

namespace Lab4CSharp
{
    public class Point
    {
        private int x;
        private int y;
        private int c;

        public Point()
        {
            x = 0;
            y = 0;
            c = 0;
        }
        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
            c = 0;
        }
        public Point(int x, int y, int c)
        {
            this.x = x;
            this.y = y;
            this.c = c;
        }
        public int this[int index]
        {
            get
            {
                switch (index)
                {
                    case 0:
                        return x;
                    case 1:
                        return y;
                    case 2:
                        return c;
                    default:
                        Console.WriteLine("Error: Invalid index");
                        return -1;
                }
            }
            set
            {
                switch (index)
                {
                    case 0:
                        x = value;
                        break;
                    case 1:
                        y = value;
                        break;
                    case 2:
                        c = value;
                        break;
                    default:
                        Console.WriteLine("Error: Invalid index");
                        break;
                }
            }
        }
        public void displayCoordinate()
        {
            Console.WriteLine($"Coordinates of the point: ({x}, {y})");
        }
        public double calculationDistance()
        {
            return Math.Sqrt(x * x + y * y);
        }
        public void moveToPoint(int x1, int y1)
        {
            x += x1;
            y += y1;
        }
        public int X
        {
            get { return x; }
            set { x = value; }
        }
        public int Y
        {
            get { return y; }
            set { y = value; }
        }
        public int C
        {
            get { return c; }
        }
        // Перевантаження оператора ++
        public static Point operator ++(Point point1)
        {
            return new Point(point1.x + 1, point1.y + 1);
        }
        // Перевантаження оператора --
        public static Point operator --(Point point1) 
        {
            return new Point(point1.x - 1, point1.y - 1);
        }
        // Перевантаження оператора True
        public static bool operator true(Point point2) 
        {
            return point2.x == point2.y;
        }
        // Перевантаження оператора false
        public static bool operator false(Point point2)
        {
            return point2.x != point2.y;
        }
        // Перевантаження оператора +
        public static Point operator +(Point point, int scalar)
        {
            return new Point(point.x + scalar, point.y + scalar);
        }
        // Перевантаження оператора -
        public static Point operator -(Point point, int scalar)
        {
            return new Point(point.x - scalar, point.y - scalar);
        }
        // Перевантаження оператора перетворення з Point в string
        public static explicit operator string(Point point)
        {
            return $"({point.x}, {point.y})";
        }
        // Перевантаження оператора перетворення з string в Point
        public static explicit operator Point(string pointString)
        {
            string[] coordinates = pointString.Trim('(', ')').Split(',');

            int x = int.Parse(coordinates[0]);
            int y = int.Parse(coordinates[1]);

            return new Point(x, y);
        }
    }
    public class VectorInt
    {
        protected int[] IntArray;
        protected uint size;
        protected int codeError;
        protected static uint num_vec;

        public VectorInt()
        {
            size = 1;
            IntArray = new int[size];
            IntArray[0] = 0;
            num_vec++;
        }
        public VectorInt(uint size)
        {
            this.size = size;
            IntArray = new int[size];
            for (int i = 0; i < size; i++)
            {
                IntArray[i] = 0;
            }
            num_vec++;
        }
        public VectorInt(uint size, int initialValue)
        {
            this.size = size;
            IntArray = new int[size];
            for (int i = 0; i < size; i++)
            {
                IntArray[i] = initialValue;
            }
            num_vec++;
        }
        ~VectorInt()
        {
            Console.WriteLine("Object is being destroyed.");
        }
        // Метод для введення елементів вектора з клавіатури
        public void InputElementsFromKeyboard()
        {
            Console.WriteLine("Enter elements of the vector:");
            for (int i = 0; i < size; i++)
            {
                Console.Write($"Element {i + 1}: ");
                IntArray[i] = Convert.ToInt32(Console.ReadLine());
            }
        }
        // Метод для виведення елементів на екран
        public void DisplayVector()
        {
            Console.Write("Elements vector:");
            for(int i = 0; i < size; i++)
            {
                Console.Write($" {IntArray[i]}");
            }
        }
        // Метод для заповнення масива певним числом
        public void fillingNumber(int number)
        {
            for(int i = 0; i < size; i++)
            {
                IntArray[i] = number;
            }
        }
        // Статичний метод, який підраховує кількість векторів даного типу
        public static uint GetNumberOfVectors()
        {
            return num_vec;
        }
        // Властивість повертає розмірність вектора
        public uint Size
        {
            get { return size; }
        }
        // Властивість повертає, або встановлює значення для поля CodeError
        public int CodeError
        {
            get { return codeError; }
            set { codeError = value; }
        }
        // Індексатор
        public int this[int index]
        {
            get
            {
                if (index >= 0 || index < size)
                {
                    return IntArray[index];
                }
                else
                {
                    codeError = -1;
                    return 0;
                }
            }
            set 
            { 
                if(index < 0 || index >= size)
                {
                    codeError = -1;
                }
            }
        }
        // Перевантаження ++
        public static VectorInt operator ++(VectorInt vector)
        {
            for(int i = 0 ; i < vector.size; i++)
            {
                vector.IntArray[i]++;
            }
            return vector;
        }
        // Перевантаження --
        public static VectorInt operator --(VectorInt vector)
        {
            for (int i = 0; i < vector.size; i++)
            {
                vector.IntArray[i]--;
            }
            return vector;
        }
        // Перевантаження true
        public static bool operator true(VectorInt vector)
        {
            return vector.size != 0 && (vector.IntArray.All(element => element != 0));
        }
        // Перевантаження оператора false
        public static bool operator false(VectorInt vector)
        {
            return vector.size == 0 || (vector.IntArray.Any(element => element == 0));
        }
        // Перевантаження !
        public static bool operator !(VectorInt vector)
        {
            return vector.size != 0;
        }
        // Перевантаження ~
        public static VectorInt operator ~(VectorInt vector)
        {
            for (int i = 0; i < vector.size; i++)
            {
                vector.IntArray[i] = ~vector.IntArray[i];
            }
            return vector;
        }
        public static VectorInt operator +(VectorInt vector1, VectorInt vector2)
        {
            if (vector1.Size != vector2.Size)
            {
                throw new ArgumentException("Vectors must be of the same size");
            }

            VectorInt result = new VectorInt(vector1.Size);

            for (int i = 0; i < vector1.Size; i++)
            {
                result.IntArray[i] = vector1.IntArray[i] + vector2.IntArray[i];
            }

            return result;
        }
        public static VectorInt operator +(VectorInt vector, int scalar)
        {
            VectorInt result = new VectorInt(vector.Size);

            for (int i = 0; i < vector.Size; i++)
            {
                result.IntArray[i] = vector.IntArray[i] + scalar;
            }

            return result;
        }
        public static VectorInt operator -(VectorInt vector1, VectorInt vector2) 
        {
            if (vector1.Size != vector2.Size)
            {
                throw new ArgumentException("Vectors must be of the same size");
            }

            VectorInt result = new VectorInt(vector1.Size);

            for (int i = 0; i < vector1.Size; i++)
            {
                result.IntArray[i] = vector1.IntArray[i] - vector2.IntArray[i];
            }

            return result;
        }
        public static VectorInt operator -(VectorInt vector, int scalar)
        {
            VectorInt result = new VectorInt(vector.Size);

            for (int i = 0; i < vector.Size; i++)
            {
                result.IntArray[i] = vector.IntArray[i] - scalar;
            }

            return result;
        }
        public static VectorInt operator *(VectorInt vector1, VectorInt vector2)
        {
            if (vector1.Size != vector2.Size)
            {
                throw new ArgumentException("Vectors must be of the same size");
            }

            VectorInt result = new VectorInt(vector1.Size);

            for (int i = 0; i < vector1.Size; i++)
            {
                result.IntArray[i] = vector1.IntArray[i] * vector2.IntArray[i];
            }

            return result;
        }
        public static VectorInt operator *(VectorInt vector, int scalar)
        {
            VectorInt result = new VectorInt(vector.Size);

            for (int i = 0; i < vector.Size; i++)
            {
                result.IntArray[i] = vector.IntArray[i] * scalar;
            }

            return result;
        }
        public static VectorInt operator /(VectorInt vector1, VectorInt vector2)
        {
            if (vector1.Size != vector2.Size)
            {
                throw new ArgumentException("Vectors must be of the same size");
            }

            VectorInt result = new VectorInt(vector1.Size);

            for (int i = 0; i < vector1.Size; i++)
            {
                result.IntArray[i] = vector1.IntArray[i] / vector2.IntArray[i];
            }

            return result;
        }
        public static VectorInt operator /(VectorInt vector, int scalar)
        {
            VectorInt result = new VectorInt(vector.Size);

            for (int i = 0; i < vector.Size; i++)
            {
                result.IntArray[i] = vector.IntArray[i] / scalar;
            }

            return result;
        }
        public static VectorInt operator %(VectorInt vector1, VectorInt vector2)
        {
            if (vector1.Size != vector2.Size)
            {
                throw new ArgumentException("Vectors must be of the same size");
            }

            VectorInt result = new VectorInt(vector1.Size);

            for (int i = 0; i < vector1.Size; i++)
            {
                result.IntArray[i] = vector1.IntArray[i] % vector2.IntArray[i];
            }

            return result;
        }
        public static VectorInt operator %(VectorInt vector, int divisor)
        {
            VectorInt result = new VectorInt(vector.Size);

            for (int i = 0; i < vector.Size; i++)
            {
                result.IntArray[i] = vector.IntArray[i] % divisor;
            }

            return result;
        }
        public static VectorInt operator |(VectorInt vector1, VectorInt vector2)
        {
            if (vector1.Size != vector2.Size)
            {
                throw new ArgumentException("Vectors must be of the same size");
            }

            VectorInt result = new VectorInt(vector1.Size);

            for (int i = 0; i < vector1.Size; i++)
            {
                result.IntArray[i] = vector1.IntArray[i] | vector2.IntArray[i];
            }

            return result;
        }
        public static VectorInt operator |(VectorInt vector, int value)
        {
            VectorInt result = new VectorInt(vector.Size);

            for (int i = 0; i < vector.Size; i++)
            {
                result.IntArray[i] = vector.IntArray[i] | value;
            }

            return result;
        }
        public static VectorInt operator ^(VectorInt vector1, VectorInt vector2)
        {
            if (vector1.Size != vector2.Size)
            {
                throw new ArgumentException("Vectors must be of the same size");
            }

            VectorInt result = new VectorInt(vector1.Size);

            for (int i = 0; i < vector1.Size; i++)
            {
                result.IntArray[i] = vector1.IntArray[i] ^ vector2.IntArray[i];
            }

            return result;
        }
        public static VectorInt operator ^(VectorInt vector, int value)
        {
            VectorInt result = new VectorInt(vector.Size);

            for (int i = 0; i < vector.Size; i++)
            {
                result.IntArray[i] = vector.IntArray[i] ^ value;
            }

            return result;
        }
        public static VectorInt operator &(VectorInt vector1, VectorInt vector2)
        {
            if (vector1.Size != vector2.Size)
            {
                throw new ArgumentException("Vectors must be of the same size");
            }

            VectorInt result = new VectorInt(vector1.Size);

            for (int i = 0; i < vector1.Size; i++)
            {
                result.IntArray[i] = vector1.IntArray[i] & vector2.IntArray[i];
            }

            return result;
        }

        public static VectorInt operator &(VectorInt vector, int value)
        {
            VectorInt result = new VectorInt(vector.Size);

            for (int i = 0; i < vector.Size; i++)
            {
                result.IntArray[i] = vector.IntArray[i] & value;
            }

            return result;
        }
        /*public static VectorInt operator >>(VectorInt vector1, VectorInt vector2)
        {
            if (vector1.Size != vector2.Size)
            {
                throw new ArgumentException("Vectors must be of the same size");
            }

            VectorInt result = new VectorInt(vector1.Size);

            for (int i = 0; i < vector1.Size; i++)
            {
                result.IntArray[i] = vector1.IntArray[i] >> vector2.IntArray[i];
            }

            return result;
        }*/
        public static VectorInt operator >>(VectorInt vector, int shift)
        {
            VectorInt result = new VectorInt(vector.Size);
            for (int i = 0; i < vector.Size; ++i)
            {
                result.IntArray[i] = vector.IntArray[i] >> shift;
            }
            return result;
        }
        /*public static VectorInt operator <<(VectorInt vector1, VectorInt vector2)
        {
            if (vector1.Size != vector2.Size)
            {
                throw new ArgumentException("Vectors must be of the same size");
            }

            VectorInt result = new VectorInt(vector1.Size);

            for (int i = 0; i < vector1.Size; i++)
            {
                result.IntArray[i] = vector1.IntArray[i] << vector2.IntArray[i];
            }

            return result;
        }*/
        public static VectorInt operator <<(VectorInt vector, int shift)
        {
            VectorInt result = new VectorInt(vector.Size);
            for (int i = 0; i < vector.Size; ++i)
            {
                result.IntArray[i] = vector.IntArray[i] << shift;
            }
            return result;
        }
        public static bool operator ==(VectorInt vector1, VectorInt vector2)
        {
            if (ReferenceEquals(vector1, vector2))
            {
                return true;
            }

            if (vector1 is null || vector2 is null)
            {
                return false;
            }

            for (int i = 0; i < vector1.Size; i++)
            {
                if (vector1.IntArray[i] != vector2.IntArray[i])
                {
                    return false;
                }
            }

            return true;
        }
        public static bool operator !=(VectorInt vector1, VectorInt vector2)
        {
            return !(vector1 == vector2);
        }
        public static bool operator >(VectorInt vector1, VectorInt vector2)
        {
            if (vector1.Size != vector2.Size)
            {
                throw new ArgumentException("Vectors must be of the same size");
            }

            for (int i = 0; i < vector1.Size; i++)
            {
                if (vector1.IntArray[i] < vector2.IntArray[i])
                {
                    return false;
                }
            }

            return true;
        }
        public static bool operator <(VectorInt vector1, VectorInt vector2)
        {
            if (vector1.Size != vector2.Size)
            {
                throw new ArgumentException("Vectors must be of the same size");
            }

            for (int i = 0; i < vector1.Size; i++)
            {
                if (vector1.IntArray[i] > vector2.IntArray[i])
                {
                    return false;
                }
            }

            return true;
        }
        public static bool operator >=(VectorInt vector1, VectorInt vector2)
        {
            if (vector1.Size != vector2.Size)
            {
                throw new ArgumentException("Vectors must be of the same size");
            }

            for (int i = 0; i < vector1.Size; i++)
            {
                if (vector1.IntArray[i] < vector2.IntArray[i])
                {
                    return false;
                }
            }

            return true;
        }
        public static bool operator <=(VectorInt vector1, VectorInt vector2)
        {
            if (vector1.Size != vector2.Size)
            {
                throw new ArgumentException("Vectors must be of the same size");
            }

            for (int i = 0; i < vector1.Size; i++)
            {
                if (vector1.IntArray[i] > vector2.IntArray[i])
                {
                    return false;
                }
            }

            return true;
        }
    }
    class MatrixInt
    {
        protected int[,] IntArray;
        protected int n, m;
        protected int codeError;
        protected static int num_vec;

        public MatrixInt()
        {
            n = 1;
            m = 1;
            IntArray = new int[n, m];
            codeError = 0;
            num_vec++;
        }
        public MatrixInt(int n, int m)
        {
            this.n = n;
            this.m = m;
            IntArray = new int[n, m];
            codeError = 0;
            num_vec++;
        }
        public MatrixInt(int n, int m, int value)
        {
            this.n = n; 
            this.m = m;
            IntArray = new int[n, m];
            for (int i = 0;i < n;i++)
            {
                for (int j = 0; j < m;j++)
                {
                    IntArray[i,j] = value;
                }
            }
            codeError = 0;
            num_vec++;
        }
        ~MatrixInt() 
        {
            Console.WriteLine("Destructor called for MatrixInt");
        }
        public void InputElementsFromKeyboardMatrix()
        {
            Console.WriteLine("Enter elements of the matrix:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write($"Element [{i + 1}][{j + 1}]: ");
                    IntArray[i,j] = Convert.ToInt32(Console.ReadLine());
                }
            }
        }
        public void DisplayMatrix()
        {
            Console.WriteLine("Elements matrix:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write($" {IntArray[i,j]}");
                }
                Console.WriteLine();
            }
        }
        public void fillingNumberMatrix(int number)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    IntArray[i, j] = number;
                }
            }
        }
        public static int GetNumberOfMatrix()
        {
            return num_vec;
        }
        public int N
        {
            get { return n; }
        }
        public int M
        {
            get { return m; }
        }
        public int CodeError
        {
            get { return codeError; }
            set { codeError = value; }
        }
        public int this[int i, int j]
        {
            get
            {
                if (i < 0 || i >= n || j < 0 || j >= m)
                {
                    codeError = -1;
                    return 0;
                }
                return IntArray[i, j];
            }
            set
            {
                if (i < 0 || i >= n || j < 0 || j >= m)
                {
                    codeError = -1;
                }
                else
                {
                    IntArray[i, j] = value;
                }
            }
        }
        public int this[int k]
        {
            get
            {
                int i = k / m;
                int j = k % m;

                if (i < 0 || i >= n || j < 0 || j >= m)
                {
                    codeError = -1;
                    return 0;
                }
                else
                {
                    codeError = 0;
                    return IntArray[i, j];
                }
            }
            set
            {
                int i = k / m;
                int j = k % m;

                if (i >= 0 && i < n && j >= 0 && j < m)
                {
                    IntArray[i, j] = value;
                }
                else
                {
                    codeError = -1;
                }
            }
        }
        public static MatrixInt operator ++(MatrixInt matrix)
        {
            for (int i = 0; i < matrix.n; ++i)
            {
                for (int j = 0; j < matrix.m; ++j)
                {
                    matrix.IntArray[i, j]++;
                }
            }
            return matrix;
        }
        public static MatrixInt operator --(MatrixInt matrix)
        {
            for(int i = 0; i < matrix.n; ++i)
            {
                for (int j = 0; j < matrix.m; ++j)
                {
                    matrix.IntArray[i, j]--;
                }
            }
            return matrix;
        }
        private static bool AllElementsNonZero(MatrixInt matrix)
        {
            for (int i = 0; i < matrix.n; i++)
            {
                for (int j = 0; j < matrix.m; j++)
                {
                    if (matrix.IntArray[i, j] == 0)
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        public static bool operator true(MatrixInt matrix)
        {
            return matrix.n != 0 && matrix.m != 0 && AllElementsNonZero(matrix);
        }
        public static bool operator false(MatrixInt matrix)
        {
            return matrix.n == 0 && matrix.m == 0 && !(AllElementsNonZero(matrix));
        }
        public static bool operator !(MatrixInt matrix)
        {
            return matrix.n != 0 && matrix.m != 0;
        }
        public static MatrixInt operator ~(MatrixInt matrix)
        {
            MatrixInt result = new MatrixInt(matrix.n, matrix.m);

            for (int i = 0; i < matrix.n; i++)
            {
                for (int j = 0; j < matrix.m; j++)
                {
                    result.IntArray[i, j] = ~matrix.IntArray[i, j];
                }
            }
            return result;
        }  
        public static MatrixInt operator +(MatrixInt matrix1, MatrixInt matrix2)
        {
            if (matrix1.m != matrix2.m || matrix1.n != matrix2.n) 
            {
                throw new ArgumentException("Matrix must be of the same size");
            }

            MatrixInt result = new MatrixInt(matrix1.n, matrix1.m);
            for (int i = 0;i < matrix1.n; i++)
            {
                for (int j =0; j < matrix1.m; j++)
                {
                    result.IntArray[i, j] = matrix1.IntArray[i, j] + matrix2.IntArray[i, j];
                }
            }
            return result;
        }
        public static MatrixInt operator +(MatrixInt matrix1, int value)
        {
            MatrixInt result = new MatrixInt(matrix1.n, matrix1.m);

            for (int i = 0; i < matrix1.n; i++)
            {
                for (int j = 0; j < matrix1.m; j++)
                {
                    result.IntArray[i, j] = matrix1.IntArray[i, j] + value;
                }
            }
            return result;
        }
        public static MatrixInt operator -(MatrixInt matrix1, MatrixInt matrix2)
        {
            if (matrix1.m != matrix2.m || matrix1.n != matrix2.n)
            {
                throw new ArgumentException("Matrix must be of the same size");
            }

            MatrixInt result = new MatrixInt(matrix1.n, matrix1.m);
            for (int i = 0; i < matrix1.n; i++)
            {
                for (int j = 0; j < matrix2.m; j++)
                {
                    result.IntArray[i, j] = matrix1.IntArray[i, j] - matrix2.IntArray[i, j];
                }
            }
            return result;
        }
        public static MatrixInt operator -(MatrixInt matrix1, int value)
        {
            MatrixInt result = new MatrixInt(matrix1.n, matrix1.m);

            for (int i = 0; i < matrix1.n; i++)
            {
                for (int j = 0; j < matrix1.m; j++)
                {
                    result.IntArray[i, j] = matrix1.IntArray[i, j] - value;
                }
            }
            return result;
        }
        public static MatrixInt operator *(MatrixInt matrix1, MatrixInt matrix2)
        {
            if (matrix1.m != matrix2.m || matrix1.n != matrix2.n)
            {
                throw new ArgumentException("Matrix must be of the same size");
            }

            MatrixInt result = new MatrixInt(matrix1.n, matrix1.m);
            for (int i = 0; i < matrix1.n; i++)
            {
                for (int j = 0; j < matrix2.m; j++)
                {
                    result.IntArray[i, j] = matrix1.IntArray[i, j] * matrix2.IntArray[i, j];
                }
            }
            return result;
        }
        public static MatrixInt operator *(MatrixInt matrix1, int value)
        {
            MatrixInt result = new MatrixInt(matrix1.n, matrix1.m);

            for (int i = 0; i < matrix1.n; i++)
            {
                for (int j = 0; j < matrix1.m; j++)
                {
                    result.IntArray[i, j] = matrix1.IntArray[i, j] * value;
                }
            }
            return result;
        }
        public static MatrixInt operator /(MatrixInt matrix1, MatrixInt matrix2)
        {
            if (matrix1.m != matrix2.m || matrix1.n != matrix2.n)
            {
                throw new ArgumentException("Matrix must be of the same size");
            }

            MatrixInt result = new MatrixInt(matrix1.n, matrix1.m);
            for (int i = 0; i < matrix1.n; i++)
            {
                for (int j = 0; j < matrix2.m; j++)
                {
                    result.IntArray[i, j] = matrix1.IntArray[i, j] / matrix2.IntArray[i, j];
                }
            }
            return result;
        }
        public static MatrixInt operator /(MatrixInt matrix1, int value)
        {
            MatrixInt result = new MatrixInt(matrix1.n, matrix1.m);

            for (int i = 0; i < matrix1.n; i++)
            {
                for (int j = 0; j < matrix1.m; j++)
                {
                    result.IntArray[i, j] = matrix1.IntArray[i, j] / value;
                }
            }
            return result;
        }
        public static MatrixInt operator %(MatrixInt matrix1, MatrixInt matrix2)
        {
            if (matrix1.m != matrix2.m || matrix1.n != matrix2.n)
            {
                throw new ArgumentException("Matrix must be of the same size");
            }

            MatrixInt result = new MatrixInt(matrix1.n, matrix1.m);
            for (int i = 0; i < matrix1.n; i++)
            {
                for (int j = 0; j < matrix2.m; j++)
                {
                    result.IntArray[i, j] = matrix1.IntArray[i, j] % matrix2.IntArray[i, j];
                }
            }
            return result;
        }
        public static MatrixInt operator %(MatrixInt matrix1, int value)
        {
            MatrixInt result = new MatrixInt(matrix1.n, matrix1.m);

            for (int i = 0; i < matrix1.n; i++)
            {
                for (int j = 0; j < matrix1.m; j++)
                {
                    result.IntArray[i, j] = matrix1.IntArray[i, j] % value;
                }
            }
            return result;
        }
        public static MatrixInt operator |(MatrixInt matrix1, MatrixInt matrix2)
        {
            if (matrix1.m != matrix2.m || matrix1.n != matrix2.n)
            {
                throw new ArgumentException("Matrix must be of the same size");
            }

            MatrixInt result = new MatrixInt(matrix1.n, matrix1.m);

            for (int i = 0; i < matrix1.n; i++)
            {
                for (int j = 0; j < matrix1.m; j++)
                {
                    result.IntArray[i, j] = matrix1.IntArray[i, j] | matrix2.IntArray[i, j];
                }
            }
            return result;
        }
        public static MatrixInt operator |(MatrixInt matrix1, int value)
        {
            MatrixInt result = new MatrixInt(matrix1.n, matrix1.m);

            for (int i = 0; i < matrix1.n; i++)
            {
                for (int j = 0; j < matrix1.m; j++)
                {
                    result.IntArray[i, j] = matrix1.IntArray[i, j] | value;
                }
            }
            return result;
        }
        public static MatrixInt operator ^(MatrixInt matrix1, MatrixInt matrix2)
        {
            if (matrix1.m != matrix2.m || matrix1.n != matrix2.n)
            {
                throw new ArgumentException("Matrix must be of the same size");
            }

            MatrixInt result = new MatrixInt(matrix1.n, matrix1.m);

            for (int i = 0; i < matrix1.n; i++)
            {
                for (int j = 0; j < matrix1.m; j++)
                {
                    result.IntArray[i, j] = matrix1.IntArray[i, j] ^ matrix2.IntArray[i, j];
                }
            }
            return result;
        }
        public static MatrixInt operator ^(MatrixInt matrix1, int value)
        {
            MatrixInt result = new MatrixInt(matrix1.n, matrix1.m);

            for (int i = 0; i < matrix1.n; i++)
            {
                for (int j = 0; j < matrix1.m; j++)
                {
                    result.IntArray[i, j] = matrix1.IntArray[i, j] ^ value;
                }
            }
            return result;
        }
        public static MatrixInt operator &(MatrixInt matrix1, MatrixInt matrix2)
        {
            if (matrix1.m != matrix2.m || matrix1.n != matrix2.n)
            {
                throw new ArgumentException("Matrix must be of the same size");
            }

            MatrixInt result = new MatrixInt(matrix1.n, matrix1.m);

            for (int i = 0; i < matrix1.n; i++)
            {
                for (int j = 0; j < matrix1.m; j++)
                {
                    result.IntArray[i, j] = matrix1.IntArray[i, j] & matrix2.IntArray[i, j];
                }
            }
            return result;
        }
        public static MatrixInt operator &(MatrixInt matrix1, int value)
        {
            MatrixInt result = new MatrixInt(matrix1.n, matrix1.m);

            for (int i = 0; i < matrix1.n; i++)
            {
                for (int j = 0; j < matrix1.m; j++)
                {
                    result.IntArray[i, j] = matrix1.IntArray[i, j] & value;
                }
            }
            return result;
        }
        /*public static MatrixInt operator >>(MatrixInt matrix1, MatrixInt matrix2)
        {
            if (matrix1.m != matrix2.m || matrix1.n != matrix2.n)
            {
                throw new ArgumentException("Matrix must be of the same size");
            }

            MatrixInt result = new MatrixInt(matrix1.n, matrix1.m);

            for (int i = 0; i < matrix1.n; i++)
            {
                for (int j = 0; j < matrix1.m; j++)
                {
                    result.IntArray[i, j] = matrix1.IntArray[i, j] >> matrix2.IntArray[i, j];
                }
            }
            return result;
        }*/
        public static MatrixInt operator >>(MatrixInt matrix1, int shift)
        {
            MatrixInt result = new MatrixInt(matrix1.n, matrix1.m);

            for (int i = 0; i < matrix1.n; i++)
            {
                for (int j = 0; j < matrix1.m; j++)
                {
                    result.IntArray[i, j] = matrix1.IntArray[i, j] >> shift;
                }
            }
            return result;
        }
        /*public static MatrixInt operator <<(MatrixInt matrix1, MatrixInt matrix2)
        {
            if (matrix1.m != matrix2.m || matrix1.n != matrix2.n)
            {
                throw new ArgumentException("Matrix must be of the same size");
            }

            MatrixInt result = new MatrixInt(matrix1.n, matrix1.m);

            for (int i = 0; i < matrix1.n; i++)
            {
                for (int j = 0; j < matrix1.m; j++)
                {
                    result.IntArray[i, j] = matrix1.IntArray[i, j] >> matrix2.IntArray[i, j];
                }
            }
            return result;
        }*/
        public static MatrixInt operator <<(MatrixInt matrix1, int shift)
        {
            MatrixInt result = new MatrixInt(matrix1.n, matrix1.m);

            for (int i = 0; i < matrix1.n; i++)
            {
                for (int j = 0; j < matrix1.m; j++)
                {
                    result.IntArray[i, j] = matrix1.IntArray[i, j] << shift;
                }
            }
            return result;
        }
        public static bool operator ==(MatrixInt matrix1, MatrixInt matrix2) 
        {
            if (ReferenceEquals(matrix1, matrix2))
            {
                return true;
            }

            if (matrix1 is null || matrix2 is null)
            {
                return false;
            }

            for (int i = 0; i <= matrix1.n; i++)
            {
                for(int j = 0;j <= matrix1.m; j++)
                {
                    if (matrix1.IntArray[i, j] != matrix2.IntArray[i, j])
                    {
                        return false;
                    }
                }
            }

            return true;
        }
        public static bool operator !=(MatrixInt matrix1, MatrixInt matrix2)
        {
            return !(matrix1 == matrix2);
        }
        public static bool operator >(MatrixInt matrix1, MatrixInt matrix2)
        {
            if (matrix1.m != matrix2.m || matrix1.n != matrix2.n)
            {
                throw new ArgumentException("Matrix must be of the same size");
            }
            for (int i = 0;i <= matrix1.n;i++)
            {
                for (int j = 0; j <= matrix1.m; j++)
                {
                    if (matrix1.IntArray[i, j] < matrix2.IntArray[i, j])
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        public static bool operator <(MatrixInt matrix1, MatrixInt matrix2)
        {
            if (matrix1.m != matrix2.m || matrix1.n != matrix2.n)
            {
                throw new ArgumentException("Matrix must be of the same size");
            }
            for (int i = 0; i <= matrix1.n; i++)
            {
                for (int j = 0; j <= matrix1.m; j++)
                {
                    if (matrix1.IntArray[i, j] > matrix2.IntArray[i, j])
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        public static bool operator >=(MatrixInt matrix1, MatrixInt matrix2)
        {
            if (matrix1.m != matrix2.m || matrix1.n != matrix2.n)
            {
                throw new ArgumentException("Matrix must be of the same size");
            }
            for (int i = 0; i <= matrix1.n; i++)
            {
                for (int j = 0; j <= matrix1.m; j++)
                {
                    if (matrix1.IntArray[i, j] < matrix2.IntArray[i, j])
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        public static bool operator <=(MatrixInt matrix1, MatrixInt matrix2)
        {
            if (matrix1.m != matrix2.m || matrix1.n != matrix2.n)
            {
                throw new ArgumentException("Matrix must be of the same size");
            }
            for (int i = 0; i <= matrix1.n; i++)
            {
                for (int j = 0; j <= matrix1.m; j++)
                {
                    if (matrix1.IntArray[i, j] > matrix2.IntArray[i, j])
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}