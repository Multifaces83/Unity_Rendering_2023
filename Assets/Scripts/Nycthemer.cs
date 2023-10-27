using UnityEngine;

public class Nycthemer : MonoBehaviour
{
    [SerializeField] private GameObject _directionalLight;
    [SerializeField] private Material _nightSkybox;
    [SerializeField] private Material _daySkybox;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.N))
        {
            if (_directionalLight.GetComponent<Light>().color == new Color(1f, 1f, 1f))
            {
                Night();
            }
            else
            {
                Day();
            }
        }
    }

    private void Day()
    {
        Color color = new Color(1f, 1f, 1f);
        RenderSettings.skybox = _daySkybox;
        //lighting environnement intensity
        RenderSettings.ambientIntensity = 1f;
        _directionalLight.GetComponent<Light>().color = color;
    }

    private void Night()
    {
        Color color = new Color(0.1f, 0.1f, 0.1f);
        RenderSettings.skybox = _nightSkybox;
        //lighting environnement intensity
        RenderSettings.ambientIntensity = 0.2f;
        _directionalLight.GetComponent<Light>().color = color;
        _directionalLight.GetComponent<Light>().intensity = 0.1f;
    }
}
