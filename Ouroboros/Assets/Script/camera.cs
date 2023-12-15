using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{
    public GameObject cameraMan;

    // Start is called before the first frame update
    void Start()
    {
        cameraMan = GameObject.Find("Main Camera");
        cameraMan.transform.position = new Vector3(this.transform.position.x, this.transform.position.y, -10);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
