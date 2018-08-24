using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerContorl : MonoBehaviour
{
    public float multiplyer = 1;
    public float speed = 2f;

	void FixedUpdate ()
    {
        //gameObject.transform.Translate(transform.forward * multiplyer * speed);

        if (Input.GetKeyDown(KeyCode.RightArrow))
            gameObject.transform.Translate(-transform.forward * multiplyer);
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
            gameObject.transform.Translate(transform.forward * multiplyer);
        else if (Input.GetKeyDown(KeyCode.UpArrow))
            gameObject.transform.Translate(transform.right * multiplyer);
        else if (Input.GetKeyDown(KeyCode.DownArrow))
            gameObject.transform.Translate(-transform.right * multiplyer);
    }
}
