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
    public GameObject SakeCups;
    public GameObject SakeBottle;


    private void Update()
    {
        //checks for input from player and what object is being looked it, and activates function for interaction
        if (Input.GetKeyDown(KeyCode.E))
        {
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
                        break;
                    }
                case ("Sake Cup"):
                    {
                        //Function to check if cup is filled and remove drink level if full
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