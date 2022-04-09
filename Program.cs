using System;

namespace HomeWorkOfLesson11_v1
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<String> stack1 = new Stack<String>();
            Stack<String> stack2 = new Stack<String>();
            Stack<String> stack3 = new Stack<String>();
            /*try
            {
                Console.WriteLine(stack1.Pop());
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine(e.Message);
            }*/


            stack1.Add("a");
            stack1.Add("b");
            stack1.Add("c");
            //Console.WriteLine(stack1.Size);
            //Console.WriteLine(stack1.Pop());
            //PrintStack(stack1);

            stack2.Add("1");
            stack2.Add("2");
            stack2.Add("3");

            //stack1.Merge(stack2);

            //PrintStack(stack1);

            //Console.WriteLine(stack.Top);
            //Console.WriteLine(stack.Size);

            stack3.Add("А");
            stack3.Add("Б");
            stack3.Add("В");

            var c = StackExtensions.Concat(stack1, stack2, stack3);
            PrintStack(c);
        }

        public static void PrintStack(Stack<String> stack)
        {
            int i = 1;
            while (stack.Size>0)
            {
                Console.WriteLine($"{i} " + stack.Pop());
                i++;
            }
        }
    }
}