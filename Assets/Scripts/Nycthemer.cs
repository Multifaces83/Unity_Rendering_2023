using UnityEngine;

public class Nycthemer : MonoBehaviour
{
    [Header("Day")]
    [SerializeField] private GameObject _directionalLightDay;
    [SerializeField] private GameObject[] _dayLights;

    [Header("Night")]
    [SerializeField] private GameObject _directionalLightNight;
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
            if (RenderSettings.skybox == _daySkybox)
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
        ActiveLights(_dayLights, true);
        _directionalLightNight.SetActive(false);
        Color color = new Color(1f, 1f, 1f);
        RenderSettings.skybox = _daySkybox;
        RenderSettings.ambientIntensity = 1f;
        _directionalLightDay.SetActive(true);
    }

    private void Night()
    {
        ActiveLights(_dayLights, false);
        _directionalLightDay.SetActive(false);
        Color color = new Color(0.1f, 0.1f, 0.1f);
        RenderSettings.skybox = _nightSkybox;
        RenderSettings.ambientIntensity = 0.2f;
        _directionalLightNight.SetActive(true);
        //_directionalLight.GetComponent<Light>().color = color;
        //_directionalLight.GetComponent<Light>().intensity = 0.1f;
    }

    private void ActiveLights(GameObject[] lights, bool active = true)
    {
        foreach (GameObject light in lights)
        {
            light.SetActive(active);
        }
    }
}
