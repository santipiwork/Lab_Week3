using UnityEngine;

public class DollarBillCalc : MonoBehaviour
{
    // explains in the inspector what is below it
    [Header("TASK #1: SOME DOLLAR BILLS PROBLEMS")]
    // the value that you can alter in inspector
    public int amount = 0;

    void Start()
    {
        //checks if the value in the inspector is less than 0 and returns a message in the console if it is
        if (amount < 0)
        {
            Debug.Log("Amount cannot be negative!");
            return;
        }
        // calls the function using the amount from the inspector
        CalculateBills(amount);
    }

    // function that checks the number placed in inspector and uses mod to go down the line until it is fully divided into bills
    void CalculateBills(int total)
    {
        int remaining = total;

        int hundreds = remaining / 100;
        remaining %= 100;

        int fifties = remaining / 50;
        remaining %= 50;

        int twenties = remaining / 20;
        remaining %= 20;

        int tens = remaining / 10;
        remaining %= 10;

        int fives = remaining / 5;
        remaining %= 5;

        int ones = remaining;

        // print the results into the console to check if it works
        Debug.Log($"Amount: ${total}");
        Debug.Log($"Hundreds: {hundreds}");
        Debug.Log($"Fifties: {fifties}");
        Debug.Log($"Twenties: {twenties}");
        Debug.Log($"Tens: {tens}");
        Debug.Log($"Fives: {fives}");
        Debug.Log($"Ones: {ones}");
    }
}