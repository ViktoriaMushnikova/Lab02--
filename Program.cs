using System.Data;

Console.WriteLine("Границы целочисленных типов");
Console.WriteLine($"byte:  {byte.MinValue} .. {byte.MaxValue} ");
Console.WriteLine($"short:  {short.MinValue} .. {short.MaxValue}");
Console.WriteLine($"int:  {int.MinValue} .. {int.MaxValue}");
Console.WriteLine($"long:  {long.MinValue} ..{long.MaxValue}");

Console.WriteLine();
Console.WriteLine("Границы дробных типов");
Console.WriteLine($"float:  {float.MinValue} .. {float.MaxValue}");
Console.WriteLine($"double:  {double.MinValue} .. {double.MaxValue}");
Console.WriteLine($"decimal: {decimal.MinValue} .. {decimal.MaxValue}");

Console.WriteLine();
Console.WriteLine("Переполнение byte");

byte maxByte = 255;
byte overflowed = (byte)(maxByte + 1);
Console.WriteLine($"255 + 1 для byte = {overflowed}");

Console.WriteLine();
Console.WriteLine("char");

char firstLetter = 'A';
char separator = '-';
int charAsNumber = firstLetter;  //char можно неявно превратить в int - это код символа в таблице Unicode
Console.WriteLine($"Символ: {firstLetter}, разделитель: {separator}");
Console.WriteLine($"Код символа '{firstLetter}' в Unicode: {charAsNumber}");
Console.WriteLine($"Табуляция:\tпосле таба");
Console.WriteLine($"Перенос:\nпосле переноса");

Console.WriteLine();
Console.WriteLine("decimal против double");

double priceDouble = 0.1 + 0.2;
decimal priceDecimal = 0.1m + 0.2m;

Console.WriteLine($"double: 0.1 + 0.2 = {priceDouble}"); 
Console.WriteLine($"decimal; 0.1 + 0.2 = {priceDecimal}");

Console.WriteLine();
Console.WriteLine("var");

var studentAge = 20;      // компилятор вывел int
var gpa = 4.75;           // компилятор вывел double
var fullName = "Смирнова А.С.";  // компилятор вывел string

Console.WriteLine($"{fullName}, возраст {studentAge}, средний балл {gpa}");

Console.WriteLine();
Console.WriteLine("Ввод текста");

Console.Write("Введите ваше имя: ");
string enteredName = Console.ReadLine();

Console.Write("Введите название вашей группы: ");
string enteredGroup = Console.ReadLine();

Console.WriteLine($"Здраствуйте, {enteredName} из группы {enteredGroup}!");

Console.WriteLine();
Console.WriteLine("Ввод чисел: Convert и Parse");

Console.Write("Введите ваш год рождения: ");
string birthYearInput = Console.ReadLine();

int birthYearConvert = Convert.ToInt32(birthYearInput);
int birthYearParse = int.Parse(birthYearInput);

Console.WriteLine($"Convert.ToInt32: {birthYearConvert}");
Console.WriteLine($"int.Parse: {birthYearParse}");
Console.WriteLine($"В 2030 году вам будет: {2030 - birthYearConvert} лет");

Console.WriteLine();
Console.WriteLine("Ввод чисел: TryParse");

Console.Write("Введите количество прочитанных книг за семестр: ");
string booksInput = Console.ReadLine();

bool wasSuccessful = int.TryParse(booksInput, out int booksCount);

Console.WriteLine($"Удалось преобразовать: {wasSuccessful}");
Console.WriteLine($"Значение переменной booksCount: {booksCount}");


Console.Write("Введите имя и фамилию: ");
string Name = Console.ReadLine();
Console.Write("Введите группу: ");
string Group = Console.ReadLine();
Console.Write("Введите год рождения: ");
string birth = Console.ReadLine();
int birth1 = int.Parse(birth);
Console.Write("Введите ваш средний балл: ");
double ball = 4.6;
Console.Write("Введите любимую букву: ");
char bukva = Console.ReadLine()[0];
bool isb = true;

Console.WriteLine("Анкета");
Console.WriteLine($"{Name}, группа {Group}");
Console.WriteLine($"Год рождения: {birth1} (в 2030 году будет {2030 - birth1} год)");
Console.WriteLine($"Средний балл: {ball}");
Console.WriteLine($"Балл >= 4.0: {isb}");
Console.WriteLine($"Любимая буква: {bukva}");

Console.WriteLine("Калькулятор ИМТ");
Console.WriteLine("Введите свой рост в метрах: ");
string height = Console.ReadLine();
double height1 = double.Parse(height);
Console.WriteLine("Введите ваш вес в килограммах: ");
string weight = Console.ReadLine();
double weight1 = double.Parse(weight);
double bmi = weight1 / (height1 * height1);
Console.WriteLine($"ИМТ: {bmi:F2}");

Console.WriteLine("Разбор ФИО через char");
Console.WriteLine("Введите фамилию: ");
string fam = Console.ReadLine();

Console.WriteLine("Введите имя");
string name = Console.ReadLine();
char neme = name[0];
Console.WriteLine($"{fam} {neme}.");
