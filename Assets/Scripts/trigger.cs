using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trigger : MonoBehaviour
{
    [SerializeField] GameObject spawnpoint;
    [SerializeField] GameObject floor;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("obstacle"))
        {

        }
    }
}
