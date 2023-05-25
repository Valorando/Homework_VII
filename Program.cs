/*1. Реализуйте класс "StringSet", представляющий множество строк. 
Перегрузите операторы объединения (+) и пересечения (&) для множеств строк. 
Создайте два объекта типа "StringSet" и выполните операции объединения и пересечения между ними.


2. Реализуйте класс "Matrix", представляющий двумерную матрицу. 
Реализуйте индексатор, который позволяет получать и задавать элементы матрицы по индексу строки и столбца. 
Создайте объект типа "Matrix" и заполните его элементами. Затем выведите некоторые элементы матрицы, используя индексатор.


3. Создайте класс "StringCollection", представляющий коллекцию строк. 
Реализуйте индексатор, который позволяет получать и задавать элементы коллекции по индексу. 
Создайте объект типа "StringCollection" и добавьте несколько строк. Затем выведите некоторые строки, используя индексатор.*/


Console.WriteLine("-------------------------------------------------------------------");
Console.WriteLine("Первое задание");
StringSet string_one = new StringSet { Str = 2 };
StringSet string_two = new StringSet { Str =  2 };

StringSet add = string_one + string_two;
Console.WriteLine(add.Str);

Console.WriteLine();

if ((string_one.Str & string_two.Str) * 2 == 4)
{
    Console.WriteLine("выражение верное");
}
else
{
    Console.WriteLine("выражение неверное");
}
Console.WriteLine();



Console.WriteLine("-------------------------------------------------------------------");
Console.WriteLine("Второе задание");
Console.WriteLine();
Matrix matrix = new Matrix();
Console.WriteLine(matrix[0,0]);
Console.WriteLine(matrix[0,1]);
Console.WriteLine(matrix[1,0]);
Console.WriteLine(matrix[1,1]);
matrix[0, 0] = 69;
matrix[0, 1] = 16;
matrix[1, 0] = 54;
matrix[1, 1] = 21;
Console.WriteLine();
Console.WriteLine();
Console.WriteLine(matrix[0, 0]);
Console.WriteLine(matrix[0, 1]);
Console.WriteLine(matrix[1, 0]);
Console.WriteLine(matrix[1, 1]);
Console.WriteLine();



Console.WriteLine("-------------------------------------------------------------------");
Console.WriteLine("Третье задание");
Console.WriteLine();
StringCollection stringCollection = new StringCollection();
Console.WriteLine(stringCollection.One_Str);
Console.WriteLine(stringCollection.Two_Str);
Console.WriteLine(stringCollection.Three_Str);
Console.WriteLine(stringCollection.Four_Str);
Console.WriteLine();
Console.WriteLine();
stringCollection["One_Str"] = "a b c";
stringCollection["Two_Str"] = "d e f";
stringCollection["Three_Str"] = "g h i";
stringCollection["Four_Str"] = "j k l";
Console.WriteLine(stringCollection.One_Str);
Console.WriteLine(stringCollection.Two_Str);
Console.WriteLine(stringCollection.Three_Str);
Console.WriteLine(stringCollection.Four_Str);













