using System.Collections;
using System.Collections.Generic;
using UnityEngine.Audio;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public float playerspeed = 1f;
    public float ArrowSpeed = 4f;
    private float LastFire;
    public float FireDelay;
    public Animator TopAnimator;
    public Animator BottomAnimator;
    public Rigidbody2D CharacterRb;
    public GameObject ArrowPrefab;
    public AudioSource FireSound;
    Vector2 MoveDir;
    Vector2 ShotDir;


    void Update()
    {
        Animator();            
    }
    void FixedUpdate()
    {
        Movement();
        Shooting();
    }

    void Movement()
    {
        ShotDir.x = Input.GetAxis("ShootHorizontal");
        ShotDir.y = Input.GetAxis("ShootVertical");

        MoveDir.x = Input.GetAxis("Horizontal");
        MoveDir.y = Input.GetAxis("Vertical");

        CharacterRb.MovePosition(CharacterRb.position + MoveDir * playerspeed * Time.fixedDeltaTime);
        
    }

    void Animator()
    {
       BottomAnimator.SetFloat("Vertical", MoveDir.y);
       BottomAnimator.SetFloat("Horizontal", MoveDir.x);
       BottomAnimator.SetFloat("Magnitude", MoveDir.sqrMagnitude);

       TopAnimator.SetFloat("Vertical", ShotDir.y);
       TopAnimator.SetFloat("Horizontal", ShotDir.x);
       TopAnimator.SetFloat("Magnitude", ShotDir.sqrMagnitude);
    }

    void Shooting()
    {

        float ShootH = Input.GetAxis("ShootHorizontal");
        float ShootV = Input.GetAxis("ShootVertical");

        if ((ShootH != 0 || ShootV != 0) && Time.time > LastFire + FireDelay)
        {
            FireSound.Play();
            Shoot(ShootH, ShootV);
            LastFire = Time.time;
        }
    }

    void Shoot(float x, float y)
    {
     GameObject arrow = Instantiate(ArrowPrefab,transform.position, Quaternion.identity);
        Vector2 arrowRotation = new Vector2(Input.GetAxis("ShootHorizontal"), Input.GetAxis("ShootVertical"));
        arrow.transform.Rotate(0.0f, 0.0f, Mathf.Atan2(arrowRotation.y, arrowRotation.x) * Mathf.Rad2Deg -90f);

     arrow.AddComponent<Rigidbody2D>().gravityScale = 0;
        arrow.GetComponent<Rigidbody2D>().velocity = new Vector3(
          (x < 0) ? Mathf.Floor(x) * ArrowSpeed : Mathf.Ceil(x) * ArrowSpeed,
          (y < 0) ? Mathf.Floor(y) * ArrowSpeed : Mathf.Ceil(y) * ArrowSpeed,
          0
          );
    }
    
}
