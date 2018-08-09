﻿/*
* Copyright (c) Incago Studio
* http://www.incagostudio.com/
*/

using System;

namespace DoonaLegend
{
    [Serializable]
    public class BlockModel
    {
        public int blockId;
        public BlockCategory blockCategory;
        public BlockType blockType;
        public Direction direction;
        public Node origin;
        public int progress;

        public BlockModel(int blockId, BlockCategory blockCategory, BlockType blockType, Direction direction, Node origin, int progress)
        {
            this.blockId = blockId;
            this.blockCategory = blockCategory;
            this.blockType = blockType;
            this.direction = direction;
            this.origin = origin;
            this.progress = progress;
        }
    }

    public enum BlockCategory
    {
        straight = 0, corner = 1, shortcut_start = 2, shortcut_end = 3, corner_edge = 4, straight_edge = 5
    }

    public enum BlockType
    {
        basic_straight = 0,
        basic_corner = 1,
        water = 2,
        cracked = 3,
        ice = 4 //위에 올라오면
    }
}