using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallFollow : MonoBehaviour
{
 public float speed;
 
     void Update()
     {
         transform.Translate(Vector3.forward * Time.deltaTime * speed);

         RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, 1/*, layerMask*/))
        {
             transform.Rotate(1, 90, 1);
        }
     }
}
