﻿using System.Numerics;

namespace Shapes
{
    public class Rectangle : Shape2D
    {
        private readonly Vector2 _center;
        private readonly Vector2 _size;

        public Rectangle(Vector2 center, Vector2 size)
        {
            _center = center;
            _size = size;
        }

        public Rectangle(Vector2 center, float width)
        {
            _center = center;
            _size = new Vector2(width, width);
        }

        public override Vector3 Center => new Vector3(_center.X, _center.Y, 0);

        public override float Area => _size.X * _size.Y;

        public override float Circumference => _size.X * 2.00f + _size.Y * 2.00f;
        
        public override string ToString()
        {
            var measures = $"@({_center.X:0.00}, {_center.Y:0.00}): w = {_size.X:0.00}, h = {_size.Y:0.00}";

            return _size.X == _size.Y
                ? $"square {measures}"
                : $"rectangle {measures}";
        }
    }
}