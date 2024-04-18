using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SignBoundaryControl : MonoBehaviour
{

    private void OnTriggerExit(Collider other)
    {
        transform.GetComponentInParent<SignText>().StopReadingSign();
    }
}
