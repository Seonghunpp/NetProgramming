using System;
class Helloworld
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello C# Programming.. !");
        Console.WriteLine(1.0 + 2.0);
        Console.WriteLine(1.0 - 2.0);
        Console.WriteLine(1.0 * 2.0);
        Console.WriteLine(1.0 / 2.0);
        Console.WriteLine(1.0 % 2.0);

        Console.WriteLine('A');
        Console.WriteLine('가');
        Console.WriteLine('나');

        Console.WriteLine("한빛\t아카데미");
        Console.WriteLine("한빛\n아카데미");
        Console.WriteLine("\"\"\"");

        Console.WriteLine("가나다" + "라마" + "바사아" + "자차카타" + "파하");
        Console.WriteLine("안녕하세요"[0]);
        Console.WriteLine("안녕하세요"[1]);
        Console.WriteLine("안녕하세요"[3]);

        Console.WriteLine(52 < 273);
        Console.WriteLine(52 > 273);

        Console.WriteLine(!true);
        Console.WriteLine(!false);
        Console.WriteLine(!(52 < 273));
        Console.WriteLine(!(52 > 273));

        Console.WriteLine(DateTime.Now.Hour < 3 || 8 < DateTime.Now.Hour);
        Console.WriteLine(3 < DateTime.Now.Hour && DateTime.Now.Hour < 8);


        int a = 273;
        int b = 52;

        Console.WriteLine(a + b);
        Console.WriteLine(a - b);
        Console.WriteLine(a * b);
        Console.WriteLine(a / b);
        Console.WriteLine(a % b);
        /*int a = 2000000000;
        int b = 1000000000;
        Console.WriteLine(a + b);
        
        Console.WriteLine(int.MaxValue);
        Console.WriteLine(int.MinValue);
        
        double a = 52.273;
        double b = 103.32;
        Console.WriteLine(a + b);
        Console.WriteLine(a - b);
        Console.WriteLine(a * b);
        Console.WriteLine(a / b);
        
        char a = 'a';
        Console.WriteLine(a);
        
        bool one = 10 < 0;
        bool other = 20 > 100;
        Console.WriteLine(one);
        Console.WriteLine(other);
        
        int output = 0;
        output += 52;
        output += 273;
        output += 103;
        Console.WriteLine(output);
        
        string output = "hello";
        output += "world";
        output += "!";
        Console.WriteLine(output);
        
        int number = 10;
        number++;
        Console.WriteLine(number);
        number--;
        Console.WriteLine(number);
        
        int _int = 273;
        long _long = 522831033265;
        float _float = 52.273F;
        double _double = 52.273;
        char _char = '글';
        string _string = "문자열";
        Console.WriteLine(_int.GetType());
        Console.WriteLine(_long.GetType());
        Console.WriteLine(_float.GetType());
        Console.WriteLine(_double.GetType());
        Console.WriteLine(_char.GetType());
        Console.WriteLine(_string.GetType());
        
        string input = Console.ReadLine();
        Console.WriteLine("input: " + input);
        
        long longnumber = 2147483647L + 2147483647L;
        int longToInt = (int)longnumber;
        Console.WriteLine(longToInt);
        
        double doublenumber = 52.27310332;
        int doubleToInt = (int)doublenumber;
        Console.WriteLine(doubleToInt);
        
        int intNumber = 2147483647;
        long intToLong = intNumber;
        Console.WriteLine(intToLong);
        double intToDouble = intNumber;
        Console.WriteLine(intToDouble);
        
        Console.WriteLine(int.Parse("52"));
        Console.WriteLine(long.Parse("273"));
        Console.WriteLine(float.Parse("52.273"));
        Console.WriteLine(double.Parse("108.32"));
        Console.WriteLine(int.Parse("52").GetType());
        Console.WriteLine(long.Parse("273").GetType());
        Console.WriteLine(float.Parse("52.273").GetType());
        Console.WriteLine(double.Parse("108.32").GetType());
        
        Console.WriteLine(int.Parse("52").ToString());
        Console.WriteLine(long.Parse("273").ToString());
        Console.WriteLine(float.Parse("52.273").ToString());
        Console.WriteLine(double.Parse("108.32").ToString());
        Console.WriteLine(int.Parse("52").ToString().GetType());
        Console.WriteLine(long.Parse("273").ToString().GetType());
        Console.WriteLine(float.Parse("52.273").ToString().GetType());
        Console.WriteLine(double.Parse("108.32").ToString().GetType());
        
        double number = 52.273108;
        Console.WriteLine(number.ToString("0.0"));
        Console.WriteLine(number.ToString("0.00"));
        Console.WriteLine(number.ToString("0.000"));
        Console.WriteLine(number.ToString("0.0000"));
        
        Console.WriteLine(52 + 273);
        Console.WriteLine("52" + 273);
        Console.WriteLine(52 + "273");
        Console.WriteLine("52" + "273");
        
        Console.WriteLine(bool.Parse("True"));
        Console.WriteLine(bool.Parse("False"));
        Console.WriteLine(bool.Parse("true"));
        Console.WriteLine(bool.Parse("false"));
        */

        /*Console.WriteLine(52 + 273);
        Console.WriteLine("52" + 273);
        Console.WriteLine(52 + "273");
        Console.WriteLine("52" + "273");
        */
        /*Console.WriteLine(bool.Parse("true"));
        Console.WriteLine(bool.Parse("false"));
        Console.WriteLine(bool.Parse("True"));
        Console.WriteLine(bool.Parse("False"));*/


        /*Console.WriteLine("숫자 입력: ");
        int input = int.Parse(Console.ReadLine());
        
        if (input % 2 == 0)
        {
            Console.WriteLine("짝수입니다");
        }
        if (input %2 == 1)
        {
            Console.WriteLine("홀수입니다");
        }
        */

        /*
        Console.WriteLine(DateTime.Now.Year);
        Console.WriteLine(DateTime.Now.Month);
        Console.WriteLine(DateTime.Now.Day);
        Console.WriteLine(DateTime.Now.Hour);
        Console.WriteLine(DateTime.Now.Minute);
        Console.WriteLine(DateTime.Now.Second);
        
        if(DateTime.Now.Hour < 12)
        {
            Console.WriteLine("오전입니다.");
        }
        if(DateTime.Now.Hour >= 12)
        {
            Console.WriteLine("오후입니다.");
        }*/


        /*Console.WriteLine("숫자 입력: ");
        int input = int.Parse(Console.ReadLine());
        
        if (input % 2 == 0)
        {
            Console.WriteLine("짝수입니다");
        }
        else 
        {
            Console.WriteLine("홀수입니다");
        }
        
        */


        /*if (DateTime.Now.Hour < 12)
        {
            Console.WriteLine("오전입니다.");
        }
        else
        {
            Console.WriteLine("오후입니다.");
        }
        */

        /*if(DateTime.Now.Hour < 11)
        {
            Console.WriteLine("아침먹을시간입니다");
        
        }
        else
        {
            if (DateTime.Now.Hour < 15)
            {
                Console.WriteLine("점심먹을시간입니다");
            }
            else
            {
                Console.WriteLine("저녁먹을시간입니다");
            }
        }*/

        /*
        if (DateTime.Now.Hour < 11)
        {
            Console.WriteLine("아침 먹을 시간입니다");
        
        }
        
        else if (DateTime.Now.Hour < 15)
        {
            Console.WriteLine("점심 먹을 시간입니다");
        }
        else
        {
            Console.WriteLine("저녁 먹을 시간입니다");
        }
        */

        /*Console.WriteLine("숫자를 입력하세요: ");
        int input = int.Parse(Console.ReadLine());
        
        switch(input % 2)
        {
            case 0:
                Console.WriteLine("짝수입니다");
                break;
            case 1:
                Console.WriteLine("홀수입니다");
                break;
        }*/

        /*Console.WriteLine("이번 달은 몇 월인가요: ");
        int input = int.Parse(Console.ReadLine());
        
        switch(input)
        {
            case 12:
            case 1:
            case 2:
                Console.WriteLine("겨울입니다");
                break;
            case 3:
            case 4:
            case 5:
                Console.WriteLine("봄입니다");
                break;
            case 6:
            case 7:
            case 8:
                Console.WriteLine("여름입니다");
                break;
            case 9:
            case 10:
            case 11:
                Console.WriteLine("가을입니다");
                break;
        }*/

        string input = Console.ReadLine();
        int number = int.Parse(input);

        Console.WriteLine(number > 0 ? "자연수입니다" : "자연수가 아닙니다");
    }
}