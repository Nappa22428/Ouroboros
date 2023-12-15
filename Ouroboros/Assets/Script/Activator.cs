using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Activator : MonoBehaviour
{

    SpawnNewRoom snr;
    public string compass;
    GameManager gm;
    // Start is called before the first frame update
    public bool random;
    void Start()
    {
        snr = this.GetComponentInChildren<SpawnNewRoom>();
        gm = FindObjectOfType<GameManager>();
        door();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void door()
    {
        if (random)
        {
            int r = Random.Range(1, 100);
            
            if (r % 2 == 0)
            {
                this.gameObject.SetActive(true);
            }
            else
            {
                this.gameObject.SetActive(false);
            }
        }
    }
    public void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player" && gm.NextRoom == true)
        {
            gm.NextRoom = false;
            snr.spawnRoom();
            switch (compass)
            {
                case "N":
                    other.transform.position = new Vector2(other.transform.position.x, other.transform.position.y + 2);
                    break;
                case "S":
                    other.transform.position = new Vector2(other.transform.position.x, other.transform.position.y - 2);
                    break;
                case "E":
                    other.transform.position = new Vector2(other.transform.position.x + 2, other.transform.position.y);
                    break;
                case "W":
                    other.transform.position = new Vector2(other.transform.position.x - 2, other.transform.position.y);
                    break;
            }
            Destroy(this.transform.parent.gameObject);
        }
        
    }
}
