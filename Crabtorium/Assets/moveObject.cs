using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveObject : MonoBehaviour
{

    public GameObject go;

    public BoxCollider bc;

    public Transform t;
    // Start is called before the first frame update
    void Start()
    {
        bc = GetComponent<BoxCollider>();
    }

    // Update is called once per frame

    public void OnTriggerEnter(Collider other)
    {
        go.transform.position = t.position;
        Destroy(this.gameObject);
    }
}
