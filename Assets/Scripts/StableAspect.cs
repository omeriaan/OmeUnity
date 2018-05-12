using UnityEngine;

public class StableAspect : MonoBehaviour
{
    [SerializeField] 
    private Camera _camera;
    
    [SerializeField] 
    private float _width = 1280f;
    
    [SerializeField] 
    private float _height = 720f;
    
    [SerializeField] 
    private float _pixelParUnit = 100f;
    
    void Awake()
    {
        var aspect = ((float)Screen.height) / Screen.width;
        var bgAcpect = _height / _width;
        
        // カメラのOrthographicSizeを設定
        _camera.orthographicSize = _height / 2f / _pixelParUnit;

        if (bgAcpect > aspect)
        {
            // 倍率
            var bgScale = _height / Screen.height;
        
            // viewport rectの幅
            var camWidth = _width / (Screen.width * bgScale);
        
            // viewportRectを設定
            _camera.rect = new Rect((1f - camWidth) / 2f, 0f, camWidth, 1f);
        }
        else
        {
            // 倍率
            var bgScale = _width / Screen.width;
        
            // viewport rectの幅
            var camHeight = _height / (Screen.height * bgScale);
        
            // viewportRectを設定
            _camera.rect = new Rect(0f, (1f - camHeight) / 2f, 1f, camHeight);
        }
    }
}
