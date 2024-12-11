using System;
using Cysharp.Threading.Tasks;
using UnityEngine;

namespace Xiyu
{
    public class GameTest : MonoBehaviour
    {
        [JetBrains.Annotations.UsedImplicitly]
        // ReSharper disable once Unity.IncorrectMethodSignature
        private async UniTaskVoid Start()
        {
            Debug.Log(Time.time);

            await UniTask.WaitForSeconds(1);

            Debug.Log(Time.time);
        }
        
        [SerializeField] private TMPro.TextMeshProUGUI fpsText;
        
        private float _time;
        private int _frameCount;


        private void Update()
        {
            _frameCount++;
            _time += Time.deltaTime;
            if(_time >= 1)
            {
                fpsText.text = $"FPS: {_frameCount}";
                _time = 0;
                _frameCount = 0;
            }
            
        }
    }
}