using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Level
{
    public class Starter : MonoBehaviour
    {
        private GeneratorLevelController generatorLevelController;
        [SerializeField] private GenerateLevelView generateLevelView;
        void Awake()
        {
            generatorLevelController = new GeneratorLevelController(generateLevelView);
            generatorLevelController.Init();
        }
    }
}
