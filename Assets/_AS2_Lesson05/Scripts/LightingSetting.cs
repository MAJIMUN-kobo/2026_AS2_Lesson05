using UnityEngine;

public class LightingSetting : MonoBehaviour
{
    // 
    [SerializeField] public Light DirectionalSunLight;       // 太陽の役割をするライト

    public float AmbientIntensity = 1.0f;


    void Start()
    {
        RenderSettings.ambientIntensity = AmbientIntensity;
    }


    void Update()
    {
        // 太陽（Directional Light）を回転させる
        DirectionalSunLight.transform.eulerAngles += Vector3.right * 2f * Time.deltaTime;

        // 毎フレーム光の設定を変え続ける
        RenderSettings.ambientIntensity = Mathf.Sin(Mathf.Abs(Time.time));

        RenderSettings.fog = true;
        RenderSettings.fogStartDistance = 1.0f;

        // 環境設定に反映させる
        DynamicGI.UpdateEnvironment();
    }
}
