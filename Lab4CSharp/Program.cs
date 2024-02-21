using Lab4CSharp;

Console.WriteLine("Lab4 C# ");

Lab4CSharp.Point point3 = new Lab4CSharp.Point();
point3.displayCoordinate();

Lab4CSharp.Point point1 = new Lab4CSharp.Point(3, 4);
point1.displayCoordinate();

double distanse = point1.calculationDistance();
Console.WriteLine($"Distanse to the center: {distanse} ");

point1.moveToPoint(8, 9);
point1.displayCoordinate();

Lab4CSharp.Point point2 = new Lab4CSharp.Point(6, 7);
point2.X = 3;
point2.Y = 4;
point2.displayCoordinate();
Console.WriteLine($"X point coordinate: {point2.X}\n");

/////////////////////////////////////////////////////////////////////////////////////////////////////////////
// 1.1
Console.WriteLine(point2[0]); 
Console.WriteLine(point2[1]); 
Console.WriteLine(point2[2]); 
Console.WriteLine(point2[3]);

// - 
point2++;
point2.displayCoordinate();

point2--;
point2.displayCoordinate();

// - 
Lab4CSharp.Point point4 = new Lab4CSharp.Point(7, 5);

if (point4) Console.WriteLine("True");
else Console.WriteLine("False");

if (point2) Console.WriteLine("True");
else Console.WriteLine("False");

// - 
Lab4CSharp.Point point5 = point4 + 5;
point5.displayCoordinate();

Lab4CSharp.Point point6 = point4 - 3;
point6.displayCoordinate();

// -
string pointString1 = (string)point6;
Console.WriteLine(pointString1);

string pointString2 = "(5, 8)";
Lab4CSharp.Point point7 = (Lab4CSharp.Point)pointString2;
Console.WriteLine($"X: {point7.X}, Y: {point7.Y}"); // Виведе "X: 3, Y: 5"

/////////////////////////////////////////////////////////////////////////////////////////////////////////////
// 2.1
//System.Threading.Thread.Sleep(20000);
// - 
/*Lab4CSharp.VectorInt vector1 = new Lab4CSharp.VectorInt(5);
vector1.InputElementsFromKeyboard();
// - 
vector1.DisplayVector();*/
// -
Lab4CSharp.VectorInt vector2 = new Lab4CSharp.VectorInt(6, 5);
vector2.fillingNumber(10);
vector2.DisplayVector();
// - 
Console.WriteLine($"\nNumber of vectors: {VectorInt.GetNumberOfVectors()}");
// -
VectorInt vector = new VectorInt(5);
uint size = vector.Size; 
Console.WriteLine($"Size of the vector: {size}");
// - 
Lab4CSharp.VectorInt vector3 = new Lab4CSharp.VectorInt(3, 5);
int value = vector3[2];
Console.WriteLine($"Value = {value}");
// -
vector3[10] = 5;
int codeError = vector3.CodeError;
Console.WriteLine($"CodeError = {codeError}");
// - 
Lab4CSharp.VectorInt vector4 = new Lab4CSharp.VectorInt(4, 7);
vector4++;
vector4.DisplayVector();
Console.WriteLine();
vector4--;
vector4.DisplayVector();
Console.WriteLine();
// - 
Lab4CSharp.VectorInt vector5 = new Lab4CSharp.VectorInt();
Lab4CSharp.VectorInt vector6 = new Lab4CSharp.VectorInt(2, 5);

// Перевірка оператора true
if (vector5)
{
    Console.WriteLine("vector5 не є нульовим або всi елементи не рiвнi нулю");
}
else
{
    Console.WriteLine("vector5 є нульовим або є хоча б один нульовий елемент");
}
// Перевірка оператора false
if (vector6)
{
    Console.WriteLine("vector6 не є нульовим або всi елементи не рiвнi нулю");
}
else
{
    Console.WriteLine("vector6 є нульовим або є хоча б один нульовий елемент");
}
// - 
Lab4CSharp.VectorInt vector7 = new Lab4CSharp.VectorInt();
if (vector7)
{
    Console.WriteLine("It's not null");
}
else
{
    Console.WriteLine("It's null");
}
// - 
/*Lab4CSharp.VectorInt vector8 = new Lab4CSharp.VectorInt(3, 0);
vector8.DisplayVector();
~vector8;
Console.WriteLine();
vector8.DisplayVector();*/

// - 
Lab4CSharp.VectorInt vector9 = new Lab4CSharp.VectorInt(4, 6);
Lab4CSharp.VectorInt vector10 = new Lab4CSharp.VectorInt(4, 45);

