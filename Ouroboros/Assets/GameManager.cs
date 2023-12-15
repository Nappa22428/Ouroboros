using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public bool NextRoom;
    public int EnemiesLeft = 0;
    // Start is called before the first frame update
    void Start()
    {
        NextRoom = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        if(EnemiesLeft <= 0)
        {
            NextRoom = true;
        }
        else
        {
            NextRoom = false;
        }
    }
}
