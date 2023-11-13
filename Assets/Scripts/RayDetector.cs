
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class RayDetector : MonoBehaviour
{
    [SerializeField] private Image _reticule;
    public bool popMenu = false;
    [SerializeField] private TextMeshProUGUI _alertTextKeyMenu;

    [SerializeField] private MaterialMenu _materialMenu;

    void Start()
    {
        _alertTextKeyMenu.gameObject.SetActive(false);
    }

    private void Update()
    {
        UseTarget(FindUsableTarget());

    }

    private IUsableObject FindUsableTarget()
    {
        RaycastHit hit;
        if (Physics.Raycast(Camera.main.transform.position, Camera.main.transform.forward, out hit))
        {
            //Debug.Log(hit.collider.name);
            if (hit.collider.GetComponent<IUsableObject>() != null)
            {
                _reticule.color = Color.green;
                //Debug.Log("IUsableObject");

                if (hit.collider.GetComponent<ScriptableGroup>() != null)
                {
                    //Debug.Log("ScriptableGroup");
                    _alertTextKeyMenu.gameObject.SetActive(true);

                    if (Input.GetKeyDown(KeyCode.E))
                    {
                        hit.collider.GetComponent<ScriptableGroup>().GetScriptableObject();
                        _materialMenu.LoadScriptable(hit.collider.GetComponent<ScriptableGroup>().GetScriptableObject());
                        _materialMenu._menu.SetActive(true);
                    }
                }
                else
                {
                    //Debug.Log("No ScriptableGroup");
                }


                return hit.collider.GetComponent<IUsableObject>();
            }
            else
            {
                _reticule.color = Color.white;
                _alertTextKeyMenu.gameObject.SetActive(false);
                _materialMenu._menu.SetActive(false);
            }
        }
        else
        {
            _reticule.color = Color.white;
            //_alertTextKeyMenu.gameObject.SetActive(false);
        }
        return null;
    }


    private void UseTarget(IUsableObject usableObject)
    {
        if (Input.GetKeyDown(KeyCode.E) && usableObject != null)
        {
            usableObject.UseObject();
        }

    }
}