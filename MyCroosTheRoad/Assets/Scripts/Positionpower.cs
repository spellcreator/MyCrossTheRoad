using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Positionpower : MonoBehaviour
{
    public List<Road> roads = new List<Road>();

    void Start()
    {
        int i = 0;
        foreach (var road in roads)
        {
            road.transform.position = new Vector3(i, road.transform.position.y, road.transform.position.z);
            i++;
        }
    }
}
