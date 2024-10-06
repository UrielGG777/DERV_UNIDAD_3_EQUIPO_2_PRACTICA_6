using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P1_LookAt : MonoBehaviour
{

    Transform ubi_obj_a_mirar;
    P2_CalcularDistancia auxCompontenteDistance;

    //los gameobject se inicializan en awake
    private void Awake()
    {
      ubi_obj_a_mirar = GameObject.Find("Jugador").GetComponent<Transform>();  
    }

    // Start is called before the first frame update
    //Componentes se inicializan en start
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
            float valY = ubi_obj_a_mirar.position.y;

            if (valY > 6.5f)
            {
                transform.LookAt(new Vector3(
                    ubi_obj_a_mirar.position.x,
                    3.5f,
                    ubi_obj_a_mirar.position.z));
            }
            else
            {
                transform.LookAt(ubi_obj_a_mirar.position);
            }
        }
    }
}
