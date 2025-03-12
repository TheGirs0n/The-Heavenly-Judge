using TMPro;
using UnityEngine;

namespace UI
{
    public class CaseResult : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI _memoryBulletRemainCountText;
        [SerializeField] private TextMeshProUGUI _caseResultText;

        public void SetCaseResult(string memoryBulletRemain, string result)
        {
            _memoryBulletRemainCountText.text = $"Memory bullet remain\n{memoryBulletRemain}";
            _caseResultText.text = $"RESULT\n{result}";
        }
    }
}