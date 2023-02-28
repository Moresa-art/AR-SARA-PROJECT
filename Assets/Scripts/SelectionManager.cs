using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectionManager : MonoBehaviour
{
    public Material selectedMaterial;
    private Material originalMaterial;
    // Start is called before the first frame update
    void Start()
    {
        originalMaterial = gameObject.GetComponent<MeshRenderer>().material;
    }

    public void SetSelectedMaterial()
    {
        gameObject.GetComponent<MeshRenderer>().material = selectedMaterial;
    }
    public void SetOriginalMaterial()
    {
        gameObject.GetComponent<MeshRenderer>().material=originalMaterial;
    }
        
    
}
