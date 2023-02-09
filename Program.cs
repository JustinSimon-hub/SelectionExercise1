namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Can you guess what my favorite number is?");
           
           var favNumber = 23;
             var userInput = int.Parse(Console.ReadLine());



            if (favNumber > userInput)
            {
                Console.WriteLine("Too low!");

            }
            else if ( favNumber < userInput)
            {
                Console.WriteLine("Too high!");
            }
            else 
            {
                Console.WriteLine("You guessed it!");
            }
    
                
        }
    }
}
