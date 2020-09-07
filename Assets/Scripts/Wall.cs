﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.name == "Ball")
        {
            Debug.Log("Bottom Wall");
            collision.gameObject.SendMessage("Reset");
        }
    }

}
