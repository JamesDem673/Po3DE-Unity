using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class KeySpawn : MonoBehaviour
{
    GameObject[] KeySpawns;
    public GameObject key;
    public GameObject test;

    public GameObject arrow;
    void Start()
    {
        int randomNum = Random.Range(0, transform.childCount - 1);
        Quaternion keyRot = new Quaternion(45, 45, 45, 45);
        key.transform.SetPositionAndRotation(transform.GetChild(randomNum).transform.position, keyRot);
        key.transform.SetParent(transform.GetChild(randomNum));

        Vector3 newPos = new Vector3 (key.transform.position.x, 70, key.transform.position.z);
        arrow.transform.SetPositionAndRotation(newPos, Quaternion.identity);
        arrow.transform.SetParent(transform.GetChild(randomNum));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
