using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowHitDedection : MonoBehaviour
{
    public float arrowDeleteTime = 0.3f;
    public void OnCollisionEnter2D(Collision2D collision)
    {
        GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);

        Destroy(gameObject, arrowDeleteTime);
    }

}
