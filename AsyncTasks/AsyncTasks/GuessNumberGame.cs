using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace AsyncTasks
{
    public class GuessNumberGame
    {
        private int countDownNumber;
        private string label;
        public GuessNumberGame()
        {
            MagicNumber = new Random().Next(1, 10);

            Start();
        }

        public int MagicNumber { get; private set; }
        public bool IsCounting { get; private set; }

        /// <summary>
        /// Guess 'MagicNumber' before 'countDownNumber' hits zero.
        /// </summary>
        public void Start()
        {
            var playingGame = true;

            Task timer = GameTimer(10);

            PrintMessage("Guess a number from 1 to 10");
            while (playingGame)
            {
                var input = Console.ReadLine();

                if (timer.IsCompleted)
                {
                    PrintMessage("Time over. You failed.");
                    playingGame = false;
                }
                else
                {
                    if (int.TryParse(input, out int inputAsInt))
                    {
                        if (inputAsInt == MagicNumber)
                        {
                            IsCounting = false;
                            PrintMessage("Congrats. Correct number.");

                            playingGame = false;
                        }
                        else
                        {
                            PrintMessage("Wrong guess, try again");
                        }
                    }
                    else
                    {
                        PrintMessage("Invalid Input.");
                    }
                }
            }

            timer.Wait();
        }

        /// <summary>
        /// Start timer. OBS timer stops if IsCounting is set to false;
        /// </summary>
        /// <param name="numberOfSeconds">Count down to zero from number of seconds</param>
        /// <returns></returns>
        public async Task GameTimer(int numberOfSeconds)
        {
            IsCounting = true;
            for (int i = numberOfSeconds; i > 0; i--)
            {
                if (!IsCounting) break;

                countDownNumber = i;

                PrintMessage();

                await Task.Delay(1000);
            }
            if (countDownNumber == 0) PrintMessage("Time over.");
            IsCounting = false;
        }

        /// <summary>
        /// Clears console and prints label. Suffixes timeleft, if 'IsCounting' is true
        /// </summary>
        void PrintMessage()
        {
            Console.Clear();
            if (IsCounting)
            {
                Console.WriteLine("{0} - Timeleft: {1}", label, countDownNumber);
            }
            else
            {
                Console.WriteLine(label);
            }
        }

        /// <summary>
        /// Clears console and prints message. Suffixes timeleft, if 'IsCounting' is true
        /// </summary>
        /// <param name="message">Sets field 'label' and prints message.</param>
        void PrintMessage(string message)
        {
            Console.Clear();
            label = message;
            if (IsCounting)
            {
                Console.WriteLine("{0} - Timeleft: {1}", label, countDownNumber);
            }
            else
            {
                Console.WriteLine(label);
            }
        }
    }
}
