using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitInteraction : MonoBehaviour
{
    [Header("Fruit States")]
    public GameObject WholeFruit;
    public GameObject BittenFruit;

    // Swaps active fruits
    public void BiteFruit()
    {
        BittenFruit.SetActive(true);
        WholeFruit.SetActive(false);
    }
}
