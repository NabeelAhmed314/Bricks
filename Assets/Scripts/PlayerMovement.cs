using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public KeyCode moveleft, moveright;
    public float speed = 5;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(moveleft))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(-speed,0f);
        }
        else if (Input.GetKey(moveright))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(speed, 0f);

        }
        else
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(0f, 0f);
        }
    }
}
