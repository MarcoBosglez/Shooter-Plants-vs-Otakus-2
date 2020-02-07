using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] float resistence = 50f;
    [SerializeField] GameObject explosion;

    public void HitEnemy(float hit)
    {
        resistence -= hit;
        if (resistence <= 0)
        {
            Explota();
            Destroy(gameObject);
        }
    }
    private void Explota ()
    {
        if (!explosion) return;
        GameObject explosionObjeto =
            Instantiate(explosion, transform.position, transform.rotation);
        Destroy(explosionObjeto, 1f);
    }
}
