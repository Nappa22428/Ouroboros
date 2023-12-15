using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class randomStats : MonoBehaviour
{

    Rigidbody2D rb;

    public Transform f;

    public float s = 50f;

    public TextMeshPro t;

    // Start is called before the first frame update
    public void Awake()
    {
        s = Random.Range(20f, 75f);
        rb = GetComponent<Rigidbody2D>();
        this.transform.Rotate(0,0,Random.Range(1,361));
        t.color = new Color(Random.Range(-1f, 256f)/255f, Random.Range(-1f, 256f) / 255f, Random.Range(-1f, 256f) / 255f, 255);
    }

    

    // Update is called once per frame
    void Update()
    {
        Vector2 fDirection = f.position - transform.position;

        rb.velocity = (fDirection * s * Time.fixedDeltaTime);
    }

    void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
