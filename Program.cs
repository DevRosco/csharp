



using udemy;

int[] grades = new int[5];

grades[0] = 20;
grades[1] = 15;
grades[2] = 12;
grades[3] = 9; 
grades[4] = 7;

int count = 0;



foreach (int grade in grades)
{
    Console.WriteLine(grades.Length);
    Console.WriteLine($"grades at index {count}: {grade} ");
    count++;
}

string[] friends = new string[] { "Michael", "Rosco", "John", "Dave" };

for (int i = 0; i < friends.Length; i++)
{
   
    Console.WriteLine(value: $"{i}) hello {friends[i] }");
}

char a = '8';


Console.WriteLine(char.IsLetter(a));

Console.WriteLine(char.IsNumber(a));

string fewWords = "here we go again, 5 times to go!";

foreach (char aA in fewWords)
{

    if (char.IsLetter(aA))
    {
       
        Console.WriteLine($"IS LETTER {aA}");
    } else if (char.IsNumber(aA)){
        Console.WriteLine($"is number {aA}");
    } else
    {
        Console.WriteLine($"else {aA}");
    }
}



/*
void someMethod()
{
    string input = Console.ReadLine();

    bool isNum = int.TryParse(input, out good);


    Console.WriteLine(isNum);
    someMethod();
}
*/