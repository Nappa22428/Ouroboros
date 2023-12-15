using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnLetter : MonoBehaviour
{

    public BoxCollider2D bc;

    Vector2 cubeSize;
    Vector2 cubeCenter;

    public GameObject[] keyboard;
    // Start is called before the first frame update
    public void Awake()
    {
        Transform cubeTrans = bc.GetComponent<Transform>();
        cubeSize.x = cubeTrans.localScale.x * bc.size.x;
        cubeSize.y = cubeTrans.localScale.y * bc.size.y;
    }

    // Update is called once per frame
    void Update()
    {
        spawner();
    }

    public void spawner()
    {
        if (Input.anyKeyDown) 
        {
            string i = Input.inputString;
            switch (i)
            {
                case "\b":
                    Instantiate(keyboard[0], GetRandomPosition(), Quaternion.identity);
                    break;
                case "a":
                    Instantiate(keyboard[1], GetRandomPosition(), Quaternion.identity);
                    break;
                case "b":
                    Instantiate(keyboard[2], GetRandomPosition(), Quaternion.identity);
                    break;
                case "c":
                    Instantiate(keyboard[3], GetRandomPosition(), Quaternion.identity);
                    break;
                case "d":
                    Instantiate(keyboard[4], GetRandomPosition(), Quaternion.identity);
                    break;
                case "e":
                    Instantiate(keyboard[5], GetRandomPosition(), Quaternion.identity);
                    break;
                case "f":
                    Instantiate(keyboard[6], GetRandomPosition(), Quaternion.identity);
                    break;
                case "g":
                    Instantiate(keyboard[7], GetRandomPosition(), Quaternion.identity);
                    break;
                case "h":
                    Instantiate(keyboard[8], GetRandomPosition(), Quaternion.identity);
                    break;
                case "i":
                    Instantiate(keyboard[9], GetRandomPosition(), Quaternion.identity);
                    break;
                case "j":
                    Instantiate(keyboard[10], GetRandomPosition(), Quaternion.identity);
                    break;
                case "k":
                    Instantiate(keyboard[11], GetRandomPosition(), Quaternion.identity);
                    break;
                case "l":
                    Instantiate(keyboard[12], GetRandomPosition(), Quaternion.identity);
                    break;
                case "m":
                    Instantiate(keyboard[13], GetRandomPosition(), Quaternion.identity);
                    break;
                case "n":
                    Instantiate(keyboard[14], GetRandomPosition(), Quaternion.identity);
                    break;
                case "o":
                    Instantiate(keyboard[15], GetRandomPosition(), Quaternion.identity);
                    break;
                case "p":
                    Instantiate(keyboard[16], GetRandomPosition(), Quaternion.identity);
                    break;
                case "q":
                    Instantiate(keyboard[17], GetRandomPosition(), Quaternion.identity);
                    break;
                case "r":
                    Instantiate(keyboard[18], GetRandomPosition(), Quaternion.identity);
                    break;
                case "s":
                    Instantiate(keyboard[19], GetRandomPosition(), Quaternion.identity);
                    break;
                case "t":
                    Instantiate(keyboard[20], GetRandomPosition(), Quaternion.identity);
                    break;
                case "u":
                    Instantiate(keyboard[21], GetRandomPosition(), Quaternion.identity);
                    break;
                case "v":
                    Instantiate(keyboard[22], GetRandomPosition(), Quaternion.identity);
                    break;
                case "w":
                    Instantiate(keyboard[23], GetRandomPosition(), Quaternion.identity);
                    break;
                case "x":
                    Instantiate(keyboard[24], GetRandomPosition(), Quaternion.identity);
                    break;
                case "y":
                    Instantiate(keyboard[25], GetRandomPosition(), Quaternion.identity);
                    break;
                case "z":
                    Instantiate(keyboard[26], GetRandomPosition(), Quaternion.identity);
                    break;
                case "1":
                    Instantiate(keyboard[27], GetRandomPosition(), Quaternion.identity);
                    break;
                case "2":
                    Instantiate(keyboard[28], GetRandomPosition(), Quaternion.identity);
                    break;
                case "3":
                    Instantiate(keyboard[29], GetRandomPosition(), Quaternion.identity);
                    break;
                case "4":
                    Instantiate(keyboard[30], GetRandomPosition(), Quaternion.identity);
                    break;
                case "5":
                    Instantiate(keyboard[31], GetRandomPosition(), Quaternion.identity);
                    break;
                case "6":
                    Instantiate(keyboard[32], GetRandomPosition(), Quaternion.identity);
                    break;
                case "7":
                    Instantiate(keyboard[33], GetRandomPosition(), Quaternion.identity);
                    break;
                case "8":
                    Instantiate(keyboard[34], GetRandomPosition(), Quaternion.identity);
                    break;
                case "9":
                    Instantiate(keyboard[35], GetRandomPosition(), Quaternion.identity);
                    break;
                case "0":
                    Instantiate(keyboard[36], GetRandomPosition(), Quaternion.identity);
                    break;
                case "!":
                    Instantiate(keyboard[37], GetRandomPosition(), Quaternion.identity);
                    break;
                case "@":
                    Instantiate(keyboard[38], GetRandomPosition(), Quaternion.identity);
                    break;
                case "#":
                    Instantiate(keyboard[39], GetRandomPosition(), Quaternion.identity);
                    break;
                case "$":
                    Instantiate(keyboard[40], GetRandomPosition(), Quaternion.identity);
                    break;
                case "%":
                    Instantiate(keyboard[41], GetRandomPosition(), Quaternion.identity);
                    break;
                case "^":
                    Instantiate(keyboard[42], GetRandomPosition(), Quaternion.identity);
                    break;
                case "&":
                    Instantiate(keyboard[43], GetRandomPosition(), Quaternion.identity);
                    break;
                case "*":
                    Instantiate(keyboard[44], GetRandomPosition(), Quaternion.identity);
                    break;
                case "(":
                    Instantiate(keyboard[45], GetRandomPosition(), Quaternion.identity);
                    break;
                case ")":
                    Instantiate(keyboard[46], GetRandomPosition(), Quaternion.identity);
                    break;
                case "-":
                    Instantiate(keyboard[47], GetRandomPosition(), Quaternion.identity);
                    break;
                case "_":
                    Instantiate(keyboard[48], GetRandomPosition(), Quaternion.identity);
                    break;
                case "=":
                    Instantiate(keyboard[49], GetRandomPosition(), Quaternion.identity);
                    break;
                case "+":
                    Instantiate(keyboard[50], GetRandomPosition(), Quaternion.identity);
                    break;
                case "[":
                    Instantiate(keyboard[51], GetRandomPosition(), Quaternion.identity);
                    break;
                case "{":
                    Instantiate(keyboard[52], GetRandomPosition(), Quaternion.identity);
                    break;
                case "]":
                    Instantiate(keyboard[53], GetRandomPosition(), Quaternion.identity);
                    break;
                case "}":
                    Instantiate(keyboard[54], GetRandomPosition(), Quaternion.identity);
                    break;
                case "\\":
                    Instantiate(keyboard[55], GetRandomPosition(), Quaternion.identity);
                    break;
                case "|":
                    Instantiate(keyboard[56], GetRandomPosition(), Quaternion.identity);
                    break;
                case ";":
                    Instantiate(keyboard[57], GetRandomPosition(), Quaternion.identity);
                    break;
                case ":":
                    Instantiate(keyboard[58], GetRandomPosition(), Quaternion.identity);
                    break;
                case "'":
                    Instantiate(keyboard[59], GetRandomPosition(), Quaternion.identity);
                    break;
                case "\"":
                    Instantiate(keyboard[60], GetRandomPosition(), Quaternion.identity);
                    break;
                case ",":
                    Instantiate(keyboard[61], GetRandomPosition(), Quaternion.identity);
                    break;
                case "<":
                    Instantiate(keyboard[62], GetRandomPosition(), Quaternion.identity);
                    break;
                case ".":
                    Instantiate(keyboard[63], GetRandomPosition(), Quaternion.identity);
                    break;
                case ">":
                    Instantiate(keyboard[64], GetRandomPosition(), Quaternion.identity);
                    break;
                case "/":
                    Instantiate(keyboard[65], GetRandomPosition(), Quaternion.identity);
                    break;
                case "?":
                    Instantiate(keyboard[66], GetRandomPosition(), Quaternion.identity);
                    break;
                case "\n":
                    Instantiate(keyboard[67], GetRandomPosition(), Quaternion.identity);
                    break;
                default:
                    Debug.Log(i);
                    break;

            }
        }
    }

    private Vector2 GetRandomPosition()
    {
        // You can also take off half the bounds of the thing you want in the box, so it doesn't extend outside.
        // Right now, the center of the prefab could be right on the extents of the box
        Vector2 randomPosition = new Vector2(Random.Range(-cubeSize.x / 2, cubeSize.x / 2), Random.Range(-cubeSize.y / 2, cubeSize.y / 2));

        return cubeCenter + randomPosition;
    }
}
