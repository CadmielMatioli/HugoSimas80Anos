using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartGame : MonoBehaviour {

	
	void Start(){


	}
	public void Iniciar () {
		Debug.Log ("Iniciou");
		Application.LoadLevel("Jogo");
		}
	public void Exit(){
		Debug.Log ("Saiu");
		Application.Quit ();
	}

}
