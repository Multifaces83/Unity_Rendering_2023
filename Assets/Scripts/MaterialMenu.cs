using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class MaterialMenu : MonoBehaviour
{
    [SerializeField] private MaterialsList _scriptableObject;
    [SerializeField] private TextMeshProUGUI _titre;
    [SerializeField] private TextMeshProUGUI _description;
    [SerializeField] private Image _sprite;

    [SerializeField] private GameObject _contentParent;
    [SerializeField] private GameObject _contentPrefab;
    void Start()
    {
        LoadScriptable();
    }

    private void LoadScriptable()
    {
        for (int i = 0; i < _scriptableObject.materials.Length; i++)
        {
            string name = _scriptableObject.materials[i].name;
            string description = _scriptableObject.materials[i].description;
            Sprite image = _scriptableObject.materials[i].sprite;
            Material material = _scriptableObject.materials[i].material;

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
