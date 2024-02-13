using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.UIElements;
using static UnityEngine.Tilemaps.Tilemap;

public class ChestInteraction : MonoBehaviour
{
    [Header("Rotation States")]
    bool closed;

    public void Start()
    {
        //Gets animator for object and sets default variable state
        closed = true;
    }
    public void Interact()
    {
        //Starts relevant opening/closing animation
        if (closed)
        {
            transform.Rotate(-140, 0, 0, Space.Self);
            closed = false;
        }
        else if (!closed)
        {
            transform.Rotate(140, 0, 0, Space.Self);
            closed = true;
        }
    }
}
