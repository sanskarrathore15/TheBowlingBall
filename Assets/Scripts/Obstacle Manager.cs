using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleManager : MonoBehaviour
{
    [SerializeField] float speed =10f ;
  

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.left*Time.deltaTime*speed);
    }
}
