using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrickController : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.transform.tag == "Ball")
        {
            FindObjectOfType<GameManager>().IncreaseScore();
            Destroy(gameObject);
        }
    }
}
