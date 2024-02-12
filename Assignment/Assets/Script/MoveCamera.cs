using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour
{
    public Transform cameraPosition;

    private void Update()
    {
        //Moves camera position to the player's position
        transform.position = cameraPosition.position;
    }
}
