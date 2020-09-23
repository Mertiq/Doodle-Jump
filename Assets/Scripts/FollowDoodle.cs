using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowDoodle : MonoBehaviour
{
    [SerializeField] GameObject doodle;
   

    
    void Update()
    {
        if(doodle.transform.position.y >= transform.position.y)
        {
            transform.position = new Vector3(transform.position.x, doodle.transform.position.y, transform.position.z);
        }
    }
}
