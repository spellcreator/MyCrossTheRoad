using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    public float speed;
     

    void Update ()
    {
        Vector3 pos = transform.position;

        pos.x += speed * Time.deltaTime;
        transform.position = pos;
    }
}
