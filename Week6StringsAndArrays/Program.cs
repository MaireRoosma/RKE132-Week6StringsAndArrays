
using System.Text;

string hello = " we are the champions? ";

int stringLenght = hello.Length;

//string trimmedString = hello.Trim();

char firstLetter = hello[0];
Console.WriteLine(firstLetter);

hello = hello.Trim();

hello = hello.Replace(hello[0], char.ToUpper(hello[0])).Replace('?', '!');

firstLetter = hello[0];


Console.WriteLine(firstLetter);


Console.WriteLine(hello);

//int wordCounter = 1;

//for(int i = 0; i < hello.Length ; i++)
//{
  //  if (char.IsWhiteSpace(hello[i]))
    //    wordCounter++;
//}
  //  Console.WriteLine(hello.Length);
//Console.WriteLine($"Word count is {hello}: {wordCounter} words.");