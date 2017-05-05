using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class AutoLoadMainMenu : MonoBehaviour {
	void Start() {
		SceneManager.LoadSceneAsync("04 Main Menu", LoadSceneMode.Additive);
	}
}
