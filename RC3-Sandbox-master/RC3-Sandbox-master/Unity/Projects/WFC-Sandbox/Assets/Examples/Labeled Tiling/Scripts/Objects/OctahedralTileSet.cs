﻿
/*
 * Notes
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using RC3.WFC;

namespace RC3.Unity.Examples.LabeledTiling
{
    /// <summary>
    /// 
    /// </summary>
    [CreateAssetMenu(menuName = "RC3/Examples/Labeled Tiling/OctahedralTileset")]
    public class OctahedralTileSet : TileSet
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        protected override TileSet<string> InitTileSet()
        {
            return TileSet<string>.CreateTruncatedOctahedral(Count);
        }
    }
}
