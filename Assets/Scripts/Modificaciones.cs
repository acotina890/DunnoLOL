using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Modificaciones : MonoBehaviour
{
    public int monedas, vida;
    public float velocidad;
    public Vector3 direccion;

    // Start is called before the first frame update
    void Start()
    {
        vida = 150;

        velocidad = 0.92f;

        direccion = new Vector3(0, 0, 1);

        monedas = 0;

        Curacion();
        DañoObtenido();
    }

    // Update is called once per frame
    void Update()
    {
        MovObjeto();
        recoleccionMonedas();
    }

    void MovObjeto()
    {
        transform.Translate(direccion * velocidad * Time.deltaTime);
    }

    void Curacion()
    {
        vida += 50;
    }

    void DañoObtenido()
    {
        vida -= 40;
    }

    void recoleccionMonedas()
    {
        monedas++;
        Debug.Log("Recolecté "+monedas+" monedas");
    }


}
