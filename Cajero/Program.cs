
string? readResult;
string userInput = "";

int[] currentMoney = { 1, 5, 10, 20, 50 };
int[] currentDividedMoney = new int[currentMoney.Length];

Console.WriteLine($"Enter the amount that you need: ");

readResult = Console.ReadLine();
if (readResult != null)
{
    userInput = readResult;
}

int number = int.Parse(userInput);

getMoney(number);


void getMoney(int number)
{
    for (int i = currentMoney.Length - 1; i < 1; i--)
    {
        int j = i - 1;
        if (number / currentMoney[i] != 0)
        {
            if (number % currentMoney[i] == 0)
            {
                currentDividedMoney[i] = number / currentMoney[i];
                for (int k = i - 1; k == 0; k--)
                {
                    currentDividedMoney[k] = 0;

                }
            }
            else
            {
                currentDividedMoney[j] = (number % currentMoney[i]) / currentMoney[j];
                j--;
            }

        }
        else
        {
            currentDividedMoney[i] = 0;
        }

    }

    for (int i = 0; i < currentDividedMoney.Length; i++)
    {
        Console.WriteLine(currentDividedMoney[i]);
    }
}