using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    [SerializeField] private Rigidbody rb;
   
    [SerializeField] private GameObject lane1Cube;
    [SerializeField] private GameObject lane2Cube;
    [SerializeField] private GameObject lane3Cube;
    private Vector3[] lanePos;
        int currentLaneIndex=1;
    int targetIndex;

    // Start is called before the first frame update
    void Start()
    {
        lanePos = new Vector3[3]; //why?
        lanePos[0] = lane1Cube.transform.position; //taking the 
        lanePos[1] = lane2Cube.transform.position;
        lanePos[2] = lane3Cube.transform.position;
        Debug.Log(currentLaneIndex);
    }

    // Update is called once per frame
    void Update()
    {
      /*  if (Input.GetKey(KeyCode.W))
        {
            rb.AddForce(Vector3.forward*3f);
        }
        if (Input.GetKey(KeyCode.Space))
        {
            rb.AddForce(Vector3.up * 3f);
        }
        if (Input.GetKey(KeyCode.S))
        {
            rb.AddForce(Vector3.back * 3f);
        }*/
        if (Input.GetKeyDown(KeyCode.A))
        {
            if (currentLaneIndex != 0)
                 targetIndex = currentLaneIndex-1;
            currentLaneIndex = targetIndex;
            Debug.Log(lanePos[currentLaneIndex]);
            //rb.AddForce(Vector3.left *3f);
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            if (currentLaneIndex != 2)
                targetIndex = currentLaneIndex + 1;
            currentLaneIndex = targetIndex;
            Debug.Log(lanePos[currentLaneIndex]);
            //rb.AddForce(Vector3.right * 3f);
        }

        var step = 10f * Time.deltaTime; 
        transform.position = Vector3.MoveTowards(transform.position, lanePos[targetIndex],step);
       
    }
    private void OnTriggerEnter(Collider other)
    {
        
        if (other.gameObject.CompareTag("coin"))
        {
            if (currentLaneIndex == 0)
            {

            Destroy(lane1Cube);
            }
            if (currentLaneIndex == 1)
            {

                Destroy(lane2Cube);
            }
            if (currentLaneIndex == 2)
            {

                Destroy(lane3Cube);
            }
        }
    }

}



