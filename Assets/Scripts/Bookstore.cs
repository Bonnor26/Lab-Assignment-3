using UnityEngine;

public class BookstoreCalculator : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public float coverPrice; //x
    public int copiesSold; //y 

    void Start()
    {
        // validate inputs
        if (!IsInputValid())
            return;

        //Run functions
        float totalCost = CalculateTotalWholesaleCost();
        float profit = CalculateProfit(totalCost);

        //Show results
        PrintResults(totalCost, profit);

    }

    bool IsInputValid()
    {
        if (coverPrice <= 0 || copiesSold < 0)
        {
            Debug.LogError("Invalid input values.");
            return false;
        }
        return true;
    }

    // Price the bookstore paid per book
    float CalculateWholesalePrice()
    {
        return coverPrice * 0.6f;
    }

    // Price bookstore paid for all books
    float CalculateBookCost()
    {
        return CalculateWholesalePrice() * copiesSold;
    }

    // Shipping price for all books
    float CalculateShippingCost()
    {
        if (copiesSold <= 0)
            return 0f;

        return 3.0f + (copiesSold - 1) * 0.75f;
    }

    // Total cost for bookstore
    float CalculateTotalWholesaleCost()
    {
        return CalculateBookCost() + CalculateShippingCost();
    }

    // Total amount made through sales ( not total profit )
    float CalculateRevenue()
    {
        return coverPrice * copiesSold;
    }

    // Total profit
    float CalculateProfit(float totalCost)
    {
        return CalculateRevenue() - totalCost;
    }


    // Print to consol 
    void PrintResults(float totalCost, float profit)
    {
        Debug.Log($"Total wholesale cost: ${totalCost:F2}");
        Debug.Log($"Profit: ${profit:F2}");
    }
}
