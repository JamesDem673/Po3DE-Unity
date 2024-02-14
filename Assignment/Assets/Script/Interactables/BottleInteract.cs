using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEditorInternal;
using UnityEngine;


public class BottleInteract : MonoBehaviour
{
    [Header("GameObject Imports")]
    public GameObject sakeLiquid;
    public GameObject sakeCupLiquid1;
    public GameObject sakeCupLiquid2;
    public GameObject sakeCupLiquid3;

    List<GameObject> sakes = new List<GameObject>();
    int randomVal;

    public void Start()
    {
        sakes.Add(sakeCupLiquid1);
        sakes.Add(sakeCupLiquid2); 
        sakes.Add(sakeCupLiquid3);    
    }

    public void PourBottle()
    {
        if (sakes[0].activeInHierarchy && sakes[1].activeInHierarchy && sakes[2].activeInHierarchy) 
        {
            return;
        }

        randomVal = Random.Range(0, sakes.Count);

        if (!sakes[randomVal].activeInHierarchy)
        {
            sakes[randomVal].SetActive(true);
        }
        else
        {
            PourBottle();
        }
    }      
}
