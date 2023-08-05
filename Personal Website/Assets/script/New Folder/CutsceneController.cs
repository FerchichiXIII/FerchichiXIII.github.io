using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class CutsceneController : MonoBehaviour
{
    public Camera MainCamera;
    public GameObject Player;
    public GameObject CutCamera;

    IEnumerator ActivateObjectAfterDelay(float delay)
    {
        yield return new WaitForSeconds(delay);

        Player.GetComponent<PlayerMovement>().enabled = true;
        gameObject.SetActive(false);
        CutCamera.SetActive(false);
        MainCamera.gameObject.SetActive(true);
        //    Time.timeScale = 1f;
    }
    private void Start()
    {
        StartCoroutine(ActivateObjectAfterDelay(5));
        Player.GetComponent<PlayerMovement>().enabled = false;


    }
}