using UnityEngine;
using System.Collections;
using UnityEngine.UI;
//using UnityEngine.SceneManagement;



public class Player : MonoBehaviour {

	private int total = 4;
	public Text countText;
	private int counter;

	public GameObject MenuLevel;

	public float speed;
	private Rigidbody2D rb2d;

	// Use this for initialization
	void Start () {

		rb2d = GetComponent<Rigidbody2D> ();
		counter = 0;
		UpdatePickup ();
		MenuLevel.gameObject.SetActive(false);
	}

	// Chamado em intevalos fixos.
	//Uso: Atualização física
	void FixedUpdate(){
		float vHorizontal = Input.GetAxis("Horizontal");
		float vVertical = Input.GetAxis ("Vertical");

		Vector2 movement = new Vector2 (vHorizontal, vVertical);
		rb2d.AddForce (movement * speed);

	}

	void OnTriggerEnter2D(Collider2D other){
		if(other.gameObject.CompareTag("Pickup"))
		{
			other.gameObject.SetActive(false);
			counter++;
			UpdatePickup ();
		}
	}

	void UpdatePickup(){
		if (counter < 3) {
			countText.text = "Score " + counter;
		} else {
			countText.text = "ZEREI!";
			MenuLevel.gameObject.SetActive(true);
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	//chamado ao fim das atualizações fisicas
	//USo: Atualizao fisica
	void LateUpdate(){

	}

	public void reloadGame(){
		Application.LoadLevel ("level01");
	}

	public void nextGame(){
		Application.LoadLevel ("level02");
	}



}
