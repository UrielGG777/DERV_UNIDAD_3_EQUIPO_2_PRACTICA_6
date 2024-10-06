using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P3_MovimientoEnemigo : MonoBehaviour
{

    Transform ubi_personaje;
    P2_CalcularDistancia auxCompontenteDistance;

    private void Awake()
    {
        ubi_personaje = GameObject.Find("Jugador").GetComponent<Transform>();
    }

    void Start()
    {
        auxCompontenteDistance = GetComponent<P2_CalcularDistancia>();
    }

    // Update is called once per frame
    void Update()
    {
        float distacialAlEnemigo = auxCompontenteDistance.getDistance();
        if (distacialAlEnemigo < 17.5f)
        {
            float velocidad = 4.0f * Time.deltaTime;
            transform.position =
                Vector3.MoveTowards(transform.position, ubi_personaje.position, velocidad);
        }
    }
}
