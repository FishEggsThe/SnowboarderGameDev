using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDetector : MonoBehaviour
{
    [SerializeField] float loadDelay = 3f;
    [SerializeField] ParticleSystem crashEffect;
    [SerializeField] AudioClip crashSFX;
    bool alive = true;

    void OnTriggerEnter2D(Collider2D other) {
        if(other.tag == "Ground" && alive){
            FindObjectOfType<PlayerController>().DisableControls();
            Debug.Log("FUCK OW");
            crashEffect.Play();
            GetComponent<AudioSource>().PlayOneShot(crashSFX);
            Invoke("ReloadScene", loadDelay);
            alive = false;
        }
    }

    public void ReloadScene()
    {
        SceneManager.LoadScene(0);

    }
}
