using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SignText : MonoBehaviour
{
    List<string> TextLines = new List<string>();
    int Textline = 0;

    public GameObject background;
    public TMP_Text signDisplay;

    void Start()
    {
        background.SetActive(false);

        TextLines.Add("In order to get open the chest, you must first find the key");
        TextLines.Add("The key was hidden on one of the islands surrounding you, but sadly I don't know which one");
    }

    public void ReadSign()
    {
        background.SetActive(true);

        signDisplay.SetText(TextLines[Textline]);
    }
    
    public void StopReadingSign()
    {
        background.SetActive(false);

        if (Textline + 1 <= TextLines.Count)
        {
            Textline += 1;
        }
    }
}
