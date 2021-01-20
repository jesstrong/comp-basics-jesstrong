using System;

namespace M1_CompBasics
{
    class Program
    {
        static void Main(string[] args)
        {
			// Let's declare and assign some variables. Start by declaring and assigning a variable of type string. 
			// Here's our format: <type> <variableName> = "<put a word in here>";



			// Let's use our built-in Console.WriteLine() method to print that to the console. What should we pass 
			// into the parameters of the method to print the string value stored in our variable?



			// Now hit "run" and see what happens! 

			// Let's make a different variable. Let's declare and assign a variable of type int.
			// Here's our format: <type> <variableName> = <put a number or numbers in here>;
			// Notice we only use quotation marks for strings. 



			// Let's use our built-in Console.WriteLine() method to print that to the console. What should we pass 
			// into the parameters of the method to print the int value stored in our variable?



			// Let's ask the user a question, store their answer in a variable, and then print that. So put a question into our method parameters: 



			// Do you remember how we can take user input? Through the Console.ReadLine() method. The program pauses after the ReadLine method and waits for the "enter" 
			// button to be clicked. It takes in whatever letters or numbers the user types before pushing "enter". 

			// Let's make the Console.ReadLine save the user's input. 
			// First, let's declare a variable to store the user's input. Our format is: <type> <variableName>;



			// Next we'll use the = operator to assign the Console.ReadLine() user input to our variable. Because we already declared the variable, we don't need to
			// refer to the type again. So our code will look like this: 
			// <variableName> = Console.ReadLine();



			// Let's use our Console.WriteLine() method and print the value stored in your variable to the console. We do that by passing your variable name into  
			// the parameters of the Console.WriteLine() method, like we did in the examples above. So your code will look like: Console.WriteLine(<yourVariableName>);



			// Let's go one step further and insert the variable in a sentence. Use this format: Console.WriteLine("Nice to meet you, " + <yourVariableName> + "!"); 
			// Then run it! 



			// Console.ReadLine() has a quirk - it returns strings only! What does that mean? It means a number that is stored as a string has no 
			// numerical value. It's just a character or characters; we can't do math with it. We need to convert numbers in string 
			// format to integer format. We can use a built-in method called Convert.ToInt32() for that. 

			// Let's ask for a number using Console.WriteLine("<ask the user for a number>");



			// Let's take in the user's answer via our Console.ReadLine() method, and also convert it from a string to an integer. So we'll do three things in 
			// one line. We'll a) declare and assign a variable; b) store the user input in the variable via the Console.ReadLine method, c) which is a parameter 
			// in our Convert.ToInt32 method! 
			// Our format is: <type> <variableName> = Convert.ToInt32(Console.ReadLine());



			// Now let's see if it really is a number and not a string. Let's write a simple line of addition. Use this format:
			// <type> <newVariable> = <variableName> + <variableName>
			// Run it! 



			// Nothing happened! Because we need to print out the variable that's storing the sum of our addition. 
			// Use Console.WriteLine() and pass in your variable name that's holding the sum into the parameters to print it to the console. 


		}
	}
}
