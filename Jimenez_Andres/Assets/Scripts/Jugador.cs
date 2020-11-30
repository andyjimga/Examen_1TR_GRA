using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jugador : MonoBehaviour
{
    public float Vel = 1f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MoverJugador();
    }

    void MoverJugador()
    {
        float PosX = transform.position.x;
        float PosZ = transform.position.z;
        
        float desplX = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * Time.deltaTime * Vel * desplX);
        float desplZ = Input.GetAxis("Vertical"); //no entiendo porque al poner vertical si que funciona y al poner horizontal no, porque no sube la bola, pero weno, yo sigo
        transform.Translate(Vector3.forward * Time.deltaTime * Vel * desplZ);



    }
}
