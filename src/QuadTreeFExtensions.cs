using System.Collections.Generic;
using Microsoft.Xna.Framework;

namespace Tonnes.QuadTreeF.MonoGame
{
  public static class QuadTreeFExtensions {
    public static void Add<T>(this QuadTreeF<T> tree, Point point, T value) => tree.Add(point.X, point.Y, value);
    public static void Add<T>(this QuadTreeF<T> tree, Vector2 point, T value) => tree.Add(point.X, point.Y, value);

    public static void Remove<T>(this QuadTreeF<T> tree, Point point) => tree.Remove(point.X, point.Y);
    public static void Remove<T>(this QuadTreeF<T> tree, Vector2 point) => tree.Remove(point.X, point.Y);

    public static bool Contains<T>(this QuadTreeF<T> tree, Point point) => tree.Contains(point.X, point.Y);
    public static bool Contains<T>(this QuadTreeF<T> tree, Vector2 point) => tree.Contains(point.X, point.Y);

    public static QuadNodeF<T> Search<T>(this QuadTreeF<T> tree, Point point) => tree.Search(point.X, point.Y);
    public static QuadNodeF<T> Search<T>(this QuadTreeF<T> tree, Vector2 point) => tree.Search(point.X, point.Y);
    public static bool Search<T>(this QuadTreeF<T> tree, Point point, out QuadNodeF<T> node) => tree.Search(point.X, point.X, out node);
    public static bool Search<T>(this QuadTreeF<T> tree, Vector2 point, out QuadNodeF<T> node) => tree.Search(point.X, point.X, out node);
    public static List<QuadNodeF<T>> Search<T>(this QuadTreeF<T> tree, Rectangle rectangle) => tree.Search(rectangle.ToRectangleF());
  }
}