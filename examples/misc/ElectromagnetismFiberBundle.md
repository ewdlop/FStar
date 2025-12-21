# Electromagnetism in Terms of Fiber Bundles

This module demonstrates a formalization of electromagnetic theory using the mathematical framework of fiber bundles, implemented in F* using the optional monad.

## Mathematical Background

### Fiber Bundles

A fiber bundle is a mathematical structure consisting of:
- **Base space**: In our case, spacetime (4-dimensional manifold with coordinates x, y, z, t)
- **Fiber**: U(1) gauge group (complex numbers of unit magnitude, represented by phases)
- **Total space**: The product of base space and fiber
- **Projection**: Maps total space back to base space

### Electromagnetism as a U(1) Bundle

Classical electromagnetism can be elegantly formulated as a principal U(1) bundle:

1. **Connection (Vector Potential)**: The electromagnetic potential A_μ = (A_x, A_y, A_z, φ) defines a connection on the bundle, telling us how to parallel transport gauge group elements along curves in spacetime.

2. **Curvature (Field Strength)**: The electromagnetic field tensor F_μν is the curvature of this connection, computed as:
   - F_μν = ∂_μA_ν - ∂_νA_μ
   - This gives us the electric field E and magnetic field B

3. **Gauge Transformations**: Local U(1) transformations that change the vector potential:
   - A_μ → A_μ + ∂_μθ
   - The field strength F_μν remains invariant under these transformations

4. **Maxwell Equations**: 
   - Homogeneous equations (dF = 0) follow from the Bianchi identity
   - Inhomogeneous equations (d⋆F = J) involve sources

## Module Structure

### Types

- `spacetime`: 4D spacetime coordinates (x, y, z, t)
- `vector_potential`: The four-component electromagnetic potential A_μ
- `em_field`: Electric and magnetic field components (E_x, E_y, E_z, B_x, B_y, B_z)
- `u1_element`: Elements of the U(1) gauge group (represented by phases)
- `gauge_param`: Parameters for gauge transformations

### Core Functions

#### Gauge Operations
- `u1_identity`: Identity element of U(1)
- `u1_mult`: Group multiplication in U(1)
- `u1_inverse`: Group inverse in U(1)

#### Bundle Structure
- `local_chart`: Local trivialization (returns `None` for undefined regions)
- `connection_form`: Type for electromagnetic potential as a connection
- `curvature_form`: Type for electromagnetic field as curvature

#### Physical Operations
- `gauge_transform`: Apply gauge transformation to vector potential
- `field_from_potential`: Compute field strength from potential (F from A)
- `parallel_transport`: Transport gauge elements along paths using the connection
- `holonomy`: Compute phase acquired around closed loops (relates to magnetic flux)

#### Field Equations
- `bianchi_identity`: Homogeneous Maxwell equations (∇·B = 0, ∇×E + ∂B/∂t = 0)
- `source_equation`: Inhomogeneous Maxwell equations (∇·E = ρ, ∇×B - ∂E/∂t = J)

### Optional Monad Usage

The optional monad (`option` type) is used throughout to handle:

1. **Partial functions**: Local charts are only defined on certain regions (e.g., excluding singularities)
2. **Gauge ambiguity**: Multiple valid gauge choices for the same physical configuration
3. **Computational safety**: Ensures proper handling of undefined operations

The monad operators used:
- `let?`: Monadic bind for option type
- `and?`: Combining multiple optional values

## Examples

The module includes several examples:

1. **Constant field configuration**: Uniform electromagnetic field in the z-direction
2. **Gauge invariance check**: Verifies that field strength is independent of gauge choice
3. **Parallel transport**: Moving gauge group elements along spacetime paths
4. **Holonomy computation**: Computing the Berry phase around closed loops

## Physical Interpretation

This formalization captures several deep physical insights:

1. **Gauge invariance is geometric**: The freedom in choosing A_μ corresponds to choosing different trivializations of the bundle

2. **Fields are intrinsic**: F_μν is gauge-invariant because it's the curvature, which is a geometric property of the bundle

3. **Aharonov-Bohm effect**: The holonomy captures the quantum mechanical phase shift that depends on the vector potential, not just the field

4. **Quantization**: The U(1) bundle structure naturally leads to charge quantization (though not shown in this simplified version)

## Connection to Quantum Field Theory

This classical formulation extends naturally to quantum electrodynamics (QED):
- Wave functions become sections of the bundle
- The covariant derivative acts on these sections
- Gauge transformations act unitarily on quantum states

## Further Reading

- Nakahara, M. "Geometry, Topology and Physics" - Comprehensive introduction to fiber bundles in physics
- Baez, J. & Muniain, J.P. "Gauge Fields, Knots and Gravity" - Accessible introduction to gauge theory
- Frankel, T. "The Geometry of Physics" - Mathematical physics perspective
