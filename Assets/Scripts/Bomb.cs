using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb : MonoBehaviour
{   
    public float fieldofImpact;
    public float force;

    public LayerMask LayerToHit;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
 
      void Update()
    {

        Invoke(nameof(explode), 10f);
    }
    void explode()
    {
       Collider2D[] objects =  Physics2D.OverlapCircleAll(transform.position, fieldofImpact, LayerToHit);

       foreach(Collider2D obj in objects)
       {
        Vector2 direction = obj.transform.position - transform.position;

        obj.GetComponent<Rigidbody2D>().AddForce(direction * force);
       }
    }

    void OnDrawGizmosSelected() 
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, fieldofImpact);
        
    }
}
