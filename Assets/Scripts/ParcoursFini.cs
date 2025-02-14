using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ParcoursFini : MonoBehaviour
{
public void OnTriggerEnter () {
        StartCoroutine(Deconte());
    }

    public void OnTriggerExit () {
        StopAllCoroutines();
    }   

    private IEnumerator Deconte () {
        yield return new WaitForSeconds (5);
        SceneManager.LoadScene("ES1_Binette_Vincent");
    }
}
