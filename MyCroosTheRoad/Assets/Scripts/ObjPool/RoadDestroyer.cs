using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadDestroyer : MonoBehaviour
{
    public GameObject DestPoint;
    public float range;

    private void Start()
    {
        DestPoint = GameObject.Find("DestructionPoints");
        DestPoint.transform.position = new Vector3(range, DestPoint.transform.position.y, DestPoint.transform.position.z);
    }

    private void Update()
    {
        if(transform.position.x > DestPoint.transform.position.x)
        {
            gameObject.SetActive(false);
        }
    }
}	
