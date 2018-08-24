using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadGenerator : MonoBehaviour
{
    public Road roadPrefab;
    public Transform generationPoints;
    public Camera cam;

    public List<Road> roads = new List<Road>();
    public int currentAnchorPosition = 0;
   

    public ObjectPooler ObjPool;

    void Update()
    {
        DisableNoneVisibleRoads();
        SetEnavleInvisibleRoad();
        if(roads.Count > ObjPool.poolledamn)
            roads.RemoveAt(0);
    }

    void SetEnavleInvisibleRoad()
    {
        Road newPlatform = ObjPool.Pull();

        if (newPlatform != null)
        {
            roads.Add(newPlatform);
            newPlatform.transform.position = transform.position;
            newPlatform.transform.rotation = transform.rotation;
            SetNewRoadPos(newPlatform);
            newPlatform.gameObject.SetActive(true);
        }
    }

    void SetNewRoadPos(Road road)
    {
        road.transform.position = new Vector3(currentAnchorPosition, road.transform.position.y, road.transform.position.z);
        currentAnchorPosition++;
    }

    void DisableNoneVisibleRoads()
    {
        foreach(var road in roads)
        {
            if(road.transform.position.x + 5 < cam.transform.position.x)
            {
                ObjPool.Push(road);
            }
        }
    }
}
