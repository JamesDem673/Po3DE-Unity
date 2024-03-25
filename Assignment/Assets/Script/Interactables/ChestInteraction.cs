using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.UIElements;
using static UnityEngine.Tilemaps.Tilemap;

public class ChestInteraction : MonoBehaviour
{
    public Animator chestAnimator;
    bool closed;
    bool locked;

    public void Start()
    {
        //Gets animator for object and sets default variable state
        closed = true;
        locked = true;
    }
    public void Interact()
    {
        //Starts relevant opening/closing animation
        if (closed && !locked)
        {
            chestAnimator.ResetTrigger("Close");
            chestAnimator.SetTrigger("Open");
            transform.Rotate(-120, 0, 0, Space.Self);
            closed = false;
        }
        else if (!closed)
        {
            chestAnimator.ResetTrigger("Open");
            chestAnimator.SetTrigger("Close");
            transform.Rotate(120, 0, 0, Space.Self);
            closed = true;
        }
    }

    public void UnlockChest()
    {
        locked = false;
    }
}
