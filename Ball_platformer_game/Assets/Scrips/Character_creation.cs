using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character_creation : MonoBehaviour
{
    Material SphereMaterial;

    // Use this for initialization
    void Start()
    {
        SphereMaterial = Resources.Load<Material>("Materials/"+Global_variables.material.ToString());
        MeshRenderer meshRenderer = GetComponent<MeshRenderer>();
        // Get the current material applied on the GameObject
        Material oldMaterial = meshRenderer.material;
        Debug.Log("Applied Material: " + oldMaterial.name);
        // Set the new material on the GameObject
        meshRenderer.material = SphereMaterial;
    }
}
