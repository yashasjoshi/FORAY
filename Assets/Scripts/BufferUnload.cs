using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class BufferUnload : MonoBehaviour {
	void Start(){
		SceneManager.LoadSceneAsync ("Level 1");
	}

	void Update(){
		SceneManager.UnloadSceneAsync ("08 Buffer");
	}
}
