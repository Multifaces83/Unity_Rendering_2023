using UnityEngine;
using TMPro;
using UnityEngine.UI;
using System.Collections;

public class MaterialMenu : MonoBehaviour
{
    [SerializeField] private MaterialsList _scriptableObject;
    [SerializeField] private TextMeshProUGUI _titre;
    [SerializeField] private TextMeshProUGUI _description;
    [SerializeField] private Image _sprite;

    [SerializeField] public GameObject _menu;
    [SerializeField] private GameObject _contentParent;
    [SerializeField] private GameObject _contentPrefab;
    void Start()
    {
        //LoadScriptable(_scriptableObject);
        _menu.SetActive(false);
    }

    // private void LoadScriptable()
    // {
    //     for (int i = 0; i < _scriptableObject.materials.Length; i++)
    //     {
    //         string name = _scriptableObject.materials[i].name;
    //         string description = _scriptableObject.materials[i].description;
    //         Sprite image = _scriptableObject.materials[i].sprite;
    //         Material material = _scriptableObject.materials[i].material;

    //         GameObject prefabUi = Instantiate(_contentPrefab, _contentParent.transform);
    //         prefabUi.GetComponentInChildren<TextMeshProUGUI>().text = name;
    //         prefabUi.transform.GetChild(2).GetComponent<TextMeshProUGUI>().text = description;
    //         prefabUi.transform.GetChild(1).GetComponent<Image>().sprite = image;

    //         prefabUi.GetComponent<Button>().onClick.AddListener(() =>
    //         {
    //             Test(material.name);
    //         });
    //     }

    // }



    // public void LoadScriptable(MaterialsList scriptable)
    // {
    //     //_menu.SetActive(true);
    //     StartCoroutine(LoadScriptableCoroutine(scriptable));
    // }
    // private IEnumerator LoadScriptableCoroutine(MaterialsList scriptable)
    // {
    //     for (int i = 0; i < scriptable.materials.Length; i++)
    //     {
    //         string name = scriptable.materials[i].name;
    //         string description = scriptable.materials[i].description;
    //         Sprite image = scriptable.materials[i].sprite;
    //         Material material = scriptable.materials[i].material;

    //         GameObject prefabUi = Instantiate(_contentPrefab, _contentParent.transform);
    //         prefabUi.GetComponentInChildren<TextMeshProUGUI>().text = name;
    //         prefabUi.transform.GetChild(2).GetComponent<TextMeshProUGUI>().text = description;
    //         prefabUi.transform.GetChild(1).GetComponent<Image>().sprite = image;

    //         prefabUi.GetComponent<Button>().onClick.AddListener(() =>
    //         {
    //             Test(material.name);
    //         });
    //         yield return null;
    //     }


    // }

    public void LoadScriptable(MaterialsList scriptable)
    {
        for (int i = 0; i < scriptable.materials.Length; i++)
        {
            string name = scriptable.materials[i].name;
            string description = scriptable.materials[i].description;
            Sprite image = scriptable.materials[i].sprite;
            Material material = scriptable.materials[i].material;

            GameObject prefabUi = Instantiate(_contentPrefab, _contentParent.transform);
            prefabUi.GetComponentInChildren<TextMeshProUGUI>().text = name;
            prefabUi.transform.GetChild(2).GetComponent<TextMeshProUGUI>().text = description;
            prefabUi.transform.GetChild(1).GetComponent<Image>().sprite = image;

            prefabUi.GetComponent<Button>().onClick.AddListener(() =>
            {
                Test(material.name);
            });
        }
    }

    private void Test(string text)
    {
        Debug.Log(text);
    }
}
