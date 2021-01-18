using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhysicsEngine : MonoBehaviour
{
    public Vector3 velVector; //avg vel for this FixedUpdate()
    public Vector3 netForceVector;
    public List<Vector3> forceVectorList = new List<Vector3>();
    public TextStatusScript textStatus;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void FixedUpdate() 
    {
        AddForces();
        if(netForceVector == Vector3.zero){
            textStatus.isBalanced = true;
            transform.position += velVector * Time.deltaTime;
        }
        else{
            textStatus.isBalanced = false;
            Debug.LogError("Unbalanced force detected.");
        }
    }

    void AddForces(){
        netForceVector = Vector3.zero;

        foreach (Vector3 forceVector in forceVectorList){
            netForceVector += forceVector;
        }
    }
}
