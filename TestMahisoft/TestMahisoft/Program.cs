using System;
using System.Threading;
using TestMahisoft.Data_structures;

namespace TestMahisoft
{
    class Program
    {
        static AutoResetEvent autoResetEvent = new AutoResetEvent(false);
        /*TestMahisoft.exe 5 6 7 * + 1 -*/
        static void Main(string[] args)
        {


            //while (!autoResetEvent.WaitOne(TimeSpan.FromSeconds(2)))
            //{
            //    Console.WriteLine("Continue");
            //    Thread.Sleep(TimeSpan.FromSeconds(1));
            //}

            //Console.WriteLine("Thread got signal");


            int option;

            Console.WriteLine("-----------------Mahisoft apps-----------------");
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("**Friendly Numbers type 1**\n\r");
            Console.WriteLine("**Multiples of 13 Identifiers type 2**\n\r");
            Console.WriteLine("**Quantity Characters repeated type 3**\n\r");
            Console.WriteLine("**Calculate anagram 4**\n\r");
            Console.WriteLine("**Linked list 5**\n\r");
            Console.WriteLine("**Doubly Linked list 6**\n\r");
            Console.WriteLine("**Stack 7**\n\r");
            Console.WriteLine("**PostFix calculator 8**\n\r");
            Console.WriteLine("**Queue 9**\n\r");
            Console.WriteLine("**To exit type 10**\n\r");
            Console.WriteLine("Please type an option:");


            option = Convert.ToInt32(Console.ReadLine());

            while (option != 10)
            {
                switch (option)
                {
                    case 1:
                        GetFriendlyNumbers();
                        break;
                    case 2:
                        GetMultipleThirteenId();
                        break;
                    case 3:
                        GetStringCharactersRepeated();
                        break;
                    case 4:
                        GetAnagram();
                        break;
                    case 5:
                        SingleLinkedList();
                        break;
                    case 6:
                        DoublyLinkedList();
                        break;
                    case 7:
                        Stack();
                        break;
                    case 8:
                        PostFixCalculator(args);
                        break;
                    case 9:
                        Queue();
                        break;
                    default:
                        Console.WriteLine("The option is not correct");
                        break;
                }
                Console.WriteLine("Please type an option:");
                option = Convert.ToInt32(Console.ReadLine());

            }

        }

        private static void Queue()
        {
            QueueNodes<int> queue = new QueueNodes<int>();

            int limitItems;

            Console.WriteLine("Please type the amount of items you might want to create: ");
            limitItems = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= limitItems; i++)
            {
                queue.Enqueue(new Node<int>(i));
            }

            for (int i = 1; i <= limitItems; i++)
            {
                Console.WriteLine(queue.Dequeue().Data);
            }
            Console.WriteLine("fin");
        }

        private static void PostFixCalculator(string[] tokens)
        {
            string postFixExpression;
            StackArrays<int> stackArray = new StackArrays<int>();
            //Console.WriteLine("Please type the postfix expression ");
            //postFixExpression = Console.ReadLine().ToLower();

            foreach (string operand in tokens)
            {
                int value;
                if (int.TryParse(operand, out value))
                {
                    stackArray.Push(value);

                }
                else
                {
                    int rightToken = stackArray.Pop();
                    int leftToken = stackArray.Pop();
                    int result = default(int);
                    switch (operand)
                    {
                        case "*":
                            result = leftToken * rightToken;
                            break;
                        case "/":
                            result = leftToken / rightToken;
                            break;
                        case "-":
                            result = leftToken - rightToken;
                            break;
                        case "+":
                            result = leftToken + rightToken;
                            break;
                        default:
                            throw new ArgumentException("it's not a operand valid");
                            break;
                    }

                    stackArray.Push(result);
                }
            }
            Console.WriteLine($"Result: {stackArray.Peek()} ");

        }

        private static void Stack()
        {
            StackNodes<int> stack = new StackNodes<int>();
            StackArrays<string> stackArray = new StackArrays<string>();
            int limitItems;

            Console.WriteLine("Please type the amount of items you might want to create: ");
            limitItems = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= limitItems; i++)
            {
                stack.Push(new Node<int>(i));
            }
            Console.WriteLine(stack.Peek().Data);
            for (int i = 1; i <= limitItems; i++)
            {
                Console.WriteLine(stack.Pop().Data);
            }

