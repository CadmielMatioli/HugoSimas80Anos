using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnController : MonoBehaviour {

	//Objeto Spawnado
	public GameObject barreiraPrefab; 
	//Intervalo de Spawn
	public float rateSpawn;
	//tempo de Spawn
	public float currentTime;
	//Posicao do Objeto
	private int posicao;
	private float y;


	// Use this for initialization
	void Start () {
		currentTime = 0;	
	}
	
	// Update is called once per frame
	void Update () {
		currentTime += Time.deltaTime;
		if (currentTime >= rateSpawn) {
			currentTime = 0;
			posicao = Random.Range (1, 100);
			if (posicao > 50) {
				y = 0.843f;
			} else //caso a posicao seja <= a 50
			{
				y = 0.843f;
			}
			GameObject tempPrefab = Instantiate (barreiraPrefab) as GameObject;
			tempPrefab.transform.position = new Vector3 (transform.position.x, y, tempPrefab.transform.position.z);
		}
	}
}
