using UnityEngine;

public class TapEffect : MonoBehaviour
{
    [SerializeField]　
    private ParticleSystem _tapEffect;    // タップエフェクト
    
    [SerializeField]　
    private Camera _camera;    // カメラの座標

    void Update()
    {
        if (!Input.GetMouseButtonDown(0)) 
            return;
        
        // マウスのワールド座標までパーティクルを移動し、パーティクルエフェクトを1つ生成する
        var pos = _camera.ScreenToWorldPoint(Input.mousePosition + _camera.transform.forward * 10);
        _tapEffect.transform.position = pos;
        _tapEffect.Emit(1);
    }
}
