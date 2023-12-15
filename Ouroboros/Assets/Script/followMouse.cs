using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followMouse : MonoBehaviour
{
    public static bool magic = false;

    Rigidbody2D rb;
    public Transform magicBall;
    public Transform gunEnd;
    public Transform shootEnd;

    Vector2 mBallPos;


    // Update is called once per frame
    void Update()
    {
        fMouse();
    }

    void fMouse()
    {
        Vector3 mP = Input.mousePosition;
        mP = Camera.main.ScreenToWorldPoint(mP);

        Vector3 direction = new Vector3(mP.x - transform.position.x, mP.y - transform.position.y, 0);

        transform.up = direction;

        if (Input.GetButtonDown("Fire1"))
        {
            Vector3 shootDir = (shootEnd.position - gunEnd.position).normalized;
            fire(shootDir);
        }
    }

    void fire(Vector3 sdir)
    {

        Transform mBallT = Instantiate(magicBall, new Vector3(gunEnd.position.x, gunEnd.position.y, 0), Quaternion.identity);

        mBallT.GetComponent<BulletScript>().Setup(sdir);

    }
}
