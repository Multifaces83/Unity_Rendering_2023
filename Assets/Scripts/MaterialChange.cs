using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaterialChange : MonoBehaviour, IUsableObject
{
    [SerializeField] private Material[] _materials;
    private MeshRenderer _renderer;
    private int _actualMaterial = -1;
    private void Start()
    {
        // _renderer = GetComponent<MeshRenderer>();
        // ChangeMaterial();
    }

    public void UseObject() { ChangeMaterial(); }

    private void ChangeMaterial()
    {
        // _actualMaterial++;
        // if (_actualMaterial >= _materials.Length)
        // {
        //     _actualMaterial = 0;
        // }
        // _renderer.material = _materials[_actualMaterial];
    }

}