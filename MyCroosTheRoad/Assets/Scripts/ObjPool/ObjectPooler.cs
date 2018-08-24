using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPooler : MonoBehaviour
{
    public Road pooledObject;

    public int poolledamn;

    public List<Road> pooledObjects;
    
    void Start()
    {
        pooledObjects = new List<Road>();
        for (int i = 0; i < poolledamn;i++)
        {
            Road road = Instantiate(pooledObject);
            road.gameObject.SetActive(false);
            pooledObjects.Add(road); 
        }
        
    }

    public Road Pull()
    {
        for (int i = 0; i < pooledObjects.Count;i++)
        {
            if (!pooledObjects[i].gameObject.activeInHierarchy)
            {
                return pooledObjects[i]; 
            }
        }
        return null;
        //Road road = Instantiate(pooledObject);
        //road.gameObject.SetActive(false);
        //pooledObjects.Add(road);
        //return road;
    }

    public void Push(Road road)
    {
        if (road.gameObject.activeInHierarchy)
        {
            try
            {
                pooledObjects.Find(x => x == road).gameObject.SetActive(false);
            }
            catch(Exception ex)
            {
                Debug.LogError(ex, this);
            }
        }
    }
}
