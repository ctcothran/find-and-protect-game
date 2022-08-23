using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Rigidbody2D rb;
    public float knockBackSpeed = 8f;
    public Transform center;

    private Vector2 dir;

    // Start is called before the first frame update
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {

    }


    // Increase the 'Linear Drag' in the rb to get object to slow down after being knocked back
    public void KnockBack(Transform t)
    {
        
        Debug.Log("Knocked enemy back");
        dir = center.position - t.position;  // position you are at and position to move away from
        rb.AddForce(dir.normalized * knockBackSpeed);

    }
}
