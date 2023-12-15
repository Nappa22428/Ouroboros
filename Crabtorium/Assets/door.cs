using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class door : MonoBehaviour
{
    public GameObject go;

    public bool doorState;

    public float up, down, timeToReachTarget;

    public float t;

    public AudioSource ass;
    // Start is called before the first frame update
    void Start()
    {
        doorState = false;
        ass = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        t += Time.deltaTime / timeToReachTarget;
        doorUpAndDown();
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
        {
            
            if (Input.GetMouseButtonDown(0))
            {
                ass.Play();
                t = 0;
                doorState = !doorState;
            }
        }
    }


    public void doorUpAndDown()
    {
        if (doorState && go.transform.localPosition.y <= up)
        {
            MoveTowards(down, up);
        }
        else if (!doorState && go.transform.localPosition.y >= down)
        {
            MoveTowards(up, down);
        }
    }


    private void MoveTowards(float targetPosition, float oppositeThreshold)
    {
        Vector3 target = new Vector3(go.transform.localPosition.x, targetPosition, go.transform.localPosition.z);
        go.transform.localPosition = Vector3.Lerp(go.transform.localPosition, target, t);
        if (Mathf.Approximately(go.transform.localPosition.y, oppositeThreshold))
        {
            t = 0;
        }
    }
}
