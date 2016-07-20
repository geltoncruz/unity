using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	public float speed;
	private Rigidbody2D rb2d;

	// Use this for initialization
	void Start () {

		rb2d = GetComponent<Rigidbody2D> ();

	}
	// Chamado em intevalos fixos.
	//Uso: Atualização física
	void FixedUpdate(){
		float vHorizontal = Input.GetAxis("Horizontal");
		float vVertical = Input.GetAxis ("Vertical");

		Vector2 movement = new Vector2 (vHorizontal, vVertical);
		rb2d.AddForce (movement * speed);

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	//chamado ao fim das atualizações fisicas
	//USo: Atualizao fisica
	void LateUpdate(){

	}
}
