using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeySpawn : MonoBehaviour
{
    GameObject[] KeySpawns;
    public GameObject key;
    public GameObject test;

    void Start()
    {
        int randomNum = Random.Range(0, transform.childCount);
        // key.transform.SetPositionAndRotation(transform.GetChild(randomNum).transform.position, Quaternion.identity(186.242, 55.176, 92.528);
        Quaternion keyRot = new Quaternion(45, 45, 45, 45);
        key.transform.SetPositionAndRotation(transform.GetChild(randomNum).transform.position, keyRot);
        key.transform.SetParent(transform.GetChild(randomNum));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
