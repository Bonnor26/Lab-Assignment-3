using UnityEngine;

public class BookstoreCalculator : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public float coverPrice; //x
    public int copiesSold; //y 
    void Start()
    {
        // validate inputs
        if (coverPrice <= 0 || copiesSold < 0)
        {
            Debug.LogError("Invalid input values.");
            return;
        }

        // Step 1: discounted wholesale price
        float wholesalePrice = coverPrice * 0.6f;

        // Step 2: cost of books
        float bookCost = wholesalePrice * copiesSold;

        // Step 3: shipping cost
        float shippingCost = 0f;
        if (copiesSold > 0)
        {
            shippingCost = 3.0f + (copiesSold - 1) * 0.75f;
        }

        // Step 4: total wholesale cost
        float totalCost = bookCost + shippingCost;

        // Step 5: revenue 
        float revenue = coverPrice * copiesSold;

        // Step 6: profit
        float profit = revenue - totalCost;

        // Output
        Debug.Log($"Total wholesale cost: ${totalCost:F2}"); 
        Debug.Log($"Profit: ${profit:F2}");
    }
}
