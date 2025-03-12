using BulletAction;
using Sprites;
using UnityEngine;

namespace UI
{
    public enum CaseType
    {
        Heaven,
        Hell
    }
    
    public class DecisionMake : MonoBehaviour
    {
        [SerializeField] private GameObject _victimChangeSpriteScript;
        [SerializeField] private GameObject _memoryBullets;
        [SerializeField] private GameObject _caseResultGameObject;
        [SerializeField] private GameObject _lowerPanel;
        
        private ChangeSprite _victimChangeSprite;
        private CaseResult _caseResult;
        private CaseType _caseResultType;
        private string _memoryBulletRemainCount;

        private void Awake()
        {
            _victimChangeSprite = _victimChangeSpriteScript.GetComponent<ChangeSprite>();
            _caseResult = _caseResultGameObject.GetComponent<CaseResult>();

            HeavenBulet.OnHeavenBulletUsed += HandleHeavenBullet;
            HellBullet.OnHellBulletUsed += HandleHellBullet;
        }

        private void HandleHeavenBullet()
        {
            HandleDecisionState(CaseType.Heaven);
            _victimChangeSprite.HeavenBulletChangeSprite();
            
            ViewCaseResult();
        }

        private void HandleMemoryBullet()
        {
            //_victimChangeSprite.MemoryBulletChangeSprite();
        }
        
        private void HandleHellBullet()
        {
            HandleDecisionState(CaseType.Hell);
            _victimChangeSprite.HellBulletChangeSprite();
            
            ViewCaseResult();
        }

        private void HandleDecisionState(CaseType caseType)
        {
            _caseResultType = caseType;

            var memoryCountControll = _memoryBullets.GetComponent<MemoryCountControll>();
            _memoryBulletRemainCount = $"{memoryCountControll.CurrentMemoryBulletCount}";
        }

        private void ViewCaseResult()
        {
            _caseResultGameObject.SetActive(true);
            Unsubscribe();

            var time = 5f;
            
            while (time > 0)
            {
                time -= Time.deltaTime;
            }

            CaseResultGive();
        }
        
        private void CaseResultGive()
        {
            _lowerPanel.SetActive(false);
            _caseResult.SetCaseResult(this._memoryBulletRemainCount, _caseResultType.ToString());
        }
        
        private void Unsubscribe()
        {
            HeavenBulet.OnHeavenBulletUsed -= HandleHeavenBullet;
            HellBullet.OnHellBulletUsed -= HandleHellBullet;
        }
    }
}

