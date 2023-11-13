using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptableGroup : MonoBehaviour
{
    [SerializeField] private MaterialsList _scriptableObjectMaterials;

    public MaterialsList GetScriptableObject()
    {
        return _scriptableObjectMaterials;
    }
}