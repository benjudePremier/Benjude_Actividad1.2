using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    // Ejecuta al inicio , al momento de dar play.
    // Declaraciones de variables
    private float horizontal;
    private float velocidad;
    void Start()
    {
        
    }

    // Se ejecuta  que vamos jugar frame x frame.
    void Update()
    {
        //Obtiene cirtas letras del teclado
        if (Input.GetKey("a"))
        {
            this.transform.position = new Vector2(-3, 2); // la posiscion del objeto en su vector corresponde.

        }
        if (Input.GetKey("s"))
        {
            this.transform.position = new Vector2(-4, 2);

        }
        if (Input.GetKey("d"))
        {
            this.transform.position = new Vector2(-5, 3);

        }
        if (Input.GetKey("w"))
        {
            this.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 100));
            //Obtengo el Rigidbody del objeto y añade fuerzas(x,y)


        }
        horizontal = Input.GetAxis("Horizontal") * velocidad;  // hacia al horizontal.
        transform.Translate(horizontal * Time.deltaTime, 0, 0); // para desplacar el objeto.


    }
}
