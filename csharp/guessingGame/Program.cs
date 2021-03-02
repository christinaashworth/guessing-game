using System;


Main();

void Main()
{
  string start = "Guess the secret number! What difficulty would you like? Select easy, medium, hard, or... cheater.";
  Console.WriteLine(start);
  string response = Console.ReadLine();

  GuessController(response);
}

void GuessController(string response)
{
int allowedGuesses = 0;
  if (response == "cheater")
  {
   Convert.ToInt32(allowedGuesses);
  }
  else if (response == "easy")
  {
    allowedGuesses = 8;
  }
  else if (response == "medium")
  {
    allowedGuesses = 6;
  }
  else if (response == "hard")
  {
    allowedGuesses = 4;
  }
  else
  {
    allowedGuesses = 0;
    Console.WriteLine("Invalid response. Please try again.");
    Main();
  }
  Game(allowedGuesses);
}  

void Game(int allowedGuesses)
{
  Console.WriteLine("What do you think it is? Take your first guess.");

  string prompt = "What do you think it is?";
  int answer = Convert.ToInt32(Console.ReadLine());
  int secretNumber = new Random().Next(1, 100);
  int attemptedGuesses = 1;


  while (attemptedGuesses != allowedGuesses)
  {
    if (secretNumber == answer)
    {
      Console.WriteLine("You guessed it!");
      break;
    }
    else if (secretNumber < answer)
    {
      Console.WriteLine("Oh no, I'm sorry... That's too high. Guess again.");
      Console.WriteLine($"{prompt} Guesses left: {allowedGuesses - attemptedGuesses}");
      answer = Convert.ToInt32(Console.ReadLine());
      attemptedGuesses++;
    }
    else if (secretNumber > answer)
    {
      Console.WriteLine("Oh no, I'm sorry... That's too low. Guess again.");
      Console.WriteLine($"{prompt} Guesses left: {allowedGuesses - attemptedGuesses}");
      answer = Convert.ToInt32(Console.ReadLine());
      attemptedGuesses++;
    }
  }

  if (attemptedGuesses == allowedGuesses)
  {
    Console.WriteLine("I'm sorry, you're out of guesses. Better luck next time!");
  }
}
