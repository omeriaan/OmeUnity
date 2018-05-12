using UnityEngine;
using UnityEngine.UI;

namespace Counter
{
    public class CounterView : MonoBehaviour
    {
        // カウント値のテキスト
        [SerializeField] 
        private Text _countText;
        
        // 増値Button
        [SerializeField] 
        private Button _incrementButton;
        
        // 減値Button
        [SerializeField] 
        private Button _decrementButton;
        
        // リセットボタン
        [SerializeField] 
        private Button _resetButton;

        // 増値ボタンが押されたときのコールバック
        public System.Action OnIncrementButtonClickedCallBack;
        
        // 増値ボタンが押されたときのコールバック
        public System.Action OnDecrementButtonClickedCallBack;

        // リセットボタンが押されたときのコールバック
        public System.Action OnResetButtonClickedCallBack;
        
        // 初期化
        public void Initialize()
        {
            _incrementButton.onClick.AddListener(OnIncrementButtonClicked);
            _decrementButton.onClick.AddListener(OnDecrementButtonClicked);
            _resetButton.onClick.AddListener(OnResetButtonClicked);
        }
        
        // Countの値が変更されたときに呼ばれる
        public void OnCountChanged(int count)
        {
            _countText.text = count.ToString();
        }
        
        // 増値ボタンが押されたときに呼ばれる
        public void OnIncrementButtonClicked()
        {
            if (OnIncrementButtonClickedCallBack != null)
            {
                OnIncrementButtonClickedCallBack();
            }
        }
        
        // 減値ボタンが押されたときに呼ばれる
        public void OnDecrementButtonClicked()
        {
            if (OnDecrementButtonClickedCallBack != null)
            {
                OnDecrementButtonClickedCallBack();
            }
        }
        
        // リセットボタンが押されたときに呼ばれる
        public void OnResetButtonClicked()
        {
            if (OnResetButtonClickedCallBack != null)
            {
                OnResetButtonClickedCallBack();
            }
        }
    }
}
