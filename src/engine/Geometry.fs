// SPDX-License-Identifier: AGPL-3.0-or-later
// Gazelle: a fast, cross-platform engine for structural analysis & design.
// Copyright (C) 2024 James S. Bayley

namespace Gazelle.Geometry

/// <summary>
/// Orthogonal geometric axis.
/// </summary>
type Axis =
  | X
  | Y

/// <summary>
/// Orthogonal axis about which rotation occurs.
/// </summary>
type RotationalAxis =
  | XX
  | YY

/// <summary>
/// Length dimension annotated with unit-of-measure.
/// </summary>
type Length<[<Measure>] 'T> = Length of float<'T>

/// <summary>
/// Width dimension annotated with unit-of-measure.
/// </summary>
type Width<[<Measure>] 'T> = Width of float<'T>

/// <summary>
/// Depth dimension annotated with unit-of-measure.
/// </summary>
type Depth<[<Measure>] 'T> = Depth of float<'T>

/// <summary>
/// Diameter dimension annotated with unit-of-measure.
/// </summary>
type Diameter<[<Measure>] 'T> = Diameter of float<'T>

/// <summary>
/// Perimeter dimension annotated with unit-of-measure.
/// </summary>
type Perimeter<[<Measure>] 'T> = Perimeter of float<'T>

/// <summary>
/// Area dimension annotated with unit-of-measure.
/// Union type represents possible area semantics.
/// </summary>
type Area<[<Measure>] 'T> =
  | CrossSectionalArea of float<'T^2>
  | SurfaceArea of float<'T^2>

/// <summary>
/// Volume dimension annotated with unit-of-measure.
/// </summary>
type Volume<[<Measure>] 'T> = Volume of float<'T^3>

/// <summary>
/// Second moment of area dimension annotated with unit-of-measure.
/// </summary>
type SecondMomentOfArea<[<Measure>] 'T> = SecondMomentOfArea of float<'T^4>
