using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{

    [SerializeField] GameObject appleProjectile, gun;

    public void fireAnApple()
    {
        Instantiate(appleProjectile, gun.transform.position, gun.transform.rotation);    
    }
}
