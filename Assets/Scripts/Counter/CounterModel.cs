using UniRx;

namespace Counter
{
    public class CounterModel {
    
        // カウント
        private ReactiveProperty<int> _countProperty;

        public ReactiveProperty<int> CountProperty 
        {
            get { return _countProperty; }
        }

        public int Count
        {
            get { return CountProperty.Value; }
        }
        
        // コンストラクタ
        public CounterModel()
        {
            _countProperty = new ReactiveProperty<int>(0);
        }
    
        // プラス
        public void Increment()
        {
            SetCount(Count + 1);
        }
    
        // マイナス
        public void Decrement()
        {
            SetCount(UnityEngine.Mathf.Max(0, Count - 1));
        }
    
        // リセット
        public void Reset()
        {
            SetCount(0);
        }
    
        // Countの値を設定
        private void SetCount(int count)
        {
            _countProperty.Value = count;
        }  
    }
}