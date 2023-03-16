using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectionManager : MonoBehaviour
{
    //Materials
    public Material selectedMaterial;
    private Material originalMaterial;
    //Sound 
    public AudioClip audioClip;
    private AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        originalMaterial = gameObject.GetComponent<MeshRenderer>().material;
        audioSource = gameObject.AddComponent(typeof(AudioSource)) as AudioSource;
        audioSource.clip = audioClip;
    }
    public void PlayAydio()
    audioSource.Play();

    public void SetSelectedMaterial()
    {
        gameObject.GetComponent<MeshRenderer>().material = selectedMaterial;
    }
    public void SetOriginalMaterial()
    {
        gameObject.GetComponent<MeshRenderer>().material=originalMaterial;
    }
        
    
}
