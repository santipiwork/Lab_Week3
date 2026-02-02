using UnityEngine;

public class BookstoreCalc : MonoBehaviour
{
    // explains in the inspector what is below it
    [Header("TASK #2: SOME BOOKSTORE PROBLEMS")]
    
    // they are the values that you can edit in the inspector
    public float coverPrice = 0;

    public int copies = 1;

    public float sellingPrice = 0;

    void Start()
    {
        // makes sure that the values make sense so that it can run the code
        if (coverPrice < 0 || copies < 1 || sellingPrice < 0)
        {
            Debug.Log("Invalid input values!");
            return;
        }
        // calls the function
        CalculateCostAndProfit(coverPrice, copies, sellingPrice);
    }

    //the function that calculates wholesale cost and profit
    void CalculateCostAndProfit(float price, int numCopies, float sellPrice)
    {
        // 40% discount
        float discountPrice = price * 0.6f;
        // calculates the cost of the shipping
        float shipping = 3f + 0.75f * (numCopies - 1);

        float totalCost = discountPrice * numCopies + shipping;
        float totalRevenue = sellPrice * numCopies;
        float profit = totalRevenue - totalCost;

        // prints the values into the console
        Debug.Log($"Book cover price: ${price}");
        Debug.Log($"Copies purchased: {numCopies}");
        Debug.Log($"Wholesale cost: ${totalCost:F2}");
        Debug.Log($"Selling revenue: ${totalRevenue:F2}");
        Debug.Log($"Profit (before operational costs): ${profit:F2}");
    }
}