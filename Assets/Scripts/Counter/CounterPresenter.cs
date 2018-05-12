using UniRx;
using UnityEngine;

namespace Counter
{
    public class CounterPresenter : MonoBehaviour
    {
        // View
        [SerializeField] 
        private CounterView _view;
        
        // Model
        private CounterModel _counterModel;
        
        // 初期化
        public void Initialize()
        {
            // Modelの生成
            _counterModel = new CounterModel();
            
            _view.Initialize();
            
            Bind();
            SetEvents();
        }
        
        // Modelの値の変更を監視する
        private void Bind()
        {
            // ModelのCountの値が変わった際に、Viewを更新する
            _counterModel.CountProperty
                .Subscribe(_view.OnCountChanged)
                .AddTo(gameObject);
        }
        
        // Viewのイベント設定を行う
        private void SetEvents()
        {
            _view.OnIncrementButtonClickedCallBack = OnIncrementButtonClicked;
            _view.OnDecrementButtonClickedCallBack = OnDecrementButtonClicked;
            _view.OnResetButtonClickedCallBack = OnResetButtonClicked;
            
        }
        
        // Incrementボタンが押された時に呼ばれる
        private void OnIncrementButtonClicked()
        {
            _counterModel.Increment();
        }
        
        // Decrementボタンが押された時に呼ばれる
        private void OnDecrementButtonClicked()
        {
            _counterModel.Decrement();
        }
        
        // Resetボタンが押された時に呼ばれる
        private void OnResetButtonClicked()
        {
            _counterModel.Reset();
        }

        void Start()
        {
            Initialize();
        }
    }
}