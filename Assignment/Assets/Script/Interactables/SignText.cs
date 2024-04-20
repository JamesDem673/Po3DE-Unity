using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SignText : MonoBehaviour
{
    int Textline = 0;
    bool hasKey = false;

    public GameObject background;
    public TMP_Text signDisplay;
    public GameObject arrow;
    public GameObject key;

    void Start()
    {
        background.SetActive(false);
        arrow.SetActive(false);

        for (int i = 0; i < background.transform.childCount; i++) 
        {
            background.transform.GetChild(i).gameObject.SetActive(false);
        }
    }

    private void Update()
    {
        //checks for input from player and what object is being looked it, and activates function for interaction
        if (Input.GetKeyDown(KeyCode.E) && background.activeSelf == true)
        {
            StopReadingSign();
        }

        if (key.activeSelf == false) 
        {
            hasKey = true;
        }
    }

    public void ReadSign()
    {
        background.SetActive(true);
        background.transform.GetChild(Textline).gameObject.SetActive(true);

        if (Textline == 20)
        {
            arrow.SetActive(true);
        }
    }
    
    public void StopReadingSign()
    {
        background.transform.GetChild(Textline).gameObject.SetActive(false);
        background.SetActive(false);

        if (hasKey || Textline <= 20)
        {
            if (Textline + 1 <= background.transform.childCount)
            {
                Textline += 1;
            }
        }
    }
}
