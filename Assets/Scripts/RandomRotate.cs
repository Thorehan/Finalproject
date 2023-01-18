using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomRotate : MonoBehaviour
{
    private float randX, randY, randZ;
    void Start(){
        randX = Random.Range(15f, 35f);
        randY = Random.Range(15f, 35f);
        randZ = Random.Range(15f, 35f);
    }
    void Update()
    {
        transform.Rotate(randX* Time.deltaTime, 
                            randY* Time.deltaTime, 
                                randZ* Time.deltaTime);
        
    }
}
