using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrownBird : Bird
{
    [SerializeField]
    //public float _explosionForce = 100;
    public bool _hasExplosion = false;

    public GameObject _explosion;

    public void Explode(GameObject explosion)
    {
        if (State == BirdState.HitSomething && !_hasExplosion)
        {
            var clone = Instantiate(explosion, transform.position, Quaternion.identity);
            _hasExplosion = true;
            
            string tag = explosion.tag;
            if (tag == "Explosion")
            {
                Destroy(clone, 0.1f);
                Destroy(gameObject);
            }
        }
    }

    public override void OnTap()
    {
        Explode(_explosion);
    }
}

