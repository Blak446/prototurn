using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour {

    public int vHorizontal = 5;
    public int vVertical = 5;
	private Rigidbody2D rb;
  

	void Start ()
    {
		rb = GetComponent<Rigidbody2D> ();
	}
	
	 
	void Update ()
    {
		if (Input.GetKeyDown (KeyCode.Q)) 
		{
			GirarEsquerda ();
			Debug.Log ("ola");
		}
		if (Input.GetKeyDown (KeyCode.E)) 
		{
			GirarDireita ();
		}


	}

    private void FixedUpdate()
    {
        Mover();
    }

    void Mover()
    {
        // setar velocidades
        float velHorizontal = vHorizontal * Time.deltaTime;
        float velVertical = vVertical * Time.deltaTime;

        // aplicar transformações em DA
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(-velHorizontal, 0, 0);
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(velHorizontal, 0, 0);
        }

        // PULO
        if (Input.GetKeyDown(KeyCode.W))
        {
			rb.velocity += velVertical * Vector2.up;
        }

    }

	void GirarEsquerda ()
	{
		transform.Rotate (Vector3.back * -45);
	}
	void GirarDireita ()
	{
		transform.Rotate (Vector3.back * 45);
	}


 
}
