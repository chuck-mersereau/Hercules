using ShadowCoder.Extensions;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ShadowCoder.Hercules.Testing
{
    public class DataTestManager : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }

        public void OnRunTestsClick()
        {
            RunTests();
        }

        public void RunTests()
        {
            Debug.Log($"{this.LogPrefix()}");
        }
    }
}