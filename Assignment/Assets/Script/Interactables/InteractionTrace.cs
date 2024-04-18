using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class InteractionTrace : MonoBehaviour
{
    public float interactionDistance = 5f;
    public GameObject background;
    public TMP_Text itemDisplay;

    void Update()
    {
        //creates Raycast to check where player is looking
        RaycastHit hit;

        //checks if raycast hits an object
        if (Physics.Raycast(transform.position, transform.forward, out hit, interactionDistance))
        {
            if (hit.collider.gameObject.layer == 7)
            {
                //shows UI and sets text variable to object casted
                background.SetActive(true);
                itemDisplay.gameObject.SetActive(true);
                itemDisplay.text = hit.collider.transform.name;
            }
        }
        else
        {
            //hides UI and clears text variable if no object is casted
            background.SetActive(false);
            itemDisplay.gameObject.SetActive(false);
            itemDisplay.text = "Nothing";
        }
    }
}