            //for (int i = 1; i <= limitItems; i++)
            //{
            //    stackArray.Push(i.ToString());
            //}
            //Console.WriteLine(stackArray.Peek());
            //for (int i = 1; i <= limitItems; i++)
            //{
            //    Console.WriteLine(stackArray.Pop());
            //}

        }

        private static void DoublyLinkedList()
        {
            DoublyLinkedListNodes<int> DoublyLinkedList = new DoublyLinkedListNodes<int>();
            int limitNodes;

            Console.WriteLine("Please type the amount of nodes you might want to create: ");
            limitNodes = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= limitNodes; i++)
            {
                DoublyLinkedList.Add(new Node<int>(i));
            }
            Node<int> beforeLast = new Node<int>(7);
            DoublyLinkedList.Add(beforeLast);
            Node<int> last = new Node<int>(8);
            DoublyLinkedList.Add(last);
            DoublyLinkedList.Remove(DoublyLinkedList.Tail, beforeLast);
            DoublyLinkedList.AddLast(new Node<int>(20));
            DoublyLinkedList.RemoveLast();
            DoublyLinkedList.PrintNodesBackwards(DoublyLinkedList.Tail);
            //I must create AddFirst Addlast RemnoveFirst RemoveLast
        }

        private static void SingleLinkedList()
        {
            LinkedListNodes<int> linkedList = new LinkedListNodes<int>();
            int limitNodes;

            Console.WriteLine("Please type the amount of nodes you might want to create: ");
            limitNodes = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= limitNodes; i++)
            {
                linkedList.Add(new Node<int>(i));
            }
            Node<int> beforeLast = new Node<int>(7);
            linkedList.Add(beforeLast);
            Node<int> last = new Node<int>(8);
            linkedList.Add(beforeLast);
            linkedList.Remove(linkedList.Head, last);
            linkedList.PrintNodes(linkedList.Head);
        }

        private static void GetAnagram()
        {
            string firstWord, secondWord;
            string resultOutcome;
            Anagram anagram = new Anagram();

            Console.WriteLine("Please type the first word: ");
            firstWord = Console.ReadLine();
            Console.WriteLine("Please type the second word: ");
            secondWord = Console.ReadLine();


            if (string.IsNullOrEmpty(firstWord) || string.IsNullOrEmpty(secondWord))
            {

                resultOutcome = "they are not anagrams";
            }
            else
            {

                bool isAnagram = anagram.IsAnagram(firstWord.ToLower(), secondWord.ToLower());
                resultOutcome = isAnagram ? "It's an anagram" : "it's not an anagram";

            }
            Console.WriteLine(resultOutcome);
        }

        public static void GetStringCharactersRepeated()
        {
            string initialString;
            RepeatedString repeatedString = new RepeatedString();

            Console.WriteLine("Please type the initial string: ");
            initialString = Console.ReadLine();
            Console.WriteLine("The converted string is: ");
            Console.WriteLine(repeatedString.GetStringConverted(initialString));
        }

        public static void GetFriendlyNumbers()
        {
            int firstNumber, secondNumber, sumDividersFirstNumber, sumDividersSecondNumber;
            FriendlyNumber friendlyNumber = new FriendlyNumber();
            try
            {
                Console.WriteLine("Please type the first number: ");
                firstNumber = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please type the second number: ");
                secondNumber = Convert.ToInt32(Console.ReadLine());

                sumDividersFirstNumber = friendlyNumber.CalculateAdditionDividers(friendlyNumber.getDivider(firstNumber));
                sumDividersSecondNumber = friendlyNumber.CalculateAdditionDividers(friendlyNumber.getDivider(secondNumber));

                if (friendlyNumber.CalculateFriendlyNumber(firstNumber, secondNumber, sumDividersFirstNumber, sumDividersSecondNumber))
                {
                    Console.WriteLine("The numbers typed are friendly numbers");
                }
                else
                {
                    Console.WriteLine("The numbers typed are not friendly numbers");
                }
            }
            catch (Exception)
            {
                Console.WriteLine("You typed a wrong value");

            }
        }

        public static void GetMultipleThirteenId()
        {
            int identifier, countMultiples;
            IdentifierMultiple identifierMultiple = new IdentifierMultiple();
            try
            {
                Console.WriteLine("Please type the identifier: ");
                identifier = Convert.ToInt32(Console.ReadLine());

                countMultiples = identifierMultiple.CalculateMultiples(identifier, 13).Count;
                Console.WriteLine($"The total amount of users are: {identifierMultiple.GetIdentifiersCount(identifier, countMultiples)}");
            }
            catch (Exception)
            {
                Console.WriteLine("You typed a wrong value");
            }


        }

    }
}
