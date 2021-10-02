using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	public Animator 	Anime;
	public Rigidbody2D 	playerRigidbody;
	public int 			foceJump;

	public bool 		slide;

	//verifica o chao
	public Transform 	GroundCheck;
	public bool 		grounded;
	public LayerMask 	WhatIsGround;

	//slide
	public float slideTemp;
	private float timeTemp;

	//colisor
	public Transform colisor;

	//Audio
	public AudioSource audio;
	public AudioClip soundJump;
	public AudioClip soundSlide;

	//Pontuacao
	public UnityEngine.UI.Text txtPontos;
	public static int pontuacao;



	// Use this for initialization
	void Start () {
		pontuacao = 0;
			PlayerPrefs.SetInt("pontuacao", pontuacao);
	}
	
	// Update is called once per frame
	 void Update () {
		txtPontos.text = pontuacao.ToString ();

		if(Input.GetButtonDown ("Jump") && grounded == true){
			playerRigidbody.AddForce(new Vector2 (0, foceJump));

			//Audio do pulo
			audio.PlayOneShot (soundJump);
			audio.volume = 0.15f;

			if (slide == true) {
				colisor.position = new Vector3 (colisor.position.x, colisor.position.y + 0.87f, colisor.position.z);	
				slide = false;	
			}
		}
		
		if(Input.GetButtonDown("Slide") && grounded == true && slide == false){

			//Audio do slide 
			audio.PlayOneShot (soundSlide);
			audio.volume = 0.15f;

			//colisor
			colisor.position = new Vector3 (colisor.position.x, colisor.position.y - 0.87f, colisor.position.z);
			slide = true;
			timeTemp = 0;
	}
		grounded = Physics2D.OverlapCircle (GroundCheck.position, 0.2f, WhatIsGround);
		if (slide == true) {
			timeTemp += Time.deltaTime;
			if (timeTemp >= slideTemp) {
				colisor.position = new Vector3 (colisor.position.x, colisor.position.y + 0.87f, colisor.position.z);
				slide = false;
			}
		}
		Anime.SetBool ("jump", !grounded);
		Anime.SetBool ("slide", slide);

	}

	void OnTriggerEnter2D(){
		PlayerPrefs.SetInt ("pontuacao", pontuacao);
		if (pontuacao > PlayerPrefs.GetInt ("recorde")) {
			PlayerPrefs.SetInt ("recorde", pontuacao);
		}
		Application.LoadLevel("GameOver");
		Debug.Log ("bateu");
	}
}