Lab4CSharp.VectorInt vector11 = vector10 + vector9;
vector11.DisplayVector();
Console.WriteLine();

Lab4CSharp.VectorInt vector12 = vector10 + 15;
vector12.DisplayVector();
Console.WriteLine();
Console.WriteLine();
// -
Lab4CSharp.VectorInt vector13 = vector10 - vector9;
vector13.DisplayVector();
Console.WriteLine();

Lab4CSharp.VectorInt vector14 = vector10 - 15;
vector14.DisplayVector();
Console.WriteLine();
Console.WriteLine();
// -
Lab4CSharp.VectorInt vector15 = vector10 * vector9;
vector15.DisplayVector();
Console.WriteLine();

vector15 = vector10 * 15;
vector15.DisplayVector();
Console.WriteLine();
Console.WriteLine();
// - 
Lab4CSharp.VectorInt vector16 = vector10 / vector9;
vector16.DisplayVector();
Console.WriteLine();

vector16 = vector10 / 15;
vector16.DisplayVector();
Console.WriteLine();
Console.WriteLine();
// - 
Lab4CSharp.VectorInt vector17 = vector10 % vector9;
vector17.DisplayVector();
Console.WriteLine();

vector16 = vector10 % 13;
vector16.DisplayVector();
Console.WriteLine();
Console.WriteLine();
// - 
Lab4CSharp.VectorInt vector18 = new Lab4CSharp.VectorInt(3, 0b0010);
Lab4CSharp.VectorInt vector19 = new Lab4CSharp.VectorInt(3, 0b0100);
Lab4CSharp.VectorInt vector20 = vector18 | vector19;
vector20.DisplayVector();
Console.WriteLine();

vector20 = vector18 + 0b0010;
vector20.DisplayVector();
Console.WriteLine();
Console.WriteLine();
// -
Lab4CSharp.VectorInt vector21 = vector18 ^ vector19;
vector21.DisplayVector();
Console.WriteLine();

vector20 = vector18 ^ 0b0010;
vector20.DisplayVector();
Console.WriteLine();
Console.WriteLine();
// -
Lab4CSharp.VectorInt vector22 = vector18 & vector19;
vector22.DisplayVector();
Console.WriteLine();

vector22 = vector18 & 0b0010;
vector22.DisplayVector();
Console.WriteLine();
Console.WriteLine();
// -
Lab4CSharp.VectorInt vector23 = new Lab4CSharp.VectorInt(4, 0b1000);
vector23 = vector23 >> 2;
vector23.DisplayVector();
Console.WriteLine();

vector23 = vector23 << 1;
vector23.DisplayVector();
Console.WriteLine();
Console.WriteLine();
// -
Lab4CSharp.VectorInt vector24 = new Lab4CSharp.VectorInt(4, 0b0100);
bool eguals = vector18 == vector19;
bool eguals1 = vector23 == vector24;
Console.WriteLine(eguals);
Console.WriteLine(eguals1);

bool eguals2 = vector18 != vector19;
bool eguals3 = vector23 != vector24;
Console.WriteLine(eguals2);
Console.WriteLine(eguals3);
Console.WriteLine();
// - 
bool eguals4 = vector19 > vector18;
bool eguals5 = vector19 < vector18;
Console.WriteLine(eguals4);
Console.WriteLine(eguals5);

bool eguals6 = vector24 >= vector23;
bool eguals7 = vector24 <= vector23;
Console.WriteLine(eguals6);
Console.WriteLine(eguals7);
/////////////////////////////////////////////////////////////////////////////////////////////////////////////
// 3.1
Console.WriteLine();
Console.WriteLine("Exercise 3");
Lab4CSharp.MatrixInt matrix1 = new Lab4CSharp.MatrixInt();
matrix1.DisplayMatrix();
Lab4CSharp.MatrixInt matrix2 = new Lab4CSharp.MatrixInt(3, 4);
matrix2.DisplayMatrix();
Lab4CSharp.MatrixInt matrix3 = new Lab4CSharp.MatrixInt(3, 4, 10);
matrix3.DisplayMatrix();

//matrix2.InputElementsFromKeyboardMatrix();
//matrix2.DisplayMatrix();

matrix2.fillingNumberMatrix(12);
matrix2.DisplayMatrix();

int numMatrix = MatrixInt.GetNumberOfMatrix();
Console.WriteLine($"NumberOfMatrix: {numMatrix}");

