
namespace ManuelHartmann.Week03
{
    public class TicTacTo
    {
        static int counter = 1;     // Zahler, um zwischen den Spielern zu switchen.
        static char currentPlayer = 'X'; // Default Signatur fuer Spieler 1.

        // 2D Array, Matrix (Erstellte ein zweidimensionales 'char Array' -> Aufbau 3x3.
        static char[,] board = new char[3, 3]
        {
                {' ', ' ', ' '},
                {' ', ' ', ' '},
                {' ', ' ', ' '}
        };
        static void Start(string[] args)
        {
            BuildMenu();
        }

        public static void BuildMenu()
        {
            string player = ""; // Player 1 'X' oder Player 2 'O'.

            do
            {
                // Wechselt nach jeder Runde den Spieler. (gerade oder ungerade Zahl)
                if (counter % 2 == 0)
                {
                    // Wenn es sich um eine gerade Zahl handelt, ist 'Spieler 1' an der Reihe.
                    currentPlayer = 'X';
                    player = "Player 1 'X'";

                }
                else
                {
                    // Wenn es sich um eine ungerade Zahl handelt, ist 'Spieler 2' an der Reihe.
                    currentPlayer = 'O';
                    player = "Player 2 'O'";
                }
                counter++;  // Zaehler +1, dass maximal nur 9 Runden gespielt werden koennen.
                // Moeglichkeiten fuer Anwender.
                Console.WriteLine("Please tell me the field where you would like to place your marker.\n");
                Console.WriteLine("0. Top left,    1. Top middle,    2. Top right.");
                Console.WriteLine("3. Middle left, 4. Middle,        5. Middle right.");
                Console.WriteLine("6. Bottom left, 7. Bottom middle, 8. Bottom right.\n");
                PrintBoard();   // Gibt immer das derzeitige TicTacTo-Feld aus.
                string userInput = Console.ReadLine();
                if (int.TryParse(userInput, out int value) && (value >= 0 && value < 9))
                {
                    int[] tmp = CalcCorts(value);   // 'value' wird der Methode 'CalcCorts' uebergeben und ueberpruft,
                                                    // um welches Feld es sich handelt. -> Ergebnis wird in eine 'tmp' geschrieben.
                    TicTacToBuilder(tmp);           // Ergebnis wird nun an 'TicTacToBuilder uebergeben.
                }
                else
                {
                    Console.WriteLine("Please enter a valid number!");
                }
                // Ueberpruft, ob ein Spieler das Spiel gewonnen hat.
                if (CheckWin() == true)
                {
                    Console.WriteLine(new string('-', 30));
                    Console.WriteLine(player + " -> won the game!");
                    Console.WriteLine(new string('-', 30));
                    break;
                }
            } while (counter <= 9); // Beendet das Spiel nach maximal 9 Runden.
            PrintBoard();
        }
        public static void TicTacToBuilder(int[] result)
        {
            if (board[result[0], result[1]] == ' ') // Ueberpruft, ob das Feld leer ist.
            {
                board[result[0], result[1]] = currentPlayer;  // Befuellt das jeweilige Kastchen mit 'X' oder 'O'.
            }
            else
            {
                Console.WriteLine("This field is already writen!");
                counter--;  // Feld nicht leer -> User bekommt Moeglichkeit das Symbol wo anders zu setzten.
            }
        }
        // Ueberpruft in welcher Zeile & Spalte ein Symbol gesetzt werden muss.
        public static int[] CalcCorts(int value)
        {
            int[] result = new int[2];
            // Obere Zeile
            if ((int)value / 3 == 0)    // (int) -> Komma wird weg geschnitten. Wenn Ergebnis '0' -> Dymension '0'.
            {
                result[0] = 0;
                result[1] = value % 3;  // Gibt immer den Rest an!!! Also 0%3=0, 1%3=1, 2%3=2.
            }
            // Mittlere Zeile
            else if ((int)value / 3 == 1)
            {
                result[0] = 1;
                result[1] = value % 3;
            }
            // Untere Zeile
            else if ((int)value / 3 == 2)
            {
                result[0] = 2;
                result[1] = value % 3;
            }
            return result;
        }
        // Stellt das TicTacTo Board dar.
        static void PrintBoard()
        {
            // Console.Clear();
            Console.WriteLine(" Tic-Tac-Toe Board ");
            Console.WriteLine($"   {board[0, 0]} | {board[0, 1]} | {board[0, 2]} ");
            Console.WriteLine("  ---+---+---");
            Console.WriteLine($"   {board[1, 0]} | {board[1, 1]} | {board[1, 2]} ");
            Console.WriteLine("  ---+---+---");
            Console.WriteLine($"   {board[2, 0]} | {board[2, 1]} | {board[2, 2]} ");
        }
        // Bedingungen, ob ein Spieler gewonnen hat.
        public static bool CheckWin()
        {
            // Rows
            for (int i = 0; i < 3; i++)
            {
                if (board[i, 0] == currentPlayer && board[i, 1] == currentPlayer && board[i, 2] == currentPlayer || 
                    board[0, i] == currentPlayer && board[1, i] == currentPlayer && board[2, i] == currentPlayer ||
                    board[0, 0] == currentPlayer && board[1, 1] == currentPlayer && board[2, 2] == currentPlayer ||
                    board[2, 0] == currentPlayer && board[1, 1] == currentPlayer && board[0, 2] == currentPlayer)
                {
                    return true;
                }
            }
            return false;
        }
    }
}

