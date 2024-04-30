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
    public GameObject Sign;
    public GameObject Boat;

    bool inBoat = false;

    private void Update()
    {
        //checks for input from player and what object is being looked it, and activates function for interaction
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (inBoat)
            {
                Boat.transform.parent = null;
                inBoat = false;
                GetComponent<PlayerMovement>().SetInBoat(false);
                transform.position += new Vector3(0, 2, 0);
            }

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
                case ("Key"):
                    {
                        //Unlocks Chest
                        chest.GetComponent<ChestInteraction>().UnlockChest();
                        GameObject key = GameObject.FindWithTag("Key");
                        key.SetActive(false);
                        break;
                    }
                case ("Sign"):
                    {
                        //sets UI active for the sign
                        Sign.GetComponent<SignText>().ReadSign();
                        break;   
                    }
                case ("Boat"):
                    {
                        if (!inBoat)
                        {
                            //sets player to be in boat
                            transform.position = Boat.transform.position += new Vector3(0, 2, 0);
                            Boat.transform.SetParent(transform, true);
                            GetComponent<PlayerMovement>().SetInBoat(true);

                            Boat.SetActive(true);
                            inBoat = true;                          
                        }
                        break;
                    }
            }
        }
    }
}