using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

using SpatialSlur.Core;


namespace RC3.Unity.TetrahedralGrowth
{
    
    /// <summary>
    /// 
    /// </summary>
    public class ConstantField3d : ScalarField3d
    {

        [SerializeField] private double _value;
        float n;
        public Image length;

        private void Start()
        {
            length.fillAmount = 0;
        }

        
        /// <summary>
        /// 
        /// </summary>
        public override double Evaluate(Vec3d point)
        {
            n = Random.Range(0.5f, 1.5f);
            _value = n;
            return _value;
        }

        private void Update()
        {
            length.fillAmount = Mathf.Clamp(n, 0.5f, 1.5f);
        }
    }
}
