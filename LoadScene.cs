using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{

    [SerializeField] int tiempoDeEspera = 3;
    int escenaActual;
    
    void Start()
    {
        escenaActual = SceneManager.GetActiveScene().buildIndex;
        if(escenaActual == 0)
        {
            StartCoroutine(TiempoEspera());
        }

    }

    IEnumerator TiempoEspera()
    {
        yield return new WaitForSeconds(tiempoDeEspera);
        AbreEscena();
    }

    public void AbreEscena()
    {
        SceneManager.LoadScene(escenaActual + 1);
    }

}
