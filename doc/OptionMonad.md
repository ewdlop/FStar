# Optional Monad Implementation for F*

## Overview

This document describes the implementation of a typeclass-based monad abstraction for the `option` type in F*.

## Motivation

F* already has monadic let bindings (`let?`, `and?`) for the option type, but lacked a general typeclass-based monad abstraction that could:
- Be used across different monadic types
- Provide formal proofs of monad laws
- Support generic monadic programming patterns
- Enable typeclass-based polymorphism over monadic operations

## Implementation

### 1. FStar.Class.Monad Module

Created `ulib/FStar.Class.Monad.fst` which provides:

#### Monad Laws Type
```fstar
type monad_laws (m:Type0 -> Type0) 
                (return : (#a:_ -> a -> m a)) 
                (bind : (#a:_ -> #b:_ -> m a -> (a -> m b) -> m b)) = {
  idL    : #a:_ -> #b:_ -> x:a -> f:(a -> m b) -> 
           Lemma (bind (return x) f == f x);
  idR    : #a:_ -> x:m a -> 
           Lemma (bind x return == x);
  assoc  : #a:_ -> #b:_ -> #c:_ -> x:m a -> f:(a -> m b) -> g:(b -> m c) ->
           Lemma (bind (bind x f) g == bind x (fun y -> bind (f y) g));
}
```

The three monad laws are:
1. **Left Identity**: `return a >>= f ≡ f a`
2. **Right Identity**: `m >>= return ≡ m`
3. **Associativity**: `(m >>= f) >>= g ≡ m >>= (λx → f x >>= g)`

#### Monad Typeclass
```fstar
class monad (m : Type0 -> Type0) = {
  [@@ tcmethod]
  return : #a:_ -> a -> m a;
  [@@ tcmethod]
  bind   : #a:_ -> #b:_ -> m a -> (a -> m b) -> m b;
  [@@ no_method]
  laws   : monad_laws m return bind;
}
```

Features:
- Uses F*'s typeclass system (`FStar.Tactics.Typeclasses`)
- `return` and `bind` are marked as `tcmethod` for typeclass resolution
- `laws` are marked with `no_method` to prevent method generation
- Includes formal proofs that the implementation satisfies monad laws

#### Infix Operators
```fstar
let op_Greater_Greater_Equals (#m:Type0 -> Type0) {| monad m |} 
                               (#a:_) (#b:_) (x : m a) (f : a -> m b) : m b =
  bind x f

let op_Greater_Greater (#m:Type0 -> Type0) {| monad m |} 
                        (#a:_) (#b:_) (x : m a) (y : m b) : m b =
  bind x (fun _ -> y)
```

Provides:
- `>>=` operator for bind
- `>>` operator for sequencing (ignoring the first result)

### 2. FStar.Option Extension

Extended `ulib/FStar.Option.fst` with:

#### Monad Operations
```fstar
let return_option (#a:Type) (x:a) : option a = Some x

let bind_option (#a:Type) (#b:Type) (x:option a) (f:a -> option b) : option b =
  match x with
  | Some x -> f x
  | None -> None
```

#### Monad Law Proofs
```fstar
let option_law_idL (#a:Type) (#b:Type) (x:a) (f:a -> option b) 
  : Lemma (bind_option (return_option x) f == f x) = ()

let option_law_idR (#a:Type) (x:option a) 
  : Lemma (bind_option x return_option == x) = ...

let option_law_assoc (#a:Type) (#b:Type) (#c:Type) 
                      (x:option a) (f:a -> option b) (g:b -> option c)
  : Lemma (bind_option (bind_option x f) g == 
           bind_option x (fun y -> bind_option (f y) g)) = ...
```

#### Monad Instance
```fstar
instance monad_option : monad option = {
  return = return_option;
  bind = bind_option;
  laws = {
    idL = option_law_idL;
    idR = option_law_idR;
    assoc = option_law_assoc;
  };
}
```

### 3. Test Suite

Created `tests/micro-benchmarks/Test.OptionMonad.fst` with tests for:

1. **Basic Operations**:
   - `return` operation
   - `bind` operation
   - Infix operators (`>>=`, `>>`)

2. **Chaining**:
   - Multiple bind operations
   - Nested monadic computations

3. **None Propagation**:
   - Verify that `None` correctly short-circuits computation

4. **Compatibility**:
   - Existing `let?` syntax still works
   - Integration with existing option operations

## Design Decisions

### Minimal Changes
- Only added new functionality, no modifications to existing code
- Preserved all existing FStar.Option behavior
- New monad operations are additive

### Typeclass Approach
- Follows F*'s typeclass conventions
- Uses `FStar.Tactics.Typeclasses` infrastructure
- Compatible with existing typeclass-based code

### Proof-Carrying
- All monad instances must provide proofs of monad laws
- Ensures type-safe, verified monadic operations
- Prevents invalid monad implementations at compile time

## Usage Examples

### Using the Typeclass
```fstar
open FStar.Class.Monad
open FStar.Option

let example : option int =
  return #option 5 >>= (fun x ->
  return #option 10 >>= (fun y ->
  return #option (x + y)))
```

### Generic Monadic Functions
```fstar
let sequence_two (#m:Type0 -> Type0) {| monad m |} 
                 (#a:_) (#b:_) (x : m a) (y : m b) : m b =
  x >> y

let map (#m:Type0 -> Type0) {| monad m |} 
        (#a:_) (#b:_) (f : a -> b) (x : m a) : m b =
  x >>= (fun v -> return (f v))
```

## Future Extensions

This foundation enables:
1. Additional monad instances (list, state, reader, etc.)
2. Monad transformers
3. Generic monadic combinators
4. Functor and Applicative typeclasses
5. Do-notation expansion using the typeclass system

## Compatibility

- **Backward Compatible**: All existing FStar.Option code continues to work
- **Coexistence**: The `let?` syntax and typeclass-based approach can be used together
- **No Breaking Changes**: Pure additive implementation

## References

- [F* Typeclass Documentation](https://github.com/FStarLang/FStar/wiki)
- [Monadic Let Bindings in F*](https://github.com/FStarLang/FStar/blob/master/examples/misc/MonadicLetBindings.fst)
- [Category Theory for Programmers](https://bartoszmilewski.com/2014/10/28/category-theory-for-programmers-the-preface/)
