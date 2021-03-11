using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cutscene : MonoBehaviour
{
    public GameObject ThePlayer;
    public GameObject cutsceneCam;
    public GameObject CrystalShader;

    void OnTriggerEnter(Collider other)
    {
        this.gameObject.GetComponent<BoxCollider>().enabled = false;
        cutsceneCam.SetActive(true);
        ThePlayer.SetActive(false);
        StartCoroutine(FinishCut());
    }

    IEnumerator FinishCut()
    {
        yield return new WaitForSeconds(10);
        ThePlayer.SetActive(true);
        cutsceneCam.SetActive(false);
        RenderSettings.fog = true;
        RenderSettings.reflectionIntensity = 0.2f;
        //Destroy(CrystalShader);
        CrystalShader.SetActive(false);
    }
}
