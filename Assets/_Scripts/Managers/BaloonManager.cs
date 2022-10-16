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

		public void SpawnBaloon()
        {
			var obj = Instantiate(baloonPrefab,baloonParent.transform.position-Vector3.up,Quaternion.identity, baloonParent.transform);
			//obj.GetComponent<BaloonUnit>().SetRopeHolder(baloonHolder.position);
			obj.transform.DOScale(1, 1f);
        }
	}
}
