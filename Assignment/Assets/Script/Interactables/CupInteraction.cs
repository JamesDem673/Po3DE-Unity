using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CupInteraction : MonoBehaviour
{
    public void drinkSake()
    {
        if(transform.GetChild(0).gameObject.activeSelf)
        {
            transform.GetChild(0).gameObject.SetActive(false);
        }
    }
}
