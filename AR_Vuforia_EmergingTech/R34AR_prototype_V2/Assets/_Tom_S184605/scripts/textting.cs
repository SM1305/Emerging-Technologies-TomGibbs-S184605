using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

namespace Vuforia
{

    public class textting : MonoBehaviour
    {
        public Transform TestText;
        public Transform SteerButton;

        void Start()
        {
            SteerButton.gameObject.SetActive(false);
        }

        void Update()
        {
            SteerButton.gameObject.SetActive(false);

            StateManager sm = TrackerManager.Instance.GetStateManager();
            IEnumerable<TrackableBehaviour> tbs = sm.GetActiveTrackableBehaviours();
            foreach (TrackableBehaviour tb in tbs)
            {
                string name = tb.TrackableName;
                ImageTarget it = tb.Trackable as ImageTarget;

                //Evertime the target found it will show “TestText”
                SteerButton.gameObject.SetActive(true);
                TestText.gameObject.SetActive(true);
                
            }
        }

                
    }
}
