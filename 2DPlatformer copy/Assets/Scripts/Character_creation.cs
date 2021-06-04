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
        SpriteRenderer spriteRenderer = GetComponent<SpriteRenderer>();
        // Get the current material applied on the GameObject
        Material oldMaterial = spriteRenderer.material;
        Debug.Log("Applied Material: " + oldMaterial.name);
        // Set the new material on the GameObject
        spriteRenderer.material = SphereMaterial;
    }
}
