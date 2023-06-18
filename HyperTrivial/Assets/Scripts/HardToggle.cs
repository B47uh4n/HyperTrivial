using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace PathCreation.Examples
{
    public class HardToggle : MonoBehaviour
    {
        public Toggle selectedToggle;

        private void Start()
        {
            selectedToggle.onValueChanged.AddListener(delegate
            {
                ToggleValueChangedOccured(selectedToggle);
            });
        }

        void ToggleValueChangedOccured(Toggle tgValue)
        {
            Debug.Log("Your current toggle state is :" + tgValue.isOn);
            if (tgValue.isOn == true)
            {
                PathFollower.speedHard = 3;
            }
            else
            {
                PathFollower.speedHard = 1;
            }

        }
    }

}