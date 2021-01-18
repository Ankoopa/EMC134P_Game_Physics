using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhysicsEngine : MonoBehaviour
{
    public Vector3 velVector; //avg vel for this FixedUpdate()
    public Vector3 netForceVector;
    public List<Vector3> forceVectorList = new List<Vector3>();

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void FixedUpdate() 
    {
        transform.position += velVector * Time.deltaTime;
    }
}
