//Authored by saban mete turkay demirkiran
//follow: https://github.com/sbmeteturkay

using UnityEngine;

namespace MeteTurkay{
	public class BaloonUnit : MonoBehaviour
	{
		public LineRenderer rope;

		public void SetRopeHolder(Vector3 position)
        {
			rope.SetPosition(0, transform.TransformPoint(position));
        }
	}
}
