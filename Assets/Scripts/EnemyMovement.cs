using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    private Vector3 dir;
    public float speed = 10;
    public float minX, maxX, minZ, maxZ;
    public bool isX, isZ;
    void Start(){
        if(isX)
            dir=Vector3.left;
        if(isZ)
            dir=Vector3.back;
    }
    void Update()
    {
        if (isX){
            
            if (transform.position.x <= minX)
                dir=Vector3.right;
            if (transform.position.x >= maxX)
                dir=Vector3.left;
            
            transform.Translate(dir*speed*Time.deltaTime);
        }
            if (isZ){ 

            if (transform.position.z <= minZ)
                dir=Vector3.forward;
            if (transform.position.z >= maxZ)
                dir=Vector3.back;
                
            transform.Translate(dir*speed*Time.deltaTime);
        }
        
        
    }
}
