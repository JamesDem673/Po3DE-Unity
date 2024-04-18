using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SignTrigger : MonoBehaviour
{
    bool can_read;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (can_read)
            
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Hi");
        can_read = true;
    }
}
