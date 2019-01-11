using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    public float speed;
    public int PlayerNumber;
    private string HorizontalAxisNumber;
    private string VerticalAxisNumber;
    public bool canMove;
    // public float rotationSpeed; // Esta variável não é necessária se fizeres a rotação instantânea, sem suavização

    void Start()
    {

        // The axes names are based on player number.
        HorizontalAxisNumber = "Horizontal" + PlayerNumber;
        VerticalAxisNumber = "Vertical" + PlayerNumber;
        canMove = true;

    }

    // Update is called once per frame
    void LateUpdate()
    {
        if (canMove)
        { 
        Vector3 displacement = new Vector3(Input.GetAxis(HorizontalAxisNumber), 0f, Input.GetAxis(VerticalAxisNumber)) * speed * Time.deltaTime; // No meu computador isto não funciona, acho que é por causa do rato 3D. Mas devia funcionar. Se não funcionar, tens que encontrar outra forma de ler o gamepad semk ser o Input.GetAxis. Nesse caso, comenta esta linha e desbloqueia o bloco de código a seguir (mas este bloco só está a funcionar com as teclas de cursor)
        /*
        float horizontal = (Input.GetKey(KeyCode.RightArrow) ? 1 : 0) + (Input.GetKey(KeyCode.LeftArrow) ? -1 : 0);
        float vertical = (Input.GetKey(KeyCode.UpArrow) ? 1 : 0) + (Input.GetKey(KeyCode.DownArrow) ? -1 : 0);

        Vector3 displacement = new Vector3(horizontal, 0f, vertical) * speed * Time.deltaTime;
        */
        
        
        //Debug.Log(speed);
        if (displacement.magnitude != 0)
            {
            //transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(displacement), Time.deltaTime * rotationSpeed);
            // Se não quiseres a suavização da rotação, comenta a linha anterior e descomenta a próxima. Também podes apagar a linha "public float RotationSpeed" se quiseres a rotação instantânea
            transform.rotation = Quaternion.LookRotation(displacement);

            transform.Translate(transform.forward * displacement.magnitude, Space.World);
            }

        }
    }
}