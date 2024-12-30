using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject spawnpoint;
    Rigidbody2D rigid;
    public float speed;
    public float jump;
    private void Awake()
    {
        rigid = GetComponent<Rigidbody2D>();

       
    }

    private void Start()
    {
        transform.position = spawnpoint.transform.position;
    }

    private void OnBecameInvisible()
    {
        if (spawnpoint != null)
        {
            transform.position = spawnpoint.transform.position;
        }
    }
    
    private void FixedUpdate()
    {
        float pos_x = Input.GetAxisRaw("Horizontal");
        transform.position += new Vector3(pos_x, 0, 0).normalized * speed * Time.deltaTime;
      
    }


   private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("End_Point"))
        {
            GameManager.Instance.Clear();
        }
        if (collision.gameObject.CompareTag("Ground"))
        {
            rigid.velocity = new Vector2(0, jump);
        }
    }
}
