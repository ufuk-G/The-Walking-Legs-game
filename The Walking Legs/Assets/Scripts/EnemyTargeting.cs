using System.Collections;
using System.Collections.Generic;
using UnityEngine.Audio;
using UnityEngine;


public class EnemyTargeting : MonoBehaviour
{
    private Animator EnemeyAnim;
    private Transform Target;
    public int score;
    public float deleteTime = 0f;
    public float Speed;
    public ParticleSystem bloodParticle;

    private void Start()
    {
        EnemeyAnim = GetComponent<Animator>();
        Target = FindObjectOfType<PlayerControl>().transform;
    }
    private void FixedUpdate()
    {
        FollowPlayer();
    }
    private void FollowPlayer()
    {
        EnemeyAnim.SetBool("isMoving", true);
        EnemeyAnim.SetFloat("Horizontal", (Target.position.x - transform.position.x));
        EnemeyAnim.SetFloat("Vertical", (Target.position.y - transform.position.y));
        transform.position = Vector3.MoveTowards(transform.position, Target.transform.position, Speed * Time.deltaTime);

    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Arrow"))
        {
            ScoreScript.scoreValue += score;
            Destroy(gameObject, deleteTime);
            Instantiate(bloodParticle, new Vector2(transform.position.x, transform.position.y - 0.8f),
            Quaternion.identity);
            
        }

        if (collision.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject, deleteTime);
            Instantiate(bloodParticle, new Vector2(transform.position.x, transform.position.y - 0.8f),
            Quaternion.identity);

        }
    }
}
