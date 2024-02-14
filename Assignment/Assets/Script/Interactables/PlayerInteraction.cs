using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerInteraction : MonoBehaviour
{
    public TMP_Text itemLookedAt;

    [Header("Items")]
    public GameObject fruit;
    public GameObject chest;
    public GameObject SakeCup1;
    public GameObject SakeCup2;
    public GameObject SakeCup3;    
    public GameObject SakeBottle;


    private void Update()
    {
        //checks for input from player and what object is being looked it, and activates function for interaction
        if (Input.GetKeyDown(KeyCode.E))
        {
            Debug.Log(itemLookedAt.text);

            switch (itemLookedAt.text)
            {
                case ("Gomu Gomu No Mi"):
                    {
                        //Function to swap active fruits
                        fruit.GetComponent<FruitInteraction>().BiteFruit();
                        break;
                    }
                case ("Sake Bottle"):
                    {
                        //Fuction to reduce drink level and fill random cup
                        SakeBottle.GetComponent<BottleInteract>().PourBottle();
                        break;
                    }
                case ("Luffy's Sake Cup"):
                    {
                        //Function to check if cup is filled and remove drink level if full
                        SakeCup1.GetComponent<CupInteraction>().drinkSake();
                        break;
                    }
                case ("Sabo's Sake Cup"):
                    {
                        //Function to check if cup is filled and remove drink level if full
                        SakeCup2.GetComponent<CupInteraction>().drinkSake();
                        break;
                    }
                case ("Ace's Sake Cup"):
                    {
                        //Function to check if cup is filled and remove drink level if full
                        SakeCup3.GetComponent<CupInteraction>().drinkSake();
                        break;
                    }
                case ("Chest"):
                    {
                        //function to open/close chest
                        chest.GetComponent<ChestInteraction>().Interact();
                        break;
                    }
            }
        }
    }
}