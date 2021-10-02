using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SoundController : MonoBehaviour {
    // Start is called before the first frame update
    public GameObject Xtext;
    void Start(){
         if(AudioListener.volume == 0) {
            Xtext.SetActive(true);
         }
        else{
            Xtext.SetActive(false);
        }                               
    }

	void Update (){
		
	}

    public void ChangeSound(){
        if (AudioListener.volume == 1){
            AudioListener.volume = 0;
            Xtext.SetActive(true);
        }
        else{
            AudioListener.volume = 1;
            Xtext.SetActive(false);
        }
    }
}
