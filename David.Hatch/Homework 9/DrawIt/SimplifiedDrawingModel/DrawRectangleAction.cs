﻿using System;
using System.Drawing;

namespace SimplifiedDrawingModel
{
    public class DrawRectangleAction : IDrawAction
    {
        private readonly Pen _pen;
        private readonly Brush _brush;
        private readonly Point _center;
        private readonly Point _heightWidth;
        private readonly bool _tflag;

        public DrawRectangleAction(Pen pen, int x, int y, int x2, int y2)
        {
            _pen = pen;
            _center = new Point(x, y);
            _heightWidth = new Point(x2, y2);
        }
        public DrawRectangleAction(Brush brush, int x, int y, int x2, int y2, bool tflag)
        {
           
            _brush = brush;
            _center = new Point(x, y);
            _heightWidth = new Point(x2, y2);
            _tflag = tflag;

        }
        

        public void DrawOn(Graphics graphics)
        {
            if (_tflag)
            {
                // this works for regular rectangle == graphics.DrawRectangle(_pen, _center.X, _center.Y, _heightWidth.X - _center.X, _heightWidth.Y - _center.Y);
                // reverse drag with abs function on width and height - and min for starting point (frkn genius's in the .net foundation class) 
                // no min it goes the wrong way == graphics.DrawRectangle(_pen, _center.X, _center.Y, Math.Abs(_heightWidth.X - _center.X), Math.Abs(_heightWidth.Y - _center.Y)); 
                //graphics.DrawRectangle(_pen, Math.Min(_center.X, _heightWidth.X), Math.Min(_center.Y, _heightWidth.Y), Math.Abs(_heightWidth.X - _center.X), Math.Abs(_heightWidth.Y - _center.Y));
                graphics.FillRectangle(_brush, Math.Min(_center.X, _heightWidth.X), Math.Min(_center.Y, _heightWidth.Y),
                                       Math.Abs(_heightWidth.X - _center.X), Math.Abs(_heightWidth.Y - _center.Y));
            }
            else
            {
                graphics.DrawRectangle(_pen, Math.Min(_center.X, _heightWidth.X), Math.Min(_center.Y, _heightWidth.Y),
                                       Math.Abs(_heightWidth.X - _center.X), Math.Abs(_heightWidth.Y - _center.Y));
            }
        }
    }
}