// Some Dollar Bills Problems

using JetBrains.Annotations;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Task1 : MonoBehaviour
{
    public int paidDollars = 126;
    private int[] billValue = { 100, 50, 20, 10, 5, 1 };
    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        billAmount(paidDollars);
        // paid ? dollars
        // how many bills of 100.50.20.10.5,1 will you get
        // input a value, no decimals allowed
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // get the amount of bills
    private void billAmount(int paidDollars)
    {
        foreach (int billValue in billValue) 
        {
            Debug.Log("$"+ billValue + "'s : " + paidDollars / billValue);
            paidDollars = (paidDollars % billValue);
        }


    }



}
