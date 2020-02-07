using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtaqueHuachi : MonoBehaviour
{

    [SerializeField] float minimoTEnemigos = 1f;
    [SerializeField] float maximoTEnemigos = 5f;
    [SerializeField] Attack enemigoPrefab;
    bool creaEnemigos = true;
    // Start is called before the first frame update



    IEnumerator Start()
    {
        while (creaEnemigos)
        {
            yield return new WaitForSeconds(Random.Range(minimoTEnemigos, maximoTEnemigos));
           instanciaEnemigo();
        }
    }


    private void instanciaEnemigo()
    {
        Instantiate(enemigoPrefab, transform.position, transform.rotation);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}

