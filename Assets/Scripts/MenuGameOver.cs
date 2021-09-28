using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuGameOver : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	public void Voltar () {
		Debug.Log ("Voltou");
		Application.LoadLevel ("Menu");
	}
	public void Replay(){
		Debug.Log ("Reiniciou");
		Application.LoadLevel ("Jogo");
	}
}
