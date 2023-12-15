using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnNewRoom : MonoBehaviour
{
    public GameObject r;

    public void spawnRoom()
    {
        Instantiate(r, this.transform.position, Quaternion.identity);    
    }
}
