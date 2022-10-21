//Authored by saban mete turkay demirkiran
//follow: https://github.com/sbmeteturkay

using UnityEngine;
using DG.Tweening;
namespace MeteTurkay{
	public class BaloonManager : MonoBehaviour
	{
		[SerializeField] GameObject baloonPrefab;
		[SerializeField] GameObject baloonParent;
		[SerializeField] Rigidbody baloonHolder;
		[SerializeField] DrawLines lineManager;
        private void Start()
        {
			InvokeRepeating(nameof(SpawnBaloon), 1f, 1f);
        }
        public void SpawnBaloon()
        {
			var obj = Instantiate(baloonPrefab,baloonParent.transform.position-Vector3.up,Quaternion.identity, baloonParent.transform);
			BaloonUnit baloonUnit = obj.GetComponent<BaloonUnit>();
			lineManager.AddItem(baloonUnit.ropePoint);
			baloonUnit.meshRenderer.material.color = Random.ColorHSV();
			//var joint = baloonHolder.gameObject.AddComponent<ConfigurableJoint>();
			//joint.connectedBody = obj.GetComponent<BaloonUnit>().rigidbody;
			//joint.axis = new Vector3(360, 360, 360);
			baloonUnit.joint.connectedBody = baloonHolder;
			//obj.GetComponent<BaloonUnit>().SetRopeHolder(baloonHolder.position);
			obj.transform.DOScale(1, 2f);
        }
	}
}
