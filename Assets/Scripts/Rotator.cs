using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    Vector3 spin = new Vector3(15, 30, 45);
    
    // Update is called once per frame
    void Update()
    {
        // Rotates the game object that this script is attached to by 15 in the X axis,
        // 30 in the Y axis and 45 in the Z axis, multiplied by deltaTime in order to make it per second
        // rather than per frame
        transform.Rotate( spin * Time.deltaTime);        
    }
}
