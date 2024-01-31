using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour
{
   public Rigidbody rb;
   public GameObject explosion;
   public LayerMask whatIsPlayer;

   [Range(0f,1f)]
   public float bounciness;
   public bool useGravity;

   public int EnemyDamage;
   public float explosionRange;
   public int maxCollisions;
   public float maxLifetime;
   public bool explodeOnTouch = true;

   int collisions;
   PhysicMaterial physics_mat;

   private void Start()
   {
     Setup();
   }

   private void Update()
   {
        if (collisions > maxCollisions) Explode();

        maxLifetime -= Time.deltaTime;
        if (maxLifetime <= 0) Explode();
   }

   private void Explode()
   {
        if(explosion != null) Instantiate(explosion, transform.position, Quaternion.identity);

        Collider[] player = Physics.OverlapSphere(transform.position, explosionRange, whatIsPlayer);
        
        foreach(Collider Player in player)
        {
               Player.GetComponent<Healthmanager>().TakeDamage2(EnemyDamage);
               Destroy(gameObject);
        }

     Invoke("Delay", 0.05f);
   }

   private void Delay()
   {
    Destroy(gameObject);
   }

   private void OnCollisionEnter(Collision collision)
   {
        if(collision.collider.CompareTag("Bullet"))return;

        collisions++;

        if(collision.collider.CompareTag("Player") && explodeOnTouch) Explode();

        Debug.Log(collision);

        


   }

   private void Setup()
   {
        physics_mat = new PhysicMaterial();
        physics_mat.bounciness = bounciness;
        physics_mat.frictionCombine = PhysicMaterialCombine.Minimum;
        physics_mat.bounceCombine = PhysicMaterialCombine.Maximum;

        GetComponent<SphereCollider>().material = physics_mat;

        rb.useGravity = useGravity;
   }

   private void OnDrawGizmosSelected()
   {
       Gizmos.color = Color.red;
       Gizmos.DrawWireSphere(transform.position, explosionRange);
   }
}


