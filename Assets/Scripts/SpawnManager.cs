using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] GameObject spawnpoint;
    [SerializeField] List<GameObject> prefabsToSpawn;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "obstacle")
        {
            Destroy(other.gameObject);

        }
        Debug.Log(prefabsToSpawn.Count);
        int index = Random.Range(0 , prefabsToSpawn.Count); //randomly list se pick karke spawn karna
        GameObject spawn = prefabsToSpawn[index];
        Instantiate(spawn, spawnpoint.transform.position, Quaternion.identity); //rotation 0
    }
}