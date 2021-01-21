[![NuGet](https://img.shields.io/nuget/v/Tonnes.QuadTreeF.MonoGame?color=blue)](https://www.nuget.org/packages/Tonnes.QuadTreeF.MonoGame/)

# QuadTreeF.MonoGame

MonoGame compatibility layer for [QuadTreeF](https://github.com/tonnesr/QuadTreeF)

## Extensions

```c#

  // From Tonnes.QuadTreeF.RectangleF To Microsoft.Xna.Framework.Rectangle
  Rectangle ToRectangle(this RectangleF rect);
  
  // From Tonnes.QuadTreeF.PointF To Microsoft.Xna.Framework.Point
  Point ToPoint(this PointF point);
  
  // From Tonnes.QuadTreeF.PointF To Microsoft.Xna.Framework.Vector2
  Vector2 ToVector2(this PointF point);

  // From Microsoft.Xna.Framework.Point To Tonnes.QuadTreeF.PointF
  PointF ToPointF(this Point point);
  
  // From Microsoft.Xna.Framework.Vector2 To Tonnes.QuadTreeF.PointF
  PointF ToPointF(this Vector2 vector);

  // From Microsoft.Xna.Framework.Rectangle To Tonnes.QuadTreeF.RectangleF
  RectangleF ToRectangleF(this Rectangle rect);

  // QuadTree<T> extensions:
  void Add<T>(Point point, T value);
  void Add<T>(Vector2 point, T value);

  void Remove<T>(Point point);
  void Remove<T>(Vector2 point);

  bool Contains<T>(Point point);
  bool Contains<T>(Vector2 point);

  QuadNodeF<T> Search<T>(Point point);
  QuadNodeF<T> Search<T>(Vector2 point);
  bool Search<T>(Point point, out QuadNodeF<T> node);
  bool Search<T>(Vector2 point, out QuadNodeF<T> node);
  List<QuadNodeF<T>> Search<T>(Rectangle rectangle);

```

## Compatibility

Compatible with MonoGame dotnet core (netcoreapp3.1)
