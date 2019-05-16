using Newtonsoft.Json.Linq;
using UnityEngine;

namespace Keiwando.Evolution.Scenes {

    public interface IStructureBuilder {
        void Build();
    }

    public static class StructureBuilderUtils {

        public static void Build(string prefabPath, Transform transform) {
            var position = transform.Position;
            var rotation = Quaternion.Euler(0, 0, transform.Rotation);
            var obj = GameObject.Instantiate(Resources.Load(prefabPath), position, rotation) as GameObject;
            obj.GetComponent<UnityEngine.Transform>().localScale = transform.Scale;
        }
    }
}