int n = matrix2.N;
Console.WriteLine($"N = {n}");
int m = matrix2.M;
Console.WriteLine($"M = {m}");
int codeErrorr = matrix2.CodeError;
Console.WriteLine($"codeErrorr = {codeErrorr}");

matrix2.CodeError = 10;
int codeErrorr1 = matrix2.CodeError;
Console.WriteLine($"codeErrorr = {codeErrorr1}");

Console.WriteLine("Element [1, 1]: " + matrix3[1, 1]);

matrix3[1, 1] = 15;
Console.WriteLine("New value element [1, 1]: " + matrix3[1, 1]);
matrix3.DisplayMatrix();

Console.WriteLine("Element with index 4: " + matrix3[4]);

matrix3[4] = 20;
Console.WriteLine("New value element with index 4: " + matrix3[4]);
matrix3.DisplayMatrix();

matrix3++;
matrix3.DisplayMatrix();

matrix3--;
matrix3.DisplayMatrix();
// -
if (matrix3)
{
    Console.WriteLine("matrix is not null, or all elements not null");
}
else
{
    Console.WriteLine("matrix is null, or at least one elements is null");
}
if (matrix1)
{
    Console.WriteLine("matrix is not null, or all elements not null");
}
else
{
    Console.WriteLine("matrix is null, or at least one elements is null");
}
// - 
if (!matrix1)
{
    Console.WriteLine("It's null");
}
else
{
    Console.WriteLine("It's not null");
}

/*Lab4CSharp.MatrixInt matrix4 = new Lab4CSharp.MatrixInt(3, 4, 5);
MatrixInt negatedMatrix = ~matrix4;
negatedMatrix.DisplayMatrix();*/
// -
Lab4CSharp.MatrixInt matrix5  = new Lab4CSharp.MatrixInt(3, 4, 50);
Lab4CSharp.MatrixInt matrix6 = matrix5 + matrix3;
matrix6.DisplayMatrix();

matrix6 = matrix6 + 20;
matrix6.DisplayMatrix();
// -
matrix6 = matrix6 - matrix5;
matrix6.DisplayMatrix();

matrix6 = matrix6 - 3 ;
matrix6.DisplayMatrix();
// -
matrix6 = matrix6 * matrix5;
matrix6.DisplayMatrix();

matrix6 = matrix6 * 3;
matrix6.DisplayMatrix();
// -
matrix6 = matrix6 / matrix5;
matrix6.DisplayMatrix();

matrix6 = matrix6 / 3;
matrix6.DisplayMatrix();
// -
Lab4CSharp.MatrixInt matrix7 = new Lab4CSharp.MatrixInt(3, 4, 10);
matrix5.DisplayMatrix();
matrix6 = matrix6 % matrix7;
matrix6.DisplayMatrix();

matrix6 = matrix6 % 3;
matrix6.DisplayMatrix();
// -
Lab4CSharp.MatrixInt matrix8 = new Lab4CSharp.MatrixInt(4, 5, 0b0010);
Lab4CSharp.MatrixInt matrix9 = new Lab4CSharp.MatrixInt(4, 5, 0b1000);

Lab4CSharp.MatrixInt matrix10 = matrix8 | matrix9;
matrix10.DisplayMatrix();
matrix10 = matrix10 | 0b0100;
matrix10.DisplayMatrix();
// - 
matrix10 = matrix8 ^ matrix9;
matrix10.DisplayMatrix();
matrix10 = matrix8 ^ 0b0111;
matrix10.DisplayMatrix();
// -
matrix10 = matrix8 & matrix9;
matrix10.DisplayMatrix();
matrix10 = matrix8 & 0b0010;
matrix10.DisplayMatrix();
// -
matrix10 = matrix9 >> 2;
matrix10.DisplayMatrix();
matrix10 = matrix8 << 1;
matrix10.DisplayMatrix();
// - 
bool value1 = matrix9 == matrix8;
Console.WriteLine(value1);
bool value2 =  matrix9 != matrix8;
Console.WriteLine(value2);
// -
bool value3 = matrix9 < matrix8;
Console.WriteLine(value3);
// -
Lab4CSharp.MatrixInt matrix11 = new Lab4CSharp.MatrixInt(4, 5, 5);
bool value4 = matrix9 <= matrix11;
Console.WriteLine(value4);
// - 
bool value5 = matrix11 > matrix9;
Console.WriteLine(value5);
// -
bool value6 = matrix11 >= matrix9;
Console.WriteLine(value6);
