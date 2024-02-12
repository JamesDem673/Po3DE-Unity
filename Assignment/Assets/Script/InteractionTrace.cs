using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class InteractionTrace : MonoBehaviour
{
    public float interactionDistance = 3f;
    public GameObject background;
    public TMP_Text itemDisplay;

    void Update()
    {
        //creates Raycast to check where player is looking
        RaycastHit hit;

        //checks if raycast hits an object and displays item name to screen
        if (Physics.Raycast(transform.position, transform.forward, out hit, interactionDistance))
        {
            if (hit.collider.gameObject.layer == 7)
            {
                background.SetActive(true);
                itemDisplay.gameObject.SetActive(true);

                itemDisplay.text = hit.collider.transform.name;
            }
        }
        else
        {
            background.SetActive(false);
            itemDisplay.gameObject.SetActive(false);
        }
    }
}
