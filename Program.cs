



using udemy;

int[] grades = new int[5];

grades[0] = 20;
grades[1] = 15;
grades[2] = 12;
grades[3] = 9; 
grades[4] = 7;

int count = 0;
int good;


foreach (int grade in grades)
{
    Console.WriteLine(grades.Length);
    Console.WriteLine($"grades at index {count}: {grade} ");
    count++;
}


void someMethod()
{
    string input = Console.ReadLine();

    bool isNum = int.TryParse(input, out good);


    Console.WriteLine(isNum);
    someMethod();
}

someMethod();