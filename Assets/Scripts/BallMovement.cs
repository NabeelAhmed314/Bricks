using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    public float speed = 5f;
    public float randomNumber;
    public Transform player;
    
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Timer(2f));
    }

    void BallTrash()
    {
        randomNumber = Random.Range(0, 2);
        if (randomNumber > 1)
        {
            GetComponent<Rigidbody2D>().AddForce(new Vector2(10, 50));
        }
        else
        {
            GetComponent<Rigidbody2D>().AddForce(new Vector2(-10, 50));
        }
    }

    private void Reset()
    {
        StopCoroutine("Timer");
        GetComponent<Rigidbody2D>().velocity = new Vector2(0f, 0f);
        transform.position = new Vector2(0f, -3.6f);
        player.position = new Vector2(0f,-4f);
        StartCoroutine(Timer(0.5f));
    }

    IEnumerator Timer(float time)
    {
        yield return new WaitForSeconds(time);
        BallTrash();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("obstacles"))
        {
            GameSetup.obs -= 1;
            Destroy(collision.gameObject);
        }
    }
}
