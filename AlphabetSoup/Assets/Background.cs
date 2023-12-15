using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour
{
    SpriteRenderer sr;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void Awake()
    {
        sr = GetComponent<SpriteRenderer>();
        sr.color = new Color(Random.Range(-1f, 256f) / 255f, Random.Range(-1f, 256f) / 255f, Random.Range(-1f, 256f) / 255f, 255);
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.localScale += new Vector3(0.01f, 0.01f,0);
    }
}
